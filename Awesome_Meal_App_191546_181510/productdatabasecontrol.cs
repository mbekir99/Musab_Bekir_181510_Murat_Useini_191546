﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Awesome_Meal_App_191546_181510
{
    public partial class productdatabasecontrol : Form
    {

        public productdatabasecontrol()
        {
            InitializeComponent();
        }

        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mbeki\Downloads\Awesome_Meal_App_Musab_Bekir_181510_Murat_Useini_191546-main\Awesome_Meal_App_Musab_Bekir_181510_Murat_Useini_191546-main\Awesome_Meal_App_191546_181510\FoodDatabase.mdf;Integrated Security=True");
            sda = new SqlDataAdapter("Select * from Food", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt); 
        }
    }
}
