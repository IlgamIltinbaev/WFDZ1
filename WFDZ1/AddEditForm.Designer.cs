namespace WFDZ1
{
    partial class AddEditForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.groupSale = new System.Windows.Forms.GroupBox();
            this.radioSaleNo = new System.Windows.Forms.RadioButton();
            this.radioSaleYes = new System.Windows.Forms.RadioButton();
            this.buttonSafe = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboAuthor = new System.Windows.Forms.ComboBox();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.groupSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(145, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(145, 143);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(50, 16);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Автор:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(145, 201);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(47, 16);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "Жанр:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(227, 84);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(300, 22);
            this.textName.TabIndex = 3;
            // 
            // groupSale
            // 
            this.groupSale.Controls.Add(this.radioSaleNo);
            this.groupSale.Controls.Add(this.radioSaleYes);
            this.groupSale.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.groupSale.Location = new System.Drawing.Point(148, 253);
            this.groupSale.Name = "groupSale";
            this.groupSale.Size = new System.Drawing.Size(379, 128);
            this.groupSale.TabIndex = 6;
            this.groupSale.TabStop = false;
            this.groupSale.Text = "Скидка:";
            // 
            // radioSaleNo
            // 
            this.radioSaleNo.AutoSize = true;
            this.radioSaleNo.Location = new System.Drawing.Point(17, 72);
            this.radioSaleNo.Name = "radioSaleNo";
            this.radioSaleNo.Size = new System.Drawing.Size(59, 27);
            this.radioSaleNo.TabIndex = 1;
            this.radioSaleNo.TabStop = true;
            this.radioSaleNo.Text = "Нет";
            this.radioSaleNo.UseVisualStyleBackColor = true;
            // 
            // radioSaleYes
            // 
            this.radioSaleYes.AutoSize = true;
            this.radioSaleYes.Location = new System.Drawing.Point(17, 29);
            this.radioSaleYes.Name = "radioSaleYes";
            this.radioSaleYes.Size = new System.Drawing.Size(64, 27);
            this.radioSaleYes.TabIndex = 0;
            this.radioSaleYes.TabStop = true;
            this.radioSaleYes.Text = "Есть";
            this.radioSaleYes.UseVisualStyleBackColor = true;
            // 
            // buttonSafe
            // 
            this.buttonSafe.Location = new System.Drawing.Point(148, 400);
            this.buttonSafe.Name = "buttonSafe";
            this.buttonSafe.Size = new System.Drawing.Size(111, 23);
            this.buttonSafe.TabIndex = 7;
            this.buttonSafe.Text = "Сохранить";
            this.buttonSafe.UseVisualStyleBackColor = true;
            this.buttonSafe.Click += new System.EventHandler(this.buttonSafe_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(422, 400);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Отмена";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboAuthor
            // 
            this.comboAuthor.FormattingEnabled = true;
            this.comboAuthor.Location = new System.Drawing.Point(227, 143);
            this.comboAuthor.Name = "comboAuthor";
            this.comboAuthor.Size = new System.Drawing.Size(300, 24);
            this.comboAuthor.TabIndex = 9;
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(227, 198);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(300, 24);
            this.comboGenre.TabIndex = 10;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(690, 481);
            this.Controls.Add(this.comboGenre);
            this.Controls.Add(this.comboAuthor);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSafe);
            this.Controls.Add(this.groupSale);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelName);
            this.Name = "AddEditForm";
            this.Text = "Редактор книг";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.groupSale.ResumeLayout(false);
            this.groupSale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox groupSale;
        private System.Windows.Forms.RadioButton radioSaleNo;
        private System.Windows.Forms.RadioButton radioSaleYes;
        private System.Windows.Forms.Button buttonSafe;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboAuthor;
        private System.Windows.Forms.ComboBox comboGenre;
    }
}