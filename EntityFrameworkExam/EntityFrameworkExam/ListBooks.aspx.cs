using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityFrameworkExam
{
    public partial class ListBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDropDownMenu();
            }

        }

        protected void authorsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopupateBooksGridView();
        }

        private void PopupateBooksGridView()
        {
            int selectedAutorID = int.Parse(authorsDropDownList.SelectedValue);
            List<Titles> titleList = CRUD.GetAuthorsTitles(selectedAutorID);

            titlesGridView.DataSource = titleList;
            titlesGridView.DataBind();

                //titlesGridView.DataSource = titlesQuery;
                //titlesGridView.DataBind();

        }


        private void LoadDropDownMenu()
        {
            List<Authors> authorList = CRUD.GetAuthors();
            foreach (var item in authorList)
            {
                ListItem listItem = new ListItem();
                listItem.Text = item.FirstName + " " + item.LastName;
                listItem.Value = item.AuthorID.ToString();
                authorsDropDownList.Items.Add(listItem);
            }

                //Todo: Get all authors and bind them to the dropdown menu

                //authorsDropDownList.DataValueField = "AuthorID";
                //authorsDropDownList.DataTextField = "Name";
                //authorsDropDownList.DataSource = authorsQuery;
                //authorsDropDownList.DataBind();
            
        }
    }
}