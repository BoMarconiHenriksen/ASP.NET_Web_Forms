using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPWebForm
{
  public partial class TimeSheetViewer : System.Web.UI.Page
  {
    // Used to switch the master from MasterPageExample.Master to Print.Master
    void Page_PreInit(object sender, EventArgs e)
    {
      if (Request.QueryString["Print"] != null)
      {
        MasterPageFile = "~/Print.Master";
      }
      
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
  }
}