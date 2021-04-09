
namespace RolePlay_Notes
{
    partial class MoneyEditForm
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
            this.moneyEditFormSkin = new FlatUI.FormSkin();
            this.moneyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelFlatButton = new FlatUI.FlatButton();
            this.applyFlatButton = new FlatUI.FlatButton();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.nameFlatTextBox = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.closeFlatLabel = new FlatUI.FlatLabel();
            this.flatMax1 = new FlatUI.FlatMax();
            this.moneyEditFormSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyEditFormSkin
            // 
            this.moneyEditFormSkin.BackColor = System.Drawing.Color.White;
            this.moneyEditFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.moneyEditFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.moneyEditFormSkin.Controls.Add(this.moneyNumericUpDown);
            this.moneyEditFormSkin.Controls.Add(this.cancelFlatButton);
            this.moneyEditFormSkin.Controls.Add(this.applyFlatButton);
            this.moneyEditFormSkin.Controls.Add(this.flatLabel2);
            this.moneyEditFormSkin.Controls.Add(this.nameFlatTextBox);
            this.moneyEditFormSkin.Controls.Add(this.flatLabel1);
            this.moneyEditFormSkin.Controls.Add(this.closeFlatLabel);
            this.moneyEditFormSkin.Controls.Add(this.flatMax1);
            this.moneyEditFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyEditFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.moneyEditFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.moneyEditFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.moneyEditFormSkin.HeaderMaximize = false;
            this.moneyEditFormSkin.Location = new System.Drawing.Point(0, 0);
            this.moneyEditFormSkin.Name = "moneyEditFormSkin";
            this.moneyEditFormSkin.Size = new System.Drawing.Size(430, 220);
            this.moneyEditFormSkin.TabIndex = 2;
            this.moneyEditFormSkin.Text = "Edition d\'Argent";
            // 
            // moneyNumericUpDown
            // 
            this.moneyNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moneyNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.moneyNumericUpDown.ForeColor = System.Drawing.Color.Silver;
            this.moneyNumericUpDown.Location = new System.Drawing.Point(109, 140);
            this.moneyNumericUpDown.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.moneyNumericUpDown.Minimum = new decimal(new int[] {
            2147483646,
            0,
            0,
            -2147483648});
            this.moneyNumericUpDown.Name = "moneyNumericUpDown";
            this.moneyNumericUpDown.Size = new System.Drawing.Size(155, 29);
            this.moneyNumericUpDown.TabIndex = 158;
            // 
            // cancelFlatButton
            // 
            this.cancelFlatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelFlatButton.Location = new System.Drawing.Point(286, 95);
            this.cancelFlatButton.Name = "cancelFlatButton";
            this.cancelFlatButton.Rounded = false;
            this.cancelFlatButton.Size = new System.Drawing.Size(112, 32);
            this.cancelFlatButton.TabIndex = 155;
            this.cancelFlatButton.Text = "Annuler";
            this.cancelFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cancelFlatButton.Click += new System.EventHandler(this.closeFlatLabel_Click);
            // 
            // applyFlatButton
            // 
            this.applyFlatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.applyFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.applyFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.applyFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.applyFlatButton.Location = new System.Drawing.Point(286, 136);
            this.applyFlatButton.Name = "applyFlatButton";
            this.applyFlatButton.Rounded = false;
            this.applyFlatButton.Size = new System.Drawing.Size(112, 32);
            this.applyFlatButton.TabIndex = 156;
            this.applyFlatButton.Text = "Appliquer";
            this.applyFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.applyFlatButton.Click += new System.EventHandler(this.applyFlatButton_Click);
            // 
            // flatLabel2
            // 
            this.flatLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(24, 138);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(79, 30);
            this.flatLabel2.TabIndex = 149;
            this.flatLabel2.Text = "Argent";
            this.flatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameFlatTextBox
            // 
            this.nameFlatTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameFlatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.nameFlatTextBox.FocusOnHover = false;
            this.nameFlatTextBox.Location = new System.Drawing.Point(109, 95);
            this.nameFlatTextBox.MaxLength = 100;
            this.nameFlatTextBox.Multiline = false;
            this.nameFlatTextBox.Name = "nameFlatTextBox";
            this.nameFlatTextBox.ReadOnly = true;
            this.nameFlatTextBox.Size = new System.Drawing.Size(155, 29);
            this.nameFlatTextBox.TabIndex = 147;
            this.nameFlatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameFlatTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nameFlatTextBox.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(24, 95);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(79, 29);
            this.flatLabel1.TabIndex = 148;
            this.flatLabel1.Text = "Utilisateur";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeFlatLabel
            // 
            this.closeFlatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFlatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFlatLabel.ForeColor = System.Drawing.Color.White;
            this.closeFlatLabel.Location = new System.Drawing.Point(400, 12);
            this.closeFlatLabel.Name = "closeFlatLabel";
            this.closeFlatLabel.Size = new System.Drawing.Size(18, 18);
            this.closeFlatLabel.TabIndex = 136;
            this.closeFlatLabel.Text = "X";
            this.closeFlatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeFlatLabel.Click += new System.EventHandler(this.closeFlatLabel_Click);
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(376, 12);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 135;
            this.flatMax1.Text = "flatMax";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // MoneyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 220);
            this.Controls.Add(this.moneyEditFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoneyEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyEditForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.moneyEditFormSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moneyNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin moneyEditFormSkin;
        private System.Windows.Forms.NumericUpDown moneyNumericUpDown;
        private FlatUI.FlatButton cancelFlatButton;
        private FlatUI.FlatButton applyFlatButton;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox nameFlatTextBox;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel closeFlatLabel;
        private FlatUI.FlatMax flatMax1;
    }
}