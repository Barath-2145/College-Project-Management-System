<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="approvedProjectDetails.aspx.cs" Inherits="CollegeProjectManagementSystem.approvedProjectDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center">
        <div class="container ">
            <div class="row">

                <div class="col-md">
                    <div class="card" id="addStudent">
                        <div class="card-body">

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
                                    <label>Project Id</label>
                                    <br />

                                    <asp:TextBox ID="projectId" class="form-control read" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-8">
                                    <label>Project Tilte</label>
                                    <br />

                                    <asp:TextBox ID="projectTitle" class="form-control read" placeholder="title" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>

                            </div>
                            <div class="row grid-bottom-padding">
                                <div class="col-md-2">
                                    <label>Student Id</label>
                                    <br />

                                    <asp:TextBox ID="studentId1" class="form-control read" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-2">
                                    <label>Student Id</label>
                                    <br />

                                    <asp:TextBox ID="studentId2" class="form-control read" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-2">
                                    <label>Student Id</label>
                                    <br />

                                    <asp:TextBox ID="studentId3" class="form-control read" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-2">
                                    <label>Student Id</label>
                                    <br />

                                    <asp:TextBox ID="studentId4" class="form-control read" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                

                            </div>








                            <div class="row grid-bottom-padding">
                                <div class="col-md-3">

                                    <label>Year </label>
                                    <br />

                                    <asp:TextBox ID="year" class="form-control read" placeholder="year" TextMode="Number" runat="server"></asp:TextBox>

                                </div>

                                <div class="col-md-3">
                                    <label>
                                        Technologies 
                                    </label>
                                    <asp:TextBox ID="tech" CssClass="form-control read" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label>
                                        Batch
                                    </label>
                                    <asp:TextBox ID="batch" CssClass="form-control read" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>


                            <div class="row grid-bottom-padding">
                                <div class="col-md-5">
                                    <label>Subject Name </label>
                                    <br />

                                    <asp:TextBox ID="subject" class="form-control read" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-5">
                                    <label>Project Guide (Faculty Id) </label>
                                    <br />


                                    <asp:TextBox ID="facultyId" class="form-control read" runat="server" ReadOnly="true"></asp:TextBox>



                                </div>

                            </div>
                            <div class="row grid-bottom-padding">
                                <div class="col-md-3">
                                    <label>Status </label>
                                    <br />

                                    <asp:TextBox ID="status" class="form-control" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label>DeadLine </label>
                                    <br />
                                    <asp:TextBox ID="deadLine" class="form-control" TextMode="Date" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-3">
                                    <label>Remarks </label>
                                    <br />
                                    <asp:TextBox ID="remarks" class="form-control" runat="server"></asp:TextBox>
                                </div>

                            </div>

                            <br />
                            <div class="row grid-padding">
                                <div class="col">
                                    <center>
                                        <asp:Button Style="width: 30%;" CssClass="btn btn-lg btn-success btn-block " ID="viewReportBtn" runat="server" Text="View Report" OnClick="viewReportBtn_Click" />
                                    </center>
                                    <br />
                                    <br />

                                    <center>
                                        <asp:Button Style="width: 30%;" CssClass="btn btn-lg btn-primary btn-block " ID="updateBtn" runat="server" Text="update" OnClick="updateBtn_Click" />
                                    </center>
                                    <br />
                                    <br />
                                     <center>
                                        <asp:Button Style="width: 30%;" CssClass="btn btn-lg btn-danger btn-block " ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click"  />
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
        .read {
            background-color: #D6D4D3;
        }

        .none {
            display: none;
        }
    </style>
</asp:Content>
