<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default"%> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ProductCLient</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
 Access our WebService Here.  

 <asp:HyperLink ID="HyperLinkProductService" runat ="server" NavigateUrl="~/Default.aspx.cs"> Print Me. </asp:HyperLink>
    </div>
    </form>
</body>
</html>
