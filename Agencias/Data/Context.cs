using Agencias.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agencias.Data
{
    public class Context:DbContext
    {
        private readonly string strConn;

        public Context(string strConn)
        {
            this.strConn = strConn;
        }
        public Context()
        {
            this.strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joao.silva\Documents\Alura\ByteBank\Agencias\Data\ByteBank.mdf;Integrated Security=True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(strConn);
        }
        public virtual DbSet<Agencia> Agencia { get; set; }
    }
}
