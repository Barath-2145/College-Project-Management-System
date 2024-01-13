<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="batchDetails.aspx.cs" Inherits="CollegeProjectManagementSystem.batchDetails" %>
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
                    <div class="card" id="addBatch">
                        <div class="card-body">
                            <div class="row d-fles justify-content-end ml-2">
                                <!-- <asp:Button Style="width: 15%;" CssClass="btn btn-lg btn-secondary btn-block " ID="Button2" runat="server" Text="View Departments" /> -->
                                <button type="button" style="width: 20%;" class="btn btn-lg btn-secondary btn-block " id="viewBtn" onclick="hide()">View Batch Details</button>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h3 class="h3">College Batch Details</h3>
                                        <img src="images/office-building.png" style="width: 100px; height: 100px" />
                                    </center>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class="row">
                                <div class="col-md">
                                    <label>Batch ID</label>
                                    <br />
                                    <div class="form-group">
                                        <div class="input-group">
                                            <asp:TextBox ID="batchId" class="form-control" placeholder="eg: 2024" runat="server"></asp:TextBox>
                                            <asp:Button CssClass="btn btn-primary btn-md btn-inline" ID="goBtn" runat="server" Text="Go" OnClick="goBtn_Click"  />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md">
                                    <label>Batch </label>
                                    <br />
                                    <asp:TextBox ID="batch" class="form-control" placeholder="eg: 2020-2024" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md">
                                    <label>Last Date </label>
                                    <br />
                                    <asp:TextBox ID="lastDate" class="form-control" placeholder="eg: 25-06-2034" Textmode="Date" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <div class="row grid-padding">
                                <div class="col">
                                    <center>
                                        <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-success btn-block " ID="addBtn" runat="server" Text="Add" OnClick="addBtn_Click"  />
                                    </center>
                                </div>
                                <div class="col">
                                    <center>
                                        <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-warning btn-block " ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
                                    </center>
                                </div>
                                <div class="col">
                                    <center>
                                        <asp:Button Style="width: 40%;" CssClass="btn btn-lg btn-danger btn-block " ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click"  />
                                    </center>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card" id="viewBatch" style="display: none">
                        <div class="row d-flex justify-content-end m-2">
                            <button type="button" style="width: 20%;" class="btn btn-lg btn-secondary btn-block " id="addDeptBtn" onclick="hide()">Add Batch Details</button>
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
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString %>" SelectCommand="SELECT * FROM [students_batch_tbl]"></asp:SqlDataSource>
                                <div class="col">
                                    <asp:GridView class="table table-striped table-bordered " ID="batchGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="batch_id" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField DataField="batch_id" HeaderText="batch_id" ReadOnly="True" SortExpression="batch_id" />
                                            <asp:BoundField DataField="batch" HeaderText="batch" SortExpression="batch" />
                                            <asp:BoundField DataField="last_date" HeaderText="last_date" SortExpression="last_date" />
                                        </Columns>
                                    </asp:GridView>
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
            let addBatch = document.getElementById("addBatch")
            let viewBatch = document.getElementById("viewBatch")
            //let addBtn = document.getElementById("addBtn")
            //let viewBtn = document.getElementById("viewBtn")
            if (addBatch.style.display == "none") {
                viewBatch.style.display = "none"
                //viewBtn.style.display = "none"
                addBatch.style.display = "block"
                //addBtn.style.display = "block"

            }
            else {
                viewBatch.style.display = "block"
                // viewBtn.style.display = "block"
                addBatch.style.display = "none"
                //  addBtn.style.display = "none"
            }

        }

    </script>
</asp:Content>
