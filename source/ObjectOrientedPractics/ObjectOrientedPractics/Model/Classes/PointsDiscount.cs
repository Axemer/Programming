﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    internal class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Максимальный процент скидки.
        /// </summary>
        private const int MaxDiscountPercent = 30;

        private string _info;

        /// <summary>
        /// Вернуть информацию о скидке.
        /// </summary>
        public string Info
        {
            get => $"Накопительная - {Points} баллов.";
            set => _info = value;
        }

        public bool Active { get; set; } = true;

        /// <summary>
        /// Вернуть количество баллов.
        /// </summary>
        public int Points { get; set; }

        public double Calculate(IEnumerable<Item> items)
        {
            var sum = items.Sum(item => item.Cost);
            var maxDiscount = (int)Math.Ceiling(sum / 100 * MaxDiscountPercent);
            return Points <= maxDiscount
                ? Points
                : maxDiscount;
        }

        public double Apply(IEnumerable<Item> items)
        {
            var points = Points;
            var sum = items.Sum(item => item.Cost);
            var maxDiscount = (int)Math.Ceiling(sum / 100 * MaxDiscountPercent);
            if (points > maxDiscount)
            {
                return Points -= maxDiscount;
            }
            Points = 0;
            return points;
        }

        public void Update(IEnumerable<Item> items)
        {
            Points = (int)(items.Sum(item => item.Cost) / 10);
        }

        public override string ToString()
        {
            return Info;
        }
    }
}