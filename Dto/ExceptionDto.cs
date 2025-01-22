using SkyNET.Mail.Contracts.Services;

namespace SkyNET.Mail.Contracts.Dto {
    public class ExceptionDto : IInfoDto {
        public string MachineName { get; set; }
        public string UserDomainName { get; set; }
        public string UserName { get; set; }
        public string UserFio { get; set; }

        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string TargetSite { get; set; }

        public ExceptionDto InnerException { get; set; }
    }
}
