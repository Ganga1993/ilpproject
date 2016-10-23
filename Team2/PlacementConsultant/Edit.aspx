<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Team2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .grid {
            text-align:center;
            margin-left:auto;
            margin-right:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form class="form-horizontal">
        <fieldset>
    <div class="container">
        <div class="row">
            <div class="col-lg-offset-5 col-lg-4">
                <h3 style="color:brown"><strong>Edit Candidate Profile</strong></h3>
            </div>
        </div>
    </div>
            <br />

    <div class="container">
        <div class="form-group">
            <label class="control-label col-md-5" for="vId">Vacancy ID</label>
            <div class="col-md-3">
                <asp:DropDownList ID="vId" runat="server" CssClass="form-control input-md">
                    <asp:ListItem Value="--select--"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
    </div>
             <!-- Button (Double) -->
<div class="form-group">
  <label class="col-md-5 control-label" for="submit1"></label>
  <div class="col-md-5">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="Button1" runat="server" Text="Submit"  CssClass="btn btn-primary" OnClick="Button1_Click" />
  </div>
</div>
            </fieldset>
        </form>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            onrowcancelingedit="GridView1_RowCancelingEdit"            
            onrowdeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing"
            onrowupdating="GridView1_RowUpdating" Height="185px"
             ShowFooter="false" Width="75%" CssClass="grid" AllowPaging="true" PageIndex="0" PageSize="4" OnPageIndexChanging="GridView1_PageIndexChanging" >
            <Columns>
                <asp:TemplateField HeaderText="Candidate profile id" HeaderStyle-HorizontalAlign="Left">
                    <EditItemTemplate>
                        <asp:Label ID="lcp" runat="server" Text='<%# Eval("cPId") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tcp" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("cPId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="candidate name"  HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                        <asp:TextBox ID="lname" runat="server" Text='<%# Eval("cName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tname" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("cName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DOB" HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                        <asp:TextBox ID="ldob" runat="server" Text='<%# Eval("cDob") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tdob" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("cDob") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Location" HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                        <asp:TextBox ID="llocation" runat="server" Text='<%# Eval("cLocation") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tlocation" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("cLocation") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender" HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                        <asp:TextBox ID="lgender" runat="server" Text='<%# Eval("cGender") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tgender" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("cGender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="10th Percentage" HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                        <asp:TextBox ID="lten" runat="server" Text='<%# Eval("cPTenth") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tten" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("cPTenth") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="12th percentage" HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                        <asp:TextBox ID="ltwelth" runat="server" Text='<%# Eval("cPTwelth") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="ttwelth" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("cPTwelth") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gap in education" HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                        <asp:TextBox ID="lgapedu" runat="server" Text='<%# Eval("cGapInEdu") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tgapedu" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("cGapInEdu") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="reason" HeaderStyle-HorizontalAlign="Left">
                      <EditItemTemplate>
                        <asp:TextBox ID="lgapreason" runat="server" Text='<%# Eval("cGapReasonEdu") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tgapreason" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("cGapReasonEdu") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="year" HeaderStyle-HorizontalAlign="Left">
                      <EditItemTemplate>
                        <asp:TextBox ID="lyear" runat="server" Text='<%# Eval("cGapEduYear") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tyear" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("cGapEduYear") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gap in experience" HeaderStyle-HorizontalAlign="Left">
                      <EditItemTemplate>
                        <asp:TextBox ID="lgapexp" runat="server" Text='<%# Eval("cGapInEdu") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tgapexp" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("cGapInEdu") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Reason" HeaderStyle-HorizontalAlign="Left">
                        <EditItemTemplate>
                        <asp:TextBox ID="lgapexpreason" runat="server" Text='<%# Eval("cGapReasonExp") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tgapexpreason" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label12" runat="server" Text='<%# Eval("cGapReasonExp") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Year" HeaderStyle-HorizontalAlign="Left">
                        <EditItemTemplate>
                        <asp:TextBox ID="lgapexpyear" runat="server" Text='<%# Eval("cGapExpYear") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tgapexpyear" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label13" runat="server" Text='<%# Eval("cGapExpYear") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Experience Years" HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                        <asp:TextBox ID="lexpyear" runat="server" Text='<%# Eval("cExperience") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="texpyear" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label14" runat="server" Text='<%# Eval("cExperience") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Resume" HeaderStyle-HorizontalAlign="Left">
                        <EditItemTemplate>
                        <asp:TextBox ID="lresume" runat="server" Text='<%# Eval("cResume") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tresume" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label15" runat="server" Text='<%# Eval("cResume") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test Id" HeaderStyle-HorizontalAlign="Left">
                           <EditItemTemplate>
                        <asp:Label ID="ltestid" runat="server" Text='<%# Eval("cTestId") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="ttestid" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label16" runat="server" Text='<%# Eval("cTestId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test status" HeaderStyle-HorizontalAlign="Left">
                          <EditItemTemplate>
                        <asp:Label ID="lteststatus" runat="server" Text='<%# Eval("cTestStatus") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tteststatus" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label17" runat="server" Text='<%# Eval("cTestStatus") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Medical status" HeaderStyle-HorizontalAlign="Left">
                            <EditItemTemplate>
                                <asp:Label ID="lmedstatus" runat="server" Text='<%# Eval("cMedicalStatus") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tmedstatus" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label18" runat="server" Text='<%# Eval("cMedicalStatus") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BGC testid" HeaderStyle-HorizontalAlign="Left">
                             <EditItemTemplate>
                                 <asp:Label ID="lbgctestid" runat="server" Text='<%# Eval("cBGCTestId") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tbgctestid" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label19" runat="server" Text='<%# Eval("cBGCTestId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BGC teststatus" HeaderStyle-HorizontalAlign="Left">
                     <EditItemTemplate>
                         <asp:Label ID="lbgcteststatus" runat="server" Text='<%# Eval("cBGCTestStatus") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="tbgcteststatus" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label20" runat="server" Text='<%# Eval("cBGCTestStatus") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                                
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:TemplateField  ShowHeader="false">    
                     <FooterTemplate>
                         <asp:LinkButton ID="add" runat="server" CommandName="add">Add</asp:LinkButton>
                    </FooterTemplate></asp:TemplateField>     
            </Columns>
        </asp:GridView>   
</asp:Content>
