using System;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class LargeTextBoxForm : Form
    {
        public string EnteredText { get; private set; } // Correct property name

        public LargeTextBoxForm(string initialText)
        {
            InitializeComponent();
            textBoxLarge.Text = initialText;
        }

        private void InitializeComponent()
        {
            this.textBoxLarge = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLarge
            // 
            this.textBoxLarge.Location = new System.Drawing.Point(12, 12);
            this.textBoxLarge.Multiline = true;
            this.textBoxLarge.Name = "textBoxLarge";
            this.textBoxLarge.Size = new System.Drawing.Size(360, 200);
            this.textBoxLarge.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(297, 218);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LargeTextBoxForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxLarge);
            this.Name = "LargeTextBoxForm";
            this.Text = "Large Text Input";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            EnteredText = textBoxLarge.Text; // Store the entered text in the property
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private System.Windows.Forms.TextBox textBoxLarge;
        private System.Windows.Forms.Button buttonSave;
    }
}
