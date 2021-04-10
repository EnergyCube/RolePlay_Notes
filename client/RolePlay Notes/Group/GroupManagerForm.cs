using RolePlay_Notes.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class GroupManagerForm : Form
    {
        private RPN_API_Web web;

        public GroupManagerForm(RPN_API_Web web)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            groupManagerFormSkin.FlatColor = Program.UIColor;

            groupSizeFlatComboBox.HoverColor = Program.UIColor;

            groupDataGridView.Columns.Add("username", "Utilisateur");
            groupDataGridView.Columns.Add("playerid", "Renseignement ID");
            groupDataGridView.Columns.Add("permission", "Permission");

            groupDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            groupDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            groupDataGridView.AllowUserToResizeRows = false;

            this.web = web;

            ReloadData();

            // Hide work in tab
            flatTabControl1.TabPages.Remove(flatTabControl1.TabPages[1]);
        }

        private void ReloadData()
        {
            groupDataGridView.Rows.Clear();
            refreshFlatButton.Enabled = false;

            try
            {
                List<RPN_API_Json.InternalData> users = web.GetAllUsers();

                foreach (RPN_API_Json.InternalData internalData in users)
                {
                    rowNbFlatLabel.Text = users.Count + " Membre(s)";
                    groupDataGridView.Rows.Add(internalData.Username, internalData.RenseignementID, internalData.Permission);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de la récupérations des membres de groupe !\n" +
                    "Erreur : " + ex.Message, "Erreur");
            }

            refreshFlatButton.Enabled = true;
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addMemberFlatButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                Program.IsFullscreen = true;
            else
                Program.IsFullscreen = false;

            new GroupManagerEditForm(web, null).ShowDialog();
            ReloadData();
        }

        private void refreshFlatButton_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void groupEncryptionHelpFlatLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votre groupe utilise une branche du réseau RPN, malheureusement les plus riches groupes de l'île" +
                " peuvent vous attaquer à tout moment !\n" +
                "En activant l'encryptage des communications RPN de votre groupe les risques de piratage sont largement réduits !\n" +
                "La sécurité n'a pas de prix n'est ce pas.\n" +
                "La fonction d'encryption aurgmente de 20% le prix de votre abonnement RPN.", "Encryption RPN");
        }

        private void groupEncryptionFlatToggle_CheckedChanged(object sender)
        {
            ReloadSub();
        }

        private void ReloadSub()
        {
            if (groupEncryptionFlatToggle.Checked)
            {
                encryptionPictureBox.Image = Resources.padlock;
            }
            else
            {
                encryptionPictureBox.Image = Resources.padunlock;
            }
        }

        private void editMemberFlatButton_Click(object sender, EventArgs e)
        {
            if (groupDataGridView.SelectedRows.Count > 0)
            {
                string user = groupDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                new GroupManagerEditForm(web, user).ShowDialog();
                ReloadData();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de membre !");
                return;
            }
        }

        private void deleteMemberFlatButton_Click(object sender, EventArgs e)
        {
            if (groupDataGridView.SelectedRows.Count > 0)
            {
                string user = groupDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                DeleteUser(user);
                ReloadData();
            }
            else
            {
                MessageBox.Show("Vous n'avez pas selectionné de membre !");
                return;
            }
        }

        private void DeleteUser(string username)
        {
            DialogResult dialogResult = MessageBox.Show
                ("Voulez vous vraiment supprimer l'utilisateur '" + username + "' du groupe ?",
                "Suppression d'un membre ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (!web.DeleteUser(username))
                    {
                        MessageBox.Show("Une erreur est survenue lors de la suppression du membre !\n", "Erreur");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la suppression du membre !\n" +
                        "Erreur : " + ex.Message, "Erreur");
                }

            }
        }

        private void groupDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new GroupManagerEditForm(web, groupDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
            ReloadData();
        }
    }
}
