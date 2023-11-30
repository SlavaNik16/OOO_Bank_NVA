using System.ComponentModel;

namespace OOO_Bank_NVA.Models.Enums
{
    public enum RoleType
    {
        /// <summary>
        /// Обычный пользователь - нет привилегий
        /// </summary>
        [Description("Пользователь")]
        User,

        /// <summary>
        /// Администратор - все привилегии
        /// </summary>
        [Description("Админ")]
        Admin,
    }
}
