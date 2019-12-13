using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.Contexts
{
    public class TezContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=94.73.146.5;Initial Catalog=TezDB;Persist Security Info=True;User ID=canberk;Password=AlperSenturk1998");
        }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> tblKullanici { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Cozum> tblCozum { get; set; }
        public DbSet<CozumPuan> tblCozumPuan { get; set; }
        public DbSet<Etkinlik> tblEtkinlik { get; set; }
        public DbSet<EtkinlikKatilim> tblEtkinlikKatilim { get; set; }
        public DbSet<Hata> tblHata { get; set; }
        public DbSet<Ilan> tblIlan { get; set; }
        public DbSet<IlanBasvuru> tblIlanBasvuru { get; set; }
      
    }
}
