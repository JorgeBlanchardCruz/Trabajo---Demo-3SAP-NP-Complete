using System;
using System.Linq;
using System.Windows.Forms;

namespace Demo_3SAP_NP_Complete {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e) {

            switch (cbProblem.SelectedItem.ToString()) {
                case "Problem size 1":
                    example1();
                    break;
                case "Problem size 2":
                    example2();
                    break;
                case "Problem size 3":
                    example3();
                    break;
                case "Problem size 4":
                    example4();
                    break;

            }

        }

        private void example1 () {
            bool[] directs = new bool[1];
            CLiteral[] ls = new CLiteral[1];
            ls[0] = CLiteral.generateLiteral(true);
            directs[0] = true;

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

        private void example2 () {
            bool[] directs = new bool[2];
            CLiteral[] ls = new CLiteral[2];
            ls[0] = CLiteral.generateLiteral(true);
            directs[0] = true;
            ls[1] = CLiteral.generateLiteral(true);

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

        private void example3 () {
            bool[] directs = new bool[3];
            CLiteral[] ls = new CLiteral[3];
            ls[0] = CLiteral.generateLiteral(true);
            ls[1] = CLiteral.generateLiteral(true);
            ls[2] = CLiteral.generateLiteral(true);
            directs[2] = true;

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

        private void example4 () {
            bool[] directs = new bool[6];
            CLiteral[] ls = new CLiteral[6];
            ls[0] = CLiteral.generateLiteral(true);
            ls[1] = CLiteral.generateLiteral(true);
            ls[2] = CLiteral.generateLiteral(true);
            directs[2] = true;
            ls[3] = CLiteral.generateLiteral(true);
            ls[4] = CLiteral.generateLiteral(true);
            directs[4] = true;
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
