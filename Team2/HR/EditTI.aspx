<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="Team2.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .grid {
            text-align:left;
            margin-left:auto;
            margin-right:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
        <div class="row">
            <div class="col-lg-offset-5 col-lg-4">
                <h3 style="color:brown"><strong>Edit Test Schedule</strong></h3>
            </div>
        </div>
    </div>
               <div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="">Vacancy Id: </label>
  <div class="col-md-3">
    <asp:DropDownList ID="vId" CssClass="form-control" runat="server">
          <asp:ListItem Value="--select--"></asp:ListItem>
      </asp:DropDownList>
      <br />
  </div>
</div>
    <div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="submit"></label>
  <div class="col-md-7">
      <asp:Button ID="btnSubmit"  runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-primary" OnClientClick="verifydates()"/>
  </div>
</div>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            onrowcancelingedit="GridView1_RowCancelingEdit"
            OnRowEditing="GridView1_RowEditing"
            onrowupdating="GridView1_RowUpdating" Height="185px"
             ShowFooter="False" width="75%" CssClass="grid" >
            <Columns>
                <asp:TemplateField HeaderText="Test Id">
                           <EditItemTemplate>
                        <asp:Label ID="tid" runat="server" Enabled="false" Text='<%# Eval("TestId") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label16" runat="server" Text='<%# Eval("TestId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>              
                <asp:TemplateField HeaderText="Vacancy Id">
                     <EditItemTemplate>
                        <asp:Label ID="vid" runat="server" Enabled="false" Text='<%# Eval("VacancyId") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("VacancyId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Written Test Date">
                     <EditItemTemplate>
                        <asp:TextBox ID="wtd" runat="server" Text='<%# Eval("WrittenTestDate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("WrittenTestDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Technical Interview Date">
                     <EditItemTemplate>
                        <asp:TextBox ID="tidt" runat="server" Text='<%# Eval("TechnicalInterviewDate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("TechnicalInterviewDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="HRInterview Date">
                     <EditItemTemplate>
                        <asp:TextBox ID="hid" runat="server" Text='<%# Eval("HRInterviewDate") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("HRInterviewDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>               
                <asp:CommandField ShowEditButton="True" />  
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
