namespace mailManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.adressTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdressToField = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.MessageBodyField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactsChoose = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContactsChooseCopy = new System.Windows.Forms.ListBox();
            this.Files = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adressTo
            // 
            this.adressTo.AutoSize = true;
            this.adressTo.Location = new System.Drawing.Point(13, 13);
            this.adressTo.Name = "adressTo";
            this.adressTo.Size = new System.Drawing.Size(70, 16);
            this.adressTo.TabIndex = 0;
            this.adressTo.Text = "Adress To";
            this.adressTo.Click += new System.EventHandler(this.adressTo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // AdressToField
            // 
            this.AdressToField.Location = new System.Drawing.Point(13, 33);
            this.AdressToField.Name = "AdressToField";
            this.AdressToField.Size = new System.Drawing.Size(243, 22);
            this.AdressToField.TabIndex = 2;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(12, 81);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(244, 22);
            this.SubjectTextBox.TabIndex = 3;
            // 
            // MessageBodyField
            // 
            this.MessageBodyField.Location = new System.Drawing.Point(12, 125);
            this.MessageBodyField.Multiline = true;
            this.MessageBodyField.Name = "MessageBodyField";
            this.MessageBodyField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageBodyField.Size = new System.Drawing.Size(244, 312);
            this.MessageBodyField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contacts";
            // 
            // ContactsChoose
            // 
            this.ContactsChoose.FormattingEnabled = true;
            this.ContactsChoose.Location = new System.Drawing.Point(288, 33);
            this.ContactsChoose.Name = "ContactsChoose";
            this.ContactsChoose.Size = new System.Drawing.Size(252, 24);
            this.ContactsChoose.TabIndex = 7;
            this.ContactsChoose.SelectedIndexChanged += new System.EventHandler(this.ContactsChoose_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Copies";
            // 
            // ContactsChooseCopy
            // 
            this.ContactsChooseCopy.FormattingEnabled = true;
            this.ContactsChooseCopy.ItemHeight = 16;
            this.ContactsChooseCopy.Location = new System.Drawing.Point(288, 81);
            this.ContactsChooseCopy.Name = "ContactsChooseCopy";
            this.ContactsChooseCopy.Size = new System.Drawing.Size(252, 356);
            this.ContactsChooseCopy.TabIndex = 9;
            // 
            // Files
            // 
            this.Files.AutoSize = true;
            this.Files.Location = new System.Drawing.Point(558, 13);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(36, 16);
            this.Files.TabIndex = 10;
            this.Files.Text = "Files";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(561, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(227, 84);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(561, 228);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(227, 84);
            this.listBox3.TabIndex = 12;
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(561, 123);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(109, 23);
            this.ChooseBtn.TabIndex = 13;
            this.ChooseBtn.Text = "ChooseBtn";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(676, 122);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 23);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "AddBtn";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(676, 316);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(109, 23);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.Text = "ClearBtn";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(561, 316);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(109, 23);
            this.SendBtn.TabIndex = 15;
            this.SendBtn.Text = "SendBtn";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Files);
            this.Controls.Add(this.ContactsChooseCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContactsChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageBodyField);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.AdressToField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adressTo);
            this.Name = "Form1";
            this.Text = "Email Menager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adressTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdressToField;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.TextBox MessageBodyField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ContactsChoose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ContactsChooseCopy;
        private System.Windows.Forms.Label Files;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button ChooseBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SendBtn;
    }
}

