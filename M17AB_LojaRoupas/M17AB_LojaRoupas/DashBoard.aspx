<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="M17AB_LojaRoupas.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" id="container" runat="server"> 
        Clique aqui para mandar um email a todos os clientes com uma NewsLetter
        <button type="button" class="btn btn-dark" runat="server" onserverclick="Unnamed_ServerClick" id="envioEmail">Email</button>

    </div>
</asp:Content>
