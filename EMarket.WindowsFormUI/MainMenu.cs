using EMarket.Business.Abstract;
using System;
using System.Globalization;
using System.Windows.Forms;
using Coree.Business.DependencyResolvers.Ninject;
using EMarket.Entity.Concrete;
using EMarket.Entity.Domain_Model;
using EMarket.WindowsFormUI.Helper;
using Ninject.Modules;

namespace EMarket.WindowsFormUI
{
    public partial class MainMenu : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ICartService _cartService;
        private Product _product;
        private Product _cartProduct;
        private readonly Cart _cart;
        private NinjectModule _module;
        public MainMenu( NinjectModule module)
        {
            _module = module;
            _productService = Instancefactory.GetInstance<IProductService>(_module);
            _cartService = Instancefactory.GetInstance<ICartService>(_module); 
            _categoryService = Instancefactory.GetInstance<ICategoryService>(_module); 
            InitializeComponent();
            _cart=new Cart();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = _categoryService.GetAll();
            categories.Insert(0,new Category()
            {
                CategoryName = "All Products",Id=0
            });
            cbxSearchByCategory.DataSource = categories;
            cbxSearchByCategory.DisplayMember = "CategoryName";
            cbxSearchByCategory.ValueMember = "Id";
        }
        private void LoadProducts()
        {
            dgwBuyProducts.DataSource = _productService.GetAll();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            short quantity = Convert.ToInt16(nudProductCount.Value);
            if (_product != null)
            {
                ErrorHandlingHelper.ErrorHandler(()=> _cartService.AddToCart(quantity,_product, _cart));
                
                LoadCart();
                LoadTotalPrice();
        }
            else
            {
                MessageBox.Show(@"Please, select the product");
            }
            
        }

        private void dgwBuyProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwBuyProducts.CurrentRow;
            if (row != null)
                _product = new Product()
                {
                    Id = Convert.ToInt32(row.Cells[0].Value),
                    CategoryId = Convert.ToInt32(row.Cells[1].Value),
                    ProductName = row.Cells[2].Value.ToString(),
                    UnitPrice = Convert.ToDecimal(row.Cells[3].Value),
                    StockAmount = Convert.ToInt16(row.Cells[4].Value)
                };
        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {
            string name = tbxSearchByName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                dgwBuyProducts.DataSource = _productService.GetByName(name);
            }
            else
            {
                LoadProducts();
            }
            
        }

        private void cbxSearchByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                var categoryId = Convert.ToInt32(cbxSearchByCategory.SelectedValue);
                if (categoryId== 0)
                {
                    LoadProducts();
                }
                else
                {
                    dgwBuyProducts.DataSource = _productService.GetByCategoryId(categoryId);
                }
            }
            catch
            {
                // ignored
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (_cartProduct !=null)
            {
                _cartService.DeleteFromCart(_cartProduct, _cart);
                LoadCart();
                LoadTotalPrice();
            }
            
        }

        private void LoadTotalPrice()
        {
            lbl2.Text = _cart.TotalPrice.ToString(CultureInfo.CurrentCulture);
        }

        private void LoadCart()
        {
            dgwCart.DataSource = CartHelper.Converter(_cart);
        }

        private void dgwCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwCart.CurrentRow != null)
                _cartProduct = new Product()
                {
                    Id = Convert.ToInt32(dgwCart.CurrentRow.Cells[0].Value)
                };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to clear?", "", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                _cartService.Clear(_cart);
                LoadCart();
                LoadTotalPrice();
            }
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            if (_cartProduct != null)
            {
                _cartService.DeleteOne(_product, _cart);
                LoadCart();
                LoadTotalPrice();
            }
            else
            {
                MessageBox.Show(@"Please select the product and then delete one!");
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            _cartService.Sell(_cart);
            _cartService.Clear(_cart);
            LoadProducts();
            LoadCart();
            LoadTotalPrice();
            MessageBox.Show(@"Thanks you for choosing us!");
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var updateProducts = new UpdateProducts(_module,_product);
            updateProducts.ShowDialog();
            this.Close();
        }
       
    }
}
