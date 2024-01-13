<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="uploadFile.aspx.cs" Inherits="CollegeProjectManagementSystem.uploadFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mb-5">
        <div class="row">
            <div class="col-md-6">
                <div class="card " style="padding:20px">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <div class="card-body">
                                    <label>
                                        Project Id
                                    </label>
                                    <asp:TextBox ID="projectId" class="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                    </div>
                        <div class="row">
                            <div class="col">
                                <label>
                                     Upload Report (PDF format only)
                                </label>
                                <asp:FileUpload ID="file" class="form-control" runat="server"></asp:FileUpload>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:Button ID="fileUploadBtn" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="fileUploadBtn_Click" />
                            </div>
                        </div>
                </div>
            </div>
                <br />
                <br />
                <br />
        </div>
    </div>
</asp:Content>
