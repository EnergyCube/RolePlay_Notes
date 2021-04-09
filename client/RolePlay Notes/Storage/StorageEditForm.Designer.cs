
namespace RolePlay_Notes
{
    partial class StorageEditForm
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
            this.cancelFlatButton = new FlatUI.FlatButton();
            this.applyFlatButton = new FlatUI.FlatButton();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.nameFlatTextBox = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.closeFlatLabel = new FlatUI.FlatLabel();
            this.flatMax1 = new FlatUI.FlatMax();
            this.storageFormSkin = new FlatUI.FormSkin();
            this.ownerFlatComboBox = new FlatUI.FlatComboBox();
            this.locationFlatTextBox = new FlatUI.FlatTextBox();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.storageTypeFlatComboBox = new FlatUI.FlatComboBox();
            this.storageFormSkin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelFlatButton
            // 
            this.cancelFlatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelFlatButton.Location = new System.Drawing.Point(326, 152);
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
            this.applyFlatButton.Location = new System.Drawing.Point(326, 195);
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
            this.flatLabel2.Location = new System.Drawing.Point(8, 109);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(121, 30);
            this.flatLabel2.TabIndex = 149;
            this.flatLabel2.Text = "Propriétaire";
            this.flatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameFlatTextBox
            // 
            this.nameFlatTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameFlatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.nameFlatTextBox.FocusOnHover = false;
            this.nameFlatTextBox.Location = new System.Drawing.Point(135, 64);
            this.nameFlatTextBox.MaxLength = 100;
            this.nameFlatTextBox.Multiline = false;
            this.nameFlatTextBox.Name = "nameFlatTextBox";
            this.nameFlatTextBox.ReadOnly = false;
            this.nameFlatTextBox.Size = new System.Drawing.Size(167, 29);
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
            this.flatLabel1.Location = new System.Drawing.Point(8, 66);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(121, 29);
            this.flatLabel1.TabIndex = 148;
            this.flatLabel1.Text = "Nom";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeFlatLabel
            // 
            this.closeFlatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFlatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeFlatLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFlatLabel.ForeColor = System.Drawing.Color.White;
            this.closeFlatLabel.Location = new System.Drawing.Point(420, 12);
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
            this.flatMax1.Location = new System.Drawing.Point(396, 12);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 135;
            this.flatMax1.Text = "flatMax";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // storageFormSkin
            // 
            this.storageFormSkin.BackColor = System.Drawing.Color.White;
            this.storageFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.storageFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.storageFormSkin.Controls.Add(this.storageTypeFlatComboBox);
            this.storageFormSkin.Controls.Add(this.ownerFlatComboBox);
            this.storageFormSkin.Controls.Add(this.locationFlatTextBox);
            this.storageFormSkin.Controls.Add(this.flatLabel4);
            this.storageFormSkin.Controls.Add(this.flatLabel3);
            this.storageFormSkin.Controls.Add(this.cancelFlatButton);
            this.storageFormSkin.Controls.Add(this.applyFlatButton);
            this.storageFormSkin.Controls.Add(this.flatLabel2);
            this.storageFormSkin.Controls.Add(this.nameFlatTextBox);
            this.storageFormSkin.Controls.Add(this.flatLabel1);
            this.storageFormSkin.Controls.Add(this.closeFlatLabel);
            this.storageFormSkin.Controls.Add(this.flatMax1);
            this.storageFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.storageFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.storageFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.storageFormSkin.HeaderMaximize = false;
            this.storageFormSkin.Location = new System.Drawing.Point(0, 0);
            this.storageFormSkin.Name = "storageFormSkin";
            this.storageFormSkin.Size = new System.Drawing.Size(450, 242);
            this.storageFormSkin.TabIndex = 2;
            this.storageFormSkin.Text = "Edition d\'un Stockage";
            // 
            // ownerFlatComboBox
            // 
            this.ownerFlatComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ownerFlatComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ownerFlatComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ownerFlatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ownerFlatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownerFlatComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ownerFlatComboBox.ForeColor = System.Drawing.Color.Silver;
            this.ownerFlatComboBox.FormattingEnabled = true;
            this.ownerFlatComboBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.ownerFlatComboBox.ItemHeight = 18;
            this.ownerFlatComboBox.Location = new System.Drawing.Point(135, 109);
            this.ownerFlatComboBox.Name = "ownerFlatComboBox";
            this.ownerFlatComboBox.Size = new System.Drawing.Size(167, 24);
            this.ownerFlatComboBox.TabIndex = 162;
            // 
            // locationFlatTextBox
            // 
            this.locationFlatTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationFlatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.locationFlatTextBox.FocusOnHover = false;
            this.locationFlatTextBox.Location = new System.Drawing.Point(135, 198);
            this.locationFlatTextBox.MaxLength = 100;
            this.locationFlatTextBox.Multiline = false;
            this.locationFlatTextBox.Name = "locationFlatTextBox";
            this.locationFlatTextBox.ReadOnly = false;
            this.locationFlatTextBox.Size = new System.Drawing.Size(167, 29);
            this.locationFlatTextBox.TabIndex = 161;
            this.locationFlatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.locationFlatTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.locationFlatTextBox.UseSystemPasswordChar = false;
            // 
            // flatLabel4
            // 
            this.flatLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(8, 197);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(121, 30);
            this.flatLabel4.TabIndex = 160;
            this.flatLabel4.Text = "Postition (X:Y)";
            this.flatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flatLabel3
            // 
            this.flatLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(8, 153);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(121, 30);
            this.flatLabel3.TabIndex = 158;
            this.flatLabel3.Text = "Type de Stockage";
            this.flatLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storageTypeFlatComboBox
            // 
            this.storageTypeFlatComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.storageTypeFlatComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.storageTypeFlatComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storageTypeFlatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.storageTypeFlatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storageTypeFlatComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.storageTypeFlatComboBox.ForeColor = System.Drawing.Color.Silver;
            this.storageTypeFlatComboBox.FormattingEnabled = true;
            this.storageTypeFlatComboBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.storageTypeFlatComboBox.ItemHeight = 18;
            this.storageTypeFlatComboBox.Location = new System.Drawing.Point(135, 152);
            this.storageTypeFlatComboBox.Name = "storageTypeFlatComboBox";
            this.storageTypeFlatComboBox.Size = new System.Drawing.Size(167, 24);
            this.storageTypeFlatComboBox.TabIndex = 163;
            // 
            // StorageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 242);
            this.Controls.Add(this.storageFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageEditForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.storageFormSkin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlatUI.FlatButton cancelFlatButton;
        private FlatUI.FlatButton applyFlatButton;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox nameFlatTextBox;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel closeFlatLabel;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FormSkin storageFormSkin;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatTextBox locationFlatTextBox;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatComboBox ownerFlatComboBox;
        private FlatUI.FlatComboBox storageTypeFlatComboBox;
    }
}