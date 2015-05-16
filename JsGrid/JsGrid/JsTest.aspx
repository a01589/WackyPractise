<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JsTest.aspx.cs" Inherits="JsGrid.JsTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border-collapse:collapse; width:500px" border="1">
<tr>
<td>1</td>
<td>2</td>
<td>3</td>
<td>4</td>
<td>5</td>
</tr>
<tr>
<td rowspan="3">6</td>
<td rowspan="3">7</td>
<td>8</td>
<td>9</td>
<td>10</td>
</tr>
<tr>
<td>11</td>
<td>12</td>
<td>13</td>
</tr>
<tr>
<td>14</td>
<td>15</td>
<td>16</td>
</tr>
<tr>
<td>17</td>
<td colspan="4">18</td>
</tr>
</table>
    </div>
    </form>
</body>
</html>
