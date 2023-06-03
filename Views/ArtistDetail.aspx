<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="AOL_Code_1.Views.InsertArtist" EnableEventValidation="false"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Artist_Detail</title>
</head>
<body>
    <form id="form1" runat="server">
       <h1>Artist Detail</h1>
        <br />
        <%--artist Image, artist name, ALBUM DETAILS -> image, name, price, description--%>
                              <asp:Image ID="ArtistImage" ImageUrl="" runat="server" />
        <br />
                            <%--<img id="ArtistImg" src="../Assets/Artist/<%# Eval("ArtistImage") %>"  alt="...">
                            <br />--%>
                            <asp:Label ID="ArtistName" runat="server" Text='<%# Eval("ArtistName") %>'></asp:Label>
                            <br />

        <asp:Repeater ID="ArtistRepeater" runat="server">
                    <ItemTemplate>
                        <div >
                            
                         
                              <br />
                            <img id="AlbumImg" src="../Assets/Album/<%# Eval("AlbumImage") %>"  alt="...">
                            <br />
                            <asp:Label ID="AlbumName" runat="server" Text='<%# Eval("AlbumName") %>'></asp:Label>
                            <br />
                            <asp:Label ID="AlbumPrice" runat="server" Text='<%# Eval("AlbumPrice") %>'></asp:Label>
                            <br />
                            <asp:Label ID="AlbumDescription" runat="server" Text='<%# Eval("AlbumDescription") %>'></asp:Label>
                            <br />   


                             <asp:Button ID="Button1" runat="server" Text="Album Detail" OnClick="Button1_Click" CommandArgument='<%# Eval("AlbumID") %>'/>


                           
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
        


       
        

        
       
    </form>
</body>
</html>
