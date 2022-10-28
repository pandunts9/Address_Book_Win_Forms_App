
namespace Address_Book_Win_Forms_App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.book_grid = new System.Windows.Forms.DataGridView();
            this.addressBookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tittle_lbl = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.creata_button = new System.Windows.Forms.Button();
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.delete_with_id = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.book_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // book_grid
            // 
            this.book_grid.AllowUserToAddRows = false;
            this.book_grid.AllowUserToDeleteRows = false;
            this.book_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.book_grid.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.book_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete_with_id,
            this.fullname,
            this.email,
            this.phonenumber,
            this.address});
            this.book_grid.GridColor = System.Drawing.Color.PaleGreen;
            this.book_grid.Location = new System.Drawing.Point(2, 96);
            this.book_grid.Name = "book_grid";
            this.book_grid.ReadOnly = true;
            this.book_grid.RowHeadersVisible = false;
            this.book_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.book_grid.Size = new System.Drawing.Size(797, 292);
            this.book_grid.TabIndex = 0;
            this.book_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.book_grid_CellDoubleClick);
            // 
            // addressBookBindingSource2
            // 
            this.addressBookBindingSource2.DataMember = "AddressBook";
            // 
            // tittle_lbl
            // 
            this.tittle_lbl.BackColor = System.Drawing.Color.SeaShell;
            this.tittle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle_lbl.Location = new System.Drawing.Point(0, 0);
            this.tittle_lbl.Name = "tittle_lbl";
            this.tittle_lbl.Size = new System.Drawing.Size(800, 96);
            this.tittle_lbl.TabIndex = 1;
            this.tittle_lbl.Text = "ADDRESS BOOK";
            this.tittle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.PaleGreen;
            this.close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(724, 34);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(65, 44);
            this.close_button.TabIndex = 2;
            this.close_button.Text = "CLose";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // creata_button
            // 
            this.creata_button.BackColor = System.Drawing.Color.PaleGreen;
            this.creata_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creata_button.Location = new System.Drawing.Point(648, 34);
            this.creata_button.Name = "creata_button";
            this.creata_button.Size = new System.Drawing.Size(65, 44);
            this.creata_button.TabIndex = 3;
            this.creata_button.Text = "Create";
            this.creata_button.UseVisualStyleBackColor = false;
            this.creata_button.Click += new System.EventHandler(this.creata_button_Click);
            // 
            // addressBookBindingSource
            // 
            this.addressBookBindingSource.DataMember = "AddressBook";
            this.addressBookBindingSource.DataSource = this.appDataBindingSource;
            // 
            // addressBookBindingSource1
            // 
            this.addressBookBindingSource1.DataMember = "AddressBook";
            // 
            // delete_with_id
            // 
            this.delete_with_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete_with_id.FillWeight = 120F;
            this.delete_with_id.HeaderText = "Cursor";
            this.delete_with_id.Name = "delete_with_id";
            this.delete_with_id.ReadOnly = true;
            this.delete_with_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_with_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete_with_id.Width = 62;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Width = 79;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phonenumber.HeaderText = "Phone Number";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            this.phonenumber.Width = 120;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 390);
            this.Controls.Add(this.creata_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.tittle_lbl);
            this.Controls.Add(this.book_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "AddressBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.book_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView book_grid;
        private System.Windows.Forms.Label tittle_lbl;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button creata_button;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private System.Windows.Forms.BindingSource addressBookBindingSource;
        private System.Windows.Forms.BindingSource addressBookBindingSource1;
        private System.Windows.Forms.BindingSource addressBookBindingSource2;
        private System.Windows.Forms.DataGridViewButtonColumn delete_with_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}

