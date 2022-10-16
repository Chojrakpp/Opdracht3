namespace oefening2
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
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btTestOut = new System.Windows.Forms.Button();
            this.btTestIn = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btStringOut = new System.Windows.Forms.Button();
            this.btStringIn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btOut = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.tbInOut = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.btStringCheck = new System.Windows.Forms.Button();
            this.btTestCheck = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.btStringShow = new System.Windows.Forms.Button();
            this.btTestShow = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.btStringCopy = new System.Windows.Forms.Button();
            this.btTestCopy = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(241, 72);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(65, 15);
            this.linkLabel3.TabIndex = 19;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "TestClasses";
            // 
            // btTestOut
            // 
            this.btTestOut.Location = new System.Drawing.Point(241, 132);
            this.btTestOut.Margin = new System.Windows.Forms.Padding(2);
            this.btTestOut.Name = "btTestOut";
            this.btTestOut.Size = new System.Drawing.Size(78, 20);
            this.btTestOut.TabIndex = 18;
            this.btTestOut.Text = "Out";
            this.btTestOut.UseVisualStyleBackColor = true;
            this.btTestOut.Click += new System.EventHandler(this.btTestOut_Click);
            // 
            // btTestIn
            // 
            this.btTestIn.Location = new System.Drawing.Point(241, 102);
            this.btTestIn.Margin = new System.Windows.Forms.Padding(2);
            this.btTestIn.Name = "btTestIn";
            this.btTestIn.Size = new System.Drawing.Size(78, 20);
            this.btTestIn.TabIndex = 17;
            this.btTestIn.Text = "In";
            this.btTestIn.UseVisualStyleBackColor = true;
            this.btTestIn.Click += new System.EventHandler(this.btTestClassIn_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(149, 72);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(43, 15);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Strings";
            // 
            // btStringOut
            // 
            this.btStringOut.Location = new System.Drawing.Point(134, 132);
            this.btStringOut.Margin = new System.Windows.Forms.Padding(2);
            this.btStringOut.Name = "btStringOut";
            this.btStringOut.Size = new System.Drawing.Size(78, 20);
            this.btStringOut.TabIndex = 15;
            this.btStringOut.Text = "Out";
            this.btStringOut.UseVisualStyleBackColor = true;
            this.btStringOut.Click += new System.EventHandler(this.btStringOut_Click);
            // 
            // btStringIn
            // 
            this.btStringIn.Location = new System.Drawing.Point(134, 102);
            this.btStringIn.Margin = new System.Windows.Forms.Padding(2);
            this.btStringIn.Name = "btStringIn";
            this.btStringIn.Size = new System.Drawing.Size(78, 20);
            this.btStringIn.TabIndex = 14;
            this.btStringIn.Text = "In";
            this.btStringIn.UseVisualStyleBackColor = true;
            this.btStringIn.Click += new System.EventHandler(this.btStringIn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(45, 72);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Integers";
            // 
            // btOut
            // 
            this.btOut.Location = new System.Drawing.Point(30, 132);
            this.btOut.Margin = new System.Windows.Forms.Padding(2);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(78, 20);
            this.btOut.TabIndex = 12;
            this.btOut.Text = "Out";
            this.btOut.UseVisualStyleBackColor = true;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(30, 102);
            this.btIn.Margin = new System.Windows.Forms.Padding(2);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(78, 20);
            this.btIn.TabIndex = 11;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // tbInOut
            // 
            this.tbInOut.Location = new System.Drawing.Point(30, 42);
            this.tbInOut.Margin = new System.Windows.Forms.Padding(2);
            this.tbInOut.Name = "tbInOut";
            this.tbInOut.Size = new System.Drawing.Size(183, 23);
            this.tbInOut.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Empty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btTestEmpty_Click);
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(30, 263);
            this.btCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(78, 39);
            this.btCheck.TabIndex = 21;
            this.btCheck.Text = "check if inside";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btStringCheck
            // 
            this.btStringCheck.Location = new System.Drawing.Point(135, 263);
            this.btStringCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btStringCheck.Name = "btStringCheck";
            this.btStringCheck.Size = new System.Drawing.Size(78, 39);
            this.btStringCheck.TabIndex = 22;
            this.btStringCheck.Text = "check if inside";
            this.btStringCheck.UseVisualStyleBackColor = true;
            this.btStringCheck.Click += new System.EventHandler(this.btStringCheck_Click);
            // 
            // btTestCheck
            // 
            this.btTestCheck.Location = new System.Drawing.Point(241, 263);
            this.btTestCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btTestCheck.Name = "btTestCheck";
            this.btTestCheck.Size = new System.Drawing.Size(78, 39);
            this.btTestCheck.TabIndex = 23;
            this.btTestCheck.Text = "check if inside";
            this.btTestCheck.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 25);
            this.button2.TabIndex = 24;
            this.button2.Text = "Empty";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btStringEmpty_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 156);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 25);
            this.button3.TabIndex = 25;
            this.button3.Text = "Empty";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btEmpty_Click);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(30, 207);
            this.btShow.Margin = new System.Windows.Forms.Padding(2);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(78, 25);
            this.btShow.TabIndex = 26;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btStringShow
            // 
            this.btStringShow.Location = new System.Drawing.Point(134, 207);
            this.btStringShow.Margin = new System.Windows.Forms.Padding(2);
            this.btStringShow.Name = "btStringShow";
            this.btStringShow.Size = new System.Drawing.Size(78, 25);
            this.btStringShow.TabIndex = 27;
            this.btStringShow.Text = "Show";
            this.btStringShow.UseVisualStyleBackColor = true;
            this.btStringShow.Click += new System.EventHandler(this.btStringShow_Click);
            // 
            // btTestShow
            // 
            this.btTestShow.Location = new System.Drawing.Point(241, 207);
            this.btTestShow.Margin = new System.Windows.Forms.Padding(2);
            this.btTestShow.Name = "btTestShow";
            this.btTestShow.Size = new System.Drawing.Size(78, 25);
            this.btTestShow.TabIndex = 28;
            this.btTestShow.Text = "Show";
            this.btTestShow.UseVisualStyleBackColor = true;
            this.btTestShow.Click += new System.EventHandler(this.btTestShow_Click);
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(30, 324);
            this.btCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(78, 25);
            this.btCopy.TabIndex = 29;
            this.btCopy.Text = "Copy";
            this.btCopy.UseVisualStyleBackColor = true;
            // 
            // btStringCopy
            // 
            this.btStringCopy.Location = new System.Drawing.Point(134, 324);
            this.btStringCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btStringCopy.Name = "btStringCopy";
            this.btStringCopy.Size = new System.Drawing.Size(78, 25);
            this.btStringCopy.TabIndex = 30;
            this.btStringCopy.Text = "Copy";
            this.btStringCopy.UseVisualStyleBackColor = true;
            // 
            // btTestCopy
            // 
            this.btTestCopy.Location = new System.Drawing.Point(241, 324);
            this.btTestCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btTestCopy.Name = "btTestCopy";
            this.btTestCopy.Size = new System.Drawing.Size(78, 25);
            this.btTestCopy.TabIndex = 31;
            this.btTestCopy.Text = "Copy";
            this.btTestCopy.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(30, 236);
            this.tbResult.Margin = new System.Windows.Forms.Padding(2);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(289, 23);
            this.tbResult.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 435);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btTestCopy);
            this.Controls.Add(this.btStringCopy);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.btTestShow);
            this.Controls.Add(this.btStringShow);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btTestCheck);
            this.Controls.Add(this.btStringCheck);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.btTestOut);
            this.Controls.Add(this.btTestIn);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btStringOut);
            this.Controls.Add(this.btStringIn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.tbInOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel3;
        private Button btTestOut;
        private Button btTestIn;
        private LinkLabel linkLabel2;
        private Button btStringOut;
        private Button btStringIn;
        private LinkLabel linkLabel1;
        private Button btOut;
        private Button btIn;
        private TextBox tbInOut;
        private Button button1;
        private Button btCheck;
        private Button btStringCheck;
        private Button btTestCheck;
        private Button button2;
        private Button button3;
        private Button btShow;
        private Button btStringShow;
        private Button btTestShow;
        private Button btCopy;
        private Button btStringCopy;
        private Button btTestCopy;
        private TextBox tbResult;
    }
}