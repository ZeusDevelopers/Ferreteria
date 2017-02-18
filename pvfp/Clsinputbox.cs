using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVFP
{
    static class Clsinputbox
    {
        public static string ShowDialog(string text, string caption,string cant_actual)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                //FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 45, Width = 130 };
            Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 60, Top = 70, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancel", Left = 120, Width = 60, Top = 70, DialogResult = DialogResult.Cancel };
            textBox.Text = cant_actual;
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.MinimizeBox = false;
            prompt.MaximizeBox = false;
            prompt.ShowIcon = false;
            prompt.FormBorderStyle = FormBorderStyle.Fixed3D;
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
                return textBox.Text;
            else
                return "empty";
        }
    }
}
