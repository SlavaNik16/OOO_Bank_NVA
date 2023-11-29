using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Models.Enums;

namespace OOO_Bank_NVA.Models
{
    /// <summary>
    /// Сущность хранение данных в банке
    /// </summary>
    public class DBBank : BaseAuditEntity
    {
        /// <summary>
        /// Логин пользователя (телефон)
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Права пользователя
        /// </summary>
        public RoleType Role { get; set; } = RoleType.User;

        /// <summary>
        /// Статус пользователя
        /// </summary>
        public StatusType Status { get; set; } = StatusType.Offline;
    }
}
