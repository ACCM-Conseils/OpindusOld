using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using J4L.RChart;
using System.Data.OleDb;
using System.Data;

namespace Opindus
{
	/// <summary>
	/// Description résumée de GraphiquesCAM.
	/// </summary>
	public class GraphiquesCAM : System.Windows.Forms.Form
	{
		private J4L.RChart.ChartControl chartControl1;
		private J4L.RChart.ChartControl chartControl2;
		private J4L.RChart.ChartControl chartControl3;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private J4L.RChart.ChartControl chartControl4;
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet MyData;
		private Decimal EcartType1;
		private Decimal EcartType2;
		private Decimal EcartTypeEstime;
		private Decimal EcartTypeInstantane;
		private Decimal Dispersion;
		private Decimal Moyenne;
		private Decimal Pourcent1;
		private Decimal Pourcent2;
		private Decimal Pourcent3;
		private Decimal Pourcent4;
		private Decimal Pourcent5;
		private Decimal Pourcent6;
		private Decimal Pourcent7;
		private Decimal Pourcent8;
		private Decimal CAM1;
		private Decimal CAM2;
		private Decimal CAM3;
		private Decimal CAM4;
		private Decimal CAM5;
		private Decimal CAM6;
		private Decimal CAM7;
		private Decimal CAM8;
		private Decimal MaxValeur;
		private Decimal MiniCmk;
		private Decimal MiniPpk;
		private Decimal MiniM;
		private Decimal MaxiM;
		private Decimal NumControle;
		private Decimal PourcentMaxiMachine;
		private Decimal PourcentMaxiReglage;
		private Decimal MoyenneGroupe1;
		private Decimal MoyenneGroupe2;
		private Double EcartTypeGroupe1;
		private Double EcartTypeGroupe2;
		private Decimal TestDerive;
		private Decimal DiffAbs;
		private Double Kolmo;
		private Decimal MinPerf;
		private Decimal MaxPerf;
		private const int WM_PRINT = 0x0317;
		private const int PRF_CHECKVISIBLE = 0x00000001;
		private const int PRF_NONCLIENT = 0x00000002;
		private const int PRF_CLIENT = 0x00000004;
		private const int PRF_ERASEBKGND = 0x00000008;
		private const int PRF_CHILDREN = 0x00000010;
		private const int PRF_OWNED = 0x00000020;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.IContainer components;

		public GraphiquesCAM(int NumControle,Decimal Max,Decimal Moyenne, Decimal EcartType, Decimal MiniM, Decimal MaxiM,int NbMesures)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			MiniM=MiniM;
			MaxiM=MaxiM;
			NumControle=NumControle;
			OleDbCommand Comm = new OleDbCommand();
			Comm = new OleDbCommand();
			DataAD = new OleDbDataAdapter();

			Comm.Connection=oleDbConnection1;
			DataAD.SelectCommand=Comm;
			MyData=new DataSet();
			if(NbMesures.Equals(30))
			{
				Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017,"
					+"T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus], T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_affectation.Affectation, T_site.Site, T_parc_CAPTEURS.Chaine, T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM (T_site INNER JOIN (T_affectation INNER JOIN ((T_controles_cam INNER JOIN "
					+"T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site) INNER JOIN T_type_machine_Vis ON T_parc_machine.[Type machine] = T_type_machine_Vis.Code WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";

				
				DataAD.Fill(MyData,"T_controles_cam");
				oleDbConnection1.Open();
				Comm.CommandText="delete * from t_temp_ecart";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				
				Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(MyData,"ecart");
				EcartType1 = System.Convert.ToDecimal(MyData.Tables["ecart"].Rows[0]["ÉcartTypeDeValeur"].ToString());
				Comm.CommandText="select * from t_temp_ecart order by valeur ASC";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(MyData,"t_temp_ecart");
				Comm.CommandText="delete * from t_temp_ecart_tri";
				Comm.ExecuteNonQuery();
				Double Cpt=1.000;
				Decimal Total=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString())+
					System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString())+
					System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString())+
					System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString())+
					System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString())+
					System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString());
				Decimal Moy=Total/30;
				foreach(DataRow row in MyData.Tables["t_temp_ecart"].Rows)
				{
					Double Position=(System.Convert.ToDouble(row["valeur"].ToString())-System.Convert.ToDouble(Moy))/System.Convert.ToDouble(EcartType1);
					Double ProbaTheo=poz(Position);
					Double ProbaReelle=Cpt/30.000;
					Double Diff=Math.Abs(ProbaTheo-ProbaReelle);
					Comm.CommandText="insert into t_temp_ecart_tri (valeur,position_stat,ProbaTheo,ProbaReelle,DiffProba) values ("+row["valeur"].ToString().Replace(",",".")+","+Position.ToString("0.000").Replace(",",".")+","+ProbaTheo.ToString("0.0000").Replace(",",".")+","+ProbaReelle.ToString("0.0000").Replace(",",".")+","+Diff.ToString("0.0000").Replace(",",".")+")";                                              
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					Cpt++;
				}
				oleDbConnection1.Close();
				Comm.CommandText="SELECT * FROM t_temp_ecart_tri";
				DataAD.Fill(MyData,"t_temp_ecart_tri");
			}
			else if(NbMesures.Equals(50))
			{
				Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017,"
					+"T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031,T_controles_cam.Val_032,T_controles_cam.Val_033,T_controles_cam.Val_034,T_controles_cam.Val_035,T_controles_cam.Val_036,T_controles_cam.Val_037,T_controles_cam.Val_038,T_controles_cam.Val_039,T_controles_cam.Val_040,T_controles_cam.Val_041,T_controles_cam.Val_042,T_controles_cam.Val_043,T_controles_cam.Val_044,T_controles_cam.Val_045,"
					+"T_controles_cam.Val_046,T_controles_cam.Val_047,T_controles_cam.Val_048,T_controles_cam.Val_049,T_controles_cam.Val_050,T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus], T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_affectation.Affectation, T_site.Site, T_parc_CAPTEURS.Chaine, T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM (T_site INNER JOIN (T_affectation INNER JOIN ((T_controles_cam INNER JOIN "
					+"T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site) INNER JOIN T_type_machine_Vis ON T_parc_machine.[Type machine] = T_type_machine_Vis.Code WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
				DataAD.Fill(MyData,"T_controles_cam");
				oleDbConnection1.Open();
				Comm.CommandText="delete * from t_temp_ecart";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
				Comm.ExecuteNonQuery();
				
				MyData.Tables["t_temp_ecart"].Clear();
				MyData.Tables["t_temp_ecart_tri"].Clear();
				Comm.CommandText="select * from t_temp_ecart order by valeur ASC";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(MyData,"t_temp_ecart");
				Comm.CommandText="delete * from t_temp_ecart_tri";
				Comm.ExecuteNonQuery();
				Double Cpt=1.000;
				foreach(DataRow row in MyData.Tables["t_temp_ecart"].Rows)
				{
					Double Position=(System.Convert.ToDouble(row["valeur"].ToString())-System.Convert.ToDouble(Moyenne))/System.Convert.ToDouble(EcartType1);
					Double ProbaTheo=poz(Position);
					Double ProbaReelle=Cpt/50.000;
					Double Diff=Math.Abs(ProbaTheo-ProbaReelle);
					Comm.CommandText="insert into t_temp_ecart_tri (valeur,position_stat,ProbaTheo,ProbaReelle,DiffProba) values ("+row["valeur"].ToString().Replace(",",".")+","+Position.ToString("0.000").Replace(",",".")+","+ProbaTheo.ToString("0.0000").Replace(",",".")+","+ProbaReelle.ToString("0.0000").Replace(",",".")+","+Diff.ToString("0.0000").Replace(",",".")+")";                                              
					try
					{
						Comm.ExecuteNonQuery();
					}
					catch(Exception exp)
					{
						MessageBox.Show(exp.Message);
					}
					Cpt++;
				}
				oleDbConnection1.Close();
			}
			
			int Cpt1=0;
			int Cpt2=0;
			int Cpt3=0;
			int Cpt4=0;
			int Cpt5=0;
			int Cpt6=0;
			int Cpt7=0;
			int Cpt8=0;
			Comm.CommandText="select * from t_temp_ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_temp_ecart");
			foreach(DataRow row in MyData.Tables["t_temp_ecart"].Rows)
			{
				if(System.Convert.ToDouble(row["Valeur"].ToString())<(System.Convert.ToDouble(Moyenne)-System.Convert.ToDouble(EcartType)*4))
					Cpt1++;
				else if(System.Convert.ToDouble(row["Valeur"].ToString())<(System.Convert.ToDouble(Moyenne)-System.Convert.ToDouble(EcartType)*3))
					Cpt2++;
				else if(System.Convert.ToDouble(row["Valeur"].ToString())<(System.Convert.ToDouble(Moyenne)-System.Convert.ToDouble(EcartType)*2))
					Cpt3++;
				else if(System.Convert.ToDouble(row["Valeur"].ToString())<(System.Convert.ToDouble(Moyenne)-System.Convert.ToDouble(EcartType)*1))
					Cpt4++;
				else if(System.Convert.ToDouble(row["Valeur"].ToString())>(System.Convert.ToDouble(Moyenne)-System.Convert.ToDouble(EcartType)*1))
					Cpt5++;
				else if(System.Convert.ToDouble(row["Valeur"].ToString())>(System.Convert.ToDouble(Moyenne)-System.Convert.ToDouble(EcartType)*2))
					Cpt6++;
				else if(System.Convert.ToDouble(row["Valeur"].ToString())>(System.Convert.ToDouble(Moyenne)-System.Convert.ToDouble(EcartType)*3))
					Cpt7++;
				else if(System.Convert.ToDouble(row["Valeur"].ToString())>(System.Convert.ToDouble(Moyenne)-System.Convert.ToDouble(EcartType)*4))
					Cpt8++;

			}
			ChartLoader chartLoader= chartControl1.getChartLoader();
			// set chart parameters 
			chartLoader.clearParams();
			chartLoader.setParameter("TITLECHART","Réglage de la machine"); 
			chartLoader.setParameter("YLABEL","Nm"); 
			chartLoader.setParameter("XSCALE_MIN","0"); 
			chartLoader.setParameter("XSCALE_MAX","3"); 
			chartLoader.setParameter("YSCALE_MIN","0"); 
			chartLoader.setParameter("YSCALE_MAX",Max.ToString().Replace(",","."));
			chartLoader.setParameter("BIG_TICK_INTERVALY","1"); 
			chartLoader.setParameter("TICK_INTERVALY","10"); 
			chartLoader.setParameter("CERO_XAXIS","LINE"); 
			chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
			chartLoader.setParameter("SERIE_1","Valeurs"); 
			chartLoader.setParameter("SERIE_2","Mini"); 
			chartLoader.setParameter("LEGEND","FALSE");
			chartLoader.setParameter("LEFT_MARGIN","0.20");
			chartLoader.setParameter("YAXIS_LABEL_FORMAT","{0:F1}");
			chartLoader.setParameter("SERIE_TYPE_1","BAR");
			chartLoader.setParameter("SERIE_TYPE_2","BAR");
			chartLoader.setParameter("TICK_INTERVALY","1");
			chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
			chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
			chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
			chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
			chartLoader.setParameter("XAXIS_LABELS","Type machine|Poste|Cam");
			chartLoader.setParameter("BARCHART_CUMULATIVE","TRUE");
			chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
			chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
			chartLoader.setParameter("SERIE_FONT_1","Arial|PLAIN|8"); 
			chartLoader.setParameter("SERIE_DATA_1",MyData.Tables["t_controles_cam"].Rows[0]["C_maxi"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["maxi-poste"].ToString()+"|1,3"); 
			chartLoader.setParameter("SERIE_FONT_2","Arial|PLAIN|8"); 
			chartLoader.setParameter("SERIE_DATA_2",MyData.Tables["t_controles_cam"].Rows[0]["C_mini"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["mini-poste"].ToString()+"|0"); 
			chartLoader.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
			chartLoader.setParameter("SERIE_BAR_STYLE_1","ff00"); 
			chartLoader.setParameter("SERIE_BAR_STYLE_2","ff");
			chartLoader.setParameter("BARCHART_BARSPACE","500"); 
			chartLoader.setParameter("BARCHART_BARWIDTH","50");
			chartLoader.setParameter("CHART_FILL","ffcc00"); 
			chartLoader.setParameter("YLABEL_VERTICAL","FALSE"); 
			chartLoader.setParameter("YAXIS_TICKATBASE","true");
			// create chart 
			chartControl1.buildChart();

			ChartLoader chartLoader2= new ChartLoader();

			Max=0;
			Decimal Min=0;
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString())>Max)
				Max=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString());
			Min=Max;
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString());
			if(System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString())<Min)
				Min=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString());
			chartLoader2.clearParams();
			chartLoader2.setParameter("TITLECHART","Valeurs successives"); 
			if(NbMesures.Equals(30))
			{
				chartLoader2.setParameter("SERIE_DATA_1",MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString()); 
				chartLoader2.setParameter("SERIE_DATA_2",Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne);
			}
			else if(NbMesures.Equals(50))
			{
				chartLoader2.setParameter("SERIE_DATA_1",MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_031"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_032"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_033"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_034"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_035"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_036"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_037"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_038"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_039"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_040"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_041"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_042"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_043"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_044"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_045"].ToString()+
					"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_046"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_047"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_048"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_049"].ToString()+"|"+MyData.Tables["t_controles_cam"].Rows[0]["Val_050"].ToString());
				chartLoader2.setParameter("SERIE_DATA_2",Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne+"|"+Moyenne);
			}
			chartLoader2.setParameter("XSCALE_MIN","0"); 
			chartLoader2.setParameter("XSCALE_MAX",NbMesures.ToString()); 
			chartLoader2.setParameter("GRIDY","true");
			chartLoader2.setParameter("CERO_XAXIS","LINE"); 
			chartLoader2.setParameter("SERIE_1","Valeurs"); 
			chartLoader2.setParameter("SERIE_2","Moyenne");
			chartLoader2.setParameter("LEFT_MARGIN","0.20");
			chartLoader2.setParameter("SERIE_TYPE_1","LINE");
			chartLoader2.setParameter("SERIE_TYPE_2","LINE");
			chartLoader2.setParameter("SERIE_STYLE_2","1|BLUE|LINE");
			chartLoader2.setParameter("TICK_INTERVALY","10");
			chartLoader2.setParameter("BIG_TICK_INTERVALY","1");
			chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
			chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
			//chartLoader.setParameter("YAXIS_AUTO_TICKS","0.5");
			//chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL",Min.ToString().Replace(",",".")+"|"+Max.ToString().Replace(",","."));
			chartLoader2.setParameter("CHART_FILL","LIGHTGRAY");
			
			chartLoader2.setParameter("SERIE_BORDER_TYPE_1","RAISED"); 
			chartLoader2.setParameter("SERIE_STYLE_1","1|RED|LINE");
			chartLoader2.setParameter("CHART_FILL","ffcc00"); 
			chartLoader2.setParameter("YLABEL_VERTICAL","TRUE"); 
			chartControl2.setChart(chartLoader2.buildChart());
				
			// set chart parameters 
			chartLoader= chartControl3.getChartLoader();
			chartLoader.clearParams();
			chartLoader.setParameter("TITLECHART","Histogramme"); 
			chartLoader.setParameter("XSCALE_MIN","0"); 
			chartLoader.setParameter("XSCALE_MAX","9"); 
			chartLoader.setParameter("YSCALE_MIN","0"); 
			chartLoader.setParameter("BIG_TICK_INTERVALX","1"); 
			chartLoader.setParameter("BIG_TICK_INTERVALY","1");
			chartLoader.setParameter("XAXIS_VERTICAL_LABELS","TRUE");
			chartLoader.setParameter("XAXIS_LABELS","<= 3 sigma|-3 sigma|-2 sigma|-1 sigma|Moyenne|+1 sigma|+2 sigma|+3 sigma|>=3 sigma"); 
			chartLoader.setParameter("CERO_XAXIS","LINE"); 
			chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
			chartLoader.setParameter("SERIE_1","Valeurs"); 
			chartLoader.setParameter("LEGEND","FALSE");
			chartLoader.setParameter("LEFT_MARGIN","0.20");
			chartLoader.setParameter("SERIE_TYPE_1","BAR");
			chartLoader.setParameter("TICK_INTERVALY","10");
			chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
			chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
			chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
			chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
			chartLoader.setParameter("SERIE_FONT_1","Arial|PLAIN|8"); 
			chartLoader.setParameter("SERIE_DATA_1",Cpt1.ToString()+"|"+Cpt2.ToString()+"|"+Cpt3.ToString()+"|"+Cpt4.ToString()+"|"+Cpt5.ToString()+"|"+Cpt6.ToString()+"|"+Cpt7.ToString()+"|"+Cpt8.ToString()); 
			chartLoader.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
			chartLoader.setParameter("SERIE_BAR_STYLE_1","ff"); 
			chartLoader.setParameter("BARCHART_BARSPACE","150"); 
			chartLoader.setParameter("BARCHART_BARWIDTH","50");
			chartLoader.setParameter("CHART_FILL","ffcc00"); 
			chartLoader.setParameter("YLABEL_VERTICAL","FALSE");
			chartLoader.setParameter("YAXIS_TICKATBASE","true");
			chartControl3.buildChart();

			chartLoader= chartControl4.getChartLoader();
			// set chart parameters 
			chartLoader.clearParams();
			chartLoader.setParameter("TITLECHART","Distribution"); 
			chartLoader.setParameter("XSCALE_MIN","0"); 
			chartLoader.setParameter("XSCALE_MAX","9"); 
			chartLoader.setParameter("BIG_TICK_INTERVALX","1"); 
			chartLoader.setParameter("BIG_TICK_INTERVALY","1");
			chartLoader.setParameter("CERO_XAXIS","LINE"); 
			chartLoader.setParameter("SERIE_1","Proba Réelle"); 
			chartLoader.setParameter("SERIE_2","Proba Théorique");
			chartLoader.setParameter("LEGEND","TRUE");
			chartLoader.setParameter("LEFT_MARGIN","0.20");
			chartLoader.setParameter("SERIE_TYPE_1","LINE");
			chartLoader.setParameter("SERIE_TYPE_2","LINE");
			chartLoader.setParameter("TICK_INTERVALY","10");
			chartLoader.setParameter("XAXIS_AUTO_TICKS","5");
			chartLoader.setParameter("XAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
			chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
			chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
			chartLoader.setParameter("SERIE_STYLE_1","1|BLUE|LINE");
			chartLoader.setParameter("SERIE_STYLE_2","1|RED|LINE");
			chartLoader.setParameter("SERIE_DATA_1",MyData.Tables["t_temp_ecart_tri"].Rows[0]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[1]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[2]["ProbaTheo"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[3]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[4]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[5]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[6]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[7]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[8]["ProbaTheo"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[9]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[10]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[11]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[12]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[13]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[14]["ProbaTheo"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[15]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[16]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[17]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[18]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[19]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[20]["ProbaTheo"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[21]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[22]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[23]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[24]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[25]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[26]["ProbaTheo"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[27]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[28]["ProbaTheo"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[29]["ProbaTheo"].ToString()); 
			chartLoader.setParameter("SERIE_DATA_2",MyData.Tables["t_temp_ecart_tri"].Rows[0]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[1]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[2]["ProbaReelle"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[3]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[4]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[5]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[6]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[7]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[8]["ProbaReelle"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[9]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[10]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[11]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[12]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[13]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[14]["ProbaReelle"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[15]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[16]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[17]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[18]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[19]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[20]["ProbaReelle"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[21]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[22]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[23]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[24]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[25]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[26]["ProbaReelle"].ToString()+
				"|"+MyData.Tables["t_temp_ecart_tri"].Rows[27]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[28]["ProbaReelle"].ToString()+"|"+MyData.Tables["t_temp_ecart_tri"].Rows[29]["ProbaReelle"].ToString()); 
			chartLoader.setParameter("SERIE_BORDER_TYPE_1","RAISED");  
			chartLoader.setParameter("CHART_FILL","ffcc00"); 
			chartLoader.setParameter("YLABEL_VERTICAL","TRUE"); 
			chartLoader.setParameter("YAXIS_TICKATBASE","true");
			chartControl4.buildChart();
			this.Update();

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

		private void EcartType30()
		{
			EcartType1=0;
			EcartType2=0;
			EcartTypeEstime=0;
			EcartTypeInstantane=0;
			Dispersion=0;
			Moyenne=0;
			Pourcent1=0;
			Pourcent2=0;
			Pourcent3=0;
			Pourcent4=0;
			Pourcent5=0;
			Pourcent6=0;
			Pourcent7=0;
			Pourcent8=0;
			CAM1=0;
			CAM2=0;
			CAM3=0;
			CAM4=0;
			CAM5=0;
			CAM6=0;
			CAM7=0;
			CAM8=0;
			MiniCmk=0;
			oleDbConnection1.Open();
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
		
			DataSet MyData = new DataSet();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Total=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString());
			Moyenne=Total/30;
				
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartType2 = System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDevP(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartType1 = System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			Decimal Mul=new Decimal(1.28);
			EcartTypeEstime = Decimal.Multiply(EcartType2,Mul);
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue1=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue2=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue3=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue4=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue5=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue6=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Decimal EtendueMoyenne=(Etendue1+Etendue2+Etendue3+Etendue4+Etendue5+Etendue6)/6;
			MaxValeur=Etendue1;
			if(Etendue2>MaxValeur)
				MaxValeur=Etendue2;
			if(Etendue3>MaxValeur)
				MaxValeur=Etendue3;
			if(Etendue4>MaxValeur)
				MaxValeur=Etendue4;
			if(Etendue5>MaxValeur)
				MaxValeur=Etendue5;
			if(Etendue6>MaxValeur)
				MaxValeur=Etendue6;
			Decimal Div=new Decimal(1.746);
			EcartTypeInstantane=Decimal.Divide(EtendueMoyenne,Div);
			Dispersion=Decimal.Multiply(EcartTypeInstantane,new Decimal(6));
			Pourcent1=Decimal.Multiply(Moyenne,new Decimal(0.10));
			Pourcent2=Decimal.Multiply(Moyenne,new Decimal(0.20));
			Pourcent3=Decimal.Multiply(Moyenne,new Decimal(0.30));
			Pourcent4=Decimal.Multiply(Moyenne,new Decimal(0.40));
			Pourcent5=Decimal.Multiply(Moyenne,new Decimal(0.50));
			Pourcent6=Decimal.Multiply(Moyenne,new Decimal(0.60));
			Pourcent7=Decimal.Multiply(Moyenne,new Decimal(0.70));
			Pourcent8=Decimal.Multiply(Moyenne,new Decimal(0.80));
			CAM1=Decimal.Divide(Pourcent1,Dispersion);
			CAM2=Decimal.Divide(Pourcent2,Dispersion);
			CAM3=Decimal.Divide(Pourcent3,Dispersion);
			CAM4=Decimal.Divide(Pourcent4,Dispersion);
			CAM5=Decimal.Divide(Pourcent5,Dispersion);
			CAM6=Decimal.Divide(Pourcent6,Dispersion);
			CAM7=Decimal.Divide(Pourcent7,Dispersion);
			CAM8=Decimal.Divide(Pourcent8,Dispersion);
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal MaxiPoste=0;
			Decimal MiniPoste=0;
			if(MyData.Tables["t_controles_cam"].Rows[0]["Maxi-Poste"].ToString().Length>0)
				MaxiPoste=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Maxi-Poste"].ToString());
			if(MyData.Tables["t_controles_cam"].Rows[0]["Mini-Poste"].ToString().Length>0)
				MiniPoste=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Mini-Poste"].ToString());
			Decimal MaxiMachine=0;
			Decimal MiniMachine=0;
			if(MaxiM>0)
				MaxiMachine=MaxiM;
			if(MiniM>0)
				MiniMachine=MiniM;
			Decimal CMK1=Decimal.Divide(MaxiPoste-Moyenne,Decimal.Multiply(EcartTypeEstime,new Decimal(3)));
			Decimal CMK2=Decimal.Divide(Moyenne-MiniPoste,Decimal.Multiply(EcartTypeEstime,new Decimal(3)));
			MiniCmk=Math.Min(CMK1,CMK2);
			Decimal PPK1=Decimal.Divide(MaxiPoste-Moyenne,Decimal.Multiply(EcartType2,new Decimal(3)));
			Decimal PPK2=Decimal.Divide(Moyenne-MiniPoste,Decimal.Multiply(EcartType2,new Decimal(3)));
			MiniPpk=Math.Min(PPK1,PPK2);

			try
			{
				PourcentMaxiMachine=Decimal.Multiply(Decimal.Divide(Moyenne,MaxiMachine),new Decimal(100));
				PourcentMaxiReglage=Decimal.Multiply(Decimal.Divide(Moyenne-MiniMachine,MaxiMachine-MiniMachine),new Decimal(100));
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Avg(T_Temp_Ecart.Valeur) AS MoyenneDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			MoyenneGroupe1=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MoyenneDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartTypeGroupe1=System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Avg(T_Temp_Ecart.Valeur) AS MoyenneDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			MoyenneGroupe2=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MoyenneDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartTypeGroupe2=System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			DiffAbs=Math.Abs(MoyenneGroupe1-MoyenneGroupe2);
			Double EcartTypeDiff=(Math.Pow(EcartTypeGroupe1,2)+Math.Pow(EcartTypeGroupe2,2))/15;
			Double EcartTypeDiffCarre=Math.Sqrt(EcartTypeDiff);
			TestDerive=Decimal.Multiply(System.Convert.ToDecimal(EcartTypeDiffCarre),new Decimal(1.96));
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
		
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");	
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="select * from t_temp_ecart order by valeur ASC";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_temp_ecart");
			Comm.CommandText="delete * from t_temp_ecart_tri";
			Comm.ExecuteNonQuery();
			Double Cpt=1.000;
			foreach(DataRow row in MyData.Tables["t_temp_ecart"].Rows)
			{
				Double Position=(System.Convert.ToDouble(row["valeur"].ToString())-System.Convert.ToDouble(Moyenne))/System.Convert.ToDouble(EcartType1);
				Double ProbaTheo=poz(Position);
				Double ProbaReelle=Cpt/30.000;
				Double Diff=Math.Abs(ProbaTheo-ProbaReelle);
				Comm.CommandText="insert into t_temp_ecart_tri (valeur,position_stat,ProbaTheo,ProbaReelle,DiffProba) values ("+row["valeur"].ToString().Replace(",",".")+","+Position.ToString("0.000").Replace(",",".")+","+ProbaTheo.ToString("0.0000").Replace(",",".")+","+ProbaReelle.ToString("0.0000").Replace(",",".")+","+Diff.ToString("0.0000").Replace(",",".")+")";                                              
				try
				{
					Comm.ExecuteNonQuery();
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				Cpt++;
			}
			DataSet Kolmogorov = new DataSet();
			Comm.CommandText="SELECT Max(T_temp_ecart_tri.DiffProba) AS MaxDeDiffProba FROM T_temp_ecart_tri";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(Kolmogorov,"T_temp_ecart_tri");
			Kolmo=System.Convert.ToDouble(Kolmogorov.Tables["t_temp_ecart_tri"].Rows[0]["MaxDeDiffProba"].ToString());
			oleDbConnection1.Close();
		}

		private void EcartType50()
		{
			EcartType1=0;
			EcartType2=0;
			EcartTypeEstime=0;
			EcartTypeInstantane=0;
			Dispersion=0;
			Moyenne=0;
			Pourcent1=0;
			Pourcent2=0;
			Pourcent3=0;
			Pourcent4=0;
			Pourcent5=0;
			Pourcent6=0;
			Pourcent7=0;
			Pourcent8=0;
			CAM1=0;
			CAM2=0;
			CAM3=0;
			CAM4=0;
			CAM5=0;
			CAM6=0;
			CAM7=0;
			CAM8=0;
			MiniCmk=0;
			oleDbConnection1.Open();
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
		
			DataSet MyData = new DataSet();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031,T_controles_cam.Val_032,T_controles_cam.Val_033,T_controles_cam.Val_034,T_controles_cam.Val_035,T_controles_cam.Val_036,T_controles_cam.Val_037,T_controles_cam.Val_038,T_controles_cam.Val_039,T_controles_cam.Val_040,T_controles_cam.Val_041,T_controles_cam.Val_042,T_controles_cam.Val_043,T_controles_cam.Val_044,T_controles_cam.Val_045,T_controles_cam.Val_046,T_controles_cam.Val_047,"+
				" T_controles_cam.Val_048,T_controles_cam.Val_049,T_controles_cam.Val_050,T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Total=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_031"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_032"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_033"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_034"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_035"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_036"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_037"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_038"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_039"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_040"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_041"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_042"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_043"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_044"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_045"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_046"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_047"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_048"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_049"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_050"].ToString());
			Moyenne=Total/50;
				
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartType2 = System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDevP(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartType1 = System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			Decimal Mul=new Decimal(1.21);
			EcartTypeEstime = Decimal.Multiply(EcartType2,Mul);
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue1=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue2=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			
			Decimal Etendue3=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			
			Decimal Etendue4=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue5=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue6=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue7=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue8=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue9=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue10=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Decimal EtendueMoyenne=(Etendue1+Etendue2+Etendue3+Etendue4+Etendue5+Etendue6+Etendue7+Etendue8+Etendue9+Etendue10)/10;
			MaxValeur=Etendue1;
			if(Etendue2>MaxValeur)
				MaxValeur=Etendue2;
			if(Etendue3>MaxValeur)
				MaxValeur=Etendue3;
			if(Etendue4>MaxValeur)
				MaxValeur=Etendue4;
			if(Etendue5>MaxValeur)
				MaxValeur=Etendue5;
			if(Etendue6>MaxValeur)
				MaxValeur=Etendue6;
			if(Etendue7>MaxValeur)
				MaxValeur=Etendue7;
			if(Etendue8>MaxValeur)
				MaxValeur=Etendue8;
			if(Etendue9>MaxValeur)
				MaxValeur=Etendue9;
			if(Etendue10>MaxValeur)
				MaxValeur=Etendue10;
			Decimal Div=new Decimal(1.877);
			EcartTypeInstantane=Decimal.Divide(EtendueMoyenne,Div);
			Dispersion=Decimal.Multiply(EcartTypeInstantane,new Decimal(6));
			Pourcent1=Decimal.Multiply(Moyenne,new Decimal(0.10));
			Pourcent2=Decimal.Multiply(Moyenne,new Decimal(0.20));
			Pourcent3=Decimal.Multiply(Moyenne,new Decimal(0.30));
			Pourcent4=Decimal.Multiply(Moyenne,new Decimal(0.40));
			Pourcent5=Decimal.Multiply(Moyenne,new Decimal(0.50));
			Pourcent6=Decimal.Multiply(Moyenne,new Decimal(0.60));
			Pourcent7=Decimal.Multiply(Moyenne,new Decimal(0.70));
			Pourcent8=Decimal.Multiply(Moyenne,new Decimal(0.80));
			CAM1=Decimal.Divide(Pourcent1,Dispersion);
			CAM2=Decimal.Divide(Pourcent2,Dispersion);
			CAM3=Decimal.Divide(Pourcent3,Dispersion);
			CAM4=Decimal.Divide(Pourcent4,Dispersion);
			CAM5=Decimal.Divide(Pourcent5,Dispersion);
			CAM6=Decimal.Divide(Pourcent6,Dispersion);
			CAM7=Decimal.Divide(Pourcent7,Dispersion);
			CAM8=Decimal.Divide(Pourcent8,Dispersion);
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031,T_controles_cam.Val_032,T_controles_cam.Val_033,T_controles_cam.Val_034,T_controles_cam.Val_035,T_controles_cam.Val_036,T_controles_cam.Val_037,T_controles_cam.Val_038,T_controles_cam.Val_039,T_controles_cam.Val_040,T_controles_cam.Val_041,T_controles_cam.Val_042,T_controles_cam.Val_043,T_controles_cam.Val_044,T_controles_cam.Val_045,T_controles_cam.Val_046,T_controles_cam.Val_047,"+
				" T_controles_cam.Val_048,T_controles_cam.Val_049,T_controles_cam.Val_050,T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal MaxiPoste=0;
			Decimal MiniPoste=0;
			if(MyData.Tables["t_controles_cam"].Rows[0]["Maxi-Poste"].ToString().Length>0)
				MaxiPoste=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Maxi-Poste"].ToString());
			if(MaxiM>0)
				MiniPoste=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Mini-Poste"].ToString());
			Decimal MaxiMachine=0;
			Decimal MiniMachine=0;
			if(MaxiM>0)
				MaxiMachine=MaxiM;
			if(MiniM>0 )
				MiniMachine=MiniM;
			try
			{
				Decimal CMK1=Decimal.Divide(MaxiPoste-Moyenne,Decimal.Multiply(EcartTypeEstime,new Decimal(3)));
				Decimal CMK2=Decimal.Divide(Moyenne-MiniPoste,Decimal.Multiply(EcartTypeEstime,new Decimal(3)));
				MiniCmk=Math.Min(CMK1,CMK2);
				Decimal PPK1=Decimal.Divide(MaxiPoste-Moyenne,Decimal.Multiply(EcartType2,new Decimal(3)));
				Decimal PPK2=Decimal.Divide(Moyenne-MiniPoste,Decimal.Multiply(EcartType2,new Decimal(3)));
				MiniPpk=Math.Min(PPK1,PPK2);
				PourcentMaxiMachine=Decimal.Multiply(Decimal.Divide(Moyenne,MaxiMachine),new Decimal(100));
				PourcentMaxiReglage=Decimal.Multiply(Decimal.Divide(Moyenne-MiniMachine,MaxiMachine-MiniMachine),new Decimal(100));
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}


			
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Avg(T_Temp_Ecart.Valeur) AS MoyenneDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			MoyenneGroupe1=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MoyenneDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartTypeGroupe1=System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Avg(T_Temp_Ecart.Valeur) AS MoyenneDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			MoyenneGroupe2=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MoyenneDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartTypeGroupe2=System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			DiffAbs=Math.Abs(MoyenneGroupe1-MoyenneGroupe2);
			Double EcartTypeDiff=(Math.Pow(EcartTypeGroupe1,2)+Math.Pow(EcartTypeGroupe2,2))/25;
			Double EcartTypeDiffCarre=Math.Sqrt(EcartTypeDiff);
			TestDerive=Decimal.Multiply(System.Convert.ToDecimal(EcartTypeDiffCarre),new Decimal(1.96));
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
		
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031,T_controles_cam.Val_032,T_controles_cam.Val_033,T_controles_cam.Val_034,T_controles_cam.Val_035,T_controles_cam.Val_036,T_controles_cam.Val_037,T_controles_cam.Val_038,T_controles_cam.Val_039,T_controles_cam.Val_040,T_controles_cam.Val_041,T_controles_cam.Val_042,T_controles_cam.Val_043,T_controles_cam.Val_044,T_controles_cam.Val_045,T_controles_cam.Val_046,T_controles_cam.Val_047,"+
				" T_controles_cam.Val_048,T_controles_cam.Val_049,T_controles_cam.Val_050,T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");	
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="select * from t_temp_ecart order by valeur ASC";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_temp_ecart");
			Comm.CommandText="delete * from t_temp_ecart_tri";
			Comm.ExecuteNonQuery();
			Double Cpt=1.000;
			foreach(DataRow row in MyData.Tables["t_temp_ecart"].Rows)
			{
				Double Position=(System.Convert.ToDouble(row["valeur"].ToString())-System.Convert.ToDouble(Moyenne))/System.Convert.ToDouble(EcartType1);
				Double ProbaTheo=poz(Position);
				Double ProbaReelle=Cpt/50.000;
				Double Diff=Math.Abs(ProbaTheo-ProbaReelle);
				Comm.CommandText="insert into t_temp_ecart_tri (valeur,position_stat,ProbaTheo,ProbaReelle,DiffProba) values ("+row["valeur"].ToString().Replace(",",".")+","+Position.ToString("0.000").Replace(",",".")+","+ProbaTheo.ToString("0.0000").Replace(",",".")+","+ProbaReelle.ToString("0.0000").Replace(",",".")+","+Diff.ToString("0.0000").Replace(",",".")+")";                                              
				try
				{
					Comm.ExecuteNonQuery();
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				Cpt++;
			}
			DataSet Kolmogorov = new DataSet();
			Comm.CommandText="SELECT Max(T_temp_ecart_tri.DiffProba) AS MaxDeDiffProba FROM T_temp_ecart_tri";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(Kolmogorov,"T_temp_ecart_tri");
			Kolmo=System.Convert.ToDouble(Kolmogorov.Tables["t_temp_ecart_tri"].Rows[0]["MaxDeDiffProba"].ToString());
			oleDbConnection1.Close();
		}

		private void EcartType100()
		{
			EcartType1=0;
			EcartType2=0;
			EcartTypeEstime=0;
			EcartTypeInstantane=0;
			Dispersion=0;
			Moyenne=0;
			Pourcent1=0;
			Pourcent2=0;
			Pourcent3=0;
			Pourcent4=0;
			Pourcent5=0;
			Pourcent6=0;
			Pourcent7=0;
			Pourcent8=0;
			CAM1=0;
			CAM2=0;
			CAM3=0;
			CAM4=0;
			CAM5=0;
			CAM6=0;
			CAM7=0;
			CAM8=0;
			MiniCmk=0;
			oleDbConnection1.Open();
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
		
			DataSet MyData = new DataSet();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031,T_controles_cam.Val_032,T_controles_cam.Val_033,T_controles_cam.Val_034,T_controles_cam.Val_035,T_controles_cam.Val_036,T_controles_cam.Val_037,T_controles_cam.Val_038,T_controles_cam.Val_039,T_controles_cam.Val_040,T_controles_cam.Val_041,T_controles_cam.Val_042,T_controles_cam.Val_043,T_controles_cam.Val_044,T_controles_cam.Val_045,T_controles_cam.Val_046,T_controles_cam.Val_047,"+
				" T_controles_cam.Val_048,T_controles_cam.Val_049,T_controles_cam.Val_050,T_controles_cam.Val_051,T_controles_cam.Val_052,T_controles_cam.Val_053,T_controles_cam.Val_054,T_controles_cam.Val_055,T_controles_cam.Val_056,T_controles_cam.Val_057,T_controles_cam.Val_058,T_controles_cam.Val_059,T_controles_cam.Val_060,T_controles_cam.Val_061,T_controles_cam.Val_062,T_controles_cam.Val_063,T_controles_cam.Val_064,T_controles_cam.Val_065,T_controles_cam.Val_066,T_controles_cam.Val_067,T_controles_cam.Val_068,"+
				" T_controles_cam.Val_069,T_controles_cam.Val_070,T_controles_cam.Val_071,T_controles_cam.Val_072,T_controles_cam.Val_073,T_controles_cam.Val_074,T_controles_cam.Val_075,T_controles_cam.Val_076,T_controles_cam.Val_077,T_controles_cam.Val_078,T_controles_cam.Val_079,T_controles_cam.Val_080,T_controles_cam.Val_081,T_controles_cam.Val_082,T_controles_cam.Val_083,T_controles_cam.Val_084,T_controles_cam.Val_085,T_controles_cam.Val_086,T_controles_cam.Val_087,T_controles_cam.Val_088,"+
				" T_controles_cam.Val_089,T_controles_cam.Val_090,T_controles_cam.Val_091,T_controles_cam.Val_092,T_controles_cam.Val_093,T_controles_cam.Val_094,T_controles_cam.Val_095,T_controles_cam.Val_096,T_controles_cam.Val_097,T_controles_cam.Val_098,T_controles_cam.Val_099,T_controles_cam.Val_100,T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Total=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_001"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_002"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_003"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_004"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_005"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_006"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_007"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_008"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_009"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_010"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_011"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_012"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_013"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_014"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_015"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_016"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_017"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_018"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_019"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_020"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_021"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_022"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_023"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_024"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_025"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_026"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_027"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_028"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_029"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_030"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_031"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_032"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_033"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_034"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_035"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_036"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_037"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_038"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_039"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_040"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_041"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_042"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_043"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_044"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_045"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_046"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_047"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_048"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_049"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_050"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_051"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_052"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_053"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_054"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_055"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_056"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_057"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_058"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_059"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_060"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_061"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_062"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_063"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_064"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_065"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_066"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_067"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_068"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_069"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_070"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_071"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_072"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_073"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_074"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_075"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_076"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_077"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_078"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_079"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_080"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_081"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_082"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_083"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_084"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_085"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_086"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_087"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_088"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_089"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_090"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_091"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_092"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_093"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_094"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_095"].ToString())+
				System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_096"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_097"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_098"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_099"].ToString())+System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Val_100"].ToString());
			Moyenne=Total/100;
				
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_051"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_052"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_053"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_054"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_055"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_056"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_057"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_058"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_059"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_060"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_061"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_062"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_063"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_064"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_065"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_066"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_067"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_068"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_069"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_070"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_071"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_072"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_073"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_074"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_075"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_076"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_077"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_078"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_079"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_080"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_081"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_082"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_083"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_084"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_085"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_086"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_087"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_088"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_089"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_090"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_091"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_092"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_093"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_094"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_095"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_096"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_097"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_098"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_099"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_100"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartType2 = System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDevP(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartType1 = System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			Decimal Mul=new Decimal(1.13);
			EcartTypeEstime = Decimal.Multiply(EcartType2,Mul);
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue1=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue2=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			
			Decimal Etendue3=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			
			Decimal Etendue4=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue5=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue6=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue7=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue8=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue9=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());
			
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue10=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_051, T_controles_cam.Val_052, T_controles_cam.Val_053, T_controles_cam.Val_054, T_controles_cam.Val_055 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_051"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_052"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_053"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_054"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_055"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue11=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_056, T_controles_cam.Val_057, T_controles_cam.Val_058, T_controles_cam.Val_059, T_controles_cam.Val_060 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_056"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_057"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_058"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_059"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_060"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue12=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_061, T_controles_cam.Val_062, T_controles_cam.Val_063, T_controles_cam.Val_064, T_controles_cam.Val_065 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_061"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_062"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_063"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_064"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_065"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue13=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_066, T_controles_cam.Val_067, T_controles_cam.Val_068, T_controles_cam.Val_069, T_controles_cam.Val_070 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_066"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_067"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_068"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_069"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_070"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue14=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_071, T_controles_cam.Val_072, T_controles_cam.Val_073, T_controles_cam.Val_074, T_controles_cam.Val_075 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_071"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_072"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_073"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_074"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_075"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue15=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_076, T_controles_cam.Val_077, T_controles_cam.Val_078, T_controles_cam.Val_079, T_controles_cam.Val_080 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_076"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_077"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_078"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_079"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_080"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue16=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_081, T_controles_cam.Val_082, T_controles_cam.Val_083, T_controles_cam.Val_084, T_controles_cam.Val_085 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_081"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_082"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_083"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_084"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_085"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue17=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_086, T_controles_cam.Val_087, T_controles_cam.Val_088, T_controles_cam.Val_089, T_controles_cam.Val_090 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_086"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_087"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_088"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_089"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_090"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue18=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_091, T_controles_cam.Val_092, T_controles_cam.Val_093, T_controles_cam.Val_094, T_controles_cam.Val_095 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_091"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_092"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_093"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_094"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_095"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue19=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050, T_controles_cam.Val_096, T_controles_cam.Val_097, T_controles_cam.Val_098, T_controles_cam.Val_099, T_controles_cam.Val_100 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_096"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_097"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_098"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_099"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_100"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Max(T_Temp_Ecart.Valeur) AS MaxDeValeur, Min(T_Temp_Ecart.Valeur) AS MinDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal Etendue20=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MaxDeValeur"].ToString())-System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MinDeValeur"].ToString());

			Decimal EtendueMoyenne=(Etendue1+Etendue2+Etendue3+Etendue4+Etendue5+Etendue6+Etendue7+Etendue8+Etendue9+Etendue10+Etendue11+Etendue12+Etendue13+Etendue14+Etendue15+Etendue16+Etendue17+Etendue18+Etendue19+Etendue20)/20;
			MaxValeur=Etendue1;
			if(Etendue2>MaxValeur)
				MaxValeur=Etendue2;
			if(Etendue3>MaxValeur)
				MaxValeur=Etendue3;
			if(Etendue4>MaxValeur)
				MaxValeur=Etendue4;
			if(Etendue5>MaxValeur)
				MaxValeur=Etendue5;
			if(Etendue6>MaxValeur)
				MaxValeur=Etendue6;
			if(Etendue7>MaxValeur)
				MaxValeur=Etendue7;
			if(Etendue8>MaxValeur)
				MaxValeur=Etendue8;
			if(Etendue9>MaxValeur)
				MaxValeur=Etendue9;
			if(Etendue10>MaxValeur)
				MaxValeur=Etendue10;
			if(Etendue11>MaxValeur)
				MaxValeur=Etendue11;
			if(Etendue12>MaxValeur)
				MaxValeur=Etendue12;
			if(Etendue13>MaxValeur)
				MaxValeur=Etendue13;
			if(Etendue14>MaxValeur)
				MaxValeur=Etendue14;
			if(Etendue15>MaxValeur)
				MaxValeur=Etendue15;
			if(Etendue16>MaxValeur)
				MaxValeur=Etendue16;
			if(Etendue17>MaxValeur)
				MaxValeur=Etendue17;
			if(Etendue18>MaxValeur)
				MaxValeur=Etendue18;
			if(Etendue19>MaxValeur)
				MaxValeur=Etendue19;
			if(Etendue20>MaxValeur)
				MaxValeur=Etendue20;
			Decimal Div=new Decimal(2.008);
			EcartTypeInstantane=Decimal.Divide(EtendueMoyenne,Div);
			Dispersion=Decimal.Multiply(EcartTypeInstantane,new Decimal(6));
			Pourcent1=Decimal.Multiply(Moyenne,new Decimal(0.10));
			Pourcent2=Decimal.Multiply(Moyenne,new Decimal(0.20));
			Pourcent3=Decimal.Multiply(Moyenne,new Decimal(0.30));
			Pourcent4=Decimal.Multiply(Moyenne,new Decimal(0.40));
			Pourcent5=Decimal.Multiply(Moyenne,new Decimal(0.50));
			Pourcent6=Decimal.Multiply(Moyenne,new Decimal(0.60));
			Pourcent7=Decimal.Multiply(Moyenne,new Decimal(0.70));
			Pourcent8=Decimal.Multiply(Moyenne,new Decimal(0.80));
			CAM1=Decimal.Divide(Pourcent1,Dispersion);
			CAM2=Decimal.Divide(Pourcent2,Dispersion);
			CAM3=Decimal.Divide(Pourcent3,Dispersion);
			CAM4=Decimal.Divide(Pourcent4,Dispersion);
			CAM5=Decimal.Divide(Pourcent5,Dispersion);
			CAM6=Decimal.Divide(Pourcent6,Dispersion);
			CAM7=Decimal.Divide(Pourcent7,Dispersion);
			CAM8=Decimal.Divide(Pourcent8,Dispersion);
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031,T_controles_cam.Val_032,T_controles_cam.Val_033,T_controles_cam.Val_034,T_controles_cam.Val_035,T_controles_cam.Val_036,T_controles_cam.Val_037,T_controles_cam.Val_038,T_controles_cam.Val_039,T_controles_cam.Val_040,T_controles_cam.Val_041,T_controles_cam.Val_042,T_controles_cam.Val_043,T_controles_cam.Val_044,T_controles_cam.Val_045,T_controles_cam.Val_046,T_controles_cam.Val_047,"+
				" T_controles_cam.Val_048,T_controles_cam.Val_049,T_controles_cam.Val_050,T_controles_cam.Val_051,T_controles_cam.Val_052,T_controles_cam.Val_053,T_controles_cam.Val_054,T_controles_cam.Val_055,T_controles_cam.Val_056,T_controles_cam.Val_057,T_controles_cam.Val_058,T_controles_cam.Val_059,T_controles_cam.Val_060,T_controles_cam.Val_061,T_controles_cam.Val_062,T_controles_cam.Val_063,T_controles_cam.Val_064,T_controles_cam.Val_065,T_controles_cam.Val_066,T_controles_cam.Val_067,"+
				" T_controles_cam.Val_068,T_controles_cam.Val_069,T_controles_cam.Val_070,T_controles_cam.Val_071,T_controles_cam.Val_072,T_controles_cam.Val_073,T_controles_cam.Val_074,T_controles_cam.Val_075,T_controles_cam.Val_076,T_controles_cam.Val_077,T_controles_cam.Val_078,T_controles_cam.Val_079,T_controles_cam.Val_080,T_controles_cam.Val_081,T_controles_cam.Val_082,T_controles_cam.Val_083,T_controles_cam.Val_084,T_controles_cam.Val_085,T_controles_cam.Val_086,T_controles_cam.Val_087,"+
				" T_controles_cam.Val_088,T_controles_cam.Val_089,T_controles_cam.Val_090,T_controles_cam.Val_091,T_controles_cam.Val_092,T_controles_cam.Val_093,T_controles_cam.Val_094,T_controles_cam.Val_095,T_controles_cam.Val_096,T_controles_cam.Val_097,T_controles_cam.Val_098,T_controles_cam.Val_099,T_controles_cam.Val_100,T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Decimal MaxiPoste=0;
			Decimal MiniPoste=0;
			if(MyData.Tables["t_controles_cam"].Rows[0]["Maxi-Poste"].ToString().Length>0)
				MaxiPoste=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Maxi-Poste"].ToString());
			if(MaxiM>0)
				MiniPoste=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["Mini-Poste"].ToString());
			Decimal MaxiMachine=0;
			Decimal MiniMachine=0;
			if(MaxiM>0)
				MaxiMachine=MaxiM;
			if(MiniM>0 )
				MiniMachine=MiniM;
			try
			{
				Decimal CMK1=Decimal.Divide(MaxiPoste-Moyenne,Decimal.Multiply(EcartTypeEstime,new Decimal(3)));
				Decimal CMK2=Decimal.Divide(Moyenne-MiniPoste,Decimal.Multiply(EcartTypeEstime,new Decimal(3)));
				MiniCmk=Math.Min(CMK1,CMK2);
				Decimal PPK1=Decimal.Divide(MaxiPoste-Moyenne,Decimal.Multiply(EcartType2,new Decimal(3)));
				Decimal PPK2=Decimal.Divide(Moyenne-MiniPoste,Decimal.Multiply(EcartType2,new Decimal(3)));
				MiniPpk=Math.Min(PPK1,PPK2);
				PourcentMaxiMachine=Decimal.Multiply(Decimal.Divide(Moyenne,MaxiMachine),new Decimal(100));
				PourcentMaxiReglage=Decimal.Multiply(Decimal.Divide(Moyenne-MiniMachine,MaxiMachine-MiniMachine),new Decimal(100));
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025,"+
				" T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044, T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Avg(T_Temp_Ecart.Valeur) AS MoyenneDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			MoyenneGroupe1=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MoyenneDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartTypeGroupe1=System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.Val_051, T_controles_cam.Val_052, T_controles_cam.Val_053, T_controles_cam.Val_054, T_controles_cam.Val_055, T_controles_cam.Val_056, T_controles_cam.Val_057, T_controles_cam.Val_058, T_controles_cam.Val_059, T_controles_cam.Val_060, T_controles_cam.Val_061, T_controles_cam.Val_062, T_controles_cam.Val_063, T_controles_cam.Val_064, T_controles_cam.Val_065, T_controles_cam.Val_066, T_controles_cam.Val_067, T_controles_cam.Val_068, T_controles_cam.Val_069, T_controles_cam.Val_070, T_controles_cam.Val_071, T_controles_cam.Val_072, T_controles_cam.Val_073, T_controles_cam.Val_074, T_controles_cam.Val_075,"+
				" T_controles_cam.Val_076, T_controles_cam.Val_077, T_controles_cam.Val_078, T_controles_cam.Val_079, T_controles_cam.Val_080, T_controles_cam.Val_081, T_controles_cam.Val_082, T_controles_cam.Val_083, T_controles_cam.Val_084, T_controles_cam.Val_085, T_controles_cam.Val_086, T_controles_cam.Val_087, T_controles_cam.Val_088, T_controles_cam.Val_089, T_controles_cam.Val_090, T_controles_cam.Val_091, T_controles_cam.Val_092, T_controles_cam.Val_093, T_controles_cam.Val_094, T_controles_cam.Val_095, T_controles_cam.Val_096, T_controles_cam.Val_097, T_controles_cam.Val_098, T_controles_cam.Val_099, T_controles_cam.Val_100 FROM T_controles_cam WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_051"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_052"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_053"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_054"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_055"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_056"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_057"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_058"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_059"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_060"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_061"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_062"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_063"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_064"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_065"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_066"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_067"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_068"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_069"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_070"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_071"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_072"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_073"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_074"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_075"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_076"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_077"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_078"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_079"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_080"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_081"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_082"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_083"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_084"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_085"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_086"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_087"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_088"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_089"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_090"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_091"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_092"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_093"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_094"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_095"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_096"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_097"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_098"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_099"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_100"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT Avg(T_Temp_Ecart.Valeur) AS MoyenneDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			MoyenneGroupe2=System.Convert.ToDecimal(MyData.Tables["t_controles_cam"].Rows[0]["MoyenneDeValeur"].ToString());
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT StDev(T_Temp_Ecart.Valeur) AS ÉcartTypeDeValeur FROM T_Temp_Ecart";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");
			EcartTypeGroupe2=System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["ÉcartTypeDeValeur"].ToString());
			DiffAbs=Math.Abs(MoyenneGroupe1-MoyenneGroupe2);
			Double EcartTypeDiff=(Math.Pow(EcartTypeGroupe1,2)+Math.Pow(EcartTypeGroupe2,2))/25;
			Double EcartTypeDiffCarre=Math.Sqrt(EcartTypeDiff);
			TestDerive=Decimal.Multiply(System.Convert.ToDecimal(EcartTypeDiffCarre),new Decimal(1.96));
			Comm.CommandText="delete * from t_temp_ecart";
			Comm.ExecuteNonQuery();
		
			MyData.Tables["t_controles_cam"].Clear();
			Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008,"+
				" T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017, T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027,"+
				" T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031,T_controles_cam.Val_032,T_controles_cam.Val_033,T_controles_cam.Val_034,T_controles_cam.Val_035,T_controles_cam.Val_036,T_controles_cam.Val_037,T_controles_cam.Val_038,T_controles_cam.Val_039,T_controles_cam.Val_040,T_controles_cam.Val_041,T_controles_cam.Val_042,T_controles_cam.Val_043,T_controles_cam.Val_044,T_controles_cam.Val_045,T_controles_cam.Val_046,T_controles_cam.Val_047,"+
				" T_controles_cam.Val_048,T_controles_cam.Val_049,T_controles_cam.Val_050,T_controles_cam.Val_051,T_controles_cam.Val_052,T_controles_cam.Val_053,T_controles_cam.Val_054,T_controles_cam.Val_055,T_controles_cam.Val_056,T_controles_cam.Val_057,T_controles_cam.Val_058,T_controles_cam.Val_059,T_controles_cam.Val_060,T_controles_cam.Val_061,T_controles_cam.Val_062,T_controles_cam.Val_063,T_controles_cam.Val_064,T_controles_cam.Val_065,T_controles_cam.Val_066,T_controles_cam.Val_067,"+
				" T_controles_cam.Val_068,T_controles_cam.Val_069,T_controles_cam.Val_070,T_controles_cam.Val_071,T_controles_cam.Val_072,T_controles_cam.Val_073,T_controles_cam.Val_074,T_controles_cam.Val_075,T_controles_cam.Val_076,T_controles_cam.Val_077,T_controles_cam.Val_078,T_controles_cam.Val_079,T_controles_cam.Val_080,T_controles_cam.Val_081,T_controles_cam.Val_082,T_controles_cam.Val_083,T_controles_cam.Val_084,T_controles_cam.Val_085,T_controles_cam.Val_086,T_controles_cam.Val_087,"+
				" T_controles_cam.Val_088,T_controles_cam.Val_089,T_controles_cam.Val_090,T_controles_cam.Val_091,T_controles_cam.Val_092,T_controles_cam.Val_093,T_controles_cam.Val_094,T_controles_cam.Val_095,T_controles_cam.Val_096,T_controles_cam.Val_097,T_controles_cam.Val_098,T_controles_cam.Val_099,T_controles_cam.Val_100,T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus],"+
				" T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_fournisseurs.Nom, T_affectation.Affectation, T_site.Site, T_type_machine.[Mini machine], T_type_machine.[Maxi machine], T_type_machine.Vitesse, T_parc_CAPTEURS.Chaine FROM (((T_fournisseurs INNER JOIN (T_famille_machine INNER JOIN (T_type_machine INNER JOIN (T_controles_cam INNER JOIN T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) ON T_type_machine.Code ="+
				" T_parc_machine.[Type machine]) ON T_famille_machine.Code = T_type_machine.[Code famille]) ON T_fournisseurs.Code = T_type_machine.Fournisseur) INNER JOIN T_affectation ON T_parc_machine.Affectation = T_affectation.ID) INNER JOIN T_site ON T_parc_machine.Site = T_site.ID) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_controles_cam");	
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_001"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_002"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_003"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_004"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_005"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_006"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_007"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_008"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_009"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_010"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_011"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_012"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_013"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_014"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_015"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_016"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_017"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_018"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_019"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_020"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_021"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_022"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_023"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_024"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_025"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_026"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_027"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_028"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_029"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_030"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_031"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_032"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_033"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_034"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_035"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_036"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_037"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_038"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_039"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_040"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_041"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_042"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_043"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_044"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_045"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_046"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_047"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_048"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_049"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_050"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_051"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_052"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_053"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_054"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_055"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_056"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_057"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_058"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_059"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_060"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_061"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_062"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_063"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_064"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_065"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_066"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_067"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_068"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_069"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_070"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_071"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_072"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_073"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_074"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_075"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_076"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_077"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_078"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_079"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_080"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_081"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_082"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_083"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_084"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_085"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_086"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_087"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_088"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_089"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_090"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_091"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_092"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_093"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_094"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_095"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_096"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_097"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_098"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_099"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="insert into t_temp_ecart (valeur) values ("+System.Convert.ToDouble(MyData.Tables["t_controles_cam"].Rows[0]["val_100"].ToString()).ToString().Replace(",",".")+")";
			Comm.ExecuteNonQuery();
			Comm.CommandText="select * from t_temp_ecart order by valeur ASC";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(MyData,"t_temp_ecart");
			Comm.CommandText="delete * from t_temp_ecart_tri";
			Comm.ExecuteNonQuery();
			Double Cpt=1.000;
			foreach(DataRow row in MyData.Tables["t_temp_ecart"].Rows)
			{
				Double Position=(System.Convert.ToDouble(row["valeur"].ToString())-System.Convert.ToDouble(Moyenne))/System.Convert.ToDouble(EcartType1);
				Double ProbaTheo=poz(Position);
				Double ProbaReelle=Cpt/100.000;
				Double Diff=Math.Abs(ProbaTheo-ProbaReelle);
				Comm.CommandText="insert into t_temp_ecart_tri (valeur,position_stat,ProbaTheo,ProbaReelle,DiffProba) values ("+row["valeur"].ToString().Replace(",",".")+","+Position.ToString("0.000").Replace(",",".")+","+ProbaTheo.ToString("0.0000").Replace(",",".")+","+ProbaReelle.ToString("0.0000").Replace(",",".")+","+Diff.ToString("0.0000").Replace(",",".")+")";                                              
				try
				{
					Comm.ExecuteNonQuery();
				}
				catch(Exception exp)
				{
					MessageBox.Show(exp.Message);
				}
				Cpt++;
			}
			DataSet Kolmogorov = new DataSet();
			Comm.CommandText="SELECT Max(T_temp_ecart_tri.DiffProba) AS MaxDeDiffProba FROM T_temp_ecart_tri";
			DataAD.SelectCommand=Comm;
			DataAD.Fill(Kolmogorov,"T_temp_ecart_tri");
			Kolmo=System.Convert.ToDouble(Kolmogorov.Tables["t_temp_ecart_tri"].Rows[0]["MaxDeDiffProba"].ToString());
			oleDbConnection1.Close();
		}

		private Double poz(Double z)
		{
			Double y=0, x, w;
			Double z_max;
			z_max = 6; 
			if (z == 0)
				x = 0;
			else
				y = 0.5 * Math.Abs(z); 
			if(y >= z_max * 0.5)
				x = 1;
			else if (y < 1)
			{
				w = y * y; 
				x = ((((((((0.000124818987 * w - 0.001075204047) * w + 0.005198775019) * w - 0.019198292004) * w + 0.059054035642) * w - 0.151968751364) * w + 0.319152932694) * w - 0.5319230073) * w + 0.797884560593) * y * 2; 
			}
			else 
			{
				y = y - 2; 
				x = (((((((((((((-0.000045255659 * y + 0.00015252929) * y - 0.000019538132) * y - 0.000676904986) * y + 0.001390604284) * y - 0.00079462082) * y - 0.002034254874) * y + 0.006549791214) * y - 0.010557625006) * y + 0.011630447319) * y - 0.009279453341) * y + 0.005353579108) * y - 0.002141268741) * y + 0.000535310849) * y + 0.999936657524;
			}
			if (z > 0)
				return ((x + 1) * 0.5);
			else 
				return ((1 - x) * 0.5);   

		}

		public Bitmap PrintWindowEx()
		{
			Bitmap bmp = null;
			Graphics gr = null;
			IntPtr hdc = IntPtr.Zero;

			try
			{
				bmp = new Bitmap( panel1.ClientRectangle.Width, panel1.ClientRectangle.Height, panel1.CreateGraphics() );
				gr = Graphics.FromImage(bmp);
				hdc = gr.GetHdc();
				IntPtr wParam = hdc;
				IntPtr lParam = new IntPtr(PRF_CLIENT | PRF_CHILDREN);
				Message msg = Message.Create(panel1.Handle, WM_PRINT, wParam, lParam);
				this.WndProc(ref msg);
			}
			catch{}
			finally
			{
				if ( gr != null )
				{
					if (hdc != IntPtr.Zero)
						gr.ReleaseHdc(hdc);
					gr.Dispose();
				}
			}
			return bmp;
		}


		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GraphiquesCAM));
			this.chartControl1 = new J4L.RChart.ChartControl();
			this.chartControl2 = new J4L.RChart.ChartControl();
			this.chartControl3 = new J4L.RChart.ChartControl();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.chartControl4 = new J4L.RChart.ChartControl();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chartControl1
			// 
			this.chartControl1.BackColor = System.Drawing.Color.White;
			this.chartControl1.Location = new System.Drawing.Point(48, 32);
			this.chartControl1.Name = "chartControl1";
			this.chartControl1.Size = new System.Drawing.Size(760, 208);
			this.chartControl1.TabIndex = 0;
			this.chartControl1.Text = "chartControl1";
			// 
			// chartControl2
			// 
			this.chartControl2.BackColor = System.Drawing.Color.White;
			this.chartControl2.Location = new System.Drawing.Point(112, 224);
			this.chartControl2.Name = "chartControl2";
			this.chartControl2.Size = new System.Drawing.Size(760, 192);
			this.chartControl2.TabIndex = 3;
			this.chartControl2.Text = "chartControl2";
			// 
			// chartControl3
			// 
			this.chartControl3.BackColor = System.Drawing.Color.White;
			this.chartControl3.Location = new System.Drawing.Point(112, 424);
			this.chartControl3.Name = "chartControl3";
			this.chartControl3.Size = new System.Drawing.Size(760, 248);
			this.chartControl3.TabIndex = 4;
			this.chartControl3.Text = "chartControl3";
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// chartControl4
			// 
			this.chartControl4.BackColor = System.Drawing.Color.White;
			this.chartControl4.Location = new System.Drawing.Point(112, 680);
			this.chartControl4.Name = "chartControl4";
			this.chartControl4.Size = new System.Drawing.Size(760, 208);
			this.chartControl4.TabIndex = 5;
			this.chartControl4.Text = "chartControl4";
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
			this.printPreviewDialog1.Location = new System.Drawing.Point(290, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chartControl1);
			this.panel1.Location = new System.Drawing.Point(56, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(832, 280);
			this.panel1.TabIndex = 6;
			// 
			// GraphiquesCAM
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(992, 894);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.chartControl4);
			this.Controls.Add(this.chartControl3);
			this.Controls.Add(this.chartControl2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "GraphiquesCAM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
            
		}
	}
}
