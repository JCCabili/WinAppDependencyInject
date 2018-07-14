using EFCoreWinApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using EFCoreWinApp.Data.Repository;
using EFCoreWinApp.Data.Interface;
using EFCoreWinApp.Custom;
using Unity;
using EFCoreWinApp.Data.Model;

namespace EFCoreWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }
        private IEmployee _employeeRepository;
        public void Initialize()
        {
            _employeeRepository = Global.Container.Resolve<IEmployee>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void LoadEmployee()
        {
            var emplist = _employeeRepository.GetAllWithAddress();

            StringBuilder sb = new StringBuilder();
            foreach (var emp in emplist)
            {
                sb.AppendLine(emp.Name);
                foreach (var add in emp.AddressList)
                {
                    sb.AppendLine(add.Address1);
                }
            }

            textBox1.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emp = new Employee();

            emp.Name = txtName.Text;
            emp.Inital = txtInital.Text;

            _employeeRepository.Create(emp);
            LoadEmployee();
        }
    }
}
