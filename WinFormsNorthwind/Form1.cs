using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsNorthwind
{
    public partial class Form1 : Form
    {
        List<Supplier> Suppliers;
        public Form1()
        {
            InitializeComponent();
            Suppliers = new List<Supplier>();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bindingSource1;
            bindingSource1.DataSource = Suppliers;
            btnUpdateTable.Click += BtnUpdateTable_Click;
        }

        private void BtnUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        void UpdateTable ()
        {
            Suppliers.Clear();
            var lst = Controller.GetSuppliers();
            if (lst != null && lst.Count> 0)
            {
                Suppliers.AddRange(lst);
                bindingSource1.ResetBindings(false);
            }

        }
    }
}
