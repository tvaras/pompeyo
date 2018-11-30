<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Informe.aspx.cs" Inherits="SitioWeb.Informe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="row">
    <h1>Informe de Ventas</h1>
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
                <asp:BoundField DataField="fechaCompra" HeaderText="Fecha Compra" DataFormatString="{0:dd/MM/yyyy}" />
            </Columns>
        </asp:GridView>
    </div>
</div>  
</asp:Content>