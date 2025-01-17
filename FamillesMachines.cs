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
	/// Description résumée de FamillesMachines.
	/// </summary>
	public class FamillesMachines : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private bool Nouveau;
		private System.Windows.Forms.TextBox textBox6;
		private int Agence;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.Button button3;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private OleDbTransaction Transac;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FamillesMachines(int Agence, string famille)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			DataAD=new OleDbDataAdapter();
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			ds=new DataSet();

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
			if(famille.Length.Equals(0))
			{
				Nouveau=true;
				textBox1.BackColor=Color.MistyRose;
				mtgcComboBox1.SelectedIndex=-1;
				Enable();
				textBox1.Focus();
			}
			else
			{
				Comm.CommandText="SELECT T_famille_machine.Designation, T_famille_machine.Type, T_famille_machine.E_champ_1, T_famille_machine.E_champ_2, T_famille_machine.E_champ_3, T_famille_machine.E_champ_4 FROM T_famille_machine WHERE (((T_famille_machine.Code)="+famille+")) GROUP BY T_famille_machine.Designation, T_famille_machine.Type, T_famille_machine.E_champ_1, T_famille_machine.E_champ_2, T_famille_machine.E_champ_3, T_famille_machine.E_champ_4";
				DataAD.SelectCommand=Comm;
				if(DataAD.Fill(ds,"famille")>0)
				{
					Enable();
					textBox1.Focus();
					textBox1.Text=ds.Tables["famille"].Rows[0]["Designation"].ToString();
					textBox2.Text=ds.Tables["famille"].Rows[0]["E_champ_1"].ToString();
					textBox3.Text=ds.Tables["famille"].Rows[0]["E_champ_2"].ToString();
					textBox4.Text=ds.Tables["famille"].Rows[0]["E_champ_3"].ToString();
					textBox5.Text=ds.Tables["famille"].Rows[0]["E_champ_4"].ToString();
					if(ds.Tables["famille"].Rows[0]["Type"].ToString().Equals("1"))
					{
						radioButton1.Checked=true;
					}
					else if(ds.Tables["famille"].Rows[0]["Type"].ToString().Equals("2"))
					{
						radioButton2.Checked=true;
					}
					else if(ds.Tables["famille"].Rows[0]["Type"].ToString().Equals("3"))
					{
						radioButton3.Checked=true;
					}
					else if(ds.Tables["famille"].Rows[0]["Type"].ToString().Equals("4"))
					{
						radioButton4.Checked=true;
					}
					else if(ds.Tables["famille"].Rows[0]["Type"].ToString().Equals("5"))
					{
						radioButton5.Checked=true;
					}
					else if(ds.Tables["famille"].Rows[0]["Type"].ToString().Equals("6"))
					{
						radioButton6.Checked=true;
					}
				}
			}
		}
		private void InitializeData()
		{
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["T_famille_machine"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["designation"].ToString(),"","",""));
			}
			mtgcComboBox1.SelectedIndex=-1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FamillesMachines));
			this.label1 = new System.Windows.Forms.Label();
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
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(312, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Recherche";
			// 
			// btSupprime
			// 
			this.btSupprime.BackColor = System.Drawing.Color.White;
			this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSupprime.Enabled = false;
			this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btSupprime.ForeColor = System.Drawing.Color.Red;
			this.btSupprime.Location = new System.Drawing.Point(552, 240);
			this.btSupprime.Name = "btSupprime";
			this.btSupprime.Size = new System.Drawing.Size(100, 23);
			this.btSupprime.TabIndex = 33;
			this.btSupprime.Text = "Supprime";
			this.btSupprime.Click += new System.EventHandler(this.btSupprime_Click);
			// 
			// btEnregistre
			// 
			this.btEnregistre.BackColor = System.Drawing.Color.White;
			this.btEnregistre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btEnregistre.Enabled = false;
			this.btEnregistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEnregistre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btEnregistre.ForeColor = System.Drawing.Color.Blue;
			this.btEnregistre.Location = new System.Drawing.Point(136, 240);
			this.btEnregistre.Name = "btEnregistre";
			this.btEnregistre.Size = new System.Drawing.Size(100, 23);
			this.btEnregistre.TabIndex = 32;
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
			this.btNouveau.Location = new System.Drawing.Point(16, 240);
			this.btNouveau.Name = "btNouveau";
			this.btNouveau.Size = new System.Drawing.Size(100, 23);
			this.btNouveau.TabIndex = 31;
			this.btNouveau.Text = "Nouveau";
			this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=ReadWrite;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_famille_machine", new System.Data.Common.DataColumnMapping[] {
																																																							 new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																							 new System.Data.Common.DataColumnMapping("Designation", "Designation"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_1", "E_champ_1"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_2", "E_champ_2"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_3", "E_champ_3"),
																																																							 new System.Data.Common.DataColumnMapping("E_champ_4", "E_champ_4"),
																																																							 new System.Data.Common.DataColumnMapping("Type", "Type")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM T_famille_machine WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (E_champ_1 = ? OR ? IS NULL AND E_champ_1 IS NULL) AND (E_champ_2 = ? OR ? IS NULL AND E_champ_2 IS NULL) AND (E_champ_3 = ? OR ? IS NULL AND E_champ_3 IS NULL) AND (E_champ_4 = ? OR ? IS NULL AND E_champ_4 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_famille_machine(Code, Designation, E_champ_1, E_champ_2, E_champ_3," +
				" E_champ_4, Type) VALUES (?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Code, Designation, E_champ_1, E_champ_2, E_champ_3, E_champ_4, Type FROM T" +
				"_famille_machine ORDER BY Designation";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE T_famille_machine SET Code = ?, Designation = ?, E_champ_1 = ?, E_champ_2 = ?, E_champ_3 = ?, E_champ_4 = ?, Type = ? WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND Designation IS NULL) AND (E_champ_1 = ? OR ? IS NULL AND E_champ_1 IS NULL) AND (E_champ_2 = ? OR ? IS NULL AND E_champ_2 IS NULL) AND (E_champ_3 = ? OR ? IS NULL AND E_champ_3 IS NULL) AND (E_champ_4 = ? OR ? IS NULL AND E_champ_4 IS NULL) AND (Type = ? OR ? IS NULL AND Type IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.Integer, 0, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_1"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_2"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_3"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, "E_champ_4"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Type"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_11", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_2", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_21", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_2", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_3", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_31", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_3", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_4", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_E_champ_41", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "E_champ_4", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(24, 0);
			this.textBox6.Name = "textBox6";
			this.textBox6.TabIndex = 35;
			this.textBox6.Text = "";
			this.textBox6.Visible = false;
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Location = new System.Drawing.Point(-8, 32);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(760, 184);
			this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
			this.tabControlEX1.TabIndex = 36;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.groupBox1);
			this.tabPageEX1.Controls.Add(this.groupBox2);
			this.tabPageEX1.Controls.Add(this.groupBox3);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(752, 155);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Saisie";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.radioButton6);
			this.groupBox1.Controls.Add(this.radioButton5);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(736, 48);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// radioButton6
			// 
			this.radioButton6.Checked = true;
			this.radioButton6.Enabled = false;
			this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton6.Location = new System.Drawing.Point(584, 16);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.TabIndex = 11;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Autre";
			// 
			// radioButton5
			// 
			this.radioButton5.Enabled = false;
			this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton5.Location = new System.Drawing.Point(488, 16);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(80, 24);
			this.radioButton5.TabIndex = 10;
			this.radioButton5.Text = "Clé à choc";
			// 
			// radioButton4
			// 
			this.radioButton4.Enabled = false;
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(392, 16);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(80, 24);
			this.radioButton4.TabIndex = 9;
			this.radioButton4.Text = "Perceuse";
			// 
			// radioButton3
			// 
			this.radioButton3.Enabled = false;
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(296, 16);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(80, 24);
			this.radioButton3.TabIndex = 8;
			this.radioButton3.Text = "Meuleuse";
			// 
			// radioButton2
			// 
			this.radioButton2.Enabled = false;
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(208, 16);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(72, 24);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.Text = "Visseuse";
			// 
			// radioButton1
			// 
			this.radioButton1.Enabled = false;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(128, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 24);
			this.radioButton1.TabIndex = 6;
			this.radioButton1.Text = "Clé Dyn";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Types familles";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(8, 41);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(736, 48);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Silver;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(248, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(400, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Désignation famille";
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(8, 81);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(736, 72);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(464, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "Champ 4";
			this.label8.Visible = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(464, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 7;
			this.label7.Text = "Champ 3";
			this.label7.Visible = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(248, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Champ 2";
			this.label6.Visible = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(248, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Champ 1";
			this.label5.Visible = false;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.White;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Enabled = false;
			this.textBox5.Location = new System.Drawing.Point(520, 40);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(128, 20);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "?";
			this.textBox5.Visible = false;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.White;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(312, 40);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(128, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "?";
			this.textBox4.Visible = false;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(520, 16);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(128, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "?";
			this.textBox3.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(312, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(128, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "?";
			this.textBox2.Visible = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Libellés informations";
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 1;
			this.mtgcComboBox1.ColumnWidth = "121";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 141;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = false;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(400, 8);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(328, 21);
			this.mtgcComboBox1.TabIndex = 37;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(680, 224);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 48);
			this.button3.TabIndex = 38;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// FamillesMachines
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(742, 280);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.mtgcComboBox1);
			this.Controls.Add(this.tabControlEX1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.btSupprime);
			this.Controls.Add(this.btEnregistre);
			this.Controls.Add(this.btNouveau);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "FamillesMachines";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Familles machines";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			Nouveau=true;
			textBox1.BackColor=Color.MistyRose;
			mtgcComboBox1.SelectedIndex=-1;
			Enable();
			textBox1.Focus();
		}

		private void Enable()
		{
			radioButton1.Enabled=true;
			radioButton2.Enabled=true;
			radioButton3.Enabled=true;
			radioButton4.Enabled=true;
			radioButton5.Enabled=true;
			radioButton6.Enabled=true;
			textBox1.Enabled=true;
			textBox1.Text="";
			textBox2.Enabled=true;
			textBox2.Text="?";
			textBox3.Enabled=true;
			textBox3.Text="?";
			textBox4.Enabled=true;
			textBox4.Text="?";
			textBox5.Enabled=true;
			textBox5.Text="?";
			btEnregistre.Enabled=true;
			btSupprime.Enabled=true;
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			if(textBox1.TextLength>0)
			{
				textBox1.BackColor=Color.Silver;
				if(Nouveau)
				{
					try
					{
						oleDbConnection1.Open();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					OleDbCommand Comm = new OleDbCommand();
					Comm.Connection=oleDbConnection1;
					Comm.CommandText="select * from t_famille_machine";
					oleDbDataAdapter1.SelectCommand=Comm;
					DataSet ds = new DataSet();
					oleDbDataAdapter1.Fill(ds);

					int cpt=0;
			
					foreach(DataRow row in ds.Tables["t_famille_machine"].Rows)
					{
						if(System.Convert.ToInt32(row["Code"].ToString())>cpt)
							cpt=System.Convert.ToInt32(row["Code"].ToString());
						cpt++;
					}
					cpt+=1;
					DataRow newrow = ds.Tables["t_famille_machine"].NewRow();
					newrow["Code"]=cpt;
					newrow["designation"]=textBox1.Text.ToUpper();
					if(radioButton1.Checked)
						newrow["type"]=1;
					else if(radioButton2.Checked)
						newrow["type"]=2;
					else if(radioButton3.Checked)
						newrow["type"]=3;
					else if(radioButton4.Checked)
						newrow["type"]=4;
					else if(radioButton5.Checked)
						newrow["type"]=5;
					else if(radioButton6.Checked)
						newrow["type"]=6;
					newrow["E_champ_1"]=textBox2.Text.ToUpper();
					newrow["E_champ_2"]=textBox3.Text.ToUpper();
					newrow["E_champ_3"]=textBox4.Text.ToUpper();
					newrow["E_champ_4"]=textBox5.Text.ToUpper();
					ds.Tables["t_famille_machine"].Rows.Add(newrow);
					try
					{
						oleDbDataAdapter1.Update(ds);
						MessageBox.Show("Enregistrement terminé");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					oleDbConnection1.Close();
					Enable();
					dataSet11.Clear();
					mtgcComboBox1.Items.Clear();
					oleDbDataAdapter1.Fill(dataSet11);
					foreach(DataRow row in dataSet11.Tables["T_famille_machine"].Rows)
					{
						mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["designation"].ToString(),"","",""));
					}
					mtgcComboBox1.SelectedIndex=-1;
				}
				else
				{
					oleDbConnection1.Open();
					OleDbCommand Comm= new OleDbCommand();
					Comm.Connection=oleDbConnection1;
					int Check=6;
					if(radioButton1.Checked)
						Check=1;
					else if(radioButton2.Checked)
						Check=2;
					else if(radioButton3.Checked)
						Check=3;
					else if(radioButton4.Checked)
						Check=4;
					else if(radioButton5.Checked)
						Check=5;
					else if(radioButton6.Checked)
						Check=6;
					string Designation=textBox1.Text.ToUpper().Replace("'","''");
					if(radioButton6.Checked)
						Comm.CommandText="update t_famille_machine set E_champ_1='"+textBox2.Text.ToUpper()+"', E_champ_2='"+textBox3.Text.ToUpper()+"', E_champ_3='"+textBox4.Text.ToUpper()+"', E_champ_4='"+textBox5.Text.ToUpper()+"', designation='"+Designation+"', type="+Check.ToString()+" where Code="+textBox6.Text;
					else
						Comm.CommandText="update t_famille_machine set designation='"+Designation+"', type="+Check.ToString()+" where Code="+textBox6.Text;
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					MessageBox.Show("Mise à jour OK");
					oleDbConnection1.Close();
				}
			}
			else
				MessageBox.Show("Veuillez entrer une désignation");
		}

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			DataSet ds = new DataSet();
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select * from t_famille_machine";
			oleDbDataAdapter1.SelectCommand=Comm;
			oleDbDataAdapter1.Fill(ds);
			DataTable Table = ds.Tables["T_famille_machine"];
			
			if(MessageBox.Show("Supprimer la famille ?","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
			{
				foreach (DataRow row in Table.Rows)
				{
					if(row["Code"].ToString().Equals(textBox6.Text.ToUpper()))
					{
						row.Delete();
						break;
					}
				}
			}
			oleDbDataAdapter1.Update(ds);
			Enable();
			mtgcComboBox1.Items.Clear();
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["T_famille_machine"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["designation"].ToString(),"","",""));
			}
			mtgcComboBox1.SelectedIndex=-1;
		}

		private void radioButton6_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton6.Checked)
			{
				textBox2.Visible=true;
				textBox3.Visible=true;
				textBox4.Visible=true;
				textBox5.Visible=true;
				label5.Visible=true;
				label6.Visible=true;
				label7.Visible=true;
				label8.Visible=true;
			}
			else
			{
				textBox2.Visible=false;
				textBox3.Visible=false;
				textBox4.Visible=false;
				textBox5.Visible=false;
				label5.Visible=false;
				label6.Visible=false;
				label7.Visible=false;
				label8.Visible=false;
			}
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			radioButton1.Enabled=true;
			radioButton2.Enabled=true;
			radioButton3.Enabled=true;
			radioButton4.Enabled=true;
			radioButton5.Enabled=true;
			radioButton6.Enabled=true;
			textBox1.Enabled=true;
			textBox2.Enabled=true;
			textBox3.Enabled=true;
			textBox4.Enabled=true;
			textBox5.Enabled=true;
			btEnregistre.Enabled=true;
			btSupprime.Enabled=true;
			dataSet11.Clear();
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			string Nom=mtgcComboBox1.Text;
			Nom=Nom.Replace("'","''");
			Comm.CommandText="select * from t_famille_machine where designation='"+Nom+"'";
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			if(dataSet11.Tables["t_famille_machine"].Rows[0]["type"].ToString().Equals("1"))
				radioButton1.Checked=true;
			else if(dataSet11.Tables["t_famille_machine"].Rows[0]["type"].ToString().Equals("2"))
				radioButton2.Checked=true;
			else if(dataSet11.Tables["t_famille_machine"].Rows[0]["type"].ToString().Equals("3"))
				radioButton3.Checked=true;
			else if(dataSet11.Tables["t_famille_machine"].Rows[0]["type"].ToString().Equals("4"))
				radioButton4.Checked=true;
			else if(dataSet11.Tables["t_famille_machine"].Rows[0]["type"].ToString().Equals("5"))
				radioButton5.Checked=true;
			else if(dataSet11.Tables["t_famille_machine"].Rows[0]["type"].ToString().Equals("6"))
				radioButton6.Checked=true;
			textBox1.Text=dataSet11.Tables["t_famille_machine"].Rows[0]["designation"].ToString();
			textBox2.Text=dataSet11.Tables["t_famille_machine"].Rows[0]["e_champ_1"].ToString();
			textBox3.Text=dataSet11.Tables["t_famille_machine"].Rows[0]["e_champ_2"].ToString();
			textBox4.Text=dataSet11.Tables["t_famille_machine"].Rows[0]["e_champ_3"].ToString();
			textBox5.Text=dataSet11.Tables["t_famille_machine"].Rows[0]["e_champ_4"].ToString();
			textBox6.Text=dataSet11.Tables["t_famille_machine"].Rows[0]["Code"].ToString();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
