namespace CityBook
{
    partial class StartWindow
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
            this.citiesList = new System.Windows.Forms.ComboBox();
            this.addPhone = new System.Windows.Forms.Button();
            this.showPhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // citiesList
            // 
            this.citiesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesList.FormattingEnabled = true;
            this.citiesList.Location = new System.Drawing.Point(125, 134);
            this.citiesList.Name = "citiesList";
            this.citiesList.Size = new System.Drawing.Size(225, 21);
            this.citiesList.TabIndex = 0;
            this.citiesList.SelectedIndexChanged += new System.EventHandler(this.citiesList_SelectedIndexChanged);
            // 
            // addPhone
            // 
            this.addPhone.Location = new System.Drawing.Point(461, 134);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(93, 36);
            this.addPhone.TabIndex = 1;
            this.addPhone.Text = "Добавить номер";
            this.addPhone.UseVisualStyleBackColor = true;
            this.addPhone.Click += new System.EventHandler(this.addPhone_Click);
            // 
            // showPhone
            // 
            this.showPhone.Location = new System.Drawing.Point(461, 197);
            this.showPhone.Name = "showPhone";
            this.showPhone.Size = new System.Drawing.Size(93, 36);
            this.showPhone.TabIndex = 2;
            this.showPhone.Text = "Показать номера";
            this.showPhone.UseVisualStyleBackColor = true;
            this.showPhone.Click += new System.EventHandler(this.showPhone_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showPhone);
            this.Controls.Add(this.addPhone);
            this.Controls.Add(this.citiesList);
            this.Name = "StartWindow";
            this.Text = "Справочник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox citiesList;
        private System.Windows.Forms.Button addPhone;
        private System.Windows.Forms.Button showPhone;
    }
}