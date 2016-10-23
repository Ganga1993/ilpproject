<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Team2.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <fieldset>
<!-- Form Name -->
<div class="container">
        <div class="row">
            <div class="col-lg-offset-5 col-lg-4">
                <h3 style="color:brown"><strong>Create Candidate Profile</strong></h3>
            </div>
        </div>
    </div>
            <br />
<!-- Select Basic -->
<div class="form-group">
  <label class="col-md-5 control-label" for="vId">Vacancy ID : </label>
  <div class="col-md-3">
      <asp:DropDownList ID="vId" CssClass="form-control" runat="server">
          <asp:ListItem Value="--select--"></asp:ListItem>
      </asp:DropDownList>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cName">Candidate Name : </label>  
  <div class="col-md-3">
      <asp:TextBox ID="cName" runat="server" CssClass="form-control input-md"></asp:TextBox>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cDob">Date of Birth : </label>  
  <div class="col-md-3">
      <asp:TextBox ID="cDob" runat="server" CssClass="form-control input-md" TextMode="Date"></asp:TextBox>
  </div>
</div>

<!-- Select Basic -->
<div class="form-group">
  <label class="col-md-5 control-label" for="cLocation">Location : </label>
  <div class="col-md-3">
      <asp:DropDownList ID="cLocation" runat="server" CssClass="form-control">
          <asp:ListItem Value="--select--"></asp:ListItem>
          <asp:ListItem Value="Chennai"></asp:ListItem>
          <asp:ListItem Value="Bangalore"></asp:ListItem>
          <asp:ListItem Value="Hyderabad"></asp:ListItem>
          <asp:ListItem Value="Pune"></asp:ListItem>
          <asp:ListItem Value="Kolkata"></asp:ListItem>
      </asp:DropDownList>
  </div>
</div>
<!-- Multiple Radios (inline) -->
<div class="form-group">
  <label class="col-md-5 control-label" for="cGender">Gender : </label>
  <div class="col-md-4">
      <label class="radio-inline" for="cGender-0">
      <asp:RadioButtonList ID="cGender" runat="server">
          <asp:ListItem Value="Male" Selected="True"></asp:ListItem>
          <asp:ListItem Value="Female"></asp:ListItem>
      </asp:RadioButtonList>
          </label>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cPTenth">Percentage in 10th Class : </label>  
  <div class="col-md-3">
      <asp:TextBox ID="cPTenth" runat="server" CssClass="form-control input-md"></asp:TextBox>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cPTwelth">Percentage in 12th Class : </label>  
  <div class="col-md-3">
      <asp:TextBox ID="cPTwelth" runat="server" CssClass="form-control input-md"></asp:TextBox>
  </div>
</div>

<!-- Multiple Radios (inline) -->
<div class="form-group">
  <label class="col-md-5 control-label" for="cGapInEdu">Gap in Education : </label>
  <div class="col-md-4">
       <label class="radio-inline" for="cGender-0">
      <asp:RadioButtonList ID="cGapInEdu" runat="server">
          <asp:ListItem Value="Yes"></asp:ListItem>
          <asp:ListItem Value="No" Selected="True"></asp:ListItem>
      </asp:RadioButtonList>
       </label>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cGapReasonEdu"></label>  
  <div class="col-md-3">
      <asp:TextBox ID="cGapReasonEdu" runat="server" CssClass="form-control input-md"></asp:TextBox>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cGapEduYear">Gap in Years : </label>  
  <div class="col-md-3">
      <asp:TextBox ID="cGapEduYear" runat="server" CssClass="form-control input-md"></asp:TextBox>
  </div>
</div>

<!-- Multiple Radios (inline) -->
<div class="form-group">
  <label class="col-md-5 control-label" for="cGapInExp">Gap In Experience : </label>
  <div class="col-md-4"> 
       <label class="radio-inline" for="cGender-0">
    <asp:RadioButtonList ID="cGapInExp" runat="server">
            <asp:ListItem Value="Yes" Selected="True"></asp:ListItem>
            <asp:ListItem Value="No"></asp:ListItem>
      </asp:RadioButtonList>
           </label>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cGapReasonExp"></label>  
  <div class="col-md-3">
      <asp:TextBox ID="cGapReasonExp" runat="server" CssClass="form-control input-md"></asp:TextBox>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cGapExpYear">Gap in Years : </label>  
  <div class="col-md-3">
      <asp:TextBox ID="cGapExpYear" runat="server" CssClass="form-control input-md"></asp:TextBox>
  </div>
</div>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-5 control-label" for="cExperience">Experience in Years : </label>  
  <div class="col-md-3">
      <asp:TextBox ID="cExperience" runat="server" Cssclass="form-control input-md"></asp:TextBox>
  </div>
</div>

<!-- File Button --> 
<div class="form-group">
  <label class="col-md-5 control-label" for="cResume">Resume : </label>
  <div class="col-md-3">
    <input id="jk" name="cResume" class="input-file" type="file" />
  </div>
</div>

    <!-- Button (Double) -->
<div class="form-group">
  <label class="col-md-5 control-label" for="submit1"></label>
  <div class="col-md-6">
      <asp:Button ID="submit1" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="Button1_Click"/>
      <asp:Button ID="reset1" runat="server" Text="Reset" CssClass="btn btn-inverse" />
    </div>
</div>


</fieldset>
</asp:Content>
