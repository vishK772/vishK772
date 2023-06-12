<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="onlycourse.aspx.cs" Inherits="Course.onlycourse" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="courses-wrapper">

					<div class="row">

						<!-- single course -->
						<div class="col-md-3 col-sm-6 col-xs-6">
							<div class="course">
								
									<img src="/image/" class="course-img" id="coimage" runat="server" style="height:300px; width:300px;"  />
							<h3 class="course-details" id="CONAME" runat="server"></h3>
								<h4 class="course-details" id="CODESC" runat="server"></h4>
								<h4 class="course-details" id="COPRICE" runat="server"></h4>
								<h4 class="course-details" id="CODURATION" runat="server"></h4>
							</div>
			<asp:Button ID="BuyBtn" runat="server" Text="BUY NOW" CssClass="btn-danger" OnClick="BuyBtn_Click"/>
</div>
		
</div>
		</div>




</asp:Content>
