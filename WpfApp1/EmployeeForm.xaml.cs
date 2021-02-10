using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for EmployeeForm.xaml
    /// </summary>
    
    //Question 1 Display Employee Data
    public partial class EmployeeForm : Window
    {
        EmployeeDataClassesDataContext dc; 
        public EmployeeForm()
        {
            InitializeComponent();
            dc = new EmployeeDataClassesDataContext();
            //fill the grid with all employee data
            EmployeeDg.ItemsSource = from Emp in dc.Employees 
                                     select Emp;
        }

        //1.Select data of all employees whose age is greater than 25.
        private void AllEmpAgeGrt25_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees 
                                     where Emp.Emp_Age > 25 
                                     select Emp;
        }

        //2. Select data of all female employees order by Employee department.
        private void AllFemaleEmp_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where Emp.Emp_Gender == "Female" orderby Emp.Emp_ID 
                                     select Emp;
        }

        //3. Select all employees whose age between 25 to 30
        private void EmpBt20to30_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where (Emp.Emp_Age >=25 && Emp.Emp_Age <=30) 
                                     select Emp;
        }

        //4.Select all records of female employees whose emp id is between 103 to 106
        private void F_EmpIdBt103t0106_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees 
                                     where Emp.Emp_Gender == "Female" && (Emp.Emp_ID >= 103 && Emp.Emp_ID <= 106)
                                     select Emp;
        }

       //5. Select the data of employees whose length of FirstName is > 5.
        private void EmpFNameGrt5_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where Emp.Emp_FName.Length > 5
                                     select Emp;
        }

        //6.Select the data of employees whose name start with ‘C’ 
        private void EmpNameStC_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where Emp.Emp_FName.StartsWith("C")
                                     select Emp;
        }

        //7.Select the data of employees who is having ‘gmail’ email id. 
        private void EmpGmailId_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where Emp.Emp_Email.Contains("gmail")
                                     select Emp;
        }

        //8.Select the data of employees whose last name is ‘Nafar’.
        private void EmpLnameNafar_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where Emp.Emp_LName.EndsWith("Nafar")
                                     select Emp;
        }

        //9. Select the data of employees whose name contains ‘sh’
        private void EmpNameSH_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where (Emp.Emp_LName.Contains("sh") || Emp.Emp_FName.Contains("sh"))
                                     select Emp;
        }

        //10.Select the data of employees whose age is either 20,30 or 35
        private void EmpAge203035_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where (Emp.Emp_Age == 20 || Emp.Emp_Age == 30 || Emp.Emp_Age == 35)
                                     select Emp;
        }

        //11. Find out all teenager employees.
        private void TenenageEmp_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where (Emp.Emp_Age >= 13 && Emp.Emp_Age <= 19)
                                     select Emp;
        }

        //12.Sorts all employees Last name in descending order
        private void LastNameInDesc_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     orderby Emp.Emp_LName descending
                                     select Emp;
        }

        //13.Get the full combined name for employees born in 1992 or later
        private void bornIn1992OrLater_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where Emp.Emp_DBO.Value.Year >= 1992
                                     select Emp;
        }

       //14. Count number of employees in department Accounting & Finance.
        private void AccFinanceDept_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDg.ItemsSource = from Emp in dc.Employees
                                     where (Emp.Emp_Dept == "Accounting" || Emp.Emp_Dept == "Finance")
                                     group Emp by Emp.Emp_Dept into D
                                     where D.Count() >= 1
                                     select new { Dept = D.Key, EmployeeCount = D.Count() };

        }
    }
}
