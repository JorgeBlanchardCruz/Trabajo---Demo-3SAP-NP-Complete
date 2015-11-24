using System;

namespace Demo_3SAP_NP_Complete {
    public class CSATProblem {

        private CLiteralSet literals;
        private CClausuleSet clausules;

        public CSATProblem (CLiteralSet literals, CClausuleSet clausules) {
            setLiterals(literals);
            setClausules(clausules);
        }


        public bool isSatisfactible () {
            return getClausules().isSatisfactible();
        }

        public string toString () {
            string result = "";

            result += "Literals = " + getLiterals().toString() + Environment.NewLine;
            result += "Clausules = " + getClausules().toString() + Environment.NewLine;

            return result;
        }
        public CLiteralSet getLiterals () {
            return literals;
        }
        private void setLiterals (CLiteralSet literals) {
            this.literals = literals;
        }
        public CClausuleSet getClausules () {
            return clausules;
        }
        private void setClausules (CClausuleSet clausules) {
            this.clausules = clausules;
        }

    }
}
