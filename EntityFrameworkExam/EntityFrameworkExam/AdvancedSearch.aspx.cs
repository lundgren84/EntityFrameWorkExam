using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class AdvancedSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUltimateSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchAuthorsResultGridView();
        }

        protected void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchAuthorsResultGridView();
        }

        protected void btnTitleSearch_Click(object sender, EventArgs e)
        {
            PopupateSearchTitlesResultGridView();
        }

        private void PopupateSearchAuthorsResultGridView()
        {
            List<Authors> authorList = new List<Authors>();
            if (!string.IsNullOrWhiteSpace(txtAuthorSearchText.Text))
            {
                 authorList = CRUD.FindAuthor(txtAuthorSearchText.Text.ToLower());           
            }          
            authorsResultGridView.DataSource = authorList;
            authorsResultGridView.DataBind();

            //authorsResultGridView.DataSource = authorsQuery;
            // authorsResultGridView.DataBind();

        }

        private void PopupateSearchTitlesResultGridView()
        {     
            var TitleList = new List<Titles>();
            if (!string.IsNullOrWhiteSpace(txtTitleSearchText.Text))
            {
                 TitleList = CRUD.FindTitle(txtTitleSearchText.Text.ToLower());            
            }
            titlesResultGridView.DataSource = TitleList;
            titlesResultGridView.DataBind();

            //titlesResultGridView.DataSource = titlesQuery;
            //titlesResultGridView.DataBind();

        }
    }
}