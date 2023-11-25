using OOO_Bank_NVA.Enums;

namespace OOO_Bank_NVA.Models
{
    /// <summary>
    /// Сущность хранение данных в банке
    /// </summary>
    public class DBBank : BaseAuditEntity
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Статус пользователя
        /// </summary>
        public StatusType StatusType { get; set; }  
    }
}
