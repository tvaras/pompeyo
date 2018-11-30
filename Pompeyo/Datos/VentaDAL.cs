using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class VentaDAL
    {
        public VentaDTO crear(int idModelo, int idCliente, int monto, int idUsuario)
        {
            Venta entidad = new Venta
            {
                idModelo = idModelo,
                idCliente = idCliente,
                MontoRealCompra = monto,
                fechaCompra = DateTime.Now,
                idUsuario = idUsuario
            };

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidad = dbo.Venta.Add(entidad);
                dbo.SaveChanges();
            }

            return new VentaDTO() {
                idCliente = entidad.idCliente,
                idUsuario = entidad.idUsuario,
                idModelo = entidad.idModelo,
                idVenta = entidad.idVenta,
                monto = entidad.MontoRealCompra,
                fechaCompra = entidad.fechaCompra
            };
        }

        public List<VentaDTO> listar()
        {
            List<VentaDTO> entidades = new List<VentaDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from v in dbo.Venta
                             join c in dbo.Cliente on v.idCliente equals c.idCliente
                             join u in dbo.Usuario on v.idUsuario equals u.idUsuario
                             join m in dbo.Modelo on v.idModelo equals m.idModelo
                             join ma in dbo.Marca on m.idMarca equals ma.idMarca
                             select new VentaDTO()
                             {
                                 rut = c.rut,
                                 cliente = c.nombre,
                                 idCliente = c.idCliente,
                                 idUsuario = u.idUsuario,
                                 usuario = u.nombre,
                                 idModelo = m.idModelo,
                                 modelo = m.nombre,
                                 marca = ma.nombre,
                                 monto = v.MontoRealCompra,
                                 idVenta = v.idVenta,
                                 fechaCompra = v.fechaCompra
                             }
                             ).ToList<VentaDTO>();
            }

            return entidades;
        }

        public VentaDTO buscar(int id)
        {
            VentaDTO entidad = new VentaDTO();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidad = (from v in dbo.Venta
                           join c in dbo.Cliente on v.idCliente equals c.idCliente
                           join u in dbo.Usuario on v.idUsuario equals u.idUsuario
                           join m in dbo.Modelo on v.idModelo equals m.idModelo
                           join ma in dbo.Marca on m.idMarca equals ma.idMarca
                           where v.idVenta == id
                           select new VentaDTO() {
                               rut = c.rut,
                               cliente = c.nombre,
                               idCliente = c.idCliente,
                               idUsuario = u.idUsuario,
                               usuario = u.nombre,
                               idModelo = m.idModelo,
                               modelo = m.nombre,
                               marca = ma.nombre,
                               monto = v.MontoRealCompra,
                               idVenta = v.idVenta,
                               fechaCompra = v.fechaCompra
                           }).First<VentaDTO>();
            }

            return entidad;
        }

        public List<VentaDTO> listarDTO()
        {
            List<VentaDTO> entidades = new List<VentaDTO>();

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                entidades = (from v in dbo.Venta
                                join c in dbo.Cliente on v.idCliente equals c.idCliente
                                join u in dbo.Usuario on v.idUsuario equals u.idUsuario
                                join m in dbo.Modelo on v.idModelo equals m.idModelo
                                join ma in dbo.Marca on m.idMarca equals ma.idMarca
                             select new VentaDTO
                             {
                                 rut = c.rut,
                                 cliente = c.nombre,
                                 idCliente = c.idCliente,
                                 idUsuario = u.idUsuario,
                                 usuario = u.nombre,
                                 idModelo = m.idModelo,
                                 modelo = m.nombre,
                                 marca = ma.nombre,
                                 monto = v.MontoRealCompra,
                                 idVenta = v.idVenta,
                                 fechaCompra = v.fechaCompra

                             }).ToList<VentaDTO>();
            }

            return entidades;
        }

        public bool eliminar(VentaDTO v)
        {
            Venta entidad = new Venta
            {
                idModelo = v.idModelo,
                idCliente = v.idCliente,
                MontoRealCompra = v.monto,
                fechaCompra = DateTime.Now,
                idUsuario = v.idUsuario
            };

            using (PompeyoCarrascoEntities dbo = new PompeyoCarrascoEntities())
            {
                dbo.Venta.Attach(entidad);
                entidad = dbo.Venta.Remove(entidad);
                dbo.SaveChanges();
                return true;
            }
        }
    }
}
