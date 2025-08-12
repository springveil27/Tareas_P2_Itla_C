namespace class_map.entities
{
    public class AdministrativeStaff : Employee
    {
        public string administrativeDepartment { get; set; }
        public string Position { get; set; }
        public int workingHours { get; set; }
        public string hierarchicalLevel { get; set; }
    }
}