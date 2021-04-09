using RolePlay_Notes.Properties;
using System;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class RelationEditForm : Form
    {
        private RPN_API_Web web;
        private int id = -1;

        public RelationEditForm(RPN_API_Web web, int id)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            relationEditFormSkin.FlatColor = Program.UIColor;

            financialSituationFlatComboBox.HoverColor = Program.UIColor;
            behaviourComboBox.HoverColor = Program.UIColor;
            groupTypeComboBox.HoverColor = Program.UIColor;
            powerflatComboBox.HoverColor = Program.UIColor;

            this.web = web;
            this.id = id;

            if (id != -1)
            {
                RPN_API_Json.RelationData relationData = web.GetRelation(id);
                nameFlatTextBox.Text = relationData.Name;
                behaviourComboBox.Text = relationData.Behaviour;
                powerflatComboBox.Text = relationData.Strength;
                groupTypeComboBox.Text = relationData.Type;
                financialSituationFlatComboBox.Text = relationData.FinancialSituation;
                effectifNumericUpDown.Value = relationData.Headcount;
                infoTextBox.Text = relationData.Info;
            }
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void applyFlatButton_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                if (!web.CreateRelation(nameFlatTextBox.Text, behaviourComboBox.Text, powerflatComboBox.Text, groupTypeComboBox.Text,
                    financialSituationFlatComboBox.Text, (int)effectifNumericUpDown.Value, infoTextBox.Text))
                {
                    MessageBox.Show("Impossible d'ajouter une relation !");
                }
            }
            else
            {
                if (!web.EditRelation(id, nameFlatTextBox.Text, behaviourComboBox.Text, powerflatComboBox.Text, groupTypeComboBox.Text,
                    financialSituationFlatComboBox.Text, (int)effectifNumericUpDown.Value, infoTextBox.Text))
                {
                    MessageBox.Show("Impossible de mettre à jour la relation !");
                }
            }
            Close();
        }
    }
}
