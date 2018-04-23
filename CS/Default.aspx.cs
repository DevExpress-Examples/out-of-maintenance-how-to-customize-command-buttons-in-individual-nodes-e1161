using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace HideCommandButton {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(!IsPostBack && !IsCallback) {
                ASPxTreeList1.DataBind();
                ASPxTreeList1.ExpandAll();
            }
        }

        protected void ASPxTreeList1_HtmlCommandCellPrepared(object sender, DevExpress.Web.ASPxTreeList.TreeListHtmlCommandCellEventArgs e) {
            // disable editing of top level nodes
            if(e.Level == 1) {
                e.Cell.Controls[0].Visible = false; 
            }
        }
    }
}
