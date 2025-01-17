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
	/// Description résumée de AcCauses.
	/// </summary>
	public class AcCauses : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btSupprime;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btNouveau;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private int Agence;
		bool Nouveau;
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
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AcCauses(int Agence)
		{
			InitializeComponent();

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
			try
			{
				Comm.CommandText="SELECT T_causes.Designation FROM T_causes ORDER BY T_causes.Designation";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"Causes");
				mtgcComboBox1.SourceDataString=new string[] {"Designation","","","",""};
				mtgcComboBox1.SourceDataTable=ds.Tables["Causes"];
				mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
				Nouveau=true;
				ds.Tables["Causes"].Clear();
				mtgcComboBox1.SelectedIndex=0;

			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			
			
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AcCauses));
			this.btSupprime = new System.Windows.Forms.Button();
			this.btEnregistre = new System.Windows.Forms.Button();
			this.btNouveau = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.txDesignation = new System.Windows.Forms.TextBox();
			this.txCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControlEX1.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btSupprime
			// 
			this.btSupprime.BackColor = System.Drawing.Color.White;
			this.btSupprime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSupprime.Enabled = false;
			this.btSupprime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupprime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btSupprime.ForeColor = System.Drawing.Color.Red;
			this.btSupprime.Location = new System.Drawing.Point(296, 176);
			this.btSupprime.Name = "btSupprime";
			this.btSupprime.Size = new System.Drawing.Size(100, 23);
			this.btSupprime.TabIndex = 11;
			this.btSupprime.Text = "Supprime";
			this.btSupprime.Click += new System.EventHandler(this.btSupprime_Click);
			// 
			// btEnregistre
			// 
			this.btEnregistre.BackColor = System.Drawing.Color.White;
			this.btEnregistre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btEnregistre.Enabled = false;
			this.btEnregistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEnregistre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btEnregistre.ForeColor = System.Drawing.Color.Blue;
			this.btEnregistre.Location = new System.Drawing.Point(128, 176);
			this.btEnregistre.Name = "btEnregistre";
			this.btEnregistre.Size = new System.Drawing.Size(100, 23);
			this.btEnregistre.TabIndex = 10;
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
			this.btNouveau.TabIndex = 9;
			this.btNouveau.Text = "Nouveau";
			this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=ReadWrite;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Location = new System.Drawing.Point(-5, 9);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Gainsboro;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(525, 241);
			this.tabControlEX1.TabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.TabIndex = 13;
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
			this.tabPageEX1.Size = new System.Drawing.Size(517, 212);
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
			this.mtgcComboBox1.Location = new System.Drawing.Point(112, 29);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(344, 21);
			this.mtgcComboBox1.TabIndex = 12;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// txDesignation
			// 
			this.txDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txDesignation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txDesignation.Enabled = false;
			this.txDesignation.Location = new System.Drawing.Point(112, 109);
			this.txDesignation.Name = "txDesignation";
			this.txDesignation.Size = new System.Drawing.Size(344, 20);
			this.txDesignation.TabIndex = 11;
			this.txDesignation.Text = "";
			// 
			// txCode
			// 
			this.txCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCode.Enabled = false;
			this.txCode.Location = new System.Drawing.Point(112, 69);
			this.txCode.Name = "txCode";
			this.txCode.ReadOnly = true;
			this.txCode.TabIndex = 10;
			this.txCode.Text = "";
			this.txCode.TextChanged += new System.EventHandler(this.txCode_TextChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Designation";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Code";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Recherche";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(456, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 48);
			this.button2.TabIndex = 19;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// AcCauses
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(515, 246);
			this.ControlBox = false;
			this.Controls.Add(this.tabControlEX1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "AcCauses";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Causes";
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
			Nouveau=true;
			Nettoyer();
			Activer();
			txDesignation.BackColor=Color.MistyRose;
			Comm.CommandText="SELECT Max(T_causes.Code) AS MaxDeCode FROM T_causes";
			try
			{
				oleDbConnection1.Open();
				int Code=System.Convert.ToInt32(Comm.ExecuteScalar())+1;
				txCode.Text=Code.ToString();
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
				MessageBox.Show("Erreur dans la base de données","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				oleDbConnection1.Close();
			}

		}


		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			if(txDesignation.Text.Length==0&&txCode.Text.Length==0)
			{
				MessageBox.Show("Champ vide interdit !");
			}
			else
			{
				if(Nouveau)
				{
					Comm.CommandText="INSERT INTO T_causes (Code,Designation) VALUES ("+txCode.Text+",'"+txDesignation.Text.Replace("'","''")+"')";
					try
					{
						oleDbConnection1.Open();
						Transac = oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Enregistrement terminé","I/O",MessageBoxButtons.OK, MessageBoxIcon.Information);
							Nettoyer();
							Desactiver();
							mtgcComboBox1.Items.Clear();
							Comm.CommandText="SELECT T_causes.Designation FROM T_causes ORDER BY T_causes.Designation";
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Causes");
							mtgcComboBox1.SourceDataString=new string[] {"Designation","","","",""};
							mtgcComboBox1.SourceDataTable=ds.Tables["Causes"];
							ds.Tables["Causes"].Clear();
							mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
							mtgcComboBox1.SelectedIndex=0;
						}
						catch(OleDbException ex)
						{
							Transac.Rollback();
							Console.WriteLine(ex.Message);
							MessageBox.Show("Erreur dans la base de données");
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
				else
				{
					Comm.CommandText="UPDATE t_causes SET designation ='"+txDesignation.Text+"' WHERE code="+txCode.Text;
					try
					{
						oleDbConnection1.Open();
						Transac = oleDbConnection1.BeginTransaction();
						Comm.Transaction = Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Mise à jour terminée","I/O",MessageBoxButtons.OK, MessageBoxIcon.Information);
							Nettoyer();
							Desactiver();
							mtgcComboBox1.Items.Clear();
							Comm.CommandText="SELECT T_causes.Designation FROM T_causes ORDER BY T_causes.Designation";
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Causes");
							mtgcComboBox1.SourceDataString=new string[] {"Designation","","","",""};
							mtgcComboBox1.SourceDataTable=ds.Tables["Causes"];
							ds.Tables["Causes"].Clear();
							mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
							mtgcComboBox1.SelectedIndex=0;
						}
						catch(OleDbException ex)
						{
							Transac.Rollback();
							MessageBox.Show("Erreur dans la base de données");
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

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			if(txDesignation.Text.Length==0&&txCode.Text.Length==0)
				MessageBox.Show("Rien à supprimer !");
			else
			{
				
				if(MessageBox.Show("Suppression ?","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
				{
					Comm.CommandText="DELETE FROM T_causes WHERE Code="+txCode.Text;
					try
					{
						oleDbConnection1.Open();
						Transac = oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Suppression terminée","I/O",MessageBoxButtons.OK, MessageBoxIcon.Information);
							Nettoyer();
							Desactiver();
							mtgcComboBox1.Items.Clear();
							Comm.CommandText="SELECT T_causes.Designation FROM T_causes ORDER BY T_causes.Designation";
							DataAD.SelectCommand=Comm;
							DataAD.Fill(ds,"Causes");
							mtgcComboBox1.SourceDataString=new string[] {"Designation","","","",""};
							mtgcComboBox1.SourceDataTable=ds.Tables["Causes"];
							ds.Tables["Causes"].Clear();
							mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
						}
						catch(OleDbException ex)
						{
							Transac.Rollback();
							MessageBox.Show("Erreur dans la base de données");
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

		private void mtgcComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(mtgcComboBox1.SelectedIndex>0)
			{
				Comm.CommandText="SELECT code, designation FROM T_causes WHERE designation='"+mtgcComboBox1.Text.Replace("'","''")+"'";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"Causes");
				txCode.Text=ds.Tables["Causes"].Rows[0]["Code"].ToString();
				txDesignation.Text=ds.Tables["Causes"].Rows[0]["Designation"].ToString();
				ds.Tables["Causes"].Clear();
				Activer();
				Nouveau=false;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void Nettoyer()
		{
			txCode.Text="";
			txDesignation.BackColor=Color.Empty;
			txDesignation.Text="";
			mtgcComboBox1.Text="";
			mtgcComboBox1.SelectedIndex=0;
		}

		private void Activer()
		{
			txCode.Enabled=true;
			txDesignation.Enabled=true;
		}

		private void Desactiver()
		{
			txCode.Enabled=false;
			txDesignation.Enabled=false;
			btEnregistre.Enabled=false;
			btSupprime.Enabled=false;
		}

		private void txCode_TextChanged(object sender, System.EventArgs e)
		{
			if(txCode.Text.Length>0)
			{
				btEnregistre.Enabled=true;
				btSupprime.Enabled=true;
			}
		}

	}
}
