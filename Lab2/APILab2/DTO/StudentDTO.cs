namespace APILab2.DTO
{
    public class StudentDTO
    {
        public int St_Id { get; set; }
        public string St_Fname { get; set; }
        public string St_Lname { get; set; }
        public string St_Address { get; set; }
        public int? St_Age { get; set; }
        public int? Dept_Id { get; set; }
        public string? Dept_Name { get; set; }
        public int? St_super { get; set; }
        public string? St_super_Name { get; set; }

    }
}
