namespace Hash_Table_Abonent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int HashFunctionMethod(string key);
        int rowCount = 256;
        List<Abonent> abonents = new List<Abonent>();
        MyHashTable myHashTable;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (myHashTable != null)
            {
                myHashTable.Draw(pictureBox1.Width, pictureBox1.Height, e.Graphics);
            }
        }

        private int goodHash(string key)
        {
            int k = 0;
            for (int i = 0; i < key.Length; i++)
            {
                k += Convert.ToChar(key[i]);
            }
            return Convert.ToInt32(k % rowCount);
        }

        private int badHash(string key)
        {
            int k = 0;
            for (int i = 0; i < key.Length; i++)
            {
                k += Convert.ToChar(key[i]);
            }
            return Convert.ToInt32(k * 200 % rowCount);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            KeysType kt;
            if (radioButtonName.Checked)
            {
                kt = KeysType.Name;
            }
            else if (radioButtonBirthday.Checked)
            {
                kt = KeysType.DateOfBirthday;
            }
            else
            {
                kt = KeysType.Phone;
            }
            HashFunctionMethod s;
            if (checkBoxBadHash.Checked)
            {
                s = badHash;
            }
            else
            {
                s = goodHash;
            }
            myHashTable = new MyHashTable(rowCount, kt, s);
            myHashTable.Load();
            Refresh();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            abonents = myHashTable.Find(textBoxKeyFind.Text, out int steps);
            labelSteps.Text = steps + " = steps to find";
            textBoxInfo.Text = "";
            foreach (Abonent abonent in abonents)
            {
                textBoxInfo.Text += "Name: " + abonent.Name + "\n";
                textBoxInfo.Text += "Birthday: " + abonent.Birthday + "\n";
                textBoxInfo.Text += "Phone: " + abonent.Phone + "\n";
                textBoxInfo.Text += "-------------------------\n";
            }
        }
    }
}