namespace CheckSumCalculator
{
    public partial class CheckSumCalculator : Form
    {
        public CheckSumCalculator()
        {
            InitializeComponent();
        }

        private void calculateCheckSumBtn_Click(object sender, EventArgs e)
        {
            string partialCode = partialCodeTextBox.Text;

            var result = Luhn.CalculateCodeWithCheckSum(partialCode);

            checkSumValueLbl.Text = result.Item1.ToString();

            codeWithCheckSumValueLbl.Text = result.Item2;
        }

        private void clearScreenBtn_Click(object sender, EventArgs e)
        {
            partialCodeTextBox.Text = "";

            checkSumValueLbl.Text = "";

            codeWithCheckSumValueLbl.Text = "";
        }

        private void partialCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            checkSumValueLbl.Text = "";

            codeWithCheckSumValueLbl.Text = "";
        }
    }
}
