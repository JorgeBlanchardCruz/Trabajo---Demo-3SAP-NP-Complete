using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3SAP_NP_Complete {
    public class CClausuleSet {

        private List<CClausule> _clausules;

        public CClausuleSet () {
            setClausules(new List<CClausule>());
        }

        public void addClausule (CClausule newClausule) {
            _clausules.Add(newClausule);
        }

        public bool isSatisfactible () {
            foreach (CClausule clausule in _clausules) {
                if (!clausule.isSatsifactible())
                    return false;
            }

            return true;
        }

        public string toString () {
            string result = "{";
            for (int i = 0; i < _clausules.Count; i++) {
                result += _clausules[i].toString();
            }
            result += "}";
            return result;
        }

        public List<CClausule> getClausules () {
            return _clausules;
        }

        public void setClausules (List<CClausule> clausules) {
            this._clausules = clausules;
        }

    }
}
