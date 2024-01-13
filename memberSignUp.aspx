<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="memberSignUp.aspx.cs" Inherits="CollegeProjectManagementSystem.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row grid-padding">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150" src="images/generaluser.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col">
                                <center>
                                    <h3 class="h3">User Registeration</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col-md">
                                <label>Full Name</label>
                                <asp:TextBox ID="TextBox1" class="form-control" placeholder=" Full Name" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>Date Of Birth</label>
                                <asp:TextBox ID="TextBox2" class="form-control" placeholder="DOB" TextMode="Date" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col-md">
                                <label>Conatct Number</label>
                                <asp:TextBox ID="TextBox3" class="form-control" placeholder="Contact Number" TextMode="Number" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>E-Mail ID</label>
                                <asp:TextBox ID="TextBox4" class="form-control" placeholder="E-Mail ID" TextMode="Email" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col-md">
                                <label>State </label>
                                <asp:DropDownList ID="DropDownList1" class="form-control" runat="server">
                                    <asp:ListItem Text="--Select--"></asp:ListItem>
                                    <asp:ListItem Text="Pondicherry" Value="Pondicherry"></asp:ListItem>
                                    <asp:ListItem Text="TamilNadu" Value="TamilNadu"></asp:ListItem>
                                    <asp:ListItem Text="Karnataka" Value="Karnataka"></asp:ListItem>
                                    <asp:ListItem Text="Kerala" Value="Kerala"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md">
                                <label>City </label>
                                <asp:TextBox ID="TextBox6" class="form-control" placeholder="City" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>PinCode </label>
                                <asp:TextBox ID="TextBox7" class="form-control" placeholder="pin Code " TextMode="Number" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col-md">
                                <label> Residential Address</label>
                                <asp:TextBox ID="TextBox5" class="form-control" placeholder="Residential Address" TextMode="MultiLine" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row text-center">
                            <div class="col-md">
                                <span class="badge text-bg-info">Login Credentials
                                </span>
                            </div>
                        </div>
                         <div class="row grid-padding">
                              <div class="col">
                                <div class="form-group">
                                    <label>User ID</label>
                                    <asp:TextBox class="form-control" placeholder="User Id" ID="TextBox9" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>Password</label>
                                    <asp:TextBox class="form-control" placeholder="Password" ID="TextBox8" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                         <div class="row grid-padding">
                            <div class="col">
                                <center>
                                    <div class="form-group">
                                        <asp:Button Style="width: 100%;" CssClass="btn btn-success btn-lg" ID="Button1" runat="server" Text="SignUp" />
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
