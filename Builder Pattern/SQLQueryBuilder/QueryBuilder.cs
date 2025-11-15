using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueryBuilder
{
    public class QueryBuilder : ISelectStage, IFromStage, IWhereStage,IOrderStage, ILimitStage, IBuildStage
    {
        private Query query;
        private string _columns;
        private string _table;
        private string _condition;
        private string _orderByColumn;
        private bool _isAscending;
        private int? _limit;

        public Query Build()
        {
            query = new Query(_columns, _table, _condition, _orderByColumn, _isAscending, _limit);
            return query;
        }

        public IWhereStage From(string table)
        {
            if(table == null || table.Trim() == "")
            {
                throw new ArgumentException("Table name cannot be null or empty");
            }
            _table = table;
            return this;
        }

        public IBuildStage Limit(int rowCount)
        {
            if(rowCount <= 0)
            {
                throw new ArgumentException("Row count must be greater than zero");
            }
            _limit = rowCount;
            return this;
        }

        public IOrderStage Where(string condition)
        {
            if(string.IsNullOrWhiteSpace(condition))
            {
                throw new ArgumentException("Condition cannot be null or empty");
            }
            _condition = condition;
            return this;
        }

        public ILimitStage OrderBy(string column, bool ascending = true)
        {
            if(string.IsNullOrWhiteSpace(column))
            {
                throw new ArgumentException("Column name cannot be null or empty");
            }
            _orderByColumn = column;
            _isAscending = ascending;
            return this;
        }

        public IFromStage Select(string columns = "*")
        {
            if(string.IsNullOrWhiteSpace(columns))
            {
                throw new ArgumentException("Columns cannot be null or empty");
            }
            _columns = columns;
            return this;
        }
    }
}
