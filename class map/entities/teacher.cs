namespace class_map.entities
{
    public class Teacher : Educational
    {
        public string educationalLevel { get; set; }
        public int NumberOfclasses { get; set; }
        public string subject { get; set; }
        public float averageStudentEvaluation { get; set; }
    }
}