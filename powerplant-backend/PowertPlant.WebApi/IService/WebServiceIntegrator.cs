using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PowertPlant.WebApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowertPlant.WebApi.IService
{

    public class WebServiceIntegrator : IWebService
    {
        private readonly Context _ctx;

        public WebServiceIntegrator(Context ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<ElectroMeter>> getAllElectroMetersAsync()
        {
            return await _ctx.Set<ElectroMeter>().ToListAsync();
        }

        public async Task insertElectroMeterAsync(string name)
        {
            Guid webID = Guid.NewGuid();
            var entity = new ElectroMeter()
            {
                name = name,
                webid = webID
            };
            
           _ctx.Set<ElectroMeter>().Add(entity);
           await _ctx.SaveChangesAsync();
        }

        public async Task updateElectroMeterAsync(string name,Guid webid)
        {
            var entity = _ctx.ElectroMeters.FirstOrDefault(e => e.webid == webid);

            entity.name = name;

            _ctx.Set<ElectroMeter>().Update(entity);
            await _ctx.SaveChangesAsync();
        }

        public async Task deleteElectroMeterAsync(Guid webid)
        {
            var entity = _ctx.ElectroMeters.ToList().FirstOrDefault(e => e.webid == webid);
            _ctx.Set<ElectroMeter>().Remove(entity);
            await _ctx.SaveChangesAsync();
        }

       

    }
}
