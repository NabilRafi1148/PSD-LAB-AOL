<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateArtist.aspx.cs" Inherits="AOL_Code_1.Views.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Artist</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Update Artist</h1>

        <br /> 
       <%-- BAGIAN CURRENT DATA--%>
         
                        <div >
                            <asp:Label ID="ArtistName" runat="server" Text='<%# Eval("ArtistName") %>'></asp:Label>
                            <br />
                            <asp:Image ID="ArtistImg" runat="server" />
                            <br />

                           
                        </div>
                   

        <br />

        <%--BAGIAN INSERT--%>
        <asp:Label ID="Label1" runat="server" Text="Insert Artist Name"></asp:Label>
        <br />
        <asp:TextBox ID="ArtistNameTxt" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="ArtistNameLbl" runat="server" Text=""  ForeColor="Red"  ></asp:Label>
        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="ArtistNameTxt"  ErrorMessage="Artist's Name must be filled and unique"></asp:RequiredFieldValidator>--%>

        <br />
        <asp:Label ID="Label2" runat="server" Text="Insert Artist Image"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Label ID="ArtistImageLbl" runat="server" Text=""   ForeColor="Red" ></asp:Label>
       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ControlToValidate="ArtistImage"  ErrorMessage="Must be choose and file size must be lower than 2MB  "></asp:RequiredFieldValidator>--%>

        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

    </form>
</body>
</html>
