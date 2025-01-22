using System;

namespace SkyNET.Mail.Contracts.Dto {
    public class MailAddressDto {
        public MailAddressDto(string address, string? displayName) {
            Address = address;
            DisplayName = displayName;
        }

        public string Address { get; set; }
        public string DisplayName { get; }
    }
}