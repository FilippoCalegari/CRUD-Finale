namespace Gestione_prodotti_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txtb_ProductName = new System.Windows.Forms.TextBox();
            this.txtb_ProductPrice = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.txtb_NewProductName = new System.Windows.Forms.TextBox();
            this.lbl_NewProductName = new System.Windows.Forms.Label();
            this.lbl_NewProductPrice = new System.Windows.Forms.Label();
            this.txtb_NewProductPrice = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_LogicDelete = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Recover = new System.Windows.Forms.Button();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_EmptyFile = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TitleUpdate = new System.Windows.Forms.Label();
            this.lbl_TitleSearch = new System.Windows.Forms.Label();
            this.lbl_TitleCreate = new System.Windows.Forms.Label();
            this.lbl_TitleDelete = new System.Windows.Forms.Label();
            this.lbl_TitleRecover = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_TitleEmptyFile = new System.Windows.Forms.Label();
            this.lbl_TitleOpenFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ProductName.Location = new System.Drawing.Point(207, 535);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(94, 13);
            this.lbl_ProductName.TabIndex = 0;
            this.lbl_ProductName.Text = "Nome prodotto:";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ProductName.Visible = false;
            // 
            // txtb_ProductName
            // 
            this.txtb_ProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_ProductName.Location = new System.Drawing.Point(209, 551);
            this.txtb_ProductName.Name = "txtb_ProductName";
            this.txtb_ProductName.Size = new System.Drawing.Size(174, 20);
            this.txtb_ProductName.TabIndex = 1;
            this.txtb_ProductName.Visible = false;
            this.txtb_ProductName.TextChanged += new System.EventHandler(this.txtb_ProductName_TextChanged);
            // 
            // txtb_ProductPrice
            // 
            this.txtb_ProductPrice.Location = new System.Drawing.Point(467, 551);
            this.txtb_ProductPrice.Name = "txtb_ProductPrice";
            this.txtb_ProductPrice.Size = new System.Drawing.Size(174, 20);
            this.txtb_ProductPrice.TabIndex = 3;
            this.txtb_ProductPrice.Visible = false;
            this.txtb_ProductPrice.TextChanged += new System.EventHandler(this.txtb_ProductPrice_TextChanged);
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductPrice.Location = new System.Drawing.Point(465, 535);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(100, 13);
            this.lbl_ProductPrice.TabIndex = 2;
            this.lbl_ProductPrice.Text = "Prezzo prodotto:";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ProductPrice.Visible = false;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_AddProduct.Location = new System.Drawing.Point(5, 52);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(205, 200);
            this.btn_AddProduct.TabIndex = 7;
            this.btn_AddProduct.Text = "Crea";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_UpdateProduct.Location = new System.Drawing.Point(5, 268);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(205, 200);
            this.btn_UpdateProduct.TabIndex = 9;
            this.btn_UpdateProduct.Text = "Modifica";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateProduct_Click);
            // 
            // txtb_NewProductName
            // 
            this.txtb_NewProductName.Location = new System.Drawing.Point(210, 601);
            this.txtb_NewProductName.Name = "txtb_NewProductName";
            this.txtb_NewProductName.Size = new System.Drawing.Size(174, 20);
            this.txtb_NewProductName.TabIndex = 13;
            this.txtb_NewProductName.Visible = false;
            this.txtb_NewProductName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_NewProductName
            // 
            this.lbl_NewProductName.AutoSize = true;
            this.lbl_NewProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewProductName.Location = new System.Drawing.Point(207, 584);
            this.lbl_NewProductName.Name = "lbl_NewProductName";
            this.lbl_NewProductName.Size = new System.Drawing.Size(133, 13);
            this.lbl_NewProductName.TabIndex = 12;
            this.lbl_NewProductName.Text = "Nuovo nome prodotto:";
            this.lbl_NewProductName.Visible = false;
            this.lbl_NewProductName.Click += new System.EventHandler(this.lbl_NewProductName_Click);
            // 
            // lbl_NewProductPrice
            // 
            this.lbl_NewProductPrice.AutoSize = true;
            this.lbl_NewProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewProductPrice.Location = new System.Drawing.Point(465, 584);
            this.lbl_NewProductPrice.Name = "lbl_NewProductPrice";
            this.lbl_NewProductPrice.Size = new System.Drawing.Size(140, 13);
            this.lbl_NewProductPrice.TabIndex = 18;
            this.lbl_NewProductPrice.Text = "Nuovo prezzo prodotto:";
            this.lbl_NewProductPrice.Visible = false;
            // 
            // txtb_NewProductPrice
            // 
            this.txtb_NewProductPrice.Location = new System.Drawing.Point(467, 601);
            this.txtb_NewProductPrice.Name = "txtb_NewProductPrice";
            this.txtb_NewProductPrice.Size = new System.Drawing.Size(174, 20);
            this.txtb_NewProductPrice.TabIndex = 19;
            this.txtb_NewProductPrice.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Search.Location = new System.Drawing.Point(216, 52);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(205, 200);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Cerca";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_LogicDelete
            // 
            this.btn_LogicDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_LogicDelete.Location = new System.Drawing.Point(427, 52);
            this.btn_LogicDelete.Name = "btn_LogicDelete";
            this.btn_LogicDelete.Size = new System.Drawing.Size(205, 200);
            this.btn_LogicDelete.TabIndex = 21;
            this.btn_LogicDelete.Text = "Eliminazione Logica";
            this.btn_LogicDelete.UseVisualStyleBackColor = true;
            this.btn_LogicDelete.Click += new System.EventHandler(this.btn_LogicDelete_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Delete.Location = new System.Drawing.Point(216, 268);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(205, 200);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Eliminazione Fisica";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Recover
            // 
            this.btn_Recover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Recover.Location = new System.Drawing.Point(427, 268);
            this.btn_Recover.Name = "btn_Recover";
            this.btn_Recover.Size = new System.Drawing.Size(205, 200);
            this.btn_Recover.TabIndex = 23;
            this.btn_Recover.Text = "Recupera";
            this.btn_Recover.UseVisualStyleBackColor = true;
            this.btn_Recover.Click += new System.EventHandler(this.btn_Recover_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_OpenFile.Location = new System.Drawing.Point(639, 52);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(205, 200);
            this.btn_OpenFile.TabIndex = 24;
            this.btn_OpenFile.Text = "Apri File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_EmptyFile
            // 
            this.btn_EmptyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_EmptyFile.Location = new System.Drawing.Point(639, 268);
            this.btn_EmptyFile.Name = "btn_EmptyFile";
            this.btn_EmptyFile.Size = new System.Drawing.Size(205, 200);
            this.btn_EmptyFile.TabIndex = 25;
            this.btn_EmptyFile.Text = "Svuota File";
            this.btn_EmptyFile.UseVisualStyleBackColor = true;
            this.btn_EmptyFile.Click += new System.EventHandler(this.btn_EmptyFile_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button7.Location = new System.Drawing.Point(677, 846);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 117);
            this.button7.TabIndex = 32;
            this.button7.Text = "Esci";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(147, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "SELEZIONA UN\'AZIONE PER INIZIARE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_TitleUpdate
            // 
            this.lbl_TitleUpdate.AutoSize = true;
            this.lbl_TitleUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TitleUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TitleUpdate.Location = new System.Drawing.Point(296, 499);
            this.lbl_TitleUpdate.Name = "lbl_TitleUpdate";
            this.lbl_TitleUpdate.Size = new System.Drawing.Size(254, 13);
            this.lbl_TitleUpdate.TabIndex = 34;
            this.lbl_TitleUpdate.Text = "Inserisci di seguito il prodotto da modificare";
            this.lbl_TitleUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_TitleUpdate.Visible = false;
            // 
            // lbl_TitleSearch
            // 
            this.lbl_TitleSearch.AutoSize = true;
            this.lbl_TitleSearch.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TitleSearch.Location = new System.Drawing.Point(300, 499);
            this.lbl_TitleSearch.Name = "lbl_TitleSearch";
            this.lbl_TitleSearch.Size = new System.Drawing.Size(246, 13);
            this.lbl_TitleSearch.TabIndex = 35;
            this.lbl_TitleSearch.Text = "Inserisci di seguito il prodotto da ricercare";
            this.lbl_TitleSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_TitleSearch.Visible = false;
            // 
            // lbl_TitleCreate
            // 
            this.lbl_TitleCreate.AutoSize = true;
            this.lbl_TitleCreate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TitleCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TitleCreate.Location = new System.Drawing.Point(289, 499);
            this.lbl_TitleCreate.Name = "lbl_TitleCreate";
            this.lbl_TitleCreate.Size = new System.Drawing.Size(275, 13);
            this.lbl_TitleCreate.TabIndex = 36;
            this.lbl_TitleCreate.Text = "Inserisci di seguito i dati del prodotto da creare\r\n";
            this.lbl_TitleCreate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_TitleCreate.Visible = false;
            // 
            // lbl_TitleDelete
            // 
            this.lbl_TitleDelete.AutoSize = true;
            this.lbl_TitleDelete.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TitleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TitleDelete.Location = new System.Drawing.Point(303, 499);
            this.lbl_TitleDelete.Name = "lbl_TitleDelete";
            this.lbl_TitleDelete.Size = new System.Drawing.Size(246, 13);
            this.lbl_TitleDelete.TabIndex = 37;
            this.lbl_TitleDelete.Text = "Inserisci di seguito il prodotto da eliminare";
            this.lbl_TitleDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_TitleDelete.Visible = false;
            // 
            // lbl_TitleRecover
            // 
            this.lbl_TitleRecover.AutoSize = true;
            this.lbl_TitleRecover.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TitleRecover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleRecover.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TitleRecover.Location = new System.Drawing.Point(296, 499);
            this.lbl_TitleRecover.Name = "lbl_TitleRecover";
            this.lbl_TitleRecover.Size = new System.Drawing.Size(257, 13);
            this.lbl_TitleRecover.TabIndex = 38;
            this.lbl_TitleRecover.Text = "Inserisci di seguito il prodotto da recuperare";
            this.lbl_TitleRecover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_TitleRecover.Visible = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Confirm.Location = new System.Drawing.Point(210, 634);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(430, 117);
            this.btn_Confirm.TabIndex = 39;
            this.btn_Confirm.Text = "Conferma";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Visible = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_TitleEmptyFile
            // 
            this.lbl_TitleEmptyFile.AutoSize = true;
            this.lbl_TitleEmptyFile.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TitleEmptyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleEmptyFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TitleEmptyFile.Location = new System.Drawing.Point(327, 608);
            this.lbl_TitleEmptyFile.Name = "lbl_TitleEmptyFile";
            this.lbl_TitleEmptyFile.Size = new System.Drawing.Size(200, 13);
            this.lbl_TitleEmptyFile.TabIndex = 40;
            this.lbl_TitleEmptyFile.Text = "Sei sicuro di voler svuotare il file?";
            this.lbl_TitleEmptyFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_TitleEmptyFile.Visible = false;
            // 
            // lbl_TitleOpenFile
            // 
            this.lbl_TitleOpenFile.AutoSize = true;
            this.lbl_TitleOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_TitleOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleOpenFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TitleOpenFile.Location = new System.Drawing.Point(334, 608);
            this.lbl_TitleOpenFile.Name = "lbl_TitleOpenFile";
            this.lbl_TitleOpenFile.Size = new System.Drawing.Size(183, 13);
            this.lbl_TitleOpenFile.TabIndex = 41;
            this.lbl_TitleOpenFile.Text = "Sei sicuro di voler aprire il file?";
            this.lbl_TitleOpenFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_TitleOpenFile.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 775);
            this.Controls.Add(this.lbl_TitleOpenFile);
            this.Controls.Add(this.lbl_TitleEmptyFile);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_TitleRecover);
            this.Controls.Add(this.lbl_TitleDelete);
            this.Controls.Add(this.lbl_TitleCreate);
            this.Controls.Add(this.lbl_TitleSearch);
            this.Controls.Add(this.lbl_TitleUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_EmptyFile);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.btn_Recover);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_LogicDelete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtb_NewProductPrice);
            this.Controls.Add(this.lbl_NewProductPrice);
            this.Controls.Add(this.txtb_NewProductName);
            this.Controls.Add(this.lbl_NewProductName);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.txtb_ProductPrice);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.txtb_ProductName);
            this.Controls.Add(this.lbl_ProductName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txtb_ProductName;
        private System.Windows.Forms.TextBox txtb_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.TextBox txtb_NewProductName;
        private System.Windows.Forms.Label lbl_NewProductPrice;
        private System.Windows.Forms.TextBox txtb_NewProductPrice;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_LogicDelete;
        private System.Windows.Forms.Button btn_Recover;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_EmptyFile;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lbl_NewProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TitleUpdate;
        private System.Windows.Forms.Label lbl_TitleSearch;
        private System.Windows.Forms.Label lbl_TitleCreate;
        private System.Windows.Forms.Label lbl_TitleDelete;
        private System.Windows.Forms.Label lbl_TitleRecover;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_TitleEmptyFile;
        private System.Windows.Forms.Label lbl_TitleOpenFile;
    }
}

