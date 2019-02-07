<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rDestinario.aspx.cs" Inherits="ProyectoCarta.Registros.rDestinario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center">
        <h1 style="font-size: x-large; font-family: 'Agency FB', Times, serif; font: bold;">Registro Destinario</h1>
    </div>
    <div class="form-row justify-content-center">
        <aside class="col-sm-8">
    <div class="form-gruop col-md-12">
        <div class="col-md-8">
            <asp:Label ID="Label2" runat="server" Text="Id:"></asp:Label>
            <asp:TextBox ID="DestinarioIdTextBox" class="form-control col-md-3" Text="0" type="number" runat="server"></asp:TextBox>
            <asp:Button ID="BuscarButton" ValidationGroup="Buscar" class="form-control btn btn-info col-md-2 btn-sm" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
            <asp:RequiredFieldValidator ID="IdRFdValidator" ValidationGroup="Buscar" ControlToValidate="DestinarioIdTextBox" runat="server" ErrorMessage="*" Display="Dynamic" ForeColor="DarkRed"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-gruop col-md-12">
        <label for="NombreTextbox" class="col-md-3 control-label input-sm">Nombre:</label>
        <div class="col-md-8">
            <asp:TextBox ID="NombreTextBox" runat="server" class="form-control input-sm"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CuerpoRFValidator" ValidationGroup="Guardar" ControlToValidate="NombreTextBox" runat="server" ErrorMessage="*" Display="Dynamic" ForeColor="DarkRed"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-gruop col-md-12">
                    <label for="ResibidaTextbox" class="col-md-3 control-label input-sm">Cartas resibida:</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="ResividaTextBox" runat="server" class="form-control input-sm"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RrFValidator" ValidationGroup="Guardar" ControlToValidate="RecibidaTextBox" runat="server" ErrorMessage="*" Display="Dynamic" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RrEValidator" runat="server" ForeColor="DarkRed" ErrorMessage="Por favor solo numeros" ValidationExpression="(^\d*\.?\d*[0-9]+\d*$)|(^[0-9]+\d*\.\d*$)" ValidationGroup="Guardar" ControlToValidate="ResibidaTextBox"></asp:RegularExpressionValidator>
                        <br />
                    </div>
                </div>
            <div class="text-center">
                    <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-secondary btn" OnClick="NuevoButton_Click"  />
                    <asp:Button ID="GuardarButton" ValidationGroup="Guardar" runat="server" Text="Guardar" class="btn btn-success btn" OnClick="GuardarButton_Click" />
                    <asp:Button ID="EliminarButton" ValidationGroup="Eliminar" runat="server" Text="Eliminar" class="btn btn-danger btn" OnClick="EliminarButton_Click" />
                </div>
            </aside>
        </div>

</asp:Content>
