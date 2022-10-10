using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class VirtualProxy : ISubject
    {
        public int Height
        {
            get
            {
                if (_height == 0)
                {
                    return GetSubject().Height;
                }
                return _height;
            }
        }

        public int Width
        {
            get
            {
                if (_width == 0)
                {
                    return GetSubject().Width;
                }
                return _width;
            }
        }

        //test bit
        public bool SubjectLoaded = false;

        private ISubject _subject;
        private int _height;
        private int _width;
        private int _subjectIndex;
        private ISubject[] _subjects;

        public VirtualProxy(int subjectIndex, ISubject[] subjects, int width = 0, int height = 0)
        {
            _subjectIndex = subjectIndex;
            _subjects = subjects;
            _width = width;
            _height = height;
        }

        public void CostlyOperation()
        {
            GetSubject();
        }

        private ISubject GetSubject()
        {
            if (_subject is null)
                _subject = LoadSubject();
            return _subject;
        }

        private ISubject LoadSubject()
        {
            //using array and array index to simplify example this would be a costly fetch
            //like a file load, heavy calculation, etc.
            SubjectLoaded = true;
            return _subjects[_subjectIndex];
        }
    }
}
