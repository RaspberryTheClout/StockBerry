using System;

namespace StockBerry_Objects
{
    public enum ItemCategory
    {
        // Categories for inventory items

        General,    // Default
        Perishable, // Food items (Use Expiry Date)
        Hardware,   // Tools, Electronics
        Stationery, // Pens, Paper
        Clothing,   // Apparel
        Other       // Miscellaneous
    }

    public class InventoryItem
    {
        // Item Identification
        public int Id { get; set; }                 // Item Barcode
        public string Name { get; set; }            // Ex : "Samsung Galaxy S24"
        public string Description { get; set; }     // Ex : "256GB, Black"
        public ItemCategory Category { get; set; }  // Item Category from the predefined enum

        // Quantity Attributes
        public int Quantity { get; set; }           // Current stock level
        public int LowStockThreshold { get; set; }  // Minimum stock level before alert

        // **tba : when to alert for low stock**

        // Financial Attributes
        public decimal CostPrice { get; set; }      // Cost to buy from supplier
        public decimal SellPrice { get; set; }      // Price for customer

        // Timestamps
        public DateTime DateAdded { get; set; }     // When item was added to inventory
        public DateTime? ExpiryDate { get; set; }   // For perishable items (Nullable)

        // Computed Property
        public decimal ProfitPerUnit => SellPrice - CostPrice; // Profit calculation
    }
}
