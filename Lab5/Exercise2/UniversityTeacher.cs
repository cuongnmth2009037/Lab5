namespace Lab5.Exercise2
{
    public class UniversityTeacher: Person, IEmployeeAction
    {
        public string UniversityTeacherCode { get; set; }
        public int EnglishSkillLevel { get; set; }

        public double CalculateSalary()
        {
            if (SeniorLecture < 60000)
            {
                throw new AmountException("Senior lecture can not get less than 60,000 salary");
            }

            if (Bonus > 10000)
            {
                throw new AmountException("Bonus is more than 10,000", FullName);
            }

            return BaseSalary * EnglishSkillLevel + ((BaseSalary / 10) * EnglishSkillLevel) + SeniorLecture + Bonus;
        }
    }
}