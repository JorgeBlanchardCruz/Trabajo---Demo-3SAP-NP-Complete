using System;
using System.Linq;
using System.Windows.Forms;

namespace Demo_3SAP_NP_Complete {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e) {
            bool[] directs = new bool[6];
            directs[2] = true;
            directs[4] = true;

            CLiteral[] ls = new CLiteral[6];
            ls[0] = CLiteral.generateLiteral(true);
            ls[1] = CLiteral.generateLiteral(true);
            ls[2] = CLiteral.generateLiteral(true);
            ls[3] = CLiteral.generateLiteral(true);
            ls[4] = CLiteral.generateLiteral(true);
            ls[5] = CLiteral.generateLiteral(true);

            CLiteralSet literalSet = new CLiteralSet();
            for (int i = 0; i < ls.Count(); i++)
                literalSet.addLiteral(ls[i]);

            CClausuleSet clausuleSet = new CClausuleSet();
            clausuleSet.addClausule(new CClausule(ls, directs));

            CSATProblem problem = new CSATProblem(literalSet, clausuleSet);


            txOutput.Text = problem.toString();

            txOutput.Text += problem.isSatisfactible().ToString() + Environment.NewLine;

            txOutput.Text += CProblemReduction.reduct(problem).toString();

        }
    }
}
