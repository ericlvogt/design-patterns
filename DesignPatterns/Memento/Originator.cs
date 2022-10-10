using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Originator : IOriginator
    {
        private class State : ICloneable
        {
            public string Name { get; set; }

            public State(string name)
            {
                Name = name;
            }

            public object Clone()
            {
                return new State(Name);
            }
        }

        private class Memento : IMemento
        {
            private State _state;

            public State GetState()
            {
                return _state;
            }

            public void SetState(State state)
            {
                _state = state;
            }
        }

        public string Name { get => _state.Name; set => _state.Name = value; }

        private State _state = new(null);

        public IMemento CreateMemento()
        {
            Memento result = new();
            result.SetState((State)(_state.Clone()));
            return result;
        }

        public void SetMemento(IMemento memento)
        {
            if (memento is Memento m)
                _state = (State)m.GetState().Clone();
        }

    }
}
