<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery-3.0.0.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset-1">
                <div class="row">
                    <h3 class="well">Cadastro de Cliente</h3>
                </div>
                <br />
                <div>
                    Nome do Cliente:
                    <br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder=" Nome Completo" Width="45%" CssClass="form-control"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator
                        ID="requiredNome"
                        runat="server"
                        ControlToValidate="txtNome"
                        ErrorMessage="Por favor, digite seu nome."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>--%>
                    <br />
                    <br />
                </div>
                <div>
                    Endereço do Cliente:
                    <br />
                    <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial Atual" Width="50%" CssClass="form-control"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator 
                    ID="requiredEndereco" 
                    runat="server" 
                    ControlToValidate="txtEndereco" 
                    ErrorMessage="Por favor digite seu endereço" 
                    ForeColor="Red">
                    </asp:RequiredFieldValidator>--%>
                    <br />
                    <br />
                </div>
                <div>
                    Email do Cliente:
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email válido" Width="25%" CssClass="form-control"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator 
                    ID="requiredEmail" 
                    runat="server" 
                    ControlToValidate="txtEmail" 
                    ErrorMessage="Por favor, digite seu e-mail." 
                    ForeColor="Red">
                    </asp:RequiredFieldValidator>--%>
                    <br />
                    <br />
                </div>
                <p>
                    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>
                <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastarCliente" />
                <a href="/Default.aspx" class="btn btn-primary btn-lg">Voltar</a>
            </div>
        </div>
    </form>
</body>
</html>
