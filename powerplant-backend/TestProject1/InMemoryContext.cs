using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace TestProject1
{
    public class InMemoryContext : PowertPlant.WebApi.Context
    {
        public InMemoryContext() : base(new DbContextOptionsBuilder<PowertPlant.WebApi.Context>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options)
        {
        }
    }
}
