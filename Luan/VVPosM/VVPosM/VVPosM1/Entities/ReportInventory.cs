namespace VVPosM1.Entities
{ 
    public class ReportInventory
    {
        public string IngredientId { get; set; }
        public string IngredientName { get; set; }
        public int TotalBought { get; set; }
        public int TotalSold { get; set; }
        public int Inventory { get; set; }
        public string IngredientUnit { get; set; }
    }
}
