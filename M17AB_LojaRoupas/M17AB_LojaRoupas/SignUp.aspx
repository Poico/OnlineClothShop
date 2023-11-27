<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="M17AB_LojaRoupas.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="w-100 px-4 py-5 gradient-custom" style="border-radius: .5rem .5rem 0 0;">
      <div class="row d-flex justify-content-center">
        <div class="col-12 col-md-8 col-lg-6 col-xl-6">
          <div class="card bg-dark text-white" style="border-radius: 1rem;">
            <div class="card-body p-5 text-center">

              <div class="mb-md-5 mt-md-4 pb-5">

                <h2 class="fw-bold mb-2 text-uppercase">Sign Up </h2>
                <asp:Label class="text-white-50 mb-5" runat="server" id="labelTopo">Porfavor escreva o seu email, password!</asp:Label>

                <div class="form-outline form-white mb-4">
                  <input type="email" id="typeEmailX" class="form-control form-control-lg" runat="server">
                  <asp:Label class="form-label" for="typeEmailX" style="margin-left: 0px;" id="lbl_Email" runat="server">Email</asp:Label>
                <div class="form-notch"><div class="form-notch-leading" style="width: 9px;"></div><div class="form-notch-middle" style="width: 40px;"></div><div class="form-notch-trailing"></div></div></div>

                <div class="form-outline form-white mb-4">
                  <input type="password" id="typePasswordX" class="form-control form-control-lg" runat="server">
                  <asp:Label class="form-label" for="typePasswordX" style="margin-left: 0px;" id="lbl_Password" runat="server">Password</asp:Label>
                <div class="form-notch"><div class="form-notch-leading" style="width: 9px;"></div><div class="form-notch-middle" style="width: 64px;"></div><div class="form-notch-trailing"></div></div></div>

                  <div class="form-outline form-white mb-4">
                  <input type="password" id="Password2" class="form-control form-control-lg" runat="server">
                  <asp:Label class="form-label" for="typePasswordX2" style="margin-left: 0px;" id="Label2" runat="server">Confirme Password</asp:Label>
                <div class="form-notch"><div class="form-notch-leading" style="width: 9px;"></div><div class="form-notch-middle" style="width: 64px;"></div><div class="form-notch-trailing"></div></div></div>

                  <div class="form-outline form-white mb-4">
                  <input type="text" id="Username1" class="form-control form-control-lg" runat="server">
                  <asp:Label class="form-label" for="typeUsernameX" style="margin-left: 0px;" id="Label1" runat="server">Username</asp:Label>
                <div class="form-notch"><div class="form-notch-leading" style="width: 9px;"></div><div class="form-notch-middle" style="width: 64px;"></div><div class="form-notch-trailing"></div></div></div>

                <button class="btn btn-outline-light btn-lg px-5" type="submit" runat="server" id="SignUpButton" onserverclick="SignUpButton_ServerClick">Sign Up</button>

                <div class="d-flex justify-content-center text-center mt-4 pt-1">
                  <a href="#!" class="text-white"><i class="fab fa-facebook-f fa-lg"></i></a>
                  <a href="#!" class="text-white"><i class="fab fa-twitter fa-lg mx-4 px-2"></i></a>
                  <a href="#!" class="text-white"><i class="fab fa-google fa-lg"></i></a>
                </div>

              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
</asp:Content>
