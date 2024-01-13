using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_1
{
    public partial class frmEmployee : Form
    {
        DataTable _dtSource=new DataTable();
        public frmEmployee()
        {
            InitializeComponent();
        }

        public DataTable DtSource { get => _dtSource; set => _dtSource = value; }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dtg_Employee.DataSource = _dtSource;
        }

        private void dtg_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
