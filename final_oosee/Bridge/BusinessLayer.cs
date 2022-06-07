using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;
using final_oosee.Global;

namespace final_oosee.Business
{
    public interface BusinessLayer
    {
        ITable GetTable();

        bool Insert();

        bool Delete();

        bool DeleteBaseOnUseID();

        bool Update();

        void Search(DataGridView dgv, string searchKeyWord);

    }
}
