using System.ComponentModel;

namespace OOO_Bank_NVA.Enums
{
    public enum StatusType
    {
        /// <summary>
        /// Офлайн
        /// </summary>
        [Description("Оффлайн")]
        Offline,

        /// <summary>
        /// Онлайн
        /// </summary>
        [Description("Онлайн")]
        Online,

        /// <summary>
        /// Заблокирован
        /// </summary>
        [Description("Заблокирован")]
        Blocked,

    }
}
