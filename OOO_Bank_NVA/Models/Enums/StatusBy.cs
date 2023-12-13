using System.ComponentModel;

namespace OOO_Bank_NVA.Models.Enums
{
    /// <summary>
    /// Статус оплаты
    /// </summary>
    public enum StatusBy
    {
        [Description("В ожидании оплаты")]
        Attendant,
        [Description("Оплачено")]
        By,

    }
}
