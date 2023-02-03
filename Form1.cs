namespace SoftwareProduction
{
    public partial class Form1 : Form
    {

        private static string validChars = "ACDEFHJKMPRSTWXYZ234579";
        private static Random rnd = new Random(Guid.NewGuid().GetHashCode());


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Generate a license code
        /// </summary>
        /// <param name="length">length of each phrase</param>
        /// <param name="number">number of phrases separated by a '-'</param>
        /// <returns></returns>
        public static string GetNewCode(int length, int number)
        {
            string license = string.Empty;

            for (int numberOfPhrases = 0; numberOfPhrases < number; numberOfPhrases++)
            {
                license += getPhrase(length);
                if (numberOfPhrases < number)
                    license += "-";
            }

            return license.TrimEnd('-');
        }

        /// <summary>
        /// generate a phrase
        /// </summary>
        /// <param name="length">length of phrase</param>
        /// <returns></returns>
        private static string getPhrase(int length)
        {
            string phrase = string.Empty;

            for (int loop = 0; loop < length; loop++)
            {
                phrase += validChars[rnd.Next(validChars.Length)];
            }

            return phrase;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            TbProductKey.Text = GetNewCode(4,4 );
        }
    }
}