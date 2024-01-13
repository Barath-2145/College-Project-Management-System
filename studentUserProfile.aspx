<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="studentUserProfile.aspx.cs" Inherits="CollegeProjectManagementSystem.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">

         // let table = new DataTable('.table');
         $(document).ready(function () {
             $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
         })

     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container ">
        <div class="row grid-padding " id="myProfile">
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
                                    <h3 class="h3">Student Profile</h3>
                                    <span>Account Status - </span>
                                    <asp:Label class="badge text-bg-success" ID="Label1" runat="server" Text="Active"></asp:Label>
                                </center>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col-md ">
                                <label>First Name</label>
                                <asp:TextBox ID="studentFirstName" class="form-control" placeholder="First Name" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>Last Name</label>
                                <asp:TextBox ID="studentLastName" class="form-control" placeholder="last Name" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>Year</label>
                                <asp:TextBox ID="year" class="form-control" placeholder="Year" TextMode="Number" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>

                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col-md">
                                <label>Batch</label>
                                <asp:TextBox ID="batch" class="form-control" placeholder="Batch" TextMode="Number" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>Department</label>
                                <asp:TextBox ID="department" class="form-control" placeholder="Department" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">
                            <div class="col-md">
                                <label>Mobile Number</label>
                                <asp:TextBox ID="mobile" class="form-control" placeholder="Contact Number" TextMode="Number" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="col-md">
                                <label>E-Mail ID</label>
                                <asp:TextBox ID="email" class="form-control" placeholder="E-Mail ID" TextMode="Email" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row grid-bottom-padding">

                            <div class="col-md-6">
                                <label>Date of Birth </label>
                                <asp:TextBox ID="dob" class="form-control" placeholder="DOB" TextMode="Date" runat="server" ReadOnly="true"></asp:TextBox>
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
                                    <label>Student ID</label>
                                    <asp:TextBox class="form-control" placeholder="User Id" ID="studentId" runat="server" ReadOnly="True"></asp:TextBox>
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
                                    <asp:TextBox Style="background-color: white;" class="form-control" placeholder="Password" ID="newPassword" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row grid-padding">
                            <div class="col">
                                <center>
                                    <div class="form-group">
                                        <asp:Button CssClass="btn btn-primary btn-lg" ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
                                    </div>
                                </center>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card" id="viewRequest" style="display: none">
                    <div class="row d-flex justify-content-end m-2">
                        <button type="button" style="width: 20%;" class="btn btn-lg btn-secondary btn-block " id="requestBtn" onclick="hide()">My Requests</button>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3 class="h3">Batch Details</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md">
                                <asp:GridView runat="server" class="table table-striped table-bordered " ID="projectRequestGridView" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="project_id" HeaderText="project_id" SortExpression="project_id" />
                                        <asp:BoundField DataField="project_title" HeaderText="project_title" SortExpression="project_title" />
                                        <asp:BoundField DataField="technology" HeaderText="technology" SortExpression="technology" />
                                        <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
                                        <asp:BoundField DataField="batch" HeaderText="batch" SortExpression="batch" />
                                        <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                                        <asp:BoundField DataField="faculty_id" HeaderText="faculty_id" SortExpression="faculty_id" />
                                        <asp:BoundField DataField="subject" HeaderText="subject" SortExpression="subject" />

                                    </Columns>
                                </asp:GridView>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString6 %>"></asp:SqlDataSource>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <style>
        .form-control {
            background-color: #D6D4D3;
        }
    </style>
     <script type="text/javascript">
        function hide() {
            let myProfile = document.getElementById("addBatch")
            let viewRequest = document.getElementById("viewRequest")
            //let addBtn = document.getElementById("addBtn")
            //let viewBtn = document.getElementById("viewBtn")
            if (myProfile.style.display == "none") {
                viewRequest.style.display = "none"
                //viewBtn.style.display = "none"
                myProfile.style.display = "block"
                //addBtn.style.display = "block"

            }
            else {
                viewRequest.style.display = "block"
                // viewBtn.style.display = "block"
                myProfile.style.display = "none"
                //  addBtn.style.display = "none"
            }

        }

     </script>
</asp:Content>
