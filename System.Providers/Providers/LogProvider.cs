using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Entities.Logs;

namespace System.Providers
{
    public class LogProvider
    {
        private readonly DbContext _context;

        public LogProvider(DbContext context)
        {
            _context = context;
        }

        public Log GetLogById(int id)
        {
            return _context.Set<Log>().Find(id);
        }

        public IEnumerable<Log> GetAllLogs()
        {
            return _context.Set<Log>().ToList();
        }

        public void UpdateLog(Log log)
        {
            _context.Entry(log).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void InsertLog(Log log)
        {
            _context.Set<Log>().Add(log);
            _context.SaveChanges();
        }
    }
}
