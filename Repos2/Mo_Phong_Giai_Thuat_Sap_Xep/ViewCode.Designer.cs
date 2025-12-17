namespace Mo_Phong_Giai_Thuat_Sap_Xep
{
    partial class Form_ViewCode
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
            this.ViewCodeBox = new System.Windows.Forms.RichTextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewCodeBox
            // 
            this.ViewCodeBox.Location = new System.Drawing.Point(87, 12);
            this.ViewCodeBox.Name = "ViewCodeBox";
            this.ViewCodeBox.Size = new System.Drawing.Size(576, 426);
            this.ViewCodeBox.TabIndex = 0;
            this.ViewCodeBox.Text = "";
            this.ViewCodeBox.TextChanged += new System.EventHandler(this.ViewCodeBox_TextChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(685, 387);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(103, 51);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Form_ViewCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ViewCodeBox);
            this.Name = "Form_ViewCode";
            this.Text = "ViewCode";
            this.Load += new System.EventHandler(this.Form_ViewCode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ViewCodeBox;
        private System.Windows.Forms.Button BackBtn;
    }
}