using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    public class PriorityOrder : Order
    {
        private DateTime _deliveryDate;

        private string _deliveryTime;

        public PriorityOrder()
        {

        }

        public PriorityOrder(OrderStatus status, Address address, List<Item> items,
            DateTime deliveryDate, string deliveryTime) : base(status, address, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        public DateTime DeliveryDate
        {
            get
            {
                return _deliveryDate;
            }
            set
            {
                _deliveryDate = value;
            }
        }

        public string DeliveryTime
        {
            get
            {
                return _deliveryTime;
            }
            set
            {
                _deliveryTime = value;
            }
        }
    }
}
