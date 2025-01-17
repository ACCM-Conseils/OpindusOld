using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Opindus
{
	/// <summary>
	/// Description résumée de AcReglements.
	/// </summary>
	public class AcReglements : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private int Agence;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private bool Nouveau;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.TextBox txDesignation;
		private System.Windows.Forms.TextBox txCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private OleDbTransaction Transac;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AcReglements(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
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

		private void InitializeData()
		{
			oleDbConnection1.Open();
			try
			{
				oleDbDataAdapter1.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			DataTable Table = dataSet11.Tables["T_reglement"];
			mtgcComboBox1.SourceDataString = new string[] {"Designation","","",""};
			mtgcComboBox1.SourceDataTable = dataSet11.Tables["T_reglement"];
			oleDbConnection1.Close();
			Nouveau=true;
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AcReglements));
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
			this.txDesignation = new System.Windows.Forms.TextBox();
			this.txCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
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
			this.btSupprime.Click += new System.EventHandler(this.btSupprime_Click);
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
			this.btNouveau.Text = "R A Z";
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
																										new System.Data.Common.DataTableMapping("Table", "T_Reglement", new System.Data.Common.DataColumnMapping[] {
																																																					   new System.Data.Common.DataColumnMapping("Code", "Code"),
																																																					   new System.Data.Common.DataColumnMapping("Designation", "Designation")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_Reglement WHERE (Code = ?) AND (Designation = ? OR ? IS NULL AND De" +
				"signation IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_Reglement(Code, Designation) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 8, "Code"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Code, Designation FROM T_Reglement";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_Reglement SET Code = ?, Designation = ? WHERE (Code = ?) AND (Designatio" +
				"n = ? OR ? IS NULL AND Designation IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 8, "Code"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Designation", System.Data.OleDb.OleDbType.VarWChar, 255, "Designation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Designation1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Designation", System.Data.DataRowVersion.Original, null));
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
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Gainsboro;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(525, 243);
			this.tabControlEX1.TabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.TabIndex = 17;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.mtgcComboBox1);
			this.tabPageEX1.Controls.Add(this.txDesignation);
			this.tabPageEX1.Controls.Add(this.txCode);
			this.tabPageEX1.Controls.Add(this.label3);
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(125, 27);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(271, 21);
			this.mtgcComboBox1.TabIndex = 18;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// txDesignation
			// 
			this.txDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txDesignation.Location = new System.Drawing.Point(125, 107);
			this.txDesignation.Name = "txDesignation";
			this.txDesignation.Size = new System.Drawing.Size(272, 20);
			this.txDesignation.TabIndex = 17;
			this.txDesignation.Text = "";
			// 
			// txCode
			// 
			this.txCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCode.Location = new System.Drawing.Point(125, 67);
			this.txCode.MaxLength = 2;
			this.txCode.Name = "txCode";
			this.txCode.TabIndex = 16;
			this.txCode.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "Designation";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Code";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 13;
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
			this.button2.Location = new System.Drawing.Point(459, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 48);
			this.button2.TabIndex = 18;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AcReglements
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(515, 246);
			this.ControlBox = false;
			this.Controls.Add(this.tabControlEX1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "AcReglements";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reglements";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			mtgcComboBox1.SelectedIndex=-1;
			txCode.Clear();
			txCode.ReadOnly=false;
			txDesignation.Clear();
			Nouveau=true;
		}

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			if(txCode.Text.Length==0&&txDesignation.Text.Length==0)
				MessageBox.Show("Rien à supprimer !");
			else
			{
				if(MessageBox.Show("Suppression ?","Attention",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
				{
					
					oleDbDataAdapter1.Fill(dataSet11);
					DataTable Table = dataSet11.Tables["T_reglement"];
					foreach(DataRow row in Table.Rows)
					{
						if(row["Designation"].ToString().Equals(txDesignation.Text))
						{
							row.Delete();
						}
					}
					oleDbConnection1.Open();
					Transac = oleDbConnection1.BeginTransaction();
					oleDbDeleteCommand1.Transaction=Transac;
					
					try
					{
						oleDbDataAdapter1.Update(dataSet11);
						Transac.Commit();
					}
					catch(Exception exp)
					{
						try
						{
							Transac.Rollback();
							MessageBox.Show(exp.Message);
						}
						catch(OleDbException excep)
						{
							MessageBox.Show("Problème lors du rollback !");
							MessageBox.Show(excep.Message);
						}							
					}
					finally
					{
						oleDbConnection1.Close();
					}
					txCode.Clear();
					txDesignation.Clear();
					mtgcComboBox1.Items.Clear();
					oleDbDataAdapter1.Fill(dataSet11);
					mtgcComboBox1.Text="";
					foreach(DataRow row2 in Table.Rows)
					{
						mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row2["Designation"].ToString(),"","",""));
					}
					mtgcComboBox1.SelectedIndex=-1;
				}
			}
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			if(txDesignation.Text.Length==0)
			{
				MessageBox.Show("Champ vide interdit !");
			}
			else
			{
				oleDbDataAdapter1.Fill(dataSet11);
				DataTable Table = dataSet11.Tables["T_reglement"];
				bool save=true;
				if(Nouveau)
				{
					foreach(DataRow row in Table.Rows)
					{
						if(row["Code"].ToString().ToUpper().Equals(txCode.Text.ToUpper()))
						{
							MessageBox.Show("Code déja présent dans la base !","Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							save=false;
						}
					}
				}
				if(save)
				{
					if(Nouveau)
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						oleDbInsertCommand1.Transaction=Transac;
						DataRow newrow = Table.NewRow();
						newrow["Code"]=txCode.Text.ToUpper();
						newrow["Designation"]=txDesignation.Text.ToUpper();
						Table.Rows.Add(newrow);
						
						try
						{
							MessageBox.Show("!!!");
							oleDbDataAdapter1.Update(dataSet11);
							Transac.Commit();
						}
						catch(Exception exp)
						{
							try
							{
								Transac.Rollback();
								MessageBox.Show(exp.Message);
							}
							catch(OleDbException excep)
							{
								MessageBox.Show("Problème lors du Rollback !");
								MessageBox.Show(excep.Message);
							}							
						}
						finally
						{
							oleDbConnection1.Close();
						}
						txCode.Clear();
						txDesignation.Clear();
						mtgcComboBox1.Items.Clear();
						oleDbDataAdapter1.Fill(dataSet11);
						foreach(DataRow row2 in Table.Rows)
						{
							mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row2["Designation"].ToString(),"","",""));
						}
						mtgcComboBox1.SelectedIndex=-1;
					}
					else
					{
						oleDbConnection1.Open();
						OleDbCommand Comm = new OleDbCommand();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.Connection=oleDbConnection1;
						Comm.CommandText="update t_reglement set designation ='"+txDesignation.Text+"' where code='"+txCode.Text+"'";
						try
						{
							Comm.ExecuteNonQuery();
							try
							{
								Transac.Commit();
								MessageBox.Show("Mise à jour OK");
							}
							catch(OleDbException Excp)
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
			}
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DataTable Table = dataSet11.Tables["T_reglement"];
			foreach (DataRow row in Table.Rows)
			{
				if(mtgcComboBox1.Text.Equals(row["Designation"]))
				{
					txCode.Text=row["Code"].ToString();
					txDesignation.Text=row["Designation"].ToString();
					Nouveau=false;
					txCode.ReadOnly=true;
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

	}
}
