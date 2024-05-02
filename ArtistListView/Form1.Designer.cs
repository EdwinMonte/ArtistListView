namespace ArtistListView
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
            lstvartist = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstvartist
            // 
            lstvartist.Location = new Point(51, 71);
            lstvartist.Name = "lstvartist";
            lstvartist.Size = new Size(699, 339);
            lstvartist.TabIndex = 0;
            lstvartist.UseCompatibleStateImageBehavior = false;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 29);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 1;
            label1.Text = "List of artists";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lstvartist);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvartist;
        private Label label1;
    }
}
