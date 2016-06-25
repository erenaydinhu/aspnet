<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>


    
    <div>
    <svg>
  <text x="0" y="15" > <%= Request.QueryString["fname"] %>  </text>
   </svg>
    </div>

</body>
</html>
