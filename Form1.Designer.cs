namespace calendrier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Txt = new TextBox();
            Lab = new Label();
            LabDate = new Label();
            SuspendLayout();
            // 
            // Txt
            // 
            Txt.Location = new Point(225, 15);
            Txt.Name = "Txt";
            Txt.Size = new Size(71, 23);
            Txt.TabIndex = 0;
            Txt.KeyDown += Txt_KeyDown;
            // 
            // Lab
            // 
            Lab.AutoSize = true;
            Lab.Location = new Point(12, 18);
            Lab.Name = "Lab";
            Lab.Size = new Size(157, 15);
            Lab.TabIndex = 1;
            Lab.Text = "Date au format jj/mm/aaaa :";
            // 
            // LabDate
            // 
            LabDate.AutoSize = true;
            LabDate.Location = new Point(12, 75);
            LabDate.Name = "LabDate";
            LabDate.Size = new Size(101, 15);
            LabDate.TabIndex = 2;
            LabDate.Text = "Nous sommes le :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 100);
            Controls.Add(LabDate);
            Controls.Add(Lab);
            Controls.Add(Txt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculateur Date";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt;
        private Label Lab;
        private Label LabDate;
    }
}
