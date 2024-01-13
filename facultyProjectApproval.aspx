<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="facultyProjectApproval.aspx.cs" Inherits="CollegeProjectManagementSystem.facultyProjectApproval" %>

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
            <div class="col-md">
                
                <asp:GridView ID="projectApprovalGridView" runat="server"  class="table table-striped table-bordered "  Width="947px"  >
                    <Columns>
                       
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                 
                </asp:GridView>
           
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CPMSConnectionString8 %>" ></asp:SqlDataSource>
                 <center>
                      <asp:Button ID="Button1" style="width:35%;" runat="server" CssClass="btn btn-primary " Text="Submit For Approval" Width="205px" OnClick="Button1_Click" />
                 </center>
               
                <br />
                                <br />
                                <br />
                <center>
                      <asp:Button ID="Button3" style="width:35%;" runat="server" CssClass="btn btn-secondary " Text="View Details" Width="205px" OnClick="Button3_Click" />
                 </center>
                <br />
                <br />
                <center>
                      <asp:Button ID="Button2" style="width:35%;" runat="server" CssClass="btn btn-danger " Text="Reject Request" Width="205px" OnClick="Button2_Click"  />
                 </center>
            </div>
        </div>
    </div>

</asp:Content>
