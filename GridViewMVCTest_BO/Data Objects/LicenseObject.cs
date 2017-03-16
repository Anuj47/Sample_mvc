using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GridViewMVCTest_BO
{
    [Serializable]
    public class LicenseObject
    {
        // Constructors =======================================================
        public LicenseObject()
        {

        }

        public LicenseObject(string fileNumber, string legalLocation)
        {
	        FileNumber = fileNumber;
            LegalLocation = legalLocation;
        }

        public LicenseObject(int iD, string fileNumber, string legalLocation)
            : this(fileNumber, legalLocation)
        {
            id = iD;
        }

        // Properties =========================================================
        public int id { get; set; }

        [Required]
        public string FileNumber { get; set; }

        [Required]
        public string LegalLocation { get; set; }
    }
}
