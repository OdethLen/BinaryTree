namespace BinaryTree
{
    public partial class Form1 : Form
    {
        private BinaryTree tree;
        public Form1()
        {
            InitializeComponent();
            tree = new BinaryTree();

        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            lstvResult.Items.Clear();
            var result = tree.InOrder();
            DisplayResult(result);
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            lstvResult.Items.Clear();
            var result = tree.PreOrder();
            DisplayResult(result);
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            lstvResult.Items.Clear();
            var result = tree.PostOrder();
            DisplayResult(result);
        }


        private void DisplayResult(System.Collections.Generic.List<int> result)
        {
            foreach (var number in result)
            {
                lstvResult.Items.Add(new ListViewItem(number.ToString()));
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string input = txtNumbers.Text;
            string[] numbers = input.Split(',');

            foreach (var num in numbers)
            {
                if (int.TryParse(num.Trim(), out int result))
                {
                    tree.Insert(result);
                }
                else
                {
                    MessageBox.Show("Por favor ingrese números válidos.");
                    return;
                }
            }

            MessageBox.Show("Números insertados correctamente.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string input = txtNumbers.Text;
            if (int.TryParse(input.Trim(), out int number))
            {
                tree.Delete(number);
                MessageBox.Show("Número eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
                return;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string treeStructure = tree.GetTreeStructure();
            lblTree.Text = treeStructure;
        }
    }
}
