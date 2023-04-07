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
using System.Collections;

namespace Hangman
{
    public partial class Form1 : Form
    {
        TextBox[] letterBoxes = new TextBox[13];
        string[] guessedLetters = new string[26];
        string[] invalidLetter= new string[26];
        int IncorrectGuesses = 0;
        
        public Form1()
        {
            InitializeComponent();
            letterBoxes[0] = TB1;
            letterBoxes[1] = TB2;
            letterBoxes[2] = TB3;
            letterBoxes[3] = TB4;
            letterBoxes[4] = TB5;
            letterBoxes[5] = TB6;
            letterBoxes[6] = TB7;
            letterBoxes[7] = TB8;
            letterBoxes[8] = TB9;
            letterBoxes[9] = TB10;
            letterBoxes[10] = TB11;
            letterBoxes[11] = TB12;
            letterBoxes[12] = TB13;
            TBInvisible();
        }


   
        public void TBInvisible()
        {
            foreach (TextBox item in letterBoxes)
            {
                item.Visible = false;
            }
        }
        
        public string[] allWords()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\msala\OneDrive\Documents\C#\Hangman\engmix.txt");
            return lines;
        }
        public int getWordListLength()
        {
            int length;
            string[] lines = allWords();
            length = lines.Length;
            return length;


        }


        public void EmptyTBVisible(string word)
        {
            int tempNum = 0;
            foreach (TextBox item in letterBoxes)
            {
                if (tempNum != word.Length)
                {
                    item.Visible = true;
                    tempNum++;
                }

            }
        }

        public void ClearAllTB()
        {
            foreach (TextBox item in letterBoxes)
            {
                item.Text = string.Empty;
            }
        }
        public void MakeTBVisible(string word, string UILetter)
        {
            char charLetter = char.Parse(UILetter);
            for(int i = 0; i<word.Length; i++)
            {
                if (word[i] == charLetter){
                    (letterBoxes[i]).Text = UILetter;
                }
            }
        }

        public string listToString(string[] listName)
        {
            string result = "";
            foreach(string letter in listName)
            {
                result += letter;
            }
            return result;
        }
        public void addToList(string[] listName, string toAdd)
        {
            for (int i = 0; i < listName.Length; i++)
            {
                if (listName[i] == null)
                {
                    listName[i] = toAdd;
                    break;
                }
            }
        }

        public bool CheckInList(string[] listName, string UILetter)
        {
            foreach (string letter in listName)
            {
                if (letter == UILetter)
                {
                    return true;
                }
            }
            return false;
        }


        public void DrawLine(int APoint1, int APoint2, int BPoint1, int BPoint2)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, APoint1, APoint2, BPoint1, BPoint2);
            myPen.Dispose();
            formGraphics.Dispose();
        }
        public void DrawCircle()
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(new Pen(System.Drawing.Color.Red), 
                new Rectangle(725, 60, 50, 50));
            myPen.Dispose();
            formGraphics.Dispose();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            ErrorLabel.Text = string.Empty;
            guessedLetters = new string[26];
            invalidLetter = new string[26];
            IncorrectGuesses = 0;
            invalidLettersTB.Text = string.Empty;


            TBInvisible();
            ClearAllTB();

            int length;
            int randomNum;
            string word;
            string[] words;
            length = getWordListLength();
            Random rnd = new Random();
            randomNum = rnd.Next(1, length);
            words = allWords();
            word = words[randomNum];
            while (word.Length > 13)
            {
                randomNum = rnd.Next(1, length);
                word = words[randomNum];
            }
            WordBox.Text = word;
            
            EmptyTBVisible(word);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ErrorLabel.Text = string.Empty;
            bool letterFound = false;
            int wordIndex = 0;
            string UILetter = (GuessTB.Text).ToLower();
            string word = WordBox.Text;
            int letterFoundCount = 0;


            if (word.Length == 0)
            {
                ErrorLabel.Text = "Word not generated";
            }
            else if (UILetter.Length > 1)
            {
                ErrorLabel.Text = "Multiple letters? Not allowed!";
            }
            else if (CheckInList(guessedLetters, UILetter) == true)
            {
                ErrorLabel.Text = "Letter already guessed";
            }
            else if (Char.IsLetter(Convert.ToChar(UILetter)) == false)
            {
                ErrorLabel.Text = "Invalid input, it is not a letter";
            }
            else
            {
                addToList(guessedLetters, UILetter);
                foreach (char wordLetter in word)
                {
                    if(char.Parse(UILetter) == wordLetter)
                    {
                        letterBoxes[wordIndex].Text = UILetter;
                        letterFound= true;
                        for (int i = 0; i < word.Length; i++) 
                        {
                            if (letterBoxes[i].Text != string.Empty)
                            {
                                letterFoundCount++;
                            }
                        }
                        if (letterFoundCount == word.Length)
                        {
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }
                        
                    }
                    wordIndex++;
                }
                if (letterFound == false)
                {
                    ErrorLabel.Text = "letter not in word";
                    addToList(invalidLetter, UILetter);
                    invalidLettersTB.Text = listToString(invalidLetter);
                    IncorrectGuesses++;
                    
                    if (IncorrectGuesses == 1)
                    {
                        DrawLine(500, 30, 500, 300);
                    }
                    else if(IncorrectGuesses == 2)
                    {
                        DrawLine(500, 30, 750, 30);
                    }
                    else if(IncorrectGuesses == 3)
                    {
                        DrawCircle();
                    }
                    else if (IncorrectGuesses == 4)
                    {
                        DrawLine(750, 110, 750, 225);
                    }
                    else if (IncorrectGuesses == 5)
                    {
                        DrawLine(750, 135, 650, 135);
                    }
                    else if (IncorrectGuesses == 6)
                    {
                        DrawLine(750, 135, 850, 135);
                    }
                    else if (IncorrectGuesses == 7)
                    {
                        DrawLine(750, 225, 650, 275);
                    }
                    else if (IncorrectGuesses == 8)
                    {
                        DrawLine(750, 225, 850, 275);
                    }
                    else
                    {
                        DrawLine(750, 30, 750, 90);
                        ErrorLabel.Text = "YOU LOSE!";
                        Form3 f3 = new Form3();
                        f3.LabelText = f3.LabelText + word;
                        f3.Show();
                        
                        this.Hide();
                    }


                }
            }


        }

        
    }
}
