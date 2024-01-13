using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_1
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            timer_photo.Interval= 3000;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.process.start?view=net-8.0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial_STM.Open();
            timer_photo.Start();

            dt.Columns.Add("STT");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Class");

            dt.Rows.Add("1","Nguyen Van A", "23", "TDH1");
            dt.Rows.Add("2", "Nguyen Van B", "21", "TDH1");
            dt.Rows.Add("3", "Nguyen Van C", "23", "TDH1");
            dt.Rows.Add("4", "Nguyen Van D", "22", "TDH1");

            
        }

        private void cbo_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_name.Text = cbo_name.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/Photo/" + txt_name.Text + ".jpg";
            pic_name.ImageLocation = path;
        }

        int k = 0;
        private void timer_photo_Tick(object sender, EventArgs e)
        {            
            k++;
            string path = Application.StartupPath + "/Photo/AC" + k.ToString() + ".jpg";
            pic_name.ImageLocation = path;
            if(k%2==0)
            {
                txt_name.ForeColor = Color.Red;
            }
            else
            {
                txt_name.ForeColor = Color.Blue;
            }

            if (k > 7)
            {
                k = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.DtSource = dt;
            frm.ShowDialog();
        }

        private void serial_STM_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           string data= serial_STM.ReadTo("x");

        }
    }
}
