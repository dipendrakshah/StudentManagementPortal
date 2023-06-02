using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbFactory;

namespace StudentManagementPortal
{
    public partial class StudentRegion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAO.LoadList(ddlCountry, "tblCountryMaster", "CountryName", "CountryCode");
        }
    }
}