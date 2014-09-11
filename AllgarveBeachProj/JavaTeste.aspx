<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JavaTeste.aspx.cs" Inherits="AllgarveBeach.JavaTeste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script src="JavaScript.js"></script>
    <form id="form1" runat="server">
    <div>

        
        <table style="border:1px solid; ">
            <tr>
                <td><button type="button" onclick="Time()">Date</button></td>
                <td>
                    <p id="Time"></p></td>
            </tr>
            <tr>
                <td><button type="button" onclick="Hello()">Click Me</button></td>
                <td>
                    <p id="Hello">Olá JavaScript!</p></td>
            </tr>
            <tr>
                <td>
                    <button type="button" onclick="Font()">Change Font</button>
                </td>
                <td>
                    <p id="Font">JavaScript can change the style of an HTML element.</p>
                </td>
            </tr>
            <tr>
                <td>
                    Input a number between 1 and 10: <input id="texto" type="text" /><br />
                    <button type="button" onclick="Submit()">Submit</button>
                </td>
                <td>
                    <p id="rtexto"></p>
                </td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
