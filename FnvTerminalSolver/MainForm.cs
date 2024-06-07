using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FnvTerminalSolver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var minCommonCharacters = int.Parse(textBoxMinimumCommonCharacters.Text);
            var text = this.richTextBox1.Text.Split(new string[] { Environment.NewLine, " " }, StringSplitOptions.RemoveEmptyEntries);

            var results = new List<string>();
            // find the similarity between all the strings in text. Show me, which words have which characters in common.
            foreach (string line in text)
            {
                foreach (string word in text)
                {
                    if (line == word)
                    {
                        continue;
                    }

                    var commonChars = line.Intersect(word).ToArray();
                    if (commonChars.Length > minCommonCharacters)
                    {
                        var item = $"{line} and {word} have the following {commonChars.Length} characters in common: {string.Join(", ", commonChars)}";
                        if (!results.Contains(item))
                        {
                            results.Add(item);
                        }
                        // Console.WriteLine($"{line} and {word} have the following {commonChars.Length} characters in common: {string.Join(", ", commonChars)}");
                    }
                }
            }

            this.outputTextBox.Text = string.Join(Environment.NewLine, results);
            // results.Clear();
        }
    }
}