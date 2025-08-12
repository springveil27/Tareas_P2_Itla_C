namespace class_map.entities
{
    public class Employee : CommunityMember
    {
        public int employeeID { get; set; }
        public string hireDate { get; set; }
        public string job { get; set; }
        public decimal salary { get; set; }
        public string department { get; set; }
    }
}