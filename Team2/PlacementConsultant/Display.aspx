<%@ Page Title="" Language="C#" MasterPageFile="~/PlacementConsultant.Master" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="Team2.WebForm1" %>
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
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="106px" OnPageIndexChanging="GridView1_PageIndexChanging" 
             ShowFooter="false" CssClass="grid" AllowPaging="True" AllowSorting="true" 
         PageIndex="0" PageSize="4" Width="75%" >
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
            <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPrevious" NextPageText="Next" PageButtonCount="1" PreviousPageText="Previous" />
        </asp:GridView>   
</asp:Content>
