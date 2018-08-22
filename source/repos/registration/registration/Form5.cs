using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void rtBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rtBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.regis_wtDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'regis_wtDataSet.rt' table. You can move, or remove it, as needed.
            this.rtTableAdapter.Fill(this.regis_wtDataSet.rt);

        }
    }
}
