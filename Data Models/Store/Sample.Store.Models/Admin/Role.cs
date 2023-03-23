using Sample.Store.Models.Enums;
using Sample.Store.Models.Interfaces;

namespace Sample.Store.Models.Admin;

public class Role :IDatabasePromise
{ 
	public int Id { get; set; }

	public RoleType RoleType { get; set; }
}
