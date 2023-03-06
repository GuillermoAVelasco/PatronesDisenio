using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Flyweight
{
    public class AutoComponente
    {
        private string _numMotor;
        private string _patente;
        private Auto _auto;

        public AutoComponente(string numMotor, string patente, Auto auto)
        {
            _numMotor = numMotor;
            _patente = patente;
            _auto = auto;
        }

        public void setComponente(Componente c)
        {
            _auto.setComponente(c);
        }

        public override string ToString()
        {
            return _auto.ToString()+" Motor: "+_numMotor+" Patente:"+_patente;
        }

        public string getAuto()
        {
            return _auto.getClave();
        }

        public void getComponentes()
        {
            _auto.getComponentes();
        }
    }
}
