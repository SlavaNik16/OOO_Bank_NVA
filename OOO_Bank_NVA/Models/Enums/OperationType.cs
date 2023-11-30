using System.ComponentModel;

namespace OOO_Bank_NVA.Enums
{
    /// <summary>
    /// Типы операций
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Пополнения счета
        /// </summary>
        [Description("Пополнение")]
        Add,

        /// <summary>
        /// Снятие со счета
        /// </summary>
        [Description("Снятие")]
        TakeOff,

        /// <summary>
        /// Перевод средств на другую карту
        /// </summary>
        [Description("Перевод")]
        Translation,

        /// <summary>
        /// Покупка
        /// </summary>
        [Description("Покупка")]
        By,


    }
}
