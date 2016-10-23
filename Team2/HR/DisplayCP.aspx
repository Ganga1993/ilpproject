<%@ Page Title="" Language="C#" MasterPageFile="~/HR.Master" AutoEventWireup="true" CodeBehind="DisplayCP.aspx.cs" Inherits="Team2.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .grid {
            text-align:center;
            margin-left:auto;
            margin-right:auto;
            margin-top: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Height="106px" OnPageIndexChanging="GridView2_PageIndexChanging" 
             ShowFooter="False" AllowPaging="true" PageSize="4" PageIndex="0" EnableTheming="False" Width="75%" CssClass="grid">
            <Columns>
                <asp:TemplateField HeaderText="Candidate profile id" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("cPId") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="candidate name"  HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("cName") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DOB" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("cDob") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Location" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("cLocation") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("cGender") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="10th Percentage" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("cPTenth") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="12th percentage" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("cPTwelth") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Experience Years" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label14" runat="server" Text='<%# Eval("cExperience") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Resume" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label15" runat="server" Text='<%# Eval("cResume") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test Id" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label16" runat="server" Text='<%# Eval("cTestId") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test status" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label17" runat="server" Text='<%# Eval("cTestStatus") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Medical status" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label18" runat="server" Text='<%# Eval("cMedicalStatus") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BGC testid" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label19" runat="server" Text='<%# Eval("cBGCTestId") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BGC teststatus" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <asp:Label ID="Label20" runat="server" Text='<%# Eval("cBGCTestStatus") %>'></asp:Label>
                    </ItemTemplate>
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
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
            <PagerSettings FirstPageText="First" LastPageText="Last" NextPageText="Next" PageButtonCount="1" PreviousPageText="Previous" Mode="NextPrevious" />
        </asp:GridView>   
</asp:Content>
