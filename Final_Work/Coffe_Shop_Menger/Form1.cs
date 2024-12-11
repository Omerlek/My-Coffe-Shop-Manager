
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using PRODUCTS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics;
using CPPGroupProject2.Frontend.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Coffe_Shop_Menger
{

    public partial class Form1 : Form
    {
        public bool unsaved_canges = false, vegan, alc, cheese, bread;
        public productList lst = new productList();
        public string choice, name, breadtype = "white";
        public double prc, totalprice = 0;
        public int cals;

        public Form1()
        {

            InitializeComponent();
            selectbox.Items.Add("Salad");
            selectbox.Items.Add("Sandwich");
            selectbox.Items.Add("Drink");
        }

        private void productname_TextChanged(object sender, EventArgs e)
        {
            name = productname.Text.ToString();
        }

        private void calories_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cals = int.Parse(calories.Text.ToString());
            }
            catch
            {
                MessageBox.Show("only numbers insertion allowed");
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                prc = double.Parse(price.Text.ToString());
            }
            catch
            {
                MessageBox.Show("only numbers insertion allowed");
            }
        }

        private void rdb_vegan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_vegan.Checked)
                vegan = true;
            else
                vegan = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (choice == "Salad")
            {
                if (productname.Text == "" || calories.Text == "" || price.Text == "")
                    MessageBox.Show("Please fill al the data needed");
                else
                {
                    lst.pList[lst.pList.Count] = new SALAD(name, prc, cals, vegan, cheese);
                    totalprice = totalprice + prc;
                    total_cal.Text = totalprice.ToString();
                    dataGridView1.Rows.Add(name, "Salad", cals.ToString(), prc.ToString(), vegan.ToString(), cheese.ToString(), "N/A", "N/A");
                }
            }
            else if (choice == "Sandwich")
            {
                if (productname.Text == "" || calories.Text == "" || price.Text == "")
                    MessageBox.Show("Please fill al the data needed");
                else
                {
                    lst.pList[lst.pList.Count] = new SANDWICH(name, prc, cals, bread, vegan);
                    totalprice = totalprice + prc;
                    total_cal.Text = totalprice.ToString();
                    dataGridView1.Rows.Add(name, "Sandwich", cals.ToString(), prc.ToString(), vegan.ToString(), "N/A", breadtype, "N/A");
                }
            }
            else if (choice == "Drink")
            {
                if (productname.Text == "" || calories.Text == "" || price.Text == "")
                    MessageBox.Show("Please fill al the data needed");
                else
                {
                    lst.pList[lst.pList.Count] = new ToDRINK(name, prc, cals, alc);
                    totalprice = totalprice + prc;
                    total_cal.Text = totalprice.ToString();
                    dataGridView1.Rows.Add(name, "Drink", cals.ToString(), prc.ToString(), "N/A", "N/A", "N/A", alc.ToString());
                }
            }
            else { MessageBox.Show("Please fill al the data needed"); }
            unsaved_canges = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, lst);
                    unsaved_canges = false;
                }
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            delete();
            unsaved_canges = true;

        }

        private void rdb_alc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_alc.Checked)
                alc = true;
            else
                alc = false;
        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            DialogResult rst;

            if (unsaved_canges == false)
                Application.Exit();
            else
            {
                rst = MessageBox.Show("There are changes that you have not saved in your project.\n Are you sure you want to exit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rst == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            iReset();
            total_cal.Text = "0";
            unsaved_canges = true;
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                bread = true;
                breadtype = "brown";
            }

            else
            {
                bread = false;
                breadtype = "white";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPictureBox formPictureBox = new FormPictureBox();
            formPictureBox.Image.Load("https://coffee.alexflipnote.dev/random");
            formPictureBox.ShowDialog();
        }

        private void total_cal_Click(object sender, EventArgs e)
        {

        }

        private void cal_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                cheese = true;
            else
                cheese = false;

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                lst = (productList)binaryFormatter.Deserialize(stream);
                iLoad();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = selectbox.Text.ToString();
        }
        private void delete()
        {

            double temp = double.Parse(total_cal.Text.ToString());
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                {
                    double temp1 = double.Parse(dataGridView1.Rows[item.Index].Cells[3].Value.ToString()); ;
                    lst.Remove(item.Index);
                    dataGridView1.Rows.RemoveAt(item.Index);
                    temp -= temp1;

                }
                totalprice = temp;
                total_cal.Text = temp.ToString();
            }

        }
        private void iReset()
        {
            int curr;
            int max = dataGridView1.Rows.Count;
            for (int i = 0; i < max - 1; i++)
            {
                curr = dataGridView1.Rows.Count - 2;
                dataGridView1.Rows.Remove(dataGridView1.Rows[curr]);

            }
            max = lst.pList.Count;
            for (int i = 0; i < max; i++)
            {
                curr = lst.pList.Count - 1;
                lst.Remove(curr);
            }
            totalprice = 0;
            total_cal.Text = "0";
            MessageBox.Show("All the data has been deleted");
        }
        private void iLoad()
        {
            string temp, bread;
            double price = 0;
            bool temp1;
            for (int i = 0; i < lst.pList.Count; i++)
            {
                temp = lst.pList.GetByIndex(i).ToString();
                temp = temp.Remove(0, 9);
                if (temp == "SALAD")
                {
                    dataGridView1.Rows.Add(lst.getElementSALAD(i).name.ToString(), "Salad", lst.getElementSALAD(i).calories.ToString(), lst.getElementSALAD(i).price.ToString(), lst.getElementSALAD(i).isVegan.ToString(), lst.getElementSALAD(i).cheese.ToString(), "N/A", "N/A");
                    price += lst.getElementSALAD(i).price;
                }
                else if (temp == "SANDWICH")
                {
                    temp1 = lst.getElementSANDWICH(i).brownBread;
                    if (temp1 == true) { bread = "brown"; } else { bread = "white"; }
                    dataGridView1.Rows.Add(lst.getElementSANDWICH(i).name.ToString(), "Sandwich", lst.getElementSANDWICH(i).calories.ToString(), lst.getElementSANDWICH(i).price.ToString(), lst.getElementSANDWICH(i).isVegan.ToString(), "N/A", bread, "N/A");
                    price += lst.getElementSANDWICH(i).price;
                }
                else if (temp == "ToDRINK")
                {
                    dataGridView1.Rows.Add(lst.getElementToDRINK(i).name.ToString(), "Drink", lst.getElementToDRINK(i).calories.ToString(), lst.getElementToDRINK(i).price.ToString(), "N/A", "N/A", "N/A", lst.getElementToDRINK(i).alcohol);
                    price += lst.getElementToDRINK(i).price;
                }
                total_cal.Text = price.ToString();
            }

        }

    }

}