<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="MedicalStatus.aspx.cs" Inherits="Team2.WebForm20" %>
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
     <form class="form-horizontal">
    <div class="container">
        <div class="form-group form-horizontal">
            <label class="control-label col-md-5" for="vId">vacancy ID : </label>
            <div class="col-md-3">
                <asp:DropDownList ID="vId" runat="server" CssClass="form-control input-md">
                    <asp:ListItem Value="select"></asp:ListItem>
                </asp:DropDownList>
                <br />
            </div>
        </div>
        </div>
        <div class="form-group">
  <label class="col-md-5 control-label" for="submit1"></label>
  <div class="col-md-5">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="Button1_Click" />     
  </div>
</div>
      <br />
    <asp:GridView runat="server" ID="gridview1" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" 
        CssClass="grid" Width="75%" OnRowUpdating="gridview1_RowUpdating" OnRowCancelingEdit="gridview1_RowCancelingEdit" OnRowEditing="gridview1_RowEditing">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Candidate ID" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblname" runat="server" Text='<%# Bind("cPId") %>'></asp:Label>
                </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
                <asp:TemplateField HeaderText="Vacancy Id" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lbllocation" runat="server" Text='<%# Bind("vId") %>'></asp:Label>
                </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Candidate Name" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lbldesign" runat="server" Text='<%# Bind("cName") %>'></asp:Label>
                </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Test Id" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <asp:Label ID="lblexperience" runat="server" Text='<%# Bind("cTestId") %>'></asp:Label>
                </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Medical status" HeaderStyle-HorizontalAlign="Left">
                <EditItemTemplate >
                    <asp:TextBox ID="txtexperience1" runat="server" Text='<%# Bind("cMedicalStatus") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtnewexperience1" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblexperience1" runat="server" Text='<%# Bind("cMedicalStatus") %>'></asp:Label>
                </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
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
        </form>
</asp:Content>
