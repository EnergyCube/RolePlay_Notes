
namespace RolePlay_Notes
{
    partial class StorageTypeEditForm
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
            this.storageTypeFormSkin = new FlatUI.FormSkin();
            this.cancelFlatButton = new FlatUI.FlatButton();
            this.applyFlatButton = new FlatUI.FlatButton();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.nameFlatTextBox = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.closeFlatLabel = new FlatUI.FlatLabel();
            this.flatMax1 = new FlatUI.FlatMax();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.storageTypeFormSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // storageTypeFormSkin
            // 
            this.storageTypeFormSkin.BackColor = System.Drawing.Color.White;
            this.storageTypeFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.storageTypeFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.storageTypeFormSkin.Controls.Add(this.sizeNumericUpDown);
            this.storageTypeFormSkin.Controls.Add(this.cancelFlatButton);
            this.storageTypeFormSkin.Controls.Add(this.applyFlatButton);
            this.storageTypeFormSkin.Controls.Add(this.flatLabel2);
            this.storageTypeFormSkin.Controls.Add(this.nameFlatTextBox);
            this.storageTypeFormSkin.Controls.Add(this.flatLabel1);
            this.storageTypeFormSkin.Controls.Add(this.closeFlatLabel);
            this.storageTypeFormSkin.Controls.Add(this.flatMax1);
            this.storageTypeFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storageTypeFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.storageTypeFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.storageTypeFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.storageTypeFormSkin.HeaderMaximize = false;
            this.storageTypeFormSkin.Location = new System.Drawing.Point(0, 0);
            this.storageTypeFormSkin.Name = "storageTypeFormSkin";
            this.storageTypeFormSkin.Size = new System.Drawing.Size(390, 185);
            this.storageTypeFormSkin.TabIndex = 1;
            this.storageTypeFormSkin.Text = "Edition d\'un Type de Stockage";
            // 
            // cancelFlatButton
            // 
            this.cancelFlatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelFlatButton.Location = new System.Drawing.Point(266, 77);
            this.cancelFlatButton.Name = "cancelFlatButton";
            this.cancelFlatButton.Rounded = false;
            this.cancelFlatButton.Size = new System.Drawing.Size(112, 32);
            this.cancelFlatButton.TabIndex = 155;
            this.cancelFlatButton.Text = "Annuler";
            this.cancelFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cancelFlatButton.Click += new System.EventHandler(this.cancelFlatButton_Click);
            // 
            // applyFlatButton
            // 
            this.applyFlatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.applyFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.applyFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.applyFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.applyFlatButton.Location = new System.Drawing.Point(266, 118);
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
            this.flatLabel2.Location = new System.Drawing.Point(4, 120);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(67, 30);
            this.flatLabel2.TabIndex = 149;
            this.flatLabel2.Text = "Taille";
            this.flatLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameFlatTextBox
            // 
            this.nameFlatTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameFlatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.nameFlatTextBox.FocusOnHover = false;
            this.nameFlatTextBox.Location = new System.Drawing.Point(77, 77);
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
            this.flatLabel1.Location = new System.Drawing.Point(4, 77);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(67, 29);
            this.flatLabel1.TabIndex = 148;
            this.flatLabel1.Text = "Nom";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeFlatLabel
            // 
            this.closeFlatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFlatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFlatLabel.ForeColor = System.Drawing.Color.White;
            this.closeFlatLabel.Location = new System.Drawing.Point(360, 12);
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
            this.flatMax1.Location = new System.Drawing.Point(336, 12);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 135;
            this.flatMax1.Text = "flatMax";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sizeNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.sizeNumericUpDown.ForeColor = System.Drawing.Color.Silver;
            this.sizeNumericUpDown.Location = new System.Drawing.Point(77, 122);
            this.sizeNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(167, 29);
            this.sizeNumericUpDown.TabIndex = 158;
            // 
            // StorageTypeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 185);
            this.Controls.Add(this.storageTypeFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageTypeEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageTypeEditForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.storageTypeFormSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin storageTypeFormSkin;
        private FlatUI.FlatButton cancelFlatButton;
        private FlatUI.FlatButton applyFlatButton;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox nameFlatTextBox;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel closeFlatLabel;
        private FlatUI.FlatMax flatMax1;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
    }
}