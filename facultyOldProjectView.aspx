<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="facultyOldProjectView.aspx.cs" Inherits="CollegeProjectManagementSystem.facultyOldProjectView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        // let table = new DataTable('.table');
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
        })

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="facultyOldProjectGridView" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="facultyOldProjectGridView_SelectedIndexChanged">
        <Columns>
            <asp:CommandField HeaderText="Action" SelectText="View Details" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</asp:Content>
