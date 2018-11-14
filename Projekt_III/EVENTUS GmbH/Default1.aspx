<%@ Page Language="VB" %>

<!DOCTYPE html>
<script runat="server">


</script>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">   
        <p>
            <asp:TextBox ID="TextBox1" runat="server">Hallo</asp:TextBox>
        </p>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="XmlDataSource1">
        </asp:GridView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/XMLFile1.xml"></asp:XmlDataSource>
    </form>
    </body>
</html>
