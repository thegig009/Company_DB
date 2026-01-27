using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Company_DB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();   // เปิดแบบล็อกหน้าหลัก
        }

        private void button2_Click(object sender, EventArgs e)
        {
			
				Form1 frm = new Form1();
				frm.ShowDialog();   // เปิดแบบล็อกหน้าหลัก
			}

		}
	}


