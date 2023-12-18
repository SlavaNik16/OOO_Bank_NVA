namespace OOO_Bank_NVA.Models
{
    public class Tovar : BaseAuditEntity
    {
        /// <summary>
        /// Название товара или услуги
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Цена за 1
        /// </summary>
        public decimal Price { get; set; } = 0;

        /// <summary>
        /// Максимальное Кол-во
        /// </summary>
        public int MaxCount { get; set; } = 1;

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Фото
        /// </summary>
        public string Photo { get; set; } = string.Empty;

    }
}
