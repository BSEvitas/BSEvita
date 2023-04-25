namespace Bruchrechner
{
    public partial class Bruchrechner : Form
    {
        private int nenner1 { get; set; }
        private int nenner2 { get; set; }
        private int zaehler1 { get; set; }
        private int zaehler2 { get; set; }
        private Calculator result { get; set; }


        public Bruchrechner()
        {
            InitializeComponent();
        }

        private void Bruchrechner_Load(object sender, EventArgs e)
        {
            potenzLabel.Visible = false;
            textBoxPotenz.Visible = false;

            operations.Items.Clear();
            operations.Items.Add("Addition");
            operations.Items.Add("Subtraktion");
            operations.Items.Add("Multiplikation");
            operations.Items.Add("Division");
            operations.Items.Add("Potenzieren");
            operations.Items.Add("Wurzel ziehen");

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (operations.SelectedItem == null)
            {
                MessageBox.Show("Bitte w�hle eine valide Operation aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedMode = operations.SelectedItem.ToString();
            int Potenz;

            try
            {
                nenner1 = Convert.ToInt32(textBoxNennerEins.Text);
                zaehler1 = Convert.ToInt32(textBoxZ�hlerEins.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie valide Werte ein!", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Calculator calculator1 = new Calculator(nenner1, zaehler1);

            if (selectedMode == "Wurzel ziehen")
            {
                result = Calculator.sqrt(calculator1);
                return;
            }

            try
            {
                zaehler2 = Convert.ToInt32(textBoxZ�hlerZwei.Text);
                nenner2 = Convert.ToInt32(textBoxNennerZwei.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bitte geben Sie valide Werte ein!", "Fehler: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Calculator calculator2 = new Calculator(nenner2, zaehler2);

            switch (selectedMode)
            {
                case "Addition":
                    result = Calculator.Addition(calculator1, calculator2);
                    break;
                case "Subtraktion":
                    result = Calculator.Subtract(calculator1, calculator2);
                    break;
                case "Multiplikation":
                    result = Calculator.Multiply(calculator1, calculator2);
                    break;
                case "Division":
                    result = Calculator.Divide(calculator1, calculator2);
                    break;
                case "Potenzieren":
                    Potenz = Convert.ToInt32(textBoxPotenz.Text);
                    result = Calculator.Exponentiate(calculator1, Potenz);
                    break;
                default:
                    MessageBox.Show("Bitte w�hle eine valide Operation aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            textBoxErgebnis.Text = result.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (operations.Text == "Potenzieren")
            {
                zaehlerZweiLabel.Visible = false;
                textBoxZ�hlerZwei.Visible = false;
                NennerZweiLabel.Visible = false;
                textBoxNennerZwei.Visible = false;

                textBoxPotenz.Visible = true;
                potenzLabel.Visible = true;
            }
            else if (operations.Text == "Wurzel ziehen")
            {
                zaehlerZweiLabel.Visible = false;
                textBoxZ�hlerZwei.Visible = false;
                NennerZweiLabel.Visible = false;
                textBoxNennerZwei.Visible = false;

                textBoxPotenz.Visible = false;
                potenzLabel.Visible = false;
            }
            else
            {
                zaehlerZweiLabel.Visible = true;
                textBoxZ�hlerZwei.Visible = true;
                NennerZweiLabel.Visible = true;
                textBoxNennerZwei.Visible = true;

                textBoxPotenz.Visible = false;
                potenzLabel.Visible = false;
            }
        }
    }
}