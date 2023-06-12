<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="Course.ForgetPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-md-pull-8">

            <div class="row">
                <div>
                <span>Enter Your Email</span>
                <asp:TextBox ID="Email" runat="server" Text=""></asp:TextBox>
                    </div>
                <div>
                <span>Enter New Password</span>
                <asp:TextBox ID="Password" runat="server" Text=""></asp:TextBox>
                </div>

            </div>

        </div>

    </div>



</asp:Content>
