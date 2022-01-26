using Microsoft.EntityFrameworkCore;
using PowertPlant.WebApi.IService;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class WebServiceIntegratorTests
    {
        [Fact]
        public async Task insertElectroMeterAsync_ShouldInsertDatabase()
        {
            var context = new InMemoryContext();
            var service = new WebServiceIntegrator(context);

            await service.insertElectroMeterAsync("test1");

            var entity = await context.ElectroMeters.FirstOrDefaultAsync();
            Assert.NotNull(entity);
            Assert.Equal("test1", entity.name);
        }
    }
}
