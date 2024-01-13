<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="facultyLogin.aspx.cs" Inherits="CollegeProjectManagementSystem.facultyLogin" %>
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
                                    <h3 class="h3">Faculty Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <div class="form-group">
                                    <label> Faculty Id</label>
                                    <asp:TextBox class="form-control" placeholder="Faculty Id" ID="facultyId" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <div class="form-group">
                                    <label>Password</label>
                                    <asp:TextBox class="form-control" placeholder="Password" ID="password" TextMode="Password" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <center>
                                    <div class="form-group">
                                        <asp:Button Style="width: 100%;" CssClass="btn btn-success btn-lg" ID="facultyLoginBtn" runat="server" Text="Login" OnClick="registrarLoginBtn_Click"  />
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
