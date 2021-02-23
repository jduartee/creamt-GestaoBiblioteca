using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace BibliotecaNet.Common
{

    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int Total { get; private set; }
        public int TotalNotFiltered { get { return Total; } }

        public PaginatedList(List<T> rows, int total, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            Total = (int)Math.Ceiling(total / (double)pageSize);

            this.AddRange(rows);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < Total);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, Expression<Func<T, bool>> predicate, int pageIndex, int pageSize)
        {
            var count = await source.Where(predicate).CountAsync();
            var items = await source.Where(predicate).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
