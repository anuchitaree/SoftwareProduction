using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace SoftwareProduction
{
    public partial class MainForm : Form
    {

        private static string validChars = "ACDEFHJKMPRSTWXYZ234579";
        private static Random rnd = new Random(Guid.NewGuid().GetHashCode());


        public MainForm()
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
            TbProductKey.Text = GetNewCode(4, 4);
        }

        private void BtnMac_Click(object sender, EventArgs e)
        {
            TbMacEnc.Text = GetMACAddress();
        }

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == string.Empty)// only return MAC Address from first card
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }

            Mac.Text = sMacAddress;
            return EncodingMacAddress(sMacAddress);
        }

        private string EncodingMacAddress(string input)
        {
            string sMacAddress = Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
            sMacAddress = sMacAddress.Insert(4, "-");
            sMacAddress = sMacAddress.Insert(9, "-");
            return sMacAddress.Insert(14, "-");
        }

        private void BtnMac1_Click(object sender, EventArgs e)
        {
            string encodeMacAddress = TbMacEnc.Text.Replace("-", "");

            TbMacAddress.Text = Encoding.UTF8.GetString(Convert.FromBase64String(encodeMacAddress));
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            TbActivationCode.Text = DecoderMacAddress(TbMacEnc.Text);
        }

        private string DecoderMacAddress(string encodeMac)
        {
            string screctkey = "Gdspx26";
            //string screctkey = "";

            string encodeMacAddress = TbMacEnc.Text.Replace("-", "");

            string macAddress = Encoding.UTF8.GetString(Convert.FromBase64String(encodeMacAddress));

            //byte[] fix = new byte[] {1,2,3,4,5,6,6,5,6,5,3,2,3,2,4,6,5,6,5,6,5,6,6};

            //byte[] aa = Convert.FromBase64String(encodeMacAddress);

            //var fix = Encoding.UTF8.GetBytes("12345662213345665654");

            //byte[] result = new byte[] { };

            //for (uint i = 0; i < aa.Length; i++)
            //{
            //    result[i] = fix[i]; //aa[i];// 

            //}


            //return Convert.ToBase64String(Encoding.UTF8.GetBytes(macAddress));

            byte[] bytes = Encoding.UTF8.GetBytes(macAddress+ screctkey);
            SHA256 sha = SHA256.Create();
            byte[] hash = sha.ComputeHash(bytes);

            string org = Convert.ToBase64String(hash);
            label8.Text = org;
            string encode16 = org.Substring(6,16).ToUpper();

          

            for (int i = 4; i < encode16.Length; i += 5)
            {
                encode16 = encode16.Insert(i, "-");
            }
            return encode16;


            //int keySize = 8; //64
            ////string password = "anuchit";
            //int iterations = 1;
            //HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512; // .SHA512;

            //byte[] salt = RandomNumberGenerator.GetBytes(keySize);
            //var hash = Rfc2898DeriveBytes.Pbkdf2(
            //    Encoding.UTF8.GetBytes(macAddress),
            //    salt,
            //    iterations,
            //    hashAlgorithm,
            //    keySize);

            //return Convert.ToHexString(hash);
        }
    }
}