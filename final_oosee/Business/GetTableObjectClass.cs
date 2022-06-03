using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using final_oosee.Global;

namespace final_oosee.Business
{
    internal static class GetTableObjectClass<T> where T : class
    {
        public static ITable GetTable()
        {
            JobManagemetDataContext jobManagemetDataContext = new JobManagemetDataContext();
            return jobManagemetDataContext.GetTable<T>();
        }
    }
}
