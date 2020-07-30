using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    #region Case 1

    // Inheritance
    public class PhysicalPerson : Person
    {
        public string Cpf { get; set; }
    }

    // Composition
    public class PhysicalPerson2
    {
        public Person Person { get; set; }

        public string Cpf { get; set; }
    }

    public class TestInheritanceComposition
    {
        public TestInheritanceComposition()
        {
            var inheritancePerson = new PhysicalPerson
            {
                Name = "Joao",
                DateOfBorn = DateTime.Now,
                Cpf = "123654789"
            };

            var compositionPerson = new PhysicalPerson2
            {
                Person = new Person
                {
                    Name = "Joao",
                    DateOfBorn = DateTime.Now
                },
                Cpf = "123654789"
            };

            var inheritanceName = inheritancePerson.Name;
            var compositionName = compositionPerson.Person.Name;
        }
    }

    #endregion

    #region Case 2

    public interface IRepository<T>
    {
        void Add(T obj);
        void Delete(T obj);
    }

    public interface IPersonRepository
    {
        void Add(Person obj);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Add(T obj)
        {
            // 
        }

        public void Delete(T obj)
        {
            // 
        }
    }

    public class InheritancePersonRepository : Repository<Person>, IPersonRepository
    {

    }

    public class CompositionPersonRepository : IPersonRepository
    {
        private readonly IRepository<Person> _repository;

        public CompositionPersonRepository(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public void Add(Person obj)
        {
            _repository.Add(obj); 
        }
    }

    public class TestInheritanceComposition2
    {
        public TestInheritanceComposition2()
        {
            var repH = new InheritancePersonRepository();
            repH.Add(new Person());
            repH.Delete(new Person());

            var repC = new CompositionPersonRepository(new Repository<Person>());
            repC.Add(new Person());
        }
    }

    #endregion
}
