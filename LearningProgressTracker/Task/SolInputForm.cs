using System;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class SolInputForm : Form
    {
        public string InputText { get; set; }

        public SolInputForm(string initialText)
        {
            InitializeComponent();
            textBoxInput.Text = initialText;
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(460, 237);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(197, 255);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // TextInputForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 291);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxInput);
            this.Name = "TextInputForm";
            this.Text = "Wpisz tekst";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            InputText = textBoxInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private TextBox textBoxInput;
        private Button buttonOk;
    }
}
