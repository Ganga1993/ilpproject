<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="DeleteTA.aspx.cs" Inherits="Team2.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .grid
        {
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
                <h3 style="color:brown"><strong>Delete Test Admin</strong></h3>
            </div>
        </div>
    </div>
     <asp:GridView runat="server" Width="75%" ID="gridview1" AutoGenerateColumns="False" OnRowDeleting="gridview1_RowDeleting" CssClass="grid" CellPadding="4" ForeColor="#333333" GridLines="None">
         <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Employee ID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("eId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                <EditItemTemplate >
                    <asp:TextBox ID="txtname" runat="server" Text='<%# Bind("eName") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtnewname" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblname" runat="server" Text='<%# Bind("eName") %>'></asp:Label>
                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Location" HeaderStyle-HorizontalAlign="Center">
                <EditItemTemplate >
                    <asp:TextBox ID="txtlocation" runat="server" Text='<%# Bind("Location") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtnewlocation" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="lbllocation" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            </asp:TemplateField>
                        <asp:TemplateField HeaderText="Experience" HeaderStyle-HorizontalAlign="Center">
                <EditItemTemplate >
                    <asp:TextBox ID="txtexperience" runat="server" Text='<%# Bind("eExp") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtnewexperience" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblexperience" runat="server" Text='<%# Bind("eExp") %>'></asp:Label>
                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete" HeaderStyle-HorizontalAlign="Center">
                <EditItemTemplate >  
                   <asp:HiddenField ID="hdnid1" runat="server" Value='<%# Eval("eId") %>' />                 
                   <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete"></asp:LinkButton> 
                </EditItemTemplate>
                <FooterTemplate>            
                </FooterTemplate>
                <ItemTemplate>
                    <asp:HiddenField ID="hdnid1" runat="server" Value='<%# Eval("eId") %>' />   
                   <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete"></asp:LinkButton>                                      
                </ItemTemplate>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
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
</asp:Content>
