using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebIntelliTest.BusinessCode;

namespace WebIntelliTest
{
    public partial class _Default : Page
    {

        General objGeneral = new General();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_ServerClick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Val1.Value);
            int b = Convert.ToInt32(Val2.Value);
            int result = objGeneral.AddTwoPositiveNumber(a, b);
            Response.Write(result);
        }

        
    }
}