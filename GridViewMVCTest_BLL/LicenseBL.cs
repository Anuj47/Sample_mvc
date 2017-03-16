using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Web.Mvc;
using GridViewMVCTest_BO;

namespace GridViewMVCTest_BLL
{
    public class LicenseBL
    {
        private static List<LicenseObject> dataList = null;

        public IEnumerable<LicenseObject> GetLicenses()
        {
            if (dataList == null)
            {
                dataList = new List<LicenseObject>();

                dataList.Add(new LicenseObject(1, "1111", "1"));
                dataList.Add(new LicenseObject(2, "1112", "2"));
                dataList.Add(new LicenseObject(3, "1113", "3"));
                dataList.Add(new LicenseObject(4, "1114", "4"));
                dataList.Add(new LicenseObject(5, "1115", "5"));
            }

            // Return the results
            return dataList;
        }

        public IEnumerable<LicenseObject> GetLicensesByRange(int numberOfRows, int startRow, ReadOnlyCollection<GridViewColumnState> sortedColumns)
        {
            // This isn't correct code but should allow the grid to function
            if (dataList == null)
            {
                dataList = new List<LicenseObject>();

                dataList.Add(new LicenseObject(1, "1111", "1"));
                dataList.Add(new LicenseObject(2, "1112", "2"));
                dataList.Add(new LicenseObject(3, "1113", "3"));
                dataList.Add(new LicenseObject(4, "1114", "4"));
                dataList.Add(new LicenseObject(5, "1115", "5"));
            }

            // Return the results
            return dataList;
        }

        public int GetLicenseCount(string filterExpression)
        {
            return 5;
        }
    }
}
