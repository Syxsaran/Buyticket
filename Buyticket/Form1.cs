namespace Buyticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Consert consert = new Consert();
            consert.Visible = true;
        }
    }
}