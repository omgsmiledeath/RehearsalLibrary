using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RehearsalLibrary.Entities;
using RehearsalLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehearsalLibrary.Base
{
    public class RehearshalSqlBase : DbContext, IRehearshalBase
    {
        private SqlConnectionStringBuilder _sqlConStrBuilder;
        public DbSet<IndividualEntry> IndividualEntries { get; set; }
        public DbSet<GroupEntry> GroupEntries { get; set; }
        public DbSet<VocalEntry> VocalEntries { get; set; }
        public DbSet<StudioClient> StudioClients { get; set; }
        public DbSet<StudioGuest> StudioGuests { get; set; }
        //public RehearshalSqlBase(SqlConnectionStringBuilder sqlConStrBuilder)
        //{
        //    _sqlConStrBuilder = sqlConStrBuilder;
        //}
        public RehearshalSqlBase()
        {
    
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer((@"Server=(localdb)\mssqllocaldb;Database=RehearsalDb;Trusted_Connection=True;"));
        }

        public void AddNewClient(IRehearsalClient client)
        {
            throw new NotImplementedException();
        }

        public void AddNewEntry(IEntry entry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRehearsalClient> GetAllClient()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEntry> GetAllEntries()
        {
            throw new NotImplementedException();
        }
    }
}
