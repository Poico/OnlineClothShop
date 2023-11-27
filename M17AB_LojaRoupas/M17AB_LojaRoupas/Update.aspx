<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="M17AB_LojaRoupas.WebForm9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container p-5">

        <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Pesquisar</label>
            <input class="form-control" id="Text1" runat="server">
        </div>
        <button type="button" class="btn btn-secondary btn-lg" runat="server" onserverclick="Unnamed_ServerClick">Search</button>



        <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Nome</label>
            <input class="form-control" id="Nome" runat="server">
        </div>
        <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Tipo</label>
            <input class="form-control" id="Tipo" runat="server">
        </div>
        <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Promoção</label>
            <input class="form-control" id="Promocao" runat="server">
        </div>
        <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Designer</label>
            <input class="form-control" id="Designer" runat="server">
        </div>
        <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Preço</label>
            <input class="form-control" id="Preco" runat="server">
        </div>
        <div class="mb-3">
            <label for="exampleFormControlTextarea1" class="form-label">Descrição</label>
            <textarea class="form-control" id="Descrisao" rows="3" runat="server"></textarea>
        </div>

        <button type="button" class="btn btn-secondary btn-lg" runat="server" onserverclick="Submit">Submit</button>
    </div>
</asp:Content>
