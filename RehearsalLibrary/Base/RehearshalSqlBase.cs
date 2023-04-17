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
        DbSet<IndividualEntry> IndividualEntries;
        DbSet<GroupEntry> GroupEntries;
        DbSet<VocalEntry> VocalEntries;
        DbSet<StudioClient> StudiClients;
        DbSet<StudioGuest> StudiGuests;
        //public RehearshalSqlBase(SqlConnectionStringBuilder sqlConStrBuilder)
        //{
        //    _sqlConStrBuilder = sqlConStrBuilder;
        //}

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
