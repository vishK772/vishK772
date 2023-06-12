<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Course.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container-fluid">

        <div class="container-fluid" >
            <div class="row" ></div>
            
                <div class="col-sm-12">
                    <div class="col-sm-8">                
                            <br><br>
                        <asp:TextBox ID="Name" runat="server" type="text" placeholder="Enter your  name " class="form-control"></asp:TextBox>
                          <br><br />
                        <div>
                      
                         <asp:TextBox ID="Email" runat="server" type="email" placeholder="Enter your  email address " class="form-control"></asp:TextBox>

                             
                          <br><br>
                            </div>
                        <div>
                       
                                <asp:TextBox ID="Password" runat="server" type="password" placeholder="create  your Password  here" style="font-weight: 600;" class="form-control"></asp:TextBox>
                            
                            

                            <br><br>

                            </div>


                        <div>
                            
              <asp:TextBox ID="Mobile" runat="server" placeholder="Enter your mobile number " ></asp:TextBox>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" ControlToValidate="Mobile" MaximumValue="12" MinimumValue="7" Type="Double"></asp:RangeValidator>
                   <br><br>
                            </div>

                        <div>
                            <asp:TextBox ID="Dob" runat="server" placeholder="Enter your Date Of Birth " ></asp:TextBox>
                          <br><br>
                        </div>
                        <div>
                         <asp:TextBox ID="Gender" runat="server" placeholder="Male/Female" ></asp:TextBox>
                          <br><br>
                        </div>
                         <div>
                 <asp:TextBox ID="Address" runat="server" type="text" placeholder="Enter your address " class="form-control"></asp:TextBox>
                          <br><br>
                        </div>
                        <div>
                       <asp:TextBox ID="City" runat="server" type="text" placeholder="Enter your city "  class="form-control"></asp:TextBox>
                          <br><br>
                        </div>
                        <div>
                         <asp:TextBox ID="State" runat="server" type="text"  placeholder="Enter your State "   class="form-control"></asp:TextBox>
                          <br><br>
                        </div>

                        <div>
                        
                         <asp:TextBox ID="ZipCode" runat="server" type="number" placeholder="postal/zip code"  class="form-control"></asp:TextBox>

                            
                          <br><br>
                         </div>
                            <asp:FileUpload ID="UImage" runat="server" />
                       
                            <br />
            
                        <asp:Button  ID="RegisterBtn" runat="server"   Text="Register" OnClick="RegisterBtn_Click"  class="btn-success" style="margin-left: 20px; min-width: 120px; max-height: 50px; border-radius: 10px;"  />    
                        

                        
                          
                    
                    </div>
                   
               
            </div>
        </div>

    </div>

</asp:Content>
