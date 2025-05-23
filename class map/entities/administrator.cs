namespace class_map.entities
{
    public class Administrator : Educational
    {
        public string ManagementArea { get; set; }
        public decimal assignedBudget { get; set; }
        public float MonthlyReports  { get; set; }
        public string personnelInCharger { get; set; }
    }
}