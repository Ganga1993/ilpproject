<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="CreateTA.aspx.cs" Inherits="Team2.WebForm3" %>
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
        <fieldset>
    <div class="container">
        <div class="row">
            <div class="col-lg-offset-5 col-lg-4">
                <h3 style="color:brown"><strong>Create Test Admin</strong></h3>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="form-group form-horizontal">
            <label class="control-label col-md-5" for="vId">Employee ID : </label>
            <div class="col-md-3">
                <asp:DropDownList ID="eId" runat="server" CssClass="form-control input-md" OnSelectedIndexChanged="eId_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem Value="select"></asp:ListItem>
                </asp:DropDownList>
                <br />
            </div>
        </div>
    </div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="40%" CssClass="grid" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Employee Name">
                        <ItemTemplate>
                            <asp:Label ID="lblname" runat="server" Text='<%# Bind("eName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Location">
                        <ItemTemplate>
                            <asp:Label ID="lbllocation" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Experience">
                        <ItemTemplate>
                            <asp:Label ID="lblexperience" runat="server" Text='<%# Bind("eExp") %>'></asp:Label>
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
       <!-- Button (Double) -->
<div class="form-group">
  <label class="col-md-5 control-label" for="submit1"></label>
  <div class="col-md-5">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="Button1_Click" />
  </div>
</div>
            </fieldset>
    </form>
</asp:Content>
