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

public partial class TreeList_Data_BindToClientSideXml_Default : System.Web.UI.Page {
	const string Key = "SomeUniqueString";

	protected override void OnLoad(EventArgs e) {
		base.OnLoad(e);
		Bind();
	}

	protected void ASPxTreeList1_CustomCallback(object sender, DevExpress.Web.ASPxTreeList.TreeListCustomCallbackEventArgs e) {
		Session[Key] = e.Argument;
		Bind();		
	}

	void Bind() {
		if(Session[Key] != null) {
			try {
				XmlDataSource1.Data = Session[Key].ToString();
				ASPxTreeList1.DataSourceID = XmlDataSource1.ID;
				ASPxTreeList1.DataBind();
			} catch {
				Session[Key] = null;
				throw;
			}
		}
	}

}
