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
    /// Description résumée de ActiviteCli.
    /// </summary>
    public class ActiviteCli : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private int Agence;
        private MTGCComboBox mtgcComboBox1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private Opindus.DataSet1 dataSet11;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Windows.Forms.Button button2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private System.Windows.Forms.TextBox textBox1;
        private int Page;
        private int countRow;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private OleDbCommand Comm;
        private OleDbDataAdapter DataAD;
        private DataSet ds;
        private Decimal TotalPA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private int TotalReforme = 0;
        private int TotalControle = 0;
        private int TotalRep = 0;
        private int TotalGar = 0;
        private int TotalRefus = 0;
        private Decimal GeneralForfaitDNR = 0;
        private Decimal GeneralTotalCA = 0;
        private Decimal GeneralTotalPieces = 0;
        private bool PageEnCours = false;
        Decimal qteLigne = 0;
        Decimal MontantLigne = 0;
        Decimal TotalLigne = 0;
        Decimal TotalGenLigne = 0;
        Decimal TotalP = 0;
        Decimal Achat = 0;
        Decimal Vente = 0;
        Decimal qteLigne_vente = 0;
        Decimal MontantLigne_vente = 0;
        Decimal TotalLigne_vente = 0;
        Decimal TotalGenLigne_vente = 0;
        Decimal TotalP_vente = 0;
        Decimal Diff_achat = 0;
        Decimal Diff_vente = 0;
        int CptForun = 0;
        string fourn = "";
        int TotalCptFourn = 0;
        bool InBoucle = false;

        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ActiviteCli(int Agence)
        {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            DataAD = new OleDbDataAdapter();
            Comm = new OleDbCommand();
            Comm.Connection = oleDbConnection1;
            ds = new DataSet();

            Page = 0;
            countRow = 0;
            this.Agence = Agence;
            if (Agence.Equals(1))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }
            else if (Agence.Equals(2))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\
\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }
            else if (Agence.Equals(3))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Rouen\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }
            oleDbDataAdapter1.Fill(dataSet11);
            foreach (DataRow row in dataSet11.Tables["t_clients"].Rows)
            {
                mtgcComboBox1.Items.Add(new MTGCComboBoxItem(row["Nom"].ToString(), row["ident"].ToString(), row["Groupe"].ToString(), row["usine"].ToString()));
            }

            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.DefaultPageSettings.Margins.Bottom = 50;
            printPreviewDialog1.SetBounds(0, 0, 800, 600);
        }

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiviteCli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mtgcComboBox1 = new MTGCComboBox();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataSet11 = new Opindus.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activité clients";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Début";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fin";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(8, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(424, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Client selectionné";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(16, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Visualiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtgcComboBox1
            // 
            this.mtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.mtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtgcComboBox1.ColumnNum = 4;
            this.mtgcComboBox1.ColumnWidth = "250;50;50;50";
            this.mtgcComboBox1.DisplayMember = "Text";
            this.mtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.mtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.mtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.mtgcComboBox1.DropDownWidth = 420;
            this.mtgcComboBox1.Enabled = false;
            this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
            this.mtgcComboBox1.GridLineHorizontal = false;
            this.mtgcComboBox1.GridLineVertical = true;
            this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
            this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
            this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.mtgcComboBox1.Location = new System.Drawing.Point(8, 48);
            this.mtgcComboBox1.ManagingFastMouseMoving = true;
            this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
            this.mtgcComboBox1.Name = "mtgcComboBox1";
            this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
            this.mtgcComboBox1.Size = new System.Drawing.Size(424, 21);
            this.mtgcComboBox1.TabIndex = 0;
            this.mtgcComboBox1.TabStop = false;
            this.mtgcComboBox1.SelectedIndexChanged += new System.EventHandler(this.mtgcComboBox1_SelectedIndexChanged);
            this.mtgcComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtgcComboBox1_KeyDown);
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
            new System.Data.Common.DataTableMapping("Table", "T_clients", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Ident", "Ident"),
                        new System.Data.Common.DataColumnMapping("Nom", "Nom"),
                        new System.Data.Common.DataColumnMapping("Groupe", "Groupe"),
                        new System.Data.Common.DataColumnMapping("Usine", "Usine")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM T_clients WHERE (Ident = ?) AND (Groupe = ? OR ? IS NULL AND Groupe I" +
                "S NULL) AND (Nom = ? OR ? IS NULL AND Nom IS NULL) AND (Usine = ? OR ? IS NULL A" +
                "ND Usine IS NULL)";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ident", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usine", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO T_clients(Ident, Nom, Groupe, Usine) VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"),
            new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"),
            new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Ident, Nom, Groupe, Usine FROM T_clients ORDER BY Nom";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Ident", System.Data.OleDb.OleDbType.Integer, 0, "Ident"),
            new System.Data.OleDb.OleDbParameter("Nom", System.Data.OleDb.OleDbType.VarWChar, 30, "Nom"),
            new System.Data.OleDb.OleDbParameter("Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, "Groupe"),
            new System.Data.OleDb.OleDbParameter("Usine", System.Data.OleDb.OleDbType.VarWChar, 3, "Usine"),
            new System.Data.OleDb.OleDbParameter("Original_Ident", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ident", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Groupe", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Groupe1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Groupe", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Nom1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Usine", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usine", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Usine1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usine", System.Data.DataRowVersion.Original, null)});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("fr-FR");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(640, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Repare", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Valide", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = resources.GetString("oleDbInsertCommand2.CommandText");
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"),
            new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"),
            new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"),
            new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"),
            new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"),
            new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"),
            new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"),
            new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"),
            new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"),
            new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"),
            new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"),
            new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"),
            new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"),
            new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"),
            new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"),
            new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"),
            new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"),
            new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"),
            new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"),
            new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"),
            new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"),
            new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"),
            new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"),
            new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"),
            new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"),
            new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"),
            new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"),
            new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"),
            new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"),
            new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"),
            new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"),
            new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"),
            new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"),
            new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"),
            new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"),
            new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"),
            new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"),
            new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"),
            new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"),
            new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"),
            new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide")});
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = resources.GetString("oleDbSelectCommand2.CommandText");
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, "Accord Client"),
            new System.Data.OleDb.OleDbParameter("Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, "Calcul Auto"),
            new System.Data.OleDb.OleDbParameter("Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, "Cause atelier"),
            new System.Data.OleDb.OleDbParameter("Cause_client", System.Data.OleDb.OleDbType.Integer, 0, "Cause client"),
            new System.Data.OleDb.OleDbParameter("Code_Client", System.Data.OleDb.OleDbType.Integer, 0, "Code Client"),
            new System.Data.OleDb.OleDbParameter("Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, "Code Materiel"),
            new System.Data.OleDb.OleDbParameter("Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Commande generee"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.VarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.DBDate, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, "Date Decision"),
            new System.Data.OleDb.OleDbParameter("Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, "Date entree reelle"),
            new System.Data.OleDb.OleDbParameter("Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, "Date Generation commande"),
            new System.Data.OleDb.OleDbParameter("Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, "Date Reception pieces"),
            new System.Data.OleDb.OleDbParameter("Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, "Date reparation"),
            new System.Data.OleDb.OleDbParameter("Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail atelier"),
            new System.Data.OleDb.OleDbParameter("Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, "Detail Client"),
            new System.Data.OleDb.OleDbParameter("Edite", System.Data.OleDb.OleDbType.Boolean, 2, "Edite"),
            new System.Data.OleDb.OleDbParameter("edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, "edition_fax"),
            new System.Data.OleDb.OleDbParameter("Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, "Emplacement"),
            new System.Data.OleDb.OleDbParameter("Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, "Forfait Controle"),
            new System.Data.OleDb.OleDbParameter("Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, "Forfait DNR"),
            new System.Data.OleDb.OleDbParameter("Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, "Forfait transport"),
            new System.Data.OleDb.OleDbParameter("Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, "Imputation comptable"),
            new System.Data.OleDb.OleDbParameter("Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, "Limite Devis"),
            new System.Data.OleDb.OleDbParameter("Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, "Message Pieds"),
            new System.Data.OleDb.OleDbParameter("n__Bl", System.Data.OleDb.OleDbType.Integer, 0, "n° Bl"),
            new System.Data.OleDb.OleDbParameter("N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, "N° Commande generee"),
            new System.Data.OleDb.OleDbParameter("N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, "N° Commande ouverte"),
            new System.Data.OleDb.OleDbParameter("N__Devis", System.Data.OleDb.OleDbType.Integer, 0, "N° Devis"),
            new System.Data.OleDb.OleDbParameter("N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, "N° Troncon"),
            new System.Data.OleDb.OleDbParameter("Niveau", System.Data.OleDb.OleDbType.Integer, 0, "Niveau"),
            new System.Data.OleDb.OleDbParameter("Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, "Ordre Travail"),
            new System.Data.OleDb.OleDbParameter("Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, "Prix machine neuve"),
            new System.Data.OleDb.OleDbParameter("Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, "Prix Reference"),
            new System.Data.OleDb.OleDbParameter("Reforme", System.Data.OleDb.OleDbType.Boolean, 2, "Reforme"),
            new System.Data.OleDb.OleDbParameter("Refus", System.Data.OleDb.OleDbType.Boolean, 2, "Refus"),
            new System.Data.OleDb.OleDbParameter("Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_D"),
            new System.Data.OleDb.OleDbParameter("Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, "Reparateur_R"),
            new System.Data.OleDb.OleDbParameter("Repare", System.Data.OleDb.OleDbType.Boolean, 2, "Repare"),
            new System.Data.OleDb.OleDbParameter("Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, "Seuil Client"),
            new System.Data.OleDb.OleDbParameter("Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, "Seuil devis"),
            new System.Data.OleDb.OleDbParameter("Total_devis", System.Data.OleDb.OleDbType.Double, 0, "Total devis"),
            new System.Data.OleDb.OleDbParameter("Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, "Total devis euro"),
            new System.Data.OleDb.OleDbParameter("Total_pieces", System.Data.OleDb.OleDbType.Double, 0, "Total pieces"),
            new System.Data.OleDb.OleDbParameter("Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, "Type devis"),
            new System.Data.OleDb.OleDbParameter("Valide", System.Data.OleDb.OleDbType.Boolean, 2, "Valide"),
            new System.Data.OleDb.OleDbParameter("Original_N__Devis", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Accord_Client", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Accord Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Calcul_Auto", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Calcul Auto", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_atelier", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_atelier1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Cause_client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cause client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Client1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Materiel", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Code_Materiel1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Code Materiel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Commande_generee", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Commande_generee1", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Decision", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Decision1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Decision", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Generation_commande1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Generation commande", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_Reception_pieces1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date Reception pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_entree_reelle1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date entree reelle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reparation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Date_reparation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date reparation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_Client", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_Client1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_atelier", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Detail_atelier1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Detail atelier", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Edite", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Edite", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Emplacement", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Emplacement1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Emplacement", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_Controle1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait Controle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_DNR1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait DNR", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Forfait_transport1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Forfait transport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Imputation_comptable1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imputation comptable", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Limite_Devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Limite_Devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Limite Devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Message_Pieds", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Message_Pieds1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Message Pieds", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Niveau", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Niveau1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Niveau", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_generee1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande generee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Commande_ouverte", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Commande ouverte", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_N__Troncon", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N° Troncon", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Ordre_Travail", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ordre Travail", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Reference", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_Reference1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix Reference", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Prix_machine_neuve1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prix machine neuve", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reforme", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reforme", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Refus", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Refus", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_D", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_D1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_D", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_R", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Reparateur_R1", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Reparateur_R", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Repare", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Repare", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_Client", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_Client1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil Client", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Seuil_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Seuil devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_devis_euro1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total devis euro", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_pieces", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Total_pieces1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Total pieces", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_devis", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Type_devis1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Type devis", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Valide", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Valide", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_edition_fax", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "edition_fax", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_n__Bl", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_n__Bl1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "n° Bl", System.Data.DataRowVersion.Original, null)});
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(272, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
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
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(24, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(144, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(24, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Format de date incorrect";
            this.label5.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(136, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Imprimer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.mtgcComboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(256, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 120);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix de l\'impression";
            // 
            // radioButton3
            // 
            this.radioButton3.Checked = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(192, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Totalité synthèse";
            // 
            // radioButton1
            // 
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(80, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Client";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Checked = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(336, 192);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sans détail";
            // 
            // radioButton4
            // 
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(448, 192);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.Text = "Avec détail";
            // 
            // ActiviteCli
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(704, 240);
            this.ControlBox = false;
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ActiviteCli";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activité clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private void button2_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void mtgcComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13))
            {
                button1.Enabled = true;
                button3.Enabled = true;
                dataSet11.Tables["t_clients"].Clear();
                oleDbDataAdapter1.SelectCommand.CommandText = "select * from t_clients where nom='" + mtgcComboBox1.Text + "'";
                oleDbDataAdapter1.Fill(dataSet11);
                textBox3.Text = mtgcComboBox1.Text;
                textBox1.Text = dataSet11.Tables["t_clients"].Rows[0]["ident"].ToString();
                dataSet11.Tables["t_devis_entete"].Clear();
                oleDbDataAdapter2.SelectCommand.CommandText = "SELECT T_devis_entete.[n° devis], T_clients.Nom, T_devis_entete.[Total pieces], T_devis_entete.Reforme, T_devis_entete.Refus, T_devis_entete.Niveau, T_devis_entete.[Type devis], T_clients.Ident, T_devis_entete.[Date reparation], T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE T_devis_entete.Niveau>6 AND T_clients.Ident=" + textBox1.Text;
                try
                {
                    oleDbDataAdapter2.Fill(dataSet11);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                textBox2.Enabled = true;
                textBox4.Enabled = true;

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Page += 1;
            int ypos = e.MarginBounds.Top;
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(e.MarginBounds.Left, ypos), new Point(e.MarginBounds.Right, ypos));
            ypos += 15;
            e.Graphics.DrawString("Activité clients du " + textBox2.Text + " au " + textBox4.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 200, e.MarginBounds.Top);
            ypos += 30;
            e.Graphics.DrawString("Nom", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
            e.Graphics.DrawString("Ident", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 220, ypos);
            e.Graphics.DrawString("Contrôles", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 265, ypos);
            e.Graphics.DrawString("Garantie", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
            e.Graphics.DrawString("Réformées", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 430, ypos);
            e.Graphics.DrawString("Refusées", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 510, ypos);
            e.Graphics.DrawString("Réparations", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 590, ypos);
            e.Graphics.DrawString("Total", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 670, ypos);
            e.Graphics.DrawString("DNR", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 750, ypos);
            e.Graphics.DrawString("CA", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 830, ypos);
            e.Graphics.DrawString("Pièces", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 910, ypos);
            ypos += 15;
            e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(e.MarginBounds.Left, ypos), new Point(e.MarginBounds.Right, ypos));
            ypos += 20;
            if (radioButton4.Checked)
            {
                string ancienClient = "";
                string prochaineMachine = "";
                bool debut = true;
                PageEnCours = false;
                int CptReforme = 0;
                int CptControle = 0;
                int CptRep = 0;
                int CptGar = 0;
                int CptRefus = 0;
                CptForun = 0;
                int Ident = 0;
                Decimal ForfaitDNR = 0;
                Decimal TotalCA = 0;
                Decimal TotalPieces = 0;
                while (ypos < e.MarginBounds.Height && (countRow < ds.Tables["Clients"].Rows.Count) && (ds.Tables["Clients"].Rows.Count > 0))
                {
                    if (!debut)
                    {
                        try
                        {
                            ancienClient = ds.Tables["Clients"].Rows[countRow + 1]["Nom"].ToString();
                        }
                        catch
                        {
                            ancienClient = "";
                        }
                        try
                        {
                            prochaineMachine = ds.Tables["Clients"].Rows[countRow + 1]["Code machine Opindus"].ToString();
                        }
                        catch (Exception exp)
                        {
                        }
                    }

                    try
                    {
                        //if((System.Convert.ToDateTime(ds.Tables["Clients"].Rows[countRow]["Date reparation"].ToString())>=System.Convert.ToDateTime(textBox2.Text))&&(System.Convert.ToDateTime(ds.Tables["Clients"].Rows[countRow]["Date reparation"].ToString())<=System.Convert.ToDateTime(textBox4.Text)))
                        //{
                        if (ds.Tables["Clients"].Rows[countRow]["niveau"].ToString().Equals("9"))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptReforme += 1;
                            TotalReforme += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        if (ds.Tables["Clients"].Rows[countRow]["Type devis"].ToString().Equals("1"))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptRep += 1;
                            TotalRep += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        if (ds.Tables["Clients"].Rows[countRow]["Type devis"].ToString().Equals("2") && (System.Convert.ToInt32(ds.Tables["Clients"].Rows[countRow]["niveau"].ToString()).Equals(7)))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptGar += 1;
                            TotalGar += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        if (ds.Tables["Clients"].Rows[countRow]["Type devis"].ToString().Equals("3") && (System.Convert.ToInt32(ds.Tables["Clients"].Rows[countRow]["niveau"].ToString()).Equals(7)))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptControle += 1;
                            TotalControle += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        if (ds.Tables["Clients"].Rows[countRow]["niveau"].ToString().Equals("8"))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptRefus += 1;
                            TotalRefus += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        //}
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);
                    }

                    DateTime Debut = System.Convert.ToDateTime(textBox2.Text);
                    DateTime Fin = System.Convert.ToDateTime(textBox4.Text);

                    if (ancienClient != ds.Tables["Clients"].Rows[countRow]["Nom"].ToString() && !debut)
                    {
                        oleDbConnection1.Open();
                        Comm.Connection = oleDbConnection1;
                        Comm.CommandText = "SELECT SUM(T_devis_entete.[Forfait DNR]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            ForfaitDNR = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            ForfaitDNR = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total devis]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalCA = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalCA = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total pieces]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalPieces = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalPieces = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptRep = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRep = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=8) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptRefus = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRefus = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=9) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptReforme = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptReforme = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='3')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptControle = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptControle = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='2')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptGar = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptGar = 0;
                        }

                        oleDbConnection1.Close();

                        int total = CptReforme + CptControle + CptRep + CptRefus + CptGar;
                        e.Graphics.DrawString(ds.Tables["Clients"].Rows[countRow]["Ident"].ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 220, ypos);
                        e.Graphics.DrawString(CptReforme.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 430, ypos);
                        e.Graphics.DrawString(CptGar.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                        e.Graphics.DrawString(CptControle.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 265, ypos);
                        e.Graphics.DrawString(CptRep.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 590, ypos);
                        e.Graphics.DrawString(CptRefus.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 510, ypos);
                        e.Graphics.DrawString(ForfaitDNR.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 750, ypos);
                        e.Graphics.DrawString(TotalCA.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 830, ypos);
                        e.Graphics.DrawString(TotalPieces.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 910, ypos);
                        e.Graphics.DrawString(total.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 670, ypos);
                        e.Graphics.DrawString(ds.Tables["Clients"].Rows[countRow]["Nom"].ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                        Ident = System.Convert.ToInt32(ds.Tables["Clients"].Rows[countRow]["Ident"].ToString());
                        CptReforme = 0;
                        CptControle = 0;
                        CptRep = 0;
                        CptGar = 0;
                        CptRefus = 0;
                        TotalCA = 0;
                        TotalPieces = 0;
                        ForfaitDNR = 0;
                        ypos += 50;
                        e.Graphics.DrawString("Détail",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                        e.Graphics.DrawString("Fournisseur",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 210, ypos);
                        e.Graphics.DrawString("Prix de vente",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                        e.Graphics.DrawString("Prix d'achat",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 600, ypos);
                        e.Graphics.DrawString("Marge",
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                        ypos += 20;




                        if (!PageEnCours)
                        {
                            PageEnCours = true;
                            //Comm.CommandText = "SELECT T_fournisseurs.Nom, Sum(T_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_devis_lignes.Quantite, T_pieces_detachees.[Prix Achat Net] FROM (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON T_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6) AND ((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ")) GROUP BY T_fournisseurs.Nom, T_devis_lignes.Quantite, T_pieces_detachees.[Prix Achat Net] ORDER BY T_fournisseurs.Nom";
                            Comm.CommandText = "SELECT T_clients.Ident, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus], T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_lignes.Quantite, T_pieces_detachees.[Prix achat net], T_devis_lignes.[Prix de vente] FROM (T_type_machine INNER JOIN (T_pieces_detachees INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_fournisseurs ON T_pieces_detachees.[Code Fournisseur Principal] = T_fournisseurs.Code WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7)) AND ((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                            if (mtgcComboBox1.SelectedIndex > 0)
                            {
                                MTGCComboBoxItem Item = (MTGCComboBoxItem)mtgcComboBox1.SelectedItem;
                                Comm.CommandText += " AND T_devis_entete.[Code client]=" + Item.Col2;
                            }
                            Comm.CommandText += " ORDER BY T_fournisseurs.Nom ASC";
                            DataAD.SelectCommand = Comm;
                            DataAD.Fill(ds, "Detail");
                            try
                            {
                                fourn = ds.Tables["Detail"].Rows[0]["nom"].ToString();
                            }
                            catch
                            {
                            }
                            TotalCptFourn = ds.Tables["Detail"].Rows.Count;
                        }

                        bool deb = true;
                        bool next = true;

                        if (TotalCptFourn > 0)
                        {
                            for (; CptForun <= TotalCptFourn; )
                            {
                                InBoucle = true;
                                if (CptForun < TotalCptFourn)
                                {
                                    if ((ds.Tables["Detail"].Rows[CptForun]["nom"].ToString()) != fourn || CptForun.Equals(TotalCptFourn))
                                    {
                                        try
                                        {

                                            e.Graphics.DrawString(fourn,
                                                new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 210, ypos);


                                            /*try
                                            {
                                                oleDbConnection1.Open();
                                                Comm.CommandText = "SELECT Sum(T_devis_entete.[Total pieces]) AS [SommeDeTotal pieces] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6) AND ((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ")) AND T_fournisseurs.Nom='" + fourn.Replace("'", "''") + "'";
                                                TotalP = System.Convert.ToDecimal(Comm.ExecuteScalar());
                                                oleDbConnection1.Close();

                                                e.Graphics.DrawString(TotalP.ToString("0.00"),
                                                new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 500, ypos);

                                                Vente += System.Convert.ToDecimal(TotalP);
                                            }
                                            catch (Exception exp)
                                            {
                                            }*/

                                            Achat += TotalGenLigne;
                                            Vente += TotalGenLigne_vente;

                                            try
                                            {
                                                Diff_achat = TotalGenLigne_vente - TotalGenLigne;
                                            }
                                            catch
                                            {
                                            }

                                            e.Graphics.DrawString(TotalGenLigne.ToString("0.00"),
                                                new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 600, ypos);

                                            e.Graphics.DrawString(TotalGenLigne_vente.ToString("0.00"),
                                                new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 500, ypos);

                                            e.Graphics.DrawString(Diff_achat.ToString("0.00"),
                                               new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 700, ypos);

                                            try
                                            {
                                                TotalGenLigne = 0;
                                                qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                                MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                                TotalLigne = qteLigne * MontantLigne;
                                                TotalGenLigne += TotalLigne;

                                                TotalGenLigne_vente = 0;
                                                qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                                MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                                TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                                TotalGenLigne_vente += TotalLigne_vente;

                                            }
                                            catch
                                            {
                                            }

                                            /*Decimal Difference = TotalP - TotalGenLigne;

                                            e.Graphics.DrawString(Difference.ToString("0.00"),
                                                new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 700, ypos);*/


                                        }
                                        catch (Exception exp)
                                        {

                                        }

                                        fourn = ds.Tables["Detail"].Rows[CptForun]["nom"].ToString();
                                        CptForun++;

                                        if (ypos < e.MarginBounds.Height - 100)
                                        {
                                            ypos += 20;
                                            next = true;
                                        }
                                        else
                                        {
                                            ypos += 20;
                                            next = false;
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        try
                                        {
                                            qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                            MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                            TotalLigne = qteLigne * MontantLigne;
                                            TotalGenLigne += TotalLigne;

                                            qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                            MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                            TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                            TotalGenLigne_vente += TotalLigne_vente;
                                        }
                                        catch (Exception exp)
                                        {
                                        }
                                        fourn = ds.Tables["Detail"].Rows[CptForun]["nom"].ToString();
                                        CptForun++;
                                    }

                                }
                                else
                                {
                                    CptForun -= 1;

                                    e.Graphics.DrawString(fourn,
                                        new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 210, ypos);


                                    /*try
                                    {
                                        oleDbConnection1.Open();
                                        Comm.CommandText = "SELECT Sum(T_devis_entete.[Total pieces]) AS [SommeDeTotal pieces] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN T_devis_entete ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6) AND ((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ")) AND T_fournisseurs.Nom='" + fourn.Replace("'", "''") + "'";
                                        TotalP = System.Convert.ToDecimal(Comm.ExecuteScalar());
                                        oleDbConnection1.Close();

                                        e.Graphics.DrawString(TotalP.ToString("0.00"),
                                        new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 500, ypos);

                                        Vente += System.Convert.ToDecimal(TotalP);
                                    }
                                    catch (Exception exp)
                                    {
                                    }*/

                                    Achat += TotalGenLigne;
                                    Vente += TotalGenLigne_vente;

                                    try
                                    {
                                        Diff_achat = TotalGenLigne_vente - TotalGenLigne;
                                    }
                                    catch
                                    {
                                    }

                                    e.Graphics.DrawString(TotalGenLigne.ToString("0.00"),
                                        new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 600, ypos);

                                    e.Graphics.DrawString(TotalGenLigne_vente.ToString("0.00"),
                                        new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 500, ypos);

                                    e.Graphics.DrawString(Diff_achat.ToString("0.00"),
                                               new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                                    try
                                    {
                                        qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                        MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                        TotalLigne = qteLigne * MontantLigne;
                                        TotalGenLigne += TotalLigne;

                                        qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                        MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                        TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                        TotalGenLigne_vente += TotalLigne_vente;

                                    }
                                    catch (Exception exp)
                                    {
                                    }
                                    ypos += 20;
                                    TotalGenLigne = 0;
                                    TotalGenLigne_vente = 0;
                                    break;
                                    /*Decimal Difference = TotalP - TotalGenLigne;

                                    e.Graphics.DrawString(Difference.ToString("0.00"),
                                        new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 700, ypos);*/
                                }
                            }
                            InBoucle = false;
                        }
                        if (next)
                        {
                            ds.Tables["Detail"].Clear();
                            e.Graphics.DrawString("Total PV",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                            e.Graphics.DrawString("Total PA",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 600, ypos);
                            e.Graphics.DrawString("Total Marge",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                            ypos += 25;
                            Decimal Diff = 0;
                            try
                            {
                                Diff = Vente - Achat;
                            }
                            catch
                            {
                                Diff = 0;
                            }
                            e.Graphics.DrawString(Vente.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                            e.Graphics.DrawString(Achat.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 600, ypos);
                            e.Graphics.DrawString(Diff.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                            e.Graphics.DrawString(DateTime.Now.ToLongDateString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom);
                            e.Graphics.DrawString("Page " + Page.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right - 50, e.MarginBounds.Bottom);

                            PageEnCours = false;
                            qteLigne = 0;
                            MontantLigne = 0;
                            TotalLigne = 0;
                            TotalGenLigne = 0;
                            TotalP = 0;
                            Achat = 0;
                            Vente = 0;
                            CptForun = 0;
                            TotalCptFourn = 0;

                            ypos += 20;
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(e.MarginBounds.Left, ypos), new Point(e.MarginBounds.Right, ypos));
                            ypos += 10;
                            break;
                        }

                    }
                    else
                    {
                        if (countRow.Equals(0))
                        {
                            /*oleDbConnection1.Open();
                            Comm.Connection = oleDbConnection1;
                            Comm.CommandText = "SELECT SUM(T_devis_entete.[Forfait DNR]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                            try
                            {
                                ForfaitDNR = System.Convert.ToDecimal(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                ForfaitDNR = 0;
                            }

                            Comm.CommandText = "SELECT SUM(T_devis_entete.[total devis]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                            try
                            {
                                TotalCA = System.Convert.ToDecimal(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                TotalCA = 0;
                            }

                            Comm.CommandText = "SELECT SUM(T_devis_entete.[total pieces]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                            try
                            {
                                TotalPieces = System.Convert.ToDecimal(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                TotalPieces = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptRep = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptRep = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=8) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptRefus = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptRefus = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=9) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptReforme = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptReforme = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='3')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptControle = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptControle = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='2')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptGar = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptGar = 0;
                            }

                            oleDbConnection1.Close();

                            int total = CptReforme + CptControle + CptRep + CptRefus + CptGar;
                            e.Graphics.DrawString(ds.Tables["Clients"].Rows[countRow]["Ident"].ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 220, ypos);
                            e.Graphics.DrawString(CptReforme.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 430, ypos);
                            e.Graphics.DrawString(CptGar.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                            e.Graphics.DrawString(CptControle.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 265, ypos);
                            e.Graphics.DrawString(CptRep.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 590, ypos);
                            e.Graphics.DrawString(CptRefus.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 510, ypos);
                            e.Graphics.DrawString(ForfaitDNR.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 750, ypos);
                            e.Graphics.DrawString(TotalCA.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 830, ypos);
                            e.Graphics.DrawString(TotalPieces.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 910, ypos);
                            e.Graphics.DrawString(total.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 670, ypos);
                            e.Graphics.DrawString(ds.Tables["Clients"].Rows[countRow]["Nom"].ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                            Ident = System.Convert.ToInt32(ds.Tables["Clients"].Rows[countRow]["Ident"].ToString());
                            CptReforme = 0;
                            CptControle = 0;
                            CptRep = 0;
                            CptGar = 0;
                            CptRefus = 0;
                            TotalCA = 0;
                            TotalPieces = 0;
                            ForfaitDNR = 0;
                            ypos += 50;
                            e.Graphics.DrawString("Détail",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                            e.Graphics.DrawString("Fournisseur",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 210, ypos);
                            e.Graphics.DrawString("Prix de vente",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                            e.Graphics.DrawString("Prix d'achat",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 600, ypos);
                            e.Graphics.DrawString("Marge",
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                            ypos += 20;




                            if (!PageEnCours)
                            {
                                PageEnCours = true;
                                //Comm.CommandText = "SELECT T_fournisseurs.Nom, Sum(T_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_devis_lignes.Quantite, T_pieces_detachees.[Prix Achat Net] FROM (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON T_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6) AND ((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ")) GROUP BY T_fournisseurs.Nom, T_devis_lignes.Quantite, T_pieces_detachees.[Prix Achat Net] ORDER BY T_fournisseurs.Nom";
                                Comm.CommandText = "SELECT T_clients.Ident, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus], T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_lignes.Quantite, T_pieces_detachees.[Prix achat net], T_devis_lignes.[Prix de vente] FROM (T_type_machine INNER JOIN (T_pieces_detachees INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_fournisseurs ON T_pieces_detachees.[Code Fournisseur Principal] = T_fournisseurs.Code WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7)) AND ((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                                if (mtgcComboBox1.SelectedIndex > 0)
                                {
                                    MTGCComboBoxItem Item = (MTGCComboBoxItem)mtgcComboBox1.SelectedItem;
                                    Comm.CommandText += " AND T_devis_entete.[Code client]=" + Item.Col2;
                                }
                                Comm.CommandText += " ORDER BY T_fournisseurs.Nom ASC";
                                DataAD.SelectCommand = Comm;
                                DataAD.Fill(ds, "Detail");
                                try
                                {
                                    fourn = ds.Tables["Detail"].Rows[0]["nom"].ToString();
                                }
                                catch
                                {
                                }
                                TotalCptFourn = ds.Tables["Detail"].Rows.Count;
                            }

                            bool deb = true;
                            bool next = true;

                            if (TotalCptFourn > 0)
                            {
                                for (; CptForun <= TotalCptFourn; )
                                {
                                    InBoucle = true;
                                    if (CptForun < TotalCptFourn)
                                    {
                                        if ((ds.Tables["Detail"].Rows[CptForun]["nom"].ToString()) != fourn || CptForun.Equals(TotalCptFourn))
                                        {
                                            try
                                            {

                                                e.Graphics.DrawString(fourn,
                                                    new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 210, ypos);



                                                Achat += TotalGenLigne;
                                                Vente += TotalGenLigne_vente;

                                                try
                                                {
                                                    Diff_achat = TotalGenLigne_vente - TotalGenLigne;
                                                }
                                                catch
                                                {
                                                }

                                                e.Graphics.DrawString(TotalGenLigne.ToString("0.00"),
                                                    new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 600, ypos);

                                                e.Graphics.DrawString(TotalGenLigne_vente.ToString("0.00"),
                                                    new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 500, ypos);

                                                e.Graphics.DrawString(Diff_achat.ToString("0.00"),
                                                   new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 700, ypos);

                                                try
                                                {
                                                    TotalGenLigne = 0;
                                                    qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                                    MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                                    TotalLigne = qteLigne * MontantLigne;
                                                    TotalGenLigne += TotalLigne;

                                                    TotalGenLigne_vente = 0;
                                                    qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                                    MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                                    TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                                    TotalGenLigne_vente += TotalLigne_vente;

                                                }
                                                catch
                                                {
                                                }



                                            }
                                            catch (Exception exp)
                                            {

                                            }

                                            fourn = ds.Tables["Detail"].Rows[CptForun]["nom"].ToString();
                                            CptForun++;

                                            if (ypos < e.MarginBounds.Height - 100)
                                            {
                                                ypos += 20;
                                                next = true;
                                            }
                                            else
                                            {
                                                ypos += 20;
                                                next = false;
                                                break;
                                            }

                                        }
                                        else
                                        {
                                            try
                                            {
                                                qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                                MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                                TotalLigne = qteLigne * MontantLigne;
                                                TotalGenLigne += TotalLigne;

                                                qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                                MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                                TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                                TotalGenLigne_vente += TotalLigne_vente;
                                            }
                                            catch (Exception exp)
                                            {
                                            }
                                            fourn = ds.Tables["Detail"].Rows[CptForun]["nom"].ToString();
                                            CptForun++;
                                        }

                                    }
                                    else
                                    {
                                        CptForun -= 1;

                                        e.Graphics.DrawString(fourn,
                                            new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 210, ypos);



                                        Achat += TotalGenLigne;
                                        Vente += TotalGenLigne_vente;

                                        try
                                        {
                                            Diff_achat = TotalGenLigne_vente - TotalGenLigne;
                                        }
                                        catch
                                        {
                                        }

                                        e.Graphics.DrawString(TotalGenLigne.ToString("0.00"),
                                            new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 600, ypos);

                                        e.Graphics.DrawString(TotalGenLigne_vente.ToString("0.00"),
                                            new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 500, ypos);

                                        e.Graphics.DrawString(Diff_achat.ToString("0.00"),
                                                   new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                                        try
                                        {
                                            qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                            MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                            TotalLigne = qteLigne * MontantLigne;
                                            TotalGenLigne += TotalLigne;

                                            qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                            MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                            TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                            TotalGenLigne_vente += TotalLigne_vente;

                                        }
                                        catch (Exception exp)
                                        {
                                        }
                                        ypos += 20;
                                        TotalGenLigne = 0;
                                        TotalGenLigne_vente = 0;
                                        break;

                                    }
                                }
                                InBoucle = false;
                            }
                            if (next)
                            {
                                ds.Tables["Detail"].Clear();
                                e.Graphics.DrawString("Total PV",
                                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                                e.Graphics.DrawString("Total PA",
                                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 600, ypos);
                                e.Graphics.DrawString("Total Marge",
                                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                                ypos += 25;
                                Decimal Diff = 0;
                                try
                                {
                                    Diff = Vente - Achat;
                                }
                                catch
                                {
                                    Diff = 0;
                                }
                                e.Graphics.DrawString(Vente.ToString("0.00"),
                                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                                e.Graphics.DrawString(Achat.ToString("0.00"),
                                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 600, ypos);
                                e.Graphics.DrawString(Diff.ToString("0.00"),
                                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                                e.Graphics.DrawString(DateTime.Now.ToLongDateString(),
                                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom);
                                e.Graphics.DrawString("Page " + Page.ToString(),
                                    new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right - 50, e.MarginBounds.Bottom);

                                PageEnCours = false;
                                qteLigne = 0;
                                MontantLigne = 0;
                                TotalLigne = 0;
                                TotalGenLigne = 0;
                                TotalP = 0;
                                Achat = 0;
                                Vente = 0;
                                CptForun = 0;
                                TotalCptFourn = 0;

                                ypos += 20;
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(e.MarginBounds.Left, ypos), new Point(e.MarginBounds.Right, ypos));
                                ypos += 10;
                                countRow += 1;
                                debut = false;
                                break;
                            }*/
                        }
                    }
                    countRow += 1;
                    debut = false;
                }

                if (countRow < ds.Tables["Clients"].Rows.Count)
                    e.HasMorePages = true;
                else
                {
                    DateTime Debut = System.Convert.ToDateTime(textBox2.Text);
                    DateTime Fin = System.Convert.ToDateTime(textBox4.Text);

                    if (radioButton1.Checked)
                    {
                        oleDbConnection1.Open();
                        Comm.Connection = oleDbConnection1;
                        Comm.CommandText = "SELECT SUM(T_devis_entete.[Forfait DNR]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            ForfaitDNR = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            ForfaitDNR = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total devis]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalCA = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalCA = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total pieces]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalPieces = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalPieces = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptRep = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRep = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=8) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptRefus = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRefus = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=9) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptReforme = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptReforme = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='3'))";
                        try
                        {
                            CptControle = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptControle = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='2'))";
                        try
                        {
                            CptGar = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptGar = 0;
                        }

                        oleDbConnection1.Close();
                    }
                    else
                    {
                        oleDbConnection1.Open();
                        Comm.Connection = oleDbConnection1;
                        Comm.CommandText = "SELECT SUM(T_devis_entete.[Forfait DNR]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            ForfaitDNR = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            ForfaitDNR = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total devis]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalCA = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalCA = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total pieces]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalPieces = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalPieces = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptRep = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRep = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=8) AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptRefus = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRefus = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=9) AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptReforme = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptReforme = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='3'))";
                        try
                        {
                            CptControle = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptControle = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='2'))";
                        try
                        {
                            CptGar = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptGar = 0;
                        }

                        oleDbConnection1.Close();
                    }

                    int total = CptReforme + CptControle + CptRep + CptRefus + CptGar;
                    e.Graphics.DrawString("Total clients",
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 150, ypos);
                    e.Graphics.DrawString(CptReforme.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 430, ypos);
                    e.Graphics.DrawString(CptGar.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                    e.Graphics.DrawString(CptControle.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 265, ypos);
                    e.Graphics.DrawString(CptRep.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 590, ypos);
                    e.Graphics.DrawString(CptRefus.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 510, ypos);
                    e.Graphics.DrawString(ForfaitDNR.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 750, ypos);
                    e.Graphics.DrawString(TotalCA.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 830, ypos);
                    e.Graphics.DrawString(TotalPieces.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 910, ypos);
                    e.Graphics.DrawString(total.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 670, ypos);

                    e.HasMorePages = false;
                    countRow = 0;
                    Page = 0;
                }
            }
            else
            {
                string ancienClient = "";
                string prochaineMachine = "";
                bool debut = true;
                int CptReforme = 0;
                int CptControle = 0;
                int CptRep = 0;
                int CptGar = 0;
                CptForun = 0;
                PageEnCours = false;
                int CptRefus = 0;
                int Ident = 0;
                Decimal ForfaitDNR = 0;
                Decimal TotalCA = 0;
                Decimal TotalPieces = 0;
                while (ypos < e.MarginBounds.Height && (countRow < ds.Tables["Clients"].Rows.Count) && (ds.Tables["Clients"].Rows.Count > 0))
                {
                    if (!debut)
                    {
                        try
                        {
                            ancienClient = ds.Tables["Clients"].Rows[countRow + 1]["Nom"].ToString();
                        }
                        catch
                        {
                            ancienClient = "";
                        }
                        try
                        {
                            prochaineMachine = ds.Tables["Clients"].Rows[countRow + 1]["Code machine Opindus"].ToString();
                        }
                        catch (Exception exp)
                        {
                        }
                    }

                    try
                    {
                        //if((System.Convert.ToDateTime(ds.Tables["Clients"].Rows[countRow]["Date reparation"].ToString())>=System.Convert.ToDateTime(textBox2.Text))&&(System.Convert.ToDateTime(ds.Tables["Clients"].Rows[countRow]["Date reparation"].ToString())<=System.Convert.ToDateTime(textBox4.Text)))
                        //{
                        if (ds.Tables["Clients"].Rows[countRow]["niveau"].ToString().Equals("9"))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptReforme += 1;
                            TotalReforme += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        if (ds.Tables["Clients"].Rows[countRow]["Type devis"].ToString().Equals("1"))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptRep += 1;
                            TotalRep += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        if (ds.Tables["Clients"].Rows[countRow]["Type devis"].ToString().Equals("2") && (System.Convert.ToInt32(ds.Tables["Clients"].Rows[countRow]["niveau"].ToString()).Equals(7)))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptGar += 1;
                            TotalGar += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        if (ds.Tables["Clients"].Rows[countRow]["Type devis"].ToString().Equals("3") && (System.Convert.ToInt32(ds.Tables["Clients"].Rows[countRow]["niveau"].ToString()).Equals(7)))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptControle += 1;
                            TotalControle += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        if (ds.Tables["Clients"].Rows[countRow]["niveau"].ToString().Equals("8"))
                        {
                            //if (prochaineMachine != ds.Tables["Clients"].Rows[countRow]["Code machine opindus"].ToString())
                            //{
                            CptRefus += 1;
                            TotalRefus += 1;
                            //}
                            /*ForfaitDNR+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Forfait DNR"].ToString());
                            TotalCA+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total Devis"].ToString());
                            TotalPieces+=System.Convert.ToDecimal(ds.Tables["Clients"].Rows[countRow]["Total pieces"].ToString());*/
                        }
                        //}
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);
                    }

                    DateTime Debut = System.Convert.ToDateTime(textBox2.Text);
                    DateTime Fin = System.Convert.ToDateTime(textBox4.Text);

                    if (ancienClient != ds.Tables["Clients"].Rows[countRow]["Nom"].ToString() && !debut)
                    {
                        oleDbConnection1.Open();
                        Comm.Connection = oleDbConnection1;
                        Comm.CommandText = "SELECT SUM(T_devis_entete.[Forfait DNR]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            ForfaitDNR = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            ForfaitDNR = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total devis]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalCA = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalCA = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total pieces]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalPieces = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalPieces = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptRep = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRep = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=8) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptRefus = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRefus = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=9) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptReforme = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptReforme = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='3')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptControle = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptControle = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='2')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                        try
                        {
                            CptGar = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptGar = 0;
                        }

                        oleDbConnection1.Close();

                        int total = CptReforme + CptControle + CptRep + CptRefus + CptGar;
                        e.Graphics.DrawString(ds.Tables["Clients"].Rows[countRow]["Ident"].ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 220, ypos);
                        e.Graphics.DrawString(CptReforme.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 430, ypos);
                        e.Graphics.DrawString(CptGar.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                        e.Graphics.DrawString(CptControle.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 265, ypos);
                        e.Graphics.DrawString(CptRep.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 590, ypos);
                        e.Graphics.DrawString(CptRefus.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 510, ypos);
                        e.Graphics.DrawString(ForfaitDNR.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 750, ypos);
                        e.Graphics.DrawString(TotalCA.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 830, ypos);
                        e.Graphics.DrawString(TotalPieces.ToString("0.00"),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 910, ypos);
                        e.Graphics.DrawString(total.ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 670, ypos);
                        e.Graphics.DrawString(ds.Tables["Clients"].Rows[countRow]["Nom"].ToString(),
                            new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                        Ident = System.Convert.ToInt32(ds.Tables["Clients"].Rows[countRow]["Ident"].ToString());
                        CptReforme = 0;
                        CptControle = 0;
                        CptRep = 0;
                        CptGar = 0;
                        CptRefus = 0;
                        TotalCA = 0;
                        TotalPieces = 0;
                        ForfaitDNR = 0;
                        ypos += 30;


                    }
                    else
                    {
                        if (countRow.Equals(0))
                        {
                            /*oleDbConnection1.Open();
                            Comm.Connection = oleDbConnection1;
                            Comm.CommandText = "SELECT SUM(T_devis_entete.[Forfait DNR]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                            try
                            {
                                ForfaitDNR = System.Convert.ToDecimal(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                ForfaitDNR = 0;
                            }

                            Comm.CommandText = "SELECT SUM(T_devis_entete.[total devis]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                            try
                            {
                                TotalCA = System.Convert.ToDecimal(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                TotalCA = 0;
                            }

                            Comm.CommandText = "SELECT SUM(T_devis_entete.[total pieces]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                            try
                            {
                                TotalPieces = System.Convert.ToDecimal(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                TotalPieces = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptRep = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptRep = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=8) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptRefus = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptRefus = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=9) AND ((T_devis_entete.[Type devis])='1')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptReforme = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptReforme = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='3')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptControle = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptControle = 0;
                            }

                            Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='2')) AND (((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + "))";
                            try
                            {
                                CptGar = System.Convert.ToInt32(Comm.ExecuteScalar());
                            }
                            catch (Exception exp)
                            {
                                CptGar = 0;
                            }

                            oleDbConnection1.Close();

                            int total = CptReforme + CptControle + CptRep + CptRefus + CptGar;
                            e.Graphics.DrawString(ds.Tables["Clients"].Rows[countRow]["Ident"].ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 220, ypos);
                            e.Graphics.DrawString(CptReforme.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 430, ypos);
                            e.Graphics.DrawString(CptGar.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                            e.Graphics.DrawString(CptControle.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 265, ypos);
                            e.Graphics.DrawString(CptRep.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 590, ypos);
                            e.Graphics.DrawString(CptRefus.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 510, ypos);
                            e.Graphics.DrawString(ForfaitDNR.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 750, ypos);
                            e.Graphics.DrawString(TotalCA.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 830, ypos);
                            e.Graphics.DrawString(TotalPieces.ToString("0.00"),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 910, ypos);
                            e.Graphics.DrawString(total.ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 670, ypos);
                            e.Graphics.DrawString(ds.Tables["Clients"].Rows[countRow]["Nom"].ToString(),
                                new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, ypos);
                            Ident = System.Convert.ToInt32(ds.Tables["Clients"].Rows[countRow]["Ident"].ToString());
                            CptReforme = 0;
                            CptControle = 0;
                            CptRep = 0;
                            CptGar = 0;
                            CptRefus = 0;
                            TotalCA = 0;
                            TotalPieces = 0;
                            ForfaitDNR = 0;
                            ypos += 30;*/
                        }
                    }
                    countRow += 1;
                    debut = false;
                }

                if (countRow < ds.Tables["Clients"].Rows.Count)
                    e.HasMorePages = true;
                else
                {
                    DateTime Debut = System.Convert.ToDateTime(textBox2.Text);
                    DateTime Fin = System.Convert.ToDateTime(textBox4.Text);

                    if (radioButton1.Checked)
                    {
                        oleDbConnection1.Open();
                        Comm.Connection = oleDbConnection1;
                        Comm.CommandText = "SELECT SUM(T_devis_entete.[Forfait DNR]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            ForfaitDNR = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            ForfaitDNR = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total devis]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalCA = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalCA = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total pieces]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalPieces = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalPieces = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptRep = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRep = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=8) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptRefus = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRefus = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=9) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptReforme = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptReforme = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='3'))";
                        try
                        {
                            CptControle = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptControle = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND (T_devis_entete.[Code Client]=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ")  AND ((T_devis_entete.[Type devis])='2'))";
                        try
                        {
                            CptGar = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptGar = 0;
                        }

                        oleDbConnection1.Close();
                    }
                    else
                    {
                        oleDbConnection1.Open();
                        Comm.Connection = oleDbConnection1;
                        Comm.CommandText = "SELECT SUM(T_devis_entete.[Forfait DNR]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            ForfaitDNR = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            ForfaitDNR = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total devis]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalCA = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalCA = 0;
                        }

                        Comm.CommandText = "SELECT SUM(T_devis_entete.[total pieces]) FROM T_devis_entete WHERE (T_devis_entete.[Date reparation]>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "#) And (T_devis_entete.[Date reparation]<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND (T_devis_entete.Niveau>6) AND (T_devis_entete.[Type devis]='1')";
                        try
                        {
                            TotalPieces = System.Convert.ToDecimal(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            TotalPieces = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptRep = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRep = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=8) AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptRefus = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptRefus = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=9) AND ((T_devis_entete.[Type devis])='1'))";
                        try
                        {
                            CptReforme = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptReforme = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='3'))";
                        try
                        {
                            CptControle = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptControle = 0;
                        }

                        Comm.CommandText = "SELECT Count(T_devis_entete.[N° Devis]) AS [CompteDeN° Devis] FROM T_devis_entete WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7) AND ((T_devis_entete.[Type devis])='2'))";
                        try
                        {
                            CptGar = System.Convert.ToInt32(Comm.ExecuteScalar());
                        }
                        catch (Exception exp)
                        {
                            CptGar = 0;
                        }

                        oleDbConnection1.Close();
                    }
                    ypos += 20;
                    int total = CptReforme + CptControle + CptRep + CptRefus + CptGar;
                    e.Graphics.DrawString("Total clients",
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 150, ypos);
                    e.Graphics.DrawString(CptReforme.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 430, ypos);
                    e.Graphics.DrawString(CptGar.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 350, ypos);
                    e.Graphics.DrawString(CptControle.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 265, ypos);
                    e.Graphics.DrawString(CptRep.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 590, ypos);
                    e.Graphics.DrawString(CptRefus.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 510, ypos);
                    e.Graphics.DrawString(ForfaitDNR.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 750, ypos);
                    e.Graphics.DrawString(TotalCA.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 830, ypos);
                    e.Graphics.DrawString(TotalPieces.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 910, ypos);
                    e.Graphics.DrawString(total.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 670, ypos);

                    ypos += 30;

                    PageEnCours = true;
                    //Comm.CommandText = "SELECT T_fournisseurs.Nom, Sum(T_devis_lignes.[Total ligne]) AS [SommeDeTotal ligne], T_devis_lignes.Quantite, T_pieces_detachees.[Prix Achat Net] FROM (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) INNER JOIN (T_fournisseurs INNER JOIN T_pieces_detachees ON T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) ON T_devis_lignes.[Code piece] = T_pieces_detachees.Identificateur WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6) AND ((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow]["Ident"].ToString() + ")) GROUP BY T_fournisseurs.Nom, T_devis_lignes.Quantite, T_pieces_detachees.[Prix Achat Net] ORDER BY T_fournisseurs.Nom";
                    if (radioButton3.Checked)
                        Comm.CommandText = "SELECT T_clients.Ident, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus], T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_lignes.Quantite, T_pieces_detachees.[Prix achat net], T_devis_lignes.[Prix de vente] FROM (T_type_machine INNER JOIN (T_pieces_detachees INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_fournisseurs ON T_pieces_detachees.[Code Fournisseur Principal] = T_fournisseurs.Code WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7)) AND (T_devis_entete.[Type devis]='1')";
                    else
                        Comm.CommandText = "SELECT T_clients.Ident, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus], T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_lignes.Quantite, T_pieces_detachees.[Prix achat net], T_devis_lignes.[Prix de vente] FROM (T_type_machine INNER JOIN (T_pieces_detachees INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) INNER JOIN T_fournisseurs ON T_pieces_detachees.[Code Fournisseur Principal] = T_fournisseurs.Code WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)=7)) AND ((T_devis_entete.[Code Client])=" + ds.Tables["Clients"].Rows[countRow - 1]["Ident"].ToString() + ") AND (T_devis_entete.[Type devis]='1')";
                    if (mtgcComboBox1.SelectedIndex > 0)
                    {
                        MTGCComboBoxItem Item = (MTGCComboBoxItem)mtgcComboBox1.SelectedItem;
                        Comm.CommandText += " AND T_devis_entete.[Code client]=" + Item.Col2;
                    }
                    Comm.CommandText += " ORDER BY T_fournisseurs.Nom ASC";
                    DataAD.SelectCommand = Comm;
                    DataAD.Fill(ds, "Detail");
                    try
                    {
                        fourn = ds.Tables["Detail"].Rows[0]["nom"].ToString();
                    }
                    catch
                    {
                    }
                    TotalCptFourn = ds.Tables["Detail"].Rows.Count;

                    bool deb = true;

                    if (TotalCptFourn > 0)
                    {
                        for (; CptForun <= TotalCptFourn; )
                        {
                            InBoucle = true;
                            if (CptForun < TotalCptFourn)
                            {
                                if ((ds.Tables["Detail"].Rows[CptForun]["nom"].ToString()) != fourn || CptForun.Equals(TotalCptFourn))
                                {
                                    try
                                    {

                                        Achat += TotalGenLigne;
                                        Vente += TotalGenLigne_vente;

                                        try
                                        {
                                            Diff_achat = TotalGenLigne_vente - TotalGenLigne;
                                        }
                                        catch
                                        {
                                        }

                                        try
                                        {
                                            TotalGenLigne = 0;
                                            qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                            MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                            TotalLigne = qteLigne * MontantLigne;
                                            TotalGenLigne += TotalLigne;

                                            TotalGenLigne_vente = 0;
                                            qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                            MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                            TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                            TotalGenLigne_vente += TotalLigne_vente;

                                        }
                                        catch
                                        {
                                        }

                                        /*Decimal Difference = TotalP - TotalGenLigne;

                                        e.Graphics.DrawString(Difference.ToString("0.00"),
                                            new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 700, ypos);*/


                                    }
                                    catch (Exception exp)
                                    {

                                    }

                                    fourn = ds.Tables["Detail"].Rows[CptForun]["nom"].ToString();
                                    CptForun++;

                                }
                                else
                                {
                                    try
                                    {
                                        qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                        MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                        TotalLigne = qteLigne * MontantLigne;
                                        TotalGenLigne += TotalLigne;

                                        qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                        MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                        TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                        TotalGenLigne_vente += TotalLigne_vente;
                                    }
                                    catch (Exception exp)
                                    {
                                    }
                                    fourn = ds.Tables["Detail"].Rows[CptForun]["nom"].ToString();
                                    CptForun++;
                                }

                            }
                            else
                            {
                                CptForun -= 1;

                                Achat += TotalGenLigne;
                                Vente += TotalGenLigne_vente;

                                try
                                {
                                    Diff_achat = TotalGenLigne_vente - TotalGenLigne;
                                }
                                catch
                                {
                                }

                                try
                                {
                                    qteLigne = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                    MontantLigne = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix achat net"].ToString());
                                    TotalLigne = qteLigne * MontantLigne;
                                    TotalGenLigne += TotalLigne;

                                    qteLigne_vente = System.Convert.ToInt32(ds.Tables["Detail"].Rows[CptForun]["Quantite"].ToString());
                                    MontantLigne_vente = System.Convert.ToDecimal(ds.Tables["Detail"].Rows[CptForun]["Prix de vente"].ToString());
                                    TotalLigne_vente = qteLigne_vente * MontantLigne_vente;
                                    TotalGenLigne_vente += TotalLigne_vente;

                                }
                                catch (Exception exp)
                                {
                                }
                                ypos += 20;
                                TotalGenLigne = 0;
                                TotalGenLigne_vente = 0;
                                break;
                                /*Decimal Difference = TotalP - TotalGenLigne;

                                e.Graphics.DrawString(Difference.ToString("0.00"),
                                    new Font("Arial", 8, FontStyle.Regular), Brushes.Black, e.MarginBounds.Left + 700, ypos);*/
                            }
                        }
                        InBoucle = false;
                    }

                    ds.Tables["Detail"].Clear();
                    e.Graphics.DrawString("Total PV",
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                    e.Graphics.DrawString("Total PA",
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 600, ypos);
                    e.Graphics.DrawString("Total Marge",
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                    ypos += 25;
                    Decimal Diff = 0;
                    try
                    {
                        Diff = Vente - Achat;
                    }
                    catch
                    {
                        Diff = 0;
                    }
                    e.Graphics.DrawString(Vente.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 500, ypos);
                    e.Graphics.DrawString(Achat.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 600, ypos);
                    e.Graphics.DrawString(Diff.ToString("0.00"),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + 700, ypos);
                    e.Graphics.DrawString(DateTime.Now.ToLongDateString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom);
                    e.Graphics.DrawString("Page " + Page.ToString(),
                        new Font("Arial", 8, FontStyle.Bold), Brushes.Black, e.MarginBounds.Right - 50, e.MarginBounds.Bottom);

                    e.HasMorePages = false;
                    countRow = 0;
                    Page = 0;
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Page = 0;
            countRow = 0;
            TotalReforme = 0;
            TotalControle = 0;
            TotalRep = 0;
            TotalGar = 0;
            TotalRefus = 0;
            GeneralForfaitDNR = 0;
            GeneralTotalCA = 0;
            GeneralTotalPieces = 0;

            DateTime Debut = DateTime.Now;

            DateTime Fin = DateTime.Now;
            ds.Clear();

            try
            {
                ds = new DataSet();
                Debut = System.Convert.ToDateTime(textBox2.Text);
                Fin = System.Convert.ToDateTime(textBox4.Text);
                if (radioButton1.Checked)
                {
                    if (radioButton2.Checked)
                    {
                        MTGCComboBoxItem Item = (MTGCComboBoxItem)mtgcComboBox1.SelectedItem;
                        ds = new DataSet();
                        OleDbCommand Cde = new OleDbCommand();
                        Cde.Connection = oleDbConnection1;
                        //Cde.CommandText="SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year+"#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] ORDER BY T_clients.Nom, T_fournisseurs.Nom";
                        //Cde.CommandText = "SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus]";
                        //Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom AS Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] FROM T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + " / " + System.Convert.ToDateTime(Debut).Day + " / " + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom, T_parc_machine.[Code machine Opindus]";
                        Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom, T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE T_devis_entete.[Code Client] = " + Item.Col2 + " GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom";

                        DataAD.SelectCommand = Cde;
                        try
                        {
                            DataAD.Fill(ds, "Clients");
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                    }
                    else
                    {
                        ds = new DataSet();
                        OleDbCommand Cde = new OleDbCommand();
                        Cde.Connection = oleDbConnection1;
                        //Cde.CommandText="SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year+"#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] ORDER BY T_clients.Nom, T_fournisseurs.Nom";
                        //Cde.CommandText = "SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus]";
                        //Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom AS Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] FROM T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + " / " + System.Convert.ToDateTime(Debut).Day + " / " + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom, T_parc_machine.[Code machine Opindus]";

                        MTGCComboBoxItem Item = (MTGCComboBoxItem)mtgcComboBox1.SelectedItem;


                        Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom AS Nom, T_parc_machine.[Code machine Opindus], T_fournisseurs.Nom AS NomFourn, T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis], T_devis_lignes.Quantite, T_devis_lignes.[Prix achat net], T_devis_lignes.[Prix de vente] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_pieces_detachees INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON (T_pieces_detachees.[Code Fournisseur Principal] = T_fournisseurs.Code) AND (T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) WHERE T_devis_entete.[Code Client] = " + Item.Col2 + " GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_parc_machine.[Code machine Opindus], T_fournisseurs.Nom, T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis], T_devis_lignes.Quantite, T_devis_lignes.[Prix achat net], T_devis_lignes.[Prix de vente] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus]";

                        DataAD.SelectCommand = Cde;
                        try
                        {
                            DataAD.Fill(ds, "Clients");
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                    }
                }
                else
                {
                    if (radioButton2.Checked)
                    {
                        ds = new DataSet();
                        OleDbCommand Cde = new OleDbCommand();
                        Cde.Connection = oleDbConnection1;
                        //Cde.CommandText="SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year+"#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] ORDER BY T_clients.Nom, T_fournisseurs.Nom";
                        //Cde.CommandText = "SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus]";
                        //Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom AS Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] FROM T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + " / " + System.Convert.ToDateTime(Debut).Day + " / " + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom, T_parc_machine.[Code machine Opindus]";

                        MTGCComboBoxItem Item = (MTGCComboBoxItem)mtgcComboBox1.SelectedItem;

                        Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom, T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom";

                        DataAD.SelectCommand = Cde;
                        try
                        {
                            DataAD.Fill(ds, "Clients");
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                    }
                    else
                    {
                        ds = new DataSet();
                        OleDbCommand Cde = new OleDbCommand();
                        Cde.Connection = oleDbConnection1;
                        //Cde.CommandText="SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year+"#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] ORDER BY T_clients.Nom, T_fournisseurs.Nom";
                        //Cde.CommandText = "SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus]";
                        //Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom AS Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] FROM T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + " / " + System.Convert.ToDateTime(Debut).Day + " / " + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom, T_parc_machine.[Code machine Opindus]";

                        Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom AS Nom, T_parc_machine.[Code machine Opindus], T_fournisseurs.Nom AS NomFourn, T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis], T_devis_lignes.Quantite, T_devis_lignes.[Prix achat net], T_devis_lignes.[Prix de vente] FROM T_fournisseurs INNER JOIN (T_type_machine INNER JOIN (T_pieces_detachees INNER JOIN (T_parc_machine INNER JOIN ((T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_pieces_detachees.Identificateur = T_devis_lignes.[Code piece]) ON T_type_machine.Code = T_parc_machine.[Type machine]) ON (T_pieces_detachees.[Code Fournisseur Principal] = T_fournisseurs.Code) AND (T_fournisseurs.Code = T_pieces_detachees.[Code Fournisseur Principal]) GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_parc_machine.[Code machine Opindus], T_fournisseurs.Nom, T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis], T_devis_lignes.Quantite, T_devis_lignes.[Prix achat net], T_devis_lignes.[Prix de vente] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus]";

                        DataAD.SelectCommand = Cde;
                        try
                        {
                            DataAD.Fill(ds, "Clients");
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                label5.Visible = true;
            }
        }

        private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue != 8)
            {
                if (textBox2.TextLength.Equals(2))
                {
                    textBox2.Text += "/";
                    textBox2.Select(3, 1);
                }
                else if (textBox2.TextLength.Equals(5))
                {
                    textBox2.Text += "/";
                    textBox2.Select(6, 1);
                }
                else if (textBox2.TextLength.Equals(7))
                    textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue != 8)
            {
                if (textBox4.TextLength.Equals(2))
                {
                    textBox4.Text += "/";
                    textBox4.Select(3, 1);
                }
                else if (textBox4.TextLength.Equals(5))
                {
                    textBox4.Text += "/";
                    textBox4.Select(6, 1);
                }
                else if (textBox4.TextLength.Equals(7))
                    button1.Focus();
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Page = 0;
            DateTime Debut = DateTime.Now;
            DateTime Fin = DateTime.Now;
            try
            {
                Debut = System.Convert.ToDateTime(textBox2.Text);
                Fin = System.Convert.ToDateTime(textBox4.Text);
                printDocument1.Print();
                countRow = 0;
                Page = 0;
            }
            catch (Exception exp)
            {
                label5.Visible = true;
                Console.WriteLine(exp.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked)
            {
                mtgcComboBox1.Enabled = true;
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                mtgcComboBox1.Enabled = false;
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void mtgcComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mtgcComboBox1.SelectedIndex > 0)
            {
                button1.Enabled = true;
                button3.Enabled = true;
                dataSet11.Tables["t_clients"].Clear();
                oleDbDataAdapter1.SelectCommand.CommandText = "select * from t_clients where nom='" + mtgcComboBox1.Text + "'";
                oleDbDataAdapter1.Fill(dataSet11);
                textBox3.Text = mtgcComboBox1.Text;
                textBox1.Text = dataSet11.Tables["t_clients"].Rows[0]["ident"].ToString();
                dataSet11.Tables["t_devis_entete"].Clear();
                oleDbDataAdapter2.SelectCommand.CommandText = "SELECT T_devis_entete.[n° devis], T_clients.Nom, T_devis_entete.[Total pieces], T_devis_entete.Reforme, T_devis_entete.Refus, T_devis_entete.Niveau, T_devis_entete.[Type devis], T_clients.Ident, T_devis_entete.[Date reparation], T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis] FROM T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident WHERE T_devis_entete.Niveau>6 AND T_clients.Ident=" + textBox1.Text;
                try
                {
                    oleDbDataAdapter2.Fill(dataSet11);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                textBox2.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            OleDbCommand Cde = new OleDbCommand();
            Cde.Connection = oleDbConnection1;
            //Cde.CommandText="SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#"+System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year+"# And (T_devis_entete.[Date reparation])<=#"+System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year+"#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces] ORDER BY T_clients.Nom, T_fournisseurs.Nom";
            //Cde.CommandText = "SELECT T_clients.Ident, T_clients.Nom AS Nom, T_fournisseurs.Nom AS NomFourn, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN ((T_clients INNER JOIN T_parc_machine ON T_clients.Ident = T_parc_machine.[Code Client]) INNER JOIN (T_devis_entete INNER JOIN T_devis_lignes ON T_devis_entete.[N° Devis] = T_devis_lignes.[N° Devis]) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel]) ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_devis_entete.[Date reparation])>=#" + System.Convert.ToDateTime(Debut).Month + "/" + System.Convert.ToDateTime(Debut).Day + "/" + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<=#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) GROUP BY T_clients.Ident, T_clients.Nom, T_fournisseurs.Nom, T_devis_entete.[Type devis], T_devis_entete.Niveau, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_parc_machine.[Code machine Opindus] ORDER BY T_clients.Nom, T_fournisseurs.Nom, T_parc_machine.[Code machine Opindus]";
            //Cde.CommandText = "SELECT T_devis_entete.[N° Devis], T_clients.Nom AS Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] FROM T_parc_machine INNER JOIN (T_devis_entete INNER JOIN T_clients ON T_devis_entete.[Code Client] = T_clients.Ident) ON T_parc_machine.[Code machine Opindus] = T_devis_entete.[Code Materiel] GROUP BY T_devis_entete.[N° Devis], T_clients.Nom, T_parc_machine.[Code machine Opindus], T_clients.Ident, T_devis_entete.[Forfait DNR], T_devis_entete.[Total devis], T_devis_entete.[Total pieces], T_devis_entete.[Date reparation], T_devis_entete.Niveau, T_devis_entete.[Type devis] HAVING (((T_devis_entete.[Date reparation])>#" + System.Convert.ToDateTime(Debut).Month + " / " + System.Convert.ToDateTime(Debut).Day + " / " + System.Convert.ToDateTime(Debut).Year + "# And (T_devis_entete.[Date reparation])<#" + System.Convert.ToDateTime(Fin).Month + "/" + System.Convert.ToDateTime(Fin).Day + "/" + System.Convert.ToDateTime(Fin).Year + "#) AND ((T_devis_entete.Niveau)>6)) ORDER BY T_clients.Nom, T_parc_machine.[Code machine Opindus]";
            Cde.CommandText = "SELECT * FROM t_devis_lignes WHERE idLigne > 458489";

            DataAD.SelectCommand = Cde;
            try
            {
                DataAD.Fill(ds, "Lignes");

                oleDbConnection1.Open();

                foreach (DataRow Ligne in ds.Tables["Lignes"].Rows)
                {
                    Cde.Connection = oleDbConnection1;
                    Cde.CommandText = "SELECT [Prix achat net] FROM t_pieces_detachees WHERE Identificateur=" + Ligne["Code Piece"].ToString();

                    Decimal Prix = System.Convert.ToDecimal(Cde.ExecuteScalar());

                    String PrixAchat = Ligne["Prix achat net"].ToString();

                    Cde.CommandText = "UPDATE t_devis_lignes SET [Prix achat net]=" + Prix.ToString().Replace(",", ".") + " WHERE idLigne=" + Ligne["idLigne"].ToString();

                    Cde.ExecuteScalar();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            finally
            {
                oleDbConnection1.Close();
            }
        }
    }
}
