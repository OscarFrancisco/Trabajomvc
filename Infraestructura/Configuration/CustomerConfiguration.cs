using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura;
using Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Infraestructura.Configuration
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            this.Property(x => x.Id).IsRequired();
            this.Property(x => x.Nombre).HasMaxLength(50).IsRequired();
            this.Property(x => x.Telefono).HasMaxLength(10).IsRequired();
            this.Property(x => x.Correo).HasMaxLength(50).IsRequired();
            this.Property(x => x.NombreUsuario).HasMaxLength(50).IsRequired();
        }
    }
}
