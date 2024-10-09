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
            i.Quantity,
            i.TotalPrice,
            i.Status,
            i.DeliveryMethod,
            i.CustomerNote)).ToList();

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
            jobOrder.Quantity,
            jobOrder.TotalPrice,
            jobOrder.Status,
            jobOrder.DeliveryMethod,
            jobOrder.CustomerNote
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
            Quantity = jobOrder.Quantity,
            TotalPrice = jobOrder.TotalPrice,
            Status = jobOrder.Status,
            DeliveryMethod = jobOrder.DeliveryMethod,
            CustomerNote = jobOrder.CustomerNote
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
            Quantity = jobOrder.Quantity,
            TotalPrice = jobOrder.TotalPrice,
            Status = jobOrder.Status,
            DeliveryMethod = jobOrder.DeliveryMethod,
            CustomerNote = jobOrder.CustomerNote
        };
    }
}