using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace CMS_SharepointDev.ViewVendorDetails
{
    [ToolboxItemAttribute(false)]
    public class ViewVendorDetails : WebPart
    {
        protected override void CreateChildControls()
        {
            _lblScriptHolder = new Label();
            _lblScriptHolder.ID = "lblScriptHolder";
            string _scriptData = "<table id=\"list47\"></table>";
            _scriptData += "<div id=\"plist47\"></div>";
            _scriptData += "<script type=\"text/javascript\">";
            _scriptData += "var mydata = [";
            _scriptData += "{ id: \"1\", invdate: \"2010-05-24\", name: \"Microsoft\", note: \"note\", amount: \"300000.00\", tax: \"10.00\", total: \"302978.00\" },";
            _scriptData += "{ id: \"2\", invdate: \"2010-05-25\", name: \"G4 Security Services\", note: \"note2\", amount: \"98000.00\", tax: \"20.00\", total: \"99890.00\" },";
            _scriptData += "{ id: \"3\", invdate: \"2007-09-01\", name: \"Vasini Food Services\", note: \"note3\", amount: \"700000.00\", tax: \"30.00\", total: \"708430.00\" },";
            _scriptData += "{ id: \"4\", invdate: \"2007-10-04\", name: \"Bakers Inn\", note: \"note\", amount: \"487000.00\", tax: \"10.00\", total: \"499210.00\" },";
            _scriptData += "{ id: \"5\", invdate: \"2007-10-05\", name: \"Computer World\", note: \"note2\", amount: \"120000.00\", tax: \"20.00\", total: \"132000.00\" },";
            _scriptData += "{ id: \"6\", invdate: \"2007-09-06\", name: \"Royal Furniture\", note: \"note3\", amount: \"70000.00\", tax: \"30.00\", total: \"70430.00\" },";
            _scriptData += "{ id: \"7\", invdate: \"2007-10-04\", name: \"Supreme Chairs\", note: \"note\", amount: \"830000.00\", tax: \"10.00\", total: \"842100.00\" },";
            _scriptData += "{ id: \"8\", invdate: \"2007-10-03\", name: \"Raja Computer Networks\", note: \"note2\", amount: \"300000.00\", tax: \"21.00\", total: \"320000.00\" },";
            _scriptData += "{ id: \"9\", invdate: \"2007-09-01\", name: \"Cisco\", note: \"note3\", amount: \"400000.00\", tax: \"30.00\", total: \"430000.00\" }	";
            _scriptData += "];";
            _scriptData += "jQuery(\"#list47\").jqGrid({";
            _scriptData += "data: mydata,";
            _scriptData += "datatype: \"local\",";
            _scriptData += "height: 'auto',";
            _scriptData += "rowNum: 5,";
            _scriptData += "colNames: ['Inv No', 'Date', 'Client', 'Amount', 'Tax', 'Total', 'Notes'],";
            _scriptData += "colModel: [";
            _scriptData += "{ name: 'id', index: 'id', width: 60, sorttype: \"int\" },";
            _scriptData += "{ name: 'invdate', index: 'invdate', width: 90, sorttype: \"date\" },";
            _scriptData += "{ name: 'name', index: 'name', width: 100, editable: true },";
            _scriptData += "{ name: 'amount', index: 'amount', width: 80, align: \"right\", sorttype: \"float\",  editable: true },";
            _scriptData += "{ name: 'tax', index: 'tax', width: 80, align: \"right\", sorttype: \"float\", editable: true },";
            _scriptData += "{ name: 'total', index: 'total', width: 80, align: \"right\", sorttype: \"float\" },";
            _scriptData += "{ name: 'note', index: 'note', width: 150, sortable: false }";
            _scriptData += "],";
            _scriptData += "pager: \"#plist47\",";
            _scriptData += "viewrecords: true,";
            _scriptData += "sortname: 'name',  ";
            _scriptData += "caption: \"Vendor Details\"";
            _scriptData += "});";
            _scriptData += "jQuery(\"#list47\").jqGrid('navGrid', '#plist47', { edit: false, add: false, del: false }, {}, {}, {}, { multipleSearch: true, multipleGroup: true });";
            _scriptData += "</script>";            
            _lblScriptHolder.Text = _scriptData;
            this.Controls.Add(_lblScriptHolder);
        }
        Label _lblScriptHolder = null;
    }
}
