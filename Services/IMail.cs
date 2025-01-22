using SkyNET.Mail.Contracts.Dto;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SkyNET.Mail.Contracts.Services {
    public interface IMail {
        Task<ExceptionDto> SendMailFromRobotToRazrabAsync(ExceptionDto exc);
        Task<Guid> SendMailFromRobotToRazrabAsync(string body);

        bool SendMail(MailMessageSendDto msg, out SmtpException exc);
        Task<bool> SendMailAsync(MailMessageSendDto msg, out SmtpException exc);

        bool SendMail(MailAddressCollection to, string subject, string body, out SmtpException exc, MailAddressCollection cc = null);
        Task<bool> SendMailAsync(MailAddressCollection to, string subject, string body, out SmtpException exc, MailAddressCollection cc = null);
        Task<Guid> SaveMailAsync(MailMessage mail, string exception);
    }
}
