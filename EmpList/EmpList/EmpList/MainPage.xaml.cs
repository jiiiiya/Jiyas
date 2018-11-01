using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmpList
{
    public partial class MainPage : ContentPage
    {
        EmpViewModel viewModel = new EmpViewModel();

        public MainPage()
        {
            InitializeComponent();

            listView.ItemsSource = viewModel.Emps;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpno.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtEname.Text))
            {
                return;
            }


            viewModel.Emps.Add(new Emp()
            {
                Empno = txtEmpno.Text,
                Ename = txtEname.Text,
                IsChecked = false
            });
            txtEmpno.Text = "";
            txtEname.Text = "";
        }
    }    
}
