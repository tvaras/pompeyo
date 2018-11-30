<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Venta.aspx.cs" Inherits="SitioWeb.Venta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1>Ventas</h1>
    </div>
<div class="row">
    <div class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-dark"
            HeaderStyle-CssClass="thead-dark" 
            >
            <Columns>
                <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                <asp:BoundField DataField="marca" HeaderText="Marca" />
                <asp:BoundField DataField="monto" HeaderText="Valor" DataFormatString="${0:###,###,###}" />
                <asp:BoundField DataField="rut" HeaderText="Rut Cliente" />
                <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                <asp:BoundField DataField="usuario" HeaderText="Vendedor" />
            </Columns>
        </asp:GridView>
    </div>
</div>
  <div class="form-group">
    <label for="cbCliente">Cliente</label>
    <asp:DropDownList ID="cbCliente" class="form-control" runat="server" >

    </asp:DropDownList>
  </div>
  <div class="form-group">
    <label for="cbModelo">Modelo</label>
    <asp:DropDownList ID="cbModelo" class="form-control" runat="server" >

    </asp:DropDownList>
  </div>
  <div class="form-group">
    <asp:Button ID="btnConfirmar" class="btn btn-primary" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
      <br />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
  </div>
</asp:Content>
