namespace PigLatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string[] english = txtEnglish.Text.Split();
            string pigLatin = "";
            string vowels = "aeiouAEIOU";
            string consonants = "bcdfghjklmnpqrstvwxyz";
            consonants = consonants+consonants.ToUpper();
            string punctuation = ".,?!";
            string symbols = "()@#$%^&*<>";
            string numbers = "1234567890";
            string newWord = "";
            bool badWord = false;

            foreach (string word in english)
            {
                badWord = false;
                for (int i = 0; i < word.Length; i++)
                {
                    char testVowel = word[i];
                    if (symbols.Contains(testVowel) || numbers.Contains(testVowel))
                    {
                        badWord = true;
                    }
                }
                if (badWord)
                { 
                    newWord = word;
                }
                else if (vowels.Contains(word[0]))
                {
                    char punc = word[^1];
                    if (punctuation.Contains(punc))
                    {
                        newWord = word[0..^2] + "way" + punc;
                    }
                    else
                    {
                        newWord = word + "way";
                    }
                } else if (consonants.Contains(word[0])) 
                {
                    int vowelidx = -1;
                    for (int i = 0; i < word.Length; i++)
                    {
                        char testVowel = word[i];
                        if (vowels.Contains(testVowel) && vowelidx == -1) 
                        {
                            vowelidx = i;
                        }
                    }
                    char punc = word[^1];
                    if (punctuation.Contains(punc))
                    {
                        if (vowelidx != -1)
                        {
                            newWord = word[vowelidx..^1] + word.Substring(0, vowelidx);
                        }
                        else
                        {
                            newWord = word[0..^1];
                        }
                        newWord = newWord + "ay" + punc;
                    }
                    else
                    {
                        if (vowelidx != -1)
                        {
                            newWord = word[vowelidx..] + word.Substring(0, vowelidx);
                        }
                        else
                        {
                            newWord = word[0..];
                        }
                        newWord = newWord + "ay";
                    }
                }
                else { newWord = word; }
                string firstLetter = word.Substring(0,1);
                if (word == word.ToUpper())
                {
                    newWord = newWord.ToUpper();
                }
                else if (word == word.ToLower())
                {
                    newWord = newWord.ToLower();
                }
                else if (firstLetter == firstLetter.ToUpper())
                {
                    newWord = newWord.ToLower();
                    firstLetter = newWord.ToUpper();
                    newWord = firstLetter.Substring(0, 1) + newWord.Substring(1,newWord.Length -1);
                }
                pigLatin = pigLatin + newWord + " ";
            }//End of For Each
            txtPigLatin.Text = pigLatin;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnglish.Clear();
            txtPigLatin.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}