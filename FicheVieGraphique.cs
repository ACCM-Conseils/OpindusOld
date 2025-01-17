using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Opindus
{

    public partial class FicheVieGraphique : Form
    {
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private OleDbTransaction Transac;
        private OleDbDataAdapter DataAD;
        private DataSet ds;
        private OleDbCommand Comm;
        private String Agence;
        private String Machine;
        Object oRien = System.Reflection.Missing.Value;

        public FicheVieGraphique(String Agence, String Machine)
        {
            InitializeComponent();

            oleDbConnection1 = new OleDbConnection();
            Comm = new OleDbCommand();
            Comm.Connection = oleDbConnection1;
            DataAD = new OleDbDataAdapter();
            ds = new DataSet();

            this.Agence = Agence;
            this.Machine = Machine;
            if (Agence.Equals("1"))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }
            else if (Agence.Equals("2"))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lille\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }
            else if (Agence.Equals("3"))
            {
                oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Rouen\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
            }

            Comm.CommandText = "SELECT T_parc_machine_historique.ID,T_parc_machine_historique.Dateinter, T_parc_machine_historique.typeinterv, T_parc_machine_historique.N_Controle, T_parc_machine_historique.infos_3, T_parc_machine_historique.infos_4, T_parc_machine_historique.ind_k, T_parc_machine_historique.test_k, T_affectation.Affectation, T_site.Site FROM T_site INNER JOIN (T_affectation INNER JOIN (T_parc_machine INNER JOIN T_parc_machine_historique ON T_parc_machine.[Code machine Opindus] = T_parc_machine_historique.[Code machine Opindus]) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site where T_parc_machine_historique.[code machine opindus]='" + Machine + "' and T_parc_machine_historique.typeinterv=1";
            DataAD.SelectCommand = Comm;
            DataAD.Fill(ds, "t_machines_histo");
            if (ds.Tables["t_machines_histo"].Rows.Count > 0)
            {
                ListViewItem Ctrl = new ListViewItem();
                Ctrl.Text = Machine + ".xls";
                listView1.Items.Add(Ctrl);

            }
            ds.Tables["t_machines_histo"].Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel._Worksheet oSheet2;
            Microsoft.Office.Interop.Excel.Range oRng;

            oXL = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                oXL.Application.Visible = false;
            }
            catch
            {
                oXL.Application.Visible = false;
            }

            oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\modeles\fiche_vie.xls", oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien);

            oWB = (Microsoft.Office.Interop.Excel._Workbook)oXL.Workbooks[1];
            oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[2];
            oSheet2 = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1];

            Comm.CommandText = "SELECT T_parc_machine_historique.ID,T_parc_machine_historique.Dateinter,T_parc_machine_historique.Moyenne,T_parc_machine_historique.precision,T_parc_machine_historique.itmax,T_parc_machine_historique.itmin,T_parc_machine_historique.test_k,T_parc_machine_historique.ind_k, T_parc_machine_historique.typeinterv, T_parc_machine_historique.N_Controle, T_parc_machine_historique.infos_3, T_parc_machine_historique.infos_4, T_parc_machine_historique.ind_k, T_parc_machine_historique.test_k, T_affectation.Affectation, T_site.Site FROM T_site INNER JOIN (T_affectation INNER JOIN (T_parc_machine INNER JOIN T_parc_machine_historique ON T_parc_machine.[Code machine Opindus] = T_parc_machine_historique.[Code machine Opindus]) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site where T_parc_machine_historique.[Code machine opindus]='" + Machine + "'";
            DataAD.SelectCommand = Comm;
            DataAD.Fill(ds, "t_machines_histo");

            Comm.CommandText="SELECT T_famille_machine.Type FROM T_famille_machine INNER JOIN (T_type_machine INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille] WHERE (((T_parc_machine.[Code machine opindus])='"+Machine+"'))";

            String Type_famille = "";

            try
            {
                oleDbConnection1.Open();

                Type_famille = System.Convert.ToString(Comm.ExecuteScalar());

                
            }
            catch
            {
            }
            finally
            {
                oleDbConnection1.Close();
            }


            Comm.CommandText = "SELECT T_type_machine.[Code] FROM T_type_machine INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_parc_machine.[Code machine opindus])='" + Machine + "'))";

            String famille = "";

            try
            {
                oleDbConnection1.Open();

                famille = System.Convert.ToString(Comm.ExecuteScalar());


            }
            catch
            {
            }
            finally
            {
                oleDbConnection1.Close();
            }

            if (Type_famille.Equals("1"))
            {
                Comm.CommandText = "SELECT T_type_machine_dyn.*, T_type_machine_dyn_iso.Type, T_type_machine_dyn_iso.classe, T_type_machine_dyn_iso.precision, T_type_machine_dyn.Code FROM T_type_machine_dyn_iso INNER JOIN T_type_machine_dyn ON T_type_machine_dyn_iso.ID = T_type_machine_dyn.idIso WHERE (((T_type_machine_dyn.Code)='" + famille + "'))";
                DataAD.SelectCommand = Comm;
                DataAD.Fill(ds, "type_dyn");



            }
            else if (Type_famille.Equals("2"))
            {
                Comm.Connection = oleDbConnection1;
                Comm.CommandText = "select * from t_type_machine_vis where code='" + famille + "'";
                DataAD.SelectCommand = Comm;
                try
                {
                    DataAD.Fill(ds, "type_dyn");
                }
                catch (Exception exp)
                {

                }

            }
            else if (Type_famille.Equals("5"))
            {
                Comm.Connection = oleDbConnection1;
                Comm.CommandText = "select * from t_type_machine_clc where code='" + famille + "'";
                DataAD.SelectCommand = Comm;
                try
                {
                    DataAD.Fill(ds, "type_dyn");

                }
                catch (Exception exp)
                {

                }

            }
            else if (Type_famille.Equals("6"))
            {
            }

            

            int col = 3;
            if (ds.Tables["t_machines_histo"].Rows.Count > 0)
            {
                foreach (DataRow Histo in ds.Tables["t_machines_histo"].Rows)
                {
                    if (Histo["typeinterv"].ToString().Equals("1"))
                    {
                        oSheet2.Cells[2, 21] = ds.Tables["type_dyn"].Rows[0]["C_mini"].ToString();
                        oSheet2.Cells[3, 21] = ds.Tables["type_dyn"].Rows[0]["C_maxi"].ToString();
                        //oSheet.Cells[2, col] = ds.Tables["type_dyn"].Rows[0]["C_mini"].ToString();
                        //oSheet.Cells[3, col] = ds.Tables["type_dyn"].Rows[0]["C_maxi"].ToString();
                        oSheet.Cells[5, col] = "R";
                        String Date_Inter = Histo["Dateinter"].ToString().Replace("/", ".").Remove(10, 9);
                        oSheet.Cells[6, col] = Date_Inter ;
                        oSheet.Cells[7, col] = Histo["N_Controle"].ToString();
                        oSheet.Cells[8, col] = Histo["Moyenne"].ToString();
                        oSheet.Cells[9, col] = Histo["precision"].ToString();
                        oSheet.Cells[10, col] = Histo["itmax"].ToString();
                        oSheet.Cells[11, col] = Histo["itmin"].ToString();
                        oSheet.Cells[12, col] = Histo["test_k"].ToString();
                        oSheet.Cells[13, col] = Histo["ind_k"].ToString();

                        Decimal Moyenne = 0;
                        Decimal ItMax = 0;
                        Decimal ItMin = 0;

                        try
                        {
                            Moyenne = Decimal.Divide(System.Convert.ToDecimal(Histo["Moyenne"].ToString()), new Decimal(100));
                        }
                        catch
                        {
                        }

                        try
                        {
                            ItMax = Decimal.Divide(System.Convert.ToDecimal(Histo["itmax"].ToString()), new Decimal(100));
                        }
                        catch
                        {
                        }

                        try
                        {
                            ItMin = Decimal.Divide(System.Convert.ToDecimal(Histo["itmin"].ToString()), new Decimal(100));
                        }
                        catch
                        {
                        }

                        Decimal Moy = Decimal.Divide(Moyenne, System.Convert.ToDecimal(ds.Tables["type_dyn"].Rows[0]["C_maxi"].ToString()));
                        Decimal ItMaxi = Decimal.Divide(ItMax, System.Convert.ToDecimal(ds.Tables["type_dyn"].Rows[0]["C_maxi"].ToString()));
                        Decimal ItMini = Decimal.Divide(ItMin, System.Convert.ToDecimal(ds.Tables["type_dyn"].Rows[0]["C_maxi"].ToString()));

                        Moy = Moy * 100;
                        ItMaxi = ItMaxi * 100;
                        ItMini = ItMini * 100;

                        oSheet.Cells[15, col] = Moy.ToString();
                        oSheet.Cells[16, col] = ItMaxi.ToString();
                        oSheet.Cells[17, col] = ItMini.ToString();
                        col += 2;
                    }
                }
            }

            Comm.CommandText = "SELECT T_fournisseurs.Nom, T_type_machine.Code, T_parc_machine.[Code machine Opindus] AS CodeMachine, T_parc_machine.[Code Mabec] AS CodeMabec FROM (T_fournisseurs INNER JOIN T_type_machine ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_parc_machine ON T_type_machine.Code = T_parc_machine.[Type machine] WHERE (((T_parc_machine.[Code machine opindus])='" + Machine + "'))";

            DataAD.SelectCommand = Comm;
            DataAD.Fill(ds, "infos");

            if (ds.Tables["infos"].Rows.Count > 0)
            {
                oSheet2.Cells[2, 13] = ds.Tables["infos"].Rows[0]["CodeMachine"].ToString();
                oSheet2.Cells[2, 3] = ds.Tables["infos"].Rows[0]["Nom"].ToString();
                oSheet2.Cells[3, 3] = ds.Tables["infos"].Rows[0]["Code"].ToString();
                oSheet2.Cells[3, 13] = ds.Tables["infos"].Rows[0]["CodeMabec"].ToString();
            }

            oXL.Workbooks[1].SaveAs(@"C:\Program Files (x86)\Opindus\excel\" + Machine + ".xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, "", "", false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
            if (oXL != null)
            {
                oXL.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
                oXL = null;
            }
            oXL = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                oXL.Application.Visible = true;
            }
            catch
            {
                oXL.Application.Visible = true;
            }
            oXL.Workbooks.Open(@"C:\Program Files (x86)\Opindus\excel\" + Machine + ".xls", oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien, oRien);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}