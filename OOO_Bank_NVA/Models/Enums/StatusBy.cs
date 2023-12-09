using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
