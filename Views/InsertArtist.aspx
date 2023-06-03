<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="AOL_Code_1.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Artist</title>
</head>
<body>
    <form id="form1" runat="server">
     <h1>Insert Artist</h1>
        <br /> 

        <asp:Label ID="Label1" runat="server" Text="Insert Artist Name"></asp:Label>
        <br />
        <asp:TextBox ID="ArtistNameTxt" runat="server"></asp:TextBox>
        <br />
        <%--<asp:RequiredFieldValidator ID="RequiedFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="ArtistNameTxt"  ErrorMessage="Artist's Name must be filled and unique"></asp:RequiredFieldValidator>--%>
        <asp:Label ID="ArtistNameLbl" runat="server" Text=""  ForeColor="Red"  ></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Insert Artist Image"></asp:Label>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ControlToValidate="ArtistImage"  ErrorMessage="Must be choose and file size must be lower than 2MB "></asp:RequiredFieldValidator>--%>
        <asp:Label ID="ArtistImageLbl" runat="server" Text=""   ForeColor="Red" ></asp:Label>   

        <br />
        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
        <br />
    </form>
</body>
</html>
