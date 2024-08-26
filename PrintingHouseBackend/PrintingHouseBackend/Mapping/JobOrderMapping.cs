using PrintingHouseBackend.Dtos.JobOrderDtos;
using PrintingHouseBackend.Models;

namespace PrintingHouseBackend.Mapping;

public static class JobOrderMapping
{
    public static List<JobOrderSummaryDto> ToJobOrdersSummaryDto(this List<JobOrder> jobOrders)
    {
        List<JobOrderSummaryDto> jobOrdersDto = jobOrders.Select(i => new JobOrderSummaryDto(
            i.Id,
            $"{i.Customer!.Name} {i.Customer.Surname}",
            i.JobDetails!.Name,
            i.OrderDate,
            i.Status)).ToList();

        return jobOrdersDto;
    }

    public static JobOrderSummaryDto ToJobOrderSummaryDto(this JobOrder jobOrder)
    {
        string customerName = $"{jobOrder.Customer!.Name} {jobOrder.Customer.Surname}";

        return new JobOrderSummaryDto(
            jobOrder.Id,
            customerName,
            jobOrder.JobDetails!.Name,
            jobOrder.OrderDate,
            jobOrder.Status
            );
    }

    public static JobOrder ToEntity(this CreateJobOrderDto jobOrder)
    {
        return new JobOrder()
        {
            CustomerId = jobOrder.CustomerId,
            Customer = jobOrder.Customer,
            JobDetailsId = jobOrder.JobDetailsId,
            JobDetails = jobOrder.JobDetails,
            OrderDate = jobOrder.OrderDate,
            Status = jobOrder.Status
        };
    }

    public static JobOrder ToEntity(this UpdatedJobOrderDto jobOrder, int id)
    {
        return new JobOrder()
        {
            Id = id,
            CustomerId = jobOrder.CustomerId,
            Customer = jobOrder.Customer,
            JobDetailsId = jobOrder.JobDetailsId,
            JobDetails = jobOrder.JobDetails,
            OrderDate = jobOrder.OrderDate,
            Status = jobOrder.Status
        };
    }
}
