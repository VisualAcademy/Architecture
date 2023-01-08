﻿namespace Application.Common.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(
            string email,
            string subject,
            string message,
            bool isBodyHtml = true);
    }
}
