using System;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Web.ASPxClasses;

namespace HideCommandButton {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(!IsPostBack && !IsCallback) {
                ASPxTreeList1.DataBind();
                ASPxTreeList1.ExpandAll();
            }
        }

        protected void ASPxTreeList1_CommandColumnButtonInitialize(object sender, DevExpress.Web.ASPxTreeList.TreeListCommandColumnButtonEventArgs e) {
            TreeListNode node =ASPxTreeList1.FindNodeByKeyValue(e.NodeKey.ToString()); 
            if (node.Level == 1) {
                e.Visible = DefaultBoolean.False;
            }
        }
    }
}
