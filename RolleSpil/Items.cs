namespace RolleSpil
{
    abstract class Items
    {
        string itemName;
        int quantity;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}