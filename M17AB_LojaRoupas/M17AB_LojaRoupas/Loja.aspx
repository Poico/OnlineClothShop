<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="Loja.aspx.cs" Inherits="M17AB_LojaRoupas.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container p-3">
        <asp:DataList ID="DataList1" runat="server" DataSourceID="Roupa" DataKeyField="IDModelo">
            <ItemTemplate>
                <div class="card" style="width: 18rem;">
                    <img src="Imagens/Roupa/<%# Eval("IDModelo") %>.png" class="card-img-top" style="width: 286px; height: 286px;">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Nome") %></h5>
                        <p class="card-text">
                                    Rating: <%#  Eval("Rating")%>★
                        </p>
                        <p class="card-text">Preço: <%# Math.Round(Convert.ToDouble(Eval("Preco")),2) %> €</p>
                        <p class="card-text"><%# Eval("descricao") %></p>
                        <a href="Roupa.aspx?Roupa=<%# Eval("IDModelo") %>" class="btn btn-primary">Saber Mais</a>
                    </div>
                </div>
            </ItemTemplate>

        </asp:DataList>
    </div>
    <asp:SqlDataSource ID="Roupa" runat="server" ConnectionString="<%$ ConnectionStrings:BD_LojaRoupaConnectionString %>" SelectCommand="SELECT [IDModelo], [Nome], [Rating], [descricao], [Preco] FROM [Modelo] WHERE ([Tipo] = @Tipo)">
        <SelectParameters>
            <asp:QueryStringParameter Name="Tipo" QueryStringField="Modelo" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
