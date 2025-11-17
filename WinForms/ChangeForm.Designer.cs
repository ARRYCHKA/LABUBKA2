namespace WinForms
{
    partial class ChangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            yearTextBox = new TextBox();
            colorTextBox = new TextBox();
            brandTextBox = new TextBox();
            newYearLabel = new Label();
            newColorlabel = new Label();
            newBrendlabel = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(yearTextBox);
            panel1.Controls.Add(colorTextBox);
            panel1.Controls.Add(brandTextBox);
            panel1.Controls.Add(newYearLabel);
            panel1.Controls.Add(newColorlabel);
            panel1.Controls.Add(newBrendlabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 284);
            panel1.TabIndex = 0;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(15, 157);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(264, 27);
            yearTextBox.TabIndex = 5;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(15, 99);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(264, 27);
            colorTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(15, 37);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(264, 27);
            brandTextBox.TabIndex = 3;
            // 
            // newYearLabel
            // 
            newYearLabel.AutoSize = true;
            newYearLabel.Location = new Point(18, 129);
            newYearLabel.Name = "newYearLabel";
            newYearLabel.Size = new Size(142, 20);
            newYearLabel.TabIndex = 2;
            newYearLabel.Text = "Введите новый год";
            // 
            // newColorlabel
            // 
            newColorlabel.AutoSize = true;
            newColorlabel.Location = new Point(12, 67);
            newColorlabel.Name = "newColorlabel";
            newColorlabel.Size = new Size(150, 20);
            newColorlabel.TabIndex = 1;
            newColorlabel.Text = "Введите новый цвет";
            // 
            // newBrendlabel
            // 
            newBrendlabel.AutoSize = true;
            newBrendlabel.Location = new Point(11, 9);
            newBrendlabel.Name = "newBrendlabel";
            newBrendlabel.Size = new Size(162, 20);
            newBrendlabel.TabIndex = 0;
            newBrendlabel.Text = "Введите новый бренд";
            // 
            // button1
            // 
            button1.Location = new Point(15, 201);
            button1.Name = "button1";
            button1.Size = new Size(264, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 236);
            button2.Name = "button2";
            button2.Size = new Size(264, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 284);
            Controls.Add(panel1);
            Name = "ChangeForm";
            Text = "ChangeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label newYearLabel;
        private Label newColorlabel;
        private Label newBrendlabel;
        private TextBox yearTextBox;
        private TextBox colorTextBox;
        private TextBox brandTextBox;
        private Button button2;
        private Button button1;
    }
}