<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Lab_1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div>
        <asp:Image ID="logo" runat="server" AlternateText="Лого на ФИНКИ" ImageUrl="https://www.finki.ukim.mk/sites/default/files/logo_10.png" Width="292px" />
    </div>

    <div style="margin-left: 10px;">
        <asp:Label ID="lblProfessor" runat="server" Text="вонр. проф. д-р Весна Димитрова"></asp:Label>
    </div>

    <div style="margin-bottom: 10px; margin-left: 20px; margin-top: 15px">
        <asp:ListBox ID="listSubjects" runat="server" OnSelectedIndexChanged="listSubjects_SelectedIndexChanged"></asp:ListBox>
        <asp:ListBox ID="listCredits" runat="server"></asp:ListBox>
    </div>

    <div style="margin-bottom: 10px; margin-left: 80px;">
        <asp:Button ID="btnVote" runat="server" Text="Гласај" OnClick="btnVote_Click" />
    </div>

    <div style="width: 260px; margin-bottom: 40px; margin-top: 40px;">
        <hr />
    </div>

    <div style="width: 260px; margin-left: 90px;">
        <asp:Label ID="lblAddSubject" runat="server" Text="Предмет:"></asp:Label>
    </div>

    <div class="text-center" style="width: 250px;  margin-bottom: 20px;">
        <asp:TextBox ID="addSubject" runat="server"></asp:TextBox>
    </div>

    <div style="width: 260px; margin-left: 90px;">
        <asp:Label ID="lblAddCredit" runat="server" Text="Кредити:"></asp:Label>
    </div>

    <div class="text-center" style="width: 250px; margin-bottom: 20px;">
        <asp:TextBox ID="addCredit" runat="server" OnTextChanged="addCredit_TextChanged"></asp:TextBox>
    </div>

    <div style="margin-left: 45px; margin-bottom: 10px;">
        <asp:Button ID="btnAddSubject" runat="server" Text="Додади" OnClick="btnAddSubject_Click" />
         <asp:Button ID="Button1" runat="server" Text="Избриши" OnClick="btnRemoveSubject_Click" />
    </div>
</asp:Content>
