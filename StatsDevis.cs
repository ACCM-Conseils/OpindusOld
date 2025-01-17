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
	/// Description résumée de StatsDevis.
	/// </summary>
	public class StatsDevis : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.TextBox textBox6;
		private int Agence;
		private MTGCComboBox mtgcComboBox1;
		private MTGCComboBox mtgcComboBox2;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private DataSet ds;
		private OleDbDataAdapter DataAD;
		private OleDbCommand Comm;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private int Page;
		private int Selection;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private DateTime Debut=DateTime.Now;
		private DateTime Fin=DateTime.Now;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StatsDevis(int Agence)
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
			ds = new DataSet();
			DataAD = new OleDbDataAdapter();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="select code,nom from t_fournisseurs order by nom";

			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_fournisseurs");
			foreach(DataRow row in ds.Tables["t_fournisseurs"].Rows)
			{
				mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["nom"].ToString(),"","",""));
			}

			Comm.CommandText="select ident,nom from t_clients order by nom";

			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_clients");
			foreach(DataRow row in ds.Tables["t_clients"].Rows)
			{
				mtgcComboBox2.Items.Add(new MTGCComboBoxItem(row["nom"].ToString(),"","",""));
			}

			printDocument1.DefaultPageSettings.Landscape=true;
			printDocument1.DefaultPageSettings.Margins.Bottom=10;
			printPreviewDialog1.SetBounds(0,0,800,600);
			Page=0;
			Selection=0;
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(StatsDevis));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.mtgcComboBox2 = new MTGCComboBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.mtgcComboBox2);
			this.groupBox1.Controls.Add(this.mtgcComboBox1);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.button6);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(689, 240);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(160, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 23;
			this.label5.Text = "Format de date incorrect";
			this.label5.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(280, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 20);
			this.textBox2.TabIndex = 22;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(160, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 20);
			this.textBox1.TabIndex = 21;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
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
			this.mtgcComboBox2.Location = new System.Drawing.Point(160, 120);
			this.mtgcComboBox2.ManagingFastMouseMoving = true;
			this.mtgcComboBox2.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox2.Name = "mtgcComboBox2";
			this.mtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox2.Size = new System.Drawing.Size(504, 21);
			this.mtgcComboBox2.TabIndex = 20;
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(160, 88);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(504, 21);
			this.mtgcComboBox1.TabIndex = 19;
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(8, 208);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(656, 20);
			this.textBox5.TabIndex = 16;
			this.textBox5.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(200, 184);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(464, 20);
			this.textBox4.TabIndex = 15;
			this.textBox4.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(8, 184);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(184, 20);
			this.textBox3.TabIndex = 14;
			this.textBox3.Text = "";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.White;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Blue;
			this.button6.Location = new System.Drawing.Point(8, 152);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(128, 23);
			this.button6.TabIndex = 11;
			this.button6.Text = "Client / Fournisseur";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.White;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Blue;
			this.button5.Location = new System.Drawing.Point(8, 120);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(128, 23);
			this.button5.TabIndex = 10;
			this.button5.Text = "Client";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Blue;
			this.button4.Location = new System.Drawing.Point(8, 88);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 23);
			this.button4.TabIndex = 9;
			this.button4.Text = "Fournisseur";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Red;
			this.button3.Location = new System.Drawing.Point(8, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Tous les devis";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(252, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Fin";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(112, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Début";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Période à traiter";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.radioButton8);
			this.groupBox2.Controls.Add(this.radioButton7);
			this.groupBox2.Controls.Add(this.radioButton6);
			this.groupBox2.Controls.Add(this.radioButton5);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Location = new System.Drawing.Point(8, 241);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(689, 269);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// radioButton8
			// 
			this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton8.Location = new System.Drawing.Point(16, 176);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(432, 24);
			this.radioButton8.TabIndex = 20;
			this.radioButton8.Text = "Durée entre la date de décision et la réparation";
			// 
			// radioButton7
			// 
			this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton7.Location = new System.Drawing.Point(16, 144);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(432, 24);
			this.radioButton7.TabIndex = 19;
			this.radioButton7.Text = "Durée entre la date de réception des pièces et la réparation";
			// 
			// radioButton6
			// 
			this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton6.Location = new System.Drawing.Point(16, 112);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(432, 24);
			this.radioButton6.TabIndex = 18;
			this.radioButton6.Text = "Durée entre la date de la génération de la commande et la réception des pièces";
			// 
			// radioButton5
			// 
			this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton5.Location = new System.Drawing.Point(16, 80);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(384, 24);
			this.radioButton5.TabIndex = 17;
			this.radioButton5.Text = "Durée entre la date de décision et la génération de la commande";
			// 
			// radioButton4
			// 
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(16, 48);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(384, 24);
			this.radioButton4.TabIndex = 16;
			this.radioButton4.Text = "Durée entre la date de saisie et la décision";
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(16, 16);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(384, 24);
			this.radioButton3.TabIndex = 15;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Durée entre l\'enregistrement du devis et la date de saisie";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(16, 240);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(648, 20);
			this.textBox6.TabIndex = 8;
			this.textBox6.Text = "";
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.White;
			this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.Blue;
			this.button8.Location = new System.Drawing.Point(176, 208);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(136, 23);
			this.button8.TabIndex = 7;
			this.button8.Text = "Tableau récapitulatif";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.White;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Blue;
			this.button7.Location = new System.Drawing.Point(16, 208);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(136, 23);
			this.button7.TabIndex = 6;
			this.button7.Text = "Voir les graphiques";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(290, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(648, 514);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 48);
			this.button1.TabIndex = 17;
			this.button1.TabStop = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// StatsDevis
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(704, 566);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "StatsDevis";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Statistiques sur les durées";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button9_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Selection=0;
			button3.BackColor=Color.MistyRose;
			button4.BackColor=Color.White;
			button5.BackColor=Color.White;
			button6.BackColor=Color.White;

		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			try
			{
				Debut=System.Convert.ToDateTime(textBox1.Text);
				Fin=System.Convert.ToDateTime(textBox2.Text);
				if(Selection.Equals(1)&&mtgcComboBox1.Text.Length.Equals(0))
				{
					MessageBox.Show("Veuillez effectuer une selection","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else if(Selection.Equals(2)&&mtgcComboBox2.Text.Length.Equals(0))
				{
					MessageBox.Show("Veuillez effectuer une selection","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else if(Selection.Equals(3)&&(mtgcComboBox1.Text.Length.Equals(0)||mtgcComboBox2.Text.Length.Equals(0)))
				{
					MessageBox.Show("Veuillez effectuer une selection","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else
				{
					printPreviewDialog1.Document=printDocument1;
					printPreviewDialog1.ShowDialog();
				}
			}
			catch(Exception ex)
			{
				label5.Visible=true;
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			if(Selection.Equals(0))
			{
				Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.[Date entree reelle], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(textBox1.Text).Month+"/"+System.Convert.ToDateTime(textBox1.Text).Day+"/"+System.Convert.ToDateTime(textBox1.Text).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(textBox2.Text).Month+"/"+System.Convert.ToDateTime(textBox2.Text).Day+"/"+System.Convert.ToDateTime(textBox2.Text).Year+"#)) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.Niveau, T_devis_entete.Date, T_devis_entete.[Date entree reelle], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation] HAVING (((T_devis_entete.Niveau)=7)) ORDER BY T_devis_entete.[N° Devis]";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_devis_entete");
			}
			if(radioButton3.Checked)
			{
				int cpt1=0;
				int cpt2=0;
				int cpt3=0;
				int cpt4=0;
				int cpt5=0;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=System.Convert.ToDateTime(row["date entree reelle"].ToString()).Subtract(System.Convert.ToDateTime(row["date"].ToString()));
					if(diff.Days<=2)
						cpt1++;
					else if(diff.Days.Equals(3))
						cpt2++;
					else if(diff.Days.Equals(4))
						cpt3++;
					else if(diff.Days>=5&&diff.Days<=10)
						cpt4++;
					else if(diff.Days>10)
						cpt5++;

				}
				decimal rep1=(System.Convert.ToDecimal(cpt1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep2=(System.Convert.ToDecimal(cpt2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep3=(System.Convert.ToDecimal(cpt3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep4=(System.Convert.ToDecimal(cpt4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep5=(System.Convert.ToDecimal(cpt5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				MessageBox.Show(rep1.ToString("0.00"));
				MessageBox.Show(rep2.ToString("0.00"));
				MessageBox.Show(rep3.ToString("0.00"));
				MessageBox.Show(rep4.ToString("0.00"));
				MessageBox.Show(rep5.ToString("0.00"));
				ds.Tables["t_devis_entete"].Clear();
			}
			else if(radioButton4.Checked)
			{
				int cpt1=0;
				int cpt2=0;
				int cpt3=0;
				int cpt4=0;
				int cpt5=0;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=System.Convert.ToDateTime(row["date decision"].ToString()).Subtract(System.Convert.ToDateTime(row["date entree reelle"].ToString()));
					if(diff.Days<=2)
						cpt1++;
					else if(diff.Days.Equals(3))
						cpt2++;
					else if(diff.Days.Equals(4))
						cpt3++;
					else if(diff.Days>=5&&diff.Days<=10)
						cpt4++;
					else if(diff.Days>10)
						cpt5++;

				}
				decimal rep1=(System.Convert.ToDecimal(cpt1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep2=(System.Convert.ToDecimal(cpt2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep3=(System.Convert.ToDecimal(cpt3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep4=(System.Convert.ToDecimal(cpt4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep5=(System.Convert.ToDecimal(cpt5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				MessageBox.Show(rep1.ToString("0.00"));
				MessageBox.Show(rep2.ToString("0.00"));
				MessageBox.Show(rep3.ToString("0.00"));
				MessageBox.Show(rep4.ToString("0.00"));
				MessageBox.Show(rep5.ToString("0.00"));
				ds.Tables["t_devis_entete"].Clear();
			}
			else if(radioButton5.Checked)
			{
				int cpt1=0;
				int cpt2=0;
				int cpt3=0;
				int cpt4=0;
				int cpt5=0;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=System.Convert.ToDateTime(row["date generation commande"].ToString()).Subtract(System.Convert.ToDateTime(row["date decision"].ToString()));
					if(diff.Days<=2)
						cpt1++;
					else if(diff.Days.Equals(3))
						cpt2++;
					else if(diff.Days.Equals(4))
						cpt3++;
					else if(diff.Days>=5&&diff.Days<=10)
						cpt4++;
					else if(diff.Days>10)
						cpt5++;

				}
				decimal rep1=(System.Convert.ToDecimal(cpt1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep2=(System.Convert.ToDecimal(cpt2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep3=(System.Convert.ToDecimal(cpt3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep4=(System.Convert.ToDecimal(cpt4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep5=(System.Convert.ToDecimal(cpt5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				MessageBox.Show(rep1.ToString("0.00"));
				MessageBox.Show(rep2.ToString("0.00"));
				MessageBox.Show(rep3.ToString("0.00"));
				MessageBox.Show(rep4.ToString("0.00"));
				MessageBox.Show(rep5.ToString("0.00"));
				ds.Tables["t_devis_entete"].Clear();
			}
			else if(radioButton6.Checked)
			{
				int cpt1=0;
				int cpt2=0;
				int cpt3=0;
				int cpt4=0;
				int cpt5=0;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=System.Convert.ToDateTime(row["date reception pieces"].ToString()).Subtract(System.Convert.ToDateTime(row["date generation commande"].ToString()));
					if(diff.Days<=2)
						cpt1++;
					else if(diff.Days.Equals(3))
						cpt2++;
					else if(diff.Days.Equals(4))
						cpt3++;
					else if(diff.Days>=5&&diff.Days<=10)
						cpt4++;
					else if(diff.Days>10)
						cpt5++;

				}
				decimal rep1=(System.Convert.ToDecimal(cpt1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep2=(System.Convert.ToDecimal(cpt2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep3=(System.Convert.ToDecimal(cpt3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep4=(System.Convert.ToDecimal(cpt4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep5=(System.Convert.ToDecimal(cpt5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				MessageBox.Show(rep1.ToString("0.00"));
				MessageBox.Show(rep2.ToString("0.00"));
				MessageBox.Show(rep3.ToString("0.00"));
				MessageBox.Show(rep4.ToString("0.00"));
				MessageBox.Show(rep5.ToString("0.00"));
				ds.Tables["t_devis_entete"].Clear();
			}
			else if(radioButton7.Checked)
			{
				int cpt1=0;
				int cpt2=0;
				int cpt3=0;
				int cpt4=0;
				int cpt5=0;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=System.Convert.ToDateTime(row["date reparation"].ToString()).Subtract(System.Convert.ToDateTime(row["date reception pieces"].ToString()));
					if(diff.Days<=2)
						cpt1++;
					else if(diff.Days.Equals(3))
						cpt2++;
					else if(diff.Days.Equals(4))
						cpt3++;
					else if(diff.Days>=5&&diff.Days<=10)
						cpt4++;
					else if(diff.Days>10)
						cpt5++;

				}
				decimal rep1=(System.Convert.ToDecimal(cpt1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep2=(System.Convert.ToDecimal(cpt2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep3=(System.Convert.ToDecimal(cpt3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep4=(System.Convert.ToDecimal(cpt4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep5=(System.Convert.ToDecimal(cpt5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				MessageBox.Show(rep1.ToString("0.00"));
				MessageBox.Show(rep2.ToString("0.00"));
				MessageBox.Show(rep3.ToString("0.00"));
				MessageBox.Show(rep4.ToString("0.00"));
				MessageBox.Show(rep5.ToString("0.00"));
				ds.Tables["t_devis_entete"].Clear();
			}
			else if(radioButton8.Checked)
			{
				int cpt1=0;
				int cpt2=0;
				int cpt3=0;
				int cpt4=0;
				int cpt5=0;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=System.Convert.ToDateTime(row["date reparation"].ToString()).Subtract(System.Convert.ToDateTime(row["date decision"].ToString()));
					if(diff.Days<=2)
						cpt1++;
					else if(diff.Days.Equals(3))
						cpt2++;
					else if(diff.Days.Equals(4))
						cpt3++;
					else if(diff.Days>=5&&diff.Days<=10)
						cpt4++;
					else if(diff.Days>10)
						cpt5++;

				}
				decimal rep1=(System.Convert.ToDecimal(cpt1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep2=(System.Convert.ToDecimal(cpt2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep3=(System.Convert.ToDecimal(cpt3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep4=(System.Convert.ToDecimal(cpt4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				decimal rep5=(System.Convert.ToDecimal(cpt5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				MessageBox.Show(rep1.ToString("0.00"));
				MessageBox.Show(rep2.ToString("0.00"));
				MessageBox.Show(rep3.ToString("0.00"));
				MessageBox.Show(rep4.ToString("0.00"));
				MessageBox.Show(rep5.ToString("0.00"));
				ds.Tables["t_devis_entete"].Clear();
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			//if(ds.Tables["t_devis_entete"].Rows.Count>0)
			//{
				int cpt1_1=0;
				int cpt2_1=0;
				int cpt3_1=0;
				int cpt4_1=0;
				int cpt5_1=0;
				int Total_1=0;
			if(Selection.Equals(0))
				Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.[Date entree reelle] FROM T_devis_entete WHERE T_devis_entete.[Date]>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# AND T_devis_entete.[Date]<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#";
			else if(Selection.Equals(1))
				Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.[Date entree reelle] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.Date)>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.Date)<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_fournisseurs.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.[Date entree reelle]";
			else if(Selection.Equals(2))
				Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.[Date entree reelle] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE (((T_devis_entete.Date)>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.Date)<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_clients.Nom)='"+mtgcComboBox2.Text.Replace("'","''")+"')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.[Date entree reelle]";
			else if(Selection.Equals(3))
				Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.[Date entree reelle] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.Date)>=#"+Debut.Month+"/"+Debut.Day+"/"+Debut.Year+"# And (T_devis_entete.Date)<=#"+Fin.Month+"/"+Fin.Day+"/"+Fin.Year+"#) AND ((T_clients.Nom)='"+mtgcComboBox2.Text.Replace("'","''")+"') AND ((T_fournisseurs.Nom)='"+mtgcComboBox1.Text.Replace("'","''")+"')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.Date, T_devis_entete.[Date entree reelle]";

			DataAD.SelectCommand=Comm;
			decimal rep1_1=0;
			decimal rep2_1=0;
			decimal rep3_1=0;
			decimal rep4_1=0;
			decimal rep5_1=0;
			if(DataAD.Fill(ds,"t_devis_entete")>0)
			{
				Total_1=ds.Tables["t_devis_entete"].Rows.Count;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=new TimeSpan(0,0,0,0,0);
					try
					{
						diff=System.Convert.ToDateTime(row["date entree reelle"].ToString()).Subtract(System.Convert.ToDateTime(row["date"].ToString()));
						if(diff.Days<=2)
							cpt1_1++;
						else if(diff.Days.Equals(3))
							cpt2_1++;
						else if(diff.Days.Equals(4))
							cpt3_1++;
						else if(diff.Days>=5&&diff.Days<=10)
							cpt4_1++;
						else if(diff.Days>10)
							cpt5_1++;
					}
					catch(Exception exp)
					{
						cpt1_1++;
					}

				}
				rep1_1=(System.Convert.ToDecimal(cpt1_1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep2_1=(System.Convert.ToDecimal(cpt2_1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep3_1=(System.Convert.ToDecimal(cpt3_1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep4_1=(System.Convert.ToDecimal(cpt4_1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep5_1=(System.Convert.ToDecimal(cpt5_1)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				ds.Tables["t_devis_entete"].Clear();
			}

				int cpt1_2=0;
				int cpt2_2=0;
				int cpt3_2=0;
				int cpt4_2=0;
				int cpt5_2=0;
				int Total_2=0;
			if(Selection.Equals(0))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date Decision] FROM T_devis_entete WHERE (((T_devis_entete.[Date entree reelle])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date entree reelle])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#))";
			else if(Selection.Equals(1))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date Decision] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date entree reelle])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date entree reelle])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date decision]";
			else if(Selection.Equals(2))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date Decision] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE (((T_devis_entete.[Date entree reelle])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date entree reelle])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date decision]";
			else if(Selection.Equals(3))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date Decision] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date entree reelle])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date entree reelle])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "') AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date entree reelle], T_devis_entete.[Date decision]";
				DataAD.SelectCommand=Comm;
			decimal rep1_2=0;
			decimal rep2_2=0;
			decimal rep3_2=0;
			decimal rep4_2=0;
			decimal rep5_2=0;
			if(DataAD.Fill(ds,"t_devis_entete")>0)
			{
				Total_2=ds.Tables["t_devis_entete"].Rows.Count;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=new TimeSpan(0,0,0,0,0);
					try
					{
						diff=System.Convert.ToDateTime(row["date decision"].ToString()).Subtract(System.Convert.ToDateTime(row["date entree reelle"].ToString()));
						if(diff.Days<=2)
							cpt1_2++;
						else if(diff.Days.Equals(3))
							cpt2_2++;
						else if(diff.Days.Equals(4))
							cpt3_2++;
						else if(diff.Days>=5&&diff.Days<=10)
							cpt4_2++;
						else if(diff.Days>10)
							cpt5_2++;
					}
					catch(Exception exp)
					{
						cpt1_2++;
					}
					

				}
				
				rep1_2=(System.Convert.ToDecimal(cpt1_2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep2_2=(System.Convert.ToDecimal(cpt2_2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep3_2=(System.Convert.ToDecimal(cpt3_2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep4_2=(System.Convert.ToDecimal(cpt4_2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep5_2=(System.Convert.ToDecimal(cpt5_2)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				ds.Tables["t_devis_entete"].Clear();
			}

				int cpt1_3=0;
				int cpt2_3=0;
				int cpt3_3=0;
				int cpt4_3=0;
				int cpt5_3=0;
				int Total_3=0;
			if(Selection.Equals(0))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande] FROM T_devis_entete WHERE (((T_devis_entete.[Date Decision])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Decision])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#))";
			else if(Selection.Equals(1))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date Decision])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date decision])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande]";
			else if(Selection.Equals(2))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE (((T_devis_entete.[Date Decision])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Decision])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande]";
			else if(Selection.Equals(3))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date Decision])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Decision])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "') AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date Generation commande]";

				DataAD.SelectCommand=Comm;
			decimal rep1_3=0;
			decimal rep2_3=0;
			decimal rep3_3=0;
			decimal rep4_3=0;
			decimal rep5_3=0;
			if(DataAD.Fill(ds,"t_devis_entete")>0)
			{
				Total_3=ds.Tables["t_devis_entete"].Rows.Count;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=new TimeSpan(0,0,0,0,0);
					try
					{
						diff=System.Convert.ToDateTime(row["date generation commande"].ToString()).Subtract(System.Convert.ToDateTime(row["date decision"].ToString()));
						if(diff.Days<=2)
							cpt1_3++;
						else if(diff.Days.Equals(3))
							cpt2_3++;
						else if(diff.Days.Equals(4))
							cpt3_3++;
						else if(diff.Days>=5&&diff.Days<=10)
							cpt4_3++;
						else if(diff.Days>10)
							cpt5_3++;
					}
					catch(Exception exp)
					{
						cpt1_3++;
					}
					

				}
				
				rep1_3=(System.Convert.ToDecimal(cpt1_3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep2_3=(System.Convert.ToDecimal(cpt2_3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep3_3=(System.Convert.ToDecimal(cpt3_3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep4_3=(System.Convert.ToDecimal(cpt4_3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep5_3=(System.Convert.ToDecimal(cpt5_3)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				ds.Tables["t_devis_entete"].Clear();
			}

				int cpt1_4=0;
				int cpt2_4=0;
				int cpt3_4=0;
				int cpt4_4=0;
				int cpt5_4=0;
				int Total_4=0;
			if(Selection.Equals(0))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces] FROM T_devis_entete WHERE (((T_devis_entete.[Date Generation commande])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Generation commande])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#))";
			else if(Selection.Equals(1))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date Generation commande])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Generation commande])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces]";
			else if(Selection.Equals(2))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE (((T_devis_entete.[Date Generation commande])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Generation commande])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces]";
			else if(Selection.Equals(3))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date Generation commande])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Generation commande])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "') AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Generation commande], T_devis_entete.[Date Reception pieces]";

				DataAD.SelectCommand=Comm;
			decimal rep1_4=0;
			decimal rep2_4=0;
			decimal rep3_4=0;
			decimal rep4_4=0;
			decimal rep5_4=0;
			if(DataAD.Fill(ds,"t_devis_entete")>0)
			{
				Total_4=ds.Tables["t_devis_entete"].Rows.Count;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=new TimeSpan(0,0,0,0,0);
					try
					{
						diff=System.Convert.ToDateTime(row["date reception pieces"].ToString()).Subtract(System.Convert.ToDateTime(row["date generation commande"].ToString()));
						if(diff.Days<=2)
							cpt1_4++;
						else if(diff.Days.Equals(3))
							cpt2_4++;
						else if(diff.Days.Equals(4))
							cpt3_4++;
						else if(diff.Days>=5&&diff.Days<=10)
							cpt4_4++;
						else if(diff.Days>10)
							cpt5_4++;
					}
					catch(Exception exp)
					{
						cpt1_4++;
					}
					

				}
				
				rep1_4=(System.Convert.ToDecimal(cpt1_4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep2_4=(System.Convert.ToDecimal(cpt2_4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep3_4=(System.Convert.ToDecimal(cpt3_4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep4_4=(System.Convert.ToDecimal(cpt4_4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep5_4=(System.Convert.ToDecimal(cpt5_4)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				ds.Tables["t_devis_entete"].Clear();
			}

				int cpt1_5=0;
				int cpt2_5=0;
				int cpt3_5=0;
				int cpt4_5=0;
				int cpt5_5=0;
				int Total_5=0;
			if(Selection.Equals(0))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation] FROM T_devis_entete WHERE (((T_devis_entete.[Date Reparation])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Reparation])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "# AND ((T_devis_entete.Niveau)=7)))";
			else if(Selection.Equals(1))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date Reception pieces])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Reception pieces])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation]";
			else if(Selection.Equals(2))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE (((T_devis_entete.[Date Reception pieces])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Reception pieces])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation]";
			else if(Selection.Equals(3))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date Reception pieces])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Reception pieces])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "') AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Reception pieces], T_devis_entete.[Date reparation]";

				DataAD.SelectCommand=Comm;
			decimal rep1_5=0;
			decimal rep2_5=0;
			decimal rep3_5=0;
			decimal rep4_5=0;
			decimal rep5_5=0;
			if(DataAD.Fill(ds,"t_devis_entete")>0)
			{
				Total_5=ds.Tables["t_devis_entete"].Rows.Count;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=new TimeSpan(0,0,0,0,0);
					try
					{
						diff=System.Convert.ToDateTime(row["date reparation"].ToString()).Subtract(System.Convert.ToDateTime(row["date reception pieces"].ToString()));
						if(diff.Days<=2)
							cpt1_5++;
						else if(diff.Days.Equals(3))
							cpt2_5++;
						else if(diff.Days.Equals(4))
							cpt3_5++;
						else if(diff.Days>=5&&diff.Days<=10)
							cpt4_5++;
						else if(diff.Days>10)
							cpt5_5++;
					}
					catch(Exception exp)
					{
						cpt1_5++;
					}
					

				}
				
				rep1_5=(System.Convert.ToDecimal(cpt1_5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep2_5=(System.Convert.ToDecimal(cpt2_5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep3_5=(System.Convert.ToDecimal(cpt3_5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep4_5=(System.Convert.ToDecimal(cpt4_5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep5_5=(System.Convert.ToDecimal(cpt5_5)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				ds.Tables["t_devis_entete"].Clear();
			}

				int cpt1_6=0;
				int cpt2_6=0;
				int cpt3_6=0;
				int cpt4_6=0;
				int cpt5_6=0;
				int Total_6=0;
			if(Selection.Equals(0))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation] FROM T_devis_entete WHERE (((T_devis_entete.[Date Decision])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Decision])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#))";
			else if(Selection.Equals(1))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date Decision])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Decision])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation]";
			else if(Selection.Equals(2))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE (((T_devis_entete.[Date Decision])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Decision])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation]";
			else if(Selection.Equals(3))
                Comm.CommandText = "SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_fournisseurs.Code = T_type_machine.Fournisseur WHERE (((T_devis_entete.[Date Decision])>=#" + Debut.Month + "/" + Debut.Day + "/" + Debut.Year + "# And (T_devis_entete.[Date Decision])<=#" + Fin.Month + "/" + Fin.Day + "/" + Fin.Year + "#) AND ((T_clients.Nom)='" + mtgcComboBox2.Text.Replace("'", "''") + "') AND ((T_fournisseurs.Nom)='" + mtgcComboBox1.Text.Replace("'", "''") + "')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Date reparation]";	
				DataAD.SelectCommand=Comm;
			decimal rep1_6=0;
			decimal rep2_6=0;
			decimal rep3_6=0;
			decimal rep4_6=0;
			decimal rep5_6=0;
			if(DataAD.Fill(ds,"t_devis_entete")>0)
			{
				Total_6=ds.Tables["t_devis_entete"].Rows.Count;
				foreach(DataRow row in ds.Tables["t_devis_entete"].Rows)
				{
					TimeSpan diff=new TimeSpan(0,0,0,0,0);
					try
					{
						diff=System.Convert.ToDateTime(row["date reparation"].ToString()).Subtract(System.Convert.ToDateTime(row["date decision"].ToString()));
						if(diff.Days<=2)
							cpt1_6++;
						else if(diff.Days.Equals(3))
							cpt2_6++;
						else if(diff.Days.Equals(4))
							cpt3_6++;
						else if(diff.Days>=5&&diff.Days<=10)
							cpt4_6++;
						else if(diff.Days>10)
							cpt5_6++;
					}
					catch(Exception exp)
					{
						cpt1_6++;
					}
					

				}
				
				rep1_6=(System.Convert.ToDecimal(cpt1_6)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep2_6=(System.Convert.ToDecimal(cpt2_6)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep3_6=(System.Convert.ToDecimal(cpt3_6)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep4_6=(System.Convert.ToDecimal(cpt4_6)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;
				rep5_6=(System.Convert.ToDecimal(cpt5_6)/System.Convert.ToDecimal(ds.Tables["t_devis_entete"].Rows.Count.ToString()))*100;

				ds.Tables["t_devis_entete"].Clear();
			}
				Page+=1;
				int ypos=e.MarginBounds.Top;
				e.Graphics.DrawString("Edition statistiques devis", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
				ypos+=200;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left,ypos,e.MarginBounds.Width+40,60);
				if(Agence.Equals(1))
				{
					e.Graphics.DrawString("Agence de St Priest", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+5, ypos+5);
				}
				e.Graphics.DrawString("Periode du "+System.Convert.ToDateTime(textBox1.Text).ToShortDateString()+" au "+System.Convert.ToDateTime(textBox2.Text).ToShortDateString()+" - Date d'édition : "+DateTime.Today.ToShortDateString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+5, ypos+23);
				e.Graphics.DrawString("Type Edition : ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+5, ypos+40);
				ypos+=60;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left,ypos,100,350);
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+100,ypos,e.MarginBounds.Width-60,50);
				e.Graphics.DrawString("Statistiques maintenance 10 jours", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+200, ypos+15);
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+520,ypos),new Point(e.MarginBounds.Left+520,ypos+350));
				e.Graphics.DrawString("<= 48 heures", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+530, ypos+15);
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+630,ypos),new Point(e.MarginBounds.Left+630,ypos+350));
				e.Graphics.DrawString("3 jours", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+655, ypos+15);
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+720,ypos),new Point(e.MarginBounds.Left+720,ypos+350));
				e.Graphics.DrawString("4 jours", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+745, ypos+15);
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+820,ypos),new Point(e.MarginBounds.Left+820,ypos+350));
				e.Graphics.DrawString("5/10 jours", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+830, ypos+15);
				e.Graphics.DrawLine(new Pen(Color.Black, 1),new Point(e.MarginBounds.Left+920,ypos),new Point(e.MarginBounds.Left+920,ypos+350));
				e.Graphics.DrawString(">10 jours", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+930, ypos+15);
				ypos+=50;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+100,ypos,e.MarginBounds.Width-60,50);
				e.Graphics.DrawString(Total_1.ToString()+" devis", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+20, ypos+15);
				e.Graphics.DrawString("Durée entre l'enregistrement du devis et la date de saisie", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+105, ypos+15);
				e.Graphics.DrawString(rep1_1.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos+15);
				e.Graphics.DrawString(rep2_1.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos+15);
				e.Graphics.DrawString(rep3_1.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos+15);
				e.Graphics.DrawString(rep4_1.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos+15);
				e.Graphics.DrawString(rep5_1.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+950, ypos+15);
				ypos+=50;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+100,ypos,e.MarginBounds.Width-60,50);
				e.Graphics.DrawString(Total_2.ToString()+" devis", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+20, ypos+15);
				e.Graphics.DrawString("Durée entre la date de saisie et la décision", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+105, ypos+15);
				e.Graphics.DrawString(rep1_2.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos+15);
				e.Graphics.DrawString(rep2_2.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos+15);
				e.Graphics.DrawString(rep3_2.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos+15);
				e.Graphics.DrawString(rep4_2.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos+15);
				e.Graphics.DrawString(rep5_2.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+950, ypos+15);
				ypos+=50;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+100,ypos,e.MarginBounds.Width-60,50);
				e.Graphics.DrawString(Total_3.ToString()+" devis", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+20, ypos+15);
				e.Graphics.DrawString("Durée entre la date de décision et la génération de commande", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+105, ypos+15);
				e.Graphics.DrawString(rep1_3.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos+15);
				e.Graphics.DrawString(rep2_3.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos+15);
				e.Graphics.DrawString(rep3_3.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos+15);
				e.Graphics.DrawString(rep4_3.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos+15);
				e.Graphics.DrawString(rep5_3.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+950, ypos+15);
				ypos+=50;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+100,ypos,e.MarginBounds.Width-60,50);
				e.Graphics.DrawString(Total_4.ToString()+" devis", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+20, ypos+15);
				e.Graphics.DrawString("Durée entre la date de génération de commande et la réception pièces", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+105, ypos+15);
				e.Graphics.DrawString(rep1_4.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos+15);
				e.Graphics.DrawString(rep2_4.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos+15);
				e.Graphics.DrawString(rep3_4.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos+15);
				e.Graphics.DrawString(rep4_4.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos+15);
				e.Graphics.DrawString(rep5_4.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+950, ypos+15);
				ypos+=50;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+100,ypos,e.MarginBounds.Width-60,50);
				e.Graphics.DrawString(Total_5.ToString()+" devis", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+20, ypos+15);	
				e.Graphics.DrawString("Durée entre la date de réception pièces et la réparation", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+105, ypos+15);
				e.Graphics.DrawString(rep1_5.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos+15);
				e.Graphics.DrawString(rep2_5.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos+15);
				e.Graphics.DrawString(rep3_5.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos+15);
				e.Graphics.DrawString(rep4_5.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos+15);
				e.Graphics.DrawString(rep5_5.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+950, ypos+15);
				ypos+=50;
				e.Graphics.DrawRectangle(new Pen(Color.Black, 1),e.MarginBounds.Left+100,ypos,e.MarginBounds.Width-60,50);
				e.Graphics.DrawString(Total_6.ToString()+" devis", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+20, ypos+15);
				e.Graphics.DrawString("Durée entre la date de décision et la réparation", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+105, ypos+15);
				e.Graphics.DrawString(rep1_6.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+560, ypos+15);
				e.Graphics.DrawString(rep2_6.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+665, ypos+15);
				e.Graphics.DrawString(rep3_6.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+755, ypos+15);
				e.Graphics.DrawString(rep4_6.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+850, ypos+15);
				e.Graphics.DrawString(rep5_6.ToString("0.00")+"%", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+950, ypos+15);
			Page=0;
			//}
			/*else
			{
				ds.Tables["t_devis_entete"].Clear();
				Page+=1;
				int ypos=e.MarginBounds.Top;
				e.Graphics.DrawString("Edition statistiques devis", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
				ypos+=200;
				e.Graphics.DrawString("Aucun devis trouvé", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left+300, ypos);
			}*/
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			mtgcComboBox2.Text="";
			Selection=1;
			button4.BackColor=Color.MistyRose;
			button3.BackColor=Color.White;
			button5.BackColor=Color.White;
			button6.BackColor=Color.White;
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			mtgcComboBox1.Text="";
			Selection=2;
			button5.BackColor=Color.MistyRose;
			button3.BackColor=Color.White;
			button4.BackColor=Color.White;
			button6.BackColor=Color.White;
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			Selection=3;
			button5.BackColor=Color.White;
			button3.BackColor=Color.White;
			button4.BackColor=Color.White;
			button6.BackColor=Color.MistyRose;
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

	}
}
