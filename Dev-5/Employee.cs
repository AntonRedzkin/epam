namespace Dev_5
{
    class Employee
    {
        public int Salary { get; set; }
        public int Productivity { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }

        public Employee(string name, int salary, int productivity)
        {
            this.Name = name;
            this.Salary = salary;
            this.Productivity = productivity;
            this.Count = 0;
        }
        public override string ToString()
        {
            return string.Format("Name:{0},Count:{1}", Name, Count);
        }
    }
}
