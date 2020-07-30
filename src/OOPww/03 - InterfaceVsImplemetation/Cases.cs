using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public interface IRepository
    {
        void Add();
    }

    public class Repository : IRepository
    {
        public void Add()
        {
            // add item
        }
    }

    public class FakeRepository : IRepository
    {
        public void Add()
        {
            // simulation add item to test
        }
    }

    public class UseImplementation
    {
        // high coupling
        public void Process()
        {
            var repository = new Repository();
            repository.Add();
        }
    }

    public class UseAbstraction
    {
        // low coupling
        private readonly IRepository _repository;

        public UseAbstraction(IRepository repository)
        {
            _repository = repository;
        }

        public void Process()
        {
            _repository.Add();
        }
    }

    public class TestInterfaceImplementation
    {
        public TestInterfaceImplementation()
        {
            var repImp = new UseImplementation();
            repImp.Process();

            var repAbs = new UseAbstraction(new Repository());
            repAbs.Process();

            var repFakeAbs = new UseAbstraction(new FakeRepository());
            repFakeAbs.Process();
        }
    }
}
