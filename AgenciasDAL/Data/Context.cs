using AgenciasDAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciasDAL.Data
{
    public class Context:DbContext
    {
        private readonly string _strConn;
        public DbSet<Agencia> Agencia { get; set; }
        public Context()
        {
            this._strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joao.silva\Documents\Alura\ByteBank\AgenciasDAL\ByteBankData.mdf;Integrated Security=True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_strConn);
        }
    }
}
