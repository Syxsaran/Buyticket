using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyticket
{
    internal class ClassS1
    {
        private string _name;
        private string _email;
        private string _number;
        private string _much;
        private string _price;
        public ClassS1(string name, string email, string number, string much, string price) { this._name = name; this._email = email; this._number = number; this._much = much; this._price = price; }
        public string getname() { return _name; }
        public string getemail() { return _email; }
        public string getnumber() { return _number; }
        public string getmuch() { return _much; }
        public string getprice() { return _price; }
    }

}
