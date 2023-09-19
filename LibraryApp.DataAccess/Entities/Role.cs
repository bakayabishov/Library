using Microsoft.AspNetCore.Authorization;

namespace LibraryApp.DataAccess.Entities;
public enum Role { Administrator, Manager, User };

public class AuthorizedAttribute : AuthorizeAttribute {

    public AuthorizedAttribute(params Role[] roles) : base() {

        Roles = String.Join(",", Enum.GetNames(typeof(Role)));

    }
}