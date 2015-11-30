using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3SAP_NP_Complete {
    public static class CProblemReduction {

        public static CSATProblem reduct (CSATProblem problem) {
            CLiteralSet newLiterals = new CLiteralSet();
            CClausuleSet newClausules = new CClausuleSet();

            newLiterals.addAllLiterals(problem.getLiterals());

            for (int i = 0; i < problem.getClausules().getClausules().Count; i++) { // por cada clausula de entrada

                if (problem.getClausules().getClausules()[i].getSize() == 1)

                    caseSize1(problem.getClausules().getClausules()[i], newLiterals, newClausules);

                else if (problem.getClausules().getClausules()[i].getSize() == 2)

                    caseSize2(problem.getClausules().getClausules()[i], newLiterals, newClausules);

                else if (problem.getClausules().getClausules()[i].getSize() == 3)

                    caseSize3(problem.getClausules().getClausules()[i], newLiterals, newClausules);

                else if (problem.getClausules().getClausules()[i].getSize() > 3)

                    caseSize4(problem.getClausules().getClausules()[i], newLiterals, newClausules);
               
            }

            return new CThreeSATProblem(newLiterals, newClausules);
        }

        private static void caseSize1 (CClausule clausule, CLiteralSet newLiteral, CClausuleSet newClausules) {
            // U'j
            CLiteral y1 = CLiteral.generateLiteral(); // y1j
            newLiteral.addLiteral(y1);

            CLiteral y2 = CLiteral.generateLiteral(); // y2j
            newLiteral.addLiteral(y2);

            // C'j
            bool[] direct = new bool[3];
            CLiteral[] clausuleLiteral = new CLiteral[3]; 

            clausuleLiteral[0] = clausule.getClausuleLiterals()[0]; // z1
            direct[0] = clausule.getAreDirect()[0];

            clausuleLiteral[1] = y1; // y1j
            direct[1] = true;

            clausuleLiteral[2] = y2; // y2j
            direct[2] = true;
            newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {z1, y1j, y2j}

            direct[1] = false; // ¬y1j
            direct[2] = true;  // y2j
            newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {z1, ¬y1j, y2j}

            direct[1] = true;  // y1j
            direct[2] = false; // ¬y2j
            newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {z1, y1j, ¬y2j}

            direct[1] = false; // ¬y1j
            direct[2] = false; // ¬y2j
            newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {z1, ¬y1j, ¬y2j}
        }

        private static void caseSize2 (CClausule clausule, CLiteralSet newLiteral, CClausuleSet newClausules) {
            // U'j
            CLiteral y1 = CLiteral.generateLiteral(); // y1j
            newLiteral.addLiteral(y1);

            // C'j
            bool[] direct = new bool[3];
            CLiteral[] clausuleLiteral = new CLiteral[3];            

            clausuleLiteral[0] = clausule.getClausuleLiterals()[0]; // z1
            direct[0] = clausule.getAreDirect()[0];

            clausuleLiteral[1] = clausule.getClausuleLiterals()[1]; // z2
            direct[1] = clausule.getAreDirect()[1];

            clausuleLiteral[2] = y1; // y1j
            direct[2] = true;

            newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {z1, z2, y1j}

            direct[2] = false; // ¬y1j

            newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {z1, z2, ¬y1j}
        }

        private static void caseSize3 (CClausule clausule, CLiteralSet newLiteral, CClausuleSet newClausules) {
            newClausules.addClausule(clausule); //{cj}
        }

        private static void caseSize4 (CClausule clausule, CLiteralSet newLiteral, CClausuleSet newClausules) {
            bool[] direct = new bool[3];
            CLiteral[] clausuleLiteral = new CLiteral[3];            

            clausuleLiteral[0] = clausule.getClausuleLiterals()[0]; // z1
            direct[0] = clausule.getAreDirect()[0];

            clausuleLiteral[1] = clausule.getClausuleLiterals()[1]; // z2
            direct[1] = clausule.getAreDirect()[1];

            CLiteral l = CLiteral.generateLiteral(); // y1j
            newLiteral.addLiteral(l);
            clausuleLiteral[2] = l; 
            direct[2] = true;            

            newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {z1, z2, y1j}

            for (int i = 0; i < clausule.getSize() - 4; i++) { // 1 <= i <= k-4
                clausuleLiteral[0] = l; // ¬yij
                direct[0] = false;

                clausuleLiteral[1] = clausule.getClausuleLiterals()[i + 2]; // zi+2
                direct[1] = clausule.getAreDirect()[i + 2];

                l = CLiteral.generateLiteral(); // yi+1j
                clausuleLiteral[2] = l; 
                newLiteral.addLiteral(l);
                direct[2] = true;

                newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {{¬yij, zi+2, yi+1j} ; 1 <= i <= k-4}
            }
  
            clausuleLiteral[0] = l; // ¬yk - 3j
            direct[0] = false;

            clausuleLiteral[1] = clausule.getClausuleLiterals()[clausule.getSize() - 2]; // zk - 1
            direct[1] = clausule.getAreDirect()[clausule.getSize() - 2];

            clausuleLiteral[2] = clausule.getClausuleLiterals()[clausule.getSize() - 1]; // zk
            direct[2] = clausule.getAreDirect()[clausule.getSize() - 1];

            newClausules.addClausule(new CClausule(clausuleLiteral, direct)); // {¬yk-3j, zk-j, zk}
        }

    }
}
