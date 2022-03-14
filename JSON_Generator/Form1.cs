using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JSON_Generator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void BGenerate_Click(object sender, EventArgs e)
        {
           var data = GetData();

            //this.saveFile = new SaveFileDialog();
            //saveFile.Filter = "Excel File|*.xlsx|JSON File|*.json";
            //saveFile.FileName = "Data";
            //saveFile.ShowDialog();
        }

        private List<DataView> GetData()
        {
            var result = new List<DataView>();

            for (int i = 0; i < numericUpDown1.Value; i++)
            {


                var data = new DataView
                {
                    Name = Name(),
                    Password = Password(),
                    Email = Email(),
                    Phone = Phone(),
                    Address = Address(),
                };



                result.Add(data);
            }
            return result;
        }

#pragma warning disable CS0108 // 'mainForm.Name()' hides inherited member 'Control.Name'. Use the new keyword if hiding was intended.
        static string Name()
#pragma warning restore CS0108 // 'mainForm.Name()' hides inherited member 'Control.Name'. Use the new keyword if hiding was intended.
        {
            var input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In a est ante. Duis venenatis ex sed erat tincidunt sollicitudin. Fusce justo justo, lobortis sit amet nisl in, rhoncus sollicitudin mauris.";
            string[] names = input.Split();
            Random random = new();

            string result = names[random.Next(names.Length)];

            return result;
        }

        static string Password()
        {
            char[] specialList;
            string special = "!@#$%^&*()_+}{|:?><";
            specialList = special.ToCharArray();

            char[] charsList;
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            charsList = characters.ToCharArray();

            char[] numberList;
            string numbers = "0123456789";
            numberList = numbers.ToCharArray();

            string result = "";
            Random random = new();

            for (int i = 0; i < 10; i++)
            {

                result += i switch
                {
                    0 => charsList[random.Next(charsList.Length)].ToString().ToUpper(),
                    8 => numberList[random.Next(numberList.Length)],
                    9 => specialList[random.Next(specialList.Length)],
                    _ => charsList[random.Next(charsList.Length)],
                };
            }


            return result;
        }


        static string Email()
        {    
            char[] charsList;
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            charsList = characters.ToCharArray();

            
            string[] domains = { "ru.com", "wp.pl","gmail.com","onet.pl"};

            string result = "";
            Random random = new();

            for (int i = 0; i < 10; i++)
            {

                result += i switch
                {
                    0 => charsList[random.Next(charsList.Length)].ToString().ToUpper(),
                    8 => "@",
                    9 => domains[random.Next(domains.Length)],
                    _ => charsList[random.Next(charsList.Length)],
                };
            }
            return result;
        }

        int Phone()
        {
            Random random = new Random();

           var result = random.NextInt64(100000000,999999999);

            return Convert.ToInt32(result);
        }

        string Address()
        {




            return "qwe00";
        }























        static async Task<ActionResult<IpInfo>> UserIpInfo()
        {
            HttpClient client = new();

            HttpResponseMessage message = await client.GetAsync("https://api.freegeoip.app/json?apikey=b1142ed0-a05a-11ec-bac9-c78c892a0296");
            var jsonString = message.Content.ReadAsStringAsync();

            IpInfo? result = JsonConvert.DeserializeObject<IpInfo>(await jsonString);

            if (result == null)
            {
                IpInfo ipInfo = new();
                return ipInfo;
            }
            //var hostName = Dns.GetHostName();
            //var test = Dns.GetHostEntry(hostName);
            //var ip = Dns.GetHostByName(hostName).AddressList[0].ToString();

            // var cos = System.Web.HttpContext.Current;

            //string p = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            return result;
        }
    }
}