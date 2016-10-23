<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="Team2.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-offset-4 col-lg-5">
                <h3 style="color:brown"><strong>Create Test and Interview Schedule</strong></h3>
            </div>
        </div>
    </div>   
    <form class="form-horizontal form-group">
   <fieldset>
<legend></legend>
<!-- Select Basic -->
<div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="">Test Administrator : </label>
  <div class="col-md-3">
      <asp:DropDownList ID="vId" runat="server" CssClass="form-control">
          <asp:ListItem Value="--select--"></asp:ListItem>
      </asp:DropDownList>
      <asp:Label ID="Label6" runat="server" ForeColor="#FF3300" Text="Please Select Test Administrator" Visible="False"></asp:Label>
      <br />
  </div>
</div>
       
<!-- Select Basic -->
<div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="">Vacancy ID : </label>
  <div class="col-md-3">
      <asp:DropDownList ID="VacancyId" runat="server" CssClass="form-control">
        <asp:ListItem>select</asp:ListItem>
    </asp:DropDownList>
      <asp:Label ID="Label7" runat="server" ForeColor="#FF3300" Text="Please select Vacancy Id" Visible="False"></asp:Label>
      <br />
  </div>
</div>

<!-- Text input-->
<div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="">Written Test Date : </label>  
  <div class="col-md-3">
    <asp:TextBox ID="WrittenTestDate" runat="server" TextMode="Date" CssClass="form-control input-md"></asp:TextBox>
      <br />
  </div>
</div>

<!-- Text input-->
<div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="">Technical Interview Date : </label>  
  <div class="col-md-3">
   <asp:TextBox ID="TechnicalInterviewDate" runat="server" TextMode="Date" CssClass="form-control input-md"></asp:TextBox> 
      <br />
  </div>
</div>

<!-- Text input-->
<div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="">HR Interview Date : </label>  
  <div class="col-md-3">
    <asp:TextBox ID="HRInterviewDate" runat="server" TextMode="Date" CssClass="form-control input-md"></asp:TextBox>
      <br />
  </div>
</div>

<!-- Button (Double) -->
<div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="submit"></label>
  <div class="col-md-7">
      <asp:Button ID="Button1"  runat="server" Text="Submit" OnClick="Button1_Click"  CssClass="btn btn-primary" OnClientClick="verifydates()"/>
  </div>
</div>
</fieldset>
</form>
</asp:Content>
