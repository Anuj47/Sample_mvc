using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using GridViewMVCTest_BO;
using GridViewMVCTest_BLL;

namespace GridViewMVCTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //Standard grid callback requests 
        public ActionResult LicensesGridPartial()
        {
            var viewModel = GridViewExtension.GetViewModel("LicenseGrid");
            if (viewModel == null)
            {
                //Initialize the grid state on the first load 
                viewModel = CreateGridViewModel();
            }

            return MyCustomBindingCore(viewModel);
        }

        PartialViewResult MyCustomBindingCore(GridViewModel gridViewModel) {
            //Delegate implementation of the functions that are always required for custom binding 
            gridViewModel.ProcessCustomBinding(
                MyBindingHandlers.MyGetDataRowCount, //Function to return the total number of data rows in a model 
                MyBindingHandlers.MyGetData //Function to return data rows requested by the grid 
            );
            return PartialView("LicensesGridPartial", gridViewModel);
        }

        static GridViewModel CreateGridViewModel()
        {
            var viewModel = new GridViewModel();
            viewModel.KeyFieldName = "id";
            viewModel.Columns.Add("FileNumber");
            viewModel.Columns.Add("LegalLocation");
            return viewModel;
        }
    }

    public static class MyBindingHandlers {
        public static void MyGetDataRowCount(GridViewCustomBindingGetDataRowCountArgs e) 
        {
            // Get the bl
            LicenseBL bl = new LicenseBL();

            e.DataRowCount = bl.GetLicenseCount(e.FilterExpression);
        }

        public static void MyGetData(GridViewCustomBindingGetDataArgs e) 
        {
            // Get the bl
            LicenseBL bl = new LicenseBL();

            e.Data = bl.GetLicensesByRange(e.DataRowCount, e.StartDataRowIndex, e.State.SortedColumns);
        }
    }
}
