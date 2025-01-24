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
	/// Description résumée de TransfertBL.
	/// </summary>
	public class TransfertBL : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private int Agence;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private OleDbCommand Comm;
		private OleDbTransaction Transac;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TransfertBL(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD = new OleDbDataAdapter();
			ds = new DataSet();

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

			Comm.CommandText="SELECT T_BL_entete.[N° BL], T_BL_entete.Date, T_clients.Nom, T_BL_entete.transfere FROM T_clients INNER JOIN T_BL_entete ON T_clients.Ident = T_BL_entete.[Code client] WHERE (((T_BL_entete.transfere)=False) AND (T_BL_entete.Edite=true)) order by T_clients.Nom";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(ds,"BL");
			foreach(DataRow row in ds.Tables["BL"].Rows)
			{
				listView1.Items.Add(row["N° BL"].ToString());
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Date"].ToString().Remove(10,9));
				listView1.Items[listView1.Items.Count-1].SubItems.Add(row["Nom"].ToString());
			}
			ds.Tables["BL"].Clear();
			

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransfertBL));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 315);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° BL";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Client";
            this.columnHeader3.Width = 230;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.ContextMenu = this.contextMenu1;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(24, 398);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(612, 210);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView2_KeyDown);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "N° BL";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Client";
            this.columnHeader6.Width = 230;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // listView3
            // 
            this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(660, 47);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(504, 561);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "N° BL";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Client";
            this.columnHeader8.Width = 230;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(660, 643);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lancer le transfert";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1092, 620);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 70);
            this.button5.TabIndex = 17;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TransfertBL
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 19);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1185, 711);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransfertBL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfert BL vers gestion commerciale";
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e)
		{
			listView2.Items.Add(listView1.Items[listView1.SelectedIndices[0]].Text);
			listView2.Items[listView2.Items.Count-1].SubItems.Add(listView1.Items[listView1.SelectedIndices[0]].SubItems[1].Text);
			listView2.Items[listView2.Items.Count-1].SubItems.Add(listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text);

			listView3.Items.Add(listView1.Items[listView1.SelectedIndices[0]].Text);
			listView3.Items[listView3.Items.Count-1].SubItems.Add(listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text);
		
			listView1.Items.Remove(listView1.SelectedItems[0]);
		}

		private void listView2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyValue.Equals(46))
			{
				listView2.Items[listView2.SelectedIndices[0]].Remove();
			}
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			contextMenu1.MenuItems.Clear();
			if(contextMenu1.SourceControl==listView2)
			{
				if(listView2.Items.Count>0)
				{
					MenuItem menuItem1 = new MenuItem("&Supprimer", new EventHandler(this.Supp_Clicked));
					contextMenu1.MenuItems.Add(menuItem1);
				}
			}
		}

		private void Supp_Clicked(object sender, System.EventArgs e)
		{
			
			for(int i=0;i<listView3.Items.Count;i++)
			{
				if(listView3.Items[i].Text==listView2.Items[listView2.SelectedIndices[0]].Text)
				{
					listView3.Items[i].Remove();
					break;
				}
			}
			listView2.Items[listView2.SelectedIndices[0]].Remove();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(listView3.Items.Count>0)
			{
				string Site=null;
				if(Agence.Equals(1))
					Site="69800_E_Bl.txt";
				else if(Agence.Equals(2))
					Site="59273_E_Bl.txt";
				else if(Agence.Equals(3))
					Site="76100_E_Bl.txt";
				string path = @"C:\Program Files (x86)\Opindus\Export\"+Site;
				StreamWriter writer = new StreamWriter(path,false);
				for(int i=0;i<listView3.Items.Count;i++)
				{
					
					Comm.CommandText="SELECT T_BL_entete.[N° BL], T_clients.code_GC, T_BL_entete.[N° Commande ouverte], T_BL_entete.[OR], T_BL_entete.Date, T_BL_entete.[Total bl], T_BL_entete.[Code TVA] FROM T_clients INNER JOIN T_BL_entete ON T_clients.Ident = T_BL_entete.[Code client] WHERE (((T_BL_entete.[N° BL])="+listView3.Items[i].Text+"))";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"t_bl_entete");
					string Ligne=ds.Tables["t_bl_entete"].Rows[0]["N° BL"].ToString()+";"+ds.Tables["t_bl_entete"].Rows[0]["Code_GC"].ToString()+";"+ds.Tables["t_bl_entete"].Rows[0]["N° Commande ouverte"].ToString()+";"+ds.Tables["t_bl_entete"].Rows[0]["OR"].ToString()+";"+ds.Tables["t_bl_entete"].Rows[0]["Date"].ToString().Remove(10,9)+";"+ds.Tables["t_bl_entete"].Rows[0]["Total BL"].ToString()+";"+ds.Tables["t_bl_entete"].Rows[0]["Code TVA"].ToString()+";";
					writer.WriteLine(Ligne);
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.CommandText="UPDATE T_BL_entete SET transfere=True WHERE [N° BL]="+listView3.Items[i].Text;
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
						}
						catch(OleDbException ex)
						{
							Transac.Rollback();
							Console.WriteLine(ex.Message);
						}
					}
					catch(Exception exp)
					{
						Console.WriteLine(exp.Message);
					}
					finally
					{
						oleDbConnection1.Close();
					}
					ds.Tables["t_bl_entete"].Clear();
				
				}
				if(Agence.Equals(1))
					Site="69800_E_Bl_L.txt";
				else if(Agence.Equals(2))
					Site="59273_E_Bl_L.txt";
				else if(Agence.Equals(3))
					Site="76100_E_Bl_L.txt";
				string path2 = @"C:\Program Files (x86)\Opindus\Export\"+Site;
				StreamWriter writer2 = new StreamWriter(path2,false);
				for(int i=0;i<listView3.Items.Count;i++)
				{
					Comm.CommandText="SELECT T_BL_Lignes.[N° BL], T_BL_Lignes.[N° Devis], T_BL_Lignes.[Code Mabec], T_BL_Lignes.[Type Materiel], T_BL_Lignes.[Code materiel], T_BL_Lignes.Fournisseur, T_BL_Lignes.Troncon, T_BL_Lignes.Montant, T_BL_Lignes.[Total ligne], T_Bl_ventilation.Libelle FROM T_BL_Lignes INNER JOIN T_Bl_ventilation ON T_BL_Lignes.[Code ventilation] = T_Bl_ventilation.Code WHERE (((T_BL_Lignes.[N° BL])="+listView3.Items[i].Text+")) ORDER BY T_BL_Lignes.[N° Devis] DESC";
					DataAD.SelectCommand=Comm;
					DataAD.Fill(ds,"t_bl_lignes");
					foreach(DataRow row in ds.Tables["t_bl_lignes"].Rows)
					{
						string Ligne2="";
						if(System.Convert.ToDecimal(row["Total ligne"].ToString()).Equals(0))
						{
							Ligne2=row["N° BL"].ToString()+";"+row["N° Devis"].ToString()+";"+row["Code Mabec"].ToString()+";"+row["Type materiel"].ToString()+";"+row["Code materiel"].ToString()+";"+row["Fournisseur"].ToString()+";"+row["Troncon"].ToString()+";;"+row["Montant"].ToString()+";"+row["Libelle"].ToString();
						}
						else
						{
							Ligne2=row["N° BL"].ToString()+";"+row["N° Devis"].ToString()+";"+row["Code Mabec"].ToString()+";"+row["Type materiel"].ToString()+";"+row["Code materiel"].ToString()+";"+row["Fournisseur"].ToString()+";"+row["Troncon"].ToString()+";;"+row["Total ligne"].ToString()+";"+row["Libelle"].ToString();
						}
						writer2.WriteLine(Ligne2);
					}
					ds.Tables["t_bl_lignes"].Clear();
				
				}
				MessageBox.Show("Transfert terminé","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
				writer.Close();
				writer2.Close();
				Dispose();
			}
			else
				MessageBox.Show("Veuillez choisir un BL à transferer");
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}
	}
}
