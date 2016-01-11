<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebTemplate.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Module/jquery-1.12.0.min.js"></script>
    <link href="Module/Login/StyleSheet.css" rel="stylesheet" />
    <script src="Module/Login/JavaScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <hgroup>
                <h1>Material Design Form</h1>
                <h3>By Josh Adamous</h3>
            </hgroup>

            <div class="group">
                <input type="text"><span class="highlight"></span><span class="bar"></span>
                <label>Name</label>
            </div>
            <div class="group">
                <input type="email"><span class="highlight"></span><span class="bar"></span>
                <label>Email</label>
            </div>
            <button type="button" class="button buttonBlue">
                Subscribe

                <div class="ripples buttonRipples"><span class="ripplesCircle"></span></div>
            </button>

            <footer>
                <a href="http://www.polymer-project.org/" target="_blank">
                    <img src="https://www.polymer-project.org/images/logos/p-logo.svg"></a>
                <p>You Gotta Love <a href="http://www.polymer-project.org/" target="_blank">Google</a></p>
            </footer>
        </div>
    </form>
</body>
</html>