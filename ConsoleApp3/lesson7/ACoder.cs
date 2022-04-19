using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson7
{
    class ACoder : ICoder
    {
        private string _txt;
        public ACoder(string text)
        {
            _txt = text;

        }
        public string Decode()
        {
            if (_txt == null) return null;
            StringBuilder newString = new StringBuilder();
            for (int i=0;i<_txt.Length;i++)
            {
                newString.Append((char)(_txt[i] + 1));
            }
            _txt = newString.ToString();
            return _txt;
        }

        public string Encode()
        {
            if (_txt == null) return null;
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < _txt.Length; i++)
            {
                newString.Append((char)(_txt[i] - 1));
            }
            _txt = newString.ToString();
            return _txt;
        }
    }
}
