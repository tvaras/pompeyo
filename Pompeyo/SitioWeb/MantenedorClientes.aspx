<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorClientes.aspx.cs" Inherits="SitioWeb.MantenedorClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h1>Clientes</h1>
    </div>
<div class="row">
    <div class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-dark"
            HeaderStyle-CssClass="thead-dark" OnRowDeleting="GridView1_RowDeleting"
            >

            <Columns>
                <asp:BoundField DataField="rut" HeaderText="RUT" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="direccion" HeaderText="Dirección" />
                <asp:BoundField DataField="giro" HeaderText="Giro" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkdel" runat="server" Text="Eliminar" CommandName="Delete"></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle Width="100px" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</div>
  <div class="form-group">
    <label for="txtRut">Rut</label>
      <asp:TextBox ID="txtRut" class="form-control" runat="server" placeholder="12345678-k"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="txtNombre">Nombre</label>
    <asp:TextBox ID="txtNombre" class="form-control" runat="server" placeholder="Ingresar Nombre"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="txtDireccion">Dirección</label>
    <asp:TextBox ID="txtDireccion" class="form-control" runat="server" placeholder="Ingresar Direccion"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="cbGiro">Giro</label>
    <asp:DropDownList ID="cbGiro" class="form-control" runat="server" >

    </asp:DropDownList>
  </div>
  <div class="form-group">
    <asp:Button ID="btnConfirmar" class="btn btn-primary" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
      <br />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
  </div>
</asp:Content>
