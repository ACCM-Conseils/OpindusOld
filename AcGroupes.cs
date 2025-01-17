using System;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Opindus
{
	/// <summary>
	/// Description résumée de AcGroupes.
	/// </summary>
	public class AcGroupes : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.Button btNouveau;
		private System.Windows.Forms.Button btEnregistre;
		private System.Windows.Forms.Button btSupprime;
		private int Agence;
		bool Nouveau;
		private Dotnetrix.Controls.TabPageEX tabPageEX1;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.TextBox txDesignation;
		private System.Windows.Forms.TextBox txCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Dotnetrix.Controls.TabControlEX tabControlEX1;
		private System.Windows.Forms.Button button2;
		private OleDbTransaction Transac;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet ds;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AcGroupes(int Agence)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			DataAD=new OleDbDataAdapter();
			Comm=new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			ds=new DataSet();


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
			Nouveau=true;

			Comm.CommandText="SELECT Code, Designation FROM t_groupes ORDER BY Designation";
			DataAD.SelectCommand=Comm;
			try
			{
				DataAD.Fill(ds,"t_groupes");
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
			}
			mtgcComboBox1.SourceDataString = new string[] {"Code","designation","",""};
			mtgcComboBox1.SourceDataTable=ds.Tables["t_groupes"];
			mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
			mtgcComboBox1.SelectedIndex=0;
			ds.Tables["t_groupes"].Clear();
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AcGroupes));
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.btNouveau = new System.Windows.Forms.Button();
			this.btEnregistre = new System.Windows.Forms.Button();
			this.btSupprime = new System.Windows.Forms.Button();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.txDesignation = new System.Windows.Forms.TextBox();
			this.txCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControlEX1 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1.SuspendLayout();
			this.tabControlEX1.SuspendLayout();
			this.SuspendLayout();
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=ReadWrite;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// btNouveau
			// 
			this.btNouveau.BackColor = System.Drawing.Color.White;
			this.btNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNouveau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btNouveau.ForeColor = System.Drawing.Color.Blue;
			this.btNouveau.Location = new System.Drawing.Point(13, 176);
			this.btNouveau.Name = "btNouveau";
			this.btNouveau.Size = new System.Drawing.Size(100, 23);
			this.btNouveau.TabIndex = 1;
			this.btNouveau.Text = "Nouveau";
			this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
			// 
			// btEnregistre
			// 
			this.btEnregistre.BackColor = System.Drawing.Color.White;
			this.btEnregistre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btEnregistre.Enabled = false;
			this.btEnregistre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEnregistre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btEnregistre.ForeColor = System.Drawing.Color.Blue;
			this.btEnregistre.Location = new System.Drawing.Point(120, 176);
			this.btEnregistre.Name = "btEnregistre";
			this.btEnregistre.Size = new System.Drawing.Size(100, 23);
			this.btEnregistre.TabIndex = 2;
			this.btEnregistre.Text = "Enregistre";
			this.btEnregistre.Click += new System.EventHandler(this.btEnregistre_Click);
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
			this.btSupprime.TabIndex = 3;
			this.btSupprime.Text = "Supprime";
			this.btSupprime.Click += new System.EventHandler(this.btSupprime_Click);
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
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
			this.tabPageEX1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(517, 214);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "Saisie";
			// 
			// mtgcComboBox1
			// 
			this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
			this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.mtgcComboBox1.ColumnNum = 2;
			this.mtgcComboBox1.ColumnWidth = "60;120";
			this.mtgcComboBox1.DisplayMember = "Text";
			this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(169)), ((System.Byte)(223)));
			this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(210)), ((System.Byte)(238)));
			this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
			this.mtgcComboBox1.DropDownWidth = 200;
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = true;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(115, 24);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(295, 21);
			this.mtgcComboBox1.TabIndex = 14;
			this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
			// 
			// txDesignation
			// 
			this.txDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txDesignation.Enabled = false;
			this.txDesignation.Location = new System.Drawing.Point(115, 109);
			this.txDesignation.Name = "txDesignation";
			this.txDesignation.Size = new System.Drawing.Size(296, 20);
			this.txDesignation.TabIndex = 2;
			this.txDesignation.Text = "";
			// 
			// txCode
			// 
			this.txCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txCode.Enabled = false;
			this.txCode.Location = new System.Drawing.Point(115, 67);
			this.txCode.MaxLength = 3;
			this.txCode.Name = "txCode";
			this.txCode.Size = new System.Drawing.Size(58, 20);
			this.txCode.TabIndex = 1;
			this.txCode.Text = "";
			this.txCode.TextChanged += new System.EventHandler(this.txCode_TextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(28, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "Designation :";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(28, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Code :";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(28, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Recherche :";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(456, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 48);
			this.button2.TabIndex = 20;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tabControlEX1
			// 
			this.tabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.Bevel;
			this.tabControlEX1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.tabControlEX1.Controls.Add(this.tabPageEX1);
			this.tabControlEX1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabControlEX1.ForeColor = System.Drawing.Color.Black;
			this.tabControlEX1.ItemSize = new System.Drawing.Size(91, 21);
			this.tabControlEX1.Location = new System.Drawing.Point(-5, 8);
			this.tabControlEX1.Name = "tabControlEX1";
			this.tabControlEX1.SelectedIndex = 0;
			this.tabControlEX1.SelectedTabColor = System.Drawing.Color.Gainsboro;
			this.tabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX1.Size = new System.Drawing.Size(525, 243);
			this.tabControlEX1.TabColor = System.Drawing.Color.Silver;
			this.tabControlEX1.TabIndex = 5;
			this.tabControlEX1.UseVisualStyles = false;
			// 
			// AcGroupes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(178)), ((System.Byte)(198)), ((System.Byte)(222)));
			this.ClientSize = new System.Drawing.Size(515, 246);
			this.ControlBox = false;
			this.Controls.Add(this.tabControlEX1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "AcGroupes";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Groupes";
			this.tabPageEX1.ResumeLayout(false);
			this.tabControlEX1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion



		private void btQuitter_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void btSupprime_Click(object sender, System.EventArgs e)
		{
			if(txCode.Text.Length==0&&txDesignation.Text.Length==0)
				MessageBox.Show("Rien à supprimer !");
			else
			{	
				if(MessageBox.Show("Supprimer l'enregistrement ?","Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
				{
					Comm.CommandText="DELETE FROM t_groupes WHERE code="+txCode.Text;
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Suppression terminée","I/O",MessageBoxButtons.OK, MessageBoxIcon.Information);
							Nettoyer();
							Desactiver();
							mtgcComboBox1.Items.Clear();
							mtgcComboBox1.SourceDataString = new string[] {"Code","designation","",""};
							mtgcComboBox1.SourceDataTable=ds.Tables["t_groupes"];
							mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
							mtgcComboBox1.SelectedIndex=0;
							ds.Tables["t_groupes"].Clear();
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

		private void btNouveau_Click(object sender, System.EventArgs e)
		{
			Nouveau=true;
			Nettoyer();
			Activer();
			txCode.Focus();
			txCode.BackColor=Color.MistyRose;
		}

		private void btEnregistre_Click(object sender, System.EventArgs e)
		{
			bool save=true;
			if(Nouveau)
			{
				Comm.CommandText="SELECT Code FROM t_groupes WHERE Code='"+txCode.Text.Replace("'","''")+"'";
				String Code="";
				try
				{
					oleDbConnection1.Open();
					Code=System.Convert.ToString(Comm.ExecuteScalar());
					oleDbConnection1.Close();
				}
				catch(Exception exp)
				{
					Console.WriteLine(exp.Message);
				}
				if(Code.Length>0)
				{
					MessageBox.Show("Code déjà présent dans la base","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
					save=false;
				}
				if(txDesignation.TextLength.Equals(0))
				{
					MessageBox.Show("Champ désignation obligatoire","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
					save=false;
				}
			}
			if(save)
			{
				if(Nouveau)
				{
					Comm.CommandText="INSERT INTO t_groupes (Code,Designation) VALUES ('"+txCode.Text.Replace("'","''")+"','"+txDesignation.Text.Replace("'","''")+"')";
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						try
						{
							Comm.ExecuteNonQuery();
							Transac.Commit();
							MessageBox.Show("Enregistrement terminé.","I/O",MessageBoxButtons.OK, MessageBoxIcon.Information);
							Nettoyer();
							Desactiver();
							mtgcComboBox1.Items.Clear();
							ds.Tables["t_groupes"].Clear();
							Comm.CommandText="SELECT Code, Designation FROM t_groupes ORDER BY Designation";
							DataAD.SelectCommand=Comm;
							try
							{
								DataAD.Fill(ds,"t_groupes");
							}
							catch(Exception exp)
							{
								MessageBox.Show(exp.Message);
							}
							mtgcComboBox1.SourceDataString = new string[] {"Code","designation","",""};
							mtgcComboBox1.SourceDataTable=ds.Tables["t_groupes"];
							mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
							mtgcComboBox1.SelectedIndex=0;
							ds.Tables["t_groupes"].Clear();
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
				else
				{
					Comm.CommandText="update t_groupes set designation ='"+txDesignation.Text+"' where code='"+txCode.Text+"'";
					try
					{
						oleDbConnection1.Open();
						Transac=oleDbConnection1.BeginTransaction();
						Comm.Transaction=Transac;
						Comm.ExecuteNonQuery();
						try
						{
							Transac.Commit();
							MessageBox.Show("Mise à jour terminée.","I/O",MessageBoxButtons.OK, MessageBoxIcon.Information);
							Nettoyer();
							Desactiver();
							mtgcComboBox1.Items.Clear();
							mtgcComboBox1.SourceDataString = new string[] {"Code","designation","",""};
							mtgcComboBox1.SourceDataTable=ds.Tables["t_groupes"];
							mtgcComboBox1.Items.Insert(0,new MTGCComboBoxItem("...","","",""));
							mtgcComboBox1.SelectedIndex=0;
							ds.Tables["t_groupes"].Clear();
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
				Comm.CommandText="SELECT Code,Designation FROM t_groupes WHERE Code='"+mtgcComboBox1.Text.Replace("'","''")+"'";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(ds,"Code");
				txCode.Text=ds.Tables["Code"].Rows[0]["Code"].ToString();
				txDesignation.Text=ds.Tables["Code"].Rows[0]["Designation"].ToString();
				ds.Tables["Code"].Clear();
				Nouveau=false;
				Activer();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void Nettoyer()
		{
			txCode.Text="";
			txDesignation.Text="";
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
		}

		private void txCode_TextChanged(object sender, System.EventArgs e)
		{
			if(txCode.TextLength>0)
			{
				btEnregistre.Enabled=true;
			}
			else
				btEnregistre.Enabled=false;
		}


	}
}
