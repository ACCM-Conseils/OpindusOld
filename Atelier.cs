using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Opindus
{
	/// <summary>
	/// Description résumée de Atelier.
	/// </summary>
	public class Atelier : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private int Agence;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private MTGCComboBox mtgcComboBox1;
		private OleDbCommand Comm;
		private OleDbTransaction Transac;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Atelier(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			this.Agence=Agence;
			if(Agence.Equals(1))
			{
				oleDbConnection1.ConnectionString=@"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			else if(Agence.Equals(2))
			{
				oleDbConnection1.ConnectionString=@"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lille\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			else if(Agence.Equals(3))
			{
				oleDbConnection1.ConnectionString=@"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Rouen\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			}
			InitializeData();
			textBox1.BackColor=Color.MistyRose;
			textBox1.Focus();
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Atelier));
			this.btSupprime = new System.Windows.Forms.Button();
			this.btEnregistre = new System.Windows.Forms.Button();
			this.btNouveau = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btSupprime
			// 
			this.btSupprime.BackColor = System.Drawing.Color.White;
			this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btSupprime.ForeColor = System.Drawing.Color.Red;
			this.btSupprime.Location = new System.Drawing.Point(304, 176);
			this.btSupprime.Name = "btSupprime";
			this.btSupprime.Size = new System.Drawing.Size(100, 23);
			this.btSupprime.TabIndex = 15;
			this.btSupprime.Text = "Supprime";
			// 
			// btEnregistre
			// 
			this.btEnregistre.BackColor = System.Drawing.Color.White;
			this.btEnregistre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btEnregistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEnregistre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btEnregistre.ForeColor = System.Drawing.Color.Blue;
			this.btEnregistre.Location = new System.Drawing.Point(128, 176);
			this.btEnregistre.Name = "btEnregistre";
			this.btEnregistre.Size = new System.Drawing.Size(100, 23);
			this.btEnregistre.TabIndex = 14;
			this.btEnregistre.Text = "Enregistre";
			this.btEnregistre.Click += new System.EventHandler(this.btEnregistre_Click);
			// 
			// btNouveau
			// 
			this.btNouveau.BackColor = System.Drawing.Color.White;
			this.btNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNouveau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btNouveau.ForeColor = System.Drawing.Color.Blue;
			this.btNouveau.Location = new System.Drawing.Point(16, 176);
			this.btNouveau.Name = "btNouveau";
			this.btNouveau.Size = new System.Drawing.Size(100, 23);
			this.btNouveau.TabIndex = 13;
			this.btNouveau.Text = "Nouveau";
			this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_emplacement_atelier", new System.Data.Common.DataColumnMapping[] {
																																																								 new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																								 new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																								 new System.Data.Common.DataColumnMapping("Occupe", "Occupe")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_emplacement_atelier WHERE (Code = ?) AND (Designation = ? OR ? IS N" +
				"ULL AND Designation IS NULL) AND (Occupe = ?)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Occupe", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Occupe", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_emplacement_atelier(Code, Designation, Occupe) VALUES (?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 10, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Occupe", System.Data.OleDb.OleDbType.Boolean, 2, "Occupe"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Code, Designation, Occupe FROM T_emplacement_atelier";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_emplacement_atelier SET Code = ?, Designation = ?, Occupe = ? WHERE (Cod" +
				"e = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (Occupe = " +
				"?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 10, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Occupe", System.Data.OleDb.OleDbType.Boolean, 2, "Occupe"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Occupe", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Occupe", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Location = new System.Drawing.Point(-5, 8);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(525, 243);
			this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
			this.tabControlEX1.TabIndex = 17;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.mtgcComboBox1);
			this.tabPageEX1.Controls.Add(this.label3);
			this.tabPageEX1.Controls.Add(this.checkBox1);
			this.tabPageEX1.Controls.Add(this.textBox2);
			this.tabPageEX1.Controls.Add(this.textBox1);
			this.tabPageEX1.Controls.Add(this.label2);
			this.tabPageEX1.Controls.Add(this.label1);
			this.tabPageEX1.Controls.Add(this.btNouveau);
			this.tabPageEX1.Controls.Add(this.btEnregistre);
			this.tabPageEX1.Controls.Add(this.btSupprime);
			this.tabPageEX1.Controls.Add(this.button2);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(517, 214);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Saisie";
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 2;
			this.mtgcComboBox1.ColumnWidth = "50;200";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 270;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = true;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(128, 16);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(328, 21);
			this.mtgcComboBox1.TabIndex = 14;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Désignation";
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(128, 112);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 12;
			this.checkBox1.Text = "Occupé";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(128, 84);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(328, 20);
			this.textBox2.TabIndex = 11;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(128, 52);
			this.textBox1.MaxLength = 10;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(153, 20);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Code";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Recherche";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(456, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 48);
			this.button2.TabIndex = 18;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Atelier
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(515, 246);
			this.ControlBox = false;
			this.Controls.Add(this.tabControlEX1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "Atelier";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atelier";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void InitializeData()
		{
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_emplacement_atelier"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["code"].ToString(),row["Designation"].ToString(),"",""));
			}
		}

		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			bool Save=true;
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_emplacement_atelier"].Rows)
			{
				if(row["Code"].Equals(textBox1.Text.ToUpper()))
				{
					MessageBox.Show("Code déjà présent dans la base");
					Save=false;
				}
			}
			if(Save)
			{
				Comm.CommandText="INSERT INTO t_emplacement_atelier (Code,Designation,Occupe) VALUES ('"+textBox1.Text.Replace("'","''").ToUpper()+"','"+textBox2.Text.Replace("'","''").ToUpper()+"',"+checkBox1.Checked+")";
				/*DataRow newrow = dataSet11.Tables["t_emplacement_atelier"].NewRow();
				newrow["Code"]=textBox1.Text.ToUpper();
				newrow["Designation"]=textBox2.Text.ToUpper();
				newrow["Occupe"]=checkBox1.Checked;
				dataSet11.Tables["t_emplacement_atelier"].Rows.Add(newrow);*/
				try
				{
					//oleDbDataAdapter1.Update(dataSet11);
					oleDbConnection1.Open();
					Transac=oleDbConnection1.BeginTransaction();
					Comm.Transaction=Transac;
					Comm.ExecuteNonQuery();
					try
					{
						Transac.Commit();
						MessageBox.Show("Enregistrement terminé");
					}
					catch
					{
						Transac.Rollback();
					}
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				finally
				{
					oleDbConnection1.Close();
				}
			}

		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			textBox1.Text="";
			textBox1.BackColor=Color.MistyRose;
			textBox1.Focus();
			textBox2.Text="";
			checkBox1.Checked=false;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dataSet11.Tables["t_emplacement_atelier"].Clear();
			oleDbSelectCommand1.CommandText="select * from t_emplacement_atelier where code='"+mtgcComboBox1.Text+"'";
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
				textBox1.Text=dataSet11.Tables["t_emplacement_atelier"].Rows[0]["Code"].ToString();
				textBox2.Text=dataSet11.Tables["t_emplacement_atelier"].Rows[0]["Designation"].ToString();
				if(dataSet11.Tables["t_emplacement_atelier"].Rows[0]["Occupe"].ToString().Equals("True"))
					checkBox1.Checked=true;
				else
					checkBox1.Checked=false;
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}

		}
	}
}
