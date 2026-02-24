namespace WindowsGreeting
{
    partial class frmGreeting
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
            btnHello = new Button();
            textName = new TextBox();
            lblName = new Label();
            btnHi = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.FlatStyle = FlatStyle.System;
            btnHello.ForeColor = Color.Cornsilk;
            btnHello.Location = new Point(511, 289);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(94, 29);
            btnHello.TabIndex = 0;
            btnHello.Text = "btnHello";
            btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // textName
            // 

            textName.Location = new Point(550, 156);
            textName.Name = "textName";
            textName.Size = new Size(175, 27);
            textName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(363, 159);
            lblName.Name = "lblName";
            lblName.Size = new Size(153, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Enter Your Name here";
            // 
            // btnHi
            // 
            btnHi.Location = new Point(340, 289);
            btnHi.Name = "btnHi";
            btnHi.Size = new Size(94, 29);
            btnHi.TabIndex = 3;
            btnHi.Text = "btnHi";
            btnHi.UseVisualStyleBackColor = true;
            btnHi.Click += btnHi_Click;
            
            // 
            // frmGreeting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 446);
            Controls.Add(btnHi);
            Controls.Add(lblName);
            Controls.Add(textName);
            Controls.Add(btnHello);
            Name = "frmGreeting";
            Text = "GreetingForm";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnHello;
        private TextBox textName;
        private Label lblName;
        private Button btnHi;
    }
}
