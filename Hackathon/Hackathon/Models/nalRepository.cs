using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Hackathon.DomainModel;

namespace Hackathon.Models
{ 
    public class nalRepository : INalRepository
    {
        HackathonEntity context = new HackathonEntity();

        public IQueryable<nal> All
        {
            get { return context.nals.Take(100);  }
        }

        public IQueryable<nal> Search(string name,string address)
        {
            if (address==string.Empty)
            {
                address = "doug";
            }
            if (name == string.Empty)
            {
                address = "doug";
            }
            return context.nals.Where(x => x.owner1 == name || x.m_addr_1 == address);
        }

        public IQueryable<nal> AllIncluding(params Expression<Func<nal, object>>[] includeProperties)
        {
            IQueryable<nal> query = context.nals;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public nal Find(int id)
        {
            return context.nals.Find(id);
        }

        public void InsertOrUpdate(nal nal)
        {
            if (nal.nalId == default(int)) {
                // New entity
                context.nals.Add(nal);
            } else {
                // Existing entity
                context.Entry(nal).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var nal = context.nals.Find(id);
            context.nals.Remove(nal);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }

    public interface INalRepository : IDisposable
    {
        IQueryable<nal> All { get; }
        IQueryable<nal> AllIncluding(params Expression<Func<nal, object>>[] includeProperties);
        nal Find(int id);
        IQueryable<nal> Search(string name, string address);
        void InsertOrUpdate(nal nal);
        void Delete(int id);
        void Save();
    }
}