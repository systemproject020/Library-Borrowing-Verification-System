namespace Library_Borrowing_Verification_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtName = new TextBox();
            txtBook = new TextBox();
            picBorrow = new PictureBox();
            picReturn = new PictureBox();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            picClear = new PictureBox();
            listNames = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBorrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClear).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 177);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 55);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtBook
            // 
            txtBook.Location = new Point(160, 266);
            txtBook.Multiline = true;
            txtBook.Name = "txtBook";
            txtBook.Size = new Size(195, 52);
            txtBook.TabIndex = 1;
            // 
            // picBorrow
            // 
            picBorrow.Image = (Image)resources.GetObject("picBorrow.Image");
            picBorrow.Location = new Point(160, 345);
            picBorrow.Name = "picBorrow";
            picBorrow.Size = new Size(61, 64);
            picBorrow.SizeMode = PictureBoxSizeMode.StretchImage;
            picBorrow.TabIndex = 2;
            picBorrow.TabStop = false;
            picBorrow.Click += picBorrow_Click;
            // 
            // picReturn
            // 
            picReturn.Image = (Image)resources.GetObject("picReturn.Image");
            picReturn.Location = new Point(281, 345);
            picReturn.Name = "picReturn";
            picReturn.Size = new Size(62, 64);
            picReturn.SizeMode = PictureBoxSizeMode.StretchImage;
            picReturn.TabIndex = 3;
            picReturn.TabStop = false;
            picReturn.Click += picReturn_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Black;
            lblResult.Location = new Point(67, 22);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 26);
            lblResult.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(40, 192);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(40, 279);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 8;
            label2.Text = "Book Title:";
            // 
            // picClear
            // 
            picClear.Image = (Image)resources.GetObject("picClear.Image");
            picClear.Location = new Point(371, 180);
            picClear.Name = "picClear";
            picClear.Size = new Size(41, 52);
            picClear.SizeMode = PictureBoxSizeMode.StretchImage;
            picClear.TabIndex = 9;
            picClear.TabStop = false;
            picClear.Click += picClear_Click;
            // 
            // listNames
            // 
            listNames.FormattingEnabled = true;
            listNames.Location = new Point(432, 180);
            listNames.Name = "listNames";
            listNames.Size = new Size(316, 229);
            listNames.TabIndex = 10;
            listNames.SelectedIndexChanged += listNames_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 425);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 11;
            label3.Text = "Borrow";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 425);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 12;
            label4.Text = "Return";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 226);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 13;
            label5.Text = "Return";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 477);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listNames);
            Controls.Add(picClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(picReturn);
            Controls.Add(picBorrow);
            Controls.Add(txtBook);
            Controls.Add(txtName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBorrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtBook;
        private PictureBox picBorrow;
        private PictureBox picReturn;
        private Label lblResult;
        private Label label1;
        private Label label2;
        private PictureBox picClear;
        private ListBox listNames;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
