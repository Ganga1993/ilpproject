<%@ Page Title="" Language="C#" MasterPageFile="~/TestAdmin.Master" AutoEventWireup="true" CodeBehind="EditTestStatus.aspx.cs" Inherits="Team2.WebForm11" %>
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
    <div class="container">
        <div class="row">
            <div class="col-lg-offset-5 col-lg-4">
                <h3 style="color:brown"><strong>Edit Test Status</strong></h3>
            </div>
        </div>
    </div>
            <br />
    <div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="vId">Vacancy ID : </label>
  <div class="col-md-3">
      <asp:DropDownList ID="vId" CssClass="form-control" runat="server">
          <asp:ListItem Value="--select--"></asp:ListItem>
      </asp:DropDownList>
          <br />
  </div>
</div>

       <!-- Button (Double) -->
<div class="form-group form-horizontal">
  <label class="col-md-5 control-label" for="submit1"></label>
  <div class="col-md-6">
      <asp:Button ID="submit1" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="Button1_Click"/>
      <br />
      <br />
    </div>
</div>

    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowEditing="GridView2_RowEditing" 
        OnRowUpdating="GridView2_RowUpdating" OnRowCancelingEdit="GridView2_RowCancelingEdit" CssClass="grid" Width="75%" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
           <AlternatingRowStyle BackColor="White" />
           <Columns>
            <asp:TemplateField HeaderText="Candidate ID">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("cpId") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("cpId") %>'></asp:Label>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written Test Date">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("WrittenTestDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Written test status">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("WrittenTestStatus") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="true" AutoPostBack="true" DataTextField="Status1" SelectedValue='<%#Eval("WrittenTestStatus") %>' >
                        <asp:ListItem>approved</asp:ListItem>
                        <asp:ListItem>pending</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Date">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("TechnicalInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Technical Interview Status">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("TechnicalTestStatus") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="true" AutoPostBack="true" DataTextField="Status2" SelectedValue='<%#Eval("TechnicalTestStatus")%>' >
                        <asp:ListItem>approved</asp:ListItem>
                        <asp:ListItem>pending</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview date">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("HRInterviewDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="HR Interview Status">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("HRTestStatus") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList3" runat="server" AppendDataBoundItems="true" AutoPostBack="true" DataTextField="Status3" SelectedValue='<%#Eval("HRTestStatus") %>'>
                        <asp:ListItem>approved</asp:ListItem>
                        <asp:ListItem>pending</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" />
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
</asp:Content>
