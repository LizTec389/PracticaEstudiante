namespace PracticaEstudiante
{
    public partial class Form1 : Form

    {
        string txtmotherlastname;
        string txtLastName;
        string txtname;
        int grade;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtname = txtbox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtLastName = txtbox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtmotherlastname = txtbox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (txtbox1 != null && txtbox1 != null && txtbox1 != null)
                {
                    while (true)
                    {
                        try
                        {
                            grade = Convert.ToInt32(nup.Value);
                            break;
                        }

                        catch (FormatException)
                        {
                            txtbox.Text = "Please enter a right Grade";
                        }
                    }


                    namePerson n1 = new namePerson(txtbox1.Text, txtbox2.Text, txtbox3.Text);


                    DateTime dt = dateTime1.Value;

                    EstudentPerson n3 = new EstudentPerson(txtbox1.Text, txtbox2.Text, txtbox3.Text, dt, txtbox4.Text, txtbox5.Text, grade);

                    txtbox.Text = Convert.ToString(n3.Birthdate);
                    txtbox.Text = Convert.ToString(n3.Grade);

                    txtbox.Text = n3.ToString();
                }


            }
        }
}
