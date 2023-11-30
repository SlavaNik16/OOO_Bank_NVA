using System.ComponentModel;

namespace OOO_Bank_NVA.Enums
{
    public enum StatusType
    {
        /// <summary>
        /// Онлайн
        /// </summary>
        [Description("Онлайн")]
        Online,

        /// <summary>
        /// Офлайн
        /// </summary>
        [Description("Оффлайн")]
        Offline,

        /// <summary>
        /// Заблокирован
        /// </summary>
        [Description("Заблокирован")]
        Blocked,

    }
}
