using Autofac;
using Microsoft.Extensions.Configuration;
using CONNECTIONS.Contracts;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace CONNECTIONS
{
    internal class MySQLConnection : ISQLConnection
    {
        private static Lazy<MySQLConnection?>? _instance;
        private MySqlConnection? _connection;

        public static MySQLConnection? Instance
        {
            get
            {
                CheckNullInstance();
                return _instance!.Value;
            }
        }

        static MySQLConnection()
        {
            CheckNullInstance();
        }
        private MySQLConnection()
        {
        }
        private static void CheckNullInstance()
        {
            _instance ??= new Lazy<MySQLConnection?>(() => new MySQLConnection());
        }
        private void CreateConnection()
        {
            var dir = new DirectoryInfo(Directory.GetCurrentDirectory())!.Parent!.Parent!.Parent!.Parent!.FullName;
            var builder = new ConfigurationBuilder()
                .AddJsonFile(dir + @"\CONNECTIONS\AppSettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            var connectionStrings = configuration?.GetSection("ConnectionStrings")?.Get<List<ConnectionString>>()?.FirstOrDefault(x => x.Name == "MySQL");
            _connection = new MySqlConnection(connectionStrings?.Value);
        }

        private void OpenConnection()
        {
            try
            {
                CreateConnection();
                _connection!.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CloseConnection()
        {
            try
            {
                _connection!.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Execute(string query, object[]? parameters)
        {
            try
            {
                OpenConnection();

                using (var cmd = new MySqlCommand(query, _connection))
                {
                    ReplaceKeyValue(parameters, cmd);
                    cmd.ExecuteScalar();
                }

                CloseConnection();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet LoadData(string query, object[]? parameters)
        {
            try
            {
                DataSet ds = new DataSet();
                OpenConnection();

                using (var cmd = new MySqlCommand(query, _connection))
                {
                    cmd.CommandType = CommandType.Text;
                    ReplaceKeyValue(parameters, cmd);

                    using var msda = new MySqlDataAdapter(cmd);
                    msda.Fill(ds);
                }

                CloseConnection();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet ExecuteSP(string spName, object[]? parameters)
        {
            try
            {
                var ds = new DataSet();
                OpenConnection();

                using (var cmd = new MySqlCommand(spName, _connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    ReplaceKeyValue(parameters, cmd);

                    using (MySqlDataAdapter msda = new MySqlDataAdapter(cmd))
                    {
                        msda.Fill(ds);
                    }
                }

                CloseConnection();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void ReplaceKeyValue(object[]? parameters, MySqlCommand cmd)
        {
            if (parameters is not null)
            {
                for (int i = 0; i < parameters.Length; ++i)
                {
                    cmd.Parameters.AddWithValue($"@p{i}", parameters[i]);
                }
            }
        }
    }
}
