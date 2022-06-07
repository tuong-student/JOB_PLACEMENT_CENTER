using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using final_oosee.Business;
using final_oosee.Global;

namespace final_oosee.Bridge
{
    internal class AbstractManager
    {
        BusinessLayer bsLayer;

        public AbstractManager(BusinessLayer BSlayer)
        {
            this.bsLayer = BSlayer;
        }

        public ITable GetTable()
        {
            return bsLayer.GetTable();
        }

        public void Insert()
        {
            bsLayer.Insert();
        }

        public void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to delete ?", "Confirm dialog", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                bsLayer.Delete();
            }
        }

        public void DeleteBaseOnUserID()
        {
            try
            {
                bsLayer.DeleteBaseOnUseID();
            }
            catch
            {

            }
        }

        public void Update()
        {
            bsLayer.Update();
            MessageBox.Show("Update complete");
        }

        public void Search(DataGridView dgv, string searchKeyWord)
        {
            bsLayer.Search(dgv, searchKeyWord);
        }
    }
}
