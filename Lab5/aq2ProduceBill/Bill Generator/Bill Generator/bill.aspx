<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bill.aspx.cs" Inherits="Bill_Generator.bill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AQ2 ~ Bill Generator</title>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="row m-5 justify-content-center">
            <div class="card shadow" style="width: 25em;">
                <div class="card-body">
                    <h4 class="card-title display-4">Here's your Bill</h4>
                    <hr />
                    <table class="table table-bordered table-hover shadow" id="master_table" runat="server">

                        <thead class="thead-dark">
                            <tr>
                                <th scope="col">#</th>
                                <th scope="col">Item</th>
                                <th scope="col">Quantity</th>
                                <th scope="col">Price</th>
                            </tr>
                        </thead>

                        <tbody>
                            <tr>
                                <th scope="row">1</th>
                                <td id="mn" runat="server">Mark</td>
                                <td id="qt" runat="server">Otto</td>
                                <td id="price" runat="server">@mdo</td>
                            </tr>
                            <tr>
                                <th colspan="3" scope="row" >Total</th>
                                <td id="total_qt" runat="server">-</td>
                            </tr>
                        </tbody>

                    </table>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
