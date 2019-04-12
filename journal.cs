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
        public int beznb=0;
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
            Directory.CreateDirectory($@"C:/electron_journal/{group}/itog");
            Directory.CreateDirectory($@"C:/electron_journal/{group}/itog/data");
            for (int g = 1; g < 31; g++)
            {
                File.Create($@"C:/electron_journal/{group}/itog/data/{g}").Close(); ;
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

        }
        public void savemark(string group,string month)//сохранение оценок на одну группу на один месяц
        {
            
            File.WriteAllText($@"C:/electron_journal/{group}/{month}/data/1/1",textBox37.Text);
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
            VScrollBar vsb1 = new VScrollBar();
            vsb1.Dock = DockStyle.Right;
            Controls.Add(vsb1);
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (monthcheck)
            {
                goto endcheck;
            }
            else
            {
                //делать обработчики для нб
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
                if (textBox37.Text == "нб" || textBox37.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[1] = true;
                }
                if (textBox36.Text == "нб" || textBox36.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[2] = true;
                }
                if (textBox35.Text == "нб" || textBox35.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[3] = true;
                }
                if (textBox34.Text == "нб" || textBox34.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[4] = true;
                }
                if (textBox33.Text == "нб" || textBox33.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[5] = true;
                }
                if (textBox32.Text == "нб" || textBox32.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[6] = true;
                }
                if (textBox31.Text == "нб" || textBox31.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[7] = true;
                }
                if (textBox30.Text == "нб" || textBox30.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[8] = true;
                }
                if (textBox29.Text == "Нб" || textBox29.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[9] = true;
                }
                if (textBox28.Text == "нб" || textBox28.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[10] = true;
                }
                if (textBox27.Text == "нб" || textBox27.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[11] = true;
                }
                if (textBox26.Text == "нб" || textBox26.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[12] = true;
                }
                if (textBox25.Text == "нб" || textBox25.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[13] = true;
                }
                if (textBox24.Text == "нб" || textBox24.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[14] = true;
                }
                if (textBox38.Text == "нб" || textBox38.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[15] = true;
                }
                if (textBox39.Text == "нб" || textBox39.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[16] = true;
                }
                if (textBox23.Text == "нб" || textBox23.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[17] = true;
                }
                if (textBox40.Text == "нб" || textBox40.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[18] = true;
                }
                if (textBox22.Text == "нб" || textBox22.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[19] = true;
                }
                if (textBox21.Text == "нб" || textBox21.Text == "")
                {
                    beznb++;
                    zapolneno--;
                    check[20] = true;
                }
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
                summ = summ / (20 - beznb);
                textBox623.Text = Convert.ToString(summ);
                summ = 0;
                beznb = 0;
                monthcheck = true;
            }
            endcheck:

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
                if (textBox37.Text != "нб")
                {
                    if (textBox37.Text == "5" || textBox37.Text == "4" || textBox37.Text == "3" || textBox37.Text == "2" || textBox37.Text == "" || textBox37.Text == "0")
                    {


                    }
                    else
                    {
                        MessageBox.Show("Оценка может быть только от 2 до 5 или нб");
                        textBox37.Text = "";
                    }
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
            

            if (!Directory.Exists(@"C:/electron_journal"))
            {
                Directory.CreateDirectory(@"C:/electron_journal");
            }

            if(!Directory.Exists(@"C:/electron_journal/september"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/september");
            }

            if (!Directory.Exists(@"C:/electron_journal/october"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/october");
            }

            if (!Directory.Exists(@"C:/electron_journal/november"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/november");
            }

            if (!Directory.Exists(@"C:/electron_journal/itog1"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/itog1");
            }


            if (!Directory.Exists(@"C:/electron_journal/june"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/june");
            }

            if (!Directory.Exists(@"C:/electron_journal/feburary"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/feburary");
            }

            if (!Directory.Exists(@"C:/electron_journal/march"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/march");
            }

            if (!Directory.Exists(@"C:/electron_journal/april"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/april");
            }

            if (!Directory.Exists(@"C:/electron_journal/may"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/may");
            }

            if (!Directory.Exists(@"C:/electron_journal/june"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/june");
            }

            if (!Directory.Exists(@"C:/electron_journal/itog2"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/itog2");
            }

            if (!Directory.Exists(@"C:/electron_journal/december"))
            {
                Directory.CreateDirectory(@"C:/electron_journal/december");
            }
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
