
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    // the : inherits the BaseGradebook class
    public class StandardGradeBook : BaseGradeBook
    {
        // create a new constructor and we tell it to use base(name) on completion
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
