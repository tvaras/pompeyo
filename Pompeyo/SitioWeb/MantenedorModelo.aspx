<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenedorModelo.aspx.cs" Inherits="SitioWeb.MantenedorModelo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="row">
    <h1>Modelos</h1>
</div>
<div class="row">
    <div class="table-responsive">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-dark"
            HeaderStyle-CssClass="thead-dark" OnRowDeleting="GridView1_RowDeleting"
            >

            <Columns>
                <asp:BoundField DataField="idModelo" HeaderText="ID" />
                <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                <asp:BoundField DataField="marca" HeaderText="Marca" />
                <asp:BoundField DataField="valor" HeaderText="Valor" />
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
    <asp:Label ID="lblIdMarca" runat="server" Text=""></asp:Label>
  </div>
  <div class="form-group">
    <label for="txtMarca">Marca</label>
    <asp:DropDownList ID="cbMarcas" class="form-control" runat="server" >

    </asp:DropDownList>
  </div>
  <div class="form-group">
    <label for="txtModelo">Modelo</label>
    <asp:TextBox ID="txtModelo" class="form-control" runat="server" placeholder="Ingresar Modelo"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="txtValor">Valor</label>
    <asp:TextBox TextMode="Number" ID="txtValor" class="form-control" runat="server" placeholder="Ingresar Marca"></asp:TextBox>
  </div>
  <div class="form-group">
    <asp:Button ID="btnConfirmar" class="btn btn-primary" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" />
      <br />
    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
  </div>
</asp:Content>