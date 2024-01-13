<%@ Page Title="" Language="C#" MasterPageFile="~/Site5.Master" AutoEventWireup="true" CodeBehind="adminProjectView.aspx.cs" Inherits="CollegeProjectManagementSystem.adminProjectView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        // let table = new DataTable('.table');
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
        })

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:GridView  class="table table-striped table-bordered " ID="adminProjectGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="adminProjectGridView_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="project_id" HeaderText="project_id" SortExpression="project_id" />
                    <asp:BoundField DataField="project_title" HeaderText="project_title" SortExpression="project_title" />
                    <asp:BoundField DataField="technology" HeaderText="technology" SortExpression="technology" />
                    <asp:BoundField DataField="year" HeaderText="year" SortExpression="year" />
                    <asp:BoundField DataField="batch" HeaderText="batch" SortExpression="batch" />
                    <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                    <asp:BoundField DataField="faculty_id" HeaderText="faculty_id" SortExpression="faculty_id" />
                    <asp:BoundField DataField="subject" HeaderText="subject" SortExpression="subject" />
                    <asp:BoundField DataField="remarks" HeaderText="remarks" SortExpression="remarks" />
                    <asp:BoundField DataField="deadline" HeaderText="deadline" SortExpression="deadline" />
                    <asp:CommandField HeaderText="Action" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString10 %>" SelectCommand="SELECT [project_id], [project_title], [technology], [year], [batch], [status], [faculty_id], [subject], [remarks], [deadline] FROM [project_tbl]"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
