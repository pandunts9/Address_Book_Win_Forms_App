
namespace Address_Book_Win_Forms_App
{
    partial class Form2
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
            this.fullName_lbl = new System.Windows.Forms.Label();
            this.fullName_tb = new System.Windows.Forms.TextBox();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.address_lbl = new System.Windows.Forms.Label();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.appData = new Address_Book_Win_Forms_App.AppData();
            this.addressBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBookTableAdapter = new Address_Book_Win_Forms_App.AppDataTableAdapters.AddressBookTableAdapter();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullName_lbl
            // 
            this.fullName_lbl.BackColor = System.Drawing.Color.PaleGreen;
            this.fullName_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fullName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName_lbl.Location = new System.Drawing.Point(20, 125);
            this.fullName_lbl.Name = "fullName_lbl";
            this.fullName_lbl.Size = new System.Drawing.Size(102, 30);
            this.fullName_lbl.TabIndex = 0;
            this.fullName_lbl.Text = "Full Name";
            this.fullName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullName_tb
            // 
            this.fullName_tb.BackColor = System.Drawing.Color.PaleGreen;
            this.fullName_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "FullName", true));
            this.fullName_tb.Location = new System.Drawing.Point(130, 125);
            this.fullName_tb.Multiline = true;
            this.fullName_tb.Name = "fullName_tb";
            this.fullName_tb.Size = new System.Drawing.Size(396, 30);
            this.fullName_tb.TabIndex = 1;
            // 
            // address_tb
            // 
            this.address_tb.BackColor = System.Drawing.Color.PaleGreen;
            this.address_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "Address", true));
            this.address_tb.Location = new System.Drawing.Point(130, 245);
            this.address_tb.Multiline = true;
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(396, 30);
            this.address_tb.TabIndex = 4;
            // 
            // address_lbl
            // 
            this.address_lbl.BackColor = System.Drawing.Color.PaleGreen;
            this.address_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.address_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.Location = new System.Drawing.Point(20, 245);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(102, 30);
            this.address_lbl.TabIndex = 2;
            this.address_lbl.Text = "Address";
            this.address_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone_tb
            // 
            this.phone_tb.BackColor = System.Drawing.Color.PaleGreen;
            this.phone_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "PhoneNumber", true));
            this.phone_tb.Location = new System.Drawing.Point(130, 205);
            this.phone_tb.Multiline = true;
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(396, 30);
            this.phone_tb.TabIndex = 3;
            // 
            // phone_lbl
            // 
            this.phone_lbl.BackColor = System.Drawing.Color.PaleGreen;
            this.phone_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.Location = new System.Drawing.Point(20, 205);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(102, 30);
            this.phone_lbl.TabIndex = 4;
            this.phone_lbl.Text = "Phone Number";
            this.phone_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.PaleGreen;
            this.email_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "Email", true));
            this.email_tb.Location = new System.Drawing.Point(130, 165);
            this.email_tb.Multiline = true;
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(396, 30);
            this.email_tb.TabIndex = 2;
            // 
            // email_lbl
            // 
            this.email_lbl.BackColor = System.Drawing.Color.PaleGreen;
            this.email_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(20, 165);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(102, 30);
            this.email_lbl.TabIndex = 6;
            this.email_lbl.Text = "E-Mail";
            this.email_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 81);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contact Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(451, 285);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 30);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(370, 285);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 30);
            this.save_btn.TabIndex = 12;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(491, 26);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 32);
            this.exit_btn.TabIndex = 13;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBookBindingSource
            // 
            this.addressBookBindingSource.DataMember = "AddressBook";
            this.addressBookBindingSource.DataSource = this.appData;
            // 
            // addressBookTableAdapter
            // 
            this.addressBookTableAdapter.ClearBeforeFill = true;
            // 
            // id_tb
            // 
            this.id_tb.BackColor = System.Drawing.Color.PaleGreen;
            this.id_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "id", true));
            this.id_tb.Enabled = false;
            this.id_tb.Location = new System.Drawing.Point(130, 85);
            this.id_tb.Multiline = true;
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(396, 27);
            this.id_tb.TabIndex = 5;
            // 
            // id_lbl
            // 
            this.id_lbl.BackColor = System.Drawing.Color.PaleGreen;
            this.id_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(20, 85);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(105, 27);
            this.id_lbl.TabIndex = 14;
            this.id_lbl.Text = "ID";
            this.id_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(578, 323);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.fullName_tb);
            this.Controls.Add(this.fullName_lbl);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullName_lbl;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_btn;
        public System.Windows.Forms.TextBox address_tb;
        public System.Windows.Forms.TextBox fullName_tb;
        public System.Windows.Forms.TextBox phone_tb;
        public System.Windows.Forms.TextBox email_tb;
        public System.Windows.Forms.Button clear_btn;
        public System.Windows.Forms.Button save_btn;
        private AppData appData;
        private System.Windows.Forms.BindingSource addressBookBindingSource;
        private AppDataTableAdapters.AddressBookTableAdapter addressBookTableAdapter;
        public System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label id_lbl;
    }
}