using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//reference our entity framework models
using comp2007_lesson5_mon.Models;
using System.Web.ModelBinding;

namespace comp2007_lesson5_mon
{
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //fill the grid
            if (!IsPostBack)
            {
                GetDepartments();
            }
        }

        protected void GetDepartments()
        {
            //connect using our connection string from web.config and EF context class
            using (var conn = new mondayEntities()) {

                //use link to query the Departments model
                var deps = from d in conn.Departments
                           select d;
             
                //bind the query result to the gridview
                grdDepartments.DataSource = deps.ToList();
                grdDepartments.DataBind();
            }
        }
    }
}