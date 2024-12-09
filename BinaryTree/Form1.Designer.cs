namespace BinaryTree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNumbers = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            lstvResult = new ListView();
            btnInOrder = new Button();
            btnPreOrder = new Button();
            btnPostOrder = new Button();
            lblTree = new Label();
            btnShow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 127);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(85, 124);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(126, 23);
            txtNumbers.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(56, 173);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(56, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstvResult
            // 
            lstvResult.Location = new Point(335, 51);
            lstvResult.Name = "lstvResult";
            lstvResult.Size = new Size(272, 196);
            lstvResult.TabIndex = 4;
            lstvResult.UseCompatibleStateImageBehavior = false;
            // 
            // btnInOrder
            // 
            btnInOrder.Location = new Point(245, 89);
            btnInOrder.Name = "btnInOrder";
            btnInOrder.Size = new Size(75, 23);
            btnInOrder.TabIndex = 5;
            btnInOrder.Text = "In Order";
            btnInOrder.UseVisualStyleBackColor = true;
            btnInOrder.Click += btnInOrder_Click;
            // 
            // btnPreOrder
            // 
            btnPreOrder.Location = new Point(245, 131);
            btnPreOrder.Name = "btnPreOrder";
            btnPreOrder.Size = new Size(75, 23);
            btnPreOrder.TabIndex = 6;
            btnPreOrder.Text = "Pre Order";
            btnPreOrder.UseVisualStyleBackColor = true;
            btnPreOrder.Click += btnPreOrder_Click;
            // 
            // btnPostOrder
            // 
            btnPostOrder.Location = new Point(245, 171);
            btnPostOrder.Name = "btnPostOrder";
            btnPostOrder.Size = new Size(75, 23);
            btnPostOrder.TabIndex = 7;
            btnPostOrder.Text = "Post Order";
            btnPostOrder.UseVisualStyleBackColor = true;
            btnPostOrder.Click += btnPostOrder_Click;
            // 
            // lblTree
            // 
            lblTree.AutoSize = true;
            lblTree.Location = new Point(335, 280);
            lblTree.Name = "lblTree";
            lblTree.Size = new Size(16, 15);
            lblTree.TabIndex = 8;
            lblTree.Text = "...";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(56, 252);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 9;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 346);
            Controls.Add(btnShow);
            Controls.Add(lblTree);
            Controls.Add(btnPostOrder);
            Controls.Add(btnPreOrder);
            Controls.Add(btnInOrder);
            Controls.Add(lstvResult);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtNumbers);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumbers;
        private Button btnInsert;
        private Button btnDelete;
        private ListView lstvResult;
        private Button btnInOrder;
        private Button btnPreOrder;
        private Button btnPostOrder;
        private Label lblTree;
        private Button btnShow;
    }
}
