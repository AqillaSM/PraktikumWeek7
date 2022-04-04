using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek7
{
    public partial class FormQuizPanda : Form
    {
        public FormQuizPanda()
        {
            InitializeComponent();
        }
        private void FormQuizPanda_Load(object sender, EventArgs e)
        {
            LabelOutput.Text = "";
        }
        int Huruf1 = 0;
        int Huruf2 = 0;
        int Jarak = 0;
        int PanjangHuruf = 0;
        string Nama = "";
        char Nol;
        string keNol = "";
        int Angka = 0;
        private void ButtonKonversi_Click(object sender, EventArgs e)
        {
            LabelOutput.Text = "";
            // HURUF PERTAMA
            if (TextBoxHuruf1.Text.ToLower() == "a")
            {
                Huruf1 = 0;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "b")
            {
                Huruf1 = 1;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "c")
            {
                Huruf1 = 2;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "d")
            {
                Huruf1 = 3;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "e")
            {
                Huruf1 = 4;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "f")
            {
                Huruf1 = 5;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "g")
            {
                Huruf1 = 6;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "h")
            {
                Huruf1 = 7;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "i")
            {
                Huruf1 = 8;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "j")
            {
                Huruf1 = 9;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "k")
            {
                Huruf1 = 10;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "l")
            {
                Huruf1 = 11;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "m")
            {
                Huruf1 = 12;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "n")
            {
                Huruf1 = 13;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "o")
            {
                Huruf1 = 14;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "p")
            {
                Huruf1 = 15;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "q")
            {
                Huruf1 = 16;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "r")
            {
                Huruf1 = 17;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "s")
            {
                Huruf1 = 18;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "t")
            {
                Huruf1 = 19;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "u")
            {
                Huruf1 = 20;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "v")
            {
                Huruf1 = 21;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "w")
            {
                Huruf1 = 22;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "x")
            {
                Huruf1 = 23;
            }
            else if (TextBoxHuruf1.Text.ToLower() == "y")
            {
                Huruf1 = 24;
            }
            else
            {
                Huruf1 = 25;
            }

            //HURUF KEDUA
            if (TextBoxHuruf2.Text.ToLower() == "a")
            {
                Huruf2 = 0;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "b")
            {
                Huruf2 = 1;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "c")
            {
                Huruf2 = 2;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "d")
            {
                Huruf2 = 3;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "e")
            {
                Huruf2 = 4;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "f")
            {
                Huruf2 = 5;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "g")
            {
                Huruf2 = 6;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "h")
            {
                Huruf2 = 7;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "i")
            {
                Huruf2 = 8;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "j")
            {
                Huruf2 = 9;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "k")
            {
                Huruf2 = 10;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "l")
            {
                Huruf2 = 11;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "m")
            {
                Huruf2 = 12;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "n")
            {
                Huruf2 = 13;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "o")
            {
                Huruf2 = 14;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "p")
            {
                Huruf2 = 15;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "q")
            {
                Huruf2 = 16;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "r")
            {
                Huruf2 = 17;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "s")
            {
                Huruf2 = 18;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "t")
            {
                Huruf2 = 19;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "u")
            {
                Huruf2 = 20;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "v")
            {
                Huruf2 = 21;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "w")
            {
                Huruf2 = 22;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "x")
            {
                Huruf2 = 23;
            }
            else if (TextBoxHuruf2.Text.ToLower() == "y")
            {
                Huruf2 = 24;
            }
            else
            {
                Huruf2 = 25;
            }

            //PENCARIAN JARAK
            if (Huruf1 != Huruf2)
            {
                PanjangHuruf = TextBoxNama.Text.Length;
                Nama = TextBoxNama.Text.ToLower();
                for (int i = 0; i < PanjangHuruf; i++)
                {
                    Jarak = Huruf2 - Huruf1;
                    Nol = Nama[i];
                    keNol = Nol.ToString();
                    if (keNol == "")
                    {
                        LabelOutput.Text = LabelOutput.Text + " ";
                    }
                    else if (keNol != "")
                    {
                        if (keNol == "a")
                        {
                            Angka = 0;
                        }
                        else if (keNol == "b")
                        {
                            Angka = 1;
                        }
                        else if (keNol == "c")
                        {
                            Angka = 2;
                        }
                        else if (keNol == "d")
                        {
                            Angka = 3;
                        }
                        else if (keNol == "e")
                        {
                            Angka = 4;
                        }
                        else if (keNol == "f")
                        {
                            Angka = 5;
                        }
                        else if (keNol == "g")
                        {
                            Angka = 6;
                        }
                        else if (keNol == "h")
                        {
                            Angka = 7;
                        }
                        else if (keNol == "i")
                        {
                            Angka = 8;
                        }
                        else if (keNol == "j")
                        {
                            Angka = 9;
                        }
                        else if (keNol == "k")
                        {
                            Angka = 10;
                        }
                        else if (keNol == "l")
                        {
                            Angka = 11;
                        }
                        else if (keNol == "m")
                        {
                            Angka = 12;
                        }
                        else if (keNol == "n")
                        {
                            Angka = 13;
                        }
                        else if (keNol == "o")
                        {
                            Angka = 14;
                        }
                        else if (keNol == "p")
                        {
                            Angka = 15;
                        }
                        else if (keNol == "q")
                        {
                            Angka = 16;
                        }
                        else if (keNol == "r")
                        {
                            Angka = 17;
                        }
                        else if (keNol == "s")
                        {
                            Angka = 18;
                        }
                        else if (keNol == "t")
                        {
                            Angka = 19;
                        }
                        else if (keNol == "u")
                        {
                            Angka = 20;
                        }
                        else if (keNol == "v")
                        {
                            Angka = 21;
                        }
                        else if (keNol == "w")
                        {
                            Angka = 22;
                        }
                        else if (keNol == "x")
                        {
                            Angka = 23;
                        }
                        else if (keNol == "y")
                        {
                            Angka = 24;
                        }
                        else if (keNol == "z")
                        {
                            Angka = 25;
                        }
                        else
                        {
                            Angka = 100;
                        }

                        if (Angka == 100)
                        {
                            LabelOutput.Text = LabelOutput.Text + " ";
                        }
                        else if (Angka + Jarak < 0)
                        {
                            Jarak = Angka + Jarak;
                            Jarak = 26 + Jarak;
                            if (Jarak == 0)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "A";
                            }
                            else if (Jarak == 1)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "B";
                            }
                            else if (Jarak == 2)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "C";
                            }
                            else if (Jarak == 3)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "D";
                            }
                            else if (Jarak == 4)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "E";
                            }
                            else if (Jarak == 5)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "F";
                            }
                            else if (Jarak == 6)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "G";
                            }
                            else if (Jarak == 7)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "H";
                            }
                            else if (Jarak == 8)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "I";
                            }
                            else if (Jarak == 9)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "J";
                            }
                            else if (Jarak == 10)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "K";
                            }
                            else if (Jarak == 11)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "L";
                            }
                            else if (Jarak == 12)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "M";
                            }
                            else if (Jarak == 13)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "N";
                            }
                            else if (Jarak == 14)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "O";
                            }
                            else if (Jarak == 15)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "P";
                            }
                            else if (Jarak == 16)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "Q";
                            }
                            else if (Jarak == 17)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "R";
                            }
                            else if (Jarak == 18)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "S";
                            }
                            else if (Jarak == 19)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "T";
                            }
                            else if (Jarak == 20)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "U";
                            }
                            else if (Jarak == 21)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "V";
                            }
                            else if (Jarak == 22)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "W";
                            }
                            else if (Jarak == 23)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "X";
                            }
                            else if (Jarak == 24)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "Y";
                            }
                            else if (Jarak == 25)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "Z";
                            }
                            else
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + " salah yang atas bos ";
                            }
                        }
                        else
                        {
                            Jarak = Angka + Jarak;
                            if (Jarak >= 26)
                            {
                                Jarak = Jarak - 26;
                            }

                            if (Jarak == 0)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "A";
                            }
                            else if (Jarak == 1)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "B";
                            }
                            else if (Jarak == 2)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "C";
                            }
                            else if (Jarak == 3)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "D";
                            }
                            else if (Jarak == 4)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "E";
                            }
                            else if (Jarak == 5)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "F";
                            }
                            else if (Jarak == 6)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "G";
                            }
                            else if (Jarak == 7)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "H";
                            }
                            else if (Jarak == 8)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "I";
                            }
                            else if (Jarak == 9)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "J";
                            }
                            else if (Jarak == 10)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "K";
                            }
                            else if (Jarak == 11)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "L";
                            }
                            else if (Jarak == 12)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "M";
                            }
                            else if (Jarak == 13)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "N";
                            }
                            else if (Jarak == 14)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "O";
                            }
                            else if (Jarak == 15)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "P";
                            }
                            else if (Jarak == 16)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "Q";
                            }
                            else if (Jarak == 17)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "R";
                            }
                            else if (Jarak == 18)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "S";
                            }
                            else if (Jarak == 19)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "T";
                            }
                            else if (Jarak == 20)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "U";
                            }
                            else if (Jarak == 21)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "V";
                            }
                            else if (Jarak == 22)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "W";
                            }
                            else if (Jarak == 23)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "x";
                            }
                            else if (Jarak == 24)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "Y";
                            }
                            else if (Jarak == 25)
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + "Z";
                            }
                            else
                            {
                                LabelOutput.Text = LabelOutput.Text.ToUpper() + " salah yang bawah bos ";
                            }
                        }
                    }
                }
            }
            else
            {
                LabelOutput.Text = TextBoxNama.Text.ToUpper();
            }
        }
    }
}
