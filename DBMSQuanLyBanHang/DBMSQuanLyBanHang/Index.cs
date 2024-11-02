using DBMSQuanLyBanHang.Manager;
using DBMSQuanLyBanHang.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSQuanLyBanHang
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void employeecard_Click(object sender, EventArgs e)
        {
            EmployeeView view = new EmployeeView();
            view.ShowDialog();
        }

        private void recipecard_Click(object sender, EventArgs e)
        {
            RecipeView view = new RecipeView();
            view.ShowDialog();
        }

        private void categorycard_Click(object sender, EventArgs e)
        {
            CategoryView view = new CategoryView();
            view.ShowDialog();
        }

        private void categorytypecard_Click(object sender, EventArgs e)
        {
            CategoryTypeView view = new CategoryTypeView();
            view.ShowDialog();
        }

        private void importordercard_Click(object sender, EventArgs e)
        {
            ImportOrderView view = new ImportOrderView();
            view.ShowDialog();
        }

        private void suppliercard_Click(object sender, EventArgs e)
        {
            SupplierView view = new SupplierView();
            view.ShowDialog();
        }


        private void employeeManager_Click(object sender, EventArgs e)
        {
            EmployeeManager manager = new EmployeeManager();
            manager.ShowDialog();
        }

        private void receiptManager_Click(object sender, EventArgs e)
        {
            ReceiptManager manager = new ReceiptManager();
            manager.ShowDialog();
        }

        private void importOrderManager_Click(object sender, EventArgs e)
        {
            ImportOrderManager manager = new ImportOrderManager();
            manager.ShowDialog();
        }

        private void categoryManager_Click(object sender, EventArgs e)
        {
            CategoryManage manage = new CategoryManage();
            manage.ShowDialog();
        }

        private void supplierManager_Click(object sender, EventArgs e)
        {
            SuppilerManage manage = new SuppilerManage();
            manage.ShowDialog();
        }

        private void RevenueManage_Click(object sender, EventArgs e)
        {
            RevenueManage manage = new RevenueManage();
            manage.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            RevenueCorrelation manage = new RevenueCorrelation();
            manage.ShowDialog();
        }
    }
}
