using Microsoft.AspNetCore.Identity.UI.Services;

namespace ProtoDEV___Proyecto_Programacion.Models.Utilidades
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
