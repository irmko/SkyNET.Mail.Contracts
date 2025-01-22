namespace SkyNET.Mail.Contracts.Services {
    public interface IInfoDto
    {
        string MachineName { get; set; }
        string UserDomainName { get; set; }
        string UserFio { get; set; }
        string UserName { get; set; }
    }
}