using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class ProtectionProxy : ISubject
    {
        public int Height
        {
            get
            {
                this.ValidateUserAccessLevel(new List<Access>() { Access.FullAccess, Access.ReadOnly });
                return _subject.Height;
            }
        }

        public int Width
        {
            get
            {
                this.ValidateUserAccessLevel(new List<Access>() { Access.FullAccess, Access.ReadOnly });
                return _subject.Width;
            }
        }
        
        private ISubject _subject;
        private Access _userAccessLevel;

        public enum Access
        {
            NoAccess,
            ReadOnly,
            FullAccess,
        }

        //For simplification of example set access level in constructor
        public ProtectionProxy(ISubject subject, Access accessLevel)
        {
            _subject = subject;
            _userAccessLevel = accessLevel;

        }


        public void CostlyOperation()
        {
            ValidateUserAccessLevel(new List<Access>() { Access.FullAccess });
            _subject.CostlyOperation();
        }

        private void ValidateUserAccessLevel(List<Access> requiredAccessLevel)
        {
            //Simplified for example instead
            //Check singleton user, perhaps pass in context to get user instead of using class value
            if (!requiredAccessLevel.Contains(_userAccessLevel))
            {
                throw new AccessViolationException();
            }
        }
    }
}
