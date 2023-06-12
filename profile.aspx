<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Course.profile" %>
<%@ Import Namespace="Course" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">


        <div class="col-sm-12">

            <div>
                <div>
                    <img src="/image/" id="uimg" runat="server" style="height:200px; width:250px;"   />
                </div>


                <div>
                    <h2 id="Name" runat="server"></h2>
                    <h2 id="Email" runat="server"></h2>
                </div>
                <div>
                    <h3 id="Dob" runat="server" ></h3>
                    <h3 id="Mobile" runat="server" ></h3>
                </div>
                <div>
                    <h4 id="Address" runat="server"></h4>
                    <h4 id="City" runat="server"></h4>
                    <h4 id="State" runat="server"></h4>
                    <h4 id="ZipCode" runat="server"></h4>
                    
                </div>



            </div>



            <h2>YOUR COURSES</h2>
            <table border="1px">
                <thead>
                   <tr>
                       <th>Sr. No</th>
                       <th>Course Image</th>
                       <th>Course name</th>
                       <th>Course Price</th>
                       <th>Course Duration</th>
                       <th>Order Date</th>
                       <th>Course Validity</th>
                   </tr>
               </thead>
                

                <tbody>
                    <% 
                        int Serial= 1;



                        DbWork db = new DbWork();

                        db.reader = db.orderdetail(Session["uid"].ToString());

                        while (db.reader.Read())
                        {

 

                            int dura = Convert.ToInt32(db.reader["coduration"].ToString());

                            DateTime start = Convert.ToDateTime(db.reader["orderdate"]);
                            DateTime end=DateTime.Now;

                            int difference = (end - start).Days; //create TimeSpan object
                            string Valid = "";
                            int diff = Convert.ToInt32(difference);
                            if (diff>= 0 && diff<=dura )
                            {
                                 Valid =  "Course Is Valid For"+ diff;

                            }
                            else
                            {
                                 Valid = "Course is Expired";
                            }



                        %>

                    <tr>
                        <td><%=Serial++ %></td>
                        <td><img src="/admin/image/courseimg<%=db.reader["coimage"] %>" style="height:100px; width:110px;" /></td>
                        <td><%=db.reader["coname"] %></td>
                        <td><%=db.reader["coprice"] %></td>
                        <td><%=db.reader["coduration"] %></td>
                        <td><%=db.reader["orderdate"] %></td>
                        <td><%=Valid %></td>


                        <td></td>
                    </tr>


                    <%
                        }
                        %>


                </tbody>


            </table>




        </div>
    </div>

</asp:Content>
