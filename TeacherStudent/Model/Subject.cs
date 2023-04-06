namespace TeacherStudent.Model
{
    public class Subject
    {
        private double _mark;
        private string _name;

        public double Mark { get =>  _mark; set => _mark = value; }
        public string Name { get => _name; set => _name = value; }

        public Subject()
        {

        }

        public Subject(double mark, string name)
        {
            this._mark = mark;
            this._name = name;
        }
    }
}
