using Sample.Store.Models.Enums;
using Sample.Store.Models.Interfaces;
using Sample.Store.Models.Payments;

namespace Sample.Store.Models.Admin;

public class User : IDatabasePromise
{
	public int Id { get; set; }
	public string? Suffix { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? Email { get; set; }
	public string? MobilePhone { get; set; }
	public string? FullName { get; set; }
	public List<Role>? Roles { get; set; }
	public string? Street { get; set; }
	public string? Street2 { get; set; }
	public string? City { get; set; }
	public StateEnum State { get; set; }
	public string? Zipcode { get; set; }
	public string? County { get; set; }
	public CountryEnum Country { get; set; }
	public List<Payment>? Payments { get; set; }
	public List<Order>? Orders { get; set; }
}

public class Order : IDatabasePromise
{
	public int Id { get; set; }

	public Guid OrderGuid { get; set; }

	public DateOnly OrderDate { get; set; }

	public int PaymentId { get; set; }
	public Payment? Payment { get; set; }

	public int UserId { get; set; }

	public User? User { get; set; }

	public decimal Total { get; set; }

	public decimal TotalBeforeTax { get; set; }

	public decimal Tax { get; set; }

	public List<OrderLine>? OrderLines { get; set; }
}

public class OrderLine : IDatabasePromise
{
	public int Id { get; set;}

	public int OrderId { get; set; }
	public Order? Order { get; set; }

}

public class Tax : IDatabasePromise
{
	public int Id { get; set; }

	public decimal Amount { get; set; }

	public StateEnum State { get; set; }
}
