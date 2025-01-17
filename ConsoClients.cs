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
	/// Description résumée de ConsoClients.
	/// </summary>
	public class ConsoClients : System.Windows.Forms.Form
	{
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private MTGCComboBox mtgcComboBox3;
		private MTGCComboBox mtgcComboBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label1;
		private OleDbCommand Comm;
		private DataSet ds;
		private OleDbDataAdapter DataAD;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private int Page;
		private int countRow;
		private string NomFourn;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ConsoClients(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD=new OleDbDataAdapter();
			ds=new DataSet();
			this.Agence=Agence;
			Page=0;
			countRow=0;
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
			Comm.CommandText="SELECT nom,ident,groupe,usine FROM t_clients ORDER BY nom";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"clients");
			mtgcComboBox1.SourceDataTable=ds.Tables["clients"];
			mtgcComboBox1.SourceDataString=new string[]{"nom","ident","groupe","usine"};
			mtgcComboBox2.Items.Add(new MTGCComboBoxItem("Tous types machine","","",""));
			mtgcComboBox2.Items.Add(new MTGCComboBoxItem("Pièces","","",""));
			mtgcComboBox2.Items.Add(new MTGCComboBoxItem("Type machine selectionné","","",""));
			
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ConsoClients));
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mtgcComboBox3 = new MTGCComboBox();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
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
																										new System.Data.Common.DataTableMapping("Table", "T_clients", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Ident", "Ident"),
																																																					 new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																					 new System.Data.Common.DataColumnMapping("Usine", "Usine"),
																																																					 new System.Data.Common.DataColumnMapping("Groupe", "Groupe")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_clients WHERE (Ident = ?) AND (Groupe = ? OR ? IS NULL AND Groupe I" +
				"S NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Usine = ? OR ? IS NULL A" +
				"ND Usine IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_clients(Ident, Nom, Usine, Groupe) VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Ident, Nom, Usine, Groupe FROM T_clients ORDER BY Nom";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_clients SET Ident = ?, Nom = ?, Usine = ?, Groupe = ? WHERE (Ident = ?) " +
				"AND (Groupe = ? OR ? IS NULL AND Groupe IS NULL) AND (Nom = ? OR ? IS NULL AND N" +
				"om IS NULL) AND (Usine = ? OR ? IS NULL AND Usine IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lavender;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(312, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 59;
			this.button1.Text = "Visualiser";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lavender;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Blue;
			this.button3.Location = new System.Drawing.Point(424, 184);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 58;
			this.button3.Text = "Imprimer";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.mtgcComboBox3);
			this.groupBox1.Controls.Add(this.mtgcComboBox2);
			this.groupBox1.Location = new System.Drawing.Point(13, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 104);
			this.groupBox1.TabIndex = 57;
			this.groupBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(248, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Type machine";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(256, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Selection";
			// 
			// mtgcComboBox3
			// 
			this.mtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox3.ColumnNum = 1;
			this.mtgcComboBox3.ColumnWidth = "121";
			this.mtgcComboBox3.DisplayMember = "Text";
			this.mtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox3.DropDownWidth = 141;
			this.mtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox3.GridLineHorizontal = false;
			this.mtgcComboBox3.GridLineVertical = false;
			this.mtgcComboBox3.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox3.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox3.Location = new System.Drawing.Point(8, 72);
			this.mtgcComboBox3.ManagingFastMouseMoving = true;
			this.mtgcComboBox3.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox3.Name = "mtgcComboBox3";
			this.mtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox3.Size = new System.Drawing.Size(256, 21);
			this.mtgcComboBox3.TabIndex = 1;
			this.mtgcComboBox3.Visible = false;
			// 
			// mtgcComboBox2
			// 
			this.mtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox2.ColumnNum = 1;
			this.mtgcComboBox2.ColumnWidth = "121";
			this.mtgcComboBox2.DisplayMember = "Text";
			this.mtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox2.DropDownWidth = 141;
			this.mtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox2.GridLineHorizontal = false;
			this.mtgcComboBox2.GridLineVertical = false;
			this.mtgcComboBox2.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox2.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox2.Location = new System.Drawing.Point(10, 32);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(254, 21);
			this.mtgcComboBox2.TabIndex = 0;
			this.mtgcComboBox2.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox2_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(13, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 56;
			this.label5.Text = "Format de date incorrect";
			this.label5.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(133, 80);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 55;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(13, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 54;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(165, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 53;
			this.label3.Text = "Fin";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(37, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 52;
			this.label2.Text = "Début";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.mtgcComboBox1);
			this.groupBox2.Location = new System.Drawing.Point(296, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(392, 88);
			this.groupBox2.TabIndex = 51;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Choix de l\'impression";
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(184, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(144, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Totalité synthèse";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(72, 24);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 0;
			this.radioButton4.Text = "Client";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 3;
			this.mtgcComboBox1.ColumnWidth = "200;50;150";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 141;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = true;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(16, 56);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(360, 21);
			this.mtgcComboBox1.TabIndex = 40;
			this.mtgcComboBox1.ValueMember = "Code";
			this.mtgcComboBox1.Visible = false;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
			this.button7.Location = new System.Drawing.Point(648, 176);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(48, 48);
			this.button7.TabIndex = 50;
			this.button7.TabStop = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(379, 32);
			this.label1.TabIndex = 49;
			this.label1.Text = "Consommation pièces clients";
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(159, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// ConsoClients
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(706, 232);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ConsoClients";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consommation pièces clients";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(mtgcComboBox2.SelectedIndex.Equals(0))
				{
					if(radioButton3.Checked)
					{
						foreach(DataRow row in ds.Tables["clients"].Rows)
						{
							try
							{
								Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM ((T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_fournisseurs ON T_type_machine.Fournisseur = T_fournisseurs.Code WHERE ((((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# AND (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#)) AND ((T_clients.Nom)='"+row["nom"].ToString().Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code"; 
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"Select");
								if(ds.Tables["Select"].Rows.Count>0)
								{
									if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
									{
										NomFourn=row["nom"].ToString();
										Page=0;
										countRow=0;
										printPreviewDialog1.Document=printDocument1;
										printPreviewDialog1.ShowDialog();
										countRow=0;
										Page=0;
										ds.Tables["Select"].Clear();
									}
									else
										break;
								}
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
					else
					{
						Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis], T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_pieces_detachees INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = t_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#) AND ((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code"; 
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"Select");
							if(ds.Tables["Select"].Rows.Count>0)
							{
								NomFourn=mtgcComboBox1.Text;
								Page=0;
								countRow=0;
								printPreviewDialog1.Document=printDocument1;
								printPreviewDialog1.ShowDialog();
								ds.Tables["Select"].Clear();
							}
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}

				}
				else if(mtgcComboBox2.SelectedIndex.Equals(1))
				{
					if(radioButton3.Checked)
					{
						foreach(DataRow row in ds.Tables["clients"].Rows)
						{
							try
							{
								Comm.CommandText="SELECT T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_fournisseurs INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE ((((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# AND (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#)) AND ((T_clients.Nom)='"+row["nom"].ToString().Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation ORDER BY T_fournisseurs.Nom, T_pieces_detachees.Code";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"Select");
								if(ds.Tables["Select"].Rows.Count>0)
								{
									if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
									{
										NomFourn=row["nom"].ToString();
										Page=0;
										countRow=0;
										printPreviewDialog1.Document=printDocument1;
										printPreviewDialog1.ShowDialog();
										ds.Tables["Select"].Clear();
									}
									else
										break;
								}
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
					else
					{
						Comm.CommandText="SELECT T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_fournisseurs INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE ((((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# AND (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#)) AND ((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation ORDER BY T_fournisseurs.Nom, T_pieces_detachees.Code";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							NomFourn=mtgcComboBox1.Text;
							Page=0;
							countRow=0;
							printPreviewDialog1.Document=printDocument1;
							printPreviewDialog1.ShowDialog();
							ds.Tables["Select"].Clear();
						}
					}
				}
				else if(mtgcComboBox2.SelectedIndex.Equals(2))
				{
					if(radioButton3.Checked)
					{
						foreach(DataRow row in ds.Tables["clients"].Rows)
						{
							try
							{
								Comm.CommandText="SELECT T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM T_famille_machine INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_pieces_detachees INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = t_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#) AND ((T_clients.Nom)='"+row["nom"].ToString().Replace("'","''")+"') AND ((T_parc_machine.[Type machine])='"+mtgcComboBox3.Text.Replace("'","''")+"')) GROUP BY T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"Select");
								if(ds.Tables["Select"].Rows.Count>0)
								{
									if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
									{
										NomFourn=row["nom"].ToString();
										Page=0;
										countRow=0;
										printPreviewDialog1.Document=printDocument1;
										printPreviewDialog1.ShowDialog();
										ds.Tables["Select"].Clear();
									}
									else
										break;
								}
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
					else
					{
						Comm.CommandText="SELECT T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM T_famille_machine INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_pieces_detachees INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = t_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#) AND ((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"') AND ((T_parc_machine.[Type machine])='"+mtgcComboBox3.Text.Replace("'","''")+"')) GROUP BY T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							NomFourn=mtgcComboBox1.Text;
							Page=0;
							countRow=0;
							printPreviewDialog1.Document=printDocument1;
							printPreviewDialog1.ShowDialog();
							ds.Tables["Select"].Clear();
						}
						else
						{
							MessageBox.Show("Aucun résultat");
						}
					}
				}
				else
				{
					MessageBox.Show("Veuillez effectuer une sélection SVP");
				}
			}
			catch(Exception exp)
			{
				label5.Visible=true;
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void mtgcComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox2.SelectedIndex.Equals(2))
			{
				mtgcComboBox3.Items.Clear();
				if(mtgcComboBox1.SelectedIndex>0)
					Comm.CommandText="SELECT T_type_machine.Code, T_clients.Nom FROM T_clients INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_clients.Ident = T_parc_machine.[Code Client] GROUP BY T_type_machine.Code, T_clients.Nom HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"'))";

				else
					Comm.CommandText="SELECT T_type_machine.Code FROM T_type_machine GROUP BY T_type_machine.Code";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"types");
				mtgcComboBox3.SourceDataString=new string[]{"Code","","",""};
				mtgcComboBox3.SourceDataTable=ds.Tables["types"];
				mtgcComboBox3.Visible=true;
				ds.Tables["types"].Clear();
			}
			else
				mtgcComboBox3.Visible=false;
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox1.SelectedIndex>0)
			{
				mtgcComboBox2.Visible=true;
			}
			mtgcComboBox3.Items.Clear();
			if(mtgcComboBox1.SelectedIndex>0)
				Comm.CommandText="SELECT T_type_machine.Code, T_clients.Nom FROM T_clients INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_clients.Ident = T_parc_machine.[Code Client] GROUP BY T_type_machine.Code, T_clients.Nom HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"'))";

			else
				Comm.CommandText="SELECT T_type_machine.Code FROM T_type_machine GROUP BY T_type_machine.Code";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"types");
			mtgcComboBox3.SourceDataString=new string[]{"Code","","",""};
			mtgcComboBox3.SourceDataTable=ds.Tables["types"];
			ds.Tables["types"].Clear();
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue!=8)
			{
				if(textBox1.TextLength.Equals(2))
				{
					textBox1.Text+="/";
					textBox1.Select(3,1);
				}
				else if(textBox1.TextLength.Equals(5))
				{
					textBox1.Text+="/";
					textBox1.Select(6,1);
				}
				else if(textBox1.TextLength.Equals(7))
					textBox2.Focus();
			}
		}

		private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue!=8)
			{
				if(textBox2.TextLength.Equals(2))
				{
					textBox2.Text+="/";
					textBox2.Select(3,1);
				}
				else if(textBox2.TextLength.Equals(5))
				{
					textBox2.Text+="/";
					textBox2.Select(6,1);
				}
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			Page+=1;
			int ypos=e.MarginBounds.Top;
			e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,e.MarginBounds.Top), new Point(e.MarginBounds.Right,e.MarginBounds.Top));
			ypos+=5;
			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				e.Graphics.DrawString("Consommation pièces par type machine pour le client", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString(NomFourn, new Font("Arial", 12, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString("Du "+textBox1.Text+" au "+textBox2.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			else
			{
				e.Graphics.DrawString("Consommation pièces pour le client", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString(NomFourn, new Font("Arial", 12, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
				ypos+=20;
				e.Graphics.DrawString("Du "+textBox1.Text+" au "+textBox2.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			}
			ypos+=30;
			string AncienFourn=null;
			string AncienType=null;
			bool debut=true;
			int cpt=0;
			if(mtgcComboBox2.SelectedIndex.Equals(0))
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["Select"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						AncienFourn=ds.Tables["Select"].Rows[countRow-1]["Nom"].ToString();
						AncienType=ds.Tables["Select"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(AncienFourn!=ds.Tables["Select"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Blue, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					if(AncienType!=ds.Tables["Select"].Rows[countRow]["Type machine"].ToString())
					{
						cpt=0;
						Comm.CommandText="SELECT t_clients.nom,T_devis_entete.[N° Devis] FROM T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_parc_machine.[Type machine])='"+ds.Tables["Select"].Rows[countRow]["Type machine"].ToString()+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#)) GROUP BY T_clients.nom,T_devis_entete.[N° Devis] HAVING (((T_clients.Nom)='"+NomFourn+"'))";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"Devis");
						}
						catch(Exception ex)
						{
							Console.WriteLine(ex.Message);
						}
						cpt=ds.Tables["devis"].Rows.Count;
						ds.Tables["devis"].Clear();
						e.Graphics.DrawString("Type machine :      "+ds.Tables["Select"].Rows[countRow]["Type machine"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Désignation :      "+ds.Tables["Select"].Rows[countRow]["T_famille_machine.Designation"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+200, ypos);
						e.Graphics.DrawString("Nbre devis :      "+cpt.ToString(),
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Blue, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
						e.Graphics.DrawString("Code pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Désignation pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
						e.Graphics.DrawString("quantité", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Code"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["T_pieces_detachees.Designation"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["SommeDeQuantite"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+530, ypos);
					Decimal Pourcent=0;
					try
					{
						Pourcent=System.Convert.ToDecimal(ds.Tables["Select"].Rows[countRow]["SommeDeQuantite"].ToString())/cpt;
					
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
						Pourcent=0;
					}
					Pourcent=Pourcent*100;
					e.Graphics.DrawString(Pourcent.ToString("0.00")+"%",
						new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+550, ypos);
					ypos+=15;
					countRow+=1;
				}
			}
			else if(mtgcComboBox2.SelectedIndex.Equals(2))
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["Select"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						AncienFourn=ds.Tables["Select"].Rows[countRow-1]["Nom"].ToString();
						AncienType=ds.Tables["Select"].Rows[countRow-1]["Type machine"].ToString();
					}
					if(AncienFourn!=ds.Tables["Select"].Rows[countRow]["Nom"].ToString())
					{
						e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Blue, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					if(AncienType!=ds.Tables["Select"].Rows[countRow]["Type machine"].ToString())
					{
						cpt=0;
						Comm.CommandText="SELECT t_clients.nom,T_devis_entete.[N° Devis] FROM T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] WHERE (((T_parc_machine.[Type machine])='"+ds.Tables["Select"].Rows[countRow]["Type machine"].ToString()+"') AND ((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#)) GROUP BY T_clients.nom,T_devis_entete.[N° Devis] HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"'))";
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"Devis");
						}
						catch(Exception ex)
						{
							Console.WriteLine(ex.Message);
						}
						cpt=ds.Tables["devis"].Rows.Count;
						ds.Tables["devis"].Clear();
						e.Graphics.DrawString("Type machine :      "+ds.Tables["Select"].Rows[countRow]["Type machine"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Désignation :      "+ds.Tables["Select"].Rows[countRow]["T_famille_machine.Designation"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+200, ypos);
						e.Graphics.DrawString("Nbre devis :      "+cpt.ToString(),
							new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Blue, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
						e.Graphics.DrawString("Code pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Désignation pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
						e.Graphics.DrawString("quantité", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Code"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["T_pieces_detachees.Designation"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["SommeDeQuantite"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+530, ypos);
					Decimal Pourcent=System.Convert.ToDecimal(ds.Tables["Select"].Rows[countRow]["SommeDeQuantite"].ToString())/cpt;
					Pourcent=Pourcent*100;
					e.Graphics.DrawString(Pourcent.ToString("0.00")+"%",
						new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+550, ypos);
					ypos+=15;
					countRow+=1;
				}
			}
			else if(mtgcComboBox2.SelectedIndex.Equals(1))
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["Select"].Rows.Count)
				{
					if(debut)
						debut=false;
					else
					{
						AncienFourn=ds.Tables["Select"].Rows[countRow-1]["Nom"].ToString();
					}
					if(AncienFourn!=ds.Tables["Select"].Rows[countRow]["Nom"].ToString())
					{
						ypos+=10;
						e.Graphics.DrawLine(new Pen(Color.Blue, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
						e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Nom"].ToString(), 
							new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+200, ypos);
						ypos+=20;
						e.Graphics.DrawLine(new Pen(Color.Blue, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
						e.Graphics.DrawString("Code pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						e.Graphics.DrawString("Désignation pièce", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
						e.Graphics.DrawString("quantité", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
						ypos+=15;
						e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
						ypos+=10;
					}
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Code"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["Designation"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos);
					e.Graphics.DrawString(ds.Tables["Select"].Rows[countRow]["SommeDeQuantite"].ToString(), 
						new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+530, ypos);
					ypos+=15;
					countRow+=1;
				}
			}
			ypos+=25;
			e.Graphics.DrawString(DateTime.Now.ToLongDateString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Page "+Page.ToString(), 
				new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right-50, ypos);
			if(countRow<ds.Tables["Select"].Rows.Count)
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
			}

		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton4.Checked)
				mtgcComboBox1.Visible=true;
			else
				mtgcComboBox1.Visible=false;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(mtgcComboBox2.SelectedIndex.Equals(0))
				{
					if(radioButton3.Checked)
					{
						foreach(DataRow row in ds.Tables["clients"].Rows)
						{
							try
							{
								Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM ((T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_fournisseurs ON T_type_machine.Fournisseur = T_fournisseurs.Code WHERE ((((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# AND (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#)) AND ((T_clients.Nom)='"+row["nom"].ToString().Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code"; 
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"Select");
								if(ds.Tables["Select"].Rows.Count>0)
								{
									if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
									{
										NomFourn=row["nom"].ToString();
										Page=0;
										countRow=0;
										printDocument1.Print();
										countRow=0;
										Page=0;
										ds.Tables["Select"].Clear();
									}
									else
										break;
								}
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
					else
					{
						Comm.CommandText="SELECT T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis], T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_pieces_detachees INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = t_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#) AND ((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_fournisseurs.Nom, T_parc_machine.[Type machine], T_pieces_detachees.Code"; 
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"Select");
							if(ds.Tables["Select"].Rows.Count>0)
							{
								NomFourn=mtgcComboBox1.Text;
								Page=0;
								countRow=0;
								printDocument1.Print();
								ds.Tables["Select"].Clear();
							}
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}

				}
				else if(mtgcComboBox2.SelectedIndex.Equals(1))
				{
					if(radioButton3.Checked)
					{
						foreach(DataRow row in ds.Tables["clients"].Rows)
						{
							try
							{
								Comm.CommandText="SELECT T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_fournisseurs INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE ((((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# AND (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#)) AND ((T_clients.Nom)='"+row["nom"].ToString().Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation ORDER BY T_fournisseurs.Nom, T_pieces_detachees.Code";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"Select");
								if(ds.Tables["Select"].Rows.Count>0)
								{
									if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
									{
										NomFourn=row["nom"].ToString();
										Page=0;
										countRow=0;
										printDocument1.Print();
										ds.Tables["Select"].Clear();
									}
									else
										break;
								}
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
					else
					{
						Comm.CommandText="SELECT T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite FROM T_fournisseurs INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN (t_devis_lignes INNER JOIN T_pieces_detachees ON t_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur) ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal] WHERE ((((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+"# AND (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+"#)) AND ((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"')) GROUP BY T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation ORDER BY T_fournisseurs.Nom, T_pieces_detachees.Code";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							NomFourn=mtgcComboBox1.Text;
							Page=0;
							countRow=0;
							printDocument1.Print();
							ds.Tables["Select"].Clear();
						}
					}
				}
				else if(mtgcComboBox2.SelectedIndex.Equals(2))
				{
					if(radioButton3.Checked)
					{
						foreach(DataRow row in ds.Tables["clients"].Rows)
						{
							try
							{
								Comm.CommandText="SELECT T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM T_famille_machine INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_pieces_detachees INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = t_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#) AND ((T_clients.Nom)='"+row["nom"].ToString().Replace("'","''")+"') AND ((T_parc_machine.[Type machine])='"+mtgcComboBox3.Text.Replace("'","''")+"')) GROUP BY T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code";
								DataAD.SelectCommand=Comm;
								DataAD.Fill(ds,"Select");
								if(ds.Tables["Select"].Rows.Count>0)
								{
									if(MessageBox.Show("Poursuivre ?","Attention",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
									{
										NomFourn=row["nom"].ToString();
										Page=0;
										countRow=0;
										printDocument1.Print();
										ds.Tables["Select"].Clear();
									}
									else
										break;
								}
							}
							catch(Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
					else
					{
						Comm.CommandText="SELECT T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, Sum(t_devis_lignes.Quantite) AS SommeDeQuantite, T_famille_machine.Designation FROM T_famille_machine INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_pieces_detachees INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = t_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#) AND ((T_clients.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"') AND ((T_parc_machine.[Type machine])='"+mtgcComboBox3.Text.Replace("'","''")+"')) GROUP BY T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code, T_pieces_detachees.Designation, T_famille_machine.Designation ORDER BY T_parc_machine.[Type machine], T_fournisseurs.Nom, T_pieces_detachees.Code";
						DataAD.SelectCommand=Comm;
						DataAD.Fill(ds,"Select");
						if(ds.Tables["Select"].Rows.Count>0)
						{
							NomFourn=mtgcComboBox1.Text;
							Page=0;
							countRow=0;
							printDocument1.Print();
							ds.Tables["Select"].Clear();
						}
						else
						{
							MessageBox.Show("Aucun résultat");
						}
					}
				}
				else
				{
					MessageBox.Show("Veuillez effectuer une sélection SVP");
				}
			}
			catch(Exception exp)
			{
				label5.Visible=true;
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked)
			{
				mtgcComboBox3.Items.Clear();
				Comm.CommandText="SELECT T_type_machine.Code FROM T_type_machine ORDER BY T_type_machine.Code";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"types");
				mtgcComboBox3.SourceDataTable=ds.Tables["types"];
				mtgcComboBox3.SourceDataString=new string[]{"Code","","",""};
				ds.Tables["types"].Clear();

			}
		}
	}
}
