namespace CRUD_CSharp
{
    partial class crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crud));
            this.crudlabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.fornecedorlabel = new System.Windows.Forms.Label();
            this.qtdlabel = new System.Windows.Forms.Label();
            this.marcalabel = new System.Windows.Forms.Label();
            this.stocklabel = new System.Windows.Forms.Label();
            this.operadorlabel = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxOperator = new System.Windows.Forms.TextBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // crudlabel
            // 
            this.crudlabel.AutoSize = true;
            this.crudlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crudlabel.ForeColor = System.Drawing.Color.White;
            this.crudlabel.Location = new System.Drawing.Point(294, 9);
            this.crudlabel.Name = "crudlabel";
            this.crudlabel.Size = new System.Drawing.Size(180, 33);
            this.crudlabel.TabIndex = 0;
            this.crudlabel.Text = "C#  - CRUD";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.Color.White;
            this.idlabel.Location = new System.Drawing.Point(12, 113);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(29, 24);
            this.idlabel.TabIndex = 1;
            this.idlabel.Text = "ID";
            // 
            // fornecedorlabel
            // 
            this.fornecedorlabel.AutoSize = true;
            this.fornecedorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorlabel.ForeColor = System.Drawing.Color.White;
            this.fornecedorlabel.Location = new System.Drawing.Point(12, 159);
            this.fornecedorlabel.Name = "fornecedorlabel";
            this.fornecedorlabel.Size = new System.Drawing.Size(120, 24);
            this.fornecedorlabel.TabIndex = 2;
            this.fornecedorlabel.Text = "Fornecedor";
            // 
            // qtdlabel
            // 
            this.qtdlabel.AutoSize = true;
            this.qtdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdlabel.ForeColor = System.Drawing.Color.White;
            this.qtdlabel.Location = new System.Drawing.Point(14, 211);
            this.qtdlabel.Name = "qtdlabel";
            this.qtdlabel.Size = new System.Drawing.Size(118, 24);
            this.qtdlabel.TabIndex = 3;
            this.qtdlabel.Text = "Quantidade";
            // 
            // marcalabel
            // 
            this.marcalabel.AutoSize = true;
            this.marcalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcalabel.ForeColor = System.Drawing.Color.White;
            this.marcalabel.Location = new System.Drawing.Point(382, 113);
            this.marcalabel.Name = "marcalabel";
            this.marcalabel.Size = new System.Drawing.Size(167, 24);
            this.marcalabel.TabIndex = 4;
            this.marcalabel.Text = "Marca da Bebida";
            // 
            // stocklabel
            // 
            this.stocklabel.AutoSize = true;
            this.stocklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocklabel.ForeColor = System.Drawing.Color.White;
            this.stocklabel.Location = new System.Drawing.Point(232, 42);
            this.stocklabel.Name = "stocklabel";
            this.stocklabel.Size = new System.Drawing.Size(317, 29);
            this.stocklabel.TabIndex = 5;
            this.stocklabel.Text = "Sistema de Gestão de Stock";
            // 
            // operadorlabel
            // 
            this.operadorlabel.AutoSize = true;
            this.operadorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operadorlabel.ForeColor = System.Drawing.Color.White;
            this.operadorlabel.Location = new System.Drawing.Point(382, 159);
            this.operadorlabel.Name = "operadorlabel";
            this.operadorlabel.Size = new System.Drawing.Size(99, 24);
            this.operadorlabel.TabIndex = 6;
            this.operadorlabel.Text = "Operador";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(147, 113);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(81, 29);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxOperator
            // 
            this.textBoxOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOperator.Location = new System.Drawing.Point(554, 162);
            this.textBoxOperator.Name = "textBoxOperator";
            this.textBoxOperator.Size = new System.Drawing.Size(217, 29);
            this.textBoxOperator.TabIndex = 8;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "2M",
            "Txilar",
            "Laurentina Preta",
            "Corona",
            "Coca-Cola",
            "Água da Namaacha"});
            this.comboBoxBrand.Location = new System.Drawing.Point(555, 110);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(216, 32);
            this.comboBoxBrand.TabIndex = 9;
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Items.AddRange(new object[] {
            "HandLing",
            "2M",
            "Coca-Cola",
            "Água de Namaacha"});
            this.comboBoxSupplier.Location = new System.Drawing.Point(147, 159);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(209, 32);
            this.comboBoxSupplier.TabIndex = 11;
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQtd.Location = new System.Drawing.Point(147, 211);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(81, 29);
            this.textBoxQtd.TabIndex = 12;
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.SendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.Location = new System.Drawing.Point(129, 279);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(99, 35);
            this.SendBtn.TabIndex = 13;
            this.SendBtn.Text = "Enviar";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(257, 279);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(99, 35);
            this.UpdateBtn.TabIndex = 14;
            this.UpdateBtn.Text = "Atualizar";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(386, 279);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(99, 35);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Apagar";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView.Location = new System.Drawing.Point(16, 343);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(755, 220);
            this.dataGridView.TabIndex = 16;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(520, 279);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(99, 35);
            this.ClearBtn.TabIndex = 17;
            this.ClearBtn.Text = "Limpar";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.ForeColor = System.Drawing.Color.White;
            this.author.Location = new System.Drawing.Point(269, 575);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(250, 13);
            this.author.TabIndex = 18;
            this.author.Text = "Desenvolvedor: Salvador Carlos Mucavele @ 2022";
            // 
            // crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(788, 597);
            this.Controls.Add(this.author);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.textBoxOperator);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.operadorlabel);
            this.Controls.Add(this.stocklabel);
            this.Controls.Add(this.marcalabel);
            this.Controls.Add(this.qtdlabel);
            this.Controls.Add(this.fornecedorlabel);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.crudlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "crud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# - CRUD - Sistema de Gestão de Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label crudlabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label fornecedorlabel;
        private System.Windows.Forms.Label qtdlabel;
        private System.Windows.Forms.Label marcalabel;
        private System.Windows.Forms.Label stocklabel;
        private System.Windows.Forms.Label operadorlabel;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxOperator;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label author;
    }
}

