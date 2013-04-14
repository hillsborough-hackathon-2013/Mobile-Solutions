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
    public class saleRepository : ISaleRepository
    {
        HackathonEntity context = new HackathonEntity();

        public IQueryable<sale> All
        {
            get { return context.sales.Where(x=>x.grantee!="").Take(100); }
        }

        public IQueryable<sale> Search(string strap)
        {
            return context.sales.Where(x => x.strap == strap).Take(100);
        }

        public IQueryable<sale> AllIncluding(params Expression<Func<sale, object>>[] includeProperties)
        {
            IQueryable<sale> query = context.sales;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public sale Find(int id)
        {
            return context.sales.Find(id);
        }

        public void InsertOrUpdate(sale sale)
        {
            if (sale.SalesId == default(int)) {
                // New entity
                context.sales.Add(sale);
            } else {
                // Existing entity
                context.Entry(sale).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var sale = context.sales.Find(id);
            context.sales.Remove(sale);
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

    public interface ISaleRepository : IDisposable
    {
        IQueryable<sale> All { get; }
        IQueryable<sale> AllIncluding(params Expression<Func<sale, object>>[] includeProperties);
        IQueryable<sale> Search(string strap);
        sale Find(int id);
        void InsertOrUpdate(sale sale);
        void Delete(int id);
        void Save();
    }
}