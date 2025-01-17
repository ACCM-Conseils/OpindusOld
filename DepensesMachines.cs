using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Opindus
{
	/// <summary>
	/// Description résumée de DepensesMachines.
	/// </summary>
	public class DepensesMachines : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button button1;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private MTGCComboBox mtgcComboBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private DataSet ds;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private int Page;
		private int countRow;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private string ancienfourn;
		private string ancienclient;
		private string ancienmat;
		private string anciendevis;
		private string ancienmabec;
		private string ancientroncon;
		private bool debut=true;
		private Decimal Preventif=0;
		private Decimal Manquant=0;
		private Decimal Casse=0;
        private Decimal CA = 0;
        private Decimal Pieces = 0;
        private Decimal DNR = 0;
		private Decimal Usure=0;
		private Decimal Autres=0;
		private Decimal Port=0;
		private int Machines=0;
		private int GeneralMachines=0;
		private Decimal TotalPreventif=0;
		private Decimal TotalManquant=0;
		private Decimal TotalCasse=0;
		private Decimal TotalUsure=0;
		private Decimal TotalAutres=0;
		private Decimal TotalPieces=0;
		private Decimal TotalDNR=0;
		private Decimal TotalControles=0;
		private Decimal TotalCA=0;
        private Decimal TotalMachineCA = 0;
        private Decimal TotalMachineDNR = 0;
        private Decimal TotalMachinePrevention = 0;
        private Decimal TotalMachineManquant = 0;
        private Decimal TotalMachineUsure = 0;
        private Decimal TotalMachineCasse = 0;
        private Decimal TotalMachineAutres = 0;
        private Decimal TotalMachinePieces = 0;
        private Decimal TotalMachineControle = 0;
        private Decimal TotalMachinePort = 0;
		private Decimal TotalPort=0;

		private Decimal TotalPreventifMabec=0;
		private Decimal TotalManquantMabec=0;
		private Decimal TotalCasseMabec=0;
		private Decimal TotalUsureMabec=0;
		private Decimal TotalAutresMabec=0;
		private Decimal TotalPiecesMabec=0;
		private Decimal TotalDNRMabec=0;
		private Decimal TotalControlesMabec=0;
		private Decimal TotalPortMabec=0;
		private Decimal TotalCAMabec=0;

		private Decimal TotalPreventifTroncon=0;
		private Decimal TotalManquantTroncon=0;
		private Decimal TotalCasseTroncon=0;
		private Decimal TotalUsureTroncon=0;
		private Decimal TotalAutresTroncon=0;
		private Decimal TotalPiecesTroncon=0;
		private Decimal TotalDNRTroncon=0;
		private Decimal TotalPortTroncon=0;
		private Decimal TotalControlesTroncon=0;
		private Decimal TotalCATroncon=0;

		private OleDbDataAdapter DataAD;
		private Decimal GeneralPreventif=0;
		private Decimal GeneralManquant=0;
		private Decimal GeneralCasse=0;
		private Decimal GeneralUsure=0;
		private Decimal GeneralAutres=0;
		private Decimal GeneralPieces=0;
		private Decimal GeneralDNR=0;
		private Decimal GeneralControles=0;
		private Decimal GeneralCA=0;
		private Decimal GeneralPort=0;

		private Decimal ClientMachines=0;
		private Decimal ClientPreventif=0;
		private Decimal ClientManquant=0;
		private Decimal ClientCasse=0;
		private Decimal ClientUsure=0;
		private Decimal ClientAutres=0;
		private Decimal ClientPieces=0;
		private Decimal ClientDNR=0;
		private Decimal ClientControles=0;
		private Decimal ClientCA=0;
		private Decimal ClientPort=0;

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.Button button4;
		Object oRien=System.Reflection.Missing.Value;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DepensesMachines(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			DataAD=new OleDbDataAdapter();
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
			oleDbDataAdapter1.Fill(dataSet11);
			foreach(DataRow row in dataSet11.Tables["t_clients"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["nom"].ToString(),row["ident"].ToString(),row["groupe"].ToString(),row["usine"].ToString()));
			}
			mtgcComboBox1.Items.Insert(0, new MTGCComboBoxItem("...","","",""));
			mtgcComboBox1.SelectedIndex=0;
			printDocument1.DefaultPageSettings.Landscape=true;
			printDocument1.DefaultPageSettings.Margins.Bottom=50;
			printPreviewDialog1.SetBounds(0,0,800,600);
			Page=0;
			countRow=0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DepensesMachines));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dépenses clients par machine";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(240, 136);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(448, 20);
			this.textBox3.TabIndex = 4;
			this.textBox3.TabStop = false;
			this.textBox3.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Location = new System.Drawing.Point(136, 176);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(424, 200);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.Enabled = false;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Blue;
			this.button4.Location = new System.Drawing.Point(298, 168);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(110, 23);
			this.button4.TabIndex = 9;
			this.button4.Text = "Export excel";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(157, 168);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Imprimer";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radioButton4);
			this.groupBox3.Controls.Add(this.radioButton3);
			this.groupBox3.Controls.Add(this.radioButton5);
			this.groupBox3.Location = new System.Drawing.Point(17, 36);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(390, 60);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			// 
			// radioButton4
			// 
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(136, 10);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(128, 24);
			this.radioButton4.TabIndex = 1;
			this.radioButton4.Text = "Avec code Mabec";
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(8, 8);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(115, 24);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Edition normale";
			// 
			// radioButton5
			// 
			this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton5.Location = new System.Drawing.Point(8, 32);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(128, 24);
			this.radioButton5.TabIndex = 2;
			this.radioButton5.Text = "Sans détail";
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(24, 13);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(144, 24);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Edition par machine";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(16, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Visualiser";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.radioButton6);
			this.groupBox4.Location = new System.Drawing.Point(16, 120);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(392, 40);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Visible = false;
			// 
			// radioButton6
			// 
			this.radioButton6.Checked = true;
			this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton6.Location = new System.Drawing.Point(8, 8);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(115, 24);
			this.radioButton6.TabIndex = 1;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Edition normale";
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(24, 96);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(248, 24);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.Text = "Edition par regroupement machine";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 4;
			this.mtgcComboBox1.ColumnWidth = "250;50;50;50";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 420;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = true;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(16, 24);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(360, 21);
			this.mtgcComboBox1.TabIndex = 0;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_clients", new System.Data.Common.DataColumnMapping[] {
																																																					 new System.Data.Common.DataColumnMapping("Nom", "Nom"),
																																																					 new System.Data.Common.DataColumnMapping("Adresse_1", "Adresse_1"),
																																																					 new System.Data.Common.DataColumnMapping("Groupe", "Groupe"),
																																																					 new System.Data.Common.DataColumnMapping("Usine", "Usine"),
																																																					 new System.Data.Common.DataColumnMapping("Batiment", "Batiment"),
																																																					 new System.Data.Common.DataColumnMapping("Ident", "Ident")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM T_clients WHERE (Ident = ?) AND (Adresse_1 = ? OR ? IS NULL AND Adresse_1 IS NULL) AND (Batiment = ? OR ? IS NULL AND Batiment IS NULL) AND (Groupe = ? OR ? IS NULL AND Groupe IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Usine = ? OR ? IS NULL AND Usine IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Usine", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO T_clients(Nom, Adresse_1, Groupe, Usine, Batiment, Ident) VALUES (?, " +
				"?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Nom, Adresse_1, Groupe, Usine, Batiment, Ident FROM T_clients ORDER BY Nom" +
				"";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE T_clients SET Nom = ?, Adresse_1 = ?, Groupe = ?, Usine = ?, Batiment = ?, Ident = ? WHERE (Ident = ?) AND (Adresse_1 = ? OR ? IS NULL AND Adresse_1 IS NULL) AND (Batiment = ? OR ? IS NULL AND Batiment IS NULL) AND (Groupe = ? OR ? IS NULL AND Groupe IS NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Usine = ? OR ? IS NULL AND Usine IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, "Adresse_1"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, "Batiment"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ident", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Adresse_11", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse_1", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Batiment1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Batiment", System.Data.DataRowVersion.Original, null));
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
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.groupBox2.Controls.Add(this.radioButton8);
			this.groupBox2.Controls.Add(this.radioButton7);
			this.groupBox2.Controls.Add(this.mtgcComboBox1);
			this.groupBox2.Location = new System.Drawing.Point(16, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(672, 58);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// radioButton8
			// 
			this.radioButton8.Checked = true;
			this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton8.Location = new System.Drawing.Point(394, 23);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(107, 24);
			this.radioButton8.TabIndex = 5;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "Selection";
			// 
			// radioButton7
			// 
			this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton7.Location = new System.Drawing.Point(510, 23);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(107, 24);
			this.radioButton7.TabIndex = 4;
			this.radioButton7.Text = "Tous les clients";
			this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Début";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(128, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Fin";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(240, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(448, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Client sélectionné";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(648, 336);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 48);
			this.button3.TabIndex = 12;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(688, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "T_devis_entete", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Accord Client", "Accord Client"),
																																																						  new System.Data.Common.DataColumnMapping("Calcul Auto", "Calcul Auto"),
																																																						  new System.Data.Common.DataColumnMapping("Cause atelier", "Cause atelier"),
																																																						  new System.Data.Common.DataColumnMapping("Cause client", "Cause client"),
																																																						  new System.Data.Common.DataColumnMapping("Code Client", "Code Client"),
																																																						  new System.Data.Common.DataColumnMapping("Code Materiel", "Code Materiel"),
																																																						  new System.Data.Common.DataColumnMapping("Commande generee", "Commande generee"),
																																																						  new System.Data.Common.DataColumnMapping("Comment", "Comment"),
																																																						  new System.Data.Common.DataColumnMapping("Date", "Date"),
																																																						  new System.Data.Common.DataColumnMapping("Date Decision", "Date Decision"),
																																																						  new System.Data.Common.DataColumnMapping("Date entree reelle", "Date entree reelle"),
																																																						  new System.Data.Common.DataColumnMapping("Date Generation commande", "Date Generation commande"),
																																																						  new System.Data.Common.DataColumnMapping("Date Reception pieces", "Date Reception pieces"),
																																																						  new System.Data.Common.DataColumnMapping("Date reparation", "Date reparation"),
																																																						  new System.Data.Common.DataColumnMapping("Detail atelier", "Detail atelier"),
																																																						  new System.Data.Common.DataColumnMapping("Detail Client", "Detail Client"),
																																																						  new System.Data.Common.DataColumnMapping("Edite", "Edite"),
																																																						  new System.Data.Common.DataColumnMapping("edition_fax", "edition_fax"),
																																																						  new System.Data.Common.DataColumnMapping("Emplacement", "Emplacement"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait Controle", "Forfait Controle"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait DNR", "Forfait DNR"),
																																																						  new System.Data.Common.DataColumnMapping("Forfait transport", "Forfait transport"),
																																																						  new System.Data.Common.DataColumnMapping("Imputation comptable", "Imputation comptable"),
																																																						  new System.Data.Common.DataColumnMapping("Limite Devis", "Limite Devis"),
																																																						  new System.Data.Common.DataColumnMapping("Message Pieds", "Message Pieds"),
																																																						  new System.Data.Common.DataColumnMapping("n° Bl", "n° Bl"),
																																																						  new System.Data.Common.DataColumnMapping("N° Commande generee", "N° Commande generee"),
																																																						  new System.Data.Common.DataColumnMapping("N° Commande ouverte", "N° Commande ouverte"),
																																																						  new System.Data.Common.DataColumnMapping("N° Devis", "N° Devis"),
																																																						  new System.Data.Common.DataColumnMapping("N° Troncon", "N° Troncon"),
																																																						  new System.Data.Common.DataColumnMapping("Niveau", "Niveau"),
																																																						  new System.Data.Common.DataColumnMapping("Ordre Travail", "Ordre Travail"),
																																																						  new System.Data.Common.DataColumnMapping("Prix machine neuve", "Prix machine neuve"),
																																																						  new System.Data.Common.DataColumnMapping("Prix Reference", "Prix Reference"),
																																																						  new System.Data.Common.DataColumnMapping("Reforme", "Reforme"),
																																																						  new System.Data.Common.DataColumnMapping("Refus", "Refus"),
																																																						  new System.Data.Common.DataColumnMapping("Reparateur_D", "Reparateur_D"),
																																																						  new System.Data.Common.DataColumnMapping("Reparateur_R", "Reparateur_R"),
																																																						  new System.Data.Common.DataColumnMapping("Repare", "Repare"),
																																																						  new System.Data.Common.DataColumnMapping("Seuil Client", "Seuil Client"),
																																																						  new System.Data.Common.DataColumnMapping("Seuil devis", "Seuil devis"),
																																																						  new System.Data.Common.DataColumnMapping("Total devis", "Total devis"),
																																																						  new System.Data.Common.DataColumnMapping("Total devis euro", "Total devis euro"),
																																																						  new System.Data.Common.DataColumnMapping("Total pieces", "Total pieces"),
																																																						  new System.Data.Common.DataColumnMapping("Type devis", "Type devis"),
																																																						  new System.Data.Common.DataColumnMapping("Valide", "Valide")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM T_devis_entete WHERE ([N° Devis] = ?) AND ([Accord Client] = ?) AND (" +
				"[Calcul Auto] = ?) AND ([Cause atelier] = ? OR ? IS NULL AND [Cause atelier] IS " +
				"NULL) AND ([Cause client] = ? OR ? IS NULL AND [Cause client] IS NULL) AND ([Cod" +
				"e Client] = ? OR ? IS NULL AND [Code Client] IS NULL) AND ([Code Materiel] = ? O" +
				"R ? IS NULL AND [Code Materiel] IS NULL) AND ([Commande generee] = ? OR ? IS NUL" +
				"L AND [Commande generee] IS NULL) AND ([Date] = ? OR ? IS NULL AND [Date] IS NUL" +
				"L) AND ([Date Decision] = ? OR ? IS NULL AND [Date Decision] IS NULL) AND ([Date" +
				" Generation commande] = ? OR ? IS NULL AND [Date Generation commande] IS NULL) A" +
				"ND ([Date Reception pieces] = ? OR ? IS NULL AND [Date Reception pieces] IS NULL" +
				") AND ([Date entree reelle] = ? OR ? IS NULL AND [Date entree reelle] IS NULL) A" +
				"ND ([Date reparation] = ? OR ? IS NULL AND [Date reparation] IS NULL) AND ([Deta" +
				"il Client] = ? OR ? IS NULL AND [Detail Client] IS NULL) AND ([Detail atelier] =" +
				" ? OR ? IS NULL AND [Detail atelier] IS NULL) AND (Edite = ?) AND (Emplacement =" +
				" ? OR ? IS NULL AND Emplacement IS NULL) AND ([Forfait Controle] = ? OR ? IS NUL" +
				"L AND [Forfait Controle] IS NULL) AND ([Forfait DNR] = ? OR ? IS NULL AND [Forfa" +
				"it DNR] IS NULL) AND ([Forfait transport] = ? OR ? IS NULL AND [Forfait transpor" +
				"t] IS NULL) AND ([Imputation comptable] = ? OR ? IS NULL AND [Imputation comptab" +
				"le] IS NULL) AND ([Limite Devis] = ? OR ? IS NULL AND [Limite Devis] IS NULL) AN" +
				"D ([Message Pieds] = ? OR ? IS NULL AND [Message Pieds] IS NULL) AND (Niveau = ?" +
				" OR ? IS NULL AND Niveau IS NULL) AND ([N° Commande generee] = ? OR ? IS NULL AN" +
				"D [N° Commande generee] IS NULL) AND ([N° Commande ouverte] = ?) AND ([N° Tronco" +
				"n] = ?) AND ([Ordre Travail] = ?) AND ([Prix Reference] = ? OR ? IS NULL AND [Pr" +
				"ix Reference] IS NULL) AND ([Prix machine neuve] = ? OR ? IS NULL AND [Prix mach" +
				"ine neuve] IS NULL) AND (Reforme = ?) AND (Refus = ?) AND (Reparateur_D = ? OR ?" +
				" IS NULL AND Reparateur_D IS NULL) AND (Reparateur_R = ? OR ? IS NULL AND Repara" +
				"teur_R IS NULL) AND (Repare = ?) AND ([Seuil Client] = ? OR ? IS NULL AND [Seuil" +
				" Client] IS NULL) AND ([Seuil devis] = ? OR ? IS NULL AND [Seuil devis] IS NULL)" +
				" AND ([Total devis] = ? OR ? IS NULL AND [Total devis] IS NULL) AND ([Total devi" +
				"s euro] = ? OR ? IS NULL AND [Total devis euro] IS NULL) AND ([Total pieces] = ?" +
				" OR ? IS NULL AND [Total pieces] IS NULL) AND ([Type devis] = ? OR ? IS NULL AND" +
				" [Type devis] IS NULL) AND (Valide = ?) AND (edition_fax = ?) AND ([n° Bl] = ? O" +
				"R ? IS NULL AND [n° Bl] IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Repare", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = @"INSERT INTO T_devis_entete([Accord Client], [Calcul Auto], [Cause atelier], [Cause client], [Code Client], [Code Materiel], [Commande generee], Comment, [Date], [Date Decision], [Date entree reelle], [Date Generation commande], [Date Reception pieces], [Date reparation], [Detail atelier], [Detail Client], Edite, edition_fax, Emplacement, [Forfait Controle], [Forfait DNR], [Forfait transport], [Imputation comptable], [Limite Devis], [Message Pieds], [n° Bl], [N° Commande generee], [N° Commande ouverte], [N° Devis], [N° Troncon], Niveau, [Ordre Travail], [Prix machine neuve], [Prix Reference], Reforme, Refus, Reparateur_D, Reparateur_R, Repare, [Seuil Client], [Seuil devis], [Total devis], [Total devis euro], [Total pieces], [Type devis], Valide) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = @"SELECT [Accord Client], [Calcul Auto], [Cause atelier], [Cause client], [Code Client], [Code Materiel], [Commande generee], Comment, [Date], [Date Decision], [Date entree reelle], [Date Generation commande], [Date Reception pieces], [Date reparation], [Detail atelier], [Detail Client], Edite, edition_fax, Emplacement, [Forfait Controle], [Forfait DNR], [Forfait transport], [Imputation comptable], [Limite Devis], [Message Pieds], [n° Bl], [N° Commande generee], [N° Commande ouverte], [N° Devis], [N° Troncon], Niveau, [Ordre Travail], [Prix machine neuve], [Prix Reference], Reforme, Refus, Reparateur_D, Reparateur_R, Repare, [Seuil Client], [Seuil devis], [Total devis], [Total devis euro], [Total pieces], [Type devis], Valide FROM T_devis_entete";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE T_devis_entete SET [Accord Client] = ?, [Calcul Auto] = ?, [Cause atelier]" +
				" = ?, [Cause client] = ?, [Code Client] = ?, [Code Materiel] = ?, [Commande gene" +
				"ree] = ?, Comment = ?, [Date] = ?, [Date Decision] = ?, [Date entree reelle] = ?" +
				", [Date Generation commande] = ?, [Date Reception pieces] = ?, [Date reparation]" +
				" = ?, [Detail atelier] = ?, [Detail Client] = ?, Edite = ?, edition_fax = ?, Emp" +
				"lacement = ?, [Forfait Controle] = ?, [Forfait DNR] = ?, [Forfait transport] = ?" +
				", [Imputation comptable] = ?, [Limite Devis] = ?, [Message Pieds] = ?, [n° Bl] =" +
				" ?, [N° Commande generee] = ?, [N° Commande ouverte] = ?, [N° Devis] = ?, [N° Tr" +
				"oncon] = ?, Niveau = ?, [Ordre Travail] = ?, [Prix machine neuve] = ?, [Prix Ref" +
				"erence] = ?, Reforme = ?, Refus = ?, Reparateur_D = ?, Reparateur_R = ?, Repare " +
				"= ?, [Seuil Client] = ?, [Seuil devis] = ?, [Total devis] = ?, [Total devis euro" +
				"] = ?, [Total pieces] = ?, [Type devis] = ?, Valide = ? WHERE ([N° Devis] = ?) A" +
				"ND ([Accord Client] = ?) AND ([Calcul Auto] = ?) AND ([Cause atelier] = ? OR ? I" +
				"S NULL AND [Cause atelier] IS NULL) AND ([Cause client] = ? OR ? IS NULL AND [Ca" +
				"use client] IS NULL) AND ([Code Client] = ? OR ? IS NULL AND [Code Client] IS NU" +
				"LL) AND ([Code Materiel] = ? OR ? IS NULL AND [Code Materiel] IS NULL) AND ([Com" +
				"mande generee] = ? OR ? IS NULL AND [Commande generee] IS NULL) AND ([Date] = ? " +
				"OR ? IS NULL AND [Date] IS NULL) AND ([Date Decision] = ? OR ? IS NULL AND [Date" +
				" Decision] IS NULL) AND ([Date Generation commande] = ? OR ? IS NULL AND [Date G" +
				"eneration commande] IS NULL) AND ([Date Reception pieces] = ? OR ? IS NULL AND [" +
				"Date Reception pieces] IS NULL) AND ([Date entree reelle] = ? OR ? IS NULL AND [" +
				"Date entree reelle] IS NULL) AND ([Date reparation] = ? OR ? IS NULL AND [Date r" +
				"eparation] IS NULL) AND ([Detail Client] = ? OR ? IS NULL AND [Detail Client] IS" +
				" NULL) AND ([Detail atelier] = ? OR ? IS NULL AND [Detail atelier] IS NULL) AND " +
				"(Edite = ?) AND (Emplacement = ? OR ? IS NULL AND Emplacement IS NULL) AND ([For" +
				"fait Controle] = ? OR ? IS NULL AND [Forfait Controle] IS NULL) AND ([Forfait DN" +
				"R] = ? OR ? IS NULL AND [Forfait DNR] IS NULL) AND ([Forfait transport] = ? OR ?" +
				" IS NULL AND [Forfait transport] IS NULL) AND ([Imputation comptable] = ? OR ? I" +
				"S NULL AND [Imputation comptable] IS NULL) AND ([Limite Devis] = ? OR ? IS NULL " +
				"AND [Limite Devis] IS NULL) AND ([Message Pieds] = ? OR ? IS NULL AND [Message P" +
				"ieds] IS NULL) AND (Niveau = ? OR ? IS NULL AND Niveau IS NULL) AND ([N° Command" +
				"e generee] = ? OR ? IS NULL AND [N° Commande generee] IS NULL) AND ([N° Commande" +
				" ouverte] = ?) AND ([N° Troncon] = ?) AND ([Ordre Travail] = ?) AND ([Prix Refer" +
				"ence] = ? OR ? IS NULL AND [Prix Reference] IS NULL) AND ([Prix machine neuve] =" +
				" ? OR ? IS NULL AND [Prix machine neuve] IS NULL) AND (Reforme = ?) AND (Refus =" +
				" ?) AND (Reparateur_D = ? OR ? IS NULL AND Reparateur_D IS NULL) AND (Reparateur" +
				"_R = ? OR ? IS NULL AND Reparateur_R IS NULL) AND (Repare = ?) AND ([Seuil Clien" +
				"t] = ? OR ? IS NULL AND [Seuil Client] IS NULL) AND ([Seuil devis] = ? OR ? IS N" +
				"ULL AND [Seuil devis] IS NULL) AND ([Total devis] = ? OR ? IS NULL AND [Total de" +
				"vis] IS NULL) AND ([Total devis euro] = ? OR ? IS NULL AND [Total devis euro] IS" +
				" NULL) AND ([Total pieces] = ? OR ? IS NULL AND [Total pieces] IS NULL) AND ([Ty" +
				"pe devis] = ? OR ? IS NULL AND [Type devis] IS NULL) AND (Valide = ?) AND (editi" +
				"on_fax = ?) AND ([n° Bl] = ? OR ? IS NULL AND [n° Bl] IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Edite", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Repare", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Valide", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null));
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(24, 136);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 13;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(136, 136);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 14;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(24, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Format de date incorrect";
			this.label5.Visible = false;
			// 
			// DepensesMachines
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(704, 392);
			this.ControlBox = false;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DepensesMachines";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Depenses machines";
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void button3_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			printDocument1.DefaultPageSettings.Margins.Left=50;
			printDocument1.DefaultPageSettings.Margins.Right=50;
			Preventif=0;
			Manquant=0;
			Casse=0;
			Usure=0;
			Autres=0;
			Machines=0;
			GeneralMachines=0;
			TotalPreventif=0;
			TotalManquant=0;
			TotalCasse=0;
			TotalUsure=0;
			TotalAutres=0;
			TotalPieces=0;
			TotalDNR=0;
			TotalControles=0;
			TotalCA=0;
			TotalPort=0;

            TotalMachineCA = 0;
            TotalMachineDNR = 0;
            TotalMachinePieces = 0;
            TotalMachineControle = 0;

			TotalPreventifMabec=0;
			TotalManquantMabec=0;
			TotalCasseMabec=0;
			TotalUsureMabec=0;
			TotalAutresMabec=0;
			TotalPiecesMabec=0;
			TotalDNRMabec=0;
			TotalControlesMabec=0;
			TotalCAMabec=0;

			TotalPreventifTroncon=0;
			TotalManquantTroncon=0;
			TotalCasseTroncon=0;
			TotalUsureTroncon=0;
			TotalAutresTroncon=0;
			TotalPiecesTroncon=0;
			TotalDNRTroncon=0;
			TotalControlesTroncon=0;
			TotalCATroncon=0;
			GeneralPreventif=0;
			GeneralManquant=0;
			GeneralCasse=0;
			GeneralUsure=0;
			GeneralAutres=0;
			GeneralPieces=0;
			GeneralDNR=0;
			GeneralControles=0;
			GeneralCA=0;
			GeneralPort=0;
			debut=true;
			ancienfourn=null;
			anciendevis=null;
			ancienmabec=null;
			ancientroncon=null;
			Page=0;
			countRow=0;
			try
			{
				ds.Tables["devis"].Clear();
			}
			catch
			{
			}
			if(radioButton8.Checked)
			{
				if(mtgcComboBox1.SelectedIndex>0)
				{
					mtgcComboBox1.BackColor=Color.Empty;
					DateTime Debut=DateTime.Now;
					DateTime Fin=DateTime.Now;
					try
					{
						debut=true;
						ancienfourn=null;
						anciendevis=null;
						ancienmabec=null;
						ancientroncon=null;
						Debut=System.Convert.ToDateTime(textBox1.Text);
						Fin=System.Convert.ToDateTime(textBox2.Text);
						Page=0;
						countRow=0;
						OleDbCommand Comm = new OleDbCommand();
						if(radioButton1.Checked&&radioButton3.Checked)
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND T_clients.Nom='"+mtgcComboBox1.Text+"') GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						//if(radioButton1.Checked&&radioButton3.Checked)
						//	Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox3.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_fournisseurs.Nom, T_Clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						else if(radioButton1.Checked&&radioButton4.Checked)
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND T_clients.Nom='"+mtgcComboBox1.Text+"') GROUP BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
							//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon], T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]";
						else if(radioButton1.Checked&&radioButton5.Checked)
							//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]"; 
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND T_clients.Nom='"+mtgcComboBox1.Text+"') GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						else if(radioButton2.Checked&&radioButton6.Checked)
                            Comm.CommandText = "SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait transport], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_clients.Nom)='" + mtgcComboBox1.Text + "') AND ((T_devis_entete.[Date reparation])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date reparation])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_fournisseurs.Nom, T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.[Date reparation], T_devis_entete.[N° Devis]"; 
						Comm.Connection=oleDbConnection1;
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"devis");
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						if(ds.Tables["devis"].Rows.Count>0)
						{
							printPreviewDialog1.Document=printDocument1;
							printPreviewDialog1.ShowDialog();
							Preventif=0;
							Manquant=0;
							Casse=0;
							Usure=0;
							Autres=0;
							Machines=0;
							GeneralMachines=0;
							TotalPreventif=0;
							TotalManquant=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalDNR=0;
							TotalControles=0;
							TotalCA=0;
							TotalPort=0;

							TotalPreventifMabec=0;
							TotalManquantMabec=0;
							TotalCasseMabec=0;
							TotalUsureMabec=0;
							TotalAutresMabec=0;
							TotalPiecesMabec=0;
							TotalDNRMabec=0;
							TotalControlesMabec=0;
							TotalCAMabec=0;

							TotalPreventifTroncon=0;
							TotalManquantTroncon=0;
							TotalCasseTroncon=0;
							TotalUsureTroncon=0;
							TotalAutresTroncon=0;
							TotalPiecesTroncon=0;
							TotalDNRTroncon=0;
							TotalControlesTroncon=0;
							TotalCATroncon=0;
							GeneralPreventif=0;
							GeneralManquant=0;
							GeneralCasse=0;
							GeneralUsure=0;
							GeneralAutres=0;
							GeneralPieces=0;
							GeneralDNR=0;
							GeneralControles=0;
							GeneralCA=0;
							GeneralPort=0;
							debut=true;
							ancienfourn=null;
							anciendevis=null;
							ancienmabec=null;
							ancientroncon=null;
							Debut=System.Convert.ToDateTime(textBox1.Text);
							Fin=System.Convert.ToDateTime(textBox2.Text);
							Page=0;
							countRow=0;
						}
						else
							MessageBox.Show("Aucun enregistrement");
					}
					catch(Exception exp)
					{
						label5.Visible=true;
					}
				}
				else
				{
					mtgcComboBox1.BackColor=Color.Salmon;
				}
			}
			else
			{
				DateTime Debut=DateTime.Now;
				DateTime Fin=DateTime.Now;
				try
				{
					debut=true;
					ancienfourn=null;
					anciendevis=null;
					ancienmabec=null;
					ancientroncon=null;
					Debut=System.Convert.ToDateTime(textBox1.Text);
					Fin=System.Convert.ToDateTime(textBox2.Text);
					Page=0;
					countRow=0;
					OleDbCommand Comm = new OleDbCommand();
					/*if(radioButton1.Checked&&radioButton3.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
					else if(radioButton1.Checked&&radioButton4.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_Clients.Nom,T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon], T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]";
					else if(radioButton1.Checked&&radioButton5.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]"; 
					else if(radioButton2.Checked&&radioButton6.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_Clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.[Date reparation], T_devis_entete.[N° Devis]"; */
					if(radioButton1.Checked&&radioButton3.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) ) GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						//if(radioButton1.Checked&&radioButton3.Checked)
						//	Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox3.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_fournisseurs.Nom, T_Clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
					else if(radioButton1.Checked&&radioButton4.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon], T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]";
					else if(radioButton1.Checked&&radioButton5.Checked)
						//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]"; 
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
					else if(radioButton2.Checked&&radioButton6.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_fournisseurs.Nom, T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.[Date reparation], T_devis_entete.[N° Devis]"; 
					Comm.Connection=oleDbConnection1;
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"devis");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					if(ds.Tables["devis"].Rows.Count>0)
					{
						printPreviewDialog1.Document=printDocument1;
						printPreviewDialog1.ShowDialog();

						Preventif=0;
						Manquant=0;
						Casse=0;
						Usure=0;
						Autres=0;
						Machines=0;
						GeneralMachines=0;
						TotalPreventif=0;
						TotalManquant=0;
						TotalCasse=0;
						TotalUsure=0;
						TotalAutres=0;
						TotalPieces=0;
						TotalDNR=0;
						TotalControles=0;
						TotalCA=0;
						TotalPort=0;

						TotalPreventifMabec=0;
						TotalManquantMabec=0;
						TotalCasseMabec=0;
						TotalUsureMabec=0;
						TotalAutresMabec=0;
						TotalPiecesMabec=0;
						TotalDNRMabec=0;
						TotalControlesMabec=0;
						TotalCAMabec=0;

						TotalPreventifTroncon=0;
						TotalManquantTroncon=0;
						TotalCasseTroncon=0;
						TotalUsureTroncon=0;
						TotalAutresTroncon=0;
						TotalPiecesTroncon=0;
						TotalDNRTroncon=0;
						TotalControlesTroncon=0;
						TotalCATroncon=0;
						GeneralPreventif=0;
						GeneralManquant=0;
						GeneralCasse=0;
						GeneralUsure=0;
						GeneralAutres=0;
						GeneralPieces=0;
						GeneralDNR=0;
						GeneralControles=0;
						GeneralCA=0;
						GeneralPort=0;
						debut=true;
						ancienfourn=null;
						anciendevis=null;
						ancienmabec=null;
						ancientroncon=null;
						Debut=System.Convert.ToDateTime(textBox1.Text);
						Fin=System.Convert.ToDateTime(textBox2.Text);
						Page=0;
						countRow=0;
					}
					else
						MessageBox.Show("Aucun enregistrement");
				}
				catch(Exception exp)
				{
					label5.Visible=true;
				}
			}
			
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Page+=1;
			int ypos=e.MarginBounds.Top;
			e.Graphics.DrawString("Dépenses clients par machine", new Font("Arial", 16, FontStyle.Bold), Brushes.DimGray, e.MarginBounds.Left, e.MarginBounds.Top);
			e.Graphics.DrawString("Sorties du "+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+" au "+System.Convert.ToDateTime(textBox2.Text).ToShortDateString(), new Font("Arial", 16, FontStyle.Bold), Brushes.DimGray, e.MarginBounds.Left+500, e.MarginBounds.Top);
			ypos+=40;
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			e.Graphics.DrawString("Fournisseur", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
			e.Graphics.DrawString("Entrée", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+190, ypos);
			e.Graphics.DrawString("Sortie", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+260, ypos);
			e.Graphics.DrawString("Code machine", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
			e.Graphics.DrawString("Type", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
			e.Graphics.DrawString("Préventif", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+490, ypos);
			e.Graphics.DrawString("Manquant", new Font("Arial",7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+550, ypos);
			e.Graphics.DrawString("Casse", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+610, ypos);
			e.Graphics.DrawString("Usure", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+660, ypos);
			e.Graphics.DrawString("Autres", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+710, ypos);
			e.Graphics.DrawString("Tot. pièces", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos);
			e.Graphics.DrawString("DNR", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
			e.Graphics.DrawString("Ctrl", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
			e.Graphics.DrawString("Port", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
			e.Graphics.DrawString("C.A.", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
			ypos+=20;
			e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
			ypos+=10;
			if(radioButton8.Checked)
				e.Graphics.DrawString(mtgcComboBox1.Text, new Font("Arial", 10, FontStyle.Bold|FontStyle.Underline), Brushes.Black, e.MarginBounds.Left+480, ypos);
			ypos+=20;
			if(radioButton1.Checked&&radioButton3.Checked)
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["devis"].Rows.Count)
				{
					try
					{
						anciendevis=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString();
					}
					catch
					{
					}
					if(countRow.Equals(0))
					{
						e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["NomClient"].ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
						
						ypos+=40;
					}
					if(countRow.Equals(0))
					{
						e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
						ypos+=15;
					}
					if(ancienfourn!=ds.Tables["devis"].Rows[countRow]["Nom"].ToString()||countRow.Equals(ds.Tables["devis"].Rows.Count))
					{
						if(!debut)
						{
							TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait transport"].ToString());
							ypos+=5;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=5;
							e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
							e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
							e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
							e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
							e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
							e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
							e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+760, ypos);
							e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
							e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
							e.Graphics.DrawString(TotalPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+935, ypos);
							e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
							GeneralMachines+=Machines;
							GeneralPreventif+=TotalPreventif;
							GeneralManquant+=TotalManquant;
							GeneralCasse+=TotalCasse;
							GeneralUsure+=TotalUsure;
							GeneralAutres+=TotalAutres;
							GeneralPieces+=TotalPieces;
							GeneralDNR+=TotalDNR;
							GeneralControles+=TotalControles;
							GeneralCA+=TotalCA;	
							GeneralPort+=TotalPort;
							ClientMachines+=Machines;
							ClientPreventif+=TotalPreventif;
							ClientManquant+=TotalManquant;
							ClientCasse+=TotalCasse;
							ClientUsure+=TotalUsure;
							ClientAutres+=TotalAutres;
							ClientPieces+=TotalPieces;
							ClientDNR+=TotalDNR;
							ClientControles+=TotalControles;
							ClientCA+=TotalCA;
							ClientPort+=TotalPort;
							Machines=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
							TotalPreventif=0;
							TotalManquant=0;
							TotalPort=0;
							ypos+=20;

							
						}
					if(ancienclient!=ds.Tables["devis"].Rows[countRow]["NomClient"].ToString())
					{
						
						if(!debut)
						{
							//ClientAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait transport"].ToString());
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=5;
							e.Graphics.DrawString("Total client", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(ClientMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
							e.Graphics.DrawString(ClientPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
							e.Graphics.DrawString(ClientManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
							e.Graphics.DrawString(ClientCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
							e.Graphics.DrawString(ClientUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
							e.Graphics.DrawString(ClientAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
							e.Graphics.DrawString(ClientPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+760, ypos);
							e.Graphics.DrawString(ClientDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
							e.Graphics.DrawString(ClientControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
							e.Graphics.DrawString(ClientPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+935, ypos);
							e.Graphics.DrawString(ClientCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);
							/*GeneralMachines+=Machines;
							GeneralPreventif+=TotalPreventif;
							GeneralManquant+=TotalManquant;
							GeneralCasse+=TotalCasse;
							GeneralUsure+=TotalUsure;
							GeneralAutres+=TotalAutres;
							GeneralPieces+=TotalPieces;
							GeneralDNR+=TotalDNR;
							GeneralControles+=TotalControles;
							GeneralCA+=TotalCA;
							GeneralPort+=TotalPort;*/
							ClientMachines+=Machines;
							ClientPreventif+=TotalPreventif;
							ClientManquant+=TotalManquant;
							ClientCasse+=TotalCasse;
							ClientUsure+=TotalUsure;
							ClientAutres+=TotalAutres;
							ClientPieces+=TotalPieces;
							ClientDNR+=TotalDNR;
							ClientControles+=TotalControles;
							ClientCA+=TotalCA;
							ClientPort+=TotalPort;
							Machines=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
							Machines=0;
							TotalPreventif=0;
							TotalManquant=0;
							TotalPort=0;
							
							ypos+=20;
						}

					}
						if((ancienclient!=ds.Tables["devis"].Rows[countRow]["NomClient"].ToString())&&countRow>0)
						{
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=20;
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["NomClient"].ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
							ancienclient=ds.Tables["devis"].Rows[countRow]["NomClient"].ToString();
							ypos+=20;
							ClientMachines=0;
							ClientPreventif=0;
							ClientManquant=0;
							ClientCasse=0;
							ClientUsure=0;
							ClientAutres=0;
							ClientPieces=0;
							ClientDNR=0;
							ClientControles=0;
							ClientCA=0;
							ClientPort=0;
						}
						if((ancienfourn!=ds.Tables["devis"].Rows[countRow]["Nom"].ToString()||countRow.Equals(ds.Tables["devis"].Rows.Count))&&countRow>0)
						{
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=10;
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
							ypos+=15;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
							TotalPreventif=0;
							TotalManquant=0;
							TotalPort=0;
						}

						ancienfourn=ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
						ancienclient=ds.Tables["devis"].Rows[countRow]["NomClient"].ToString();
						
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							TotalAutres+=Autres;
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
								{
									TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}

							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							TotalAutres+=Autres;
						}
						ypos+=15;
					}
					else
					{
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							TotalAutres+=Autres;
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
								{
									TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ypos+=15;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							TotalAutres+=Autres;
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
								{
									TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ypos+=15;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
					}
					debut=false;
					
					countRow++;
				}
				if(countRow==ds.Tables["devis"].Rows.Count)
				{
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
					e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
					Machines++;
					try
					{
						TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString());
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					try
					{
						TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString());
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					try
					{
						TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString());
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					try
					{
						TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					try
					{
						TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString());
						//MessageBox.Show(TotalCA.ToString());
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					Preventif=0;
					Manquant=0;
					Casse=0;
					Usure=0;
					Autres=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(TotalPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+935, ypos);
					e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
					ypos+=15;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=5;
					ClientMachines+=Machines;
					ClientPreventif+=TotalPreventif;
					ClientManquant+=TotalManquant;
					ClientCasse+=TotalCasse;
					ClientUsure+=TotalUsure;
					ClientAutres+=TotalAutres;
					ClientPieces+=TotalPieces;
					ClientDNR+=TotalDNR;
					ClientControles+=TotalControles;
					ClientCA+=TotalCA;
					ClientPort+=TotalPort;

					e.Graphics.DrawString("Total client", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(ClientMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(ClientPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(ClientManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(ClientCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(ClientUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(ClientAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(ClientPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(ClientDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(ClientControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(ClientPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+935, ypos);
					e.Graphics.DrawString(ClientCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);

					
				
					GeneralMachines+=Machines;
					GeneralPreventif+=TotalPreventif;
					GeneralManquant+=TotalManquant;
					GeneralCasse+=TotalCasse;
					GeneralUsure+=TotalUsure;
					GeneralAutres+=TotalAutres;
					GeneralPieces+=TotalPieces;
					GeneralDNR+=TotalDNR;
					GeneralControles+=TotalControles;
					GeneralCA+=TotalCA;
					GeneralPort+=TotalPort;

					ClientMachines=0;
					ClientPreventif=0;
					ClientManquant=0;
					ClientCasse=0;
					ClientUsure=0;
					ClientAutres=0;
					ClientPieces=0;
					ClientDNR=0;
					ClientControles=0;
					ClientCA=0;	
					ClientPort=0;

					Machines=0;
					TotalCasse=0;
					TotalUsure=0;
					TotalAutres=0;
					TotalPieces=0;
					TotalControles=0;
					TotalCA=0;
					TotalPort=0;
					TotalDNR=0;
					Machines=0;
					TotalPreventif=0;
					TotalManquant=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString("Total général", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(GeneralMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(GeneralPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(GeneralManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(GeneralCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(GeneralUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(GeneralAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(GeneralPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(GeneralDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(GeneralControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(GeneralPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
					e.Graphics.DrawString(GeneralCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
					
					GeneralMachines=0;
					GeneralPreventif=0;
					GeneralManquant=0;
					GeneralCasse=0;
					GeneralUsure=0;
					GeneralAutres=0;
					GeneralPieces=0;
					GeneralDNR=0;
					GeneralControles=0;
					GeneralCA=0;
					GeneralPort=0;

					ypos+=20;
					countRow++;
				}
			}
			else if(radioButton1.Checked&&radioButton4.Checked)
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["devis"].Rows.Count)
				{
					if(ancienfourn!=ds.Tables["devis"].Rows[countRow]["Nom"].ToString()||countRow.Equals(ds.Tables["devis"].Rows.Count))
					{
						if(!debut)
						{
							ypos+=5;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=5;
							e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
							e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
							e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
							e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
							e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
							e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
							e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
							e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
							e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
							e.Graphics.DrawString(TotalPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+935, ypos);
							e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
							GeneralMachines+=Machines;
							GeneralPreventif+=TotalPreventif;
							GeneralManquant+=TotalManquant;
							GeneralCasse+=TotalCasse;
							GeneralUsure+=TotalUsure;
							GeneralAutres+=TotalAutres;
							GeneralPieces+=TotalPieces;
							GeneralDNR+=TotalDNR;
							GeneralControles+=TotalControles;
							GeneralCA+=TotalCA;	
							GeneralPort=+TotalPort;
							Machines=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
							TotalPort=0;
							Machines=0;
							TotalPreventif=0;
							TotalManquant=0;
							ypos+=20;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=10;
						}
						ancienfourn=ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
						if(ancientroncon!=ds.Tables["devis"].Rows[countRow]["N° troncon"].ToString())
						{
							if(!debut)
							{
								e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
								ypos+=3;
								e.Graphics.DrawString("Total Troncon", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
								e.Graphics.DrawString(TotalPreventifTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
								e.Graphics.DrawString(TotalManquantTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
								e.Graphics.DrawString(TotalCasseTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
								e.Graphics.DrawString(TotalUsureTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
								e.Graphics.DrawString(TotalAutresTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
								e.Graphics.DrawString(TotalPiecesTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
								e.Graphics.DrawString(TotalDNRTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
								e.Graphics.DrawString(TotalControlesTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
								e.Graphics.DrawString(TotalPortTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+935, ypos);
								e.Graphics.DrawString(TotalCATroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);
								e.Graphics.DrawString(ancientroncon, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+100, ypos);
								TotalPreventifTroncon=0;
								TotalManquantTroncon=0;
								TotalCasseTroncon=0;
								TotalUsureTroncon=0;
								TotalAutresTroncon=0;
								TotalPiecesTroncon=0;
								TotalDNRTroncon=0;
								TotalControlesTroncon=0;
								TotalCATroncon=0;
								TotalPort=0;
								ypos+=15;
							}
							
						}
						if(ancienmabec!=ds.Tables["devis"].Rows[countRow]["Code Mabec"].ToString())
						{
							if(!debut)
							{
								e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
								ypos+=3;
								e.Graphics.DrawString("Total Mabec", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
								e.Graphics.DrawString(TotalPreventifMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
								e.Graphics.DrawString(TotalManquantMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
								e.Graphics.DrawString(TotalCasseMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
								e.Graphics.DrawString(TotalUsureMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
								e.Graphics.DrawString(TotalAutresMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
								e.Graphics.DrawString(TotalPiecesMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
								e.Graphics.DrawString(TotalDNRMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
								e.Graphics.DrawString(TotalControlesMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
								e.Graphics.DrawString(TotalPortMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+935, ypos);
								e.Graphics.DrawString(TotalCAMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
								e.Graphics.DrawString(ancienmabec, new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+100, ypos);
								TotalPreventifMabec=0;
								TotalManquantMabec=0;
								TotalCasseMabec=0;
								TotalUsureMabec=0;
								TotalAutresMabec=0;
								TotalPiecesMabec=0;
								TotalDNRMabec=0;
								TotalControlesMabec=0;
								TotalCAMabec=0;
								TotalPort=0;
								ypos+=15;
							}
						}
						if(ypos>=e.MarginBounds.Height)
							break;
						if(ancienmabec!=ds.Tables["devis"].Rows[countRow]["Code Mabec"].ToString())
						{
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=3;
							e.Graphics.DrawString("Mabec", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code Mabec"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
							ypos+=15;
							ancienmabec=ds.Tables["devis"].Rows[countRow]["Code Mabec"].ToString();
						}
						if(ancientroncon!=ds.Tables["devis"].Rows[countRow]["N° troncon"].ToString())
						{
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=3;
							e.Graphics.DrawString("Troncon", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["N° Troncon"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
							ypos+=15;
							ancientroncon=ds.Tables["devis"].Rows[countRow]["N° Troncon"].ToString();
						}

						if(countRow!=ds.Tables["devis"].Rows.Count-1)
						{
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
							ypos+=15;
						}
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutresTroncon+=Autres;
								TotalAutresMabec+=Autres;
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
								TotalPiecesMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
								TotalPiecesTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
								TotalDNRMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
								TotalDNRTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
								TotalControlesMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
								TotalControlesTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalPortMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalPortTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								TotalCAMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								TotalCATroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
						}
						else
						{

							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutresMabec+=Autres;
								TotalAutresTroncon+=Autres;
								TotalAutres+=Autres;
							}
						}
						ypos+=15;
					}
					else
					{
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutresMabec+=Autres;
								TotalAutresTroncon+=Autres;
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ypos+=15;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
								TotalPiecesMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
								TotalPiecesTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
								TotalDNRMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
								TotalDNRTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
								TotalControlesMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
								TotalControlesTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalPortMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalPortTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								TotalCAMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								TotalCATroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								TotalUsureMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								TotalUsureTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutresMabec+=Autres;
								TotalAutresTroncon+=Autres;
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ypos+=15;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
					}
					debut=false;
					countRow++;
				}
				if(countRow==ds.Tables["devis"].Rows.Count)
				{
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
					e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
					Machines++;
					Preventif=0;
					Manquant=0;
					Casse=0;
					Usure=0;
					Autres=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(TotalPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+935, ypos);
					e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
					GeneralMachines+=Machines;
					GeneralPreventif+=TotalPreventif;
					GeneralManquant+=TotalManquant;
					GeneralCasse+=TotalCasse;
					GeneralUsure+=TotalUsure;
					GeneralAutres+=TotalAutres;
					GeneralPieces+=TotalPieces;
					GeneralDNR+=TotalDNR;
					GeneralControles+=TotalControles;
					GeneralCA+=TotalCA;
					GeneralPort+=TotalPort;
					Machines=0;

					ClientMachines=0;
					ClientPreventif=0;
					ClientManquant=0;
					ClientCasse=0;
					ClientUsure=0;
					ClientAutres=0;
					ClientPieces=0;
					ClientDNR=0;
					ClientControles=0;
					ClientCA=0;
					ClientPort=0;

					TotalCasse=0;
					TotalUsure=0;
					TotalAutres=0;
					TotalPieces=0;
					TotalControles=0;
					TotalCA=0;
					TotalDNR=0;
					TotalPort=0;
					Machines=0;
					TotalPreventif=0;
					TotalManquant=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString(GeneralMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(GeneralPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(GeneralManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(GeneralCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(GeneralUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(GeneralAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(GeneralPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(GeneralDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(GeneralControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(GeneralPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+935, ypos);
					e.Graphics.DrawString(GeneralCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);
					GeneralMachines=0;
					GeneralPreventif=0;
					GeneralManquant=0;
					GeneralCasse=0;
					GeneralUsure=0;
					GeneralAutres=0;
					GeneralPieces=0;
					GeneralDNR=0;
					GeneralControles=0;
					GeneralCA=0;
					GeneralPort=0;
					ypos+=20;
					countRow++;
				}
			}
			if(radioButton1.Checked&&radioButton5.Checked)
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["devis"].Rows.Count)
				{
					if(ancienfourn!=ds.Tables["devis"].Rows[countRow]["Nom"].ToString()||countRow.Equals(ds.Tables["devis"].Rows.Count))
					{
						if(!debut)
						{
							/*ypos+=5;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=5;
							e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
							e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
							e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
							e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
							e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
							e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
							e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
							e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+820, ypos);
							e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+870, ypos);
							e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+925, ypos);*/
							GeneralMachines+=Machines;
							GeneralPreventif+=TotalPreventif;
							GeneralManquant+=TotalManquant;
							GeneralCasse+=TotalCasse;
							GeneralUsure+=TotalUsure;
							GeneralAutres+=TotalAutres;
							GeneralPieces+=TotalPieces;
							GeneralDNR+=TotalDNR;
							GeneralControles+=TotalControles;
							GeneralCA+=TotalCA;	
							GeneralPort+=TotalPort;
							Machines=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
							TotalPort=0;
							Machines=0;
							TotalPreventif=0;
							TotalManquant=0;
							/*ypos+=20;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=10;*/
						}
						ancienfourn=ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
						if(countRow!=ds.Tables["devis"].Rows.Count-1)
						{
							//e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
							//ypos+=15;
						}
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									/*e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+820, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);*/
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
						}
						//ypos+=15;
					}
					else
					{
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									/*e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+820, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);*/
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPort+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									/*e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+820, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);*/
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
					}
					debut=false;
					countRow++;
				}
				if(countRow==ds.Tables["devis"].Rows.Count)
				{
					/*e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
					e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+820, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);*/
					Machines++;
					Preventif=0;
					Manquant=0;
					Casse=0;
					Usure=0;
					Autres=0;
					GeneralMachines+=Machines;
					GeneralPreventif+=TotalPreventif;
					GeneralManquant+=TotalManquant;
					GeneralCasse+=TotalCasse;
					GeneralUsure+=TotalUsure;
					GeneralAutres+=TotalAutres;
					GeneralPieces+=TotalPieces;
					GeneralDNR+=TotalDNR;
					GeneralControles+=TotalControles;
					GeneralCA+=TotalCA;
					GeneralPort+=TotalPort;;
					Machines=0;
					TotalCasse=0;
					TotalUsure=0;
					TotalAutres=0;
					TotalPieces=0;
					TotalControles=0;
					TotalCA=0;
					TotalDNR=0;
					TotalPort=0;
					Machines=0;
					TotalPreventif=0;
					TotalManquant=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString(GeneralMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(GeneralPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(GeneralManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+550, ypos);
					e.Graphics.DrawString(GeneralCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+610, ypos);
					e.Graphics.DrawString(GeneralUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+660, ypos);
					e.Graphics.DrawString(GeneralAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+710, ypos);
					e.Graphics.DrawString(GeneralPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(GeneralDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(GeneralControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(GeneralPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+935, ypos);
					e.Graphics.DrawString(GeneralCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);
					ypos+=20;
					countRow++;
					
				}
			}
			else if(radioButton2.Checked&&radioButton6.Checked)
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["devis"].Rows.Count)
				{
					if(ancienfourn!=ds.Tables["devis"].Rows[countRow]["Nom"].ToString()||countRow.Equals(ds.Tables["devis"].Rows.Count))
					{
						if(!debut)
						{
							ypos+=5;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=5;
							e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
							e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
							e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
							e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
							e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
							e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
							e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+760, ypos);
							e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
							e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
                            e.Graphics.DrawString("", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 935, ypos);
							e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
							GeneralMachines+=Machines;
							GeneralPreventif+=TotalPreventif;
							GeneralManquant+=TotalManquant;
							GeneralCasse+=TotalCasse;
							GeneralUsure+=TotalUsure;
							GeneralAutres+=TotalAutres;
							GeneralPieces+=TotalPieces;
							GeneralDNR+=TotalDNR;
							GeneralControles+=TotalControles;
							GeneralCA+=TotalCA;	
							Machines=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
                            TotalMachineCA = 0;
                            TotalMachineDNR = 0;
                            TotalMachinePrevention = 0;
                            TotalMachineCasse = 0;
                            TotalMachineManquant = 0;
                            TotalMachineUsure = 0;
                            TotalMachineAutres = 0;
                            TotalMachinePieces = 0;
                            TotalMachineControle = 0;
                            TotalMachinePort = 0;
		                    TotalPort=0;
							Machines=0;
							TotalPreventif=0;
							TotalManquant=0;
							ypos+=20;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=10;
						}
						ancienfourn=ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
						if(countRow!=ds.Tables["devis"].Rows.Count-1)
						{
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
							ypos+=15;
						}
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
                            try
                            {
                                TotalPieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
                                Pieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
                            try
                            {
                                TotalDNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
                                DNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
                            try
                            {
                                TotalControles += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
                            try
                            {
                                TotalCA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
                                CA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
                                //MessageBox.Show(TotalCA.ToString());
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }

							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString()!=ds.Tables["devis"].Rows[countRow+1]["Code Materiel"].ToString())
								{
                                    e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10, 9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 180, ypos);
                                    e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10, 9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 250, ypos);
                                    e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 320, ypos);
                                    e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 400, ypos);
                                    e.Graphics.DrawString(TotalMachinePrevention.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                                    e.Graphics.DrawString(TotalMachineManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 560, ypos);
                                    e.Graphics.DrawString(TotalMachineCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 615, ypos);
                                    e.Graphics.DrawString(TotalMachineUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 665, ypos);
                                    e.Graphics.DrawString(TotalMachineAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 715, ypos);
                                    e.Graphics.DrawString(TotalMachinePieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 760, ypos);
                                    e.Graphics.DrawString(TotalMachineDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 815, ypos);
                                    e.Graphics.DrawString(TotalMachineControle.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 875, ypos);
                                    e.Graphics.DrawString("", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 935, ypos);
                                    e.Graphics.DrawString(TotalMachineCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 975, ypos);
                                    Machines++;
                                    Preventif = 0;
                                    Manquant = 0;
                                    Casse = 0;
                                    CA = 0;
                                    Pieces = 0;
                                    DNR = 0;
                                    Usure = 0;
                                    Autres = 0;
                                    TotalMachineCA = 0;
                                    TotalMachineDNR = 0;
                                    TotalMachinePrevention = 0;
                                    TotalMachineCasse = 0;
                                    TotalMachineManquant = 0;
                                    TotalMachineUsure = 0;
                                    TotalMachineAutres = 0;
                                    TotalMachinePieces = 0;
                                    TotalMachineControle = 0;
                                    TotalMachinePort = 0;
                                    TotalPort = 0;
									Usure=0;
									Autres=0;
									ancienmat=ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString();
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
 
						}
						ypos+=15;
					}
					else
					{
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());                                    
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());                                    
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    Casse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString()); ;                                    
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    Usure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());                                    
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
                                
							}                            

                            try
                            {
                                TotalPieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
                                Pieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
                                TotalMachinePieces += Pieces;
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
                            try
                            {
                                TotalDNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
                                DNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
                                TotalMachineDNR += DNR;
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
                            try
                            {
                                TotalControles += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
                                TotalMachineControle += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
                            try
                            {
                                TotalCA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
                                CA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
                                TotalMachineCA += CA;
                                //MessageBox.Show(TotalCA.ToString());
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
 
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString()!=ds.Tables["devis"].Rows[countRow+1]["Code Materiel"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
                                    e.Graphics.DrawString(TotalMachinePrevention.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                                    e.Graphics.DrawString(TotalMachineManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 560, ypos);
                                    e.Graphics.DrawString(TotalMachineCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 615, ypos);
                                    e.Graphics.DrawString(TotalMachineUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 665, ypos);
                                    e.Graphics.DrawString(TotalMachineAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 715, ypos);
                                    e.Graphics.DrawString(TotalMachinePieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 760, ypos);
                                    e.Graphics.DrawString(TotalMachineDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 815, ypos);
                                    e.Graphics.DrawString(TotalMachineControle.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 875, ypos);
                                    e.Graphics.DrawString("", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 935, ypos);
                                    e.Graphics.DrawString(TotalMachineCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
                                    CA = 0;
                                    Pieces = 0;
                                    DNR = 0;
									Usure=0;
									Autres=0;
                                    TotalMachineCA = 0;
                                    TotalMachineDNR = 0;
                                    TotalMachinePrevention = 0;
                                    TotalMachineCasse = 0;
                                    TotalMachineManquant = 0;
                                    TotalMachineUsure = 0;
                                    TotalMachineAutres = 0;
                                    TotalMachinePieces = 0;
                                    TotalMachineControle = 0;
                                    TotalMachinePort = 0;
                                    TotalPort = 0;
									ypos+=15;
									ancienmat=ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString();
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
							
							
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}

                            TotalMachineCasse = Casse;
                            TotalMachineAutres = Autres;
                            TotalMachineUsure = Usure;
                            TotalMachineManquant = Manquant;
                            TotalMachinePrevention = Preventif;
  
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString()!=ds.Tables["devis"].Rows[countRow+1]["Code Materiel"].ToString())
								{
                                    e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10, 9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 180, ypos);
                                    e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10, 9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 250, ypos);
                                    e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 320, ypos);
                                    e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 400, ypos);
                                    e.Graphics.DrawString(TotalMachinePrevention.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                                    e.Graphics.DrawString(TotalMachineManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 560, ypos);
                                    e.Graphics.DrawString(TotalMachineCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 615, ypos);
                                    e.Graphics.DrawString(TotalMachineUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 665, ypos);
                                    e.Graphics.DrawString(TotalMachineAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 715, ypos);
                                    e.Graphics.DrawString(TotalMachinePieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 760, ypos);
                                    e.Graphics.DrawString(TotalMachineDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 815, ypos);
                                    e.Graphics.DrawString(TotalMachineControle.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 875, ypos);
                                    e.Graphics.DrawString("", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 935, ypos);
                                    e.Graphics.DrawString(TotalMachineCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 975, ypos);
                                    Machines++;
                                    Preventif = 0;
                                    Manquant = 0;
                                    Casse = 0;
                                    CA = 0;
                                    Pieces = 0;
                                    DNR = 0;
                                    Usure = 0;
                                    Autres = 0;
                                    TotalMachineCA = 0;
                                    TotalMachineDNR = 0;
                                    TotalMachinePrevention = 0;
                                    TotalMachineCasse = 0;
                                    TotalMachineManquant = 0;
                                    TotalMachineUsure = 0;
                                    TotalMachineAutres = 0;
                                    TotalMachinePieces = 0;
                                    TotalMachineControle = 0;
                                    TotalMachinePort = 0;
                                    TotalPort = 0;
									ypos+=15;
									ancienmat=ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString();
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
					}
					debut=false;
					countRow++;
				}
				if(countRow==ds.Tables["devis"].Rows.Count)
				{
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
					e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+810, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);
					Machines++;
					Preventif=0;
					Manquant=0;
					Casse=0;
					Usure=0;
					Autres=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+810, ypos);
					e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+870, ypos);
					e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+925, ypos);
					GeneralMachines+=Machines;
					GeneralPreventif+=TotalPreventif;
					GeneralManquant+=TotalManquant;
					GeneralCasse+=TotalCasse;
					GeneralUsure+=TotalUsure;
					GeneralAutres+=TotalAutres;
					GeneralPieces+=TotalPieces;
					GeneralDNR+=TotalDNR;
					GeneralControles+=TotalControles;
					GeneralCA+=TotalCA;
					Machines=0;
					TotalCasse=0;
					TotalUsure=0;
					TotalAutres=0;
					TotalPieces=0;
					TotalControles=0;
					TotalCA=0;
					TotalDNR=0;
					Machines=0;
					TotalPreventif=0;
					TotalManquant=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString(GeneralMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(GeneralPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(GeneralManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(GeneralCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(GeneralUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(GeneralAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(GeneralPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(GeneralDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+810, ypos);
					e.Graphics.DrawString(GeneralControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+870, ypos);
					e.Graphics.DrawString(GeneralCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+925, ypos);
					ypos+=20;
					countRow++;
				}
			}
			ypos+=10;
			if(countRow<(ds.Tables["devis"].Rows.Count))
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
				Preventif=0;
				Manquant=0;
				Casse=0;
				Usure=0;
				Autres=0;
				Machines=0;
				GeneralMachines=0;
				TotalPreventif=0;
				TotalManquant=0;
				TotalCasse=0;
				TotalUsure=0;
				TotalAutres=0;
				TotalPieces=0;
				TotalDNR=0;
				TotalControles=0;
				TotalCA=0;

				TotalPreventifMabec=0;
				TotalManquantMabec=0;
				TotalCasseMabec=0;
				TotalUsureMabec=0;
				TotalAutresMabec=0;
				TotalPiecesMabec=0;
				TotalDNRMabec=0;
				TotalControlesMabec=0;
				TotalCAMabec=0;

				TotalPreventifTroncon=0;
				TotalManquantTroncon=0;
				TotalCasseTroncon=0;
				TotalUsureTroncon=0;
				TotalAutresTroncon=0;
				TotalPiecesTroncon=0;
				TotalDNRTroncon=0;
				TotalControlesTroncon=0;
				TotalCATroncon=0;
				GeneralPreventif=0;
				GeneralManquant=0;
				GeneralCasse=0;
				GeneralUsure=0;
				GeneralAutres=0;
				GeneralPieces=0;
				GeneralDNR=0;
				GeneralControles=0;
				GeneralCA=0;
			}
		}

		private void ExportExcel()
		{
            Preventif = 0;
            Manquant = 0;
            Casse = 0;
            Usure = 0;
            Autres = 0;
            Machines = 0;
            GeneralMachines = 0;
            TotalPreventif = 0;
            TotalManquant = 0;
            TotalCasse = 0;
            TotalUsure = 0;
            TotalAutres = 0;
            TotalPieces = 0;
            TotalDNR = 0;
            TotalControles = 0;
            TotalCA = 0;

            TotalMachineCA = 0;
            TotalMachineDNR = 0;
            TotalMachinePieces = 0;
            TotalMachineControle = 0;
            TotalMachineManquant = 0;
            TotalMachineUsure = 0;
            TotalMachineCasse = 0;


            TotalPreventifMabec = 0;
            TotalManquantMabec = 0;
            TotalCasseMabec = 0;
            TotalUsureMabec = 0;
            TotalAutresMabec = 0;
            TotalPiecesMabec = 0;
            TotalDNRMabec = 0;
            TotalControlesMabec = 0;
            TotalCAMabec = 0;

            TotalPreventifTroncon = 0;
            TotalManquantTroncon = 0;
            TotalCasseTroncon = 0;
            TotalUsureTroncon = 0;
            TotalAutresTroncon = 0;
            TotalPiecesTroncon = 0;
            TotalDNRTroncon = 0;
            TotalControlesTroncon = 0;
            TotalCATroncon = 0;
            GeneralPreventif = 0;
            GeneralManquant = 0;
            GeneralCasse = 0;
            GeneralUsure = 0;
            GeneralAutres = 0;
            GeneralPieces = 0;
            GeneralDNR = 0;
            GeneralControles = 0;
            GeneralCA = 0;

			Microsoft.Office.Interop.Excel.Application oXL; 
			Microsoft.Office.Interop.Excel._Workbook oWB; 
			Microsoft.Office.Interop.Excel._Worksheet oSheet; 
			Microsoft.Office.Interop.Excel.Range oRng;

			oXL = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                oXL.Application.Visible = false;
            }
            catch
            {
                oXL.Application.Visible = false;
            }

			if(Directory.Exists(@"C:\Program Files (x86)\Opindus\Excel\Depenses\")==false)
			{
				DirectoryInfo repertoire = Directory.CreateDirectory(@"C:\Program Files (x86)\Opindus\Excel\Depenses\"); 
			}

			oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\Depenses.xls",oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien,oRien);
			
			oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
			oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];

			oSheet.Cells[1,1] = "Dépenses machines "+mtgcComboBox1.Text+" période du "+textBox1.Text+" au "+textBox2.Text;

			int Cell=3;

			if((radioButton1.Checked&&radioButton3.Checked) || (radioButton2.Checked && radioButton6.Checked))
			{
                try
                {
                    while (countRow < ds.Tables["devis"].Rows.Count)
                    {
                        try
                        {
                            anciendevis = ds.Tables["devis"].Rows[countRow + 1]["N° Devis"].ToString();
                        }
                        catch
                        {
                        }
                        if (countRow.Equals(0))
                        {
                            oSheet.Cells[Cell, 1] = ds.Tables["devis"].Rows[countRow]["NomClient"].ToString();
                            Cell++;
                            //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["NomClient"].ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);

                            //ypos+=40;
                        }
                        if (countRow.Equals(0))
                        {
                            oSheet.Cells[Cell, 1] = ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
                            Cell++;
                            //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
                            //ypos+=15;
                        }
                        if (ancienfourn != ds.Tables["devis"].Rows[countRow]["Nom"].ToString() || countRow.Equals(ds.Tables["devis"].Rows.Count))
                        {
                            if (!debut)
                            {
                                TotalAutres += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Forfait transport"].ToString());
                                //ypos+=5;
                                //e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
                                //ypos+=5;
                                Cell++;
                                oSheet.Cells[Cell, 1] = "Total fournisseur";
                                Cell++;
                                oSheet.Cells[Cell, 2] = Machines.ToString() + " machine(s)";
                                oSheet.Cells[Cell, 6] = TotalPreventif.ToString("0.00");
                                oSheet.Cells[Cell, 7] = TotalManquant.ToString("0.00");
                                oSheet.Cells[Cell, 8] = TotalCasse.ToString("0.00");
                                oSheet.Cells[Cell, 9] = TotalUsure.ToString("0.00");
                                oSheet.Cells[Cell, 10] = TotalAutres.ToString("0.00");
                                oSheet.Cells[Cell, 11] = TotalPieces.ToString("0.00");
                                oSheet.Cells[Cell, 12] = TotalDNR.ToString("0.00");
                                oSheet.Cells[Cell, 13] = TotalControles.ToString("0.00");
                                oSheet.Cells[Cell, 14] = TotalPort.ToString("0.00");
                                oSheet.Cells[Cell, 15] = TotalCA.ToString("0.00");
                                Cell++;

                                //e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
                                //e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
                                //e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
                                //e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
                                //e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
                                //e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
                                //e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
                                //e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+760, ypos);
                                //e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
                                //e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
                                //e.Graphics.DrawString(TotalPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+935, ypos);
                                //e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
                                GeneralMachines += Machines;
                                GeneralPreventif += TotalPreventif;
                                GeneralManquant += TotalManquant;
                                GeneralCasse += TotalCasse;
                                GeneralUsure += TotalUsure;
                                GeneralAutres += TotalAutres;
                                GeneralPieces += TotalPieces;
                                GeneralDNR += TotalDNR;
                                GeneralControles += TotalControles;
                                GeneralCA += TotalCA;
                                GeneralPort += TotalPort;
                                ClientMachines += Machines;
                                ClientPreventif += TotalPreventif;
                                ClientManquant += TotalManquant;
                                ClientCasse += TotalCasse;
                                ClientUsure += TotalUsure;
                                ClientAutres += TotalAutres;
                                ClientPieces += TotalPieces;
                                ClientDNR += TotalDNR;
                                ClientControles += TotalControles;
                                ClientCA += TotalCA;
                                ClientPort += TotalPort;
                                Machines = 0;
                                TotalCasse = 0;
                                TotalUsure = 0;
                                TotalAutres = 0;
                                TotalPieces = 0;
                                TotalControles = 0;
                                TotalCA = 0;
                                TotalDNR = 0;
                                TotalPreventif = 0;
                                TotalManquant = 0;
                                TotalPort = 0;
                                //ypos+=20;


                            }
                            if (ancienclient != ds.Tables["devis"].Rows[countRow]["NomClient"].ToString())
                            {

                                if (!debut)
                                {
                                    //ClientAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait transport"].ToString());
                                    //e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
                                    //ypos+=5;
                                    Cell++;
                                    oSheet.Cells[Cell, 1] = "Total client";
                                    Cell++;
                                    oSheet.Cells[Cell, 2] = ClientMachines.ToString() + " machine(s)";
                                    oSheet.Cells[Cell, 6] = ClientPreventif.ToString("0.00");
                                    oSheet.Cells[Cell, 7] = ClientManquant.ToString("0.00");
                                    oSheet.Cells[Cell, 8] = ClientCasse.ToString("0.00");
                                    oSheet.Cells[Cell, 9] = ClientUsure.ToString("0.00");
                                    oSheet.Cells[Cell, 10] = ClientAutres.ToString("0.00");
                                    oSheet.Cells[Cell, 11] = ClientPieces.ToString("0.00");
                                    oSheet.Cells[Cell, 12] = ClientDNR.ToString("0.00");
                                    oSheet.Cells[Cell, 13] = ClientControles.ToString("0.00");
                                    oSheet.Cells[Cell, 14] = ClientPort.ToString("0.00");
                                    oSheet.Cells[Cell, 15] = ClientCA.ToString("0.00");
                                    Cell++;

                                    //e.Graphics.DrawString("Total client", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
                                    //e.Graphics.DrawString(ClientMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
                                    //e.Graphics.DrawString(ClientPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
                                    //e.Graphics.DrawString(ClientManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
                                    //e.Graphics.DrawString(ClientCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
                                    //e.Graphics.DrawString(ClientUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
                                    //e.Graphics.DrawString(ClientAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
                                    //e.Graphics.DrawString(ClientPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+760, ypos);
                                    //e.Graphics.DrawString(ClientDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
                                    //e.Graphics.DrawString(ClientControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
                                    //e.Graphics.DrawString(ClientPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+935, ypos);
                                    //e.Graphics.DrawString(ClientCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);
                                    /*GeneralMachines+=Machines;
                                    GeneralPreventif+=TotalPreventif;
                                    GeneralManquant+=TotalManquant;
                                    GeneralCasse+=TotalCasse;
                                    GeneralUsure+=TotalUsure;
                                    GeneralAutres+=TotalAutres;
                                    GeneralPieces+=TotalPieces;
                                    GeneralDNR+=TotalDNR;
                                    GeneralControles+=TotalControles;
                                    GeneralCA+=TotalCA;
                                    GeneralPort+=TotalPort;*/
                                    ClientMachines += Machines;
                                    ClientPreventif += TotalPreventif;
                                    ClientManquant += TotalManquant;
                                    ClientCasse += TotalCasse;
                                    ClientUsure += TotalUsure;
                                    ClientAutres += TotalAutres;
                                    ClientPieces += TotalPieces;
                                    ClientDNR += TotalDNR;
                                    ClientControles += TotalControles;
                                    ClientCA += TotalCA;
                                    ClientPort += TotalPort;
                                    Machines = 0;
                                    TotalCasse = 0;
                                    TotalUsure = 0;
                                    TotalAutres = 0;
                                    TotalPieces = 0;
                                    TotalControles = 0;
                                    TotalCA = 0;
                                    TotalDNR = 0;
                                    Machines = 0;
                                    TotalPreventif = 0;
                                    TotalManquant = 0;
                                    TotalPort = 0;

                                    //ypos+=20;
                                }

                            }
                            if ((ancienclient != ds.Tables["devis"].Rows[countRow]["NomClient"].ToString()) && countRow > 0)
                            {
                                //e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
                                //ypos+=20;
                                oSheet.Cells[Cell, 1] = ds.Tables["devis"].Rows[countRow]["NomClient"].ToString();
                                Cell++;
                                //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["NomClient"].ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                                ancienclient = ds.Tables["devis"].Rows[countRow]["NomClient"].ToString();
                                //ypos+=20;
                                ClientMachines = 0;
                                ClientPreventif = 0;
                                ClientManquant = 0;
                                ClientCasse = 0;
                                ClientUsure = 0;
                                ClientAutres = 0;
                                ClientPieces = 0;
                                ClientDNR = 0;
                                ClientControles = 0;
                                ClientCA = 0;
                                ClientPort = 0;
                            }
                            if ((ancienfourn != ds.Tables["devis"].Rows[countRow]["Nom"].ToString() || countRow.Equals(ds.Tables["devis"].Rows.Count)) && countRow > 0)
                            {
                                //e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
                                //ypos+=10;
                                oSheet.Cells[Cell, 1] = ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
                                Cell++;
                                //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
                                //ypos+=15;
                                TotalCasse = 0;
                                TotalUsure = 0;
                                TotalAutres = 0;
                                TotalPieces = 0;
                                TotalControles = 0;
                                TotalCA = 0;
                                TotalDNR = 0;
                                TotalPreventif = 0;
                                TotalManquant = 0;
                                TotalPort = 0;
                            }

                            ancienfourn = ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
                            ancienclient = ds.Tables["devis"].Rows[countRow]["NomClient"].ToString();

                            if (anciendevis != ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
                            {

                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
                                {
                                    try
                                    {
                                        Preventif += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        TotalPreventif += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
                                {
                                    try
                                    {
                                        TotalManquant += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Manquant += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
                                {
                                    try
                                    {
                                        TotalCasse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Casse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
                                {
                                    try
                                    {
                                        TotalUsure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Usure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString()) > 4)
                                {
                                    try
                                    {
                                        Autres += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                try
                                {
                                    TotalPieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
                                    Pieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                try
                                {
                                    TotalDNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
                                    DNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()); 
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                try
                                {
                                    TotalControles += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                try
                                {
                                    TotalCA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
                                    CA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
                                    //MessageBox.Show(TotalCA.ToString());
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                TotalMachineAutres += Autres;
                                TotalMachineManquant += Manquant;
                                TotalMachinePrevention += Preventif;
                                TotalAutres += Autres;
                                try
                                {
                                    if (anciendevis != ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
                                    {
                                        TotalPort += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());

                                        oSheet.Cells[Cell, 2] = ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10, 9);
                                        oSheet.Cells[Cell, 3] = ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10, 9);
                                        oSheet.Cells[Cell, 4] = ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString();
                                        oSheet.Cells[Cell, 5] = ds.Tables["devis"].Rows[countRow]["Type machine"].ToString();
                                        oSheet.Cells[Cell, 6] = Preventif.ToString("0.00");
                                        oSheet.Cells[Cell, 7] = Manquant.ToString("0.00");
                                        oSheet.Cells[Cell, 8] = Casse.ToString("0.00");
                                        oSheet.Cells[Cell, 9] = Usure.ToString("0.00");
                                        oSheet.Cells[Cell, 10] = Autres.ToString("0.00");
                                        oSheet.Cells[Cell, 11] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00");
                                        oSheet.Cells[Cell, 12] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00");
                                        oSheet.Cells[Cell, 13] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00");
                                        oSheet.Cells[Cell, 14] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00");
                                        oSheet.Cells[Cell, 15] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00");
                                        Cell++;

                                        Machines++;
                                        Preventif = 0;
                                        Manquant = 0;
                                        Casse = 0;
                                        CA = 0;
                                        Pieces = 0;
                                        DNR = 0;
                                        Usure = 0;
                                        Autres = 0;
                                        TotalMachineCA = 0;
                                        TotalMachineDNR = 0;
                                        TotalMachinePieces = 0;
                                        TotalMachineControle = 0;
                                        TotalMachineUsure = 0;
                                        TotalMachineCasse = 0;
                                        TotalMachineManquant = 0;
                                    }
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                

                            }
                            else
                            {
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
                                {
                                    try
                                    {
                                        Preventif += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        TotalPreventif += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
                                {
                                    try
                                    {
                                        TotalManquant += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Manquant += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
                                {
                                    try
                                    {
                                        TotalCasse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Casse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
                                {
                                    try
                                    {
                                        TotalUsure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Usure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString()) > 4)
                                {
                                    try
                                    {
                                        Autres += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());

                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                TotalAutres += Autres;
                            }
                            //ypos+=15;
                        }
                        else
                        {
                            if (anciendevis != ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
                            {
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
                                {
                                    try
                                    {
                                        Preventif += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        TotalPreventif += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
                                {
                                    try
                                    {
                                        TotalManquant += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Manquant += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());                                        
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
                                {
                                    try
                                    {
                                        TotalCasse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Casse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
                                {
                                    try
                                    {
                                        TotalUsure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Usure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString()) > 4)
                                {
                                    try
                                    {
                                        Autres += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());

                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }


                                try
                                {
                                    TotalPieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
                                    Pieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
                                    TotalMachinePieces = Pieces;
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                try
                                {
                                    TotalDNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
                                    DNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
                                    TotalMachineDNR = DNR;
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                try
                                {
                                    TotalControles += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                                try
                                {
                                    TotalCA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
                                    CA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
                                    TotalMachineCA = CA;
                                    //MessageBox.Show(TotalCA.ToString());
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }

                                TotalAutres += Autres;
                                TotalMachineCasse = Casse;
                                TotalMachineUsure = Usure;
                                TotalMachineManquant = Manquant;
                                try
                                {
                                    if (anciendevis != ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
                                    {
                                        TotalPort += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());

                                        if (ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString() != ds.Tables["devis"].Rows[countRow + 1]["Code Materiel"].ToString())
                                        {
                                            oSheet.Cells[Cell, 2] = ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10, 9);
                                            oSheet.Cells[Cell, 3] = ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10, 9);
                                            oSheet.Cells[Cell, 4] = ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString();
                                            oSheet.Cells[Cell, 5] = ds.Tables["devis"].Rows[countRow]["Type machine"].ToString();
                                            oSheet.Cells[Cell, 6] = Preventif.ToString("0.00");
                                            oSheet.Cells[Cell, 7] = TotalMachineManquant.ToString("0.00");
                                            oSheet.Cells[Cell, 8] = TotalMachineCasse.ToString("0.00");
                                            oSheet.Cells[Cell, 9] = TotalMachineUsure.ToString("0.00");
                                            oSheet.Cells[Cell, 10] = Autres.ToString("0.00");
                                            oSheet.Cells[Cell, 11] = TotalMachinePieces.ToString("0.00");
                                            oSheet.Cells[Cell, 12] = TotalMachineDNR.ToString("0.00");
                                            oSheet.Cells[Cell, 13] = TotalMachineControle.ToString("0.00");
                                            oSheet.Cells[Cell, 14] = "";
                                            oSheet.Cells[Cell, 15] = TotalMachineCA.ToString("0.00");
                                            Cell++;

                                            //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
                                            //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
                                            //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
                                            //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
                                            //e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
                                            //e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
                                            //e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
                                            //e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
                                            //e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
                                            //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
                                            //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
                                            //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
                                            //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
                                            //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
                                            Machines++;
                                            Preventif = 0;
                                            Manquant = 0;
                                            Casse = 0;
                                            CA = 0;
                                            Pieces = 0;
                                            DNR = 0;
                                            Usure = 0;
                                            Autres = 0;
                                            TotalMachineCA = 0;
                                            TotalMachineDNR = 0;
                                            TotalMachinePieces = 0;
                                            TotalMachineControle = 0;
                                            TotalMachineUsure = 0;
                                            TotalMachineCasse = 0;
                                            TotalMachineManquant = 0;
                                        }
                                        //ypos+=15;
                                    }
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }

                                


                            }
                            else
                            {
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
                                {
                                    try
                                    {
                                        Preventif += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        TotalPreventif += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
                                {
                                    try
                                    {
                                        TotalManquant += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Manquant += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
                                {
                                    try
                                    {
                                        TotalCasse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                        Casse += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                if (ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
                                {
                                    TotalUsure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                    Usure += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
                                }
                                if (System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString()) > 4)
                                {
                                    try
                                    {
                                        Autres += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());

                                    }
                                    catch (Exception exp)
                                    {
                                        Console.WriteLine(exp.Message);
                                    }
                                }
                                TotalAutres += Autres;
                                try
                                {
                                    if (anciendevis != ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
                                    {
                                        TotalPort += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());

                                        oSheet.Cells[Cell, 2] = ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10, 9);
                                        oSheet.Cells[Cell, 3] = ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10, 9);
                                        oSheet.Cells[Cell, 4] = ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString();
                                        oSheet.Cells[Cell, 5] = ds.Tables["devis"].Rows[countRow]["Type machine"].ToString();
                                        oSheet.Cells[Cell, 6] = Preventif.ToString("0.00");
                                        oSheet.Cells[Cell, 7] = Manquant.ToString("0.00");
                                        oSheet.Cells[Cell, 8] = Casse.ToString("0.00");
                                        oSheet.Cells[Cell, 9] = Usure.ToString("0.00");
                                        oSheet.Cells[Cell, 10] = Autres.ToString("0.00");
                                        oSheet.Cells[Cell, 11] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00");
                                        oSheet.Cells[Cell, 12] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00");
                                        oSheet.Cells[Cell, 13] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00");
                                        oSheet.Cells[Cell, 14] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00");
                                        oSheet.Cells[Cell, 15] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00");
                                        Cell++;

                                        //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
                                        //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
                                        //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
                                        //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
                                        //e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
                                        //e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
                                        //e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
                                        //e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
                                        //e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
                                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
                                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
                                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
                                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
                                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
                                        Machines++;
                                        Preventif = 0;
                                        Manquant = 0;
                                        Casse = 0;
                                        CA = 0;
                                        Pieces = 0;
                                        DNR = 0;
                                        Usure = 0;
                                        Autres = 0;
                                        //ypos+=15;
                                    }
                                }
                                catch (Exception exp)
                                {
                                    Console.WriteLine(exp.Message);
                                }
                            }
                        }
                        debut = false;

                        countRow++;
                    }
                    if (countRow == ds.Tables["devis"].Rows.Count)
                    {
                        Cell++;
                        oSheet.Cells[Cell, 2] = ds.Tables["devis"].Rows[countRow - 1]["Date entree reelle"].ToString().Remove(10, 9);
                        oSheet.Cells[Cell, 3] = ds.Tables["devis"].Rows[countRow - 1]["Date reparation"].ToString().Remove(10, 9);
                        oSheet.Cells[Cell, 4] = ds.Tables["devis"].Rows[countRow - 1]["Code materiel"].ToString();
                        oSheet.Cells[Cell, 5] = ds.Tables["devis"].Rows[countRow - 1]["Type machine"].ToString();
                        oSheet.Cells[Cell, 6] = Preventif.ToString("0.00");
                        oSheet.Cells[Cell, 7] = Manquant.ToString("0.00");
                        oSheet.Cells[Cell, 8] = Casse.ToString("0.00");
                        oSheet.Cells[Cell, 9] = Usure.ToString("0.00");
                        oSheet.Cells[Cell, 10] = Autres.ToString("0.00");
                        oSheet.Cells[Cell, 11] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Total pieces"].ToString()).ToString("0.00");
                        oSheet.Cells[Cell, 12] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Forfait DNR"].ToString()).ToString("0.00");
                        oSheet.Cells[Cell, 13] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Forfait controle"].ToString()).ToString("0.00");
                        oSheet.Cells[Cell, 14] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Forfait transport"].ToString()).ToString("0.00");
                        oSheet.Cells[Cell, 15] = System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Total devis"].ToString()).ToString("0.00");
                        Cell++;

                        //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
                        //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
                        //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
                        //e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
                        //e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
                        //e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
                        //e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
                        //e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
                        //e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait transport"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
                        //e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
                        Machines++;
                        try
                        {
                            TotalPieces += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Total pieces"].ToString());
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                        try
                        {
                            TotalDNR += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Forfait DNR"].ToString());
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                        try
                        {
                            TotalControles += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Forfait controle"].ToString());
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                        try
                        {
                            TotalCA += System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow - 1]["Total devis"].ToString());
                            //MessageBox.Show(TotalCA.ToString());
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                        Preventif = 0;
                        Manquant = 0;
                        Casse = 0;
                        CA = 0;
                        Pieces = 0;
                        DNR = 0;
                        Usure = 0;
                        Autres = 0;
                        //ypos+=20;
                        //e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
                        //ypos+=10;
                        Cell++;
                        oSheet.Cells[Cell, 1] = "Total fournisseur";
                        Cell++;
                        oSheet.Cells[Cell, 2] = Machines.ToString() + " machine(s)";
                        oSheet.Cells[Cell, 6] = TotalPreventif.ToString("0.00");
                        oSheet.Cells[Cell, 7] = TotalManquant.ToString("0.00");
                        oSheet.Cells[Cell, 8] = TotalCasse.ToString("0.00");
                        oSheet.Cells[Cell, 9] = TotalUsure.ToString("0.00");
                        oSheet.Cells[Cell, 10] = TotalAutres.ToString("0.00");
                        oSheet.Cells[Cell, 11] = TotalPieces.ToString("0.00");
                        oSheet.Cells[Cell, 12] = TotalDNR.ToString("0.00");
                        oSheet.Cells[Cell, 13] = TotalControles.ToString("0.00");
                        oSheet.Cells[Cell, 14] = TotalPort.ToString("0.00");
                        oSheet.Cells[Cell, 15] = TotalCA.ToString("0.00");
                        Cell++;
                        //e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
                        //e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
                        //e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
                        //e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
                        //e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
                        //e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
                        //e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
                        //e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
                        //e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
                        //e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
                        //e.Graphics.DrawString(TotalPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+935, ypos);
                        //e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
                        //ypos+=15;
                        //e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
                        //ypos+=5;
                        ClientMachines += Machines;
                        ClientPreventif += TotalPreventif;
                        ClientManquant += TotalManquant;
                        ClientCasse += TotalCasse;
                        ClientUsure += TotalUsure;
                        ClientAutres += TotalAutres;
                        ClientPieces += TotalPieces;
                        ClientDNR += TotalDNR;
                        ClientControles += TotalControles;
                        ClientCA += TotalCA;

                        Cell++;
                        /*oSheet.Cells[Cell,1] = "Total fournisseur";
                        Cell++;
                        oSheet.Cells[Cell,2] = Machines.ToString()+" machine(s)";
                        oSheet.Cells[Cell,3] = TotalPreventif.ToString("0.00");
                        oSheet.Cells[Cell,4] = TotalManquant.ToString("0.00");
                        oSheet.Cells[Cell,5] = TotalCasse.ToString("0.00");
                        oSheet.Cells[Cell,6] = TotalUsure.ToString("0.00");
                        oSheet.Cells[Cell,7] = TotalAutres.ToString("0.00");
                        oSheet.Cells[Cell,8] = TotalPieces.ToString("0.00");
                        oSheet.Cells[Cell,9] = TotalDNR.ToString("0.00");
                        oSheet.Cells[Cell,10] = TotalControles.ToString("0.00");
                        oSheet.Cells[Cell,11] = TotalPort.ToString("0.00");
                        oSheet.Cells[Cell,12] = TotalCA.ToString("0.00");
                        Cell++;*/

                        oSheet.Cells[Cell, 1] = "Total client";
                        Cell++;
                        oSheet.Cells[Cell, 2] = ClientMachines.ToString() + " machine(s)";
                        oSheet.Cells[Cell, 6] = ClientPreventif.ToString("0.00");
                        oSheet.Cells[Cell, 7] = ClientManquant.ToString("0.00");
                        oSheet.Cells[Cell, 8] = ClientCasse.ToString("0.00");
                        oSheet.Cells[Cell, 9] = ClientUsure.ToString("0.00");
                        oSheet.Cells[Cell, 10] = ClientAutres.ToString("0.00");
                        oSheet.Cells[Cell, 11] = ClientPieces.ToString("0.00");
                        oSheet.Cells[Cell, 12] = ClientDNR.ToString("0.00");
                        oSheet.Cells[Cell, 13] = ClientControles.ToString("0.00");
                        oSheet.Cells[Cell, 14] = ClientPort.ToString("0.00");
                        oSheet.Cells[Cell, 15] = ClientCA.ToString("0.00");
                        Cell++;

                        /*e.Graphics.DrawString("Total client", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
                        e.Graphics.DrawString(ClientMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
                        e.Graphics.DrawString(ClientPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
                        e.Graphics.DrawString(ClientManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
                        e.Graphics.DrawString(ClientCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
                        e.Graphics.DrawString(ClientUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
                        e.Graphics.DrawString(ClientAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
                        e.Graphics.DrawString(ClientPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
                        e.Graphics.DrawString(ClientDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
                        e.Graphics.DrawString(ClientControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
                        e.Graphics.DrawString(ClientPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+935, ypos);
                        e.Graphics.DrawString(ClientCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);
    */
                        GeneralMachines += Machines;
                        GeneralPreventif += TotalPreventif;
                        GeneralManquant += TotalManquant;
                        GeneralCasse += TotalCasse;
                        GeneralUsure += TotalUsure;
                        GeneralAutres += TotalAutres;
                        GeneralPieces += TotalPieces;
                        GeneralDNR += TotalDNR;
                        GeneralControles += TotalControles;
                        GeneralCA += TotalCA;
                        GeneralPort += TotalPort;

                        ClientMachines = 0;
                        ClientPreventif = 0;
                        ClientManquant = 0;
                        ClientCasse = 0;
                        ClientUsure = 0;
                        ClientAutres = 0;
                        ClientPieces = 0;
                        ClientDNR = 0;
                        ClientControles = 0;
                        ClientCA = 0;
                        ClientPort = 0;

                        Machines = 0;
                        TotalCasse = 0;
                        TotalUsure = 0;
                        TotalAutres = 0;
                        TotalPieces = 0;
                        TotalControles = 0;
                        TotalCA = 0;
                        TotalPort = 0;
                        TotalDNR = 0;
                        Machines = 0;
                        TotalPreventif = 0;
                        TotalManquant = 0;

                        Cell++;
                        oSheet.Cells[Cell, 1] = "Total général";
                        Cell++;
                        oSheet.Cells[Cell, 2] = GeneralMachines.ToString() + " machine(s)";
                        oSheet.Cells[Cell, 6] = GeneralPreventif.ToString("0.00");
                        oSheet.Cells[Cell, 7] = GeneralManquant.ToString("0.00");
                        oSheet.Cells[Cell, 8] = GeneralCasse.ToString("0.00");
                        oSheet.Cells[Cell, 9] = GeneralUsure.ToString("0.00");
                        oSheet.Cells[Cell, 10] = GeneralAutres.ToString("0.00");
                        oSheet.Cells[Cell, 11] = GeneralPieces.ToString("0.00");
                        oSheet.Cells[Cell, 12] = GeneralDNR.ToString("0.00");
                        oSheet.Cells[Cell, 13] = GeneralControles.ToString("0.00");
                        oSheet.Cells[Cell, 14] = GeneralPort.ToString("0.00");
                        oSheet.Cells[Cell, 15] = GeneralCA.ToString("0.00");
                        Cell++;

                        //ypos+=20;
                        //e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
                        //ypos+=10;
                        /*e.Graphics.DrawString("Total général", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                        e.Graphics.DrawString(GeneralMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
                        e.Graphics.DrawString(GeneralPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
                        e.Graphics.DrawString(GeneralManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
                        e.Graphics.DrawString(GeneralCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
                        e.Graphics.DrawString(GeneralUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
                        e.Graphics.DrawString(GeneralAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
                        e.Graphics.DrawString(GeneralPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos);
                        e.Graphics.DrawString(GeneralDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
                        e.Graphics.DrawString(GeneralControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
                        e.Graphics.DrawString(GeneralPort.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+935, ypos);
                        e.Graphics.DrawString(GeneralCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
                        */
                        GeneralMachines = 0;
                        GeneralPreventif = 0;
                        GeneralManquant = 0;
                        GeneralCasse = 0;
                        GeneralUsure = 0;
                        GeneralAutres = 0;
                        GeneralPieces = 0;
                        GeneralDNR = 0;
                        GeneralControles = 0;
                        GeneralCA = 0;
                        GeneralPort = 0;

                        //ypos+=20;
                        countRow++;

                        oXL.Workbooks[1].SaveAs(@"C:\Program Files (x86)\Opindus\Excel\Depenses\" + mtgcComboBox1.Text + ".xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, "", "", false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
                        if (oXL != null)
                        {
                            oXL.Quit();
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
                            oXL = null;
                            MessageBox.Show("Export terminé");
                        }
                    }
                }
                catch (Exception e)
                {
                }
			}
			/*else if(radioButton1.Checked&&radioButton4.Checked)
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["devis"].Rows.Count)
				{
					if(ancienfourn!=ds.Tables["devis"].Rows[countRow]["Nom"].ToString()||countRow.Equals(ds.Tables["devis"].Rows.Count))
					{
						if(!debut)
						{
							ypos+=5;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=5;
							e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
							e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
							e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
							e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
							e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
							e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
							e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
							e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
							e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
							e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
							GeneralMachines+=Machines;
							GeneralPreventif+=TotalPreventif;
							GeneralManquant+=TotalManquant;
							GeneralCasse+=TotalCasse;
							GeneralUsure+=TotalUsure;
							GeneralAutres+=TotalAutres;
							GeneralPieces+=TotalPieces;
							GeneralDNR+=TotalDNR;
							GeneralControles+=TotalControles;
							GeneralCA+=TotalCA;	
							Machines=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
							Machines=0;
							TotalPreventif=0;
							TotalManquant=0;
							ypos+=20;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=10;
						}
						ancienfourn=ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
						if(ancientroncon!=ds.Tables["devis"].Rows[countRow]["N° troncon"].ToString())
						{
							if(!debut)
							{
								e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
								ypos+=3;
								e.Graphics.DrawString("Total Troncon", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
								e.Graphics.DrawString(TotalPreventifTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
								e.Graphics.DrawString(TotalManquantTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
								e.Graphics.DrawString(TotalCasseTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
								e.Graphics.DrawString(TotalUsureTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
								e.Graphics.DrawString(TotalAutresTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
								e.Graphics.DrawString(TotalPiecesTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
								e.Graphics.DrawString(TotalDNRTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
								e.Graphics.DrawString(TotalControlesTroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
								e.Graphics.DrawString(TotalCATroncon.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);
								e.Graphics.DrawString(ancientroncon, new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+100, ypos);
								TotalPreventifTroncon=0;
								TotalManquantTroncon=0;
								TotalCasseTroncon=0;
								TotalUsureTroncon=0;
								TotalAutresTroncon=0;
								TotalPiecesTroncon=0;
								TotalDNRTroncon=0;
								TotalControlesTroncon=0;
								TotalCATroncon=0;
								ypos+=15;
							}
							
						}
						if(ancienmabec!=ds.Tables["devis"].Rows[countRow]["Code Mabec"].ToString())
						{
							if(!debut)
							{
								e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
								ypos+=3;
								e.Graphics.DrawString("Total Mabec", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
								e.Graphics.DrawString(TotalPreventifMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
								e.Graphics.DrawString(TotalManquantMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
								e.Graphics.DrawString(TotalCasseMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
								e.Graphics.DrawString(TotalUsureMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
								e.Graphics.DrawString(TotalAutresMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
								e.Graphics.DrawString(TotalPiecesMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
								e.Graphics.DrawString(TotalDNRMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
								e.Graphics.DrawString(TotalControlesMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
								e.Graphics.DrawString(TotalCAMabec.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
								e.Graphics.DrawString(ancienmabec, new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+100, ypos);
								TotalPreventifMabec=0;
								TotalManquantMabec=0;
								TotalCasseMabec=0;
								TotalUsureMabec=0;
								TotalAutresMabec=0;
								TotalPiecesMabec=0;
								TotalDNRMabec=0;
								TotalControlesMabec=0;
								TotalCAMabec=0;
								ypos+=15;
							}
						}
						if(ypos>=e.MarginBounds.Height)
							break;
						if(ancienmabec!=ds.Tables["devis"].Rows[countRow]["Code Mabec"].ToString())
						{
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=3;
							e.Graphics.DrawString("Mabec", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code Mabec"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
							ypos+=15;
							ancienmabec=ds.Tables["devis"].Rows[countRow]["Code Mabec"].ToString();
						}
						if(ancientroncon!=ds.Tables["devis"].Rows[countRow]["N° troncon"].ToString())
						{
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=3;
							e.Graphics.DrawString("Troncon", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["N° Troncon"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+100, ypos);
							ypos+=15;
							ancientroncon=ds.Tables["devis"].Rows[countRow]["N° Troncon"].ToString();
						}

						if(countRow!=ds.Tables["devis"].Rows.Count-1)
						{
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
							ypos+=15;
						}
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutresTroncon+=Autres;
								TotalAutresMabec+=Autres;
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
								TotalPiecesMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
								TotalPiecesTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
								TotalDNRMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
								TotalDNRTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
								TotalControlesMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
								TotalControlesTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								TotalCAMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								TotalCATroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
						}
						else
						{

							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutresMabec+=Autres;
								TotalAutresTroncon+=Autres;
								TotalAutres+=Autres;
							}
						}
						ypos+=15;
					}
					else
					{
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalUsureTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutresMabec+=Autres;
								TotalAutresTroncon+=Autres;
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ypos+=15;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
								TotalPiecesMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
								TotalPiecesTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
								TotalDNRMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
								TotalDNRTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
								TotalControlesMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
								TotalControlesTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								TotalCAMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								TotalCATroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventifTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalManquantTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalCasseTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								TotalUsureMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								TotalUsureTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresMabec+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalAutresTroncon+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutresMabec+=Autres;
								TotalAutresTroncon+=Autres;
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ypos+=15;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
					}
					debut=false;
					countRow++;
				}
				if(countRow==ds.Tables["devis"].Rows.Count)
				{
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
					e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+975, ypos);
					Machines++;
					Preventif=0;
					Manquant=0;
					Casse=0;
					Usure=0;
					Autres=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+975, ypos);
					GeneralMachines+=Machines;
					GeneralPreventif+=TotalPreventif;
					GeneralManquant+=TotalManquant;
					GeneralCasse+=TotalCasse;
					GeneralUsure+=TotalUsure;
					GeneralAutres+=TotalAutres;
					GeneralPieces+=TotalPieces;
					GeneralDNR+=TotalDNR;
					GeneralControles+=TotalControles;
					GeneralCA+=TotalCA;
					Machines=0;

					ClientMachines=0;
					ClientPreventif=0;
					ClientManquant=0;
					ClientCasse=0;
					ClientUsure=0;
					ClientAutres=0;
					ClientPieces=0;
					ClientDNR=0;
					ClientControles=0;
					ClientCA=0;

					TotalCasse=0;
					TotalUsure=0;
					TotalAutres=0;
					TotalPieces=0;
					TotalControles=0;
					TotalCA=0;
					TotalDNR=0;
					Machines=0;
					TotalPreventif=0;
					TotalManquant=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString(GeneralMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(GeneralPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(GeneralManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(GeneralCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(GeneralUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(GeneralAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(GeneralPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(GeneralDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+815, ypos);
					e.Graphics.DrawString(GeneralControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+875, ypos);
					e.Graphics.DrawString(GeneralCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+975, ypos);
					GeneralMachines=0;
					GeneralPreventif=0;
					GeneralManquant=0;
					GeneralCasse=0;
					GeneralUsure=0;
					GeneralAutres=0;
					GeneralPieces=0;
					GeneralDNR=0;
					GeneralControles=0;
					GeneralCA=0;
					ypos+=20;
					countRow++;
				}
			}
			if(radioButton1.Checked&&radioButton5.Checked)
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["devis"].Rows.Count)
				{
					if(ancienfourn!=ds.Tables["devis"].Rows[countRow]["Nom"].ToString()||countRow.Equals(ds.Tables["devis"].Rows.Count))
					{
						if(!debut)
						{
							/*ypos+=5;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=5;
							e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
							e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
							e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
							e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
							e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
							e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
							e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
							e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+820, ypos);
							e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+870, ypos);
							e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+925, ypos);*/
/*							GeneralMachines+=Machines;
							GeneralPreventif+=TotalPreventif;
							GeneralManquant+=TotalManquant;
							GeneralCasse+=TotalCasse;
							GeneralUsure+=TotalUsure;
							GeneralAutres+=TotalAutres;
							GeneralPieces+=TotalPieces;
							GeneralDNR+=TotalDNR;
							GeneralControles+=TotalControles;
							GeneralCA+=TotalCA;	
							Machines=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
							Machines=0;
							TotalPreventif=0;
							TotalManquant=0;
							/*ypos+=20;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=10;*/
/*						}
						ancienfourn=ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
						if(countRow!=ds.Tables["devis"].Rows.Count-1)
						{
							//e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
							//ypos+=15;
						}
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									/*e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+820, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);*/
/*									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
						}
						//ypos+=15;
					}
					else
					{
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									/*e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+820, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);*/
/*									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(anciendevis!=ds.Tables["devis"].Rows[countRow+1]["N° Devis"].ToString())
								{
									/*e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+820, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);*/
/*									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
					}
					debut=false;
					countRow++;
				}
				if(countRow==ds.Tables["devis"].Rows.Count)
				{
					/*e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
					e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+820, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);*/
/*					Machines++;
					Preventif=0;
					Manquant=0;
					Casse=0;
					Usure=0;
					Autres=0;
					GeneralMachines+=Machines;
					GeneralPreventif+=TotalPreventif;
					GeneralManquant+=TotalManquant;
					GeneralCasse+=TotalCasse;
					GeneralUsure+=TotalUsure;
					GeneralAutres+=TotalAutres;
					GeneralPieces+=TotalPieces;
					GeneralDNR+=TotalDNR;
					GeneralControles+=TotalControles;
					GeneralCA+=TotalCA;
					Machines=0;
					TotalCasse=0;
					TotalUsure=0;
					TotalAutres=0;
					TotalPieces=0;
					TotalControles=0;
					TotalCA=0;
					TotalDNR=0;
					Machines=0;
					TotalPreventif=0;
					TotalManquant=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString(GeneralMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(GeneralPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(GeneralManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(GeneralCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(GeneralUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(GeneralAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(GeneralPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(GeneralDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+810, ypos);
					e.Graphics.DrawString(GeneralControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+870, ypos);
					e.Graphics.DrawString(GeneralCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+950, ypos);
					ypos+=20;
					countRow++;
					
				}
			}
			else if(radioButton2.Checked&&radioButton6.Checked)
			{
				while(ypos<e.MarginBounds.Height&&countRow<ds.Tables["devis"].Rows.Count)
				{
					if(ancienfourn!=ds.Tables["devis"].Rows[countRow]["Nom"].ToString()||countRow.Equals(ds.Tables["devis"].Rows.Count))
					{
						if(!debut)
						{
							ypos+=5;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=5;
							e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
							e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
							e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
							e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
							e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
							e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
							e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
							e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
							e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+810, ypos);
							e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+850, ypos);
							e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+925, ypos);
							GeneralMachines+=Machines;
							GeneralPreventif+=TotalPreventif;
							GeneralManquant+=TotalManquant;
							GeneralCasse+=TotalCasse;
							GeneralUsure+=TotalUsure;
							GeneralAutres+=TotalAutres;
							GeneralPieces+=TotalPieces;
							GeneralDNR+=TotalDNR;
							GeneralControles+=TotalControles;
							GeneralCA+=TotalCA;	
							Machines=0;
							TotalCasse=0;
							TotalUsure=0;
							TotalAutres=0;
							TotalPieces=0;
							TotalControles=0;
							TotalCA=0;
							TotalDNR=0;
							Machines=0;
							TotalPreventif=0;
							TotalManquant=0;
							ypos+=20;
							e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
							ypos+=10;
						}
						ancienfourn=ds.Tables["devis"].Rows[countRow]["Nom"].ToString();
						if(countRow!=ds.Tables["devis"].Rows.Count-1)
						{
							e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Nom"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left, ypos);
							ypos+=15;
						}
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString()!=ds.Tables["devis"].Rows[countRow+1]["Code Materiel"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+810, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ancienmat=ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString();
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
						}
						ypos+=15;
					}
					else
					{
						if(anciendevis!=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString())
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								try
								{
									TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString()!=ds.Tables["devis"].Rows[countRow+1]["Code Materiel"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+810, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ypos+=15;
									ancienmat=ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString();
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
							try
							{
								TotalPieces+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalDNR+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalControles+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							try
							{
								TotalCA+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString());
								//MessageBox.Show(TotalCA.ToString());
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
							
							
						}
						else
						{
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("1"))
							{
								try
								{
									Preventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									TotalPreventif+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("2"))
							{
								try
								{
									TotalManquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Manquant+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("3"))
							{
								try
								{
									TotalCasse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Casse+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(ds.Tables["devis"].Rows[countRow]["Cause"].ToString().Equals("4"))
							{
								TotalUsure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								Usure+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
							}
							if(System.Convert.ToInt32(ds.Tables["devis"].Rows[countRow]["Cause"].ToString())>4)
							{
								try
								{
									TotalAutres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
									Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["SommeDeTotal ligne"].ToString());
								}
								catch(Exception exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
							if(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString())>0)
							{
								Autres+=System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait transport"].ToString());
								TotalAutres+=Autres;
							}
							anciendevis=ds.Tables["devis"].Rows[countRow]["N° Devis"].ToString();
							try
							{
								if(ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString()!=ds.Tables["devis"].Rows[countRow+1]["Code Materiel"].ToString())
								{
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
									e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
									e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
									e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
									e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
									e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
									e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+810, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
									e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);
									Machines++;
									Preventif=0;
									Manquant=0;
									Casse=0;
									Usure=0;
									Autres=0;
									ypos+=15;
									ancienmat=ds.Tables["devis"].Rows[countRow]["Code Materiel"].ToString();
								}
							}
							catch(Exception exp)
							{
								Console.WriteLine(exp.Message);
							}
						}
					}
					debut=false;
					countRow++;
				}
				if(countRow==ds.Tables["devis"].Rows.Count)
				{
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date entree reelle"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Date reparation"].ToString().Remove(10,9), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+250, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Code materiel"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+320, ypos);
					e.Graphics.DrawString(ds.Tables["devis"].Rows[countRow-1]["Type machine"].ToString(), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+400, ypos);
					e.Graphics.DrawString(Preventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(Manquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(Casse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(Usure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(Autres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total pieces"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+760, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait DNR"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+810, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Forfait controle"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+880, ypos);
					e.Graphics.DrawString(System.Convert.ToDecimal(ds.Tables["devis"].Rows[countRow-1]["Total devis"].ToString()).ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos);
					Machines++;
					Preventif=0;
					Manquant=0;
					Casse=0;
					Usure=0;
					Autres=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString("Total fournisseur", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left, ypos);
					e.Graphics.DrawString(Machines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(TotalPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(TotalManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(TotalCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(TotalUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(TotalAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(TotalPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(TotalDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+810, ypos);
					e.Graphics.DrawString(TotalControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+870, ypos);
					e.Graphics.DrawString(TotalCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Red, e.MarginBounds.Left+925, ypos);
					GeneralMachines+=Machines;
					GeneralPreventif+=TotalPreventif;
					GeneralManquant+=TotalManquant;
					GeneralCasse+=TotalCasse;
					GeneralUsure+=TotalUsure;
					GeneralAutres+=TotalAutres;
					GeneralPieces+=TotalPieces;
					GeneralDNR+=TotalDNR;
					GeneralControles+=TotalControles;
					GeneralCA+=TotalCA;
					Machines=0;
					TotalCasse=0;
					TotalUsure=0;
					TotalAutres=0;
					TotalPieces=0;
					TotalControles=0;
					TotalCA=0;
					TotalDNR=0;
					Machines=0;
					TotalPreventif=0;
					TotalManquant=0;
					ypos+=20;
					e.Graphics.DrawLine(new Pen(Color.Black, 2),new Point(e.MarginBounds.Left,ypos), new Point(e.MarginBounds.Right,ypos));
					ypos+=10;
					e.Graphics.DrawString(GeneralMachines.ToString()+" machine(s)", new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+180, ypos);
					e.Graphics.DrawString(GeneralPreventif.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+500, ypos);
					e.Graphics.DrawString(GeneralManquant.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+560, ypos);
					e.Graphics.DrawString(GeneralCasse.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+615, ypos);
					e.Graphics.DrawString(GeneralUsure.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+665, ypos);
					e.Graphics.DrawString(GeneralAutres.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+715, ypos);
					e.Graphics.DrawString(GeneralPieces.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+755, ypos);
					e.Graphics.DrawString(GeneralDNR.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+810, ypos);
					e.Graphics.DrawString(GeneralControles.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+870, ypos);
					e.Graphics.DrawString(GeneralCA.ToString("0.00"), new Font("Arial", 8, FontStyle.Bold), Brushes.Blue, e.MarginBounds.Left+925, ypos);
					ypos+=20;
					countRow++;
				}
			}
			ypos+=10;
			if(countRow<(ds.Tables["devis"].Rows.Count))
				e.HasMorePages=true;
			else
			{
				e.HasMorePages=false;
				countRow=0;
				Page=0;
				Preventif=0;
				Manquant=0;
				Casse=0;
				Usure=0;
				Autres=0;
				Machines=0;
				GeneralMachines=0;
				TotalPreventif=0;
				TotalManquant=0;
				TotalCasse=0;
				TotalUsure=0;
				TotalAutres=0;
				TotalPieces=0;
				TotalDNR=0;
				TotalControles=0;
				TotalCA=0;

				TotalPreventifMabec=0;
				TotalManquantMabec=0;
				TotalCasseMabec=0;
				TotalUsureMabec=0;
				TotalAutresMabec=0;
				TotalPiecesMabec=0;
				TotalDNRMabec=0;
				TotalControlesMabec=0;
				TotalCAMabec=0;

				TotalPreventifTroncon=0;
				TotalManquantTroncon=0;
				TotalCasseTroncon=0;
				TotalUsureTroncon=0;
				TotalAutresTroncon=0;
				TotalPiecesTroncon=0;
				TotalDNRTroncon=0;
				TotalControlesTroncon=0;
				TotalCATroncon=0;
				GeneralPreventif=0;
				GeneralManquant=0;
				GeneralCasse=0;
				GeneralUsure=0;
				GeneralAutres=0;
				GeneralPieces=0;
				GeneralDNR=0;
				GeneralControles=0;
				GeneralCA=0;
			}*/
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
				else if(textBox2.TextLength.Equals(7))
					button1.Focus();
			}
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked)
				groupBox3.Visible=true;
			else
				groupBox3.Visible=false;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton2.Checked)
				groupBox4.Visible=true;
			else
				groupBox4.Visible=false;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			ds.Clear();
			if(radioButton8.Checked)
			{
				if(mtgcComboBox1.SelectedIndex>0)
				{
					mtgcComboBox1.BackColor=Color.Empty;
					DateTime Debut=DateTime.Now;
					DateTime Fin=DateTime.Now;
					try
					{
						debut=true;
						ancienfourn=null;
						anciendevis=null;
						ancienmabec=null;
						ancientroncon=null;
						Debut=System.Convert.ToDateTime(textBox1.Text);
						Fin=System.Convert.ToDateTime(textBox2.Text);
						Page=0;
						countRow=0;
						OleDbCommand Comm = new OleDbCommand();
						if(radioButton1.Checked&&radioButton3.Checked)
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND T_clients.Nom='"+mtgcComboBox1.Text+"') GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
							//if(radioButton1.Checked&&radioButton3.Checked)
							//	Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox3.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_fournisseurs.Nom, T_Clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						else if(radioButton1.Checked&&radioButton4.Checked)
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND T_clients.Nom='"+mtgcComboBox1.Text+"') GROUP BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
							//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon], T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]";
						else if(radioButton1.Checked&&radioButton5.Checked)
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]"; 
						else if(radioButton2.Checked&&radioButton6.Checked)
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_fournisseurs.Nom, T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.[Date reparation], T_devis_entete.[N° Devis]"; 
						Comm.Connection=oleDbConnection1;
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"devis");
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						if(ds.Tables["devis"].Rows.Count>0)
						{
							printDocument1.Print();			
							ds.Clear();
						}
						else
							MessageBox.Show("Aucun enregistrement");
					}
					catch(Exception exp)
					{
						label5.Visible=true;
					}
				}
				else
				{
					mtgcComboBox1.BackColor=Color.Salmon;
				}
			}
			else
			{
				DateTime Debut=DateTime.Now;
				DateTime Fin=DateTime.Now;
				try
				{
					debut=true;
					ancienfourn=null;
					anciendevis=null;
					ancienmabec=null;
					ancientroncon=null;
					Debut=System.Convert.ToDateTime(textBox1.Text);
					Fin=System.Convert.ToDateTime(textBox2.Text);
					Page=0;
					countRow=0;
					OleDbCommand Comm = new OleDbCommand();
					if(radioButton1.Checked&&radioButton3.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
					else if(radioButton1.Checked&&radioButton4.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_Clients.Nom,T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon], T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]";
					else if(radioButton1.Checked&&radioButton5.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]"; 
					else if(radioButton2.Checked&&radioButton6.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_Clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.[Date reparation], T_devis_entete.[N° Devis]"; 
					Comm.Connection=oleDbConnection1;
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"devis");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					if(ds.Tables["devis"].Rows.Count>0)
					{
						printDocument1.Print();	
						ds.Tables["devis"].Clear();
					}
					else
						MessageBox.Show("Aucun enregistrement");
				}
				catch(Exception exp)
				{
					label5.Visible=true;
				}
			}
			
		}

		private void radioButton7_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton7.Checked)
			{
				textBox1.Enabled=true;
				textBox2.Enabled=true;
				textBox3.Text=mtgcComboBox1.Text;
				textBox3.Enabled=true;
				textBox1.Focus();
			}
		}

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox1.SelectedIndex>0)
			{
				textBox1.Enabled=true;
				textBox2.Enabled=true;
				textBox3.Text=mtgcComboBox1.Text;
				textBox3.Enabled=true;
				radioButton8.Checked=true;
				button4.Enabled=true;
			}
			else
			{
				radioButton7.Checked=true;
				button4.Enabled=false;
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			ds.Clear();
			if(radioButton8.Checked)
			{
				if(mtgcComboBox1.SelectedIndex>0)
				{
					mtgcComboBox1.BackColor=Color.Empty;
					DateTime Debut=DateTime.Now;
					DateTime Fin=DateTime.Now;
					try
					{
						debut=true;
						ancienfourn=null;
						anciendevis=null;
						ancienmabec=null;
						ancientroncon=null;
						Debut=System.Convert.ToDateTime(textBox1.Text);
						Fin=System.Convert.ToDateTime(textBox2.Text);
						Page=0;
						countRow=0;
						OleDbCommand Comm = new OleDbCommand();
						if(radioButton1.Checked&&radioButton3.Checked)
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND T_clients.Nom='"+mtgcComboBox1.Text+"') GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
							//if(radioButton1.Checked&&radioButton3.Checked)
							//	Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_clients.Nom)='"+textBox3.Text.Replace("'","''")+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_fournisseurs.Nom, T_Clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						else if(radioButton1.Checked&&radioButton4.Checked)
							Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND T_clients.Nom='"+mtgcComboBox1.Text+"') GROUP BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
							//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] HAVING (((T_clients.Nom)='"+mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon], T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]";
						else if(radioButton1.Checked&&radioButton5.Checked)
							Comm.CommandText= "SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_clients.Nom)='" + mtgcComboBox1.Text+"') AND ((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]"; 
						else if(radioButton2.Checked&&radioButton6.Checked)
                            Comm.CommandText = "SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_fournisseurs.Nom,T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait transport], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_clients.Nom)='" + mtgcComboBox1.Text + "') AND ((T_devis_entete.[Date reparation])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date reparation])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_fournisseurs.Nom, T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.[Date reparation], T_devis_entete.[N° Devis]"; 
						Comm.Connection=oleDbConnection1;
						DataAD.SelectCommand=Comm;
						try
						{
							DataAD.Fill(ds,"devis");
						}
						catch(Exception exp)
						{
							Console.WriteLine(exp.Message);
						}
						if(ds.Tables["devis"].Rows.Count>0)
						{
							ExportExcel();			
							ds.Clear();
						}
						else
							MessageBox.Show("Aucun enregistrement");
					}
					catch(Exception exp)
					{
						label5.Visible=true;
					}
				}
				else
				{
					mtgcComboBox1.BackColor=Color.Salmon;
				}
			}
			else
			{
				DateTime Debut=DateTime.Now;
				DateTime Fin=DateTime.Now;
				try
				{
					debut=true;
					ancienfourn=null;
					anciendevis=null;
					ancienmabec=null;
					ancientroncon=null;
					Debut=System.Convert.ToDateTime(textBox1.Text);
					Fin=System.Convert.ToDateTime(textBox2.Text);
					Page=0;
					countRow=0;
					OleDbCommand Comm = new OleDbCommand();
					if(radioButton1.Checked&&radioButton3.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
					else if(radioButton1.Checked&&radioButton4.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#)) GROUP BY T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_Clients.Nom,T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Forfait transport], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING ((T_devis_entete.Niveau=7)) ORDER BY T_Clients.Nom,T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon],T_fournisseurs.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date reparation]"; 
						//Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon] HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_Clients.Nom,T_parc_machine.[Code Mabec], T_parc_machine.[N° Troncon], T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]";
					else if(radioButton1.Checked&&radioButton5.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Date reparation], T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel]"; 
					else if(radioButton2.Checked&&radioButton6.Checked)
						Comm.CommandText="SELECT T_fournisseurs.Nom,T_clients.Nom AS NomClient, T_devis_entete.[N° Devis], T_devis_entete.[Code Materiel], T_devis_entete.[Date reparation], T_devis_entete.[Date entree reelle], T_parc_machine.[Type machine], T_devis_entete.Niveau, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause, Sum(t_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN t_devis_lignes ON T_devis_entete.[N° Devis] = t_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] GROUP BY T_clients.Nom, T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date reparation], T_parc_machine.[Type machine], T_devis_entete.[Code Materiel], T_devis_entete.Niveau, T_fournisseurs.Nom, T_devis_entete.[Total pieces], T_devis_entete.[Forfait DNR], T_devis_entete.[Forfait Controle], T_devis_entete.[Total devis], t_devis_lignes.Cause HAVING (((T_devis_entete.[Date reparation])>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.[Date reparation])<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_devis_entete.Niveau)=7)) ORDER BY T_Clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Code Materiel], T_parc_machine.[Type machine], T_devis_entete.[Date reparation], T_devis_entete.[N° Devis]"; 
					Comm.Connection=oleDbConnection1;
					DataAD.SelectCommand=Comm;
					try
					{
						DataAD.Fill(ds,"devis");
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					if(ds.Tables["devis"].Rows.Count>0)
					{
						ExportExcel();
						ds.Tables["devis"].Clear();
					}
					else
						MessageBox.Show("Aucun enregistrement");
				}
				catch(Exception exp)
				{
					label5.Visible=true;
				}
			}
		}

	}
}
