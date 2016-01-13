<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebFormTest.aspx.cs" Inherits="WebTemplate.WebFormTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col s12">
        <div class="row">
            <div class="input-field col s12">
                <asp:TextBox ID="txtAmpBangkokIndex" CssClass="validate" runat="server"></asp:TextBox>
                <label for=" <%= txtAmpBangkokIndex.ClientID %> ">AmpBangkokIndex </label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s12">
                <asp:TextBox ID="txtAmpText" CssClass="validate" runat="server"></asp:TextBox>
                <label for=" <%= txtAmpText.ClientID %> ">AmpText </label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s12">
                <asp:TextBox ID="txtENGAmpText" CssClass="validate" runat="server"></asp:TextBox>
                <label for=" <%= txtENGAmpText.ClientID %> ">ENGAmpText </label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s12">
                <asp:TextBox ID="txtZoneID" CssClass="validate" runat="server"></asp:TextBox>
                <label for=" <%= txtZoneID.ClientID %> ">ZoneID </label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s12">
                <asp:TextBox ID="txtrowguid" CssClass="validate" runat="server"></asp:TextBox>
                <label for=" <%= txtrowguid.ClientID %> ">rowguid </label>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s12">
                <asp:TextBox ID="txtmsrepl_tran_version" CssClass="validate" runat="server"></asp:TextBox>
                <label for=" <%= txtmsrepl_tran_version.ClientID %> ">msrepl_tran_version </label>
            </div>
        </div>

        <div class="row">
            <div class="input-field col s12">
                <asp:LinkButton ID="btnOk" CssClass="waves-effect waves-light btn" runat="server" OnClick="btnOk_Click"><i class="material-icons left">cloud</i> Save</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>