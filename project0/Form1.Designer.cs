namespace project0
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
            button1 = new Button();
            txtMovieTitle = new TextBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            listWatchedMovies = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(123, 164);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "btnWatch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMovieTitle
            // 
            txtMovieTitle.BackColor = SystemColors.ButtonHighlight;
            txtMovieTitle.Location = new Point(33, 69);
            txtMovieTitle.Name = "txtMovieTitle";
            txtMovieTitle.Size = new Size(100, 23);
            txtMovieTitle.TabIndex = 1;
            txtMovieTitle.Text = "txtMovieTitle";
            txtMovieTitle.TextChanged += txtMovieTitle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(123, 321);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "lblWatchCount";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(227, 70);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(123, 223);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "btnRate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listWatchedMovies
            // 
            listWatchedMovies.BackColor = SystemColors.ControlLightLight;
            listWatchedMovies.FormattingEnabled = true;
            listWatchedMovies.ItemHeight = 15;
            listWatchedMovies.Location = new Point(425, 48);
            listWatchedMovies.Name = "listWatchedMovies";
            listWatchedMovies.Size = new Size(345, 334);
            listWatchedMovies.TabIndex = 5;
            listWatchedMovies.SelectedIndexChanged += listWatchedMovies_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(listWatchedMovies);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(txtMovieTitle);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtMovieTitle;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private ListBox listWatchedMovies;
    }
}
