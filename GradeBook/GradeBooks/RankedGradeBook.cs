
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    // inherit the : BaseGradeBook
    public class RankedGradeBook : BaseGradeBook
    {
        // create a new constructor
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
