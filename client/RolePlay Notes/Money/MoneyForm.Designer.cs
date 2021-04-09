
namespace RolePlay_Notes
{
    partial class MoneyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.moneyManagerFormSkin = new FlatUI.FormSkin();
            this.flatMax1 = new FlatUI.FlatMax();
            this.closeFlatLabel = new FlatUI.FlatLabel();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refreshPersoFlatButton = new FlatUI.FlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editMoneyPersoFlatButton = new FlatUI.FlatButton();
            this.moneyPersoDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refreshGroupFlatButton = new FlatUI.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.editMoneyGroupFlatButton = new FlatUI.FlatButton();
            this.moneyGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.moneyManagerFormSkin.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPersoDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyGroupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyManagerFormSkin
            // 
            this.moneyManagerFormSkin.BackColor = System.Drawing.Color.White;
            this.moneyManagerFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.moneyManagerFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.moneyManagerFormSkin.Controls.Add(this.flatMax1);
            this.moneyManagerFormSkin.Controls.Add(this.closeFlatLabel);
            this.moneyManagerFormSkin.Controls.Add(this.flatTabControl1);
            this.moneyManagerFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyManagerFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.moneyManagerFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.moneyManagerFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.moneyManagerFormSkin.HeaderMaximize = false;
            this.moneyManagerFormSkin.Location = new System.Drawing.Point(0, 0);
            this.moneyManagerFormSkin.Name = "moneyManagerFormSkin";
            this.moneyManagerFormSkin.Size = new System.Drawing.Size(800, 450);
            this.moneyManagerFormSkin.TabIndex = 1;
            this.moneyManagerFormSkin.Text = "Gestion d\'Argent";
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
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.flatTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 50);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(800, 400);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.refreshPersoFlatButton);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.editMoneyPersoFlatButton);
            this.tabPage1.Controls.Add(this.moneyPersoDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Argent Personnel";
            // 
            // refreshPersoFlatButton
            // 
            this.refreshPersoFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshPersoFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refreshPersoFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshPersoFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.refreshPersoFlatButton.Location = new System.Drawing.Point(64, 15);
            this.refreshPersoFlatButton.Name = "refreshPersoFlatButton";
            this.refreshPersoFlatButton.Rounded = false;
            this.refreshPersoFlatButton.Size = new System.Drawing.Size(144, 32);
            this.refreshPersoFlatButton.TabIndex = 149;
            this.refreshPersoFlatButton.Text = "Rafraichir";
            this.refreshPersoFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.refreshPersoFlatButton.Click += new System.EventHandler(this.refreshFlatButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RolePlay_Notes.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // editMoneyPersoFlatButton
            // 
            this.editMoneyPersoFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editMoneyPersoFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.editMoneyPersoFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editMoneyPersoFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editMoneyPersoFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editMoneyPersoFlatButton.Location = new System.Drawing.Point(640, 15);
            this.editMoneyPersoFlatButton.Name = "editMoneyPersoFlatButton";
            this.editMoneyPersoFlatButton.Rounded = false;
            this.editMoneyPersoFlatButton.Size = new System.Drawing.Size(144, 32);
            this.editMoneyPersoFlatButton.TabIndex = 144;
            this.editMoneyPersoFlatButton.Text = "Modifier";
            this.editMoneyPersoFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.editMoneyPersoFlatButton.Click += new System.EventHandler(this.editMoneyFlatButton_Click);
            // 
            // moneyPersoDataGridView
            // 
            this.moneyPersoDataGridView.AllowUserToAddRows = false;
            this.moneyPersoDataGridView.AllowUserToDeleteRows = false;
            this.moneyPersoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyPersoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moneyPersoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.moneyPersoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.moneyPersoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.moneyPersoDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.moneyPersoDataGridView.Location = new System.Drawing.Point(8, 62);
            this.moneyPersoDataGridView.MultiSelect = false;
            this.moneyPersoDataGridView.Name = "moneyPersoDataGridView";
            this.moneyPersoDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moneyPersoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.moneyPersoDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.NullValue = "N/A";
            this.moneyPersoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.moneyPersoDataGridView.Size = new System.Drawing.Size(776, 282);
            this.moneyPersoDataGridView.TabIndex = 143;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.refreshGroupFlatButton);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.editMoneyGroupFlatButton);
            this.tabPage2.Controls.Add(this.moneyGroupDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Argent Groupe";
            // 
            // refreshGroupFlatButton
            // 
            this.refreshGroupFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshGroupFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refreshGroupFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshGroupFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.refreshGroupFlatButton.Location = new System.Drawing.Point(64, 15);
            this.refreshGroupFlatButton.Name = "refreshGroupFlatButton";
            this.refreshGroupFlatButton.Rounded = false;
            this.refreshGroupFlatButton.Size = new System.Drawing.Size(144, 32);
            this.refreshGroupFlatButton.TabIndex = 153;
            this.refreshGroupFlatButton.Text = "Rafraichir";
            this.refreshGroupFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.refreshGroupFlatButton.Click += new System.EventHandler(this.refreshFlatButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RolePlay_Notes.Properties.Resources.wallet;
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 152;
            this.pictureBox2.TabStop = false;
            // 
            // editMoneyGroupFlatButton
            // 
            this.editMoneyGroupFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editMoneyGroupFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.editMoneyGroupFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editMoneyGroupFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editMoneyGroupFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editMoneyGroupFlatButton.Location = new System.Drawing.Point(640, 15);
            this.editMoneyGroupFlatButton.Name = "editMoneyGroupFlatButton";
            this.editMoneyGroupFlatButton.Rounded = false;
            this.editMoneyGroupFlatButton.Size = new System.Drawing.Size(144, 32);
            this.editMoneyGroupFlatButton.TabIndex = 151;
            this.editMoneyGroupFlatButton.Text = "Modifier";
            this.editMoneyGroupFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.editMoneyGroupFlatButton.Click += new System.EventHandler(this.editMoneyGroupFlatButton_Click);
            // 
            // moneyGroupDataGridView
            // 
            this.moneyGroupDataGridView.AllowUserToAddRows = false;
            this.moneyGroupDataGridView.AllowUserToDeleteRows = false;
            this.moneyGroupDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyGroupDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.NullValue = "N/A";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moneyGroupDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.moneyGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.moneyGroupDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.moneyGroupDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.moneyGroupDataGridView.Location = new System.Drawing.Point(8, 62);
            this.moneyGroupDataGridView.MultiSelect = false;
            this.moneyGroupDataGridView.Name = "moneyGroupDataGridView";
            this.moneyGroupDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.NullValue = "N/A";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moneyGroupDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.moneyGroupDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.NullValue = "N/A";
            this.moneyGroupDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.moneyGroupDataGridView.Size = new System.Drawing.Size(776, 282);
            this.moneyGroupDataGridView.TabIndex = 150;
            // 
            // MoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyManagerFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.moneyManagerFormSkin.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyPersoDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyGroupDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin moneyManagerFormSkin;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatLabel closeFlatLabel;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FlatUI.FlatButton refreshPersoFlatButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatButton editMoneyPersoFlatButton;
        private System.Windows.Forms.DataGridView moneyPersoDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private FlatUI.FlatButton refreshGroupFlatButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FlatUI.FlatButton editMoneyGroupFlatButton;
        private System.Windows.Forms.DataGridView moneyGroupDataGridView;
    }
}