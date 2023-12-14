namespace OOO_Bank_NVA.ModelsResponce
{
    /// <summary>
    /// Класс вывода корзины
    /// </summary>
    public class BasketResponce
    {
        /// <summary>
        /// Название товара или услуги
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Кол-во данного товара
        /// </summary>
        public int Count { get; set; } = 1;

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер карты пользователя
        /// </summary>
        public string CardName { get; set; }
    }
}
