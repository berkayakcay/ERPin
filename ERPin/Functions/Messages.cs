using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPin.Functions
{
    class Messages
    {
        public void Save(string message)
        {
            MessageBox.Show(message,"New Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Update()
        {
            return MessageBox.Show("Selected record will be updated\n Do you want to update?", "Update",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Update(string message)
        {
            MessageBox.Show("Record has been updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public DialogResult Delete()
        {
            return MessageBox.Show("Selected record will be deleted\n Do you want to delete?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Error(Exception exception)
        {
            MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
