using RolePlay_Notes.Properties;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace RolePlay_Notes
{
    public partial class RenseignementEditForm : Form
    {
        private RPN_API_Web web;
        private int id;

        public RenseignementEditForm(RPN_API_Web web, int id)
        {
            InitializeComponent();
            Icon = Resources.RPN_Sharp;

            if (Program.IsFullscreen)
                WindowState = FormWindowState.Maximized;

            renseignementEditFormSkin.FlatColor = Program.UIColor;

            financialSituationFlatComboBox.HoverColor = Program.UIColor;
            behaviourComboBox.HoverColor = Program.UIColor;

            this.web = web;
            this.id = id;

            if (id != -1)
                LoadFromID(id);

        }

        private void LoadFromID(int id)
        {
            RPN_API_Json.RenseignementData renseignementData = web.GetRenseignement(id);

            nicknameFlatTextBox.Text = renseignementData.Nickname;
            nameFlatTextBox.Text = renseignementData.Name;
            pseudoFlatTextBox.Text = renseignementData.Pseudo;
            telFlatTextBox.Text = renseignementData.Tel;
            affiliationTextBox.Text = renseignementData.Affiliation;
            affiliationOldTextBox.Text = renseignementData.OldAffiliation;
            positionTextBox.Text = renseignementData.Position;
            licensePlateTextBox.Text = renseignementData.LicensePlate;
            knownVehicleTextBox.Text = renseignementData.KnownVehicle;
            financialSituationFlatComboBox.Text = renseignementData.FinancialSituation;
            behaviourComboBox.Text = renseignementData.Behaviour;
            infoTextBox.Text = renseignementData.Info;
            infoHRPTextBox.Text = renseignementData.InfoHrp;
            deadFlatCheckBox.Checked = renseignementData.Dead;
            wantedFlatCheckBox.Checked = renseignementData.Wanted;

            wantedSinceDateTimePicker.Value = renseignementData.WantedSince;
            wantedSinceFlatLabel.Visible = wantedFlatCheckBox.Checked;
            wantedSinceDateTimePicker.Visible = wantedFlatCheckBox.Checked;

            nameFakeFlatTextBox.Text = renseignementData.FakeName;
            nicknameFakeFlatTextBox.Text = renseignementData.FakeNickname;

            lastEditFlatLabel.Visible = true;
            lastEditDateFlatLabel.Visible = true;
            DateTimeFormatInfo fmt = (CultureInfo.CurrentCulture).DateTimeFormat;
            lastEditDateFlatLabel.Text = "Le " + renseignementData.LastEditDate.ToString("G", fmt);
            lastEditByFlatLabel.Visible = true;
            lastEditByFlatLabel.Text = "Par " + renseignementData.LastEditBy;

        }

        private void applyFlatButton_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    string financialSituationData = financialSituationFlatComboBox.Text.Equals("N/A") ? null : financialSituationFlatComboBox.Text;
                    string behaviourData = behaviourComboBox.Text.Equals("N/A") ? null : behaviourComboBox.Text;

                    if (!web.CreateRenseignement(nicknameFlatTextBox.Text, nameFlatTextBox.Text, pseudoFlatTextBox.Text, telFlatTextBox.Text,
                        affiliationTextBox.Text, affiliationOldTextBox.Text, positionTextBox.Text, licensePlateTextBox.Text,
                        knownVehicleTextBox.Text, financialSituationData, behaviourData, infoTextBox.Text,
                        infoHRPTextBox.Text, deadFlatCheckBox.Checked, wantedFlatCheckBox.Checked, wantedSinceDateTimePicker.Value,
                        nicknameFakeFlatTextBox.Text, nameFakeFlatTextBox.Text))
                    {
                        throw new Exception("API REPLY ERROR");
                    }
                    else
                    {
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'ajout de la fiche de renseignement !\n" +
                        "Erreur : " + ex.Message);
                }
            }
            else
            {
                try
                {
                    string financialSituationData = financialSituationFlatComboBox.Text.Equals("N/A") ? null : financialSituationFlatComboBox.Text;
                    string behaviourData = behaviourComboBox.Text.Equals("N/A") ? null : behaviourComboBox.Text;


                    if (!web.EditRenseignement(id, nicknameFlatTextBox.Text, nameFlatTextBox.Text, pseudoFlatTextBox.Text, telFlatTextBox.Text,
                        affiliationTextBox.Text, affiliationOldTextBox.Text, positionTextBox.Text, licensePlateTextBox.Text,
                        knownVehicleTextBox.Text, financialSituationData, behaviourData, infoTextBox.Text,
                        infoHRPTextBox.Text, deadFlatCheckBox.Checked, wantedFlatCheckBox.Checked, wantedSinceDateTimePicker.Value,
                        nicknameFakeFlatTextBox.Text, nameFlatTextBox.Text))
                    {
                        throw new Exception("API REPLY ERROR");
                    }
                    else
                    {
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la mise à jour de la fiche de renseignement !\n" +
                        "Erreur : " + ex.Message);
                }
            }
        }

        private void cancelFlatButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void cancelFlatButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void wantedFlatCheckBox_CheckedChanged(object sender)
        {
            wantedSinceFlatLabel.Visible = wantedFlatCheckBox.Checked;
            wantedSinceDateTimePicker.Visible = wantedFlatCheckBox.Checked;
        }

        private void closeFlatLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
