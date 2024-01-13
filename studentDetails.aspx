<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="studentDetails.aspx.cs" Inherits="CollegeProjectManagementSystem.registrarStudentManagement" %>

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
                    <div class="card" id="addStudent">
                        <div class="card-body">
                            <div class="row d-fles justify-content-end ml-2">
                                <!-- <asp:Button Style="width: 15%;" CssClass="btn btn-lg btn-secondary btn-block " ID="Button2" runat="server" Text="View Departments" /> -->
                                <button type="button" style="width: 25%;" class="btn btn-lg btn-secondary btn-block " id="viewBtn" onclick="hide()">View Students</button>

                            </div>
                            <div class="row">

                                <div class="col">
                                    <center>
                                        <h3 class="h3">Student</h3>
                                        <img src="images/faculty.png" style="width: 100px; height: 100px" />
                                    </center>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class="row grid-bottom-padding">
                                <div class="col-md-2">
                                    <label>Registeration No</label>
                                    <br />
                                    <div class="form-group">
                                        <div class="input-group">
                                            <asp:TextBox ID="studentId" class="form-control" placeholder="Student Id" runat="server"></asp:TextBox>
                                            <asp:Button CssClass="btn btn-primary btn-md btn-inline" ID="goBtn" runat="server" Text="Go" OnClick="goBtn_Click" />
                                        </div>
                                    </div>

                                </div>
                                <div class="col-md-4">
                                    <label>Student First Name</label>
                                    <br />

                                    <asp:TextBox ID="studentFirstName" class="form-control" placeholder="First Name" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <label>Student Last Name</label>
                                    <br />

                                    <asp:TextBox ID="studentLastName" class="form-control" placeholder="Last Name" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-2">
                                    <label>Department ID</label>
                                    <br />

                                    <asp:DropDownList ID="departmentId" class="form-control" placeholder="Department Id" runat="server" DataSourceID="SqlDataSource2" DataTextField="department_id" DataValueField="department_id">
                                        <asp:ListItem>--select--</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString3 %>" SelectCommand="SELECT * FROM [departments_tbl]"></asp:SqlDataSource>
                                </div>
                            </div>


                            <div class="row grid-bottom-padding">
                                <div class="col-md-3">
                                    
                                    <label>Year </label>
                                    <br />

                                    <asp:TextBox ID="year" class="form-control" placeholder="year" TextMode="Number" runat="server"></asp:TextBox>
                                    
                                </div>
                              <!--  <div class="col-md-3">
                                    <label>
                                        Semester
                                    </label>
                                    <asp:DropDownList ID="sem" CssClass="form-control" runat="server">
                                        <asp:ListItem>
                                            1
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            2
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            3
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            4
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            5
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            6
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            7
                                        </asp:ListItem>
                                        <asp:ListItem>
                                            8
                                        </asp:ListItem>
                                    </asp:DropDownList>
                                </div> -->
                                <div class="col-md-3">
                                    <label>
                                        Password
                                    </label>
                                    <asp:TextBox ID="password" CssClass="form-control" placeholder="password" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label>
                                        Batch
                                    </label>
                                    <asp:DropDownList class="form-control" ID="batch" runat="server" DataSourceID="SqlDataSource1" DataTextField="batch_id" DataValueField="batch_id">
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString4 %>" SelectCommand="SELECT [batch_id] FROM [students_batch_tbl]"></asp:SqlDataSource>
                                </div>
                            </div>


                            <div class="row grid-bottom-padding">
                                <div class="col-md-3">
                                    <label>Email </label>
                                    <br />

                                    <asp:TextBox ID="studentEmail" class="form-control" placeholder="Email Id" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label>Mobile </label>
                                    <br />

                                    <asp:TextBox ID="studentMobile" class="form-control" placeholder="Mobile" TextMode="Number" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label>Date Of Birth </label>
                                    <br />

                                    <asp:TextBox ID="dob" class="form-control" placeholder="Dob" TextMode="Date" runat="server"></asp:TextBox>
                                </div>
                            </div>


                        </div>
                        <br />
                        <div class="row grid-padding">
                            <div class="col">
                                <center>
                                    <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-success btn-block " ID="studentAddBtn" runat="server" Text="Add" OnClick="studentAddBtn_Click" />
                                </center>
                            </div>
                            <div class="col">
                                <center>
                                    <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-warning btn-block " ID="studentUpdateBtn" runat="server" Text="Update" OnClick="studentUpdateBtn_Click" />
                                </center>
                            </div>
                            <div class="col">
                                <center>
                                    <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-danger btn-block " ID="studentDeleteBtn" runat="server" Text="Delete" OnClick="studentDeleteBtn_Click" />
                                </center>
                            </div>
                        </div>

                    </div>
                </div>
                <div class="card" id="viewStudent" style="display: none">
                    <div class="row d-flex justify-content-end m-2">

                        <button type="button" style="width: 25%;" class="btn btn-lg btn-secondary btn-block " id="addBtn" onclick="hide()">Add Students</button>

                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3 class="h3">Student  Details</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">

                            <div class="col" style="overflow: auto;" width:200; height:200;>
                                <asp:GridView class="table table-striped table-bordered " ID="studentGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="student_id" DataSourceID="SqlDataSource3">
                                    <Columns>
                                        <asp:BoundField DataField="student_id" HeaderText="student_id" ReadOnly="True" SortExpression="student_id" />
                                        <asp:BoundField DataField="student_first_name" HeaderText="student_first_name" SortExpression="student_first_name" />
                                        <asp:BoundField DataField="student_last_name" HeaderText="student_last_name" SortExpression="student_last_name" />
                                        <asp:BoundField DataField="student_password" HeaderText="student_password" SortExpression="student_password" />
                                        <asp:BoundField DataField="department_id" HeaderText="department_id" SortExpression="department_id" />
                                        <asp:BoundField DataField="batch_id" HeaderText="batch_id" SortExpression="batch_id" />
                                        <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
                                        <asp:BoundField DataField="mobile_number" HeaderText="mobile_number" SortExpression="mobile_number" />
                                        <asp:BoundField DataField="student_email" HeaderText="student_email" SortExpression="student_email" />
                                        <asp:BoundField DataField="date_of_birth" HeaderText="date_of_birth" SortExpression="date_of_birth" />
                                    </Columns>
                                </asp:GridView>

                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString5 %>" SelectCommand="SELECT * FROM [student_academic_details_tbl]"></asp:SqlDataSource>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function hide() {
            let addStudent = document.getElementById("addStudent")
            let viewStudent = document.getElementById("viewStudent")
            //let addBtn = document.getElementById("addBtn")
            //let viewBtn = document.getElementById("viewBtn")
            if (addStudent.style.display == "none") {
                viewStudent.style.display = "none"
                //viewBtn.style.display = "none"
                addStudent.style.display = "block"
                //addBtn.style.display = "block"

            }
            else {
                viewStudent.style.display = "block"
                // viewBtn.style.display = "block"
                addStudent.style.display = "none"
                //  addBtn.style.display = "none"
            }

        }

    </script>

</asp:Content>
