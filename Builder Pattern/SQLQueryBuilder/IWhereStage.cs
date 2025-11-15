using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueryBuilder
{
    public interface IWhereStage : IBuildStage
    {
        public IOrderStage Where(string condition);
    }
}
