<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="WebTemplate.Repeater" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="striped">
        <thead>
            <tr>
                <th>Currency</th>
                <th>Description</th>
                <th>Bank Note</th>
                <th>Buying Rates	</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rptCustomers" runat="server">
                <ItemTemplate>
                    <%--   <tr>
                        <td>
                            <asp:Label ID="lblCustomerId" runat="server" Text='<%# Eval("CustomerId") %>' />
                        </td>
                        <td>
                            <asp:Label ID="lblContactName" runat="server" Text='<%# Eval("ContactName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="lblCompanyName" runat="server" Text='<%# Eval("CompanyName") %>' />
                        </td>
                    </tr>--%>
                    <tr>
                        <td><%# Eval("ENGAmpText") %></td>
                        <td><%# Eval("AmpText") %></td>
                        <td><%# Eval("RecordCount") %></td>
                        <td><%# Eval("RecordCount") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <ul class="pagination">
        <li class="disabled"><a href="#!"><i class="material-icons">chevron_left</i></a></li>
        <li class="active"><a href="#!">1</a></li>
        <li class="waves-effect"><a href="#!">2</a></li>
        <li class="waves-effect"><a href="#!">3</a></li>
        <li class="waves-effect"><a href="#!">4</a></li>
        <li class="waves-effect"><a href="#!">5</a></li>
        <li class="waves-effect"><a href="#!"><i class="material-icons">chevron_right</i></a></li>
    </ul>
    <ul class="pagination">

        <asp:Repeater ID="rptPager" runat="server">
            <ItemTemplate>
                <li class="<%# LiPaggerClass(Eval("Enabled"), Eval("Text")) %>">
                    <asp:LinkButton ID="lnkPage" runat="server" Text='<%#Eval("Text") %>' CommandArgument='<%# Eval("Value") %>'
                        OnClick="Page_Changed" OnClientClick='<%# !Convert.ToBoolean(Eval("Enabled")) ? "javascript:return false;" : "" %>'></asp:LinkButton></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>