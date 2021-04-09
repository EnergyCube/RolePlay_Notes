
namespace RolePlay_Notes
{
    partial class GroupManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupManagerForm));
            this.groupManagerFormSkin = new FlatUI.FormSkin();
            this.flatMax1 = new FlatUI.FlatMax();
            this.closeFlatLabel = new FlatUI.FlatLabel();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refreshFlatButton = new FlatUI.FlatButton();
            this.rowNbFlatLabel = new FlatUI.FlatLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteMemberFlatButton = new FlatUI.FlatButton();
            this.addMemberFlatButton = new FlatUI.FlatButton();
            this.editMemberFlatButton = new FlatUI.FlatButton();
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupSizeHelpFlatLabel = new FlatUI.FlatLabel();
            this.groupEncryptionHelpFlatLabel = new FlatUI.FlatLabel();
            this.groupEncryptionFlatToggle = new FlatUI.FlatToggle();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.encryptionPictureBox = new System.Windows.Forms.PictureBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.groupSizeFlatComboBox = new FlatUI.FlatComboBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.groupManagerFormSkin.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupManagerFormSkin
            // 
            this.groupManagerFormSkin.BackColor = System.Drawing.Color.White;
            this.groupManagerFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.groupManagerFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.groupManagerFormSkin.Controls.Add(this.flatMax1);
            this.groupManagerFormSkin.Controls.Add(this.closeFlatLabel);
            this.groupManagerFormSkin.Controls.Add(this.flatTabControl1);
            this.groupManagerFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupManagerFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupManagerFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupManagerFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.groupManagerFormSkin.HeaderMaximize = false;
            this.groupManagerFormSkin.Location = new System.Drawing.Point(0, 0);
            this.groupManagerFormSkin.Name = "groupManagerFormSkin";
            this.groupManagerFormSkin.Size = new System.Drawing.Size(800, 450);
            this.groupManagerFormSkin.TabIndex = 0;
            this.groupManagerFormSkin.Text = "Gestion du Groupe";
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
            this.flatTabControl1.Controls.Add(this.tabPage3);
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
            this.tabPage1.Controls.Add(this.refreshFlatButton);
            this.tabPage1.Controls.Add(this.rowNbFlatLabel);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.deleteMemberFlatButton);
            this.tabPage1.Controls.Add(this.addMemberFlatButton);
            this.tabPage1.Controls.Add(this.editMemberFlatButton);
            this.tabPage1.Controls.Add(this.groupDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Membres";
            // 
            // refreshFlatButton
            // 
            this.refreshFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.refreshFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.refreshFlatButton.Location = new System.Drawing.Point(64, 6);
            this.refreshFlatButton.Name = "refreshFlatButton";
            this.refreshFlatButton.Rounded = false;
            this.refreshFlatButton.Size = new System.Drawing.Size(144, 32);
            this.refreshFlatButton.TabIndex = 149;
            this.refreshFlatButton.Text = "Rafraichir";
            this.refreshFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.refreshFlatButton.Click += new System.EventHandler(this.refreshFlatButton_Click);
            // 
            // rowNbFlatLabel
            // 
            this.rowNbFlatLabel.BackColor = System.Drawing.Color.Transparent;
            this.rowNbFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowNbFlatLabel.ForeColor = System.Drawing.Color.White;
            this.rowNbFlatLabel.Location = new System.Drawing.Point(61, 39);
            this.rowNbFlatLabel.Name = "rowNbFlatLabel";
            this.rowNbFlatLabel.Size = new System.Drawing.Size(245, 17);
            this.rowNbFlatLabel.TabIndex = 148;
            this.rowNbFlatLabel.Text = "Vous avez %row_nb% membres";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RolePlay_Notes.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // deleteMemberFlatButton
            // 
            this.deleteMemberFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteMemberFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteMemberFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteMemberFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMemberFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteMemberFlatButton.Location = new System.Drawing.Point(312, 15);
            this.deleteMemberFlatButton.Name = "deleteMemberFlatButton";
            this.deleteMemberFlatButton.Rounded = false;
            this.deleteMemberFlatButton.Size = new System.Drawing.Size(144, 32);
            this.deleteMemberFlatButton.TabIndex = 146;
            this.deleteMemberFlatButton.Text = "Supprimer";
            this.deleteMemberFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.deleteMemberFlatButton.Click += new System.EventHandler(this.deleteMemberFlatButton_Click);
            // 
            // addMemberFlatButton
            // 
            this.addMemberFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addMemberFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.addMemberFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addMemberFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addMemberFlatButton.Location = new System.Drawing.Point(640, 15);
            this.addMemberFlatButton.Name = "addMemberFlatButton";
            this.addMemberFlatButton.Rounded = false;
            this.addMemberFlatButton.Size = new System.Drawing.Size(144, 32);
            this.addMemberFlatButton.TabIndex = 145;
            this.addMemberFlatButton.Text = "Ajouter";
            this.addMemberFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.addMemberFlatButton.Click += new System.EventHandler(this.addMemberFlatButton_Click);
            // 
            // editMemberFlatButton
            // 
            this.editMemberFlatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editMemberFlatButton.BackColor = System.Drawing.Color.Transparent;
            this.editMemberFlatButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editMemberFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editMemberFlatButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editMemberFlatButton.Location = new System.Drawing.Point(490, 15);
            this.editMemberFlatButton.Name = "editMemberFlatButton";
            this.editMemberFlatButton.Rounded = false;
            this.editMemberFlatButton.Size = new System.Drawing.Size(144, 32);
            this.editMemberFlatButton.TabIndex = 144;
            this.editMemberFlatButton.Text = "Modifier";
            this.editMemberFlatButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.editMemberFlatButton.Click += new System.EventHandler(this.editMemberFlatButton_Click);
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AllowUserToAddRows = false;
            this.groupDataGridView.AllowUserToDeleteRows = false;
            this.groupDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.NullValue = "N/A";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.groupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groupDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.groupDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.groupDataGridView.Location = new System.Drawing.Point(8, 62);
            this.groupDataGridView.MultiSelect = false;
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.NullValue = "N/A";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.groupDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.NullValue = "N/A";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.groupDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.groupDataGridView.Size = new System.Drawing.Size(776, 282);
            this.groupDataGridView.TabIndex = 143;
            this.groupDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupDataGridView_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.groupSizeHelpFlatLabel);
            this.tabPage2.Controls.Add(this.groupEncryptionHelpFlatLabel);
            this.tabPage2.Controls.Add(this.groupEncryptionFlatToggle);
            this.tabPage2.Controls.Add(this.flatLabel4);
            this.tabPage2.Controls.Add(this.encryptionPictureBox);
            this.tabPage2.Controls.Add(this.flatLabel3);
            this.tabPage2.Controls.Add(this.groupSizeFlatComboBox);
            this.tabPage2.Controls.Add(this.flatLabel2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion RPN";
            // 
            // groupSizeHelpFlatLabel
            // 
            this.groupSizeHelpFlatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSizeHelpFlatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.groupSizeHelpFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSizeHelpFlatLabel.ForeColor = System.Drawing.Color.White;
            this.groupSizeHelpFlatLabel.Location = new System.Drawing.Point(335, 131);
            this.groupSizeHelpFlatLabel.Name = "groupSizeHelpFlatLabel";
            this.groupSizeHelpFlatLabel.Size = new System.Drawing.Size(18, 18);
            this.groupSizeHelpFlatLabel.TabIndex = 156;
            this.groupSizeHelpFlatLabel.Text = "?";
            this.groupSizeHelpFlatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupEncryptionHelpFlatLabel
            // 
            this.groupEncryptionHelpFlatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEncryptionHelpFlatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.groupEncryptionHelpFlatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEncryptionHelpFlatLabel.ForeColor = System.Drawing.Color.White;
            this.groupEncryptionHelpFlatLabel.Location = new System.Drawing.Point(335, 226);
            this.groupEncryptionHelpFlatLabel.Name = "groupEncryptionHelpFlatLabel";
            this.groupEncryptionHelpFlatLabel.Size = new System.Drawing.Size(18, 18);
            this.groupEncryptionHelpFlatLabel.TabIndex = 29;
            this.groupEncryptionHelpFlatLabel.Text = "?";
            this.groupEncryptionHelpFlatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.groupEncryptionHelpFlatLabel.Click += new System.EventHandler(this.groupEncryptionHelpFlatLabel_Click);
            // 
            // groupEncryptionFlatToggle
            // 
            this.groupEncryptionFlatToggle.BackColor = System.Drawing.Color.Transparent;
            this.groupEncryptionFlatToggle.Checked = false;
            this.groupEncryptionFlatToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupEncryptionFlatToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupEncryptionFlatToggle.Location = new System.Drawing.Point(338, 190);
            this.groupEncryptionFlatToggle.Name = "groupEncryptionFlatToggle";
            this.groupEncryptionFlatToggle.Options = FlatUI.FlatToggle.StyleOptions.Style2;
            this.groupEncryptionFlatToggle.Size = new System.Drawing.Size(76, 33);
            this.groupEncryptionFlatToggle.TabIndex = 155;
            this.groupEncryptionFlatToggle.CheckedChanged += new FlatUI.FlatToggle.CheckedChangedEventHandler(this.groupEncryptionFlatToggle_CheckedChanged);
            // 
            // flatLabel4
            // 
            this.flatLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(335, 170);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(194, 17);
            this.flatLabel4.TabIndex = 154;
            this.flatLabel4.Text = "Encryption des Communications";
            this.flatLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // encryptionPictureBox
            // 
            this.encryptionPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.encryptionPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.encryptionPictureBox.Image = global::RolePlay_Notes.Properties.Resources.padunlock;
            this.encryptionPictureBox.Location = new System.Drawing.Point(254, 170);
            this.encryptionPictureBox.Name = "encryptionPictureBox";
            this.encryptionPictureBox.Size = new System.Drawing.Size(75, 75);
            this.encryptionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.encryptionPictureBox.TabIndex = 152;
            this.encryptionPictureBox.TabStop = false;
            // 
            // flatLabel3
            // 
            this.flatLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(335, 74);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(104, 17);
            this.flatLabel3.TabIndex = 151;
            this.flatLabel3.Text = "Taille du Groupe";
            this.flatLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupSizeFlatComboBox
            // 
            this.groupSizeFlatComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupSizeFlatComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.groupSizeFlatComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupSizeFlatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.groupSizeFlatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupSizeFlatComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupSizeFlatComboBox.ForeColor = System.Drawing.Color.White;
            this.groupSizeFlatComboBox.FormattingEnabled = true;
            this.groupSizeFlatComboBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupSizeFlatComboBox.ItemHeight = 18;
            this.groupSizeFlatComboBox.Items.AddRange(new object[] {
            "Grand (10 et +)",
            "Moyen (8 et +)",
            "Petit (6 et +)",
            "Mini (5)"});
            this.groupSizeFlatComboBox.Location = new System.Drawing.Point(338, 103);
            this.groupSizeFlatComboBox.Name = "groupSizeFlatComboBox";
            this.groupSizeFlatComboBox.Size = new System.Drawing.Size(147, 24);
            this.groupSizeFlatComboBox.TabIndex = 150;
            // 
            // flatLabel2
            // 
            this.flatLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(243, 15);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(300, 17);
            this.flatLabel2.TabIndex = 149;
            this.flatLabel2.Text = "Le prix de votre abbonement RPN est de X€/Mois";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(254, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 148;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.flatLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Autres";
            // 
            // flatLabel1
            // 
            this.flatLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(3, 3);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(786, 344);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "Changement du nom de groupe ?\r\nBesoin de récupérer une version ultérieur ?\r\nBesoi" +
    "n d\'aide ?\r\n\r\nContactez l\'Admin de RPN";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupManagerFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupManagerForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.groupManagerFormSkin.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin groupManagerFormSkin;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatLabel closeFlatLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView groupDataGridView;
        private FlatUI.FlatButton deleteMemberFlatButton;
        private FlatUI.FlatButton addMemberFlatButton;
        private FlatUI.FlatButton editMemberFlatButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatComboBox groupSizeFlatComboBox;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel4;
        private System.Windows.Forms.PictureBox encryptionPictureBox;
        private FlatUI.FlatLabel groupSizeHelpFlatLabel;
        private FlatUI.FlatLabel groupEncryptionHelpFlatLabel;
        private FlatUI.FlatToggle groupEncryptionFlatToggle;
        private FlatUI.FlatButton refreshFlatButton;
        private FlatUI.FlatLabel rowNbFlatLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}