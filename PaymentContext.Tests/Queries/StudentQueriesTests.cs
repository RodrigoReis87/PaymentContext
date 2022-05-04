using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.Value_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Tests.Queries
{
    public class StudentQueriesTests
    {
        private IList<Student> _students;

        public StudentQueriesTests()
        {
            for(int i = 0; i <= 10; i++)
            {
                _students.Add(new Student(
                    new Name("Aluno", i.ToString()),
                    new Document("1111111111" + i.ToString(), Domain.Enums.EDocumentType.CPF),
                    new Email(i.ToString() + "@balta.io"))
                    );
            }
        }

        [TestMethod]
        public void ShouldRetunNullWhenDocumentNotExists()
        {
            var exp = StudentQueries.GetStudentInfo("12345678911");
            var studn = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, studn);
        }
    }
}
