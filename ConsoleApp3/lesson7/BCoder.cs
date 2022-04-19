using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson7
{
    class BCoder : ICoder
    {
        private string _txt;
        private int _lenghtSdvig;
        public BCoder(string text,int i)
        {
            _txt = text;
            _lenghtSdvig = i;
        }
        public string Decode()
        {
            if (_txt == null) return null;
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < _txt.Length; i++)
            {
                newString.Append((char)(_txt[i] + _lenghtSdvig));
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
                newString.Append((char)(_txt[i] - _lenghtSdvig));
            }
            _txt = newString.ToString();
            return _txt;
        }
    }
}
