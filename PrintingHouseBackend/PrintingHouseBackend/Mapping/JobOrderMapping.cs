using PrintingHouseBackend.Dtos;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Mapping;

public static class JobOrderMapping
{
    public static JobOrderDto ToJobOrderDto(this JobOrder jobOrder)
    {
        return new JobOrderDto
        {
            CustomerName = $"{jobOrder.Customer.Name} {jobOrder.Customer.Surname}",
            JobName = jobOrder.JobDetails.Name,
            OrderDate = jobOrder.OrderDate,
            Status = jobOrder.Status
        };
    }
}
