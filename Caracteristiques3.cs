using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Opindus
{
	/// <summary>
	/// Description résumée de Caracteristiques3.
	/// </summary>
	public class Caracteristiques3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button1;
		private int Agence;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Opindus.DataSet1 dataSet11;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private System.Windows.Forms.Label label6;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Caracteristiques3(int Agence, string Machine)
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
			oleDbDataAdapter1.SelectCommand.CommandText="SELECT T_parc_machine.[Code machine Opindus], T_parc_machine.[Type machine], T_famille_machine.Type FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_parc_machine.[Code machine Opindus])='"+Machine+"'))";
			oleDbDataAdapter1.Fill(dataSet11);
			textBox1.Text=dataSet11.Tables["t_parc_machine"].Rows[0]["code machine opindus"].ToString();
			textBox2.Text=dataSet11.Tables["t_parc_machine"].Rows[0]["Type machine"].ToString();
			int Type=System.Convert.ToInt32(dataSet11.Tables["t_parc_machine"].Rows[0]["Type"].ToString());
			if(Type.Equals(5))
			{
				label4.Visible=true;
				label5.Visible=true;
				textBox3.Visible=true;
				textBox4.Visible=true;
				oleDbDataAdapter2.SelectCommand.CommandText="select * from t_type_machine_ClC where Code='"+textBox2.Text+"'";
				oleDbDataAdapter2.Fill(dataSet11);
				if(dataSet11.Tables["t_type_machine_ClC"].Rows.Count>0)
				{
					textBox3.Text=dataSet11.Tables["t_type_machine_ClC"].Rows[0]["C_Maxi"].ToString();
					textBox4.Text=dataSet11.Tables["t_type_machine_ClC"].Rows[0]["Vitesse"].ToString();
				}
				label4.Text="Vitesse";
				label5.Text="Couple Maxi";
			}
			else if(Type.Equals(3))
			{
				label4.Visible=true;
				label5.Visible=true;
				textBox3.Visible=true;
				textBox4.Visible=true;
				oleDbDataAdapter3.SelectCommand.CommandText="select * from t_type_machine_meu where Code='"+textBox2.Text+"'";
				oleDbDataAdapter3.Fill(dataSet11);
				if(dataSet11.Tables["t_type_machine_meu"].Rows.Count>0)
				{
					textBox3.Text=dataSet11.Tables["t_type_machine_meu"].Rows[0]["Vitesse"].ToString();
					textBox4.Text=dataSet11.Tables["t_type_machine_meu"].Rows[0]["Puissance"].ToString();
				}
				label4.Text="Vitesse";
				label5.Text="Puissance";
			}
			else if(Type.Equals(4))
			{
				label4.Visible=true;
				label5.Visible=true;
				textBox3.Visible=true;
				textBox4.Visible=true;
				oleDbDataAdapter4.SelectCommand.CommandText="select * from t_type_machine_per where Code='"+textBox2.Text+"'";
				oleDbDataAdapter4.Fill(dataSet11);
				if(dataSet11.Tables["t_type_machine_per"].Rows.Count>0)
				{
					textBox3.Text=dataSet11.Tables["t_type_machine_per"].Rows[0]["Vitesse"].ToString();
					textBox4.Text=dataSet11.Tables["t_type_machine_per"].Rows[0]["Puissance"].ToString();
				}
				label4.Text="Vitesse";
				label5.Text="Puissance";
			}
			else
			{
				label4.Visible=false;
				label5.Visible=false;
				textBox3.Visible=false;
				textBox4.Visible=false;
				label6.Visible=true;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caracteristiques3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
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
            this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caractéristiques";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(24, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 117);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(324, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(150, 26);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(96, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 26);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(96, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Aucune information disponible";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(552, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 70);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
                        new System.Data.Common.DataColumnMapping("Comment", "Comment"),
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
            new System.Data.OleDb.OleDbParameter("Original_Comment", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Comment", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Comment1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Comment", System.Data.DataRowVersion.Original, null),
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
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
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
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 255, "Comment"),
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
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 255, "Comment"),
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
            new System.Data.OleDb.OleDbParameter("Original_Comment", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Comment", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Comment1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Comment", System.Data.DataRowVersion.Original, null),
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
            new System.Data.Common.DataTableMapping("Table", "T_type_machine_ClC", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("C_maxi", "C_maxi"),
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM T_type_machine_ClC WHERE (Code = ?) AND (C_maxi = ? OR ? IS NULL AND " +
    "C_maxi IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO T_type_machine_ClC(C_maxi, Code, Vitesse) VALUES (?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT C_maxi, Code, Vitesse FROM T_type_machine_ClC";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = "UPDATE T_type_machine_ClC SET C_maxi = ?, Code = ?, Vitesse = ? WHERE (Code = ?) " +
    "AND (C_maxi = ? OR ? IS NULL AND C_maxi IS NULL) AND (Vitesse = ? OR ? IS NULL A" +
    "ND Vitesse IS NULL)";
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("C_maxi", System.Data.OleDb.OleDbType.Double, 0, "C_maxi"),
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_maxi", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_C_maxi1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "C_maxi", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_type_machine_meu", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Puissance", "Puissance"),
                        new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM T_type_machine_meu WHERE (Code = ?) AND (Puissance = ? OR ? IS NULL A" +
    "ND Puissance IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Puissance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Puissance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO T_type_machine_meu(Code, Puissance, Vitesse) VALUES (?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Puissance", System.Data.OleDb.OleDbType.Double, 0, "Puissance"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse")});
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT Code, Puissance, Vitesse FROM T_type_machine_meu";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE T_type_machine_meu SET Code = ?, Puissance = ?, Vitesse = ? WHERE (Code = " +
    "?) AND (Puissance = ? OR ? IS NULL AND Puissance IS NULL) AND (Vitesse = ? OR ? " +
    "IS NULL AND Vitesse IS NULL)";
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Puissance", System.Data.OleDb.OleDbType.Double, 0, "Puissance"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Puissance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Puissance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter4
            // 
            this.oleDbDataAdapter4.DeleteCommand = this.oleDbDeleteCommand4;
            this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
            this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
            this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_type_machine_per", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code", "Code"),
                        new System.Data.Common.DataColumnMapping("Puissance", "Puissance"),
                        new System.Data.Common.DataColumnMapping("Vitesse", "Vitesse")})});
            this.oleDbDataAdapter4.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = "DELETE FROM T_type_machine_per WHERE (Code = ?) AND (Puissance = ? OR ? IS NULL A" +
    "ND Puissance IS NULL) AND (Vitesse = ? OR ? IS NULL AND Vitesse IS NULL)";
            this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Puissance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Puissance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO T_type_machine_per(Code, Puissance, Vitesse) VALUES (?, ?, ?)";
            this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Puissance", System.Data.OleDb.OleDbType.Double, 0, "Puissance"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse")});
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT Code, Puissance, Vitesse FROM T_type_machine_per";
            this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = "UPDATE T_type_machine_per SET Code = ?, Puissance = ?, Vitesse = ? WHERE (Code = " +
    "?) AND (Puissance = ? OR ? IS NULL AND Puissance IS NULL) AND (Vitesse = ? OR ? " +
    "IS NULL AND Vitesse IS NULL)";
            this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Code", System.Data.OleDb.OleDbType.VarWChar, 19, "Code"),
            new System.Data.OleDb.OleDbParameter("Puissance", System.Data.OleDb.OleDbType.Double, 0, "Puissance"),
            new System.Data.OleDb.OleDbParameter("Vitesse", System.Data.OleDb.OleDbType.Double, 0, "Vitesse"),
            new System.Data.OleDb.OleDbParameter("Original_Code", System.Data.OleDb.OleDbType.VarWChar, 19, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Puissance", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Puissance1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Puissance", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Vitesse1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vitesse", System.Data.DataRowVersion.Original, null)});
            // 
            // Caracteristiques3
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 19);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(665, 415);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Caracteristiques3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caracteristiques3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
