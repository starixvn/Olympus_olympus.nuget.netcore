using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MessagePackTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddCamelCaseKeyButtonClick(object sender, EventArgs e)
        {
            var newText = AddCamelCaseKey(SourceCodeTextBox.Text);
            SourceCodeTextBox.Text = newText;
        }

        private void RemoveKeyButtonClick(object sender, EventArgs e)
        {
            var newText = RemoveKey(SourceCodeTextBox.Text);
            SourceCodeTextBox.Text = newText;
        }

        private string AddCamelCaseKey(string sourceCode)
        {
            var pattern = new Regex(@"\s*public\s+[^\s]+\s+([a-zA-Z]+).*");
            var result = new List<string>();
            var lines = Regex.Split(sourceCode, "\r\n|\r|\n");
            foreach (var line in lines)
            {
                if (pattern.IsMatch(line))
                {
                    var match = pattern.Match(line);
                    var propertyName = match.Groups[1].Value;
                    var camelCase = ConvertToCamelCase(propertyName);
                    var key = string.Format("[Key(\"{0}\")]", camelCase);

                    result.Add(key);
                }

                result.Add(line);
            }

            return string.Join("\r\n", result);
        }

        private string ConvertToCamelCase(string titleCase)
        {
            return Char.ToLowerInvariant(titleCase[0]) + titleCase.Substring(1);
        }

        private string RemoveKey(string sourceCode)
        {
            var lines = Regex.Split(sourceCode, "\r\n|\r|\n");
            lines = lines
                        .Where(l => !l.Trim().StartsWith("[Key") && !l.Trim().EndsWith("]"))
                        .ToArray();

            return string.Join("\r\n", lines);
        }
    }
}
