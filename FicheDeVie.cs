using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Opindus
{
	/// <summary>
	/// Description résumée de FicheDeVie.
	/// </summary>
	public class FicheDeVie : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.ColumnHeader columnHeader20;
		private System.Windows.Forms.ColumnHeader columnHeader21;
		private System.Windows.Forms.ColumnHeader columnHeader22;
		private System.Windows.Forms.ColumnHeader columnHeader23;
		private System.Windows.Forms.ColumnHeader columnHeader24;
		private System.Windows.Forms.ColumnHeader columnHeader25;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ColumnHeader columnHeader26;
		private System.Windows.Forms.ColumnHeader columnHeader27;
		private System.Windows.Forms.ColumnHeader columnHeader30;
		private System.Windows.Forms.ColumnHeader columnHeader31;
		private System.Windows.Forms.ColumnHeader columnHeader32;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.ListView listView5;
		private System.Windows.Forms.ColumnHeader columnHeader28;
		private System.Windows.Forms.ColumnHeader columnHeader29;
		private System.Windows.Forms.ColumnHeader columnHeader33;
		private System.Windows.Forms.ColumnHeader columnHeader34;
		private System.Windows.Forms.ColumnHeader columnHeader35;
		private System.Windows.Forms.ColumnHeader columnHeader36;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.ListView listView6;
		private System.Windows.Forms.ColumnHeader columnHeader37;
		private System.Windows.Forms.ColumnHeader columnHeader38;
		private System.Windows.Forms.ColumnHeader columnHeader40;
		private System.Windows.Forms.ColumnHeader columnHeader41;
		private System.Windows.Forms.ColumnHeader columnHeader42;
		private System.Windows.Forms.Button button2;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private string Machine;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private Dotnetrix.Controls.TabPageEX tabPageEX2;
		private Dotnetrix.Controls.TabPageEX tabPageEX3;
		private Dotnetrix.Controls.TabPageEX tabPageEX4;
		private Dotnetrix.Controls.TabPageEX tabPageEX5;
		private Dotnetrix.Controls.TabPageEX tabPageEX6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button19;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FicheDeVie(int Agence,string Code)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			this.Agence=Agence;
			Machine=Code;
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
			tabControlEX1.SelectedTab=tabPageEX1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FicheDeVie));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.listView3 = new System.Windows.Forms.ListView();
			this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader23 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader24 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader25 = new System.Windows.Forms.ColumnHeader();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.listView4 = new System.Windows.Forms.ListView();
			this.columnHeader26 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader27 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader30 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader31 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader32 = new System.Windows.Forms.ColumnHeader();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.listView5 = new System.Windows.Forms.ListView();
			this.columnHeader28 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader29 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader36 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader33 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader34 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader35 = new System.Windows.Forms.ColumnHeader();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.listView6 = new System.Windows.Forms.ListView();
			this.columnHeader37 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader38 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader40 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader41 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader42 = new System.Windows.Forms.ColumnHeader();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX4 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX5 = new Dotnetrix.Controls.TabPageEX();
			this.tabPageEX6 = new Dotnetrix.Controls.TabPageEX();
			this.button3 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.tabPageEX2.SuspendLayout();
			this.tabPageEX3.SuspendLayout();
			this.tabPageEX4.SuspendLayout();
			this.tabPageEX5.SuspendLayout();
			this.tabPageEX6.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3,
																						this.columnHeader4,
																						this.columnHeader5,
																						this.columnHeader6,
																						this.columnHeader7});
			this.listView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(8, 40);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(952, 328);
			this.listView1.TabIndex = 16;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Date";
			this.columnHeader1.Width = 70;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Type intervention";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Coût";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 70;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Cumul dépenses globales";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 160;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Affectation";
			this.columnHeader5.Width = 130;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Site";
			this.columnHeader6.Width = 129;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Commentaires";
			this.columnHeader7.Width = 260;
			// 
			// textBox9
			// 
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox9.ForeColor = System.Drawing.Color.Red;
			this.textBox9.Location = new System.Drawing.Point(8, 8);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(208, 22);
			this.textBox9.TabIndex = 17;
			this.textBox9.Text = "Fiche de vie";
			this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listView2
			// 
			this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader8,
																						this.columnHeader9,
																						this.columnHeader10,
																						this.columnHeader11,
																						this.columnHeader15,
																						this.columnHeader16,
																						this.columnHeader17,
																						this.columnHeader18,
																						this.columnHeader12,
																						this.columnHeader13,
																						this.columnHeader14});
			this.listView2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new System.Drawing.Point(8, 40);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(952, 328);
			this.listView2.TabIndex = 19;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Date";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Type inter";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 100;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Coût";
			this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "C. dep. globales";
			this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader11.Width = 110;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "C. dep. réparat.";
			this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader15.Width = 110;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Nbr rep.";
			this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "Cumul dep. ctrl";
			this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader17.Width = 100;
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "Nbr ctrl";
			this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Affectation";
			this.columnHeader12.Width = 100;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Site";
			this.columnHeader13.Width = 100;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Comment.";
			this.columnHeader14.Width = 70;
			// 
			// textBox10
			// 
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox10.ForeColor = System.Drawing.Color.Red;
			this.textBox10.Location = new System.Drawing.Point(8, 8);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(208, 22);
			this.textBox10.TabIndex = 18;
			this.textBox10.Text = "Opindus";
			this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listView3
			// 
			this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader19,
																						this.columnHeader20,
																						this.columnHeader21,
																						this.columnHeader22,
																						this.columnHeader23,
																						this.columnHeader24,
																						this.columnHeader25});
			this.listView3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView3.FullRowSelect = true;
			this.listView3.GridLines = true;
			this.listView3.Location = new System.Drawing.Point(8, 40);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(952, 328);
			this.listView3.TabIndex = 20;
			this.listView3.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "Date";
			this.columnHeader19.Width = 70;
			// 
			// columnHeader20
			// 
			this.columnHeader20.Text = "Type intervention";
			this.columnHeader20.Width = 120;
			// 
			// columnHeader21
			// 
			this.columnHeader21.Text = "Coût";
			this.columnHeader21.Width = 70;
			// 
			// columnHeader22
			// 
			this.columnHeader22.Text = "Cumul dépenses globales";
			this.columnHeader22.Width = 160;
			// 
			// columnHeader23
			// 
			this.columnHeader23.Text = "Affectation";
			this.columnHeader23.Width = 130;
			// 
			// columnHeader24
			// 
			this.columnHeader24.Text = "Site";
			this.columnHeader24.Width = 129;
			// 
			// columnHeader25
			// 
			this.columnHeader25.Text = "Commentaires";
			this.columnHeader25.Width = 150;
			// 
			// textBox11
			// 
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox11.ForeColor = System.Drawing.Color.Red;
			this.textBox11.Location = new System.Drawing.Point(8, 8);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(208, 22);
			this.textBox11.TabIndex = 19;
			this.textBox11.Text = "Libre";
			this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listView4
			// 
			this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader26,
																						this.columnHeader27,
																						this.columnHeader30,
																						this.columnHeader31,
																						this.columnHeader32});
			this.listView4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView4.FullRowSelect = true;
			this.listView4.GridLines = true;
			this.listView4.Location = new System.Drawing.Point(8, 40);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(952, 328);
			this.listView4.TabIndex = 21;
			this.listView4.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader26
			// 
			this.columnHeader26.Text = "Date";
			this.columnHeader26.Width = 70;
			// 
			// columnHeader27
			// 
			this.columnHeader27.Text = "Type intervention";
			this.columnHeader27.Width = 120;
			// 
			// columnHeader30
			// 
			this.columnHeader30.Text = "Affectation";
			this.columnHeader30.Width = 130;
			// 
			// columnHeader31
			// 
			this.columnHeader31.Text = "Site";
			this.columnHeader31.Width = 129;
			// 
			// columnHeader32
			// 
			this.columnHeader32.Text = "Commentaires";
			this.columnHeader32.Width = 150;
			// 
			// textBox12
			// 
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox12.ForeColor = System.Drawing.Color.Red;
			this.textBox12.Location = new System.Drawing.Point(8, 8);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(208, 22);
			this.textBox12.TabIndex = 20;
			this.textBox12.Text = "Affectations";
			this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listView5
			// 
			this.listView5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader28,
																						this.columnHeader29,
																						this.columnHeader36,
																						this.columnHeader33,
																						this.columnHeader34,
																						this.columnHeader35});
			this.listView5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView5.FullRowSelect = true;
			this.listView5.GridLines = true;
			this.listView5.Location = new System.Drawing.Point(8, 40);
			this.listView5.Name = "listView5";
			this.listView5.Size = new System.Drawing.Size(952, 328);
			this.listView5.TabIndex = 22;
			this.listView5.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader28
			// 
			this.columnHeader28.Text = "Date";
			this.columnHeader28.Width = 70;
			// 
			// columnHeader29
			// 
			this.columnHeader29.Text = "Type intervention";
			this.columnHeader29.Width = 120;
			// 
			// columnHeader36
			// 
			this.columnHeader36.Text = "Résultats contrôle";
			this.columnHeader36.Width = 380;
			// 
			// columnHeader33
			// 
			this.columnHeader33.Text = "Affectation";
			this.columnHeader33.Width = 100;
			// 
			// columnHeader34
			// 
			this.columnHeader34.Text = "Site";
			this.columnHeader34.Width = 100;
			// 
			// columnHeader35
			// 
			this.columnHeader35.Text = "Commentaires";
			this.columnHeader35.Width = 150;
			// 
			// textBox13
			// 
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox13.ForeColor = System.Drawing.Color.Red;
			this.textBox13.Location = new System.Drawing.Point(8, 8);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(208, 22);
			this.textBox13.TabIndex = 21;
			this.textBox13.Text = "Contrôles";
			this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// listView6
			// 
			this.listView6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader37,
																						this.columnHeader38,
																						this.columnHeader40,
																						this.columnHeader41,
																						this.columnHeader42});
			this.listView6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView6.FullRowSelect = true;
			this.listView6.GridLines = true;
			this.listView6.Location = new System.Drawing.Point(8, 40);
			this.listView6.Name = "listView6";
			this.listView6.Size = new System.Drawing.Size(952, 328);
			this.listView6.TabIndex = 23;
			this.listView6.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader37
			// 
			this.columnHeader37.Text = "Date";
			this.columnHeader37.Width = 70;
			// 
			// columnHeader38
			// 
			this.columnHeader38.Text = "Type intervention";
			this.columnHeader38.Width = 120;
			// 
			// columnHeader40
			// 
			this.columnHeader40.Text = "Affectation";
			this.columnHeader40.Width = 100;
			// 
			// columnHeader41
			// 
			this.columnHeader41.Text = "Site";
			this.columnHeader41.Width = 100;
			// 
			// columnHeader42
			// 
			this.columnHeader42.Text = "Commentaires";
			this.columnHeader42.Width = 150;
			// 
			// textBox14
			// 
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox14.ForeColor = System.Drawing.Color.Red;
			this.textBox14.Location = new System.Drawing.Point(8, 8);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(208, 22);
			this.textBox14.TabIndex = 22;
			this.textBox14.Text = "Commentaires";
			this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(976, 104);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lavender;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(325, 63);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(201, 23);
			this.button2.TabIndex = 48;
			this.button2.Text = "Fiche de vie graphique";
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(140, 70);
			this.textBox8.Name = "textBox8";
			this.textBox8.TabIndex = 47;
			this.textBox8.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(12, 70);
			this.textBox7.Name = "textBox7";
			this.textBox7.TabIndex = 46;
			this.textBox7.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(728, 24);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(239, 20);
			this.textBox6.TabIndex = 45;
			this.textBox6.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(428, 24);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(296, 20);
			this.textBox5.TabIndex = 44;
			this.textBox5.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(324, 24);
			this.textBox4.Name = "textBox4";
			this.textBox4.TabIndex = 43;
			this.textBox4.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(220, 24);
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 42;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(116, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 41;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(12, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 40;
			this.textBox1.Text = "";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(140, 54);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 39;
			this.label8.Text = "Date réforme";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 54);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = "Date mise en service";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(728, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 37;
			this.label6.Text = "Famille";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(428, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 36;
			this.label5.Text = "Fournisseur";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(324, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = "Code Mabec";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(220, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 34;
			this.label3.Text = "N° Serie";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(116, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 33;
			this.label2.Text = "Code machine";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 32;
			this.label1.Text = "Type machine";
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
																										new System.Data.Common.DataTableMapping("Table", "T_parc_machine", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("Affectation", "Affectation"),
																																																						  new System.Data.Common.DataColumnMapping("Code Client", "Code Client"),
																																																						  new System.Data.Common.DataColumnMapping("Code Mabec", "Code Mabec"),
																																																						  new System.Data.Common.DataColumnMapping("Code machine client", "Code machine client"),
																																																						  new System.Data.Common.DataColumnMapping("Code machine Opindus", "Code machine Opindus"),
																																																						  new System.Data.Common.DataColumnMapping("creation", "creation"),
																																																						  new System.Data.Common.DataColumnMapping("Date dernier controle", "Date dernier controle"),
																																																						  new System.Data.Common.DataColumnMapping("Date dernier intervention", "Date dernier intervention"),
																																																						  new System.Data.Common.DataColumnMapping("Date fin garantie", "Date fin garantie"),
																																																						  new System.Data.Common.DataColumnMapping("Date mise en service", "Date mise en service"),
																																																						  new System.Data.Common.DataColumnMapping("Date reforme", "Date reforme"),
																																																						  new System.Data.Common.DataColumnMapping("Date refus", "Date refus"),
																																																						  new System.Data.Common.DataColumnMapping("En parc", "En parc"),
																																																						  new System.Data.Common.DataColumnMapping("En reparation", "En reparation"),
																																																						  new System.Data.Common.DataColumnMapping("Maxi machine", "Maxi machine"),
																																																						  new System.Data.Common.DataColumnMapping("Memo", "Memo"),
																																																						  new System.Data.Common.DataColumnMapping("Mini machine", "Mini machine"),
																																																						  new System.Data.Common.DataColumnMapping("N_fichier_FVG", "N_fichier_FVG"),
																																																						  new System.Data.Common.DataColumnMapping("N° Troncon", "N° Troncon"),
																																																						  new System.Data.Common.DataColumnMapping("No controle", "No controle"),
																																																						  new System.Data.Common.DataColumnMapping("No dernier devis", "No dernier devis"),
																																																						  new System.Data.Common.DataColumnMapping("No dernier devis refus", "No dernier devis refus"),
																																																						  new System.Data.Common.DataColumnMapping("No serie", "No serie"),
																																																						  new System.Data.Common.DataColumnMapping("nombre semaine entre ctl", "nombre semaine entre ctl"),
																																																						  new System.Data.Common.DataColumnMapping("nombre semaine entre inter", "nombre semaine entre inter"),
																																																						  new System.Data.Common.DataColumnMapping("Prix Achat", "Prix Achat"),
																																																						  new System.Data.Common.DataColumnMapping("Prix remplacement", "Prix remplacement"),
																																																						  new System.Data.Common.DataColumnMapping("Site", "Site"),
																																																						  new System.Data.Common.DataColumnMapping("Total casse", "Total casse"),
																																																						  new System.Data.Common.DataColumnMapping("Total controle", "Total controle"),
																																																						  new System.Data.Common.DataColumnMapping("Total general", "Total general"),
																																																						  new System.Data.Common.DataColumnMapping("Total maintenance", "Total maintenance"),
																																																						  new System.Data.Common.DataColumnMapping("Total MO", "Total MO"),
																																																						  new System.Data.Common.DataColumnMapping("Total piece manque", "Total piece manque"),
																																																						  new System.Data.Common.DataColumnMapping("Total transport", "Total transport"),
																																																						  new System.Data.Common.DataColumnMapping("Total usure", "Total usure"),
																																																						  new System.Data.Common.DataColumnMapping("Type machine", "Type machine")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_parc_machine WHERE ([Code machine Opindus] = ?) AND (Affectation = " +
				"? OR ? IS NULL AND Affectation IS NULL) AND ([Code Client] = ? OR ? IS NULL AND " +
				"[Code Client] IS NULL) AND ([Code Mabec] = ? OR ? IS NULL AND [Code Mabec] IS NU" +
				"LL) AND ([Code machine client] = ? OR ? IS NULL AND [Code machine client] IS NUL" +
				"L) AND ([Date dernier controle] = ? OR ? IS NULL AND [Date dernier controle] IS " +
				"NULL) AND ([Date dernier intervention] = ? OR ? IS NULL AND [Date dernier interv" +
				"ention] IS NULL) AND ([Date fin garantie] = ? OR ? IS NULL AND [Date fin garanti" +
				"e] IS NULL) AND ([Date mise en service] = ? OR ? IS NULL AND [Date mise en servi" +
				"ce] IS NULL) AND ([Date reforme] = ? OR ? IS NULL AND [Date reforme] IS NULL) AN" +
				"D ([Date refus] = ? OR ? IS NULL AND [Date refus] IS NULL) AND ([En parc] = ?) A" +
				"ND ([En reparation] = ?) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine]" +
				" IS NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND (" +
				"N_fichier_FVG = ? OR ? IS NULL AND N_fichier_FVG IS NULL) AND ([No controle] = ?" +
				" OR ? IS NULL AND [No controle] IS NULL) AND ([No dernier devis] = ? OR ? IS NUL" +
				"L AND [No dernier devis] IS NULL) AND ([No dernier devis refus] = ? OR ? IS NULL" +
				" AND [No dernier devis refus] IS NULL) AND ([No serie] = ? OR ? IS NULL AND [No " +
				"serie] IS NULL) AND ([N° Troncon] = ?) AND ([Prix Achat] = ? OR ? IS NULL AND [P" +
				"rix Achat] IS NULL) AND ([Prix remplacement] = ? OR ? IS NULL AND [Prix remplace" +
				"ment] IS NULL) AND (Site = ? OR ? IS NULL AND Site IS NULL) AND ([Total MO] = ? " +
				"OR ? IS NULL AND [Total MO] IS NULL) AND ([Total casse] = ? OR ? IS NULL AND [To" +
				"tal casse] IS NULL) AND ([Total controle] = ? OR ? IS NULL AND [Total controle] " +
				"IS NULL) AND ([Total general] = ? OR ? IS NULL AND [Total general] IS NULL) AND " +
				"([Total maintenance] = ? OR ? IS NULL AND [Total maintenance] IS NULL) AND ([Tot" +
				"al piece manque] = ? OR ? IS NULL AND [Total piece manque] IS NULL) AND ([Total " +
				"transport] = ? OR ? IS NULL AND [Total transport] IS NULL) AND ([Total usure] = " +
				"? OR ? IS NULL AND [Total usure] IS NULL) AND ([Type machine] = ? OR ? IS NULL A" +
				"ND [Type machine] IS NULL) AND (creation = ?) AND ([nombre semaine entre ctl] = " +
				"? OR ? IS NULL AND [nombre semaine entre ctl] IS NULL) AND ([nombre semaine entr" +
				"e inter] = ? OR ? IS NULL AND [nombre semaine entre inter] IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Affectation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Affectation1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Mabec1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_client1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_refus1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_En_parc", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "En parc", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "En reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_serie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No serie", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Site", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Site", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_MO", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_MO1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_casse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_casse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_general", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total general", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_general1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total general", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_maintenance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_usure", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_usure1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_machine1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "creation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO T_parc_machine(Affectation, [Code Client], [Code Mabec], [Code machine client], [Code machine Opindus], creation, [Date dernier controle], [Date dernier intervention], [Date fin garantie], [Date mise en service], [Date reforme], [Date refus], [En parc], [En reparation], [Maxi machine], [Memo], [Mini machine], N_fichier_FVG, [N° Troncon], [No controle], [No dernier devis], [No dernier devis refus], [No serie], [nombre semaine entre ctl], [nombre semaine entre inter], [Prix Achat], [Prix remplacement], Site, [Total casse], [Total controle], [Total general], [Total maintenance], [Total MO], [Total piece manque], [Total transport], [Total usure], [Type machine]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Affectation", System.Data.OleDb.OleDbType.Integer, 0, "Affectation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Boolean, 2, "creation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier intervention"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, "Date fin garantie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, "Date mise en service"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Date reforme"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, "Date refus"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("En_parc", System.Data.OleDb.OleDbType.Boolean, 2, "En parc"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, "En reparation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, "N_fichier_FVG"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_controle", System.Data.OleDb.OleDbType.Integer, 0, "No controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis refus"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, "No serie"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre ctl"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre inter"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, "Prix remplacement"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.Integer, 0, "Site"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_casse", System.Data.OleDb.OleDbType.Double, 0, "Total casse"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_controle", System.Data.OleDb.OleDbType.Double, 0, "Total controle"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_general", System.Data.OleDb.OleDbType.Double, 0, "Total general"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, "Total maintenance"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_MO", System.Data.OleDb.OleDbType.Double, 0, "Total MO"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, "Total piece manque"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_transport", System.Data.OleDb.OleDbType.Double, 0, "Total transport"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_usure", System.Data.OleDb.OleDbType.Double, 0, "Total usure"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, "Type machine"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT Affectation, [Code Client], [Code Mabec], [Code machine client], [Code machine Opindus], creation, [Date dernier controle], [Date dernier intervention], [Date fin garantie], [Date mise en service], [Date reforme], [Date refus], [En parc], [En reparation], [Maxi machine], [Memo], [Mini machine], N_fichier_FVG, [N° Troncon], [No controle], [No dernier devis], [No dernier devis refus], [No serie], [nombre semaine entre ctl], [nombre semaine entre inter], [Prix Achat], [Prix remplacement], Site, [Total casse], [Total controle], [Total general], [Total maintenance], [Total MO], [Total piece manque], [Total transport], [Total usure], [Type machine] FROM T_parc_machine";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE T_parc_machine SET Affectation = ?, [Code Client] = ?, [Code Mabec] = ?, [" +
				"Code machine client] = ?, [Code machine Opindus] = ?, creation = ?, [Date dernie" +
				"r controle] = ?, [Date dernier intervention] = ?, [Date fin garantie] = ?, [Date" +
				" mise en service] = ?, [Date reforme] = ?, [Date refus] = ?, [En parc] = ?, [En " +
				"reparation] = ?, [Maxi machine] = ?, [Memo] = ?, [Mini machine] = ?, N_fichier_F" +
				"VG = ?, [N° Troncon] = ?, [No controle] = ?, [No dernier devis] = ?, [No dernier" +
				" devis refus] = ?, [No serie] = ?, [nombre semaine entre ctl] = ?, [nombre semai" +
				"ne entre inter] = ?, [Prix Achat] = ?, [Prix remplacement] = ?, Site = ?, [Total" +
				" casse] = ?, [Total controle] = ?, [Total general] = ?, [Total maintenance] = ?," +
				" [Total MO] = ?, [Total piece manque] = ?, [Total transport] = ?, [Total usure] " +
				"= ?, [Type machine] = ? WHERE ([Code machine Opindus] = ?) AND (Affectation = ? " +
				"OR ? IS NULL AND Affectation IS NULL) AND ([Code Client] = ? OR ? IS NULL AND [C" +
				"ode Client] IS NULL) AND ([Code Mabec] = ? OR ? IS NULL AND [Code Mabec] IS NULL" +
				") AND ([Code machine client] = ? OR ? IS NULL AND [Code machine client] IS NULL)" +
				" AND ([Date dernier controle] = ? OR ? IS NULL AND [Date dernier controle] IS NU" +
				"LL) AND ([Date dernier intervention] = ? OR ? IS NULL AND [Date dernier interven" +
				"tion] IS NULL) AND ([Date fin garantie] = ? OR ? IS NULL AND [Date fin garantie]" +
				" IS NULL) AND ([Date mise en service] = ? OR ? IS NULL AND [Date mise en service" +
				"] IS NULL) AND ([Date reforme] = ? OR ? IS NULL AND [Date reforme] IS NULL) AND " +
				"([Date refus] = ? OR ? IS NULL AND [Date refus] IS NULL) AND ([En parc] = ?) AND" +
				" ([En reparation] = ?) AND ([Maxi machine] = ? OR ? IS NULL AND [Maxi machine] I" +
				"S NULL) AND ([Mini machine] = ? OR ? IS NULL AND [Mini machine] IS NULL) AND (N_" +
				"fichier_FVG = ? OR ? IS NULL AND N_fichier_FVG IS NULL) AND ([No controle] = ? O" +
				"R ? IS NULL AND [No controle] IS NULL) AND ([No dernier devis] = ? OR ? IS NULL " +
				"AND [No dernier devis] IS NULL) AND ([No dernier devis refus] = ? OR ? IS NULL A" +
				"ND [No dernier devis refus] IS NULL) AND ([No serie] = ? OR ? IS NULL AND [No se" +
				"rie] IS NULL) AND ([N° Troncon] = ?) AND ([Prix Achat] = ? OR ? IS NULL AND [Pri" +
				"x Achat] IS NULL) AND ([Prix remplacement] = ? OR ? IS NULL AND [Prix remplaceme" +
				"nt] IS NULL) AND (Site = ? OR ? IS NULL AND Site IS NULL) AND ([Total MO] = ? OR" +
				" ? IS NULL AND [Total MO] IS NULL) AND ([Total casse] = ? OR ? IS NULL AND [Tota" +
				"l casse] IS NULL) AND ([Total controle] = ? OR ? IS NULL AND [Total controle] IS" +
				" NULL) AND ([Total general] = ? OR ? IS NULL AND [Total general] IS NULL) AND ([" +
				"Total maintenance] = ? OR ? IS NULL AND [Total maintenance] IS NULL) AND ([Total" +
				" piece manque] = ? OR ? IS NULL AND [Total piece manque] IS NULL) AND ([Total tr" +
				"ansport] = ? OR ? IS NULL AND [Total transport] IS NULL) AND ([Total usure] = ? " +
				"OR ? IS NULL AND [Total usure] IS NULL) AND ([Type machine] = ? OR ? IS NULL AND" +
				" [Type machine] IS NULL) AND (creation = ?) AND ([nombre semaine entre ctl] = ? " +
				"OR ? IS NULL AND [nombre semaine entre ctl] IS NULL) AND ([nombre semaine entre " +
				"inter] = ? OR ? IS NULL AND [nombre semaine entre inter] IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Affectation", System.Data.OleDb.OleDbType.Integer, 0, "Affectation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Boolean, 2, "creation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier intervention"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, "Date fin garantie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, "Date mise en service"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Date reforme"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, "Date refus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("En_parc", System.Data.OleDb.OleDbType.Boolean, 2, "En parc"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, "En reparation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, "N_fichier_FVG"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_controle", System.Data.OleDb.OleDbType.Integer, 0, "No controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis refus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, "No serie"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre ctl"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre inter"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, "Prix remplacement"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.Integer, 0, "Site"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_casse", System.Data.OleDb.OleDbType.Double, 0, "Total casse"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_controle", System.Data.OleDb.OleDbType.Double, 0, "Total controle"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_general", System.Data.OleDb.OleDbType.Double, 0, "Total general"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, "Total maintenance"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_MO", System.Data.OleDb.OleDbType.Double, 0, "Total MO"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, "Total piece manque"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_transport", System.Data.OleDb.OleDbType.Double, 0, "Total transport"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Total_usure", System.Data.OleDb.OleDbType.Double, 0, "Total usure"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, "Type machine"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Affectation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Affectation1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_Mabec1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Code_machine_client1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Date_refus1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_En_parc", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "En parc", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "En reparation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_No_serie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "No serie", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_Achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Site", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Site", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_MO", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_MO1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_casse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_casse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_general", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total general", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_general1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total general", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_maintenance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_usure", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Total_usure1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Type_machine1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "creation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null));
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
			this.tabControlEX1.Controls.Add(this.tabPageEX2);
			this.tabControlEX1.Controls.Add(this.tabPageEX3);
			this.tabControlEX1.Controls.Add(this.tabPageEX4);
			this.tabControlEX1.Controls.Add(this.tabPageEX5);
			this.tabControlEX1.Controls.Add(this.tabPageEX6);
			this.tabControlEX1.Location = new System.Drawing.Point(8, 120);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(976, 416);
			this.tabControlEX1.TabColor = System.Drawing.Color.DarkGray;
			this.tabControlEX1.TabIndex = 33;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.Controls.Add(this.textBox9);
			this.tabPageEX1.Controls.Add(this.listView1);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(968, 387);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Fiche de vie";
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.Controls.Add(this.textBox10);
			this.tabPageEX2.Controls.Add(this.listView2);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(968, 387);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Opindus";
			// 
			// tabPageEX3
			// 
			this.tabPageEX3.Controls.Add(this.textBox11);
			this.tabPageEX3.Controls.Add(this.listView3);
			this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX3.Name = "tabPageEX3";
			this.tabPageEX3.Size = new System.Drawing.Size(968, 387);
			this.tabPageEX3.TabIndex = 2;
			this.tabPageEX3.Text = "Libre";
			// 
			// tabPageEX4
			// 
			this.tabPageEX4.Controls.Add(this.listView4);
			this.tabPageEX4.Controls.Add(this.textBox12);
			this.tabPageEX4.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX4.Name = "tabPageEX4";
			this.tabPageEX4.Size = new System.Drawing.Size(968, 387);
			this.tabPageEX4.TabIndex = 3;
			this.tabPageEX4.Text = "Affectations";
			// 
			// tabPageEX5
			// 
			this.tabPageEX5.Controls.Add(this.listView5);
			this.tabPageEX5.Controls.Add(this.textBox13);
			this.tabPageEX5.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX5.Name = "tabPageEX5";
			this.tabPageEX5.Size = new System.Drawing.Size(968, 387);
			this.tabPageEX5.TabIndex = 4;
			this.tabPageEX5.Text = "Contrôles";
			// 
			// tabPageEX6
			// 
			this.tabPageEX6.Controls.Add(this.textBox14);
			this.tabPageEX6.Controls.Add(this.listView6);
			this.tabPageEX6.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX6.Name = "tabPageEX6";
			this.tabPageEX6.Size = new System.Drawing.Size(968, 387);
			this.tabPageEX6.TabIndex = 5;
			this.tabPageEX6.Text = "Commentaires";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(936, 544);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 48);
			this.button3.TabIndex = 34;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.White;
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button19.ForeColor = System.Drawing.Color.Black;
			this.button19.Location = new System.Drawing.Point(16, 552);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(136, 29);
			this.button19.TabIndex = 35;
			this.button19.TabStop = false;
			this.button19.Text = "Export Excel";
			// 
			// FicheDeVie
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(994, 600);
			this.ControlBox = false;
			this.Controls.Add(this.button19);
			this.Controls.Add(this.tabControlEX1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FicheDeVie";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fiche de vie";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.tabControlEX1.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.tabPageEX2.ResumeLayout(false);
			this.tabPageEX3.ResumeLayout(false);
			this.tabPageEX4.ResumeLayout(false);
			this.tabPageEX5.ResumeLayout(false);
			this.tabPageEX6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void InitializeData()
		{
			DataSet MyData = new DataSet();
			OleDbDataAdapter DataAD = new OleDbDataAdapter();
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			Comm.CommandText="SELECT T_parc_machine.[Type machine],T_parc_machine.[Code machine opindus], T_parc_machine.[No serie], T_parc_machine.[Code Mabec], T_fournisseurs.Nom, T_famille_machine.Designation, T_parc_machine.[Date mise en service], T_parc_machine.[Date reforme], T_parc_machine.Comment, T_affectation.Affectation, T_site.Site, T_parc_machine.creation FROM (T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN T_type_machine ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN (T_site INNER JOIN (T_affectation INNER JOIN T_parc_machine ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_parc_machine.[Code machine Opindus])='"+Machine+"')) GROUP BY T_parc_machine.[Code machine opindus],T_parc_machine.[Type machine], T_parc_machine.[No serie], T_parc_machine.[Code Mabec], T_fournisseurs.Nom, T_famille_machine.Designation, T_parc_machine.[Date mise en service], T_parc_machine.[Date reforme], T_parc_machine.Comment, T_affectation.Affectation, T_site.Site, T_parc_machine.creation"; 
			oleDbDataAdapter1.SelectCommand=Comm;
			try
			{
				oleDbDataAdapter1.Fill(MyData,"t_parc_machine");
				if(MyData.Tables["t_parc_machine"].Rows.Count>0)
				{
					textBox1.Text=MyData.Tables["t_parc_machine"].Rows[0]["type machine"].ToString();
					textBox2.Text=MyData.Tables["t_parc_machine"].Rows[0]["Code machine opindus"].ToString();
					textBox3.Text=MyData.Tables["t_parc_machine"].Rows[0]["no serie"].ToString();
					textBox4.Text=MyData.Tables["t_parc_machine"].Rows[0]["Code mabec"].ToString();
					textBox5.Text=MyData.Tables["t_parc_machine"].Rows[0]["Nom"].ToString();
					textBox6.Text=MyData.Tables["t_parc_machine"].Rows[0]["Designation"].ToString();
					if(MyData.Tables["t_parc_machine"].Rows[0]["Date mise en service"].ToString().Length>0)
						textBox7.Text=System.Convert.ToDateTime(MyData.Tables["t_parc_machine"].Rows[0]["Date mise en service"].ToString()).ToShortDateString();
					if(MyData.Tables["t_parc_machine"].Rows[0]["Date reforme"].ToString().Length>0)
						textBox8.Text=System.Convert.ToDateTime(MyData.Tables["t_parc_machine"].Rows[0]["Date reforme"].ToString()).ToShortDateString();
					Decimal CumulRep=0;
					if(MyData.Tables["t_parc_machine"].Rows[0]["Creation"].ToString().Equals("True"))
					{
						listView1.Items.Add(MyData.Tables["t_parc_machine"].Rows[0]["Date reparation"].ToString());
						listView1.Items[listView1.Items.Count-1].SubItems.Add("Creation");
					}
					Comm.CommandText="SELECT T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Total devis], T_devis_entete.[Type devis], T_site.Site, T_affectation.Affectation FROM T_affectation INNER JOIN (T_site INNER JOIN (T_parc_machine INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_site.ID = T_parc_machine.Site) ON (T_site.ID = T_affectation.ID) AND (T_affectation.ID = T_parc_machine.Affectation) WHERE (((T_parc_machine.[Code machine Opindus])='"+Machine+"')) GROUP BY T_devis_entete.[N° Devis], T_devis_entete.[Date Decision], T_devis_entete.[Total devis], T_devis_entete.[Type devis], T_site.Site, T_affectation.Affectation";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(MyData,"Devis");
					if(MyData.Tables["Devis"].Rows.Count>0)
					{
						foreach(DataRow row in MyData.Tables["Devis"].Rows)
						{
							listView1.Items.Add(row["date decision"].ToString().Remove(10,9));
							if(row["type devis"].ToString().Equals("1"))
								listView1.Items[listView1.Items.Count-1].SubItems.Add("Rep. "+row["n° devis"].ToString());
							else if(row["type devis"].ToString().Equals("2"))
								listView1.Items[listView1.Items.Count-1].SubItems.Add("Gar. "+row["n° devis"].ToString());
							else
								listView1.Items[listView1.Items.Count-1].SubItems.Add("Ctrl. "+row["n° devis"].ToString());
							listView1.Items[listView1.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row["total devis"].ToString()).ToString("c"));
							if(row["type devis"].ToString().Equals("1"))
								CumulRep+=System.Convert.ToDecimal(row["Total devis"].ToString());
							listView1.Items[listView1.Items.Count-1].SubItems.Add(CumulRep .ToString("c"));
							listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Affectation"].ToString());
							listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Site"].ToString());
							//listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Comment"].ToString());

						}
					}
					CumulRep=0;
					Decimal CumulCtrl=0;
					Decimal CumulTotal=0;
					int TotalRep=0;
					int TotalCtrl=0;
					
					Comm.CommandText="select * from t_machines_histo where [code machine opindus]='"+textBox2.Text+"'";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(MyData,"t_machines_histo");
					if(MyData.Tables["t_machines_histo"].Rows.Count>0)
					{
						if(MyData.Tables["t_machines_histo"].Rows[0]["typeinterv"].ToString().Equals("3"))
						{
							listView1.Items.Insert(0,MyData.Tables["t_machines_histo"].Rows[0]["Date"].ToString());
							listView1.Items[0].SubItems.Add("Creation");
						}
					}
					
					if(MyData.Tables["Devis"].Rows.Count>0)
					{
						foreach(DataRow row in MyData.Tables["Devis"].Rows)
						{
							listView2.Items.Add(row["date decision"].ToString().Remove(10,9));
							if(row["type devis"].ToString().Equals("1"))
							{
								listView2.Items[listView2.Items.Count-1].SubItems.Add("Rep. "+row["n° devis"].ToString());
								TotalRep+=1;
							}
							else if(row["type devis"].ToString().Equals("2"))
							{
								listView2.Items[listView2.Items.Count-1].SubItems.Add("Gar. "+row["n° devis"].ToString());
								TotalRep+=1;
							}
							else
							{
								listView2.Items[listView2.Items.Count-1].SubItems.Add("Ctrl. "+row["n° devis"].ToString());
								TotalCtrl+=1;
							}
							listView2.Items[listView2.Items.Count-1].SubItems.Add(System.Convert.ToDecimal(row["total devis"].ToString()).ToString("c"));
							listView2.Items[listView2.Items.Count-1].SubItems.Add(" ");
							if(row["type devis"].ToString().Equals("1"))
								CumulRep+=System.Convert.ToDecimal(row["Total devis"].ToString());
							else if(row["type devis"].ToString().Equals("3"))
								CumulCtrl+=System.Convert.ToDecimal(row["Total devis"].ToString());
							listView2.Items[listView2.Items.Count-1].SubItems.Add(CumulRep.ToString("c"));
							listView2.Items[listView2.Items.Count-1].SubItems.Add(TotalRep.ToString());
							listView2.Items[listView2.Items.Count-1].SubItems.Add(CumulCtrl.ToString("c"));
							CumulTotal=CumulCtrl+CumulRep;
							listView2.Items[listView2.Items.Count-1].SubItems[3].Text=CumulTotal.ToString("c");
							TotalRep+=1;
							listView2.Items[listView2.Items.Count-1].SubItems.Add(TotalCtrl.ToString());
							listView2.Items[listView2.Items.Count-1].SubItems.Add(row["Affectation"].ToString());
							listView2.Items[listView2.Items.Count-1].SubItems.Add(row["Site"].ToString());
							//listView2.Items[listView2.Items.Count-1].SubItems.Add(row["comment"].ToString());

						}
					}
				}
				else
				{
					Comm.CommandText="SELECT T_parc_machine.[Code machine Opindus], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_famille_machine.Designation, T_parc_machine.[No serie], T_parc_machine.[Code Mabec], T_parc_machine.[Date mise en service], T_parc_machine.[Date reforme], T_fournisseurs.Nom, T_famille_machine.Designation FROM T_famille_machine INNER JOIN ((T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_parc_machine.[Code machine Opindus])='"+Machine+"'))";
					try
					{
						oleDbDataAdapter1.Fill(MyData,"t_parc_machine");
						if(MyData.Tables["t_parc_machine"].Rows.Count>0)
						{
							textBox1.Text=MyData.Tables["t_parc_machine"].Rows[0]["type machine"].ToString();
							textBox2.Text=MyData.Tables["t_parc_machine"].Rows[0]["Code machine opindus"].ToString();
							textBox3.Text=MyData.Tables["t_parc_machine"].Rows[0]["no serie"].ToString();
							textBox4.Text=MyData.Tables["t_parc_machine"].Rows[0]["Code mabec"].ToString();
							textBox5.Text=MyData.Tables["t_parc_machine"].Rows[0]["Nom"].ToString();
							textBox6.Text=MyData.Tables["t_parc_machine"].Rows[0]["Designation"].ToString();
							textBox7.Text=MyData.Tables["t_parc_machine"].Rows[0]["Date mise en service"].ToString();
							textBox8.Text=MyData.Tables["t_parc_machine"].Rows[0]["Date reforme"].ToString();
						}
						
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
				}
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
