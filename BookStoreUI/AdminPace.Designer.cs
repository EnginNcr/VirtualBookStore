namespace BookStoreUI
{
    partial class AdminPace
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
            this.gbxSearchAdmin = new System.Windows.Forms.GroupBox();
            this.tbxBookSerchAdmin = new System.Windows.Forms.TextBox();
            this.cbxAuthorSearchAdmin = new System.Windows.Forms.ComboBox();
            this.cbxBookTypeSearchAdmin = new System.Windows.Forms.ComboBox();
            this.lblBookAdmin = new System.Windows.Forms.Label();
            this.lblAuthorsAdmin = new System.Windows.Forms.Label();
            this.lblBookTypeAdmin = new System.Windows.Forms.Label();
            this.dgwBooksTypeAdmin = new System.Windows.Forms.DataGridView();
            this.GrbxAddAdmin = new System.Windows.Forms.GroupBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.txtStockAboutAddAdmin = new System.Windows.Forms.TextBox();
            this.txtUnitPriceAddAdmin = new System.Windows.Forms.TextBox();
            this.txtBookNameAddAdmin = new System.Windows.Forms.TextBox();
            this.cbxAuthorAddAdmin = new System.Windows.Forms.ComboBox();
            this.cbxBookTypeAdmin = new System.Windows.Forms.ComboBox();
            this.lblStockAboutAddAdmin = new System.Windows.Forms.Label();
            this.lblUnitPriceAddAdmin = new System.Windows.Forms.Label();
            this.lblBookAddAdmin = new System.Windows.Forms.Label();
            this.lblAuthorsAddAdmin = new System.Windows.Forms.Label();
            this.lblBookTypeAddAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxUpdateAdmin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxStockAboutUpdateAdmin = new System.Windows.Forms.TextBox();
            this.cbxUnitPriceUpdateAdmin = new System.Windows.Forms.TextBox();
            this.cbxBookNameUpdateAdmin = new System.Windows.Forms.TextBox();
            this.cbxAuthorUpdateAdmin = new System.Windows.Forms.ComboBox();
            this.cbxBookTypeUpdateAdmin = new System.Windows.Forms.ComboBox();
            this.lblStockAboutUpdateAdmin = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdateAdmin = new System.Windows.Forms.Label();
            this.lblBookNameUpdateAdmin = new System.Windows.Forms.Label();
            this.lblAuthorUpdateAdmin = new System.Windows.Forms.Label();
            this.lblBookTypeUpdateAdmin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeletedmin = new System.Windows.Forms.Button();
            this.gbxSearchAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooksTypeAdmin)).BeginInit();
            this.GrbxAddAdmin.SuspendLayout();
            this.gbxUpdateAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSearchAdmin
            // 
            this.gbxSearchAdmin.Controls.Add(this.tbxBookSerchAdmin);
            this.gbxSearchAdmin.Controls.Add(this.cbxAuthorSearchAdmin);
            this.gbxSearchAdmin.Controls.Add(this.cbxBookTypeSearchAdmin);
            this.gbxSearchAdmin.Controls.Add(this.lblBookAdmin);
            this.gbxSearchAdmin.Controls.Add(this.lblAuthorsAdmin);
            this.gbxSearchAdmin.Controls.Add(this.lblBookTypeAdmin);
            this.gbxSearchAdmin.Location = new System.Drawing.Point(38, 17);
            this.gbxSearchAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSearchAdmin.Name = "gbxSearchAdmin";
            this.gbxSearchAdmin.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSearchAdmin.Size = new System.Drawing.Size(934, 114);
            this.gbxSearchAdmin.TabIndex = 0;
            this.gbxSearchAdmin.TabStop = false;
            this.gbxSearchAdmin.Text = "Search";
            // 
            // tbxBookSerchAdmin
            // 
            this.tbxBookSerchAdmin.Location = new System.Drawing.Point(747, 53);
            this.tbxBookSerchAdmin.Name = "tbxBookSerchAdmin";
            this.tbxBookSerchAdmin.Size = new System.Drawing.Size(148, 24);
            this.tbxBookSerchAdmin.TabIndex = 3;
            this.tbxBookSerchAdmin.TextChanged += new System.EventHandler(this.tbxBookSerchAdmin_TextChanged);
            // 
            // cbxAuthorSearchAdmin
            // 
            this.cbxAuthorSearchAdmin.FormattingEnabled = true;
            this.cbxAuthorSearchAdmin.Location = new System.Drawing.Point(422, 50);
            this.cbxAuthorSearchAdmin.Name = "cbxAuthorSearchAdmin";
            this.cbxAuthorSearchAdmin.Size = new System.Drawing.Size(170, 26);
            this.cbxAuthorSearchAdmin.TabIndex = 2;
            this.cbxAuthorSearchAdmin.SelectedIndexChanged += new System.EventHandler(this.cbxAuthorSearchAdmin_SelectedIndexChanged);
            // 
            // cbxBookTypeSearchAdmin
            // 
            this.cbxBookTypeSearchAdmin.FormattingEnabled = true;
            this.cbxBookTypeSearchAdmin.Location = new System.Drawing.Point(149, 53);
            this.cbxBookTypeSearchAdmin.Name = "cbxBookTypeSearchAdmin";
            this.cbxBookTypeSearchAdmin.Size = new System.Drawing.Size(170, 26);
            this.cbxBookTypeSearchAdmin.TabIndex = 2;
            this.cbxBookTypeSearchAdmin.SelectedIndexChanged += new System.EventHandler(this.cbxBookTypeSearchAdmin_SelectedIndexChanged);
            // 
            // lblBookAdmin
            // 
            this.lblBookAdmin.AutoSize = true;
            this.lblBookAdmin.Location = new System.Drawing.Point(617, 56);
            this.lblBookAdmin.Name = "lblBookAdmin";
            this.lblBookAdmin.Size = new System.Drawing.Size(106, 18);
            this.lblBookAdmin.TabIndex = 1;
            this.lblBookAdmin.Text = "Book Search";
            // 
            // lblAuthorsAdmin
            // 
            this.lblAuthorsAdmin.AutoSize = true;
            this.lblAuthorsAdmin.Location = new System.Drawing.Point(348, 53);
            this.lblAuthorsAdmin.Name = "lblAuthorsAdmin";
            this.lblAuthorsAdmin.Size = new System.Drawing.Size(57, 18);
            this.lblAuthorsAdmin.TabIndex = 1;
            this.lblAuthorsAdmin.Text = "Author";
            // 
            // lblBookTypeAdmin
            // 
            this.lblBookTypeAdmin.AutoSize = true;
            this.lblBookTypeAdmin.Location = new System.Drawing.Point(35, 53);
            this.lblBookTypeAdmin.Name = "lblBookTypeAdmin";
            this.lblBookTypeAdmin.Size = new System.Drawing.Size(84, 18);
            this.lblBookTypeAdmin.TabIndex = 1;
            this.lblBookTypeAdmin.Text = "BookType";
            // 
            // dgwBooksTypeAdmin
            // 
            this.dgwBooksTypeAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooksTypeAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooksTypeAdmin.Location = new System.Drawing.Point(38, 138);
            this.dgwBooksTypeAdmin.Name = "dgwBooksTypeAdmin";
            this.dgwBooksTypeAdmin.Size = new System.Drawing.Size(934, 160);
            this.dgwBooksTypeAdmin.TabIndex = 3;
            this.dgwBooksTypeAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooksTypeAdmin_CellContentClick);
            // 
            // GrbxAddAdmin
            // 
            this.GrbxAddAdmin.Controls.Add(this.btnAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.txtStockAboutAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.txtUnitPriceAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.txtBookNameAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.cbxAuthorAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.cbxBookTypeAdmin);
            this.GrbxAddAdmin.Controls.Add(this.lblStockAboutAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.lblUnitPriceAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.lblBookAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.lblAuthorsAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.lblBookTypeAddAdmin);
            this.GrbxAddAdmin.Controls.Add(this.label1);
            this.GrbxAddAdmin.Location = new System.Drawing.Point(38, 318);
            this.GrbxAddAdmin.Name = "GrbxAddAdmin";
            this.GrbxAddAdmin.Size = new System.Drawing.Size(319, 281);
            this.GrbxAddAdmin.TabIndex = 4;
            this.GrbxAddAdmin.TabStop = false;
            this.GrbxAddAdmin.Text = "Add";
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAdmin.Location = new System.Drawing.Point(176, 235);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(108, 40);
            this.btnAddAdmin.TabIndex = 3;
            this.btnAddAdmin.Text = "Add";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            // 
            // txtStockAboutAddAdmin
            // 
            this.txtStockAboutAddAdmin.Location = new System.Drawing.Point(116, 192);
            this.txtStockAboutAddAdmin.Name = "txtStockAboutAddAdmin";
            this.txtStockAboutAddAdmin.Size = new System.Drawing.Size(168, 24);
            this.txtStockAboutAddAdmin.TabIndex = 2;
            // 
            // txtUnitPriceAddAdmin
            // 
            this.txtUnitPriceAddAdmin.Location = new System.Drawing.Point(116, 148);
            this.txtUnitPriceAddAdmin.Name = "txtUnitPriceAddAdmin";
            this.txtUnitPriceAddAdmin.Size = new System.Drawing.Size(168, 24);
            this.txtUnitPriceAddAdmin.TabIndex = 2;
            // 
            // txtBookNameAddAdmin
            // 
            this.txtBookNameAddAdmin.Location = new System.Drawing.Point(116, 110);
            this.txtBookNameAddAdmin.Name = "txtBookNameAddAdmin";
            this.txtBookNameAddAdmin.Size = new System.Drawing.Size(168, 24);
            this.txtBookNameAddAdmin.TabIndex = 2;
            // 
            // cbxAuthorAddAdmin
            // 
            this.cbxAuthorAddAdmin.FormattingEnabled = true;
            this.cbxAuthorAddAdmin.Location = new System.Drawing.Point(116, 64);
            this.cbxAuthorAddAdmin.Name = "cbxAuthorAddAdmin";
            this.cbxAuthorAddAdmin.Size = new System.Drawing.Size(168, 26);
            this.cbxAuthorAddAdmin.TabIndex = 1;
            this.cbxAuthorAddAdmin.SelectedIndexChanged += new System.EventHandler(this.cbxAuthorAddAdmin_SelectedIndexChanged);
            // 
            // cbxBookTypeAdmin
            // 
            this.cbxBookTypeAdmin.FormattingEnabled = true;
            this.cbxBookTypeAdmin.Location = new System.Drawing.Point(116, 26);
            this.cbxBookTypeAdmin.Name = "cbxBookTypeAdmin";
            this.cbxBookTypeAdmin.Size = new System.Drawing.Size(168, 26);
            this.cbxBookTypeAdmin.TabIndex = 1;
            this.cbxBookTypeAdmin.SelectedIndexChanged += new System.EventHandler(this.cbxBookTypeAdmin_SelectedIndexChanged);
            // 
            // lblStockAboutAddAdmin
            // 
            this.lblStockAboutAddAdmin.AutoSize = true;
            this.lblStockAboutAddAdmin.Location = new System.Drawing.Point(6, 195);
            this.lblStockAboutAddAdmin.Name = "lblStockAboutAddAdmin";
            this.lblStockAboutAddAdmin.Size = new System.Drawing.Size(95, 18);
            this.lblStockAboutAddAdmin.TabIndex = 0;
            this.lblStockAboutAddAdmin.Text = "StockAbout";
            // 
            // lblUnitPriceAddAdmin
            // 
            this.lblUnitPriceAddAdmin.AutoSize = true;
            this.lblUnitPriceAddAdmin.Location = new System.Drawing.Point(6, 154);
            this.lblUnitPriceAddAdmin.Name = "lblUnitPriceAddAdmin";
            this.lblUnitPriceAddAdmin.Size = new System.Drawing.Size(82, 18);
            this.lblUnitPriceAddAdmin.TabIndex = 0;
            this.lblUnitPriceAddAdmin.Text = "Unit Price";
            // 
            // lblBookAddAdmin
            // 
            this.lblBookAddAdmin.AutoSize = true;
            this.lblBookAddAdmin.Location = new System.Drawing.Point(6, 110);
            this.lblBookAddAdmin.Name = "lblBookAddAdmin";
            this.lblBookAddAdmin.Size = new System.Drawing.Size(97, 18);
            this.lblBookAddAdmin.TabIndex = 0;
            this.lblBookAddAdmin.Text = "Book Name";
            // 
            // lblAuthorsAddAdmin
            // 
            this.lblAuthorsAddAdmin.AutoSize = true;
            this.lblAuthorsAddAdmin.Location = new System.Drawing.Point(6, 67);
            this.lblAuthorsAddAdmin.Name = "lblAuthorsAddAdmin";
            this.lblAuthorsAddAdmin.Size = new System.Drawing.Size(57, 18);
            this.lblAuthorsAddAdmin.TabIndex = 0;
            this.lblAuthorsAddAdmin.Text = "Author";
            // 
            // lblBookTypeAddAdmin
            // 
            this.lblBookTypeAddAdmin.AutoSize = true;
            this.lblBookTypeAddAdmin.Location = new System.Drawing.Point(6, 29);
            this.lblBookTypeAddAdmin.Name = "lblBookTypeAddAdmin";
            this.lblBookTypeAddAdmin.Size = new System.Drawing.Size(84, 18);
            this.lblBookTypeAddAdmin.TabIndex = 0;
            this.lblBookTypeAddAdmin.Text = "BookType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // gbxUpdateAdmin
            // 
            this.gbxUpdateAdmin.Controls.Add(this.button1);
            this.gbxUpdateAdmin.Controls.Add(this.cbxStockAboutUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.cbxUnitPriceUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.cbxBookNameUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.cbxAuthorUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.cbxBookTypeUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.lblStockAboutUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.lblUnitPriceUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.lblBookNameUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.lblAuthorUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.lblBookTypeUpdateAdmin);
            this.gbxUpdateAdmin.Controls.Add(this.label7);
            this.gbxUpdateAdmin.Location = new System.Drawing.Point(442, 318);
            this.gbxUpdateAdmin.Name = "gbxUpdateAdmin";
            this.gbxUpdateAdmin.Size = new System.Drawing.Size(319, 281);
            this.gbxUpdateAdmin.TabIndex = 4;
            this.gbxUpdateAdmin.TabStop = false;
            this.gbxUpdateAdmin.Text = "Update";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(184, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbxStockAboutUpdateAdmin
            // 
            this.cbxStockAboutUpdateAdmin.Location = new System.Drawing.Point(116, 192);
            this.cbxStockAboutUpdateAdmin.Name = "cbxStockAboutUpdateAdmin";
            this.cbxStockAboutUpdateAdmin.Size = new System.Drawing.Size(168, 24);
            this.cbxStockAboutUpdateAdmin.TabIndex = 2;
            // 
            // cbxUnitPriceUpdateAdmin
            // 
            this.cbxUnitPriceUpdateAdmin.Location = new System.Drawing.Point(116, 148);
            this.cbxUnitPriceUpdateAdmin.Name = "cbxUnitPriceUpdateAdmin";
            this.cbxUnitPriceUpdateAdmin.Size = new System.Drawing.Size(168, 24);
            this.cbxUnitPriceUpdateAdmin.TabIndex = 2;
            // 
            // cbxBookNameUpdateAdmin
            // 
            this.cbxBookNameUpdateAdmin.Location = new System.Drawing.Point(116, 110);
            this.cbxBookNameUpdateAdmin.Name = "cbxBookNameUpdateAdmin";
            this.cbxBookNameUpdateAdmin.Size = new System.Drawing.Size(168, 24);
            this.cbxBookNameUpdateAdmin.TabIndex = 2;
            // 
            // cbxAuthorUpdateAdmin
            // 
            this.cbxAuthorUpdateAdmin.FormattingEnabled = true;
            this.cbxAuthorUpdateAdmin.Location = new System.Drawing.Point(116, 64);
            this.cbxAuthorUpdateAdmin.Name = "cbxAuthorUpdateAdmin";
            this.cbxAuthorUpdateAdmin.Size = new System.Drawing.Size(168, 26);
            this.cbxAuthorUpdateAdmin.TabIndex = 1;
            // 
            // cbxBookTypeUpdateAdmin
            // 
            this.cbxBookTypeUpdateAdmin.FormattingEnabled = true;
            this.cbxBookTypeUpdateAdmin.Location = new System.Drawing.Point(116, 26);
            this.cbxBookTypeUpdateAdmin.Name = "cbxBookTypeUpdateAdmin";
            this.cbxBookTypeUpdateAdmin.Size = new System.Drawing.Size(168, 26);
            this.cbxBookTypeUpdateAdmin.TabIndex = 1;
            // 
            // lblStockAboutUpdateAdmin
            // 
            this.lblStockAboutUpdateAdmin.AutoSize = true;
            this.lblStockAboutUpdateAdmin.Location = new System.Drawing.Point(6, 195);
            this.lblStockAboutUpdateAdmin.Name = "lblStockAboutUpdateAdmin";
            this.lblStockAboutUpdateAdmin.Size = new System.Drawing.Size(95, 18);
            this.lblStockAboutUpdateAdmin.TabIndex = 0;
            this.lblStockAboutUpdateAdmin.Text = "StockAbout";
            // 
            // lblUnitPriceUpdateAdmin
            // 
            this.lblUnitPriceUpdateAdmin.AutoSize = true;
            this.lblUnitPriceUpdateAdmin.Location = new System.Drawing.Point(6, 154);
            this.lblUnitPriceUpdateAdmin.Name = "lblUnitPriceUpdateAdmin";
            this.lblUnitPriceUpdateAdmin.Size = new System.Drawing.Size(82, 18);
            this.lblUnitPriceUpdateAdmin.TabIndex = 0;
            this.lblUnitPriceUpdateAdmin.Text = "Unit Price";
            // 
            // lblBookNameUpdateAdmin
            // 
            this.lblBookNameUpdateAdmin.AutoSize = true;
            this.lblBookNameUpdateAdmin.Location = new System.Drawing.Point(6, 110);
            this.lblBookNameUpdateAdmin.Name = "lblBookNameUpdateAdmin";
            this.lblBookNameUpdateAdmin.Size = new System.Drawing.Size(97, 18);
            this.lblBookNameUpdateAdmin.TabIndex = 0;
            this.lblBookNameUpdateAdmin.Text = "Book Name";
            // 
            // lblAuthorUpdateAdmin
            // 
            this.lblAuthorUpdateAdmin.AutoSize = true;
            this.lblAuthorUpdateAdmin.Location = new System.Drawing.Point(6, 67);
            this.lblAuthorUpdateAdmin.Name = "lblAuthorUpdateAdmin";
            this.lblAuthorUpdateAdmin.Size = new System.Drawing.Size(57, 18);
            this.lblAuthorUpdateAdmin.TabIndex = 0;
            this.lblAuthorUpdateAdmin.Text = "Author";
            // 
            // lblBookTypeUpdateAdmin
            // 
            this.lblBookTypeUpdateAdmin.AutoSize = true;
            this.lblBookTypeUpdateAdmin.Location = new System.Drawing.Point(6, 29);
            this.lblBookTypeUpdateAdmin.Name = "lblBookTypeUpdateAdmin";
            this.lblBookTypeUpdateAdmin.Size = new System.Drawing.Size(84, 18);
            this.lblBookTypeUpdateAdmin.TabIndex = 0;
            this.lblBookTypeUpdateAdmin.Text = "BookType";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "label1";
            // 
            // btnDeletedmin
            // 
            this.btnDeletedmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeletedmin.Location = new System.Drawing.Point(833, 347);
            this.btnDeletedmin.Name = "btnDeletedmin";
            this.btnDeletedmin.Size = new System.Drawing.Size(139, 40);
            this.btnDeletedmin.TabIndex = 3;
            this.btnDeletedmin.Text = "Delete";
            this.btnDeletedmin.UseVisualStyleBackColor = true;
            // 
            // AdminPace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.btnDeletedmin);
            this.Controls.Add(this.gbxUpdateAdmin);
            this.Controls.Add(this.GrbxAddAdmin);
            this.Controls.Add(this.dgwBooksTypeAdmin);
            this.Controls.Add(this.gbxSearchAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPace";
            this.Text = "AdminPace";
            this.Load += new System.EventHandler(this.AdminPace_Load);
            this.gbxSearchAdmin.ResumeLayout(false);
            this.gbxSearchAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooksTypeAdmin)).EndInit();
            this.GrbxAddAdmin.ResumeLayout(false);
            this.GrbxAddAdmin.PerformLayout();
            this.gbxUpdateAdmin.ResumeLayout(false);
            this.gbxUpdateAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearchAdmin;
        private System.Windows.Forms.ComboBox cbxAuthorSearchAdmin;
        private System.Windows.Forms.ComboBox cbxBookTypeSearchAdmin;
        private System.Windows.Forms.Label lblBookAdmin;
        private System.Windows.Forms.Label lblAuthorsAdmin;
        private System.Windows.Forms.Label lblBookTypeAdmin;
        private System.Windows.Forms.DataGridView dgwBooksTypeAdmin;
        private System.Windows.Forms.TextBox tbxBookSerchAdmin;
        private System.Windows.Forms.GroupBox GrbxAddAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.TextBox txtStockAboutAddAdmin;
        private System.Windows.Forms.TextBox txtUnitPriceAddAdmin;
        private System.Windows.Forms.TextBox txtBookNameAddAdmin;
        private System.Windows.Forms.ComboBox cbxAuthorAddAdmin;
        private System.Windows.Forms.ComboBox cbxBookTypeAdmin;
        private System.Windows.Forms.Label lblStockAboutAddAdmin;
        private System.Windows.Forms.Label lblUnitPriceAddAdmin;
        private System.Windows.Forms.Label lblBookAddAdmin;
        private System.Windows.Forms.Label lblAuthorsAddAdmin;
        private System.Windows.Forms.Label lblBookTypeAddAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxUpdateAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cbxStockAboutUpdateAdmin;
        private System.Windows.Forms.TextBox cbxUnitPriceUpdateAdmin;
        private System.Windows.Forms.TextBox cbxBookNameUpdateAdmin;
        private System.Windows.Forms.ComboBox cbxAuthorUpdateAdmin;
        private System.Windows.Forms.ComboBox cbxBookTypeUpdateAdmin;
        private System.Windows.Forms.Label lblStockAboutUpdateAdmin;
        private System.Windows.Forms.Label lblUnitPriceUpdateAdmin;
        private System.Windows.Forms.Label lblBookNameUpdateAdmin;
        private System.Windows.Forms.Label lblAuthorUpdateAdmin;
        private System.Windows.Forms.Label lblBookTypeUpdateAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeletedmin;
    }
}