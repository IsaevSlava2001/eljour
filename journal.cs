using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace journal_kurilov
{
    public partial class group_PKS_22_TSI : Form
    {
        public int zapolneno=0;
        public int schet = 0;
        public int snb=0;
        public double summ=0;
        public int x = 0;
        public int y=0;
        public bool [] check=new bool[21];
        public bool monthcheck=false;
        public string get;
        public string group_loc;
        public string month_loc;
        public void createdirit (string group,string month)//создание итоговых директорий
        {
            Directory.CreateDirectory($@"C:/electron_journal/{group}");
            Directory.CreateDirectory($@"C:/electron_journal/{group}/{month}");
            Directory.CreateDirectory($@"C:/electron_journal/{group}/{month}/data");
            for (int g = 1; g < 31; g++)
            {
                File.Create($@"C:/electron_journal/{group}/{month}/data/{g}").Close(); ;
            }
        }
        public void loadmark(string group,string month)//загрузка на одну группу на один месяц
        {
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/1");
            textBox37.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/2");
            textBox36.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/3");
            textBox35.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/4");
            textBox34.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/5");
            textBox33.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/6");
            textBox32.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/7");
            textBox31.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/8");
            textBox30.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/9");
            textBox29.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/10");
            textBox28.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/11");
            textBox27.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/12");
            textBox26.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/13");
            textBox25.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/14");
            textBox24.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/15");
            textBox38.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/16");
            textBox39.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/17");
            textBox23.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/18");
            textBox40.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/19");
            textBox22.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/20");
            textBox21.Text = get;
            get = File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/1/21");
            textBox623.Text = get;
            monthcheck = Convert.ToBoolean(File.ReadAllText($@"C:/electron_journal/{group}/{month}/data/endcheck.txt"));

        }
        public void savemark(string group,string month)//сохранение оценок на одну группу на один месяц
        {if (!monthcheck)
            {
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/1", textBox37.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/2", textBox36.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/3", textBox35.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/4", textBox34.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/5", textBox33.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/6", textBox32.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/7", textBox31.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/8", textBox30.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/9", textBox29.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/10", textBox28.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/11", textBox27.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/12", textBox26.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/13", textBox25.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/14", textBox24.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/15", textBox38.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/16", textBox39.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/17", textBox23.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/18", textBox40.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/19", textBox22.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/20", textBox21.Text);
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/21", textBox623.Text);
            }
            else
            {
                endcheck();
            }
        }
        public void endcheck_zap(string group, string month)
        {
                File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/endcheck.txt", monthcheck.ToString());
            
        }
        public void createdir(string group,string month)//создание директорий
        {
            Directory.CreateDirectory($@"C:/electron_journal/{group}");
            Directory.CreateDirectory($@"C:/electron_journal/{group}/{month}");
            Directory.CreateDirectory($@"C:/electron_journal/{group}/{month}/data");
            for (int g = 1; g < 31; g++)
            {
                Directory.CreateDirectory($@"C:/electron_journal/{group}/{month}/data/{g}");
            }
            for (int i=1;i<31;i++)
            {
                for(int k=1;k<22;k++)
                {
                    File.Create($@"C:/electron_journal/{group}/{month}/data/{i}/{k}").Close();
                }
            }
            File.Create($@"C:/electron_journal/{group}/{month}/data/endcheck.txt");
        }
        public group_PKS_22_TSI()
        {
            InitializeComponent();
            x = Screen.PrimaryScreen.WorkingArea.Width;
            y = Screen.PrimaryScreen.WorkingArea.Height;
            ClientSize = new System.Drawing.Size(x, y);
        }

        private void group_PKS_22_TSI_Load(object sender, EventArgs e)
        {
            this.SetScrollState(1, true); // Полоса прокрутки
            MessageBox.Show("Пожалуйста, подождите это может занять некоторое время");
            if (!Directory.Exists(@"C:/electron_journal/PKS-21OP03"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-21OP03");
                createdir("PKS-21OP03", "september");
                createdir("PKS-21OP03", "october");
                createdir("PKS-21OP03", "november");
                createdir("PKS-21OP03", "december");
                createdirit("PKS-21OP03", "itog1");
                createdir("PKS-21OP03", "january");
                createdir("PKS-21OP03", "februrary");
                createdir("PKS-21OP03", "march");
                createdir("PKS-21OP03", "april");
                createdir("PKS-21OP03", "may");
                createdir("PKS-21OP03", "june");
                createdirit("PKS-21OP03", "itog2");
                createdirit("PKS-21OP03", "itog_year");


            }
            if (!Directory.Exists(@"C:/electron_journal/PKS-23OP03"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-23OP03");
                createdir("PKS-23OP03", "september");
                createdir("PKS-23OP03", "october");
                createdir("PKS-23OP03", "november");
                createdir("PKS-23OP03", "december");
                createdirit("PKS-23OP03", "itog1");
                createdir("PKS-23OP03", "january");
                createdir("PKS-23OP03", "februrary");
                createdir("PKS-23OP03", "march");
                createdir("PKS-23OP03", "april");
                createdir("PKS-23OP03", "may");
                createdir("PKS-23OP03", "june");
                createdirit("PKS-23OP03", "itog2");
                createdirit("PKS-23OP03", "itog_year");

            }
            if (!Directory.Exists(@"C:/electron_journal/PKS-33OP12"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-33OP12");
                createdir("PKS-33OP12", "september");
                createdir("PKS-33OP12", "october");
                createdir("PKS-33OP12", "november");
                createdir("PKS-33OP12", "december");
                createdirit("PKS-33OP12", "itog1");
                createdir("PKS-33OP12", "january");
                createdir("PKS-33OP12", "februrary");
                createdir("PKS-33OP12", "march");
                createdir("PKS-33OP12", "april");
                createdir("PKS-33OP12", "may");
                createdir("PKS-33OP12", "june");
                createdirit("PKS-33OP12", "itog2");
                createdirit("PKS-33OP12", "itog_year");

            }
            if (!Directory.Exists(@"C:/electron_journal/PKS-22OP03"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-22OP03");
                createdir("PKS-22OP03", "september");
                createdir("PKS-22OP03", "october");
                createdir("PKS-22OP03", "november");
                createdir("PKS-22OP03", "december");
                createdirit("PKS-22OP03", "itog1");
                createdir("PKS-22OP03", "january");
                createdir("PKS-22OP03", "februrary");
                createdir("PKS-22OP03", "march");
                createdir("PKS-22OP03", "april");
                createdir("PKS-22OP03", "may");
                createdir("PKS-22OP03", "june");
                createdirit("PKS-22OP03", "itog2");
                createdirit("PKS-22OP03", "itog_year");



            }

            if (!Directory.Exists(@"C:/electron_journal/IKS-21OP04"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/IKS-21OP04");
                createdir("IKS-21OP04", "september");
                createdir("IKS-21OP04", "october");
                createdir("IKS-21OP04", "november");
                createdir("IKS-21OP04", "december");
                createdirit("IKS-21OP04", "itog1");
                createdir("IKS-21OP04", "january");
                createdir("IKS-21OP04", "februrary");
                createdir("IKS-21OP04", "march");
                createdir("IKS-21OP04", "april");
                createdir("IKS-21OP04", "may");
                createdir("IKS-21OP04", "june");
                createdirit("IKS-21OP04", "itog2");
                createdirit("IKS-21OP04", "itog_year");



            }

            if (!Directory.Exists(@"C:/electron_journal/IB-21OP07"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/IB-21OP07");
                createdir("IB-21OP07", "september");
                createdir("IB-21OP07", "october");
                createdir("IB-21OP07", "november");
                createdir("IB-21OP07", "december");
                createdirit("IB-21OP07", "itog1");
                createdir("IB-21OP07", "january");
                createdir("IB-21OP07", "februrary");
                createdir("IB-21OP07", "march");
                createdir("IB-21OP07", "april");
                createdir("IB-21OP07", "may");
                createdir("IB-21OP07", "june");
                createdirit("IB-21OP07", "itog2");
                createdirit("IB-21OP07", "itog_year");




            }

            if (!Directory.Exists(@"C:/electron_journal/EO-21OP02"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/EO-21OP02");
                createdir("EO-21OP02", "september");
                createdir("EO-21OP02", "october");
                createdir("EO-21OP02", "november");
                createdir("EO-21OP02", "december");
                createdirit("EO-21OP02", "itog1");
                createdir("EO-21OP02", "january");
                createdir("EO-21OP02", "februrary");
                createdir("EO-21OP02", "march");
                createdir("EO-21OP02", "april");
                createdir("EO-21OP02", "may");
                createdir("EO-21OP02", "june");
                createdirit("EO-21OP02", "itog2");
                createdirit("EO-21OP02", "itog_year");


            }

            if (!Directory.Exists(@"C:/electron_journal/EO-21OP04"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/EO-21OP04");
                createdir("EO-21OP04", "september");
                createdir("EO-21OP04", "october");
                createdir("EO-21OP04", "november");
                createdir("EO-21OP04", "december");
                createdirit("EO-21OP04", "itog1");
                createdir("EO-21OP04", "january");
                createdir("EO-21OP04", "februrary");
                createdir("EO-21OP04", "march");
                createdir("EO-21OP04", "april");
                createdir("EO-21OP04", "may");
                createdir("EO-21OP04", "june");
                createdirit("EO-21OP04", "itog2");
                createdirit("EO-21OP04", "itog_year");


            }

            if (!Directory.Exists(@"C:/electron_journal/PKS-31OP12"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-31OP12");
                createdir("PKS-31OP12", "september");
                createdir("PKS-31OP12", "october");
                createdir("PKS-31OP12", "november");
                createdir("PKS-31OP12", "december");
                createdirit("PKS-31OP12", "itog1");
                createdir("PKS-31OP12", "january");
                createdir("PKS-31OP12", "februrary");
                createdir("PKS-31OP12", "march");
                createdir("PKS-31OP12", "april");
                createdir("PKS-31OP12", "may");
                createdir("PKS-31OP12", "june");
                createdirit("PKS-31OP12", "itog2");
                createdirit("PKS-31OP12", "itog_year");


            }

            if (!Directory.Exists(@"C:/electron_journal/PKS-32OP12"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-32OP12");
                createdir("PKS-32OP12", "september");
                createdir("PKS-32OP12", "october");
                createdir("PKS-32OP12", "november");
                createdir("PKS-32OP12", "december");
                createdirit("PKS-32OP12", "itog1");
                createdir("PKS-32OP12", "january");
                createdir("PKS-32OP12", "februrary");
                createdir("PKS-32OP12", "march");
                createdir("PKS-32OP12", "april");
                createdir("PKS-32OP12", "may");
                createdir("PKS-32OP12", "june");
                createdirit("PKS-32OP12", "itog2");
                createdirit("PKS-32OP12", "itog_year");


            }

            if (!Directory.Exists(@"C:/electron_journal/PKS-34OP12"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-34OP12");


                createdir("PKS-34OP12", "september");
                createdir("PKS-34OP12", "october");
                createdir("PKS-34OP12", "november");
                createdir("PKS-34OP12", "december");
                createdirit("PKS-34OP12", "itog1");
                createdir("PKS-34OP12", "january");
                createdir("PKS-34OP12", "februrary");
                createdir("PKS-34OP12", "march");
                createdir("PKS-34OP12", "april");
                createdir("PKS-34OP12", "may");
                createdir("PKS-34OP12", "june");
                createdirit("PKS-34OP12", "itog2");
                createdirit("PKS-34OP12", "itog_year");



            }

            if (!Directory.Exists(@"C:/electron_journal/PKS-34UP01"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-34UP01");


                createdir("PKS-34UP01", "september");
                createdir("PKS-34UP01", "october");
                createdir("PKS-34UP01", "november");
                createdir("PKS-34UP01", "december");
                createdirit("PKS-34UP01", "itog1");
                createdir("PKS-34UP01", "january");
                createdir("PKS-34UP01", "februrary");
                createdir("PKS-34UP01", "march");
                createdir("PKS-34UP01", "april");
                createdir("PKS-34UP01", "may");
                createdir("PKS-34UP01", "june");
                createdirit("PKS-34UP01", "itog2");
                createdirit("PKS-34UP01", "itog_year");


            }

            if (!Directory.Exists(@"C:/electron_journal/PKS-34UP02"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-34UP02");
                createdir("PKS-34UP02", "september");
                createdir("PKS-34UP02", "october");
                createdir("PKS-34UP02", "november");
                createdir("PKS-34UP02", "december");
                createdirit("PKS-34UP02", "itog1");
                createdir("PKS-34UP02", "january");
                createdir("PKS-34UP02", "februrary");
                createdir("PKS-34UP02", "march");
                createdir("PKS-34UP02", "april");
                createdir("PKS-34UP02", "may");
                createdir("PKS-34UP02", "june");
                createdirit("PKS-34UP02", "itog2");
                createdirit("PKS-34UP02", "itog_year");






            }

            if (!Directory.Exists(@"C:/electron_journal/EO-31OP02"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/EO-31OP02");
                createdir("EO-31OP02", "september");
                createdir("EO-31OP02", "october");
                createdir("EO-31OP02", "november");
                createdir("EO-31OP02", "december");
                createdirit("EO-31OP02", "itog1");
                createdir("EO-31OP02", "january");
                createdir("EO-31OP02", "februrary");
                createdir("EO-31OP02", "march");
                createdir("EO-31OP02", "april");
                createdir("EO-31OP02", "may");
                createdir("EO-31OP02", "june");
                createdirit("EO-31OP02", "itog2");
                createdirit("EO-31OP02", "itog_year");

            }

            if (!Directory.Exists(@"C:/electron_journal/EO-31OP09"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/EO-31OP09");
                createdir("EO-31OP09", "september");
                createdir("EO-31OP09", "october");
                createdir("EO-31OP09", "november");
                createdir("EO-31OP09", "december");
                createdirit("EO-31OP09", "itog1");
                createdir("EO-31OP09", "january");
                createdir("EO-31OP09", "februrary");
                createdir("EO-31OP09", "march");
                createdir("EO-31OP09", "april");
                createdir("EO-31OP09", "may");
                createdir("EO-31OP09", "june");
                createdirit("EO-31OP09", "itog2");
                createdirit("EO-21OP09", "itog_year");

            }

            if (!Directory.Exists(@"C:/electron_journal/PKS-41PDP"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-41PDP");
                createdir("PKS-41PDP", "september");
                createdir("PKS-41PDP", "october");
                createdir("PKS-41PDP", "november");
                createdir("PKS-41PDP", "december");
                createdirit("PKS-41PDP", "itog1");
                createdir("PKS-41PDP", "january");
                createdir("PKS-41PDP", "februrary");
                createdir("PKS-41PDP", "march");
                createdir("PKS-41PDP", "april");
                createdir("PKS-41PDP", "may");
                createdir("PKS-41PDP", "june");
                createdirit("PKS-41PDP", "itog2");
                createdirit("PKS-41PDP", "itog_year");

            }

            if (!Directory.Exists(@"C:/electron_journal/PKS-41GIA"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/PKS-41GIA");
                createdir("PKS-41GIA", "september");
                createdir("PKS-41GIA", "october");
                createdir("PKS-41GIA", "november");
                createdir("PKS-41GIA", "december");
                createdirit("PKS-41GIA", "itog1");
                createdir("PKS-41GIA", "january");
                createdir("PKS-41GIA", "februrary");
                createdir("PKS-41GIA", "march");
                createdir("PKS-41GIA", "april");
                createdir("PKS-41GIA", "may");
                createdir("PKS-41GIA", "june");
                createdirit("PKS-41GIA", "itog2");
                createdirit("PKS-41GIA", "itog_year");

            }

            if (!Directory.Exists(@"C:/electron_journal/EO-41OP09"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/EO-41OP09");
                createdir("EO-41OP09", "september");
                createdir("EO-41OP09", "october");
                createdir("EO-41OP09", "november");
                createdir("EO-41OP09", "december");
                createdirit("EO-41OP09", "itog1");
                createdir("EO-41OP09", "january");
                createdir("EO-41OP09", "februrary");
                createdir("EO-41OP09", "march");
                createdir("EO-41OP09", "april");
                createdir("EO-41OP09", "may");
                createdir("EO-41OP09", "june");
                createdirit("EO-41OP09", "itog2");
                createdirit("EO-41OP09", "itog_year");

            }
            MessageBox.Show("Все загрузилось. Спасибо за ожидание.");
           
           
               
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ПКС-21 ОП.03 ТСИ")
            {
               group_loc = "PKS-21OP03";
            }
            else if(comboBox1.Text == "ПКС - 22 ОП.03 ТСИ")
            {
                group_loc = "PKS-22OP03";
            }
            else if (comboBox1.Text == "ПКС - 23 ОП.03 ТСИ")
            {
                group_loc = "PKS-23OP03";
            }
            else if (comboBox1.Text == "ИКС - 21 ОП.04 ВТ")
            {
                group_loc = "IKS-21OP04";
            }
            else if (comboBox1.Text == "ИБ - 21 ОП.07 ТСИ")
            {
                group_loc = "IB-21OP07";
            }
            else if (comboBox1.Text == "ЭО - 21 ОП.02 ТМ 4")
            {
                group_loc = "EO-21OP02";
            }
            else if (comboBox1.Text == "ЭО - 21 ОП.04 ТИ")
            {
                group_loc = "EO-21OP04";
            }
            else if (comboBox1.Text == "ПКС - 31 ОП.12 ОПАИС")
            {
                group_loc = "PKS-31OP12";
            }
            else if (comboBox1.Text == "ПКС - 32 ОП.12 ОПАИС")
            {
                group_loc = "PKS-32OP12";
            }
            else if (comboBox1.Text == "ПКС - 33 ОП.12 ОПАИС")
            {
                group_loc = "PKS-33OP12";
            }
            else if (comboBox1.Text == "ПКС - 34 ОП.12 ОПАИС")
            {
                group_loc = "PKS-34OP12";
            }
            else if (comboBox1.Text == "ПКС - 34 УП.01 РПМПО для КС")
            {
                group_loc = "PKS-34UP01";
            }
            else if (comboBox1.Text == "ПКС - 34 УП.02 Р и АБД")
            {
                group_loc = "PKS-21OP03";
            }
            else if (comboBox1.Text == "ЭО - 31 ОП.02 ТМ")
            {
                group_loc = "PKS-34UP02";
            }
            else if (comboBox1.Text == "ЭО - 31 ОП.09 ВТ")
            {
                group_loc = "EO-31OP09";
            }
            else if (comboBox1.Text == "ПКС - 41 ПДП ПП")
            {
                group_loc = "PKS-41PDP";
            }
            else if (comboBox1.Text == "ПКС - 41 ГИА консультации")
            {
                group_loc = "PKS-41GIA";
            }
            else if (comboBox1.Text == "ЭО - 41 ОП.09 ВТ")
            {
                group_loc = "EO-41OP09";
            }

            if ((comboBox2.Text != "Выбрать месяц")&& (comboBox1.Text != "Выбрать группу"))
            {
                button1.Enabled = true;
                button4.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (monthcheck)
            {
                 endcheck();
            }
            else
            {
                //делать обработчики для нб
                    //подсчет заполненных клеток
                if (textBox37.Text != "")
                {
                    if (textBox36.Text != "")
                    {
                        if (textBox35.Text != "")
                        {
                            if (textBox34.Text != "")
                            {
                                if (textBox33.Text != "")
                                {
                                    if (textBox32.Text != "")
                                    {
                                        if (textBox31.Text != "")
                                        {
                                            if (textBox30.Text != "")
                                            {
                                                if (textBox29.Text != "")
                                                {
                                                    if (textBox28.Text != "")
                                                    {
                                                        if (textBox27.Text != "")
                                                        {
                                                            if (textBox26.Text != "")
                                                            {
                                                                if (textBox25.Text != "")
                                                                {
                                                                    if (textBox24.Text != "")
                                                                    {
                                                                        if (textBox38.Text != "")
                                                                        {
                                                                            if (textBox39.Text != "")
                                                                            {
                                                                                if (textBox23.Text != "")
                                                                                {
                                                                                    if (textBox40.Text != "")
                                                                                    {
                                                                                        if (textBox22.Text != "")
                                                                                        {
                                                                                            if (textBox21.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }
                
                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox37.Text == "нб" || textBox37.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox36.Text == "нб" || textBox36.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox35.Text == "нб" || textBox35.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox34.Text == "нб" || textBox34.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox33.Text == "нб" || textBox33.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox32.Text == "нб" || textBox32.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox31.Text == "нб" || textBox31.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox30.Text == "нб" || textBox30.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox29.Text == "Нб" || textBox29.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox28.Text == "нб" || textBox28.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox27.Text == "нб" || textBox27.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox26.Text == "нб" || textBox26.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox25.Text == "нб" || textBox25.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox24.Text == "нб" || textBox24.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox38.Text == "нб" || textBox38.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox39.Text == "нб" || textBox39.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox23.Text == "нб" || textBox23.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox40.Text == "нб" || textBox40.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox22.Text == "нб" || textBox22.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox21.Text == "нб" || textBox21.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox37.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox36.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox35.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox34.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox33.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox32.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox31.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox30.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox29.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox28.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox27.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox26.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox25.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox24.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox38.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox39.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox23.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox40.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox22.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox21.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox623.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc,month_loc);





                //2 строка


                if (textBox57.Text != "")
                {
                    if (textBox56.Text != "")
                    {
                        if (textBox55.Text != "")
                        {
                            if (textBox54.Text != "")
                            {
                                if (textBox53.Text != "")
                                {
                                    if (textBox52.Text != "")
                                    {
                                        if (textBox51.Text != "")
                                        {
                                            if (textBox50.Text != "")
                                            {
                                                if (textBox49.Text != "")
                                                {
                                                    if (textBox48.Text != "")
                                                    {
                                                        if (textBox47.Text != "")
                                                        {
                                                            if (textBox46.Text != "")
                                                            {
                                                                if (textBox45.Text != "")
                                                                {
                                                                    if (textBox44.Text != "")
                                                                    {
                                                                        if (textBox58.Text != "")
                                                                        {
                                                                            if (textBox59.Text != "")
                                                                            {
                                                                                if (textBox43.Text != "")
                                                                                {
                                                                                    if (textBox60.Text != "")
                                                                                    {
                                                                                        if (textBox42.Text != "")
                                                                                        {
                                                                                            if (textBox41.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox57.Text == "нб" || textBox57.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox56.Text == "нб" || textBox56.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox55.Text == "нб" || textBox55.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox54.Text == "нб" || textBox54.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox53.Text == "нб" || textBox53.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox52.Text == "нб" || textBox52.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox51.Text == "нб" || textBox51.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox50.Text == "нб" || textBox50.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox49.Text == "Нб" || textBox49.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox48.Text == "нб" || textBox48.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox47.Text == "нб" || textBox47.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox46.Text == "нб" || textBox46.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox45.Text == "нб" || textBox45.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox44.Text == "нб" || textBox44.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox58.Text == "нб" || textBox58.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox59.Text == "нб" || textBox59.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox43.Text == "нб" || textBox43.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox60.Text == "нб" || textBox60.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox42.Text == "нб" || textBox42.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox41.Text == "нб" || textBox41.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox57.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox56.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox55.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox54.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox53.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox52.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox51.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox50.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox49.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox48.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox47.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox46.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox45.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox44.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox58.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox59.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox43.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox60.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox42.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox41.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox624.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //3 строка


                if (textBox77.Text != "")
                {
                    if (textBox76.Text != "")
                    {
                        if (textBox75.Text != "")
                        {
                            if (textBox74.Text != "")
                            {
                                if (textBox73.Text != "")
                                {
                                    if (textBox72.Text != "")
                                    {
                                        if (textBox71.Text != "")
                                        {
                                            if (textBox70.Text != "")
                                            {
                                                if (textBox69.Text != "")
                                                {
                                                    if (textBox68.Text != "")
                                                    {
                                                        if (textBox67.Text != "")
                                                        {
                                                            if (textBox66.Text != "")
                                                            {
                                                                if (textBox65.Text != "")
                                                                {
                                                                    if (textBox64.Text != "")
                                                                    {
                                                                        if (textBox78.Text != "")
                                                                        {
                                                                            if (textBox79.Text != "")
                                                                            {
                                                                                if (textBox63.Text != "")
                                                                                {
                                                                                    if (textBox80.Text != "")
                                                                                    {
                                                                                        if (textBox62.Text != "")
                                                                                        {
                                                                                            if (textBox61.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox77.Text == "нб" || textBox77.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox76.Text == "нб" || textBox76.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox75.Text == "нб" || textBox75.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox74.Text == "нб" || textBox74.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox73.Text == "нб" || textBox73.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox72.Text == "нб" || textBox72.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox71.Text == "нб" || textBox71.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox70.Text == "нб" || textBox70.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox69.Text == "Нб" || textBox69.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox68.Text == "нб" || textBox68.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox67.Text == "нб" || textBox67.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox66.Text == "нб" || textBox66.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox65.Text == "нб" || textBox65.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox64.Text == "нб" || textBox4.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox78.Text == "нб" || textBox78.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox79.Text == "нб" || textBox79.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox63.Text == "нб" || textBox63.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox80.Text == "нб" || textBox80.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox62.Text == "нб" || textBox62.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox61.Text == "нб" || textBox61.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox77.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox76.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox75.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox74.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox73.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox72.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox71.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox70.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox69.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox68.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox67.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox66.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox65.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox64.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox78.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox79.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox63.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox80.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox62.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox61.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox625.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //4 строка

                if (textBox97.Text != "")
                {
                    if (textBox96.Text != "")
                    {
                        if (textBox95.Text != "")
                        {
                            if (textBox94.Text != "")
                            {
                                if (textBox93.Text != "")
                                {
                                    if (textBox92.Text != "")
                                    {
                                        if (textBox91.Text != "")
                                        {
                                            if (textBox90.Text != "")
                                            {
                                                if (textBox89.Text != "")
                                                {
                                                    if (textBox88.Text != "")
                                                    {
                                                        if (textBox87.Text != "")
                                                        {
                                                            if (textBox86.Text != "")
                                                            {
                                                                if (textBox85.Text != "")
                                                                {
                                                                    if (textBox84.Text != "")
                                                                    {
                                                                        if (textBox98.Text != "")
                                                                        {
                                                                            if (textBox99.Text != "")
                                                                            {
                                                                                if (textBox83.Text != "")
                                                                                {
                                                                                    if (textBox100.Text != "")
                                                                                    {
                                                                                        if (textBox82.Text != "")
                                                                                        {
                                                                                            if (textBox81.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox97.Text == "нб" || textBox97.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox96.Text == "нб" || textBox96.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox95.Text == "нб" || textBox95.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox94.Text == "нб" || textBox94.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox93.Text == "нб" || textBox93.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox92.Text == "нб" || textBox92.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox91.Text == "нб" || textBox91.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox90.Text == "нб" || textBox90.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox89.Text == "Нб" || textBox89.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox88.Text == "нб" || textBox88.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox87.Text == "нб" || textBox87.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox86.Text == "нб" || textBox86.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox85.Text == "нб" || textBox85.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox84.Text == "нб" || textBox84.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox98.Text == "нб" || textBox98.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox99.Text == "нб" || textBox99.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox83.Text == "нб" || textBox83.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox100.Text == "нб" || textBox100.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox82.Text == "нб" || textBox82.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox81.Text == "нб" || textBox81.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox97.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox96.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox95.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox94.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox93.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox92.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox91.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox90.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox89.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox88.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox87.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox86.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox85.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox84.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox98.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox99.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox83.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox100.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox82.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox81.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox626.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //5 строка

                if (textBox117.Text != "")
                {
                    if (textBox116.Text != "")
                    {
                        if (textBox115.Text != "")
                        {
                            if (textBox114.Text != "")
                            {
                                if (textBox113.Text != "")
                                {
                                    if (textBox112.Text != "")
                                    {
                                        if (textBox111.Text != "")
                                        {
                                            if (textBox110.Text != "")
                                            {
                                                if (textBox109.Text != "")
                                                {
                                                    if (textBox108.Text != "")
                                                    {
                                                        if (textBox107.Text != "")
                                                        {
                                                            if (textBox106.Text != "")
                                                            {
                                                                if (textBox105.Text != "")
                                                                {
                                                                    if (textBox104.Text != "")
                                                                    {
                                                                        if (textBox118.Text != "")
                                                                        {
                                                                            if (textBox119.Text != "")
                                                                            {
                                                                                if (textBox103.Text != "")
                                                                                {
                                                                                    if (textBox120.Text != "")
                                                                                    {
                                                                                        if (textBox102.Text != "")
                                                                                        {
                                                                                            if (textBox101.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox117.Text == "нб" || textBox117.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox116.Text == "нб" || textBox116.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox115.Text == "нб" || textBox115.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox114.Text == "нб" || textBox114.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox113.Text == "нб" || textBox113.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox112.Text == "нб" || textBox112.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox111.Text == "нб" || textBox111.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox110.Text == "нб" || textBox110.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox109.Text == "Нб" || textBox109.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox108.Text == "нб" || textBox108.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox107.Text == "нб" || textBox107.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox106.Text == "нб" || textBox106.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox105.Text == "нб" || textBox105.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox104.Text == "нб" || textBox104.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox118.Text == "нб" || textBox118.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox19.Text == "нб" || textBox119.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox103.Text == "нб" || textBox103.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox120.Text == "нб" || textBox120.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox102.Text == "нб" || textBox102.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox101.Text == "нб" || textBox101.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox117.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox116.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox115.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox114.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox113.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox112.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox111.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox110.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox109.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox108.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox107.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox106.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox105.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox104.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox118.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox119.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox103.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox120.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox102.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox101.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox627.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //6 строка

                if (textBox137.Text != "")
                {
                    if (textBox136.Text != "")
                    {
                        if (textBox135.Text != "")
                        {
                            if (textBox134.Text != "")
                            {
                                if (textBox133.Text != "")
                                {
                                    if (textBox132.Text != "")
                                    {
                                        if (textBox131.Text != "")
                                        {
                                            if (textBox130.Text != "")
                                            {
                                                if (textBox129.Text != "")
                                                {
                                                    if (textBox128.Text != "")
                                                    {
                                                        if (textBox127.Text != "")
                                                        {
                                                            if (textBox126.Text != "")
                                                            {
                                                                if (textBox125.Text != "")
                                                                {
                                                                    if (textBox124.Text != "")
                                                                    {
                                                                        if (textBox138.Text != "")
                                                                        {
                                                                            if (textBox139.Text != "")
                                                                            {
                                                                                if (textBox123.Text != "")
                                                                                {
                                                                                    if (textBox140.Text != "")
                                                                                    {
                                                                                        if (textBox122.Text != "")
                                                                                        {
                                                                                            if (textBox121.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox137.Text == "нб" || textBox137.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox136.Text == "нб" || textBox136.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox135.Text == "нб" || textBox135.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox134.Text == "нб" || textBox134.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox133.Text == "нб" || textBox133.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox132.Text == "нб" || textBox132.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox131.Text == "нб" || textBox131.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox130.Text == "нб" || textBox130.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox129.Text == "Нб" || textBox129.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox128.Text == "нб" || textBox128.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox127.Text == "нб" || textBox127.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox126.Text == "нб" || textBox126.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox125.Text == "нб" || textBox125.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox124.Text == "нб" || textBox124.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox138.Text == "нб" || textBox138.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox139.Text == "нб" || textBox139.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox123.Text == "нб" || textBox123.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox140.Text == "нб" || textBox140.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox122.Text == "нб" || textBox122.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox121.Text == "нб" || textBox121.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox137.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox136.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox135.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox134.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox133.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox132.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox131.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox130.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox129.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox128.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox127.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox126.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox125.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox124.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox138.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox139.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox123.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox140.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox122.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox121.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox628.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //7 строка

                if (textBox157.Text != "")
                {
                    if (textBox156.Text != "")
                    {
                        if (textBox155.Text != "")
                        {
                            if (textBox154.Text != "")
                            {
                                if (textBox153.Text != "")
                                {
                                    if (textBox152.Text != "")
                                    {
                                        if (textBox151.Text != "")
                                        {
                                            if (textBox150.Text != "")
                                            {
                                                if (textBox149.Text != "")
                                                {
                                                    if (textBox148.Text != "")
                                                    {
                                                        if (textBox147.Text != "")
                                                        {
                                                            if (textBox146.Text != "")
                                                            {
                                                                if (textBox145.Text != "")
                                                                {
                                                                    if (textBox144.Text != "")
                                                                    {
                                                                        if (textBox158.Text != "")
                                                                        {
                                                                            if (textBox159.Text != "")
                                                                            {
                                                                                if (textBox143.Text != "")
                                                                                {
                                                                                    if (textBox160.Text != "")
                                                                                    {
                                                                                        if (textBox142.Text != "")
                                                                                        {
                                                                                            if (textBox141.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox157.Text == "нб" || textBox157.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox156.Text == "нб" || textBox156.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox155.Text == "нб" || textBox155.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox154.Text == "нб" || textBox154.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox153.Text == "нб" || textBox153.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox152.Text == "нб" || textBox152.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox151.Text == "нб" || textBox151.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox150.Text == "нб" || textBox150.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox149.Text == "Нб" || textBox149.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox148.Text == "нб" || textBox148.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox147.Text == "нб" || textBox147.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox146.Text == "нб" || textBox146.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox145.Text == "нб" || textBox145.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox144.Text == "нб" || textBox144.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox158.Text == "нб" || textBox158.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox159.Text == "нб" || textBox159.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox143.Text == "нб" || textBox143.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox160.Text == "нб" || textBox160.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox142.Text == "нб" || textBox142.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox141.Text == "нб" || textBox141.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox157.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox156.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox155.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox154.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox153.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox152.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox151.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox150.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox149.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox148.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox147.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox146.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox145.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox144.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox158.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox159.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox143.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox160.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox142.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox141.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox629.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //8 строка

                if (textBox177.Text != "")
                {
                    if (textBox176.Text != "")
                    {
                        if (textBox175.Text != "")
                        {
                            if (textBox174.Text != "")
                            {
                                if (textBox173.Text != "")
                                {
                                    if (textBox172.Text != "")
                                    {
                                        if (textBox171.Text != "")
                                        {
                                            if (textBox170.Text != "")
                                            {
                                                if (textBox169.Text != "")
                                                {
                                                    if (textBox168.Text != "")
                                                    {
                                                        if (textBox167.Text != "")
                                                        {
                                                            if (textBox166.Text != "")
                                                            {
                                                                if (textBox165.Text != "")
                                                                {
                                                                    if (textBox164.Text != "")
                                                                    {
                                                                        if (textBox178.Text != "")
                                                                        {
                                                                            if (textBox179.Text != "")
                                                                            {
                                                                                if (textBox163.Text != "")
                                                                                {
                                                                                    if (textBox180.Text != "")
                                                                                    {
                                                                                        if (textBox162.Text != "")
                                                                                        {
                                                                                            if (textBox161.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox177.Text == "нб" || textBox177.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox176.Text == "нб" || textBox176.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox175.Text == "нб" || textBox175.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox174.Text == "нб" || textBox174.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox173.Text == "нб" || textBox173.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox172.Text == "нб" || textBox172.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox171.Text == "нб" || textBox171.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox170.Text == "нб" || textBox170.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox169.Text == "Нб" || textBox169.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox168.Text == "нб" || textBox168.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox167.Text == "нб" || textBox167.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox166.Text == "нб" || textBox166.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox165.Text == "нб" || textBox165.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox164.Text == "нб" || textBox164.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox178.Text == "нб" || textBox178.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox179.Text == "нб" || textBox179.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox163.Text == "нб" || textBox163.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox180.Text == "нб" || textBox180.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox162.Text == "нб" || textBox162.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox161.Text == "нб" || textBox161.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox177.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox176.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox175.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox174.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox173.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox172.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox171.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox170.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox169.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox168.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox167.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox166.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox165.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox164.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox178.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox179.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox163.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox180.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox162.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox161.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox630.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //9 строка

                if (textBox197.Text != "")
                {
                    if (textBox196.Text != "")
                    {
                        if (textBox195.Text != "")
                        {
                            if (textBox194.Text != "")
                            {
                                if (textBox193.Text != "")
                                {
                                    if (textBox192.Text != "")
                                    {
                                        if (textBox191.Text != "")
                                        {
                                            if (textBox190.Text != "")
                                            {
                                                if (textBox189.Text != "")
                                                {
                                                    if (textBox188.Text != "")
                                                    {
                                                        if (textBox187.Text != "")
                                                        {
                                                            if (textBox186.Text != "")
                                                            {
                                                                if (textBox185.Text != "")
                                                                {
                                                                    if (textBox184.Text != "")
                                                                    {
                                                                        if (textBox198.Text != "")
                                                                        {
                                                                            if (textBox199.Text != "")
                                                                            {
                                                                                if (textBox183.Text != "")
                                                                                {
                                                                                    if (textBox200.Text != "")
                                                                                    {
                                                                                        if (textBox182.Text != "")
                                                                                        {
                                                                                            if (textBox181.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox197.Text == "нб" || textBox197.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox196.Text == "нб" || textBox196.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox195.Text == "нб" || textBox195.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox194.Text == "нб" || textBox194.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox193.Text == "нб" || textBox193.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox192.Text == "нб" || textBox192.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox191.Text == "нб" || textBox191.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox190.Text == "нб" || textBox190.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox189.Text == "Нб" || textBox189.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox188.Text == "нб" || textBox188.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox187.Text == "нб" || textBox187.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox186.Text == "нб" || textBox186.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox185.Text == "нб" || textBox185.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox184.Text == "нб" || textBox184.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox198.Text == "нб" || textBox198.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox199.Text == "нб" || textBox199.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox183.Text == "нб" || textBox183.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox200.Text == "нб" || textBox200.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox182.Text == "нб" || textBox182.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox181.Text == "нб" || textBox181.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox197.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox196.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox195.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox194.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox193.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox192.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox191.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox190.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox189.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox188.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox187.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox186.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox185.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox184.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox198.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox199.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox183.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox200.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox182.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox181.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox631.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //10 строка

                if (textBox217.Text != "")
                {
                    if (textBox216.Text != "")
                    {
                        if (textBox215.Text != "")
                        {
                            if (textBox214.Text != "")
                            {
                                if (textBox213.Text != "")
                                {
                                    if (textBox212.Text != "")
                                    {
                                        if (textBox211.Text != "")
                                        {
                                            if (textBox210.Text != "")
                                            {
                                                if (textBox209.Text != "")
                                                {
                                                    if (textBox208.Text != "")
                                                    {
                                                        if (textBox207.Text != "")
                                                        {
                                                            if (textBox206.Text != "")
                                                            {
                                                                if (textBox205.Text != "")
                                                                {
                                                                    if (textBox204.Text != "")
                                                                    {
                                                                        if (textBox218.Text != "")
                                                                        {
                                                                            if (textBox219.Text != "")
                                                                            {
                                                                                if (textBox203.Text != "")
                                                                                {
                                                                                    if (textBox220.Text != "")
                                                                                    {
                                                                                        if (textBox202.Text != "")
                                                                                        {
                                                                                            if (textBox201.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox217.Text == "нб" || textBox217.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox216.Text == "нб" || textBox216.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox215.Text == "нб" || textBox215.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox214.Text == "нб" || textBox214.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox213.Text == "нб" || textBox213.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox212.Text == "нб" || textBox212.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox211.Text == "нб" || textBox211.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox210.Text == "нб" || textBox210.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox209.Text == "Нб" || textBox209.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox208.Text == "нб" || textBox208.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox207.Text == "нб" || textBox207.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox206.Text == "нб" || textBox206.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox205.Text == "нб" || textBox205.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox204.Text == "нб" || textBox204.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox218.Text == "нб" || textBox218.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox219.Text == "нб" || textBox219.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox203.Text == "нб" || textBox203.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox220.Text == "нб" || textBox220.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox202.Text == "нб" || textBox202.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox201.Text == "нб" || textBox201.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox217.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox216.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox215.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox214.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox213.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox212.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox211.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox210.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox209.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox208.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox207.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox206.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox205.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox204.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox218.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox219.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox203.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox220.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox202.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox201.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox642.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //11 строка

                if (textBox237.Text != "")
                {
                    if (textBox236.Text != "")
                    {
                        if (textBox235.Text != "")
                        {
                            if (textBox234.Text != "")
                            {
                                if (textBox233.Text != "")
                                {
                                    if (textBox232.Text != "")
                                    {
                                        if (textBox231.Text != "")
                                        {
                                            if (textBox230.Text != "")
                                            {
                                                if (textBox229.Text != "")
                                                {
                                                    if (textBox228.Text != "")
                                                    {
                                                        if (textBox227.Text != "")
                                                        {
                                                            if (textBox226.Text != "")
                                                            {
                                                                if (textBox225.Text != "")
                                                                {
                                                                    if (textBox224.Text != "")
                                                                    {
                                                                        if (textBox238.Text != "")
                                                                        {
                                                                            if (textBox239.Text != "")
                                                                            {
                                                                                if (textBox223.Text != "")
                                                                                {
                                                                                    if (textBox240.Text != "")
                                                                                    {
                                                                                        if (textBox222.Text != "")
                                                                                        {
                                                                                            if (textBox221.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox237.Text == "нб" || textBox237.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox236.Text == "нб" || textBox236.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox235.Text == "нб" || textBox235.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox234.Text == "нб" || textBox234.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox233.Text == "нб" || textBox233.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox232.Text == "нб" || textBox232.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox231.Text == "нб" || textBox231.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox230.Text == "нб" || textBox230.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox229.Text == "Нб" || textBox229.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox228.Text == "нб" || textBox228.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox227.Text == "нб" || textBox227.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox226.Text == "нб" || textBox226.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox225.Text == "нб" || textBox225.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox224.Text == "нб" || textBox224.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox238.Text == "нб" || textBox238.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox239.Text == "нб" || textBox239.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox223.Text == "нб" || textBox223.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox240.Text == "нб" || textBox240.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox222.Text == "нб" || textBox222.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox221.Text == "нб" || textBox221.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox237.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox236.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox235.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox234.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox233.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox232.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox231.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox230.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox229.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox228.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox227.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox226.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox225.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox224.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox238.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox239.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox223.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox240.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox222.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox221.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox635.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //12 строка

                if (textBox257.Text != "")
                {
                    if (textBox256.Text != "")
                    {
                        if (textBox255.Text != "")
                        {
                            if (textBox254.Text != "")
                            {
                                if (textBox253.Text != "")
                                {
                                    if (textBox252.Text != "")
                                    {
                                        if (textBox251.Text != "")
                                        {
                                            if (textBox250.Text != "")
                                            {
                                                if (textBox249.Text != "")
                                                {
                                                    if (textBox248.Text != "")
                                                    {
                                                        if (textBox247.Text != "")
                                                        {
                                                            if (textBox246.Text != "")
                                                            {
                                                                if (textBox245.Text != "")
                                                                {
                                                                    if (textBox244.Text != "")
                                                                    {
                                                                        if (textBox258.Text != "")
                                                                        {
                                                                            if (textBox259.Text != "")
                                                                            {
                                                                                if (textBox243.Text != "")
                                                                                {
                                                                                    if (textBox260.Text != "")
                                                                                    {
                                                                                        if (textBox242.Text != "")
                                                                                        {
                                                                                            if (textBox241.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox257.Text == "нб" || textBox257.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox256.Text == "нб" || textBox256.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox255.Text == "нб" || textBox255.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox254.Text == "нб" || textBox254.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox253.Text == "нб" || textBox253.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox252.Text == "нб" || textBox252.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox251.Text == "нб" || textBox251.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox250.Text == "нб" || textBox250.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox249.Text == "Нб" || textBox249.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox248.Text == "нб" || textBox248.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox247.Text == "нб" || textBox247.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox246.Text == "нб" || textBox246.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox245.Text == "нб" || textBox245.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox244.Text == "нб" || textBox244.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox258.Text == "нб" || textBox258.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox259.Text == "нб" || textBox259.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox243.Text == "нб" || textBox243.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox260.Text == "нб" || textBox260.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox242.Text == "нб" || textBox242.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox241.Text == "нб" || textBox241.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox257.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox256.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox255.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox254.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox253.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox252.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox251.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox250.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox249.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox248.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox247.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox246.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox245.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox244.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox258.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox259.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox243.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox260.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox242.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox241.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox638.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //13 строка

                if (textBox277.Text != "")
                {
                    if (textBox276.Text != "")
                    {
                        if (textBox275.Text != "")
                        {
                            if (textBox274.Text != "")
                            {
                                if (textBox273.Text != "")
                                {
                                    if (textBox272.Text != "")
                                    {
                                        if (textBox271.Text != "")
                                        {
                                            if (textBox270.Text != "")
                                            {
                                                if (textBox269.Text != "")
                                                {
                                                    if (textBox268.Text != "")
                                                    {
                                                        if (textBox267.Text != "")
                                                        {
                                                            if (textBox266.Text != "")
                                                            {
                                                                if (textBox265.Text != "")
                                                                {
                                                                    if (textBox264.Text != "")
                                                                    {
                                                                        if (textBox278.Text != "")
                                                                        {
                                                                            if (textBox279.Text != "")
                                                                            {
                                                                                if (textBox263.Text != "")
                                                                                {
                                                                                    if (textBox280.Text != "")
                                                                                    {
                                                                                        if (textBox262.Text != "")
                                                                                        {
                                                                                            if (textBox261.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox277.Text == "нб" || textBox277.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox276.Text == "нб" || textBox276.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox275.Text == "нб" || textBox275.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox274.Text == "нб" || textBox274.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox273.Text == "нб" || textBox273.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox272.Text == "нб" || textBox272.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox271.Text == "нб" || textBox271.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox270.Text == "нб" || textBox270.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox269.Text == "Нб" || textBox269.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox268.Text == "нб" || textBox268.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox267.Text == "нб" || textBox267.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox266.Text == "нб" || textBox266.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox265.Text == "нб" || textBox265.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox264.Text == "нб" || textBox264.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox278.Text == "нб" || textBox278.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox279.Text == "нб" || textBox279.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox263.Text == "нб" || textBox263.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox280.Text == "нб" || textBox280.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox262.Text == "нб" || textBox262.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox261.Text == "нб" || textBox261.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox277.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox276.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox275.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox274.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox273.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox272.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox271.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox270.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox269.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox268.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox267.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox266.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox265.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox264.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox278.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox279.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox263.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox280.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox262.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox261.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox633.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //14 строка

                if (textBox297.Text != "")
                {
                    if (textBox296.Text != "")
                    {
                        if (textBox295.Text != "")
                        {
                            if (textBox294.Text != "")
                            {
                                if (textBox293.Text != "")
                                {
                                    if (textBox292.Text != "")
                                    {
                                        if (textBox291.Text != "")
                                        {
                                            if (textBox290.Text != "")
                                            {
                                                if (textBox289.Text != "")
                                                {
                                                    if (textBox288.Text != "")
                                                    {
                                                        if (textBox287.Text != "")
                                                        {
                                                            if (textBox286.Text != "")
                                                            {
                                                                if (textBox285.Text != "")
                                                                {
                                                                    if (textBox284.Text != "")
                                                                    {
                                                                        if (textBox298.Text != "")
                                                                        {
                                                                            if (textBox299.Text != "")
                                                                            {
                                                                                if (textBox283.Text != "")
                                                                                {
                                                                                    if (textBox300.Text != "")
                                                                                    {
                                                                                        if (textBox282.Text != "")
                                                                                        {
                                                                                            if (textBox281.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox297.Text == "нб" || textBox297.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox296.Text == "нб" || textBox296.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox295.Text == "нб" || textBox295.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox294.Text == "нб" || textBox294.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox293.Text == "нб" || textBox293.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox292.Text == "нб" || textBox292.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox291.Text == "нб" || textBox291.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox290.Text == "нб" || textBox290.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox289.Text == "Нб" || textBox289.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox288.Text == "нб" || textBox288.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox287.Text == "нб" || textBox287.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox286.Text == "нб" || textBox286.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox285.Text == "нб" || textBox285.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox284.Text == "нб" || textBox284.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox298.Text == "нб" || textBox298.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox299.Text == "нб" || textBox299.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox283.Text == "нб" || textBox283.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox300.Text == "нб" || textBox300.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox282.Text == "нб" || textBox282.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox281.Text == "нб" || textBox281.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox297.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox296.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox295.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox294.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox293.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox292.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox291.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox290.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox289.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox288.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox287.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox286.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox285.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox284.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox298.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox299.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox283.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox300.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox282.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox281.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox639.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //15 строка

                if (textBox317.Text != "")
                {
                    if (textBox316.Text != "")
                    {
                        if (textBox315.Text != "")
                        {
                            if (textBox314.Text != "")
                            {
                                if (textBox313.Text != "")
                                {
                                    if (textBox312.Text != "")
                                    {
                                        if (textBox311.Text != "")
                                        {
                                            if (textBox310.Text != "")
                                            {
                                                if (textBox309.Text != "")
                                                {
                                                    if (textBox308.Text != "")
                                                    {
                                                        if (textBox307.Text != "")
                                                        {
                                                            if (textBox306.Text != "")
                                                            {
                                                                if (textBox305.Text != "")
                                                                {
                                                                    if (textBox304.Text != "")
                                                                    {
                                                                        if (textBox318.Text != "")
                                                                        {
                                                                            if (textBox319.Text != "")
                                                                            {
                                                                                if (textBox303.Text != "")
                                                                                {
                                                                                    if (textBox320.Text != "")
                                                                                    {
                                                                                        if (textBox302.Text != "")
                                                                                        {
                                                                                            if (textBox301.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox317.Text == "нб" || textBox317.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox316.Text == "нб" || textBox316.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox315.Text == "нб" || textBox315.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox314.Text == "нб" || textBox314.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox313.Text == "нб" || textBox313.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox312.Text == "нб" || textBox312.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox311.Text == "нб" || textBox311.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox310.Text == "нб" || textBox310.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox309.Text == "Нб" || textBox309.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox308.Text == "нб" || textBox308.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox307.Text == "нб" || textBox307.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox306.Text == "нб" || textBox306.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox305.Text == "нб" || textBox305.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox304.Text == "нб" || textBox304.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox318.Text == "нб" || textBox318.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox319.Text == "нб" || textBox319.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox303.Text == "нб" || textBox303.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox320.Text == "нб" || textBox320.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox302.Text == "нб" || textBox302.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox301.Text == "нб" || textBox301.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox317.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox316.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox315.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox314.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox313.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox312.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox311.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox310.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox309.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox308.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox307.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox306.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox305.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox304.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox318.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox319.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox303.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox320.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox302.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox301.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox640.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //16 строка

                if (textBox337.Text != "")
                {
                    if (textBox336.Text != "")
                    {
                        if (textBox335.Text != "")
                        {
                            if (textBox334.Text != "")
                            {
                                if (textBox333.Text != "")
                                {
                                    if (textBox332.Text != "")
                                    {
                                        if (textBox331.Text != "")
                                        {
                                            if (textBox330.Text != "")
                                            {
                                                if (textBox329.Text != "")
                                                {
                                                    if (textBox328.Text != "")
                                                    {
                                                        if (textBox327.Text != "")
                                                        {
                                                            if (textBox326.Text != "")
                                                            {
                                                                if (textBox325.Text != "")
                                                                {
                                                                    if (textBox324.Text != "")
                                                                    {
                                                                        if (textBox338.Text != "")
                                                                        {
                                                                            if (textBox339.Text != "")
                                                                            {
                                                                                if (textBox323.Text != "")
                                                                                {
                                                                                    if (textBox340.Text != "")
                                                                                    {
                                                                                        if (textBox322.Text != "")
                                                                                        {
                                                                                            if (textBox321.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox337.Text == "нб" || textBox337.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox336.Text == "нб" || textBox336.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox335.Text == "нб" || textBox335.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox334.Text == "нб" || textBox334.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox333.Text == "нб" || textBox333.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox332.Text == "нб" || textBox332.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox331.Text == "нб" || textBox331.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox330.Text == "нб" || textBox330.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox329.Text == "Нб" || textBox329.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox328.Text == "нб" || textBox328.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox327.Text == "нб" || textBox327.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox326.Text == "нб" || textBox326.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox325.Text == "нб" || textBox325.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox324.Text == "нб" || textBox324.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox338.Text == "нб" || textBox338.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox339.Text == "нб" || textBox339.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox323.Text == "нб" || textBox323.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox340.Text == "нб" || textBox340.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox322.Text == "нб" || textBox322.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox321.Text == "нб" || textBox321.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox337.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox336.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox335.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox334.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox333.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox332.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox331.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox330.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox329.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox328.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox327.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox326.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox325.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox324.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox338.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox339.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox323.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox340.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox322.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox321.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox641.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //17 строка

                if (textBox357.Text != "")
                {
                    if (textBox356.Text != "")
                    {
                        if (textBox355.Text != "")
                        {
                            if (textBox354.Text != "")
                            {
                                if (textBox353.Text != "")
                                {
                                    if (textBox352.Text != "")
                                    {
                                        if (textBox351.Text != "")
                                        {
                                            if (textBox350.Text != "")
                                            {
                                                if (textBox349.Text != "")
                                                {
                                                    if (textBox348.Text != "")
                                                    {
                                                        if (textBox347.Text != "")
                                                        {
                                                            if (textBox346.Text != "")
                                                            {
                                                                if (textBox345.Text != "")
                                                                {
                                                                    if (textBox344.Text != "")
                                                                    {
                                                                        if (textBox358.Text != "")
                                                                        {
                                                                            if (textBox359.Text != "")
                                                                            {
                                                                                if (textBox343.Text != "")
                                                                                {
                                                                                    if (textBox360.Text != "")
                                                                                    {
                                                                                        if (textBox342.Text != "")
                                                                                        {
                                                                                            if (textBox341.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox357.Text == "нб" || textBox357.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox356.Text == "нб" || textBox356.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox355.Text == "нб" || textBox355.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox354.Text == "нб" || textBox354.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox353.Text == "нб" || textBox353.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox352.Text == "нб" || textBox352.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox351.Text == "нб" || textBox351.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox350.Text == "нб" || textBox350.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox349.Text == "Нб" || textBox349.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox348.Text == "нб" || textBox348.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox347.Text == "нб" || textBox347.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox346.Text == "нб" || textBox346.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox345.Text == "нб" || textBox345.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox344.Text == "нб" || textBox344.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox358.Text == "нб" || textBox358.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox359.Text == "нб" || textBox359.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox343.Text == "нб" || textBox343.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox360.Text == "нб" || textBox360.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox342.Text == "нб" || textBox342.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox341.Text == "нб" || textBox341.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox357.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox356.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox355.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox354.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox353.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox352.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox351.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox350.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox349.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox348.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox347.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox346.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox345.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox344.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox358.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox359.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox343.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox360.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox342.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox341.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox634.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //18 строка

                if (textBox377.Text != "")
                {
                    if (textBox376.Text != "")
                    {
                        if (textBox375.Text != "")
                        {
                            if (textBox374.Text != "")
                            {
                                if (textBox373.Text != "")
                                {
                                    if (textBox372.Text != "")
                                    {
                                        if (textBox371.Text != "")
                                        {
                                            if (textBox370.Text != "")
                                            {
                                                if (textBox369.Text != "")
                                                {
                                                    if (textBox368.Text != "")
                                                    {
                                                        if (textBox367.Text != "")
                                                        {
                                                            if (textBox366.Text != "")
                                                            {
                                                                if (textBox365.Text != "")
                                                                {
                                                                    if (textBox364.Text != "")
                                                                    {
                                                                        if (textBox378.Text != "")
                                                                        {
                                                                            if (textBox379.Text != "")
                                                                            {
                                                                                if (textBox363.Text != "")
                                                                                {
                                                                                    if (textBox380.Text != "")
                                                                                    {
                                                                                        if (textBox362.Text != "")
                                                                                        {
                                                                                            if (textBox361.Text != "")
                                                                                            {
                                                                                                zapolneno = 20;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                zapolneno = 19;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            zapolneno = 18;
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        zapolneno = 17;
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    zapolneno = 16;
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                zapolneno = 15;
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            zapolneno = 14;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        zapolneno = 13;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    zapolneno = 12;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                zapolneno = 11;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            zapolneno = 10;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        zapolneno = 9;
                                                    }
                                                }
                                                else
                                                {
                                                    zapolneno = 8;
                                                }
                                            }
                                            else
                                            {
                                                zapolneno = 7;
                                            }
                                        }
                                        else
                                        {
                                            zapolneno = 6;
                                        }
                                    }
                                    else
                                    {
                                        zapolneno = 5;
                                    }
                                }
                                else
                                {
                                    zapolneno = 4;
                                }
                            }
                            else
                            {
                                zapolneno = 3;
                            }
                        }
                        else
                        {
                            zapolneno = 2;
                        }
                    }
                    else
                    {
                        zapolneno = 1;
                    }
                }

                else
                {
                    zapolneno = 0;
                }
                //..конец подсчета заполненных клеток
                //подсчет клеток без нб и их мест
                if (textBox377.Text == "нб" || textBox377.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox376.Text == "нб" || textBox376.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox375.Text == "нб" || textBox375.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox374.Text == "нб" || textBox374.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox373.Text == "нб" || textBox373.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox372.Text == "нб" || textBox372.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox371.Text == "нб" || textBox371.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox370.Text == "нб" || textBox370.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox369.Text == "Нб" || textBox369.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox368.Text == "нб" || textBox368.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox367.Text == "нб" || textBox367.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox366.Text == "нб" || textBox366.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox365.Text == "нб" || textBox365.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox364.Text == "нб" || textBox364.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox378.Text == "нб" || textBox378.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox379.Text == "нб" || textBox379.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox363.Text == "нб" || textBox363.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox380.Text == "нб" || textBox380.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox362.Text == "нб" || textBox362.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox361.Text == "нб" || textBox361.Text == "")
                {
                    snb++;
                    zapolneno--;
                    check[20] = true;
                }
                //..конец подсчета клеток без нб и их мест
                //счет среднего значения с учетом всех факторов
                for (int i = 1; i < 21; i++)
                {
                    if (schet != 20 - x)
                    {
                        if (check[i] != true)
                        {
                            switch (i)
                            {
                                case 1:
                                    summ = summ + Convert.ToInt32(textBox377.Text);
                                    schet++;
                                    break;
                                case 2:
                                    summ = summ + Convert.ToInt32(textBox376.Text);
                                    schet++;
                                    break;
                                case 3:
                                    summ = summ + Convert.ToInt32(textBox375.Text);
                                    schet++;
                                    break;
                                case 4:
                                    summ = summ + Convert.ToInt32(textBox374.Text);
                                    schet++;
                                    break;
                                case 5:
                                    summ = summ + Convert.ToInt32(textBox373.Text);
                                    schet++;
                                    break;
                                case 6:
                                    summ = summ + Convert.ToInt32(textBox372.Text);
                                    schet++;
                                    break;
                                case 7:
                                    summ = summ + Convert.ToInt32(textBox371.Text);
                                    schet++;
                                    break;
                                case 8:
                                    summ = summ + Convert.ToInt32(textBox370.Text);
                                    schet++;
                                    break;
                                case 9:
                                    summ = summ + Convert.ToInt32(textBox369.Text);
                                    schet++;
                                    break;
                                case 10:
                                    summ = summ + Convert.ToInt32(textBox368.Text);
                                    schet++;
                                    break;
                                case 11:
                                    summ = summ + Convert.ToInt32(textBox367.Text);
                                    schet++;
                                    break;
                                case 12:
                                    summ = summ + Convert.ToInt32(textBox366.Text);
                                    schet++;
                                    break;
                                case 13:
                                    summ = summ + Convert.ToInt32(textBox365.Text);
                                    schet++;
                                    break;
                                case 14:
                                    summ = summ + Convert.ToInt32(textBox364.Text);
                                    schet++;
                                    break;
                                case 15:
                                    summ = summ + Convert.ToInt32(textBox378.Text);
                                    schet++;
                                    break;
                                case 16:
                                    summ = summ + Convert.ToInt32(textBox379.Text);
                                    schet++;
                                    break;
                                case 17:
                                    summ = summ + Convert.ToInt32(textBox363.Text);
                                    schet++;
                                    break;
                                case 18:
                                    summ = summ + Convert.ToInt32(textBox380.Text);
                                    schet++;
                                    break;
                                case 19:
                                    summ = summ + Convert.ToInt32(textBox362.Text);
                                    schet++;
                                    break;
                                case 20:
                                    summ = summ + Convert.ToInt32(textBox361.Text);
                                    schet++;
                                    break;
                            }
                        }
                    }
                }
                //..конец счета среднего значения с учетом всех факторов
                summ = summ / (20 - snb);
                textBox632.Text = Convert.ToString(summ);
                summ = 0;
                snb = 0;
                monthcheck = true;
                endcheck_zap(group_loc, month_loc);

                //19 строка
            }
        }
        private void endcheck()
        {
            MessageBox.Show("Месяц уже подсчитан");
        }
        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (!monthcheck)
            {
                if (textBox37.Text == "н")
                {
                    textBox37.Text = "нб";
                }
                if ((textBox37.Text != "нб")&& (!(textBox37.Text == "5" || textBox37.Text == "4" || textBox37.Text == "3" || textBox37.Text == "2" || textBox37.Text == "" || textBox37.Text == "0")))
                {
                        MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                        textBox37.Text = "";
                }
            }
            else
            {

            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Сентябрь")
            {
                month_loc = "september";
            }
            else if(comboBox2.Text == "Октябрь")
            {
                month_loc = "october";
            }

            else if (comboBox2.Text == "Ноябрь")
            {
                month_loc = "november";
            }

            else if (comboBox2.Text == "Декабрь")
            {
                month_loc = "december";
            }

            else if (comboBox2.Text == "Итог1")
            {
                month_loc = "itog1";
            }
            else if (comboBox2.Text == "Январь")
            {
                month_loc = "january";
            }
            else if (comboBox2.Text == "Февраль")
            {
                month_loc = "februrary";
            }
            else if (comboBox2.Text == "Март")
            {
                month_loc = "march";
            }
            else if (comboBox2.Text == "Апрель")
            {
                month_loc = "april";
            }
            else if (comboBox2.Text == "Май")
            {
                month_loc = "may";
            }
            else if (comboBox2.Text == "Июнь")
            {
                month_loc = "june";
            }
            else if (comboBox2.Text == "Итог2")
            {
                month_loc = "itog2";
            }
            else if (comboBox2.Text == "Итог год")
            {
                month_loc = "itog_year";
            }
            if ((comboBox2.Text != "Выбрать месяц" ) && (comboBox1.Text != "Выбрать группу"))
            {
                button1.Enabled = true;
                button4.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (textBox36.Text == "н")
            {
                textBox36.Text = "нб";
            }
            if (textBox36.Text != "нб")
            {
                if (textBox36.Text == "5" || textBox36.Text == "4" || textBox36.Text == "3" || textBox36.Text == "2" || textBox36.Text == "" || textBox36.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox36.Text = "";
                }
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (textBox35.Text == "н")
            {
                textBox35.Text = "нб";
            }
            if (textBox35.Text != "нб")
            {
                if (textBox35.Text == "5" || textBox35.Text == "4" || textBox35.Text == "3" || textBox35.Text == "2" || textBox35.Text == "" || textBox35.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox35.Text = "";
                }
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (textBox34.Text == "н")
            {
                textBox34.Text = "нб";
            }
            if (textBox34.Text != "нб")
            {
                if (textBox34.Text == "5" || textBox34.Text == "4" || textBox34.Text == "3" || textBox34.Text == "2" || textBox34.Text == "" || textBox34.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox34.Text = "";
                }
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.Text == "н")
            {
                textBox33.Text = "нб";
            }
            if (textBox33.Text != "нб")
            {
                if (textBox33.Text == "5" || textBox33.Text == "4" || textBox33.Text == "3" || textBox33.Text == "2" || textBox33.Text == "" || textBox33.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox33.Text = "";
                }
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (textBox32.Text == "н")
            {
                textBox32.Text = "нб";
            }
            if (textBox32.Text != "нб")
            {
                if (textBox32.Text == "5" || textBox32.Text == "4" || textBox32.Text == "3" || textBox32.Text == "2" || textBox32.Text == "" || textBox32.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox32.Text = "";
                }
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (textBox31.Text == "н")
            {
                textBox31.Text = "нб";
            }
            if (textBox31.Text != "нб")
            {
                if (textBox31.Text == "5" || textBox31.Text == "4" || textBox31.Text == "3" || textBox31.Text == "2" || textBox31.Text == "" || textBox31.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox31.Text = "";
                }
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (textBox30.Text == "н")
            {
                textBox30.Text = "нб";
            }
            if (textBox30.Text != "нб")
            {
                if (textBox30.Text == "5" || textBox30.Text == "4" || textBox30.Text == "3" || textBox30.Text == "2" || textBox30.Text == "" || textBox30.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox30.Text = "";
                }
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (textBox29.Text == "н")
            {
                textBox29.Text = "нб";
            }
            if (textBox29.Text != "нб")
            {
                if (textBox29.Text == "5" || textBox29.Text == "4" || textBox29.Text == "3" || textBox29.Text == "2" || textBox29.Text == "" || textBox29.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox29.Text = "";
                }
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text == "н")
            {
                textBox28.Text = "нб";
            }
            if (textBox28.Text != "нб")
            {
                if (textBox28.Text == "5" || textBox28.Text == "4" || textBox28.Text == "3" || textBox28.Text == "2" || textBox28.Text == "" || textBox28.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox28.Text = "";
                }
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text == "н")
            {
                textBox27.Text = "нб";
            }
            if (textBox27.Text != "нб")
            {
                if (textBox27.Text == "5" || textBox27.Text == "4" || textBox27.Text == "3" || textBox27.Text == "2" || textBox27.Text == "" || textBox27.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox27.Text = "";
                }
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text == "н")
            {
                textBox26.Text = "нб";
            }
            if (textBox26.Text != "нб")
            {
                if (textBox26.Text == "5" || textBox26.Text == "4" || textBox26.Text == "3" || textBox26.Text == "2" || textBox26.Text == "" || textBox26.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox26.Text = "";
                }
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text == "н")
            {
                textBox25.Text = "нб";
            }
            if (textBox25.Text != "нб")
            {
                if (textBox25.Text == "5" || textBox25.Text == "4" || textBox25.Text == "3" || textBox25.Text == "2" || textBox25.Text == "" || textBox25.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox25.Text = "";
                }
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text == "н")
            {
                textBox24.Text = "нб";
            }
            if (textBox24.Text != "нб")
            {
                if (textBox24.Text == "5" || textBox24.Text == "4" || textBox24.Text == "3" || textBox24.Text == "2" || textBox24.Text == "" || textBox24.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox24.Text = "";
                }
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (textBox38.Text == "н")
            {
                textBox38.Text = "нб";
            }
            if (textBox29.Text != "нб")
            {
                if (textBox29.Text == "5" || textBox29.Text == "4" || textBox29.Text == "3" || textBox29.Text == "2" || textBox29.Text == "" || textBox29.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox29.Text = "";
                }
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (textBox39.Text == "н")
            {
                textBox39.Text = "нб";
            }
            if (textBox39.Text != "нб")
            {
                if (textBox39.Text == "5" || textBox39.Text == "4" || textBox39.Text == "3" || textBox39.Text == "2" || textBox39.Text == "" || textBox39.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox39.Text = "";
                }
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text == "н")
            {
                textBox23.Text = "нб";
            }
            if (textBox23.Text != "нб")
            {
                if (textBox23.Text == "5" || textBox23.Text == "4" || textBox23.Text == "3" || textBox23.Text == "2" || textBox23.Text == "" || textBox23.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox23.Text = "";
                }
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (textBox40.Text == "н")
            {
                textBox40.Text = "нб";
            }
            if (textBox40.Text != "нб")
            {
                if (textBox40.Text == "5" || textBox40.Text == "4" || textBox40.Text == "3" || textBox40.Text == "2" || textBox40.Text == "" || textBox40.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox40.Text = "";
                }
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text == "н")
            {
                textBox22.Text = "нб";
            }
            if (textBox22.Text != "нб")
            {
                if (textBox22.Text == "5" || textBox22.Text == "4" || textBox22.Text == "3" || textBox22.Text == "2" || textBox22.Text == "" || textBox22.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox22.Text = "";
                }
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text == "н")
            {
                textBox21.Text = "нб";
            }
            if (textBox21.Text != "нб")
            {
                if (textBox21.Text == "5" || textBox21.Text == "4" || textBox21.Text == "3" || textBox21.Text == "2" || textBox21.Text == "" || textBox21.Text == "0")
                {


                }
                else
                {
                    MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                    textBox21.Text = "";
                }
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            savemark(group_loc, month_loc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadmark(group_loc,month_loc);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }
    }
}
