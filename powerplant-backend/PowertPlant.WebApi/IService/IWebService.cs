using PowertPlant.WebApi.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowertPlant.WebApi.IService
{
    public interface IWebService
    {
        Task<List<ElectroMeter>> getAllElectroMetersAsync();
        
        Task insertElectroMeterAsync(string name);
        Task updateElectroMeterAsync(string name,Guid webid);
        
        Task deleteElectroMeterAsync(Guid webid);
    }
}
