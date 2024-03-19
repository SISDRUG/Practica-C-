using System;
namespace Zadanie_13_2
{
    public class MyInfo
    {
        private string _name;

        public event EventHandler NameChanged;

        public MyInfo(string name)
        {
            this._name = name;

        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnNameChanged();
                }
            }
        }

        public void OnNameChanged()
        {
            NameChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

