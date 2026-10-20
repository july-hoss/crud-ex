namespace crud_ex
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxNome = new TextBox();
            textBoxIdade = new TextBox();
            textBoxCurso = new TextBox();
            textBoxSobrenome = new TextBox();
            textBoxAno = new TextBox();
            textBoxRM = new TextBox();
            buttonSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 89);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome ⚝";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 125);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome ⚝";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 169);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Curso ⚝";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 252);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Idade ⚝";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 210);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Ano ⚝";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 300);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "RM ⚝";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(341, 81);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(191, 23);
            textBoxNome.TabIndex = 6;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(341, 249);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(191, 23);
            textBoxIdade.TabIndex = 7;
            // 
            // textBoxCurso
            // 
            textBoxCurso.Location = new Point(341, 166);
            textBoxCurso.Name = "textBoxCurso";
            textBoxCurso.Size = new Size(191, 23);
            textBoxCurso.TabIndex = 8;
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(341, 122);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(191, 23);
            textBoxSobrenome.TabIndex = 9;
            // 
            // textBoxAno
            // 
            textBoxAno.Location = new Point(341, 207);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(191, 23);
            textBoxAno.TabIndex = 7;
            // 
            // textBoxRM
            // 
            textBoxRM.Location = new Point(341, 297);
            textBoxRM.Name = "textBoxRM";
            textBoxRM.Size = new Size(191, 23);
            textBoxRM.TabIndex = 10;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.MenuHighlight;
            buttonSalvar.Location = new Point(393, 345);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 41);
            buttonSalvar.TabIndex = 11;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxRM);
            Controls.Add(textBoxSobrenome);
            Controls.Add(textBoxCurso);
            Controls.Add(textBoxAno);
            Controls.Add(textBoxIdade);
            Controls.Add(textBoxNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxNome;
        private TextBox textBoxIdade;
        private TextBox textBoxCurso;
        private TextBox textBoxSobrenome;
        private TextBox textBoxAno;
        private TextBox textBoxRM;
        private Button buttonSalvar;
    }
}
