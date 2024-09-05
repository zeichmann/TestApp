<%@ Page Title="Csv Test Parsing" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CsvParsing.aspx.cs" Inherits="TestApp.CsvParsing" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <br /><br />
            <div>
                <asp:GridView ID="CsvData" runat="server" AutoGenerateColumns="true">
                </asp:GridView>
            </div>
    </main>
</asp:Content>
