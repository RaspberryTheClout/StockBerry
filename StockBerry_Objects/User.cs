namespace StockBerry_Objects
{
    // 1. Define the Permission Levels
    public enum UserRole
    {
        Admin,      // Can add users, delete stock, see everything
        Manager,    // Can manage stock, but not system settings
        Staff       // Can only view items or process sales
    }

    // 2. The User Definition
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        // SECURITY CRITICAL: Never store plain text passwords!
        public string PasswordHash { get; set; }

        public string FullName { get; set; }
        public UserRole Role { get; set; }

        public bool IsActive { get; set; } = true; // If false, user can't login (instead of deleting them)
    }
}
