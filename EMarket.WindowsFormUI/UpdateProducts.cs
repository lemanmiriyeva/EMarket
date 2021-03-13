using System;
using System.Windows.Forms;
using Coree.Business.DependencyResolvers.Ninject;
using EMarket.Business.Abstract;
using EMarket.Entity.Concrete;
using EMarket.WindowsFormUI.Helper;
using Ninject.Modules;

namespace EMarket.WindowsFormUI
{
    public partial class UpdateProducts : Form
    {

        private IProductService _productService;
        private ICategoryService _categoryService;
        private NinjectModule _module;

        public Product Product1 { get; }

        public UpdateProducts(NinjectModule module, Product product)
        {
            _module = module;
            Product1 = product;
            _productService = Instancefactory.GetInstance<IProductService>(module);
            _categoryService = Instancefactory.GetInstance<ICategoryService>(module);
            InitializeComponent();
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadAddCategories();
            LoadUpdateCategories();
            LoadSearchCategories();
        }

        private void LoadAddCategories()
        {
            cbxAdd.DataSource = _categoryService.GetAll();
            cbxAdd.DisplayMember = "CategoryName";
            cbxAdd.ValueMember = "Id";
        }

        private void LoadUpdateCategories()
        {
            
            cbxUpdate.DataSource = _categoryService.GetAll();
            cbxUpdate.DisplayMember = "CategoryName";
            cbxUpdate.ValueMember = "Id";
        }

        private void LoadSearchCategories()
        {
            var categories = _categoryService.GetAll();
            categories.Insert(0, new Category()
            {
                CategoryName = "All Products",
                Id = 0
            });
            cbxSearchByCategory.DataSource = categories;
            cbxSearchByCategory.DisplayMember = "CategoryName";
            cbxSearchByCategory.ValueMember = "Id";
        }


        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                var product1 = new Product()
                {
                    CategoryId = Convert.ToInt32(cbxAdd.SelectedValue),
                    ProductName = tbxAddName.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                    StockAmount = Convert.ToInt16(tbxAddUnitinstock.Text)
                };
                _productService.Add(product1);
                LoadProducts();
                MessageBox.Show(@"Mehsul elave olundu!");
            });


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                var row = dgwProducts.CurrentRow;
                if (row != null)
                {
                    var product1 = new Product()
                    {
                        Id = Convert.ToInt32(row.Cells[0].Value),
                        CategoryId = Convert.ToInt32(cbxUpdate.SelectedValue),
                        ProductName = tbxNameUpdate.Text,
                        UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                        StockAmount = Convert.ToInt16(tbxUnitinstockUpdate.Text)
                    };
                    _productService.Update(product1);
                }

                LoadProducts();
                MessageBox.Show(@"Mehsul yenilendi!");

            });
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;
            if (row == null) return;
            cbxUpdate.SelectedValue = row.Cells[1].Value;
            tbxNameUpdate.Text = row.Cells[2].Value.ToString();
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxUnitinstockUpdate.Text = row.Cells[4].Value.ToString();


        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchByName.Text != "")
            {
                dgwProducts.DataSource = _productService.GetByName(tbxSearchByName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

     

        private void cbxSearchByCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbxSearchByCategory.SelectedValue) == 0)
                {
                    LoadProducts();
                }
                else
                {
                    int a = Convert.ToInt32(cbxSearchByCategory.SelectedValue);
                    dgwProducts.DataSource = _productService.GetByCategoryId(a);
                }

            }
            catch
            {
                // ignored
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                var row = dgwProducts.CurrentRow;
                if (row != null)
                {
                    var product1 = new Product()
                    {
                        Id = Convert.ToInt32(row.Cells[0].Value),

                    };
                    _productService.Delete(product1);
                }

                LoadProducts();
                MessageBox.Show(@"Mehsul silindi!");
            });
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenu = new MainMenu(_module);
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
