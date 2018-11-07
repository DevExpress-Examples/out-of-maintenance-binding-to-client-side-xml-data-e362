<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="TreeList_Data_BindToClientSideXml_Default" %>
<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v13.1" Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dxwtl" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Binding to client-side XML data</title>
</head>
<body>
	<form id="form1" runat="server">
		<dxwtl:ASPxTreeList ID="ASPxTreeList1" runat="server" ClientInstanceName="tree" OnCustomCallback="ASPxTreeList1_CustomCallback" AutoGenerateColumns="False">
			<Columns>
				<dxwtl:TreeListDataColumn FieldName="Value" VisibleIndex="0" />
			</Columns>
		</dxwtl:ASPxTreeList>
		<br />
		Enter XML data:<br />
		<textarea id="xml" rows="10" cols="50">&lt;?xml version="1.0"?&gt;
&lt;root&gt;
	&lt;item Value="Parent1" /&gt;
	&lt;item Value="Parent2"&gt;
		&lt;item Value="Child1" /&gt;
		&lt;item Value="Child2" /&gt;
	&lt;/item&gt;
&lt;/root&gt;</textarea>
		<br />
		<input type="button" value="Bind" onclick="tree.PerformCustomCallback(document.getElementById('xml').value)" />
		<asp:XmlDataSource ID="XmlDataSource1" runat="server" XPath="/*/*" EnableViewState="False" EnableCaching="False"></asp:XmlDataSource>
	</form>
</body>
</html>
