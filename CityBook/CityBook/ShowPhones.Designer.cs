namespace CityBook
{
    partial class ShowPhones
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
            this.phonesTable = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phonesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // phonesTable
            // 
            this.phonesTable.AllowUserToAddRows = false;
            this.phonesTable.AllowUserToDeleteRows = false;
            this.phonesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phonesTable.Location = new System.Drawing.Point(12, 12);
            this.phonesTable.Name = "phonesTable";
            this.phonesTable.ReadOnly = true;
            this.phonesTable.Size = new System.Drawing.Size(407, 384);
            this.phonesTable.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(173, 420);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ShowPhones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 455);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.phonesTable);
            this.Name = "ShowPhones";
            this.Text = "ShowPhones";
            ((System.ComponentModel.ISupportInitialize)(this.phonesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView phonesTable;
        private System.Windows.Forms.Button cancelButton;
    }
}