using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CountryFlagNavigator
{
    public partial class Dashboard : Form
    {
        private readonly LinkedList<Country> countries = new LinkedList<Country>();
        private readonly LinkedList<Country> archivedCountries = new LinkedList<Country>();
        private Country currentCountry;
        public Dashboard()
        {
            InitializeComponent();
            FillCountries();
            countryInfoBox.ReadOnly = true;
            countryNameBox.ReadOnly = true;
            capitalNameBox.ReadOnly = true;
            undoButton.Visible = false;
            LoadCountryData();
        }

        private void FillCountries()
        {
            countries.AddLast(new Country("Bulgaria", "Some info for Bulgaria", "Sofia", "bg"));
            countries.AddLast(new Country("Germany", "Some info for Germany", "Berlin", "de"));
            countries.AddLast(new Country("France", "Some info for France", "Paris", "fr"));
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (countries.Count <= 0) return;
            countries.RemoveFirst();
            countries.AddLast(currentCountry);
            LoadCountryData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (countries.Count <= 0) return;
            var tempCountry = countries.Last;
            countries.RemoveLast();
            countries.AddFirst(tempCountry);
            LoadCountryData();
        }

        private void LoadCountryData()
        {
            undoButton.Visible = archivedCountries.Count > 0;
            deleteButton.Visible = countries.Count > 0;
            prevButton.Visible = countries.Count > 1;
            nextButton.Visible = countries.Count > 1;
            currentCountry = countries.First();
            countryNameBox.Text = currentCountry.Name;
            countryInfoBox.Text = currentCountry.Info;
            capitalNameBox.Text = currentCountry.Capital;
            flagBox.ImageLocation = $@"..\..\Flags\{currentCountry.PhotoID}.png";
            flagBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this country?",
                "Delete confirmation",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (countries.Count > 0)
                {
                    var countryToDelete = countries.First();
                    archivedCountries.AddFirst(countryToDelete);
                    countries.RemoveFirst();
                }
                if (countries.Count > 0)
                {
                    LoadCountryData();
                }
                else
                {
                    countryNameBox.Text = String.Empty;
                    countryInfoBox.Text = String.Empty;
                    countryCapital.Text = String.Empty;
                    flagBox.ImageLocation = String.Empty;
                    deleteButton.Visible = countries.Count > 0;
                }
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            var lastDeletedCountry = archivedCountries.First();
            archivedCountries.RemoveFirst();
            countries.AddLast(lastDeletedCountry);
            LoadCountryData();
        }
    }
}
