using SchedulerApp.DAL;
using SchedulerApp.Entities;
using SchedulerApp.Models;

namespace SchedulerApp
{
    public partial class CustomerForm : Form
    {
        private CustomerModel? customer;
        private readonly int customerId;
        private readonly CompositeDAL dal;
        private readonly MainScreen mainScreen;
        private readonly User user;

        public CustomerForm(int customerId, CompositeDAL dal, MainScreen mainScreen, User user)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.dal = dal;
            this.mainScreen = mainScreen;
            this.user = user;
        }

        /***********************
         * Form Event Handlers *
         ***********************/

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customer = dal.customer.GetCustomer(customerId);

            if (customer.customerId > 0)
            {
                nameTextBox.Text = customer.customerName;
                phoneNumberTextBox.Text = customer.address.phone;
                addressLine1TextBox.Text = customer.address.address;
                addressLine2TextBox.Text = customer.address.address2;
                cityTextBox.Text = customer.address.city.city;
                postalCodeTextBox.Text = customer.address.postalCode;
                countryTextBox.Text = customer.address.city.country.country;
                activeCheckBox.Checked = customer.active == 1;
            }
        }

        /*************************
         * Button Event Handlers *
         *************************/

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var country = dal.address.GetCountryByName(countryTextBox.Text);

            if (country.countryId <= 0)
            {
                country = new Country()
                {
                    country = countryTextBox.Text,
                    createDate = DateTime.Now.Date,
                    createdBy = user.userName,
                    lastUpdate = DateTime.Now,
                    lastUpdateBy = user.userName,
                };

                country.countryId = dal.address.CreateCountry(country);
            }

            var city = dal.address.GetCityByName(cityTextBox.Text);

            if (city.cityId <= 0)
            {
                city = new City()
                {
                    city = cityTextBox.Text,
                    countryId = country.countryId,
                    createDate = DateTime.Now.Date,
                    createdBy = user.userName,
                    lastUpdate = DateTime.Now,
                    lastUpdateBy = user.userName,
                };

                city.cityId = dal.address.CreateCity(city);
            }

            int addressId;

            if (customer!.addressId > 0)
            {
                dal.address.UpdateAddress(new Address()
                {
                    addressId = customer.addressId,
                    address = addressLine1TextBox.Text,
                    address2 = addressLine2TextBox.Text,
                    cityId = city.cityId,
                    postalCode = postalCodeTextBox.Text,
                    phone = phoneNumberTextBox.Text,
                    createDate = DateTime.Now.Date,
                    createdBy = user.userName,
                    lastUpdate = DateTime.Now,
                    lastUpdateBy = user.userName,
                });

                addressId = customer.addressId;
            }
            else
            {
                addressId = dal.address.CreateAddress(new Address()
                {
                    address = addressLine1TextBox.Text,
                    address2 = addressLine2TextBox.Text,
                    cityId = city.cityId,
                    postalCode = postalCodeTextBox.Text,
                    phone = phoneNumberTextBox.Text,
                    createDate = DateTime.Now.Date,
                    createdBy = user.userName,
                    lastUpdate = DateTime.Now,
                    lastUpdateBy = user.userName,
                });
            }

            if (customer.customerId > 0)
            {
                dal.customer.UpdateCustomer(new Customer()
                {
                    customerId = customer.customerId,
                    customerName = nameTextBox.Text,
                    addressId = addressId,
                    active = activeCheckBox.Checked ? 1 : 0,
                    createDate = DateTime.Now.Date,
                    createdBy = user.userName,
                    lastUpdate = DateTime.Now,
                    lastUpdateBy = user.userName,
                });
            }
            else
            {
                dal.customer.CreateCustomer(new Customer()
                {
                    customerName = nameTextBox.Text,
                    addressId = addressId,
                    active = activeCheckBox.Checked ? 1 : 0,
                    createDate = DateTime.Now.Date,
                    createdBy = user.userName,
                    lastUpdate = DateTime.Now,
                    lastUpdateBy = user.userName,
                });
            }

            mainScreen.RefreshData();
            Close();
        }
    }
}
