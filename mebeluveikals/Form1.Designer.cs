namespace mebeluveikals
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
            selectProductComboBox = new ComboBox();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            priceTextBox = new TextBox();
            label4 = new Label();
            hTextBox = new TextBox();
            label5 = new Label();
            wTextBox = new TextBox();
            label6 = new Label();
            descTextBox = new TextBox();
            label7 = new Label();
            lTextBox = new TextBox();
            selectBtn = new Button();
            addButton = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            ExportCSV = new Button();
            ImportCSV = new Button();
            SuspendLayout();
            // 
            // selectProductComboBox
            // 
            selectProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectProductComboBox.FormattingEnabled = true;
            selectProductComboBox.Location = new Point(14, 51);
            selectProductComboBox.Margin = new Padding(3, 4, 3, 4);
            selectProductComboBox.Name = "selectProductComboBox";
            selectProductComboBox.Size = new Size(356, 28);
            selectProductComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Izvēlies preci";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(14, 147);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(209, 27);
            nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 123);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "Preces nosaukums";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 207);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Cena";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(14, 231);
            priceTextBox.Margin = new Padding(3, 4, 3, 4);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(209, 27);
            priceTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 123);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Augstums";
            // 
            // hTextBox
            // 
            hTextBox.Location = new Point(254, 147);
            hTextBox.Margin = new Padding(3, 4, 3, 4);
            hTextBox.Name = "hTextBox";
            hTextBox.Size = new Size(209, 27);
            hTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 207);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "Platums";
            // 
            // wTextBox
            // 
            wTextBox.Location = new Point(254, 231);
            wTextBox.Margin = new Padding(3, 4, 3, 4);
            wTextBox.Name = "wTextBox";
            wTextBox.Size = new Size(209, 27);
            wTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 291);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 11;
            label6.Text = "Apraksts";
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(14, 315);
            descTextBox.Margin = new Padding(3, 4, 3, 4);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(209, 27);
            descTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 291);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 13;
            label7.Text = "Garums";
            // 
            // lTextBox
            // 
            lTextBox.Location = new Point(254, 315);
            lTextBox.Margin = new Padding(3, 4, 3, 4);
            lTextBox.Name = "lTextBox";
            lTextBox.Size = new Size(209, 27);
            lTextBox.TabIndex = 12;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(377, 49);
            selectBtn.Margin = new Padding(3, 4, 3, 4);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(86, 32);
            selectBtn.TabIndex = 14;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(14, 397);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 32);
            addButton.TabIndex = 15;
            addButton.Text = "Pievienot";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(106, 397);
            editBtn.Margin = new Padding(3, 4, 3, 4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(86, 32);
            editBtn.TabIndex = 16;
            editBtn.Text = "Rediģēt";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(199, 397);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 32);
            deleteBtn.TabIndex = 17;
            deleteBtn.Text = "Dzēst";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // ExportCSV
            // 
            ExportCSV.Location = new Point(306, 397);
            ExportCSV.Margin = new Padding(3, 4, 3, 4);
            ExportCSV.Name = "ExportCSV";
            ExportCSV.Size = new Size(86, 32);
            ExportCSV.TabIndex = 18;
            ExportCSV.Text = "Eksportēt CSV";
            ExportCSV.UseVisualStyleBackColor = true;
            // 
            // ImportCSV
            // 
            ImportCSV.Location = new Point(398, 397);
            ImportCSV.Margin = new Padding(3, 4, 3, 4);
            ImportCSV.Name = "ImportCSV";
            ImportCSV.Size = new Size(86, 32);
            ImportCSV.TabIndex = 19;
            ImportCSV.Text = "Importēt CSV";
            ImportCSV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 461);
            Controls.Add(ImportCSV);
            Controls.Add(ExportCSV);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addButton);
            Controls.Add(selectBtn);
            Controls.Add(label7);
            Controls.Add(lTextBox);
            Controls.Add(label6);
            Controls.Add(descTextBox);
            Controls.Add(label5);
            Controls.Add(wTextBox);
            Controls.Add(label4);
            Controls.Add(hTextBox);
            Controls.Add(label3);
            Controls.Add(priceTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(selectProductComboBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(522, 508);
            MinimumSize = new Size(522, 508);
            Name = "Form1";
            Text = "Mēbeļu veikals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectProductComboBox;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private Label label3;
        private TextBox priceTextBox;
        private Label label4;
        private TextBox hTextBox;
        private Label label5;
        private TextBox wTextBox;
        private Label label6;
        private TextBox descTextBox;
        private Label label7;
        private TextBox lTextBox;
        private Button selectBtn;
        private Button addButton;
        private Button editBtn;
        private Button deleteBtn;
        private Button ExportCSV;
        private Button ImportCSV;
    }
}
