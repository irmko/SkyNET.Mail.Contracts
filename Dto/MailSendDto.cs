using System.Collections.Generic;

namespace SkyNET.Mail.Contracts.Dto {
    public class MailMessageSendDto {

        /// <summary>
        /// Возвращает или задает адрес отправителя данного сообщения электронной почты
        /// </summary>
        public MailAddressDto From { get; set; }
        /// <summary>
        /// Возвращает коллекцию адресов, содержащую получателей данного сообщения
        /// </summary>
        public List<MailAddressDto> To { get; set; }
        /// <summary>
        /// Возвращает коллекцию адресов, содержащую получателей скрытой копии (BCC)
        /// </summary>
        public List<MailAddressDto> Bcc { get; set; }
        /// <summary>
        /// Возвращает коллекцию адресов, содержащую получателей копии (CC)
        /// </summary>
        public List<MailAddressDto> Cc { get; set; }
        /// <summary>
        /// Возвращает или задает строку темы
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Возвращает или задает текст сообщения
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Возвращает или задает значение, указывающее, имеет ли текст почтового сообщения
        ///     формат HTML
        /// </summary>
        public bool IsBodyHtml { get; set; }
    }
}
