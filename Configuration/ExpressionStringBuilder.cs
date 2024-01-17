using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public static class ExpressionStringBuilder
    {
        public static (string, object[]?) ToSqlWhereWithParameters(this Expression? expression)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            var parameters = new List<object?>();
            var whereClause = Visit(expression, parameters);
            return (whereClause, parameters.ToArray());
        }
        public static string Visit(Expression expression, List<object?> parameters)
        {
            if (expression is null)
                return string.Empty;

            switch (expression.NodeType)
            {
                case ExpressionType.Lambda: //Expression
                    return Visit(((LambdaExpression)expression).Body, parameters);
                case ExpressionType.Equal:                    //Equals                                   
                    return GenerateLeftAndRightClause(expression, "=", parameters);
                case ExpressionType.NotEqual: //Not Equals
                    return GenerateLeftAndRightClause(expression, "!=", parameters);
                case ExpressionType.GreaterThan: //Greater Than
                    return GenerateLeftAndRightClause(expression, ">", parameters);
                case ExpressionType.GreaterThanOrEqual: //Greater Than Or Equal
                    return GenerateLeftAndRightClause(expression, ">=", parameters);
                case ExpressionType.LessThan: //Less Than
                    return GenerateLeftAndRightClause(expression, "<", parameters);
                case ExpressionType.LessThanOrEqual: //Less Than Or Equal
                    return GenerateLeftAndRightClause(expression, "<=", parameters);
                case ExpressionType.AndAlso: //And
                    return GenerateLeftAndRightClause(expression, "AND", parameters);
                case ExpressionType.OrElse: //Or
                    return GenerateLeftAndRightClause(expression, "OR", parameters);
                case ExpressionType.Not: //Not
                    var notExpression = (UnaryExpression)expression;
                    var operandNot = Visit(notExpression.Operand, parameters);
                    return $"NOT ({operandNot})";
                case ExpressionType.Constant: //Property Value
                    parameters.Add(((ConstantExpression)expression).Value);
                    return $"@p{parameters.Count - 1}";
                case ExpressionType.MemberAccess: //Property Name
                    return ((MemberExpression)expression).Member.Name;
                default:
                    throw new NotSupportedException($"Expression type {expression.NodeType} not supported");
            }
        }
        private static string GenerateLeftAndRightClause(this Expression expression, string? op, List<object?> parameters)
        {
            if (op is null)
                throw new ArgumentNullException(nameof(op));

            var binaryEqualExpression = (BinaryExpression)expression;
            var left = Visit(binaryEqualExpression.Left, parameters);
            var right = GetMemberAccessValue(binaryEqualExpression.Right, parameters);
            return $"{left} {op} {right}";
        }

        private static string GetMemberAccessValue(Expression expression, List<object?> parameters)
        {
            if (expression is null)
                throw new ArgumentNullException(nameof(expression));

            if (expression.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpression = (MemberExpression)expression;

                var memberValue = Expression.Lambda(memberExpression).Compile().DynamicInvoke();
              
                parameters.Add(memberValue);
                return $"@p{parameters.Count - 1}";
            }

            return Visit(expression, parameters);
        }
    }
}
