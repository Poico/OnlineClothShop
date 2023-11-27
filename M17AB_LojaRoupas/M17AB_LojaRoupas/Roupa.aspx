<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="Roupa.aspx.cs" Inherits="M17AB_LojaRoupas.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .carrinho {
            width: 30px;
            height: 30px;
            background-position: center;
            background: url('/Utils/Imagens/icons8-paid.png');
            margin: auto;
        }

        .favorito {
            width: 30px;
            height: 30px;
            background-position: center;
            background: url('/Utils/Imagens/icons8-heart.png');
            margin: auto;
        }

        .carrinho:hover {
            width: 30px;
            height: 30px;
            background-position: center;
            background: url('/Utils/Imagens/carrinho.gif');
            margin: auto;
        }

        .favorito:hover {
            width: 30px;
            height: 30px;
            background-position: center;
            background: url('/Utils/Imagens/coracao.gif');
            margin: auto;
        }
    </style>
    <div class="container p-4 d-grid gap-3">
        <asp:DataList ID="DataList1" runat="server" DataSourceID="Roupa" DataKeyField="IDModelo">
            <ItemTemplate>
                <image src="Imagens/Roupa/<%# Eval("IDModelo") %>.png" class="w-50 rounded float-start" />
                <asp:Label ID="NomeLabel" runat="server" Text='<%# Eval("Nome") %>' class="fs-1 ms-3" />
                <br />
                <asp:Label ID="TipoLabel" runat="server" Text='<%# Eval("Tipo") %>' class="font-weight-bold fs-5 ms-3" />
                <br />
                <asp:Label ID="PromocaoLabel" runat="server" Text='<%# Eval("Promocao") %>' class="ms-3" />
                <br />
                <asp:Label Text="Rating" runat="server" class="ms-3"></asp:Label>
                <asp:Label ID="RatingLabel" runat="server" Text='<%#  Convert.ToDouble(Eval("Rating"))%>' />
                <asp:Label Text="★" runat="server"></asp:Label>
                </br>
                <asp:Label ID="descricaoLabel" runat="server" Text='<%# Eval("descricao") %>' class="ms-3" />
                <br />
                <asp:Label ID="Label1" runat="server" Text='Designer' class="ms-3" />
                <asp:Label ID="DesignerLabel" runat="server" Text='<%# Eval("Designer") %>' />
                <br />
                <asp:Label ID="Label2" runat="server" Text='Preço:' class="ms-3" />
                <asp:Label ID="PrecoLabel" runat="server" Text='<%# Convert.ToDouble(Eval("Preco")) %>' />
                €
                <br />
                <button class="btn btn-primary" type="button" id="tamanhoS">S</button>
                <button class="btn btn-primary" type="button" id="tamanhoM">M</button>
                <button class="btn btn-primary" type="button" id="tamanhoL">L</button>
                <br />
                <% %>
                <button class="btn btn-primary" type="button" id="CorPreto">Preto</button>
                <button class="btn btn-primary" type="button" id="CorBranco">Branco</button>
                <button class="btn btn-primary" type="button" id="CorVerde">Verde</button>
                <br />
            </ItemTemplate>
        </asp:DataList>
        <!--Favoritos/Encomendar-->
        <% if (Session["user"] != null)
            {%>
        <ul>
            <li>
                <button runat="server" id="Favorito" onserverclick="Favorito_ServerClick">
                    <div class="favorito m-2" style="background-size: contain"></div>
                </button>
            </li>
            <li>
                <button runat="server" id="Carrinho" onserverclick="Carrinho_ServerClick">
                    <div class="carrinho m-2" style="background-size: contain"></div>
                </button>
            </li>
        </ul>
        <div class="dropdown">
            <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton1" data-bs-toggle="dropdown" aria-expanded="false">
                Rating
            </button>
            <ul class="dropdown-menu" aria-labelledby="dropdownMenuButton1">
                <li><a class="dropdown-item" runat="server" onserverclick="Unnamed_ServerClick1" id="Star1">★</a></li>
                <li><a class="dropdown-item" runat="server" onserverclick="Unnamed_ServerClick2" id="Star2">★★</a></li>
                <li><a class="dropdown-item" runat="server" onserverclick="Unnamed_ServerClick3" id="Star3">★★★</a></li>
                <li><a class="dropdown-item" runat="server" onserverclick="Unnamed_ServerClick4" id="Star4">★★★★</a></li>
                <li><a class="dropdown-item" runat="server" onserverclick="Unnamed_ServerClick5" id="Star5">★★★★★</a></li>
            </ul>
        </div>
        <%}%>

        <!--Comentarios-->
        <p class="fs-1">Comentários:</p>

        <% if (Session["user"] != null)
            {%>


        <div class="input-group mb-3">
            <input type="text" class="form-control" placeholder="Comentário" aria-label="Recipient's username" aria-describedby="button-addon2" id="comentario" runat="server">
            <button class="btn btn-outline-secondary" type="button" id="butaoComentario" runat="server" onserverclick="butaoComentario_ServerClick">Publicar</button>
        </div>
        <%}%>
    </div>
    <div class="container">
        <asp:DataList ID="DataList2" runat="server" DataSourceID="Comentarios">
            <ItemTemplate>
                Texto:
                <asp:Label ID="DescrisaoLabel" runat="server" Text='<%# Eval("Descrisao") %>' />
                <br />
                Publicado:
                <asp:Label ID="DataLabel" runat="server" Text='<%# Convert.ToDateTime(Eval("Data")).ToShortDateString() %>' />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </div>
    <asp:SqlDataSource ID="Comentarios" runat="server" ConnectionString="<%$ ConnectionStrings:BD_LojaRoupaConnectionString %>" SelectCommand="SELECT [Descrisao], [Data] FROM [Comentarios] WHERE ([IDModelo] = @IDModelo)">

        <SelectParameters>
            <asp:QueryStringParameter Name="IDModelo" QueryStringField="Roupa" Type="Int32" />
        </SelectParameters>

    </asp:SqlDataSource>
    <asp:SqlDataSource ID="Roupa2" runat="server"></asp:SqlDataSource>
    <asp:SqlDataSource ID="Roupa" runat="server" ConnectionString="<%$ ConnectionStrings:BD_LojaRoupaConnectionString %>" SelectCommand="SELECT * FROM [Modelo] WHERE ([IDModelo] = @IDModelo)">
        <SelectParameters>
            <asp:QueryStringParameter Name="IDModelo" QueryStringField="Roupa" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>


</asp:Content>
