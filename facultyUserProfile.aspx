<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="facultyUserProfile.aspx.cs" Inherits="CollegeProjectManagementSystem.facultyUserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container ">
        <div class="row grid-padding ">
            <div class="col-md-12 ">
                <div class="card">
                    <div class="card-body form-group">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100" src="images/generaluser.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col">
                                <center>
                                    <h3 class="h3">Faculty Profile</h3>
                                    <span>Account Status - </span>
                                    <asp:Label class="badge text-bg-success" ID="Label1" runat="server" Text="Active"></asp:Label>
                                </center>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col-md ">
                                <label>First Name</label>
                                <asp:TextBox ID="facultyFirstName" class="form-control" placeholder="First Name" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>Last Name</label>
                                <asp:TextBox ID="facultyLastName" class="form-control" placeholder="Last Name"  runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                           
                            <div class="col-md-8">
                                <label>Department</label>
                                <asp:TextBox ID="department" class="form-control" placeholder="Department" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col-md">
                                <label>Conatct Number</label>
                                <asp:TextBox ID="mobile" class="form-control" placeholder="Contact Number" TextMode="Number" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>E-Mail </label>
                                <asp:TextBox ID="email" class="form-control" placeholder="E-Mail " TextMode="Email" runat="server" ReadOnly="true"></asp:TextBox>
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
                                    <label>Faculty ID</label>
                                    <asp:TextBox class="form-control" placeholder="User Id" ID="facultyId" runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>Old Password</label>
                                    <asp:TextBox class="form-control" placeholder="Password" ID="oldPassword" ReadOnly="true" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col">
                                <div class="form-group">
                                    <label>New Password</label>
                                    <asp:TextBox style="background-color:white;" class="form-control" placeholder="Password" ID="newPassword" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <center>
                                    <div class="form-group">
                                        <asp:Button  CssClass="btn btn-primary btn-lg" ID="updateBtn" runat="server" Text="Update" OnClick ="updateBtn_Click"/>
                                    </div>
                                </center>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
        </div>
    </div>
    <style>
        .form-control{
            background-color:#D6D4D3;
        }
    </style>
</asp:Content>
