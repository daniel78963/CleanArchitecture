﻿using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity;
    }
}
