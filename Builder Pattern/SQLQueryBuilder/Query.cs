using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueryBuilder
{
    public class Query
    {
        public string selectColumns { get; }
        public string tableName { get; }
        public string condition { get; }
        public string orderByColumn { get; }
        public bool isAscending { get; }
        public int? limit { get; }

        public Query(string selectColumns, string tableName, string condition = null, string orderByColumn = null, bool isAscending = true, int? limit = null)
        {
            this.selectColumns = selectColumns;
            this.tableName = tableName;
            this.condition = condition;
            this.orderByColumn = orderByColumn;
            this.isAscending = isAscending;
            this.limit = limit;
        }
        internal string ToSql()
        {
            var sb = new StringBuilder();
            sb.Append($"SELECT {selectColumns} FROM {tableName}");

            if (condition != null)
                sb.Append($" WHERE {condition}");

            if (orderByColumn != null)
                sb.Append($" ORDER BY {orderByColumn} {(isAscending ? "ASC" : "DESC")}");

            if (limit != null)
                sb.Append($" LIMIT {limit}");

            return sb.ToString();

        }
    }
}
