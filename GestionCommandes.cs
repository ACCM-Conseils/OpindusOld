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
	/// Description résumée de GestionCommandes.
	/// </summary>
	public class GestionCommandes : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Button button5;
		private Commande WinCommande;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private OleDbTransaction Transac;
		private bool Debut;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GestionCommandes(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			Debut=true;
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

			Debut=false;

			WinCommande = new Commande(Agence);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GestionCommandes));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Commandes";
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(104, 16);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(96, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Non soldées";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(16, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(72, 24);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.Text = "Soldées";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.Color.MintCream;
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
			this.listView1.Location = new System.Drawing.Point(16, 64);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(896, 544);
			this.listView1.TabIndex = 1;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "N° Commande";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Date";
			this.columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Code";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Fournisseur";
			this.columnHeader4.Width = 370;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Editée";
			this.columnHeader5.Width = 80;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Validée";
			this.columnHeader6.Width = 80;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Soldée";
			this.columnHeader7.Width = 80;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=ReadWrite;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Location = new System.Drawing.Point(672, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 48);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Affichage";
			// 
			// radioButton4
			// 
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(144, 16);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(60, 24);
			this.radioButton4.TabIndex = 1;
			this.radioButton4.Text = "Toutes";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(16, 16);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(112, 24);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Les 30 dernières";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(864, 624);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(48, 48);
			this.button5.TabIndex = 15;
			this.button5.TabStop = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// GestionCommandes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(924, 688);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "GestionCommandes";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gestion des commandes";
			this.VisibleChanged += new System.EventHandler(this.GestionCommandes_VisibleChanged);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void InitializeData()
		{
			listView1.Items.Clear();
			Comm.CommandText="Select TOP 30 t_cde_entete.[N° Commande],t_cde_entete.[Solde],t_cde_entete.[Edite],t_cde_entete.[Valide],t_cde_entete.[Date commande],t_cde_entete.[Code Fournisseur], t_fournisseurs.[nom] from t_cde_entete, t_fournisseurs where t_cde_entete.[Code fournisseur]=t_fournisseurs.Code order by 1 desc";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"t_cde_entete");
			
			foreach(DataRow row in ds.Tables["t_cde_entete"].Rows)
			{
				if(row["Solde"].ToString().Equals("False"))
				{
					ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
					if(row["Date Commande"].ToString().Length>0)
						item.SubItems.Add(System.Convert.ToDateTime(row["Date Commande"].ToString()).ToShortDateString());
					else
						item.SubItems.Add("");
					item.SubItems.Add(row["Code fournisseur"].ToString());
					item.SubItems.Add(row["Nom"].ToString());
					if(row["Edite"].ToString().Equals("True"))
						item.SubItems.Add("Oui");
					else
						item.SubItems.Add("Non");
					if(row["Valide"].ToString().Equals("True"))
						item.SubItems.Add("Oui");
					else
						item.SubItems.Add("Non");
					if(row["Solde"].ToString().Equals("True"))
						item.SubItems.Add("Oui");
					else
						item.SubItems.Add("Non");

					listView1.Items.Add(item);
				}
				
			}
			ds.Tables["t_cde_entete"].Clear();
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!Debut)
			{
				int Cpt=0;
				Comm.CommandText="Select t_cde_entete.[N° Commande],t_cde_entete.[Solde],t_cde_entete.[Edite],t_cde_entete.[Valide],t_cde_entete.[Date commande],t_cde_entete.[Code Fournisseur], t_fournisseurs.[nom] from t_cde_entete, t_fournisseurs where t_cde_entete.[Code fournisseur]=t_fournisseurs.Code order by 1 desc";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_cde_entete");
				listView1.Items.Clear();
				foreach(DataRow row in ds.Tables["t_cde_entete"].Rows)
				{
					if(row["Solde"].ToString().Equals("False"))
					{
						ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
						if(row["Date Commande"].ToString().Length>0)
							item.SubItems.Add(System.Convert.ToDateTime(row["Date Commande"].ToString()).ToShortDateString());
						else
							item.SubItems.Add("");
						item.SubItems.Add(row["Code fournisseur"].ToString());
						item.SubItems.Add(row["Nom"].ToString());
						if(row["Edite"].ToString().Equals("True"))
							item.SubItems.Add("Oui");
						else
							item.SubItems.Add("Non");
						if(row["Valide"].ToString().Equals("True"))
							item.SubItems.Add("Oui");
						else
							item.SubItems.Add("Non");
						if(row["Solde"].ToString().Equals("True"))
							item.SubItems.Add("Oui");
						else
							item.SubItems.Add("Non");

						listView1.Items.Add(item);
						if(radioButton3.Checked)
						{
							if(Cpt==30)
								break;
						}
						Cpt++;
					}
				}
				ds.Tables["t_cde_entete"].Clear();
			}
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!Debut)
			{
				int Cpt=0;
				listView1.Items.Clear();
				Comm.CommandText="Select t_cde_entete.[N° Commande],t_cde_entete.[Solde],t_cde_entete.[Edite],t_cde_entete.[Valide],t_cde_entete.[Date commande],t_cde_entete.[Code Fournisseur], t_fournisseurs.[nom] from t_cde_entete, t_fournisseurs where t_cde_entete.[Code fournisseur]=t_fournisseurs.Code order by 1 desc";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_cde_entete");
				foreach(DataRow row in ds.Tables["t_cde_entete"].Rows)
				{
					if(row["Solde"].ToString().Equals("True"))
					{
						ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
						if(row["Date Commande"].ToString().Length>0)
							item.SubItems.Add(row["Date Commande"].ToString().Remove(10,9));
						else
							item.SubItems.Add("");
						item.SubItems.Add(row["Code fournisseur"].ToString());
						item.SubItems.Add(row["Nom"].ToString());
						if(row["Edite"].ToString().Equals("True"))
							item.SubItems.Add("Oui");
						else
							item.SubItems.Add("Non");
						if(row["Valide"].ToString().Equals("True"))
							item.SubItems.Add("Oui");
						else
							item.SubItems.Add("Non");
						if(row["Solde"].ToString().Equals("True"))
							item.SubItems.Add("Oui");
						else
							item.SubItems.Add("Non");

						listView1.Items.Add(item);

						if(radioButton3.Checked)
						{
							if(Cpt==30)
								break;
						}
						Cpt++;
					}
				}
			}
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!Debut)
			{
				int Cpt=0;
				listView1.Items.Clear();
				Comm.CommandText="Select t_cde_entete.[N° Commande],t_cde_entete.[Solde],t_cde_entete.[Edite],t_cde_entete.[Valide],t_cde_entete.[Date commande],t_cde_entete.[Code Fournisseur], t_fournisseurs.[nom] from t_cde_entete, t_fournisseurs where t_cde_entete.[Code fournisseur]=t_fournisseurs.Code order by 1 desc";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_cde_entete");
				foreach(DataRow row in ds.Tables["t_cde_entete"].Rows)
				{
					if(radioButton1.Checked)
					{
						if(row["Solde"].ToString().Equals("True"))
						{
							ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
							if(row["Date Commande"].ToString().Length>0)
								item.SubItems.Add(row["Date Commande"].ToString().Remove(10,9));
							else
								item.SubItems.Add("");
							item.SubItems.Add(row["Code fournisseur"].ToString());
							item.SubItems.Add(row["Nom"].ToString());
							if(row["Edite"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(row["Valide"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(row["Solde"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(radioButton3.Checked)
							{
								if(Cpt==30)
									break;
							}
							Cpt++;

							listView1.Items.Add(item);
						}
					}
					else if(radioButton2.Checked)
					{
						if(row["Solde"].ToString().Equals("False"))
						{
							ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
							if(row["Date Commande"].ToString().Length>0)
								item.SubItems.Add(row["Date Commande"].ToString().Remove(10,9));
							else
								item.SubItems.Add("");
							item.SubItems.Add(row["Code fournisseur"].ToString());
							item.SubItems.Add(row["Nom"].ToString());
							if(row["Edite"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(row["Valide"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(row["Solde"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(radioButton3.Checked)
							{
								if(Cpt==30)
									break;
							}
							Cpt++;
							listView1.Items.Add(item);
						}
					}
				}
				ds.Tables["t_cde_entete"].Clear();
			}
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!Debut)
			{
				int Cpt=0;
				listView1.Items.Clear();
				Comm.CommandText="Select t_cde_entete.[N° Commande],t_cde_entete.[Solde],t_cde_entete.[Edite],t_cde_entete.[Valide],t_cde_entete.[Date commande],t_cde_entete.[Code Fournisseur], t_fournisseurs.[nom] from t_cde_entete, t_fournisseurs where t_cde_entete.[Code fournisseur]=t_fournisseurs.Code order by 1 desc";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"t_cde_entete");
				foreach(DataRow row in ds.Tables["t_cde_entete"].Rows)
				{
					if(radioButton1.Checked)
					{
						if(row["Solde"].ToString().Equals("True"))
						{
							ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
							if(row["Date Commande"].ToString().Length>0)
								item.SubItems.Add(row["Date Commande"].ToString().Remove(10,9));
							else
								item.SubItems.Add("");
							item.SubItems.Add(row["Code fournisseur"].ToString());
							item.SubItems.Add(row["Nom"].ToString());
							if(row["Edite"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(row["Valide"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(row["Solde"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(radioButton3.Checked)
							{
								if(Cpt==30)
									break;
							}
							Cpt++;
							listView1.Items.Add(item);
						}
					}
					else if(radioButton2.Checked)
					{
						if(row["Solde"].ToString().Equals("False"))
						{
							ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
							if(row["Date Commande"].ToString().Length>0)
								item.SubItems.Add(row["Date Commande"].ToString().Remove(10,9));
							else
								item.SubItems.Add("");
							item.SubItems.Add(row["Code fournisseur"].ToString());
							item.SubItems.Add(row["Nom"].ToString());
							if(row["Edite"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(row["Valide"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(row["Solde"].ToString().Equals("True"))
								item.SubItems.Add("Oui");
							else
								item.SubItems.Add("Non");
							if(radioButton3.Checked)
							{
								if(Cpt==30)
									break;
							}
							Cpt++;
							listView1.Items.Add(item);
						}
					}
				}
				ds.Tables["t_cde_entete"].Clear();
			}
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			if(listView1.SelectedIndices.Count>0)
			{
				WinCommande.Remplir(listView1.Items[listView1.SelectedIndices[0]].Text);
				InitializeData();
				WinCommande.ShowDialog();
				if(!Debut)
				{
					int Cpt=0;
					listView1.Items.Clear();
					Comm.CommandText="Select t_cde_entete.[N° Commande],t_cde_entete.[Solde],t_cde_entete.[Edite],t_cde_entete.[Valide],t_cde_entete.[Date commande],t_cde_entete.[Code Fournisseur], t_fournisseurs.[nom] from t_cde_entete, t_fournisseurs where t_cde_entete.[Code fournisseur]=t_fournisseurs.Code order by 1 desc";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"t_cde_entete");
					foreach(DataRow row in ds.Tables["t_cde_entete"].Rows)
					{
						if(radioButton1.Checked)
						{
							if(row["Solde"].ToString().Equals("True"))
							{
								ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
								if(row["Date Commande"].ToString().Length>0)
									item.SubItems.Add(row["Date Commande"].ToString().Remove(10,9));
								else
									item.SubItems.Add("");
								item.SubItems.Add(row["Code fournisseur"].ToString());
								item.SubItems.Add(row["Nom"].ToString());
								if(row["Edite"].ToString().Equals("True"))
									item.SubItems.Add("Oui");
								else
									item.SubItems.Add("Non");
								if(row["Valide"].ToString().Equals("True"))
									item.SubItems.Add("Oui");
								else
									item.SubItems.Add("Non");
								if(row["Solde"].ToString().Equals("True"))
									item.SubItems.Add("Oui");
								else
									item.SubItems.Add("Non");
								if(radioButton3.Checked)
								{
									if(Cpt==30)
										break;
								}
								Cpt++;

								listView1.Items.Add(item);
							}
						}
						else if(radioButton2.Checked)
						{
							if(row["Solde"].ToString().Equals("False"))
							{
								ListViewItem item = new ListViewItem(row["N° Commande"].ToString());
								if(row["Date Commande"].ToString().Length>0)
									item.SubItems.Add(row["Date Commande"].ToString().Remove(10,9));
								else
									item.SubItems.Add("");
								item.SubItems.Add(row["Code fournisseur"].ToString());
								item.SubItems.Add(row["Nom"].ToString());
								if(radioButton3.Checked)
								{
									if(Cpt==30)
										break;
								}
								Cpt++;
								listView1.Items.Add(item);
							}
						}
					}
					ds.Tables["t_cde_entete"].Clear();
				}
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void GestionCommandes_VisibleChanged(object sender, System.EventArgs e)
		{
			if(this.Visible.Equals(true))
			{
				radioButton2.Checked=true;
				radioButton3.Checked=true;
				InitializeData();
			}
		}

	}
}
