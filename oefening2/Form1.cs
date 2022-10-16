namespace oefening2
{
    public partial class Form1 : Form
    {
        Stapel<int> stapel = new Stapel<int>();
        Stapel<string> stringStapel = new Stapel<string>();
        Stapel<TestClass> testStapel = new Stapel<TestClass>();
        int Volgnummer
        {
            get { _volgnummer++; return _volgnummer; }
            set { _volgnummer = value; }
        }
        int _volgnummer = 0;

        public Form1()
        {
            InitializeComponent();
        }


        // ----------------------------- INT
        private void btIn_Click(object sender, EventArgs e)
        {
            try
            {
                stapel.Toevoegen(int.Parse(tbInOut.Text));
            } catch { 
            }
            
        }
        private void btOut_Click(object sender, EventArgs e)
        {
            int? result = stapel.Verwijderen();
        }

        private void btEmpty_Click(object sender, EventArgs e)
        {
            stapel.Leegmaken();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            tbResult.Text = stapel.ToString();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            tbResult.Text = stapel.IsAanwezig(int.Parse(tbInOut.Text)).ToString();
        }

        // TO DO COPY HOE WERKT

        //private void btCopy_Click(object sender, EventArgs e)
        //{
        //    tbResult.Text = stapel.Shallowcopy().ToString();
        //}

        // ----------------------------- STRING
        private void btStringIn_Click(object sender, EventArgs e)
        {
            stringStapel.Toevoegen(tbInOut.Text);
        }
        private void btStringOut_Click(object sender, EventArgs e)
        {
            tbInOut.Text = stringStapel.Verwijderen();
        }

        private void btStringEmpty_Click(object sender, EventArgs e)
        {
            stringStapel.Leegmaken();
        }

        private void btStringShow_Click(object sender, EventArgs e)
        {
            tbResult.Text = stringStapel.ToString();
        }

        private void btStringCheck_Click(object sender, EventArgs e)
        {
            tbResult.Text = stringStapel.IsAanwezig(tbInOut.Text).ToString();
        }

        //private void btStringCopy_Click(object sender, EventArgs e)
        //{
        //    tbResult.Text = stringStapel.Shallowcopy().ToString();
        //}

        // ----------------------------- TEST
        private void btTestClassIn_Click(object sender, EventArgs e)
        {
            testStapel.Toevoegen(new TestClass(Volgnummer, tbInOut.Text));
        }

        private void btTestOut_Click(object sender, EventArgs e)
        {
            tbInOut.Text = testStapel.Verwijderen().ToString();
        }

        private void btTestEmpty_Click(object sender, EventArgs e)
        {
            testStapel.Leegmaken();
        }

        private void btTestShow_Click(object sender, EventArgs e)
        {
            tbResult.Text = testStapel.ToString();
        }

        // TO DO ZOEKEN WHY PARSE VAN INT NAAR TEST 

        //private void btTestCheck_Click(object sender, EventArgs e)
        //{
        //    tbResult.Text = testStapel.IsAanwezig(tbInOut.Text).ToString();
        //}

    }
}