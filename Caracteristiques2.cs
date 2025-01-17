using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Opindus
{
	/// <summary>
	/// Description résumée de Caracteristiques2.
	/// </summary>
	public class Caracteristiques2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private string NumMachine;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Opindus.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Windows.Forms.Button button4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Caracteristiques2(int Agence, string Machine)
		{
			NumMachine=Machine;
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
			oleDbDataAdapter1.SelectCommand.CommandText="SELECT T_parc_machine.[Code machine Opindus], T_parc_machine.[Type machine] FROM T_type_machine INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_parc_machine.[Code machine Opindus])='"+NumMachine+"'))";
			oleDbDataAdapter1.Fill(dataSet11);
			textBox1.Text=dataSet11.Tables["t_parc_machine"].Rows[0]["code machine opindus"].ToString();
			textBox2.Text=dataSet11.Tables["t_parc_machine"].Rows[0]["Type machine"].ToString();
			oleDbSelectCommand2.CommandText="SELECT T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse FROM T_type_machine WHERE (((T_type_machine.Code)='"+textBox1.Text+"')) GROUP BY T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse"; 
			try
			{
				oleDbDataAdapter2.Fill(dataSet11);
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			if(dataSet11.Tables["t_type_machine"].Rows.Count>0)
			{
				textBox3.Text=dataSet11.Tables["t_type_machine"].Rows[0]["mini machine"].ToString();
				textBox4.Text=dataSet11.Tables["t_type_machine"].Rows[0]["maxi machine"].ToString();
				textBox5.Text=dataSet11.Tables["t_type_machine"].Rows[0]["vitesse"].ToString();
			}
			else
			{
				oleDbSelectCommand3.CommandText="SELECT T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM T_type_machine_Vis WHERE (((T_type_machine_Vis.Code)='"+textBox2.Text+"')) GROUP BY T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse";
				try
				{
					oleDbDataAdapter3.Fill(dataSet11);
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				if(dataSet11.Tables["t_type_machine_vis"].Rows.Count>0)
				{
					textBox3.Text=dataSet11.Tables["t_type_machine_vis"].Rows[0]["C_mini"].ToString();
					textBox4.Text=dataSet11.Tables["t_type_machine_vis"].Rows[0]["C_maxi"].ToString();
					textBox5.Text=dataSet11.Tables["t_type_machine_vis"].Rows[0]["Vitesse"].ToString();
				}
			}
			OleDbCommand Comm = new OleDbCommand();
			OleDbDataAdapter DataAD = new OleDbDataAdapter();
			Comm.CommandText="select * from t_controles_cam where [code machine opindus]='"+textBox1.Text+"'";
			Comm.Connection=oleDbConnection1;
			DataAD.SelectCommand=Comm;
			DataAD.Fill(dataSet11,"t_controles_cam");
			if(dataSet11.Tables["t_controles_cam"].Rows.Count>0)
			{
				button3.Visible=true;
				button3.Enabled=true;
			}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caracteristiques2));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new Opindus.DataSet1();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(552, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 70);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(24, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 117);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vitesse (t/mn)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Couple Maxi (Nm)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Couple Mini (Nm)";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(444, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(84, 26);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(252, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(84, 26);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(60, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(84, 26);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(24, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(300, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 33);
            this.button4.TabIndex = 2;
            this.button4.Text = "Graphiques";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(300, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "Liste";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(84, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Création";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type machine";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code machine Opindus";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(324, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(96, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contrôles CAM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
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
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Affectation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Affectation1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Mabec1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_client1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_refus1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_En_parc", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "En parc", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "En reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No serie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_serie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No serie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Site", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Site", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_MO", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_MO1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_casse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_casse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_general", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total general", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_general1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total general", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_maintenance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_usure", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_usure1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_machine1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Affectation", System.Data.OleDb.OleDbType.Integer, 0, "Affectation"),
            new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"),
            new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"),
            new System.Data.OleDb.OleDbParameter("Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine client"),
            new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"),
            new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Boolean, 2, "creation"),
            new System.Data.OleDb.OleDbParameter("Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier controle"),
            new System.Data.OleDb.OleDbParameter("Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier intervention"),
            new System.Data.OleDb.OleDbParameter("Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, "Date fin garantie"),
            new System.Data.OleDb.OleDbParameter("Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, "Date mise en service"),
            new System.Data.OleDb.OleDbParameter("Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Date reforme"),
            new System.Data.OleDb.OleDbParameter("Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, "Date refus"),
            new System.Data.OleDb.OleDbParameter("En_parc", System.Data.OleDb.OleDbType.Boolean, 2, "En parc"),
            new System.Data.OleDb.OleDbParameter("En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, "En reparation"),
            new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"),
            new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"),
            new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"),
            new System.Data.OleDb.OleDbParameter("N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, "N_fichier_FVG"),
            new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"),
            new System.Data.OleDb.OleDbParameter("No_controle", System.Data.OleDb.OleDbType.Integer, 0, "No controle"),
            new System.Data.OleDb.OleDbParameter("No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis"),
            new System.Data.OleDb.OleDbParameter("No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis refus"),
            new System.Data.OleDb.OleDbParameter("No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, "No serie"),
            new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre ctl"),
            new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre inter"),
            new System.Data.OleDb.OleDbParameter("Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat"),
            new System.Data.OleDb.OleDbParameter("Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, "Prix remplacement"),
            new System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.Integer, 0, "Site"),
            new System.Data.OleDb.OleDbParameter("Total_casse", System.Data.OleDb.OleDbType.Double, 0, "Total casse"),
            new System.Data.OleDb.OleDbParameter("Total_controle", System.Data.OleDb.OleDbType.Double, 0, "Total controle"),
            new System.Data.OleDb.OleDbParameter("Total_general", System.Data.OleDb.OleDbType.Double, 0, "Total general"),
            new System.Data.OleDb.OleDbParameter("Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, "Total maintenance"),
            new System.Data.OleDb.OleDbParameter("Total_MO", System.Data.OleDb.OleDbType.Double, 0, "Total MO"),
            new System.Data.OleDb.OleDbParameter("Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, "Total piece manque"),
            new System.Data.OleDb.OleDbParameter("Total_transport", System.Data.OleDb.OleDbType.Double, 0, "Total transport"),
            new System.Data.OleDb.OleDbParameter("Total_usure", System.Data.OleDb.OleDbType.Double, 0, "Total usure"),
            new System.Data.OleDb.OleDbParameter("Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, "Type machine")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Affectation", System.Data.OleDb.OleDbType.Integer, 0, "Affectation"),
            new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"),
            new System.Data.OleDb.OleDbParameter("Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Mabec"),
            new System.Data.OleDb.OleDbParameter("Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine client"),
            new System.Data.OleDb.OleDbParameter("Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, "Code machine Opindus"),
            new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Boolean, 2, "creation"),
            new System.Data.OleDb.OleDbParameter("Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier controle"),
            new System.Data.OleDb.OleDbParameter("Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, "Date dernier intervention"),
            new System.Data.OleDb.OleDbParameter("Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, "Date fin garantie"),
            new System.Data.OleDb.OleDbParameter("Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, "Date mise en service"),
            new System.Data.OleDb.OleDbParameter("Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, "Date reforme"),
            new System.Data.OleDb.OleDbParameter("Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, "Date refus"),
            new System.Data.OleDb.OleDbParameter("En_parc", System.Data.OleDb.OleDbType.Boolean, 2, "En parc"),
            new System.Data.OleDb.OleDbParameter("En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, "En reparation"),
            new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"),
            new System.Data.OleDb.OleDbParameter("Memo", System.Data.OleDb.OleDbType.VarWChar, 0, "Memo"),
            new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"),
            new System.Data.OleDb.OleDbParameter("N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, "N_fichier_FVG"),
            new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"),
            new System.Data.OleDb.OleDbParameter("No_controle", System.Data.OleDb.OleDbType.Integer, 0, "No controle"),
            new System.Data.OleDb.OleDbParameter("No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis"),
            new System.Data.OleDb.OleDbParameter("No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, "No dernier devis refus"),
            new System.Data.OleDb.OleDbParameter("No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, "No serie"),
            new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre ctl"),
            new System.Data.OleDb.OleDbParameter("nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, "nombre semaine entre inter"),
            new System.Data.OleDb.OleDbParameter("Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, "Prix Achat"),
            new System.Data.OleDb.OleDbParameter("Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, "Prix remplacement"),
            new System.Data.OleDb.OleDbParameter("Site", System.Data.OleDb.OleDbType.Integer, 0, "Site"),
            new System.Data.OleDb.OleDbParameter("Total_casse", System.Data.OleDb.OleDbType.Double, 0, "Total casse"),
            new System.Data.OleDb.OleDbParameter("Total_controle", System.Data.OleDb.OleDbType.Double, 0, "Total controle"),
            new System.Data.OleDb.OleDbParameter("Total_general", System.Data.OleDb.OleDbType.Double, 0, "Total general"),
            new System.Data.OleDb.OleDbParameter("Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, "Total maintenance"),
            new System.Data.OleDb.OleDbParameter("Total_MO", System.Data.OleDb.OleDbType.Double, 0, "Total MO"),
            new System.Data.OleDb.OleDbParameter("Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, "Total piece manque"),
            new System.Data.OleDb.OleDbParameter("Total_transport", System.Data.OleDb.OleDbType.Double, 0, "Total transport"),
            new System.Data.OleDb.OleDbParameter("Total_usure", System.Data.OleDb.OleDbType.Double, 0, "Total usure"),
            new System.Data.OleDb.OleDbParameter("Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, "Type machine"),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_Opindus", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine Opindus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Affectation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Affectation1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Affectation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Mabec", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Mabec1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Mabec", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_client", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_machine_client1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code machine client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_controle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_dernier_intervention1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date dernier intervention", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_fin_garantie1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date fin garantie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_mise_en_service1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date mise en service", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reforme", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reforme1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_refus", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_refus1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_En_parc", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "En parc", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_En_reparation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "En reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N_fichier_FVG1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N_fichier_FVG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_controle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_controle1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_dernier_devis_refus1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No dernier devis refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_serie", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No serie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_No_serie1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "No serie", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Achat1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Achat", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_remplacement1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix remplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Site", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Site", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Site1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Site", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_MO", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_MO1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total MO", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_casse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_casse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total casse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_general", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total general", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_general1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total general", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_maintenance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_maintenance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total maintenance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_piece_manque1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total piece manque", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_usure", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_usure1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total usure", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_machine", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_machine1", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_ctl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre ctl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre_semaine_entre_inter1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre semaine entre inter", System.Data.DataRowVersion.Original, null)});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_type_machine", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse"),
                        new System.Data.Common.DataColumnMapping("Maxi machine", "Maxi machine"),
                        new System.Data.Common.DataColumnMapping("Mini machine", "Mini machine"),
                        new System.Data.Common.DataColumnMapping("Code", "Code")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO T_type_machine(Vitesse, [Maxi machine], [Mini machine], Code) VALUES " +
    "(?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"),
            new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"),
            new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT Vitesse, [Maxi machine], [Mini machine], Code FROM T_type_machine";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"),
            new System.Data.OleDb.OleDbParameter("Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, "Maxi machine"),
            new System.Data.OleDb.OleDbParameter("Mini_machine", System.Data.OleDb.OleDbType.Double, 0, "Mini machine"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Maxi_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Maxi machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Mini_machine1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mini machine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_type_machine_Vis", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("C_maxi", "C_maxi"),
                        new System.Data.Common.DataColumnMapping("C_mini", "C_mini"),
                        new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse"),
                        new System.Data.Common.DataColumnMapping("Code", "Code")})});
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM T_type_machine_Vis WHERE (Code = ?) AND (C_maxi = ? OR ? IS NULL AND " +
    "C_maxi IS NULL) AND (C_mini = ? OR ? IS NULL AND C_mini IS NULL) AND (Vitesse = " +
    "? OR ? IS NULL AND Vitesse IS NULL)";
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO T_type_machine_Vis(C_maxi, C_mini, Vitesse, Code) VALUES (?, ?, ?, ?)" +
    "";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"),
            new System.Data.OleDb.OleDbParameter("C_mini", System.Data.OleDb.OleDbType.Double, 0, "C_mini"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code")});
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT C_maxi, C_mini, Vitesse, Code FROM T_type_machine_Vis";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"),
            new System.Data.OleDb.OleDbParameter("C_mini", System.Data.OleDb.OleDbType.Double, 0, "C_mini"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_mini", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_mini1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_mini", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // Caracteristiques2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 19);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(647, 537);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Caracteristiques2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caracteristiques2";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			ControlesCAM WinControlesCAM = new ControlesCAM(Agence, textBox1.Text);
			WinControlesCAM.ShowDialog();
			this.Refresh();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			ListeControlesCam WinListeCtrl = new ListeControlesCam(Agence, textBox1.Text);
			WinListeCtrl.ShowDialog();
			this.Refresh();
		}
	}
}
