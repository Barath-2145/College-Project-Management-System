<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="facultyDetails.aspx.cs" Inherits="CollegeProjectManagementSystem.bookIssue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        // let table = new DataTable('.table');
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
        })

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center">
        <div class="container ">
            <div class="row">

                <div class="col-md">
                    <div class="card" id="addFaculty">
                        <div class="card-body">
                            <div class="row d-fles justify-content-end ml-2">
                                <!-- <asp:Button Style="width: 15%;" CssClass="btn btn-lg btn-secondary btn-block " ID="Button2" runat="server" Text="View Departments" /> -->
                                <button type="button" style="width: 25%;" class="btn btn-lg btn-secondary btn-block " id="viewBtn" onclick="hide()">View Faculty</button>

                            </div>
                            <div class="row">

                                <div class="col">
                                    <center>
                                        <h3 class="h3">Faculty</h3>
                                        <img src="images/faculty.png" style="width: 100px; height: 100px" />
                                    </center>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class="row grid-bottom-padding">
                                <div class="col-md-2">
                                    <label>Faculty ID</label>
                                    <br />
                                    <div class="form-group">
                                        <div class="input-group">
                                            <asp:TextBox ID="facultyId" class="form-control" placeholder="Faculty Id" runat="server"></asp:TextBox>
                                            <asp:Button CssClass="btn btn-primary btn-md btn-inline" ID="goBtn" runat="server" Text="Go"  OnClick="goBtn_Click" />
                                        </div>
                                    </div>

                                </div>
                                <div class="col-md-4">
                                    <label>Faculty First Name</label>
                                    <br />

                                    <asp:TextBox ID="facultyFirtsName" class="form-control" placeholder="First Name" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <label>Faculty Last Name</label>
                                    <br />

                                    <asp:TextBox ID="facultyLastName" class="form-control" placeholder="Last Name" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-2">
                                    <label>Department ID</label>
                                    <br />

                                    <asp:DropDownList ID="departmentId" class="form-control"  placeholder="Department Id" runat="server" DataSourceID="SqlDataSource2" DataTextField="department_id" DataValueField="department_id" >
                                        <asp:ListItem>--select--</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString3 %>" SelectCommand="SELECT * FROM [departments_tbl]"></asp:SqlDataSource>
                                </div>
                                <br />
                                <br />
                                <br />
                                <div class="row grid-bottom-padding">
                                    <div class="col-md-3">
                                        <label>Email </label>
                                        <br />

                                        <asp:TextBox ID="facultyEmail" class="form-control" placeholder="Email Id" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-3">
                                        <label>Mobile </label>
                                        <br />

                                        <asp:TextBox ID="facultyMobile" class="form-control" placeholder="Mobile" TextMode="Number" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-3">
                                        <label>Password </label>
                                        <br />

                                        <asp:TextBox ID="password" class="form-control" placeholder="Password" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                            </div>
                            <br />
                            <div class="row grid-padding">
                                <div class="col">
                                    <center>
                                        <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-success btn-block " ID="facultyAddBtn" runat="server" Text="Add" OnClick="facultyAddBtn_Click" />
                                    </center>
                                </div>
                                <div class="col">
                                    <center>
                                        <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-warning btn-block " ID="facultyUpdateBtn" runat="server" Text="Update" OnClick="facultyUpdateBtn_Click" />
                                    </center>
                                </div>
                                <div class="col">
                                    <center>
                                        <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-danger btn-block " ID="facultyDeleteBtn" runat="server" Text="Delete" OnClick="facultyDeleteBtn_Click" />
                                    </center>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="card" id="viewFaculty" style="display: none">
                        <div class="row d-flex justify-content-end m-2">

                            <button type="button" style="width: 25%;" class="btn btn-lg btn-secondary btn-block " id="addBtn" onclick="hide()">Add Faculty</button>

                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h3 class="h3">Faculty  Details</h3>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                              
                                <div class="col">
                                    <asp:GridView class="table table-striped table-bordered " ID="facultyGridView" runat="server" AutoGenerateColumns="False"  DataSourceID="SqlDataSource1" >
                                        <Columns>
                                            <asp:BoundField DataField="faculty_id" HeaderText="faculty_id" SortExpression="faculty_id" />
                                            <asp:BoundField DataField="faculty_first_name" HeaderText="faculty_first_name" SortExpression="faculty_first_name" />
                                            <asp:BoundField DataField="faculty_last_name" HeaderText="faculty_last_name" SortExpression="faculty_last_name" />
                                            <asp:BoundField DataField="department_id" HeaderText="department_id" SortExpression="department_id" />
                                            <asp:BoundField DataField="faculty_email" HeaderText="faculty_email" SortExpression="faculty_email" />
                                            <asp:BoundField DataField="faculty_mobile" HeaderText="faculty_mobile" SortExpression="faculty_mobile" />
                                            <asp:BoundField DataField="faculty_password" HeaderText="faculty_password" SortExpression="faculty_password" />
                                        </Columns>
                                     
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString2 %>" SelectCommand="SELECT * FROM [faculty_tbl]"></asp:SqlDataSource>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
     <script type="text/javascript">
    function hide() {
        let addFaculty = document.getElementById("addFaculty")
        let viewFaculty = document.getElementById("viewFaculty")
        //let addBtn = document.getElementById("addBtn")
        //let viewBtn = document.getElementById("viewBtn")
        if (addFaculty.style.display == "none") {
            viewFaculty.style.display = "none"
            //viewBtn.style.display = "none"
            addFaculty.style.display = "block"
            //addBtn.style.display = "block"

        }
        else {
            viewFaculty.style.display = "block"
            // viewBtn.style.display = "block"
            addFaculty.style.display = "none"
            //  addBtn.style.display = "none"
        }

    }

     </script>
</asp:Content>
