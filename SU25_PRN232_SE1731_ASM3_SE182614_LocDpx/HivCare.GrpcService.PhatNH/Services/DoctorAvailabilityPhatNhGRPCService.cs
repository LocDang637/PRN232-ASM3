using Grpc.Core;
using HivCare.GrpcService.PhatNH.Protos;
using HivCare.Services.PhatNH;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HivCare.GrpcService.PhatNH.Services
{
    public class DoctorAvailabilityPhatNhGRPCService : DoctorAvailabilityPhatNhGRPC.DoctorAvailabilityPhatNhGRPCBase
    {
        private readonly IServiceProviders serviceProvider;

        public override async Task<DoctorAvailabilityPhatNhList> GetAllAsync(EmptyRequest request, ServerCallContext context)
        {
            var result = new DoctorAvailabilityPhatNhList();
            try
            {
                var doctorAvailability = await serviceProvider.DoctorAvailabilityService.GetAllAsync();
                var opt = new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };


                var doctorAvailabilityString = JsonSerializer.Serialize(doctorAvailability, opt);


                var items = JsonSerializer.Deserialize<List<DoctorAvailabilityPhatNh>>(doctorAvailabilityString, opt);


                result.Items.AddRange(items);
            }
            catch (Exception ex) { }

            return result;
        }

        public override async Task<DoctorAvailabilityPhatNh> GetByIdAsync(DoctorAvailabilityPhatNhIdRequest request, ServerCallContext context)
        {
            var result = new DoctorAvailabilityPhatNh();
            try
            {
                var doctorAvailability = await serviceProvider.DoctorAvailabilityService.GetGetByIdAsync(request.DoctorAvailabilityPhatNhiD);
                var opt = new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
                var doctorAvailabilityString = JsonSerializer.Serialize(doctorAvailability, opt);
                result = JsonSerializer.Deserialize<DoctorAvailabilityPhatNh>(doctorAvailabilityString, opt);
            }
            catch (Exception ex) { }
            return result;
        }

        public override async Task<MutationResult> CreateAsync(DoctorAvailabilityPhatNh request, ServerCallContext context)
        {
           
            try
            {
                var opt = new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

                var protoJsonString = JsonSerializer.Serialize(request, opt);

                var item = JsonSerializer.Deserialize<HivCare.Repository.PhatNH.Models.DoctorAvailabilityPhatNh>(protoJsonString, opt);

                var result = await serviceProvider.DoctorAvailabilityService.CreateAsync(item);
                return new MutationResult() { Result = result };
            }
            catch (Exception ex)
            {
                
            }
            return new MutationResult() { Result = 0 };
        }

        public override async Task<MutationResult> UpdateAsync(DoctorAvailabilityPhatNh request, ServerCallContext context)
        {
            try
            {
                var opt = new JsonSerializerOptions() { ReferenceHandler = ReferenceHandler.IgnoreCycles, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
                var protoJsonString = JsonSerializer.Serialize(request, opt);
                var item = JsonSerializer.Deserialize<HivCare.Repository.PhatNH.Models.DoctorAvailabilityPhatNh>(protoJsonString, opt);
                var result = await serviceProvider.DoctorAvailabilityService.UpdateAsync(item);
                return new MutationResult() { Result = result };
            }
            catch (Exception ex) { }
            return new MutationResult() { Result = 0 };
        }

        public override async Task<MutationResult> DeleteAsync(DoctorAvailabilityPhatNhIdRequest request, ServerCallContext context)
        {
            try
            {
                var result = await serviceProvider.DoctorAvailabilityService.DeleteAsync(request.DoctorAvailabilityPhatNhiD);
                int temp = result == true ? 1 : 0; // Convert bool to int (1 for true, 0 for false)
                return new MutationResult() { Result = temp };
            }
            catch (Exception ex) { }
            return new MutationResult() { Result = 0 };
        }
    }
}
