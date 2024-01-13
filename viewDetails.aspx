<%@ Page Title="" Language="C#" MasterPageFile="~/Site4.Master" AutoEventWireup="true" CodeBehind="viewDetails.aspx.cs" Inherits="CollegeProjectManagementSystem.viewDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">

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
        </div>
    </div>

</asp:Content>
