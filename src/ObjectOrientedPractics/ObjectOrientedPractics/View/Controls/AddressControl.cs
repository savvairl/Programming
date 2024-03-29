﻿using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;
        public AddressControl()
        {
            _address = new Address();

            InitializeComponent();
        }

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        public void Clear()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(PostIndexTextBox.Text);
                _address.Index = index;
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            PostIndexTextBox.BackColor = AppColor.CorrectColor;
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            CountryTextBox.BackColor = AppColor.CorrectColor;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            CityTextBox.BackColor = AppColor.CorrectColor;
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            StreetTextBox.BackColor = AppColor.CorrectColor;
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            BuildingTextBox.BackColor = AppColor.CorrectColor;
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            ApartmentTextBox.BackColor = AppColor.CorrectColor;
        }
    }
}
