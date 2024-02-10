using DependentDropdownPract.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage;

namespace DependentDropdownPract.Controllers
{
    public class DemoController : Controller
    {
        private readonly DataBaseContext _context;

        public DemoController(DataBaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categoryList = new();

            //getting data from db using efcore
            categoryList = (from category in _context.Category select category).ToList();

            //inserting select items in list
            categoryList.Insert(0, new Category { CategoryID = 0, CategoryName = "Select" });

            //assignign gthe categories to viewbag.listof categroy

            ViewBag.ListOfCategory = categoryList;
            return View();
        }

        public JsonResult GetSubCategory(int CategoryID)
        {
            List<SubCategory> subCategoryList = new();
            subCategoryList= (from SubCategory in _context.SubCategory where  SubCategory.CategoryID == CategoryID select SubCategory).ToList();

            subCategoryList.Insert(0, new SubCategory { SubCategoryID = 0, SubCategoryName = "Select" });

            return Json(new SelectList(subCategoryList, "SubCategoryID", "SubCategoryName"));
        }

        public JsonResult GetProducts(int  SubCategoryID)
        {
            List<MainProduct> productList = new List<MainProduct>();


            productList = (from product in _context.MainProduct where product.SubCategoryID == SubCategoryID select product).ToList();

            productList.Insert(0, new MainProduct { ProductID = 0, ProductName = "Select" });

            return Json(new SelectList(productList, "ProductID", "ProductName"));
        }


    }
}
