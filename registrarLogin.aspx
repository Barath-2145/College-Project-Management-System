<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registrarLogin.aspx.cs" Inherits="CollegeProjectManagementSystem.registrarLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container grid-padding">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150" src="images/adminuser.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3 class="h3">Academic Registrar Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <div class="form-group">
                                    <label>Academic Registrar ID<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RegistrarId" ErrorMessage="   *Id cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </label>
                                    &nbsp;<asp:TextBox class="form-control" placeholder="Registrar Id" ID="RegistrarId" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <div class="form-group">
                                    <label>Password<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="    *password cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </label>
                                    &nbsp;<asp:TextBox class="form-control" placeholder="Password" ID="password" TextMode="Password" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <center>
                                    <div class="form-group">
                                        <asp:Button Style="width: 100%;" CssClass="btn btn-success btn-lg" ID="registrarLoginBtn" runat="server" Text="Login" OnClick="registrarLoginBtn_Click"  />
                                    </div>
                                </center>
                            </div>
                        </div>
                    </div>
                </div>
                <a  style= "text-decoration:none;" href="homePage.aspx"><< Back to HomePage</a>
            </div>
        </div>
    </div>
</asp:Content>
