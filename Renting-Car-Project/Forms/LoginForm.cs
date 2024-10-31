﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Renting_Car_Project.Forms
{
    public partial class LoginForm : Form
    {
        bool sideBar_Expand = true;
        private Timer hoverTimer;
        private Control currentHoverControl;
        private int colorStep = 5;
        private int currentColorValue = 40;
        public LoginForm()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);
            hoverTimer = new Timer();
            hoverTimer.Interval = 30;
            hoverTimer.Tick += HoverTimer_Tick;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            guna2Panel7.Visible = true;
        }

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBar_Expand = false;
                    Timer_Sidebar_Menu.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sideBar_Expand = true;
                    Timer_Sidebar_Menu.Stop();
                }
            }
        }
        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();

        }

        private void guna2Panel4_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                currentHoverControl = control;
                currentColorValue = 40;
                hoverTimer.Start();
            }
        }

        private void guna2Panel4_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            Control control = sender as Control;
            if (control != null && control.Tag != null && control.Tag.ToString() == "RPText")
            {
                control.ForeColor = SystemColors.ButtonFace;    
                control.BackColor = Color.FromArgb(35, 40, 45);
                    }
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            if (currentHoverControl != null)
            {
                currentColorValue += colorStep; 
                if (currentColorValue > 255) currentColorValue = 255; 

                currentHoverControl.ForeColor = Color.FromArgb(currentColorValue, currentColorValue, currentColorValue); 
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true;
            guna2Panel7.Visible = false;

        }
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                txtPassSignUp.PasswordChar = '\0';
                txtRPTpass.PasswordChar = '\0';
            }
            else
            {
                txtPassSignUp.PasswordChar = '*';
                txtRPTpass.PasswordChar = '*';
            }
           
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            txtPassSignUp.PasswordChar = '*';
        
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            
            txtRPTpass.PasswordChar = '*';
        }
        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox5.PasswordChar = '*';
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true)
            {
                guna2TextBox5.PasswordChar = '\0';
               
            }
            else
            {
                guna2TextBox5.PasswordChar = '*';
          
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            guna2Panel7.Visible = true;
            guna2Panel5.Visible = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (IsNullOrWhiteSpace(txtRPTpass.Text) ||
                IsNullOrWhiteSpace(txtPassSignUp.Text) ||
                IsNullOrWhiteSpace(txtUserSignUp.Text))
            {
                MessageBox.Show("لطفا فیلد های خالی را پر کنید");
            }
            else
            {
            string userName = txtUserSignUp.Text;
            string password = txtPassSignUp.Text;
            UserRepository userRepository = new UserRepository();
            userRepository.RegisterUser(userName, password); // ارسال نام کاربری و رمز عبور به RegisterUser برای ثبت اطلاعات
            }


        }
    private bool IsNullOrWhiteSpace(string input)
    {
        return string.IsNullOrWhiteSpace(input);
    }
    }
}
