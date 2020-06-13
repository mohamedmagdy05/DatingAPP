using DatingApp.Domain.Entities;
using DatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingAPP.Persistence.Repository
{
    public class ValueRepository:IValueRepository
    {
        private DatingAppContext _ctx;
        public ValueRepository(DatingAppContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Value> GetAllValues()
        {
            return _ctx.Values.ToList();
        }
    }
}
