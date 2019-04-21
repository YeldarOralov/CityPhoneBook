namespace CityBook
{
    partial class AddPhoneWindow
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
            this.enteredName = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.enteredPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // enteredName
            // 
            this.enteredName.Location = new System.Drawing.Point(82, 57);
            this.enteredName.Name = "enteredName";
            this.enteredName.Size = new System.Drawing.Size(141, 20);
            this.enteredName.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(115, 106);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Ок";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(308, 106);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(79, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(144, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Введите имя или название";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(305, 38);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(84, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Введите номер";
            // 
            // enteredPhone
            // 
            this.enteredPhone.Location = new System.Drawing.Point(272, 57);
            this.enteredPhone.Name = "enteredPhone";
            this.enteredPhone.Size = new System.Drawing.Size(151, 20);
            this.enteredPhone.TabIndex = 6;
            // 
            // AddPhoneWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 149);
            this.Controls.Add(this.enteredPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.enteredName);
            this.Name = "AddPhoneWindow";
            this.Text = "AddPhoneWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enteredName;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox enteredPhone;
    }
}