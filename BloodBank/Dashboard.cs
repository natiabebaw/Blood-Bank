﻿
using BloodBank;
using BloodBank.Forms;
using BloodBank.Forms.Receiver;
using BloodBank.Forms.Request;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        #region CustomizeDesign Method
        private void CustomizeDesign()
        {   
            //hide the side menu initially
            panelSideSubMenu1.Visible = false;
            panelSideSubMenu2.Visible = false;
        }
        #endregion
        #region HideMenu 
        private void HideMenu() //method to hide the submenu when it called
        {
            if (panelSideSubMenu1.Visible == true)
            {
                panelSideSubMenu1.Visible = false;
            }
            if (panelSideSubMenu2.Visible == true)
            {
                panelSideSubMenu2.Visible = false;
            }
            
        }
        #endregion
        #region SubMenu
        private void SubMenu(Panel subMenu)
        {
            //check whether the subpanel is visible or not
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        private void btn_Donner_Click(object sender, EventArgs e)
        {
            SubMenu(panelSideSubMenu1);//pass the sub panel when clicked
            //if this is opend close the others
            panelSideSubMenu2.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonnerForm()); //pass the form to display on the child panel
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonorTable());

            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private static Form activeForm = null;
        private static Form copyForm = null;
        #region OpenChildForm
        public static void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelAddForm.Controls.Add(childForm);
            panelAddForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            copyForm = childForm;
        }
        #endregion

        #region CloseChildForm or Home
        private void CloseChildForm(Form childForm)
        {
            childForm.Hide();
        }
        #endregion
        private void btn_receiver_Click(object sender, EventArgs e)
        {
            SubMenu(panelSideSubMenu2);//pass the sub panel when clicked
            //if this is opend close the others
            panelSideSubMenu1.Visible = false;
        }

        private void btn_blood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new bloodTable());//pass donor_table to display it on dashboard
            
            //if this is opend close the others
            panelSideSubMenu1.Visible = false;
            panelSideSubMenu2.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReceiverForm()); //pass the form to display on the child panel
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RequestTable());
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseChildForm(copyForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {   
            OpenChildForm(new DonorTable());//pass donor_table to display it on dashboard
            //...
            //Hide when clicked
            //...
            HideMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToString("T");
            lbl_date.Text = DateTime.Now.ToString("dd MMM dddd");
;        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        string file = "D:\\Books\\Microlink\\Projects\\Advance Database and C#\\blood_bank.sql";//This is path to save the backup db file..
        string constring = "server=127.0.0.1;PORT=3306;user=root;pwd=nati brown;database=blood_bank; Convert Zero Datetime=True;";//
        private void button4_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);//This line will export the file to given path.
                        conn.Close();
                        MessageBox.Show("Backup Completed...!!!");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);//This line will export the file to given path.
                        conn.Close();
                        MessageBox.Show("DB Restore Completed...!!!");
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}
