using Sample.Store.Models.Interfaces;

namespace Sample.Store.Models.Payments;

public class Payment : IDatabasePromise
{
    public int Id { get; set; }

    public Guid PaymentGuid { get; set; }

}
