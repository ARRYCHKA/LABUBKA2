namespace WinForms
{
    partial class UpDateForm
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
            button1 = new Button();
            changeButton = new Button();
            listButton = new Button();
            idForChangeBox = new TextBox();
            IdLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(changeButton);
            panel1.Controls.Add(listButton);
            panel1.Controls.Add(idForChangeBox);
            panel1.Controls.Add(IdLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 186);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(114, 148);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(215, 113);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(159, 29);
            changeButton.TabIndex = 4;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // listButton
            // 
            listButton.Location = new Point(14, 113);
            listButton.Name = "listButton";
            listButton.Size = new Size(159, 29);
            listButton.TabIndex = 3;
            listButton.Text = "Показать список";
            listButton.UseVisualStyleBackColor = true;
            // 
            // idForChangeBox
            // 
            idForChangeBox.Location = new Point(14, 68);
            idForChangeBox.Name = "idForChangeBox";
            idForChangeBox.Size = new Size(360, 27);
            idForChangeBox.TabIndex = 2;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            IdLabel.Location = new Point(13, 23);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(319, 23);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "Введите ID автомобя для изменения";
            // 
            // UpDateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 186);
            Controls.Add(panel1);
            Name = "UpDateForm";
            Text = "UpDateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label IdLabel;
        private TextBox idForChangeBox;
        private Button changeButton;
        private Button listButton;
        private Button button1;
    }
}