<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Course.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="container-fluid">

        <div class="container-fluid" >
            <div class="row" ></div>
            
                <div class="col-sm-12">
                    <div class="col-sm-8">                
                            <br><br>


                        <div>
                    <label>Username or email *</label>
          <asp:TextBox ID="Email" runat="server" type="email" placeholder="Enter your  Email address " class="form-control p_input"></asp:TextBox>
                 <br><br>
</div>


                        <div>
                    <label>Password *</label>
<asp:TextBox ID="Password" runat="server" type="password" placeholder="Enter Password  here" style="font-weight: 600;" class="form-control p_input"></asp:TextBox>
                  <br><br>
                        </div>

             <br><br>
            <div>
                <asp:Button ID="Loginbtn" runat="server" OnClick="LoginBtn_CLick" class="btn btn-primary btn-block enter-btn"  Text="Login" />
             <br><br>

                <br><br>
            
                <asp:Button ID="ForgetPasswordBtn" runat="server" OnClick="ForgetPasswordBtn_CLick" class="btn btn-primary btn-block enter-btn"  Text="ForgetPassword" />
             <br><br>
</div>


</div>
 </div>

 </div>
 </div>
   

</asp:Content>
