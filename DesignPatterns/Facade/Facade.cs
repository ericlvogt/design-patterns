using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Facade : IFacade
    {
        private ISubComponentNumber _subComponentNumber;
        private ISubComponentText _subComponentText;

        public Facade(ISubComponentNumber subComponentNumber, ISubComponentText subComponentText)
        {
            _subComponentNumber = subComponentNumber;
            _subComponentText = subComponentText;
        }

        public int GetNumber()
        {
            return _subComponentNumber.GetValue();
        }

        public List<string> GetText()
        {
            return _subComponentText.GetText();
        }
    }
}
