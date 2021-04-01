using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.VisualBasic;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() //подключение к реестру
        {
            InitializeComponent();

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Arifka");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //размер окна
        {
            string hght = textBox2.Text;
            string wdth = textBox3.Text;

            this.Height = Convert.ToInt32(hght);
            this.Width = Convert.ToInt32(wdth);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //чтение из реестра и вывод на экран
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Arifka");

            if (key !=null )
            {
                int Height = int.Parse(key.GetValue("Height").ToString());
                int Width = int.Parse(key.GetValue("Width").ToString());
                this.Size = new Size(Width, Height);
                textBox1.Text = key.GetValue("Surname").ToString();

                string color = (string)key.GetValue("Color");

                if (color == "Зеленый")
                    BackColor = System.Drawing.Color.GreenYellow;
                else if (color == "Синий")
                    BackColor = System.Drawing.Color.Blue;
                else if (color == "Красный")
                    BackColor = System.Drawing.Color.Red;
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //сохранение в реестре
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Arifka");
       
            key.SetValue("Height", this.Height);
            key.SetValue("Width", this.Width);
            key.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) // зеленый цвет
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Arifka");

            key.SetValue("Color", "Зеленый");
            key.Close();
            BackColor = System.Drawing.Color.GreenYellow;
        }

        private void button8_Click(object sender, EventArgs e) //синий цвет
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Arifka");

            key.SetValue("Color", "Синий");
            key.Close();
            BackColor = System.Drawing.Color.Blue;
        }

        private void button9_Click(object sender, EventArgs e) //красный цвет
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Arifka");

            key.SetValue("Color", "Красный");
            key.Close();
            BackColor = System.Drawing.Color.Red;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Arifka");
            key.SetValue("Surname", textBox1.Text);
            key.Close();
        }
    }
}