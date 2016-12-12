using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkExam
{
    public partial class AddStores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAddStore_Click(object sender, EventArgs e)
        {
            AddStoreToDb();

            txtStoreLocation.Text = "";
            txtStoreTel.Text = "";
            chkPreferred.Checked = false;
        }

        private void AddStoreToDb()
        {
            //Todo: Add Store to the database through Entity framework
            Stores store = new Stores();
            store.StoreLocation = txtStoreLocation.Text;
            store.StoreTel = txtStoreTel.Text;
            store.PreferredSupplier = (chkPreferred.Checked);
            CRUD.AddNewStore(store);
        }
    }
}