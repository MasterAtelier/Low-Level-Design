using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueryBuilder
{
    public interface ILimitStage : IBuildStage
    {
        public IBuildStage Limit(int rowCount);
    }
}
