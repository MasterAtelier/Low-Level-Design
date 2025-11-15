using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueryBuilder
{
    public interface IOrderStage : IBuildStage
    {
        public ILimitStage OrderBy(string column, bool ascending = true);
    }
}
