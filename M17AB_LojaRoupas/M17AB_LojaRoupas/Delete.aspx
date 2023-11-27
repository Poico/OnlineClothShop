<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="M17AB_LojaRoupas.WebForm10" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mb-3">
        <label for="exampleFormControlInput1" class="form-label">Deletar</label>
        <input class="form-control" id="Text1" runat="server">
    </div>
    <button type="button" class="btn btn-secondary btn-lg" runat="server" onserverclick="Unnamed_ServerClick">Deletar</button>
</asp:Content>
