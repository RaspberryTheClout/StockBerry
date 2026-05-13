using System;

namespace StockBerry_Objects
{
    // What kind of movement was this?
    public enum TransactionType
    {
        Restock,    // Adding items (+)
        Sale,       // Selling items (-)
        Adjustment  // Correction (e.g., item broken/stolen) (-)
    }

    public class InventoryTransaction
    {
        public int Id { get; set; }

        // FOREIGN KEY: Which item was moved?
        // We store the ID, not the whole Item object, to keep the database light.
        public int InventoryItemId { get; set; }
        public string ItemNameSnapshot { get; set; } // Saves the name *at the time of sale* (in case name changes later)

        // Who did it?
        public int UserId { get; set; }

        public TransactionType Type { get; set; }
        public int QuantityChanged { get; set; } // e.g., +50 or -5
        public DateTime Timestamp { get; set; }
    }
}