namespace BTCPayApp.Core.Models;

public class AppUserInfoResult
{
    public string UserId { get; set; }
    public string Email { get; set; }
    public IEnumerable<string> Roles { get; set; }
    public IEnumerable<AppUserStoreInfo> Stores { get; set; }
}

public class AppUserStoreInfo
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string RoleId { get; set; }
    public bool Archived { get; set; }
    public IEnumerable<string> Permissions { get; set; }
}
