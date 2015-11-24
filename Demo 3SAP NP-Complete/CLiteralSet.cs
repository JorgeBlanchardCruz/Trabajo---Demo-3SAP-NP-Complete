using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3SAP_NP_Complete {
    public class CLiteralSet {

        private List<CLiteral> _literals;

        public CLiteralSet () {
            setLiterals(new List<CLiteral>());
        }

        public CLiteralSet (int size) {
            setLiterals(new List<CLiteral>());
            for (int i = 0; i < size; i++)
                _literals.Add(CLiteral.generateLiteral());
        }

        public void setLiterals (List<CLiteral> literals) {
            this._literals = literals;
        }

        public void addLiteral (CLiteral l) {
            _literals.Add(l);
        }

        public void addAllLiterals (CLiteralSet otherSet) {
            foreach (CLiteral literal in otherSet.getLiterals()) {
                _literals.Add(literal);
            }
        }

        public CLiteral getLiteral (int id) {
            foreach (CLiteral literal in _literals) {
                if (id == literal.getId())
                    return literal;
            }

            return null;
        }

        public bool hasLiteral (int id) {
            foreach (CLiteral literal in _literals) {
                if (literal.getId() == id)
                    return true;
            }
            return false;
        }

        public String toString () {
            String result = "{";

            //if (_literals.Count > 0)
            //    result += _literals[0].toString();

            foreach (CLiteral literal in _literals) {
                result += literal.toString() + ", ";
            }
            result = result.Substring(0, result.Length - 2);
            result += "}";

            return result;
        }

        public void setLiteralValue (int id, bool value) {
            getLiteral(id).setValue(value);
        }

        public int getCardinality () {
            return _literals.Count;
        }

        public void setLiteralValues (bool[] values) {
            for (int i = 0; i < _literals.Count; i++)
                _literals[i].setValue(values[i]);
        }

        public List<CLiteral> getLiterals () {
            return _literals;
        }


    }
}
