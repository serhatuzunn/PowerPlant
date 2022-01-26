using PowertPlant.WebApi;
using PowertPlant.WebApi.Entity;
using PowertPlant.WebApi.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerPlantMock.WebApi.Hangfire
{
    public class HangService : IHangService
    {
        private readonly Context _ctx;

        public class responseModel
        {
            public string message { get; set; }
            public bool success { get; set; }
        }

        public HangService(Context ctx)
        {
            _ctx = ctx;
        }

        public async Task<responseModel> updateDataFromWebService()
        {
            string defaultWebId = "c207d027-32fd-458b-b244-767be79507f9";

            Random rng = new Random();
            int randomNumber = rng.Next(0, 100);

            responseModel respModel = new responseModel();
            if (randomNumber > 30) {
                await updateTimedValueAsync(Guid.Parse(defaultWebId), randomNumber);
                respModel.message = "Success";
                respModel.success = true;
            }
            else
            {
                respModel.message = "Error";
                respModel.success = false;
            }

            return respModel;
        }

        public async Task updateTimedValueAsync(Guid webid, int value)
        {
            var entity = _ctx.TimedValues.FirstOrDefault(e => e.webid == webid);

            entity.value = value;

            await _ctx.SaveChangesAsync();
        }
    }
}
