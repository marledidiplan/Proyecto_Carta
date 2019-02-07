<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rCarta.aspx.cs" Inherits="ProyectoCarta.Registros.rCarta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h1 style="font-size: x-large; font-family: 'Agency FB', Times, serif; font: bold;">Registrar tus cartas</h1>
    </div>
    <div class="form-row justify-content-center">
        <aside class="col-sm-8">
            <div class="form-gruop col-md-12">
                <div class="col-md-8">
                    <asp:Label ID="Label2" runat="server" Text="Id:"></asp:Label>
                    <asp:TextBox ID="CartaIdTextBox" class="form-control col-md-3" Text="0" type="number" runat="server"></asp:TextBox>
                    <asp:Button ID="BuscarButton" class="form-control btn btn-info col-md-2 btn-sm" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
                    <asp:RequiredFieldValidator ID="IdRFdValidator" ControlToValidate="CartaIdTextBox" runat="server" ErrorMessage="*" Display="Dynamic" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="form-gruop col-md-12">
                <label for="FechaTextbox" class="col-md-3 control-label input-sm">Fecha:</label>
                <div class="col-md-8">
                    <asp:TextBox ID="FechaTextBox" type="date" runat="server" class="form-control input-sm" ReadOnly="True"></asp:TextBox>
                    <br />
                </div>
                </div>
           <div class="form-gruop col-md-12">
                    <asp:Label ID="DestinarioIdDL" runat="server" Text="Destinario"></asp:Label>
                    <div class="col-md-8">
                        <asp:DropDownList ID="DestinarioDropDownList" class="form-control input-sm" style="font-size:medium" runat="server">

                        </asp:DropDownList>
                        <br />
                    </div>
               </div>
              <div class="form-gruop col-md-12">
                    <label for="CuerpoTextbox" class="col-md-3 control-label input-sm">Cuerpo:</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="CuerpoTextBox" runat="server" class="form-control input-sm"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="CuerpoRFValidator" ValidationGroup="Guardar" ControlToValidate="CuerpoTextBox" runat="server" ErrorMessage="*" Display="Dynamic" ForeColor="DarkRed"></asp:RequiredFieldValidator>
                    </div>
                </div>

            <div class="text-center">
                    <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-secondary btn" OnClick="NuevoButton_Click" />
                    <asp:Button ID="GuardarButton" ValidationGroup="Guardar" runat="server" Text="Guardar" class="btn btn-success btn" OnClick="GuardarButton_Click" />
                    <asp:Button ID="EliminarButton" ValidationGroup="Eliminar" runat="server" Text="Eliminar" class="btn btn-danger btn" OnClick="EliminarButton_Click"/>
                </div>
        </aside>
    </div>


</asp:Content>
