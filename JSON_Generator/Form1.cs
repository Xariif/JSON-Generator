using IronXL;

namespace JSON_Generator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        private void BGenerate_Click(object sender, EventArgs e)
        {
            var data = GetData();


            if (Save(data) == true)
            {
                string message = "Wygenerowano pomyślnie " + numericUpDown1.Value + " rekordów!";
                MessageBox.Show(message);
            }
            else
            {
                string message = "Wystąpił nieoczekiwany błąd!";
                MessageBox.Show(message);
            }
        }


        bool Save(List<DataView> data)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            try
            {
                this.saveFile = new SaveFileDialog();
                saveFile.FileName = "Data";

                WorkBook xls = WorkBook.Create(ExcelFileFormat.XLS);
                xls.Metadata.Author = "Xariif";

                WorkSheet xlsSheet = xls.CreateWorkSheet("WS1");
                int z = 1;

                if (cLogin.Checked)
                    z++;

                if (cPassword.Checked)
                    z++;

                if (cEmail.Checked)
                    z++;

                if (cName.Checked)
                    z++;

                if (cSurname.Checked)
                    z++;

                if (cCountry.Checked)
                    z++;

                if (cAddress.Checked)
                    z++;

                if (cPhone.Checked)
                    z++;

                for (int i = 1; i < data.Count + 1; i++)
                {
                    int j =0;
                    if (cLogin.Checked)
                    {
                        var x = alphabet[j] + i.ToString();
                        xlsSheet[alphabet[j] + i.ToString()].Value = data[i - 1].Login;
                        j++;
                    }
                    if (cPassword.Checked)
                    {
                        xlsSheet[alphabet[j] + i.ToString()].Value = data[i - 1].Password;
                        j++;
                    }
                    if (cEmail.Checked)
                    {
                        xlsSheet[alphabet[j] + i.ToString()].Value = data[i - 1].Email;
                        j++;
                    }
                    if (cName.Checked)
                    {
                        xlsSheet[alphabet[j] + i.ToString()].Value = data[i - 1].Name;
                        j++;
                    }
                    if (cSurname.Checked)
                    {
                        xlsSheet[alphabet[j] + i.ToString()].Value = data[i - 1].Surname;
                        j++;
                    }
                    if (cCountry.Checked)
                    {
                        xlsSheet[alphabet[j] + i.ToString()].Value = data[i - 1].Country;
                        j++;
                    }
                    if (cAddress.Checked)
                    {
                        xlsSheet[alphabet[j] + i.ToString()].Value = data[i - 1].Address;
                        j++;
                    }
                    if (cPhone.Checked)
                    {
                        xlsSheet[alphabet[j] + i.ToString()].Value = data[i - 1].Phone;
                        j++;
                    }                  
                }


                if (saveFile.ShowDialog() == DialogResult.Cancel)
                {
                    return false;
                }

                var path = saveFile.FileName;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        xls.SaveAs(path + ".xls");
                        break;
                    case 1:
                        xls.SaveAsJson(path + ".json");
                        break;
                    case 2:
                        xls.SaveAsXml(path + ".xml");
                        break;
                    case 3:
                        xls.SaveAsCsv(path + ".csv");
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        List<DataView> GetData()
        {
            var result = new List<DataView>();

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                var data = new DataView
                {
                    Name = GName(),
                    Surname = Surname(),
                    Password = Password(),
                    Phone = Phone(),
                    Address = Address(),
                    Country = Country(),
                };
                data.Email = Email(data.Name, data.Surname);
                data.Login = Login(data.Name);
                result.Add(data);
            }
            return result;
        }

        string Login(string name)
        {
            if (cLogin.Checked == false)
                return "";
            Random random = new Random();
            return name + random.Next(1, 9990);
        }

        string GName()
        {
            if (cName.Checked == false)
                return "";
            var data = File.ReadAllLines("Files/Names.txt");

            Random random = new();

            string result = data[random.Next(data.Length)];

            return result;
        }

        string Surname()
        {
            if (cSurname.Checked == false)
                return "";
            var data = File.ReadAllLines("Files/Surnames.txt");

            Random random = new();

            string result = data[random.Next(data.Length)];

            return result;
        }

        string Password()
        {
            if (cPassword.Checked == false)
                return "";
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


        string Email(string name, string surname)
        {
            if (cEmail.Checked == false)
                return "";
            string[] domains = { "ru.com", "wp.pl", "gmail.com", "onet.pl" };

            string result = name + "." + surname + "@";
            Random random = new();

            result += domains[random.Next(domains.Length)];

            return result;
        }

        int Phone()
        {
            if (cPhone.Checked == false)
                return 0;
            Random random = new();

            var result = random.NextInt64(100000000, 999999999);

            return Convert.ToInt32(result);
        }

        string Address()
        {
            if (cAddress.Checked == false)
                return "";
            var data = File.ReadAllLines("Files/Cities.txt");

            Random random = new Random();

            var result = data[random.Next(data.Length)];

            result = result + " " + random.Next(1, 50);

            return result;
        }

        string Country()
        {
            if (cCountry.Checked == false)
                return "";
            var data = File.ReadAllLines("Files/Countries.txt");

            Random random = new Random();

            var result = data[random.Next(data.Length)];

            return result;
        }

    }
}