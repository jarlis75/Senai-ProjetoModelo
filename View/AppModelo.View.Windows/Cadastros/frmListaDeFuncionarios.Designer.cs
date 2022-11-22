namespace AppModelo.View.Windows.Cadastros
{
    partial class frmListaDeFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListarFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarFuncionarios
            // 
            this.dgvListarFuncionarios.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvListarFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListarFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarFuncionarios.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListarFuncionarios.Location = new System.Drawing.Point(0, 2);
            this.dgvListarFuncionarios.Name = "dgvListarFuncionarios";
            this.dgvListarFuncionarios.Size = new System.Drawing.Size(698, 290);
            this.dgvListarFuncionarios.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(114, 298);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 40);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 298);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(96, 40);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // frmListaDeFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(700, 346);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvListarFuncionarios);
            this.Name = "frmListaDeFuncionarios";
            this.Text = "Lista De Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarFuncionarios;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
    }
}