using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        // Dictionary creates a hashed-table which makes looking up a value by a key quick and easy. Alternative to List

        private readonly Dictionary<string, string> _dictionary;   // Specifiying the keys should be of type string, Values also type string


        public HttpCookie()                             // Initialize dictionary in a constructor
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
}
