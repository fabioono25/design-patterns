using System;
using Xunit;
using design_patterns.HeadFirst.Singleton;
using System.Threading.Tasks;

namespace design_patternsTests.HeadFirst.SingletonTests
{
    public class SingletonTests
    {
        public SingletonTests()
        {
        }

        [Fact]
        public void WorkingWithSimpleSingleton()
        {
            var fromTeacher = Singleton.getInstance();
            fromTeacher.printDetails("Teacher");
            var fromStudent = Singleton.getInstance();
            fromStudent.printDetails("Student");
        }

        [Fact]
        public void ThreadProblemSimulation()
        {
            // simulate calling two methods in parallel
            // counting ending up with 6
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails(),
                () => PrintTeacherDetails(),
                () => PrintStudentDetails(),
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
            );

            void PrintTeacherDetails()
            {
                var fromTeacher = Singleton.getInstance();
                fromTeacher.printDetails("Teacher");
            }

            void PrintStudentDetails()
            {
                var fromStudent = Singleton.getInstance();
                fromStudent.printDetails("Student");
            }
        }

        [Fact]
        public void ThreadSafeApproach()
        {
            // simulate calling two methods in parallel
            // counting ending up with 1
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails(),
                () => PrintTeacherDetails(),
                () => PrintStudentDetails(),
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
            );

            void PrintTeacherDetails()
            {
                var fromTeacher = SingletonThreadSafe.getInstance();
                fromTeacher.printDetails("Teacher");
            }

            void PrintStudentDetails()
            {
                var fromStudent = SingletonThreadSafe.getInstance();
                fromStudent.printDetails("Student");
            }
        }
    }
}

