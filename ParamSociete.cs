using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Opindus
{
	/// <summary>
	/// Description résumée de ParamSociete.
	/// </summary>
	public class ParamSociete : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Button button1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private int Agence;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.TextBox textBox18;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ParamSociete(int Agence)
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

			oleDbDataAdapter1.Fill(dataSet11);
			textBox1.Text=dataSet11.Tables["parametres"].Rows[0]["Societe"].ToString();
			textBox2.Text=dataSet11.Tables["parametres"].Rows[0]["f_adresse1"].ToString();
			textBox3.Text=dataSet11.Tables["parametres"].Rows[0]["f_adresse2"].ToString();
			textBox4.Text=dataSet11.Tables["parametres"].Rows[0]["f_cp"].ToString();
			textBox5.Text=dataSet11.Tables["parametres"].Rows[0]["f_ville"].ToString();
			textBox6.Text=dataSet11.Tables["parametres"].Rows[0]["f_tel"].ToString();
			textBox7.Text=dataSet11.Tables["parametres"].Rows[0]["f_fax"].ToString();
			textBox8.Text=dataSet11.Tables["parametres"].Rows[0]["e_mail"].ToString();
			textBox9.Text=dataSet11.Tables["parametres"].Rows[0]["l_adresse1"].ToString();
			textBox10.Text=dataSet11.Tables["parametres"].Rows[0]["l_adresse2"].ToString();
			textBox11.Text=dataSet11.Tables["parametres"].Rows[0]["l_cp"].ToString();
			textBox12.Text=dataSet11.Tables["parametres"].Rows[0]["l_ville"].ToString();
			textBox13.Text=dataSet11.Tables["parametres"].Rows[0]["l_tel"].ToString();
			textBox14.Text=dataSet11.Tables["parametres"].Rows[0]["l_fax"].ToString();
			textBox15.Text=dataSet11.Tables["parametres"].Rows[0]["e_mail"].ToString();
			textBox16.Text=dataSet11.Tables["parametres"].Rows[0]["signature"].ToString();
			textBox17.Text=dataSet11.Tables["parametres"].Rows[0]["message_cde"].ToString();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ParamSociete));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet11 = new Opindus.DataSet1();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(104, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(304, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(104, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Facturation";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(104, 72);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(304, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(104, 96);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(304, 20);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(104, 120);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(64, 20);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Location = new System.Drawing.Point(176, 120);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(232, 20);
			this.textBox5.TabIndex = 5;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(104, 144);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(232, 20);
			this.textBox6.TabIndex = 6;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Location = new System.Drawing.Point(104, 168);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(232, 20);
			this.textBox7.TabIndex = 7;
			this.textBox7.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(104, 192);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(232, 20);
			this.textBox8.TabIndex = 8;
			this.textBox8.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Société";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Adresse";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Complément";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 12;
			this.label5.Text = "CP / Ville";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Téléphone";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 16);
			this.label7.TabIndex = 14;
			this.label7.Text = "Fax";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(8, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 16);
			this.label8.TabIndex = 15;
			this.label8.Text = "E-Mail";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 376);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 16);
			this.label9.TabIndex = 29;
			this.label9.Text = "E-Mail";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(8, 352);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 16);
			this.label10.TabIndex = 28;
			this.label10.Text = "Fax";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(8, 328);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 16);
			this.label11.TabIndex = 27;
			this.label11.Text = "Téléphone";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(8, 304);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 16);
			this.label12.TabIndex = 26;
			this.label12.Text = "CP / Ville";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(8, 280);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 16);
			this.label13.TabIndex = 25;
			this.label13.Text = "Complément";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(8, 256);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 16);
			this.label14.TabIndex = 24;
			this.label14.Text = "Adresse";
			// 
			// textBox9
			// 
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Location = new System.Drawing.Point(104, 256);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(304, 20);
			this.textBox9.TabIndex = 23;
			this.textBox9.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Location = new System.Drawing.Point(104, 280);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(304, 20);
			this.textBox10.TabIndex = 22;
			this.textBox10.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Location = new System.Drawing.Point(104, 304);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(64, 20);
			this.textBox11.TabIndex = 21;
			this.textBox11.Text = "";
			// 
			// textBox12
			// 
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Location = new System.Drawing.Point(176, 304);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(232, 20);
			this.textBox12.TabIndex = 20;
			this.textBox12.Text = "";
			// 
			// textBox13
			// 
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.Location = new System.Drawing.Point(104, 328);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(232, 20);
			this.textBox13.TabIndex = 19;
			this.textBox13.Text = "";
			// 
			// textBox14
			// 
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.Location = new System.Drawing.Point(104, 352);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(304, 20);
			this.textBox14.TabIndex = 18;
			this.textBox14.Text = "";
			// 
			// textBox15
			// 
			this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox15.Location = new System.Drawing.Point(104, 376);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(304, 20);
			this.textBox15.TabIndex = 17;
			this.textBox15.Text = "";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(104, 232);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 16);
			this.label15.TabIndex = 16;
			this.label15.Text = "Livraison";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(8, 416);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 16);
			this.label16.TabIndex = 30;
			this.label16.Text = "Signature";
			// 
			// textBox16
			// 
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox16.Location = new System.Drawing.Point(104, 416);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(304, 20);
			this.textBox16.TabIndex = 31;
			this.textBox16.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(8, 448);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 16);
			this.label17.TabIndex = 32;
			this.label17.Text = "Message Cde";
			// 
			// textBox17
			// 
			this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox17.Location = new System.Drawing.Point(104, 448);
			this.textBox17.Multiline = true;
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(304, 72);
			this.textBox17.TabIndex = 33;
			this.textBox17.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Blue;
			this.button1.Location = new System.Drawing.Point(16, 544);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 34;
			this.button1.Text = "Enregistrer";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Parametres", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("e_mail", "e_mail"),
																																																					  new System.Data.Common.DataColumnMapping("F_adresse1", "F_adresse1"),
																																																					  new System.Data.Common.DataColumnMapping("F_adresse2", "F_adresse2"),
																																																					  new System.Data.Common.DataColumnMapping("F_cp", "F_cp"),
																																																					  new System.Data.Common.DataColumnMapping("F_fax", "F_fax"),
																																																					  new System.Data.Common.DataColumnMapping("F_tel", "F_tel"),
																																																					  new System.Data.Common.DataColumnMapping("F_ville", "F_ville"),
																																																					  new System.Data.Common.DataColumnMapping("L_adresse1", "L_adresse1"),
																																																					  new System.Data.Common.DataColumnMapping("L_adresse2", "L_adresse2"),
																																																					  new System.Data.Common.DataColumnMapping("L_cp", "L_cp"),
																																																					  new System.Data.Common.DataColumnMapping("L_fax", "L_fax"),
																																																					  new System.Data.Common.DataColumnMapping("L_tel", "L_tel"),
																																																					  new System.Data.Common.DataColumnMapping("L_ville", "L_ville"),
																																																					  new System.Data.Common.DataColumnMapping("Message_cde", "Message_cde"),
																																																					  new System.Data.Common.DataColumnMapping("signature", "signature"),
																																																					  new System.Data.Common.DataColumnMapping("Societe", "Societe")})});
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Parametres(e_mail, F_adresse1, F_adresse2, F_cp, F_fax, F_tel, F_vill" +
				"e, L_adresse1, L_adresse2, L_cp, L_fax, L_tel, L_ville, Message_cde, signature, " +
				"Societe) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("e_mail", System.Data.OleDb.OleDbType.VarWChar, 50, "e_mail"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_adresse1", System.Data.OleDb.OleDbType.VarWChar, 50, "F_adresse1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_adresse2", System.Data.OleDb.OleDbType.VarWChar, 50, "F_adresse2"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_cp", System.Data.OleDb.OleDbType.VarWChar, 50, "F_cp"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_fax", System.Data.OleDb.OleDbType.VarWChar, 50, "F_fax"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_tel", System.Data.OleDb.OleDbType.VarWChar, 50, "F_tel"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("F_ville", System.Data.OleDb.OleDbType.VarWChar, 50, "F_ville"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_adresse1", System.Data.OleDb.OleDbType.VarWChar, 50, "L_adresse1"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_adresse2", System.Data.OleDb.OleDbType.VarWChar, 50, "L_adresse2"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_cp", System.Data.OleDb.OleDbType.VarWChar, 50, "L_cp"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_fax", System.Data.OleDb.OleDbType.VarWChar, 50, "L_fax"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_tel", System.Data.OleDb.OleDbType.VarWChar, 50, "L_tel"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("L_ville", System.Data.OleDb.OleDbType.VarWChar, 50, "L_ville"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Message_cde", System.Data.OleDb.OleDbType.VarWChar, 0, "Message_cde"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("signature", System.Data.OleDb.OleDbType.VarWChar, 50, "signature"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Societe", System.Data.OleDb.OleDbType.VarWChar, 50, "Societe"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT e_mail, F_adresse1, F_adresse2, F_cp, F_fax, F_tel, F_ville, L_adresse1, L" +
				"_adresse2, L_cp, L_fax, L_tel, L_ville, Message_cde, signature, Societe FROM Par" +
				"ametres";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
			// 
			// textBox18
			// 
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox18.Location = new System.Drawing.Point(304, 40);
			this.textBox18.Name = "textBox18";
			this.textBox18.TabIndex = 36;
			this.textBox18.Text = "";
			this.textBox18.Visible = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(360, 528);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 37;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// ParamSociete
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(424, 584);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox18);
			this.Controls.Add(this.textBox17);
			this.Controls.Add(this.textBox16);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.textBox12);
			this.Controls.Add(this.textBox13);
			this.Controls.Add(this.textBox14);
			this.Controls.Add(this.textBox15);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ParamSociete";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Paramêtre société";
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(textBox3.TextLength.Equals(0))
				textBox3.Text="?";
			if(textBox10.TextLength.Equals(0))
				textBox10.Text="?";
			if(textBox8.TextLength.Equals(0))
				textBox8.Text="?";
			if(textBox15.TextLength.Equals(0))
				textBox15.Text="?";
			OleDbCommand Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			dataSet11.Tables["parametres"].Clear();
			oleDbDataAdapter1.Fill(dataSet11);
			if(dataSet11.Tables["parametres"].Rows.Count.Equals(0))
			{
				oleDbConnection1.Open();
				Comm.CommandText="insert into parametres (Societe,f_adresse1,f_adresse2,f_cp,f_ville,f_tel,f_fax,e_mail,l_adresse1,l_adresse2,l_cp,l_ville,l_tel,l_fax,e_mail,signature,message_cde) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox10.Text+"','"+textBox11.Text+"','"+textBox12.Text+"','"+textBox13.Text+"','"+textBox14.Text+"','"+textBox15.Text+"','"+textBox16.Text+"','"+textBox17.Text+"')";
				Comm.ExecuteNonQuery();
				oleDbConnection1.Close();
			}
			else
			{
				oleDbConnection1.Open();
				Comm.CommandText="update parametres set Societe='"+textBox1.Text+"'";
				if(textBox2.TextLength>0)
					Comm.CommandText+=",f_adresse1='"+textBox2.Text+"'";
				if(textBox3.TextLength>0)
					Comm.CommandText+=",f_adresse2='"+textBox3.Text+"'";
				if(textBox4.TextLength>0)
					Comm.CommandText+=",f_cp='"+textBox4.Text+"'";
				if(textBox5.TextLength>0)
					Comm.CommandText+=",f_ville='"+textBox5.Text+"'";
				if(textBox6.TextLength>0)
					Comm.CommandText+=",f_tel='"+textBox6.Text+"'";
				if(textBox7.TextLength>0)
					Comm.CommandText+=",f_fax='"+textBox7.Text+"'";
				if(textBox9.TextLength>0)
					Comm.CommandText+=",l_adresse1='"+textBox9.Text+"'";
				if(textBox10.TextLength>0)
					Comm.CommandText+=",l_adresse2='"+textBox10.Text+"'";
				if(textBox11.TextLength>0)
					Comm.CommandText+=",l_cp='"+textBox11.Text+"'";
				if(textBox12.TextLength>0)
					Comm.CommandText+=",l_ville='"+textBox12.Text+"'";
				if(textBox13.TextLength>0)
					Comm.CommandText+=",l_tel='"+textBox13.Text+"'";
				if(textBox14.TextLength>0)
					Comm.CommandText+=",l_fax='"+textBox14.Text+"'";
				if(textBox15.TextLength>0)
					Comm.CommandText+=",e_mail='"+textBox15.Text+"'";
				if(textBox16.TextLength>0)
					Comm.CommandText+=",signature='"+textBox16.Text+"'";
				if(textBox17.TextLength>0)
					Comm.CommandText+=",message_cde='"+textBox17.Text+"'";
				try
				{
					Comm.ExecuteNonQuery();
					MessageBox.Show("Mise à jour terminée","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
