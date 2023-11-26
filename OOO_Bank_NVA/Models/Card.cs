﻿using System;
using System.Collections.Generic;

namespace OOO_Bank_NVA.Models
{
    /// <summary>
    /// Сущность карты на котором хранятся средства
    /// </summary>
    public class Card : BaseAuditEntity
    {
        /// <summary>
        /// Номер карты
        /// </summary>
        public string Nomer { get; set; }

        /// <summary>
        /// CSC код
        /// </summary>
        public int CSCCode { get; set; }

        /// <summary>
        /// Баланс карты
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Пин код
        /// </summary>
        public string PinCode { get; set; } = null;

        /// <summary>
        /// Владелец карты
        /// </summary>
        public Guid PersonId { get; set; }
        internal Person Person { get; set; }

        internal ICollection<Operation> Operation { get; set; }

    }
}
