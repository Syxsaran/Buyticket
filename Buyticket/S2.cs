using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buyticket
{
    public partial class S2 : Form
    {
        public S2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAll.Text = "RingBaBoon";
            textBoxAll.Text = "รายละเอียดบัตร  Matoom5" + "\r\n" + "ชื่อ-สกุล  " + textBoxName.Text + "\r\n" + "E-mail  " + textBoxEmail.Text + "\r\n" + "เบอร์โทร  " + textBoxNumberphone.Text + "\r\n" + "จำนวนบัตร  " + comboBoxMuch.Text + "\r\n" + "ราคา  " + textBoxprice.Text;
            button2.Visible = false;
            button1.Visible = false;
            button3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Consert consert = new Consert();
            consert.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณที่ใช้บริการ");
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string classS2RAW = readAllLine[i];
                    string[] classS2Splited = classS2RAW.Split(',');
                    ClassS2 classS2 = new ClassS2(classS2Splited[0], classS2Splited[1], classS2Splited[2], classS2Splited[3], classS2Splited[4]);
                    addDataToGridView(classS2Splited[0], classS2Splited[1], classS2Splited[2], classS2Splited[3], classS2Splited[4]);
                }
            }
        }
        void addDataToGridView(string name, string email, string number, string much, string price)
        {
            this.dataGridView1.Rows.Add(new string[] { name, email, number, much, price });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
