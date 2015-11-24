using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3SAP_NP_Complete {
    public class CClausule {

        private int _size;
        private CLiteral[] _clausuleLiterals;
        private bool[] _areDirect;

        public CClausule (CLiteral[] literals, bool[] areDirect) {

            setSize(literals.Count());

            setClausuleLiterals(new CLiteral[literals.Count()]);
            for (int i = 0; i < literals.Count(); i++)
                _clausuleLiterals[i] = literals[i];

            setAreDirect(new bool[getSize()]);
            for (int i = 0; i < getSize(); i++)
                _areDirect[i] = areDirect[i];
        }

        public bool isSatsifactible () {
            for (int i = 0; i < getSize(); i++) {
                if (getClausuleLiterals()[i].isTrue() == getAreDirect()[i])
                    return true;
            }
            return false;
        }

        public string toString () {
            string result = "{";

            if (getSize() > 0) {
                if (getAreDirect()[0])
                    result += _clausuleLiterals[0].toString();
                else
                    result += "~" + _clausuleLiterals[0].toString();
            }
            for (int i = 1; i < getSize(); i++) {
                if (getAreDirect()[i])
                    result += ", " + _clausuleLiterals[i].toString();
                else
                    result += ", ~" + _clausuleLiterals[i].toString();
            }
            result += "}";
            return result;
        }

        public int getSize () {
            return _size;
        }

        public void setSize (int size) {
            this._size = size;
        }

        public CLiteral[] getClausuleLiterals () {
            return _clausuleLiterals;
        }

        public void setClausuleLiterals (CLiteral[] clausuleLiterals) {
            this._clausuleLiterals = clausuleLiterals;
        }

        public bool[] getAreDirect () {
            return _areDirect;
        }

        public void setAreDirect (bool[] areDirect) {
            this._areDirect = areDirect;
        }


    }
}
