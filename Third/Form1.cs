using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Third
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.risThirdTableAdapter.Fill(this.databaseDataSet.RisThird);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.risThirdTableAdapter.Update(databaseDataSet.RisThird);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            databaseDataSet.RisThird.RejectChanges();
        }

        private void risThirdBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.risThirdBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }
    }
}
