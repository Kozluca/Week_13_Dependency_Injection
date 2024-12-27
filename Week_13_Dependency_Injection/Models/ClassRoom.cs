namespace Week_13_Dependency_Injection.Models
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;//Field injection

        public ClassRoom(ITeacher teacher)//Constructor injection
        {
            _teacher = teacher;
        }
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}

