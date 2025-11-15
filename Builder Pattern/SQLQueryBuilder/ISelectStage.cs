using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueryBuilder
{
    public interface ISelectStage
    {
        public IFromStage Select(string columns);
    }
}
