<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="facultyCreateProject.aspx.cs" Inherits="CollegeProjectManagementSystem.facultyCreateProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="d-flex justify-content-center">
        <div class="container ">
            <div class="row">

                <div class="col-md">
                    <div class="card" id="addStudent">
                        <div class="card-body">
                            <div class="row d-fles justify-content-end ml-2">

                                <button type="button" style="width: 25%;" class="btn btn-lg btn-secondary btn-block " id="requestBtn" onclick="hide()">Requests</button>

                            </div>
                            <div class="row">

                                <div class="col">
                                    <center>
                                        <h3 class="h3">Projects</h3>
                                        <img src="images/project5.jpg" style="width: 100px; height: 100px" />
                                    </center>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class="row grid-bottom-padding">
                                <div class="col-md-2">
                                    <label>Team Members Count</label>
                                    <br />

                                    <asp:DropDownList ID="count" class="form-control select-el" placeholder="count" runat="server" onchange="disable(this);">
                                        <asp:ListItem Value="1">1</asp:ListItem>
                                        <asp:ListItem Value="2">2</asp:ListItem>
                                        <asp:ListItem Value="3">3</asp:ListItem>
                                        <asp:ListItem Value="4">4</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-8">
                                    <label>Project Tilte</label>
                                    <br />

                                    <asp:TextBox ID="projectTitle" class="form-control" placeholder="title" runat="server"></asp:TextBox>
                                </div>
                                 <div class="col-md-2">
                                    <label> Tilte Abbreviation</label>
                                    <br />

                                    <asp:TextBox ID="abbreviation" class="form-control" placeholder="Eg: CPMS" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row grid-bottom-padding" id="m1">
                                <div class="col-md-2">
                                    <label>Registeration No</label>
                                    <br />
                                    <div class="form-group">
                                        <div class="input-group">
                                            <asp:TextBox ID="studentId1" class="form-control" placeholder="Student Id" runat="server"></asp:TextBox>
                                            <asp:Button ID="go1" CssClass="btn btn-primary btn-md btn-inline"  runat="server" Text="Go"  ></asp:Button>
                                        </div>
                                    </div>

                                </div>
                                <div class="col-md-4">
                                    <label>Student First Name</label>
                                    <br />

                                    <asp:TextBox ID="studentFirstName1" class="form-control read" placeholder="First Name" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <label>Student Last Name</label>
                                    <br />

                                    <asp:TextBox ID="studentLastName1" class="form-control read" placeholder="Last Name" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-2">
                                    <label>Department ID</label>
                                    <br />
                                    <asp:TextBox ID="department1" class="form-control read" placeholder="department" runat="server" ReadOnly="true"></asp:TextBox>

                                </div>
                            </div>
                            <div class="row grid-bottom-padding" id="m2">
                                <div class="col-md-2">
                                    <label>Registeration No</label>
                                    <br />
                                    <div class="form-group">
                                        <div class="input-group">
                                            <asp:TextBox ID="studentId2" class="form-control" placeholder="Student Id" runat="server"></asp:TextBox>
                                            <asp:Button CssClass="btn btn-primary btn-md btn-inline" ID="go2" runat="server" Text="Go" OnClick="go2_Click" />
                                        </div>
                                    </div>

                                </div>
                                <div class="col-md-4">
                                    <label>Student First Name</label>
                                    <br />

                                    <asp:TextBox ID="studentFirstName2" class="form-control read" placeholder="First Name" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <label>Student Last Name</label>
                                    <br />

                                    <asp:TextBox ID="studentLastName2" class="form-control read" placeholder="Last Name" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-2">
                                    <label>Department ID</label>
                                    <br />
                                    <asp:TextBox ID="department2" class="form-control read" placeholder="department" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                </div>
                             <div class="row grid-bottom-padding" id="m3">
                                    <div class="col-md-2">
                                        <label>Registeration No</label>
                                        <br />
                                        <div class="form-group">
                                            <div class="input-group">
                                                <asp:TextBox ID="studentId3" class="form-control" placeholder="Student Id" runat="server"></asp:TextBox>
                                                <asp:Button CssClass="btn btn-primary btn-md btn-inline" ID="go3" runat="server" Text="Go" OnClick="go3_Click" />
                                            </div>
                                        </div>

                                    </div>
                                    <div class="col-md-4">
                                        <label>Student First Name</label>
                                        <br />

                                        <asp:TextBox ID="studentFirstName3" class="form-control read" placeholder="First Name" runat="server" ReadOnly="true"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4">
                                        <label>Student Last Name</label>
                                        <br />

                                        <asp:TextBox ID="studentLastName3" class="form-control read" placeholder="Last Name" runat="server" ReadOnly="true"></asp:TextBox>
                                    </div>
                                    <div class="col-md-2">
                                        <label>Department ID</label>
                                        <br />

                                        <asp:TextBox ID="department3" class="form-control read" placeholder="department" runat="server" ReadOnly="true"></asp:TextBox>
                                    </div>
                                    </div>
                             <div class="row grid-bottom-padding" id="m4">
                                        <div class="col-md-2">
                                            <label>Registeration No</label>
                                            <br />
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <asp:TextBox ID="studentId4"  class="form-control student4" placeholder="Student Id" runat="server"></asp:TextBox>
                                                    <asp:Button CssClass="btn btn-primary btn-md btn-inline" ID="go4" runat="server" Text="Go" OnClick="go4_Click" />
                                                </div>
                                            </div>

                                        </div>
                                        <div class="col-md-4">
                                            <label>Student First Name</label>
                                            <br />

                                            <asp:TextBox ID="studentFirstName4" class="form-control read" placeholder="First Name" runat="server" ReadOnly="true"></asp:TextBox>
                                        </div>
                                        <div class="col-md-4">
                                            <label>Student Last Name</label>
                                            <br />

                                            <asp:TextBox ID="studentLastName4" class="form-control read" placeholder="Last Name" runat="server" ReadOnly="true"></asp:TextBox>
                                        </div>
                                        <div class="col-md-2">
                                            <label>Department ID</label>
                                            <br />
                                            <asp:TextBox ID="department4" class="form-control read" placeholder="department" runat="server" ReadOnly="true"></asp:TextBox>

                                        </div>
                                    </div>


                                    <div class="row grid-bottom-padding">
                                        <div class="col-md-3">

                                            <label>Year </label>
                                            <br />

                                            <asp:TextBox ID="year" class="form-control" placeholder="year" TextMode="Number" runat="server"></asp:TextBox>

                                        </div>

                                        <div class="col-md-3">
                                            <label>
                                                Technologies 
                                            </label>
                                            <asp:TextBox ID="tech" CssClass="form-control" placeholder="eg: c#" runat="server"></asp:TextBox>
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
                                            <label>Subject Name </label>
                                            <br />

                                            <asp:TextBox ID="subject" class="form-control" placeholder="subject" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-md-3">
                                            <label>Project Guide (Faculty Id) </label>
                                            <br />
                                            <div class="form-group">
                                                <div class="input-group">
                                                    <asp:TextBox ID="facultyId" class="form-control" placeholder="Faculty Id" runat="server"></asp:TextBox>
                                                    <asp:Button CssClass="btn btn-primary btn-md btn-inline" ID="facultyGoBtn" runat="server" Text="Go" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <label>Faculty First Name </label>
                                            <br />

                                            <asp:TextBox ID="facultyFirstName" class="form-control read" placeholder=" First Name" runat="server" ReadOnly="true"></asp:TextBox>
                                        </div>
                                        <div class="col-md-3">
                                            <label>Faculty Last Name </label>
                                            <br />

                                            <asp:TextBox ID="facultyLastName" class="form-control read" placeholder=" Last Name" runat="server" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                
                                <br />
                                <div class="row grid-padding">
                                    <div class="col">
                                        <center>
                                            <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-success btn-block " ID="projectAddBtn" runat="server" Text="Request"  />
                                        </center>
                                    </div>

                                </div>

                            
                        </div>

                    </div>

                </div>
            </div>
        </div>
    </div>
    <style>
        .read{
             background-color:#D6D4D3;
             
        }
        .none{
            display:none;
        }
    </style>
    <script>
        function disable() {
           // let selectEl = document.getElementsByClassName("select-el")

            let e = document.getElementById('<%=count.ClientID%>')

           //console.log(e)
           let val = e.options[e.selectedIndex].value
          //  console.log(val)

            let m1 = document.getElementById("m1")
            let m2 = document.getElementById("m2")
            let m3 = document.getElementById("m3")
            let m4 = document.getElementById("m4")
            const count = [m1, m2, m3, m4]

            let i
            //console.log(count.length)
            for ( i = count.length-1; i >= val; i--) {
                let hide = count[i];

                hide.classList.add("none");
            }
            for (let j = i; j >= 0; j--) {
                let show = count[j]
                show.classList.remove("none");
            }
            //window.onload = disable();
        };

        function goStudent1() {

            let id1 = document.getElementById('<%=studentId1.ClientID%>').value;
            

            let xmlhttp = new XMLHttpRequest();
            xmlhttp.open("GET", "createProjectsStudent.aspx?id=" + id1 + "&n="+ 1 , false);
            xmlhttp.send(null);


        }

        // For DropDown List

        disable();
    </script>
</asp:Content>
