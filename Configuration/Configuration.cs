﻿using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Autofac;
using MODEL;
using MODEL.Contracts;
using WFAttribute;
using WFException;

namespace Config
{
    public static class Configuration
    {

        #region Fields
        private static readonly string errorLogFileAddress = "ErrorLog.txt";
        private static long _productID = 0;

        #endregion

        #region Properties
        public static long ProductID { get => _productID; set => _productID = value; }
        public static ContainerBuilder CB { get;} = new();
        public static IContainer? Container { get; set; }
        #endregion

        #region Methods
        public static async Task WriteErrorLogAsync(Exception ex)
        {
            try
            {
                using (var fileStream = new FileStream(errorLogFileAddress, FileMode.Append, FileAccess.Write, FileShare.None))
                {
                    using (var sw = new StreamWriter(fileStream))
                    {
                        await sw.WriteLineAsync($"********** {DateTime.Now} **********");
                        if (ex.InnerException != null)
                        {
                            await sw.WriteAsync("Inner Exception Type: ");
                            await sw.WriteLineAsync(ex.InnerException.GetType().ToString());
                            await sw.WriteAsync("Inner Exception: ");
                            await sw.WriteLineAsync(ex.InnerException.Message);
                            await sw.WriteAsync("Inner Source: ");
                            await sw.WriteLineAsync(ex.InnerException.Source);
                            if (ex.InnerException.StackTrace != null)
                            {
                                await sw.WriteLineAsync("Inner Stack Trace: ");
                                await sw.WriteLineAsync(ex.InnerException.StackTrace);
                            }
                        }
                        await sw.WriteAsync("Exception Type: ");
                        await sw.WriteLineAsync(ex.GetType().ToString());
                        await sw.WriteLineAsync($"Exception: {ex.Message}");
                        await sw.WriteLineAsync($"Source: {ex.Source}");
                        await sw.WriteLineAsync("Stack Trace: ");
                        if (ex.StackTrace != null)
                        {
                            await sw.WriteLineAsync(ex.StackTrace);
                            await sw.WriteLineAsync();
                        }
                    }
                }
            }
            catch (IOException exception)
            {
                Debug.WriteLine(exception);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
        public static async Task<string> FillIDAsync(string? source, string startString, int idLength)
        {
            string template = source ?? throw new ArgumentNullException();
            var fillLength = idLength - startString.Length;
            while (template.Count() < fillLength)
            {
                template = "0" + template;
            }
            template = startString + template;

            return template;
        }
        public static async Task CheckValidInput(object? o)
        {
            try
            {
                if (o == null)
                    throw new ArgumentNullException();

                StringBuilder inputExceptionLog = new StringBuilder(String.Empty);
                foreach (var p in o.GetType().GetProperties())
                {
                    NameAttribute? nameAttribute = p.GetCustomAttribute<NameAttribute>();
                    if (nameAttribute is not null)
                    {
                        string? name = p.GetValue(o)?.ToString();
                        if (string.IsNullOrEmpty(name))
                            inputExceptionLog.Append("Name: is null\n");
                    }
                }

                if (inputExceptionLog.Length > 0)
                {
                    throw new WrongEntityInformationException(inputExceptionLog.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static T CreateObject<T>(DataRow row)
        {
            var result = Container.Resolve<T>();
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                if (row.Table.Columns.Contains(property.Name))
                {
                    property.SetValue(result, row[property.Name]);
                }
            }

            return result;
        }

        public static object? GetDefaultValue(Type type)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type));
            if (type.IsValueType)
            {
                return Activator.CreateInstance(type);
            }
            else if(type == typeof(string))
            {
                return string.Empty;
            }
            else
            {
                return null;
            }
        }

        public static string? GetCallerMethodName(object? o)
        {
            var currentObject = o as Exception;
            if (currentObject != null)
            {
                var caller = new StackTrace(currentObject, true).GetFrame(1)!.GetMethod();

                return caller?.Name;
            }
            return null;
        }

        public static bool IsReferenceType(Type type)
        {
            if (type is null)
                throw new ArgumentNullException(nameof(type));
            return !type.IsValueType || (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
        #endregion
    }
}
