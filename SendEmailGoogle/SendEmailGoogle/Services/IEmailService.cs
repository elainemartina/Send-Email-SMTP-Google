using SendEmailGoogle.DTOs;

namespace SendEmailGoogle.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
