<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Macchine._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
       <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
            <asp:ListItem id="Panda" Value="Panda" Text="Panda" runat="server"/>
           <asp:ListItem id="Golf" Value="Golf" Text="Golf" runat="server"/>
           <asp:ListItem id="ClasseA" Value="ClasseA" Text="ClasseA" runat="server"/>
  </asp:DropDownList>
    </main>

</asp:Content>
