using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Представляет объект - заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Возвращает идентификатор заказа.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Возвращает или задает список всех <see cref="Item"/> в заказе.
        /// </summary>
        internal List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Возвращает или задает статус заказа.
        /// </summary>
        public OrderStatus Status { set; get; }

        /// <summary>
        /// Возвращает или задает адрес доставки.
        /// </summary>
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// Возвращает историю статусов заказа.
        /// </summary>
        public Dictionary<DateTime, OrderStatus> History { get; } = new Dictionary<DateTime, OrderStatus>();

        /// <summary>
        /// Возвращает или задает размер скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Общая стоимость с учетом скидки. 
        /// </summary>
        public double TotalAmount => Amount - DiscountAmount;

        /// <summary>
        /// Возвращает общую стоимость всех товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                return Items.Sum(item => item.Cost);
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Order()
        {
            Id = IDGenerator.GetNextID();
            CreateDate = DateTime.Now;
            Status = OrderStatus.New;
        }
    }
}