using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUltimateSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchResultsGridViews();
        }

        private void PopupateSearchResultsGridViews()
        {

            string searchText = txtSearchText.Text.ToLower();
            var authorList = new List<Authors>();
            var titleList = new List<Titles>();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
               authorList = CRUD.FindAuthor(searchText);
               titleList = CRUD.FindTitle(searchText);
            }

            authorsResultGridView.DataSource = authorList;
            authorsResultGridView.DataBind();
            titlesResultGridView.DataSource = titleList;
            titlesResultGridView.DataBind();

            //ctx.Authors.Load();
            //ctx.Titles.Load();

            //authorsResultGridView.DataSource = authorsQuery;
            //authorsResultGridView.DataBind();

            //titlesResultGridView.DataSource = titlesQuery;
            //titlesResultGridView.DataBind();

        }
    }
}