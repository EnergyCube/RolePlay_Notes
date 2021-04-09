
namespace RolePlay_Notes
{
    partial class RelationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.relationFormSkin = new FlatUI.FormSkin();
            this.refreshFlatButton = new FlatUI.FlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteRelationFlatButton = new FlatUI.FlatButton();
            this.addRelationFlatButton = new FlatUI.FlatButton();
            this.editRelationFlatButton = new FlatUI.FlatButton();
            this.relationDataGridView = new System.Windows.Forms.DataGridView();
            this.flatMax1 = new FlatUI.FlatMax();
            this.closeFlatLabel = new FlatUI.FlatLabel();
            this.relationFormSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relationFormSkin
            // 
            this.relationFormSkin.BackColor = System.Drawing.Color.White;
            this.relationFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.relationFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.relationFormSkin.Controls.Add(this.refreshFlatButton);
            this.relationFormSkin.Controls.Add(this.pictureBox1);
            this.relationFormSkin.Controls.Add(this.deleteRelationFlatButton);
            this.relationFormSkin.Controls.Add(this.addRelationFlatButton);
            this.relationFormSkin.Controls.Add(this.editRelationFlatButton);
            this.relationFormSkin.Controls.Add(this.relationDataGridView);
            this.relationFormSkin.Controls.Add(this.flatMax1);
            this.relationFormSkin.Controls.Add(this.closeFlatLabel);
            this.relationFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relationFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.relationFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.relationFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.relationFormSkin.HeaderMaximize = false;
            this.relationFormSkin.Location = new System.Drawing.Point(0, 0);
            this.relationFormSkin.Name = "relationFormSkin";
            this.relationFormSkin.Size = new System.Drawing.Size(800, 450);
            this.relationFormSkin.TabIndex = 1;
            this.relationFormSkin.Text = "Gestion des Relations";
            // 
            // refreshFlatButton
            // 
            this.refreshFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refreshFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.refreshFlatButton.Location = new System.Drawing.Point(68, 69);
            this.refreshFlatButton.Name = "refreshFlatButton";
            this.refreshFlatButton.Rounded = false;
            this.refreshFlatButton.Size = new System.Drawing.Size(144, 32);
            this.refreshFlatButton.TabIndex = 156;
            this.refreshFlatButton.Text = "Rafraichir";
            this.refreshFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.refreshFlatButton.Click += new System.EventHandler(this.refreshFlatButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pictureBox1.Image = global::RolePlay_Notes.Properties.Resources.notebook;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // deleteRelationFlatButton
            // 
            this.deleteRelationFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRelationFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteRelationFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteRelationFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRelationFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteRelationFlatButton.Location = new System.Drawing.Point(316, 69);
            this.deleteRelationFlatButton.Name = "deleteRelationFlatButton";
            this.deleteRelationFlatButton.Rounded = false;
            this.deleteRelationFlatButton.Size = new System.Drawing.Size(144, 32);
            this.deleteRelationFlatButton.TabIndex = 153;
            this.deleteRelationFlatButton.Text = "Supprimer";
            this.deleteRelationFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.deleteRelationFlatButton.Click += new System.EventHandler(this.deleteRelationFlatButton_Click);
            // 
            // addRelationFlatButton
            // 
            this.addRelationFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRelationFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.addRelationFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addRelationFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRelationFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addRelationFlatButton.Location = new System.Drawing.Point(644, 69);
            this.addRelationFlatButton.Name = "addRelationFlatButton";
            this.addRelationFlatButton.Rounded = false;
            this.addRelationFlatButton.Size = new System.Drawing.Size(144, 32);
            this.addRelationFlatButton.TabIndex = 152;
            this.addRelationFlatButton.Text = "Ajouter";
            this.addRelationFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.addRelationFlatButton.Click += new System.EventHandler(this.addRelationFlatButton_Click);
            // 
            // editRelationFlatButton
            // 
            this.editRelationFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editRelationFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.editRelationFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editRelationFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editRelationFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editRelationFlatButton.Location = new System.Drawing.Point(494, 69);
            this.editRelationFlatButton.Name = "editRelationFlatButton";
            this.editRelationFlatButton.Rounded = false;
            this.editRelationFlatButton.Size = new System.Drawing.Size(144, 32);
            this.editRelationFlatButton.TabIndex = 151;
            this.editRelationFlatButton.Text = "Modifier";
            this.editRelationFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.editRelationFlatButton.Click += new System.EventHandler(this.editRelationFlatButton_Click);
            // 
            // relationDataGridView
            // 
            this.relationDataGridView.AllowUserToAddRows = false;
            this.relationDataGridView.AllowUserToDeleteRows = false;
            this.relationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.relationDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.NullValue = "N/A";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.relationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.relationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.relationDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.relationDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.relationDataGridView.Location = new System.Drawing.Point(12, 118);
            this.relationDataGridView.MultiSelect = false;
            this.relationDataGridView.Name = "relationDataGridView";
            this.relationDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.NullValue = "N/A";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.relationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.relationDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.NullValue = "N/A";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.relationDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.relationDataGridView.Size = new System.Drawing.Size(776, 320);
            this.relationDataGridView.TabIndex = 150;
            this.relationDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.relationDataGridView_CellDoubleClick);
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(746, 9);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 28;
            this.flatMax1.Text = "flatMax";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // closeFlatLabel
            // 
            this.closeFlatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFlatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFlatLabel.ForeColor = System.Drawing.Color.White;
            this.closeFlatLabel.Location = new System.Drawing.Point(770, 9);
            this.closeFlatLabel.Name = "closeFlatLabel";
            this.closeFlatLabel.Size = new System.Drawing.Size(18, 18);
            this.closeFlatLabel.TabIndex = 27;
            this.closeFlatLabel.Text = "X";
            this.closeFlatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeFlatLabel.Click += new System.EventHandler(this.closeFlatLabel_Click);
            // 
            // RelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.relationFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelationForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.relationFormSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin relationFormSkin;
        private FlatUI.FlatButton refreshFlatButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatButton deleteRelationFlatButton;
        private FlatUI.FlatButton addRelationFlatButton;
        private FlatUI.FlatButton editRelationFlatButton;
        private System.Windows.Forms.DataGridView relationDataGridView;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatLabel closeFlatLabel;
    }
}