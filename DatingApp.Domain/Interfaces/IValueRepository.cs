using DatingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Domain.Interfaces
{
    public interface IValueRepository
    {
        IEnumerable<Value> GetAllValues();
    }
}
