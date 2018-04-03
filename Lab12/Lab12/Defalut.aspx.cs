using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab12
{
    public partial class Defalut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                lblError.Text = ("please enter valid search keyword!");

            }
            lblError.Text = String.Empty;

            var books = Books.GetBooks();

            var sortedbooks = from bookItem in books
                              where bookItem.Title.Contains("txtSearch.Text") 
                              orderby bookItem.Title
                              select bookItem;

            GridView1.DataSource = sortedbooks;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {

        }
    }
}