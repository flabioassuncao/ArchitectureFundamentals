using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Message : IMessage, IEnumerable<IMessage>
    {
        private readonly List<IMessage> _list = new List<IMessage>();

        public string Name { get; set; }

        public Message(string name)
        {
            Name = name;
        }

        public void AdicionarFilha(IMessage child)
        {
            _list.Add(child);
        }

        public void RemoverFilha(IMessage child)
        {
            _list.Remove(child);
        }

        public IMessage ObterFilha(int index)
        {
            return _list[index];
        }

        public IMessage ObterFilha(string name)
        {
            return _list.First(c => c.Name == name);
        }

        public IEnumerable<IMessage> GetList()
        {
            return _list;
        }

        public IEnumerator<IMessage> GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_list).GetEnumerator();
        }

        public void ShowMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);

            foreach (var message in _list)
            {
                message.ShowMessages(sub + 2);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_list).GetEnumerator();
        }
    }
}
