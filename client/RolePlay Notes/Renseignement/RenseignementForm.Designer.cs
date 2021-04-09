
namespace RolePlay_Notes
{
    partial class RenseignementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.renseignementFormSkin = new FlatUI.FormSkin();
            this.deleteFlatButton = new FlatUI.FlatButton();
            this.refreshFlatButton = new FlatUI.FlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatMax1 = new FlatUI.FlatMax();
            this.rowNbFlatLabel = new FlatUI.FlatLabel();
            this.addFlatButton = new FlatUI.FlatButton();
            this.editFlatButton = new FlatUI.FlatButton();
            this.closeFlatLabel = new FlatUI.FlatLabel();
            this.renseignementDataGridView = new System.Windows.Forms.DataGridView();
            this.renseignementFormSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renseignementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // renseignementFormSkin
            // 
            this.renseignementFormSkin.BackColor = System.Drawing.Color.White;
            this.renseignementFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.renseignementFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.renseignementFormSkin.Controls.Add(this.deleteFlatButton);
            this.renseignementFormSkin.Controls.Add(this.refreshFlatButton);
            this.renseignementFormSkin.Controls.Add(this.pictureBox1);
            this.renseignementFormSkin.Controls.Add(this.flatMax1);
            this.renseignementFormSkin.Controls.Add(this.rowNbFlatLabel);
            this.renseignementFormSkin.Controls.Add(this.addFlatButton);
            this.renseignementFormSkin.Controls.Add(this.editFlatButton);
            this.renseignementFormSkin.Controls.Add(this.closeFlatLabel);
            this.renseignementFormSkin.Controls.Add(this.renseignementDataGridView);
            this.renseignementFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renseignementFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.renseignementFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.renseignementFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.renseignementFormSkin.HeaderMaximize = false;
            this.renseignementFormSkin.Location = new System.Drawing.Point(0, 0);
            this.renseignementFormSkin.Name = "renseignementFormSkin";
            this.renseignementFormSkin.Size = new System.Drawing.Size(985, 530);
            this.renseignementFormSkin.TabIndex = 0;
            this.renseignementFormSkin.Text = "Renseignements";
            // 
            // deleteFlatButton
            // 
            this.deleteFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteFlatButton.Location = new System.Drawing.Point(501, 66);
            this.deleteFlatButton.Name = "deleteFlatButton";
            this.deleteFlatButton.Rounded = false;
            this.deleteFlatButton.Size = new System.Drawing.Size(144, 32);
            this.deleteFlatButton.TabIndex = 29;
            this.deleteFlatButton.Text = "Supprimer";
            this.deleteFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.deleteFlatButton.Click += new System.EventHandler(this.deleteFlatButton_Click);
            // 
            // refreshFlatButton
            // 
            this.refreshFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refreshFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.refreshFlatButton.Location = new System.Drawing.Point(71, 56);
            this.refreshFlatButton.Name = "refreshFlatButton";
            this.refreshFlatButton.Rounded = false;
            this.refreshFlatButton.Size = new System.Drawing.Size(144, 32);
            this.refreshFlatButton.TabIndex = 28;
            this.refreshFlatButton.Text = "Rafraichir";
            this.refreshFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.refreshFlatButton.Click += new System.EventHandler(this.refreshFlatButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pictureBox1.Image = global::RolePlay_Notes.Properties.Resources.cloud_data;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(931, 13);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 25;
            this.flatMax1.Text = "flatMax";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // rowNbFlatLabel
            // 
            this.rowNbFlatLabel.BackColor = System.Drawing.Color.Transparent;
            this.rowNbFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowNbFlatLabel.ForeColor = System.Drawing.Color.White;
            this.rowNbFlatLabel.Location = new System.Drawing.Point(68, 89);
            this.rowNbFlatLabel.Name = "rowNbFlatLabel";
            this.rowNbFlatLabel.Size = new System.Drawing.Size(427, 17);
            this.rowNbFlatLabel.TabIndex = 15;
            this.rowNbFlatLabel.Text = "Vous avez %row_nb% fiches de renseignements";
            // 
            // addFlatButton
            // 
            this.addFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.addFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addFlatButton.Location = new System.Drawing.Point(829, 66);
            this.addFlatButton.Name = "addFlatButton";
            this.addFlatButton.Rounded = false;
            this.addFlatButton.Size = new System.Drawing.Size(144, 32);
            this.addFlatButton.TabIndex = 14;
            this.addFlatButton.Text = "Ajouter";
            this.addFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.addFlatButton.Click += new System.EventHandler(this.addPlayerFlatButton_Click);
            // 
            // editFlatButton
            // 
            this.editFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.editFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editFlatButton.Location = new System.Drawing.Point(679, 66);
            this.editFlatButton.Name = "editFlatButton";
            this.editFlatButton.Rounded = false;
            this.editFlatButton.Size = new System.Drawing.Size(144, 32);
            this.editFlatButton.TabIndex = 13;
            this.editFlatButton.Text = "Modifier";
            this.editFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.editFlatButton.Click += new System.EventHandler(this.editFlatButton_Click);
            // 
            // closeFlatLabel
            // 
            this.closeFlatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFlatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFlatLabel.ForeColor = System.Drawing.Color.White;
            this.closeFlatLabel.Location = new System.Drawing.Point(955, 13);
            this.closeFlatLabel.Name = "closeFlatLabel";
            this.closeFlatLabel.Size = new System.Drawing.Size(18, 18);
            this.closeFlatLabel.TabIndex = 3;
            this.closeFlatLabel.Text = "X";
            this.closeFlatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeFlatLabel.Click += new System.EventHandler(this.closeFlatLabel_Click);
            // 
            // renseignementDataGridView
            // 
            this.renseignementDataGridView.AllowUserToAddRows = false;
            this.renseignementDataGridView.AllowUserToDeleteRows = false;
            this.renseignementDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renseignementDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.renseignementDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.renseignementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.renseignementDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.renseignementDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.renseignementDataGridView.Location = new System.Drawing.Point(12, 112);
            this.renseignementDataGridView.MultiSelect = false;
            this.renseignementDataGridView.Name = "renseignementDataGridView";
            this.renseignementDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.renseignementDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.renseignementDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.NullValue = "N/A";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.renseignementDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.renseignementDataGridView.Size = new System.Drawing.Size(961, 406);
            this.renseignementDataGridView.TabIndex = 0;
            this.renseignementDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.renseignementDataGridView_CellDoubleClick);
            // 
            // RenseignementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 530);
            this.Controls.Add(this.renseignementFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RenseignementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RenseignementForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.renseignementFormSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renseignementDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin renseignementFormSkin;
        private System.Windows.Forms.DataGridView renseignementDataGridView;
        private FlatUI.FlatLabel closeFlatLabel;
        private FlatUI.FlatButton addFlatButton;
        private FlatUI.FlatButton editFlatButton;
        private FlatUI.FlatLabel rowNbFlatLabel;
        private FlatUI.FlatMax flatMax1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatButton refreshFlatButton;
        private FlatUI.FlatButton deleteFlatButton;
    }
}