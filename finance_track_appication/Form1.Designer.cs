namespace finance_track_application

{

    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxcate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxamount = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listBoxgoster = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxcate
            // 
            this.textBoxcate.Location = new System.Drawing.Point(140, 27);
            this.textBoxcate.Name = "textBoxcate";
            this.textBoxcate.Size = new System.Drawing.Size(100, 22);
            this.textBoxcate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORİES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "AMOUNT";
            // 
            // textBoxamount
            // 
            this.textBoxamount.Location = new System.Drawing.Point(140, 69);
            this.textBoxamount.Name = "textBoxamount";
            this.textBoxamount.Size = new System.Drawing.Size(100, 22);
            this.textBoxamount.TabIndex = 3;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(12, 143);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(228, 23);
            this.buttonadd.TabIndex = 4;
            this.buttonadd.Text = "ADD TRANSACITION";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // listBoxgoster
            // 
            this.listBoxgoster.FormattingEnabled = true;
            this.listBoxgoster.ItemHeight = 16;
            this.listBoxgoster.Location = new System.Drawing.Point(12, 182);
            this.listBoxgoster.Name = "listBoxgoster";
            this.listBoxgoster.Size = new System.Drawing.Size(225, 84);
            this.listBoxgoster.TabIndex = 7;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(18, 310);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(228, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Location = new System.Drawing.Point(291, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 376);
            this.panel1.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(18, 272);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(225, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(18, 355);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(222, 22);
            this.textBoxSearch.TabIndex = 11;
          
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(19, 16);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(283, 24);
            this.comboBoxType.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listBoxgoster);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxcate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxcate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxamount;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox listBoxgoster;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}

