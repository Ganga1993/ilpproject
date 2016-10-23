<%@ Page Title="" Language="C#" MasterPageFile="~/TestAdmin.Master" AutoEventWireup="true" CodeBehind="DisplayTI.aspx.cs" Inherits="Team2.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .grid
        {
            text-align:center;
            margin-right:auto;
            margin-left:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container">
        <div class="row">
            <div class="col-lg-offset-5 col-lg-4">
                <h3 style="color:brown"><strong>Display Test Schedule</strong></h3>
            </div>
        </div>
    </div>
    <div>
        <div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="">Vacancy Id: </label>
  <div class="col-md-3">
      <asp:DropDownList ID="vId" CssClass="form-control" runat="server">
          <asp:ListItem Value="--select--"></asp:ListItem>
      </asp:DropDownList>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="vId"></asp:RequiredFieldValidator>
      <br />
  </div>
</div>
    <div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="submit"></label>
  <div class="col-md-7">
      <asp:Button ID="btnSubmit"  runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn btn-primary" OnClientClick="verifydates()"/>
      <br />
      <br />
  </div>
</div>                  
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="grid" CellPadding="4" ForeColor="#333333" GridLines="None" Width="75%" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Candidate ProfileID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("cPId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Date">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("WrittenTestDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Status">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("WrittenTestStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Date">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("TechnicalInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Status">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("TechnicalInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Date">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("HRInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Status">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("HRInterviewStatus") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <br />
    </div>
</asp:Content>
