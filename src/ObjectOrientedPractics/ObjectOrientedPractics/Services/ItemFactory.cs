using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    public static class ItemFactory
    {
        /// <summary>
        /// Создает товар.
        /// </summary>
        /// <returns>Возвращает объект Item</returns>
        public static Item Randomize()
        {
            Item item = new Item();
            item.Name = "Name";
            item.Cost = 10;
            item.Info = "info";
            item.Category = Category.Cars;

            return item;
        }
    }
}
