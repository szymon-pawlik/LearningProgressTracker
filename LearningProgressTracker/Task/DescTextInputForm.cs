using System;
using System.Drawing;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class DescTextInputForm : Form
    {
        public string DescriptionText { get; set; }

        public DescTextInputForm(string initialText)
        {
            InitializeComponent();
            textBoxLargeInput.Text = initialText;
        }

        private void InitializeComponent()
        {
            this.textBoxLargeInput = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLargeInput
            // 
            this.textBoxLargeInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxLargeInput.Multiline = true;
            this.textBoxLargeInput.Name = "textBoxLargeInput";
            this.textBoxLargeInput.Size = new System.Drawing.Size(720, 400);
            this.textBoxLargeInput.TabIndex = 0;
            this.textBoxLargeInput.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(300, 440);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(160, 60);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LargeTextInputForm
            // 
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxLargeInput);
            this.Name = "LargeTextInputForm";
            this.Text = "Enter Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            DescriptionText = textBoxLargeInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private System.Windows.Forms.TextBox textBoxLargeInput;
        private System.Windows.Forms.Button buttonSave;
    }
}
