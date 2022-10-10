using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DesignPatterns.Proxy
{
    public class RemoteProxy : ISubject
    {
        private enum RequestType
        {
            GET,
            POST,
            PUT,
            DELETE,
        }

        public int Height 
        {
            get
            {
                if (_height == 0)
                {
                    _height = this.Request(RequestType.GET, "height");
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
                    _width = this.Request(RequestType.GET, "width");
                }
                return _width;
            }
        }

        private int _height;
        private int _width;

        public RemoteProxy(string address)
        {
            //not using address for simplification however address
            //would be used to access the remote subject
        }

        public void CostlyOperation()
        {
            this.Request(RequestType.POST, "doSomethingBig");
        }

        //should be async
        //private async Task<int> CreateAndSendRequest(RequestType requestType, string parameter)
        private int Request(RequestType requestType, string parameter)
        {
            //remote call happens here
            //not implementing for simplicity

            //in server / remote client / etc.
            switch (requestType)
            {
                case RequestType.GET:
                    {
                        switch (parameter)
                        {
                            case "height":
                                return 4;
                            case "width":
                                return 5;
                        }
                    }
                    break;
                case RequestType.POST:
                    break;
                case RequestType.PUT:
                    break;
                case RequestType.DELETE:
                    break;
                default:
                    throw new NotImplementedException();
            }
            return 0;
        }
    }
}
