<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="CollegeProjectManagementSystem.WebForm4" %>
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
                                    <h3 class="h3">Admin Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <div class="form-group">
                                    <label>Admin ID </label>
                                    &nbsp;<label><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="adminID" ErrorMessage="    *Id cannot be empty" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                    </label>
                                    <asp:TextBox class="form-control" placeholder="Admin Id" ID="adminID" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <div class="form-group">
                                    <label>Password<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="   *Password cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </label>
&nbsp;<asp:TextBox class="form-control" placeholder="Password" ID="password" TextMode="Password" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <center>
                                    <div class="form-group">
                                        <asp:Button Style="width: 100%;" CssClass="btn btn-success btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
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
