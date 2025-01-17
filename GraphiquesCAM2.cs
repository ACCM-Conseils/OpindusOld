using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using J4L.RChart;

namespace Opindus
{
	/// <summary>
	/// Description résumée de GraphiquesCAM2.
	/// </summary>
	public class GraphiquesCAM2 : System.Windows.Forms.Form
	{
		private OleDbCommand Comm;
		private OleDbDataAdapter DataAD;
		private DataSet MyData;
		private J4L.RChart.ChartControl chartControl1;
		private J4L.RChart.ChartControl chartControl2;
		private System.Windows.Forms.Label label1;
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
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.TextBox ech1;
		private System.Windows.Forms.TextBox ech2;
		private System.Windows.Forms.TextBox ech3;
		private System.Windows.Forms.TextBox ech4;
		private System.Windows.Forms.TextBox ech5;
		private System.Windows.Forms.TextBox ech6;
		private System.Windows.Forms.TextBox ech7;
		private System.Windows.Forms.TextBox ech8;
		private System.Windows.Forms.TextBox ech9;
		private System.Windows.Forms.TextBox ech10;
		private System.Windows.Forms.TextBox ech16;
		private System.Windows.Forms.TextBox ech11;
		private System.Windows.Forms.TextBox ech17;
		private System.Windows.Forms.TextBox ech12;
		private System.Windows.Forms.TextBox ech18;
		private System.Windows.Forms.TextBox ech13;
		private System.Windows.Forms.TextBox ech19;
		private System.Windows.Forms.TextBox ech14;
		private System.Windows.Forms.TextBox ech20;
		private System.Windows.Forms.TextBox ech15;
		private System.Windows.Forms.TextBox ech26;
		private System.Windows.Forms.TextBox ech21;
		private System.Windows.Forms.TextBox ech27;
		private System.Windows.Forms.TextBox ech22;
		private System.Windows.Forms.TextBox ech28;
		private System.Windows.Forms.TextBox ech23;
		private System.Windows.Forms.TextBox ech29;
		private System.Windows.Forms.TextBox ech24;
		private System.Windows.Forms.TextBox ech30;
		private System.Windows.Forms.TextBox ech25;
		private System.Windows.Forms.TextBox et1;
		private System.Windows.Forms.TextBox txMoy1;
		private System.Windows.Forms.TextBox txMoy5;
		private System.Windows.Forms.TextBox txMoy4;
		private System.Windows.Forms.TextBox txMoy3;
		private System.Windows.Forms.TextBox txMoy2;
		private System.Windows.Forms.TextBox et5;
		private System.Windows.Forms.TextBox et4;
		private System.Windows.Forms.TextBox et3;
		private System.Windows.Forms.TextBox et2;
		private System.Windows.Forms.TextBox et6;
		private System.Windows.Forms.TextBox txMoy6;
		private System.Windows.Forms.TextBox txMoy10;
		private System.Windows.Forms.TextBox txMoy9;
		private System.Windows.Forms.TextBox txMoy8;
		private System.Windows.Forms.TextBox txMoy7;
		private System.Windows.Forms.TextBox et10;
		private System.Windows.Forms.TextBox et9;
		private System.Windows.Forms.TextBox et8;
		private System.Windows.Forms.TextBox et7;
		private System.Windows.Forms.TextBox ech36;
		private System.Windows.Forms.TextBox ech31;
		private System.Windows.Forms.TextBox ech37;
		private System.Windows.Forms.TextBox ech32;
		private System.Windows.Forms.TextBox ech38;
		private System.Windows.Forms.TextBox ech33;
		private System.Windows.Forms.TextBox ech39;
		private System.Windows.Forms.TextBox ech34;
		private System.Windows.Forms.TextBox ech40;
		private System.Windows.Forms.TextBox ech35;
		private System.Windows.Forms.TextBox ech96;
		private System.Windows.Forms.TextBox ech91;
		private System.Windows.Forms.TextBox ech86;
		private System.Windows.Forms.TextBox ech81;
		private System.Windows.Forms.TextBox ech76;
		private System.Windows.Forms.TextBox ech71;
		private System.Windows.Forms.TextBox ech66;
		private System.Windows.Forms.TextBox ech61;
		private System.Windows.Forms.TextBox ech56;
		private System.Windows.Forms.TextBox ech51;
		private System.Windows.Forms.TextBox ech46;
		private System.Windows.Forms.TextBox ech41;
		private System.Windows.Forms.TextBox ech97;
		private System.Windows.Forms.TextBox ech92;
		private System.Windows.Forms.TextBox ech87;
		private System.Windows.Forms.TextBox ech82;
		private System.Windows.Forms.TextBox ech77;
		private System.Windows.Forms.TextBox ech72;
		private System.Windows.Forms.TextBox ech67;
		private System.Windows.Forms.TextBox ech62;
		private System.Windows.Forms.TextBox ech57;
		private System.Windows.Forms.TextBox ech52;
		private System.Windows.Forms.TextBox ech47;
		private System.Windows.Forms.TextBox ech42;
		private System.Windows.Forms.TextBox ech98;
		private System.Windows.Forms.TextBox ech93;
		private System.Windows.Forms.TextBox ech88;
		private System.Windows.Forms.TextBox ech83;
		private System.Windows.Forms.TextBox ech78;
		private System.Windows.Forms.TextBox ech73;
		private System.Windows.Forms.TextBox ech68;
		private System.Windows.Forms.TextBox ech63;
		private System.Windows.Forms.TextBox ech58;
		private System.Windows.Forms.TextBox ech53;
		private System.Windows.Forms.TextBox ech48;
		private System.Windows.Forms.TextBox ech43;
		private System.Windows.Forms.TextBox ech99;
		private System.Windows.Forms.TextBox ech94;
		private System.Windows.Forms.TextBox ech89;
		private System.Windows.Forms.TextBox ech84;
		private System.Windows.Forms.TextBox ech79;
		private System.Windows.Forms.TextBox ech74;
		private System.Windows.Forms.TextBox ech69;
		private System.Windows.Forms.TextBox ech64;
		private System.Windows.Forms.TextBox ech59;
		private System.Windows.Forms.TextBox ech54;
		private System.Windows.Forms.TextBox ech49;
		private System.Windows.Forms.TextBox ech44;
		private System.Windows.Forms.TextBox ech100;
		private System.Windows.Forms.TextBox ech95;
		private System.Windows.Forms.TextBox ech90;
		private System.Windows.Forms.TextBox ech85;
		private System.Windows.Forms.TextBox ech80;
		private System.Windows.Forms.TextBox ech75;
		private System.Windows.Forms.TextBox ech70;
		private System.Windows.Forms.TextBox ech65;
		private System.Windows.Forms.TextBox ech60;
		private System.Windows.Forms.TextBox ech55;
		private System.Windows.Forms.TextBox ech50;
		private System.Windows.Forms.TextBox ech45;
		private System.Windows.Forms.TextBox txMoy20;
		private System.Windows.Forms.TextBox txMoy19;
		private System.Windows.Forms.TextBox txMoy18;
		private System.Windows.Forms.TextBox txMoy17;
		private System.Windows.Forms.TextBox txMoy16;
		private System.Windows.Forms.TextBox txMoy15;
		private System.Windows.Forms.TextBox txMoy14;
		private System.Windows.Forms.TextBox txMoy13;
		private System.Windows.Forms.TextBox txMoy12;
		private System.Windows.Forms.TextBox txMoy11;
		private System.Windows.Forms.TextBox et20;
		private System.Windows.Forms.TextBox et19;
		private System.Windows.Forms.TextBox et18;
		private System.Windows.Forms.TextBox et17;
		private System.Windows.Forms.TextBox et16;
		private System.Windows.Forms.TextBox et15;
		private System.Windows.Forms.TextBox et14;
		private System.Windows.Forms.TextBox et13;
		private System.Windows.Forms.TextBox et12;
		private System.Windows.Forms.TextBox et11;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GraphiquesCAM2(int NbMesures, int NumControle)
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			DataAD = new OleDbDataAdapter();
			Comm = new OleDbCommand();
			Comm.Connection=oleDbConnection1;
			DataAD.SelectCommand=Comm;
			MyData=new DataSet();
			if(NbMesures.Equals(30))
			{
				Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017,"
					+"T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus], T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_affectation.Affectation, T_site.Site, T_parc_CAPTEURS.Chaine, T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM (T_site INNER JOIN (T_affectation INNER JOIN ((T_controles_cam INNER JOIN "
					+"T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site) INNER JOIN T_type_machine_Vis ON T_parc_machine.[Type machine] = T_type_machine_Vis.Code WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(MyData,"T_controles_cam");
				ech1.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_001"]).ToString("0.00");
				ech2.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_002"]).ToString("0.00");
				ech3.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_003"]).ToString("0.00");
				ech4.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_004"]).ToString("0.00");
				ech5.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_005"]).ToString("0.00");
				ech6.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_006"]).ToString("0.00");
				ech7.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_007"]).ToString("0.00");
				ech8.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_008"]).ToString("0.00");
				ech9.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_009"]).ToString("0.00");
				ech10.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_010"]).ToString("0.00");
				ech11.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_011"]).ToString("0.00");
				ech12.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_012"]).ToString("0.00");
				ech13.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_013"]).ToString("0.00");
				ech14.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_014"]).ToString("0.00");
				ech15.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_015"]).ToString("0.00");
				ech16.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_016"]).ToString("0.00");
				ech17.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_017"]).ToString("0.00");
				ech18.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_018"]).ToString("0.00");
				ech19.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_019"]).ToString("0.00");
				ech20.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_020"]).ToString("0.00");
				ech21.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_021"]).ToString("0.00");
				ech22.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_022"]).ToString("0.00");
				ech23.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_023"]).ToString("0.00");
				ech24.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_024"]).ToString("0.00");
				ech25.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_025"]).ToString("0.00");
				ech26.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_026"]).ToString("0.00");
				ech27.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_027"]).ToString("0.00");
				ech28.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_028"]).ToString("0.00");
				ech29.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_029"]).ToString("0.00");
				ech30.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_030"]).ToString("0.00");
				ech31.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_001"]).ToString("0.00");
				ech32.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_002"]).ToString("0.00");
				ech33.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_003"]).ToString("0.00");
				ech34.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_004"]).ToString("0.00");
				ech35.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_005"]).ToString("0.00");
				ech36.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_006"]).ToString("0.00");
				ech37.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_007"]).ToString("0.00");
				ech38.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_008"]).ToString("0.00");
				ech39.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_009"]).ToString("0.00");
				ech40.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_010"]).ToString("0.00");
				ech41.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_011"]).ToString("0.00");
				ech42.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_012"]).ToString("0.00");
				ech43.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_013"]).ToString("0.00");
				ech44.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_014"]).ToString("0.00");
				ech45.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_015"]).ToString("0.00");
				ech46.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_016"]).ToString("0.00");
				ech47.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_017"]).ToString("0.00");
				ech48.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_018"]).ToString("0.00");
				ech49.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_019"]).ToString("0.00");
				ech50.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_020"]).ToString("0.00");
				ech51.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_021"]).ToString("0.00");
				ech52.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_022"]).ToString("0.00");
				ech53.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_023"]).ToString("0.00");
				ech54.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_024"]).ToString("0.00");
				ech55.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_025"]).ToString("0.00");
				ech56.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_026"]).ToString("0.00");
				ech57.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_027"]).ToString("0.00");
				ech58.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_028"]).ToString("0.00");
				ech59.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_029"]).ToString("0.00");
				ech60.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_030"]).ToString("0.00");
				ech61.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_001"]).ToString("0.00");
				ech62.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_002"]).ToString("0.00");
				ech63.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_003"]).ToString("0.00");
				ech64.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_004"]).ToString("0.00");
				ech65.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_005"]).ToString("0.00");
				ech66.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_006"]).ToString("0.00");
				ech67.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_007"]).ToString("0.00");
				ech68.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_008"]).ToString("0.00");
				ech69.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_009"]).ToString("0.00");
				ech70.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_010"]).ToString("0.00");
				ech71.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_011"]).ToString("0.00");
				ech72.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_012"]).ToString("0.00");
				ech73.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_013"]).ToString("0.00");
				ech74.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_014"]).ToString("0.00");
				ech75.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_015"]).ToString("0.00");
				ech76.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_016"]).ToString("0.00");
				ech77.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_017"]).ToString("0.00");
				ech78.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_018"]).ToString("0.00");
				ech79.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_019"]).ToString("0.00");
				ech80.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_020"]).ToString("0.00");
				ech81.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_021"]).ToString("0.00");
				ech82.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_022"]).ToString("0.00");
				ech83.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_023"]).ToString("0.00");
				ech84.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_024"]).ToString("0.00");
				ech85.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_025"]).ToString("0.00");
				ech86.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_026"]).ToString("0.00");
				ech87.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_027"]).ToString("0.00");
				ech88.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_028"]).ToString("0.00");
				ech89.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_029"]).ToString("0.00");
				ech90.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_030"]).ToString("0.00");
				ech91.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_001"]).ToString("0.00");
				ech92.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_002"]).ToString("0.00");
				ech93.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_003"]).ToString("0.00");
				ech94.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_004"]).ToString("0.00");
				ech95.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_005"]).ToString("0.00");
				ech96.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_006"]).ToString("0.00");
				ech97.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_007"]).ToString("0.00");
				ech98.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_008"]).ToString("0.00");
				ech99.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_009"]).ToString("0.00");
				ech100.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_010"]).ToString("0.00");
				Decimal moy=(System.Convert.ToDecimal(ech1.Text)+System.Convert.ToDecimal(ech2.Text)+System.Convert.ToDecimal(ech3.Text)+System.Convert.ToDecimal(ech4.Text)+System.Convert.ToDecimal(ech5.Text))/5;
				txMoy1.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech6.Text)+System.Convert.ToDecimal(ech7.Text)+System.Convert.ToDecimal(ech8.Text)+System.Convert.ToDecimal(ech9.Text)+System.Convert.ToDecimal(ech10.Text))/5;
				txMoy2.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech11.Text)+System.Convert.ToDecimal(ech12.Text)+System.Convert.ToDecimal(ech13.Text)+System.Convert.ToDecimal(ech14.Text)+System.Convert.ToDecimal(ech15.Text))/5;
				txMoy3.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech16.Text)+System.Convert.ToDecimal(ech17.Text)+System.Convert.ToDecimal(ech18.Text)+System.Convert.ToDecimal(ech19.Text)+System.Convert.ToDecimal(ech20.Text))/5;
				txMoy4.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech21.Text)+System.Convert.ToDecimal(ech22.Text)+System.Convert.ToDecimal(ech23.Text)+System.Convert.ToDecimal(ech24.Text)+System.Convert.ToDecimal(ech25.Text))/5;
				txMoy5.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech26.Text)+System.Convert.ToDecimal(ech27.Text)+System.Convert.ToDecimal(ech28.Text)+System.Convert.ToDecimal(ech29.Text)+System.Convert.ToDecimal(ech30.Text))/5;
				txMoy6.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech1.Text)+System.Convert.ToDecimal(ech2.Text)+System.Convert.ToDecimal(ech3.Text)+System.Convert.ToDecimal(ech4.Text)+System.Convert.ToDecimal(ech5.Text))/5;
				txMoy7.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech6.Text)+System.Convert.ToDecimal(ech7.Text)+System.Convert.ToDecimal(ech8.Text)+System.Convert.ToDecimal(ech9.Text)+System.Convert.ToDecimal(ech10.Text))/5;
				txMoy8.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech11.Text)+System.Convert.ToDecimal(ech12.Text)+System.Convert.ToDecimal(ech13.Text)+System.Convert.ToDecimal(ech14.Text)+System.Convert.ToDecimal(ech15.Text))/5;
				txMoy9.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech16.Text)+System.Convert.ToDecimal(ech17.Text)+System.Convert.ToDecimal(ech18.Text)+System.Convert.ToDecimal(ech19.Text)+System.Convert.ToDecimal(ech20.Text))/5;
				txMoy10.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech21.Text)+System.Convert.ToDecimal(ech22.Text)+System.Convert.ToDecimal(ech23.Text)+System.Convert.ToDecimal(ech24.Text)+System.Convert.ToDecimal(ech25.Text))/5;
				txMoy11.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech26.Text)+System.Convert.ToDecimal(ech27.Text)+System.Convert.ToDecimal(ech28.Text)+System.Convert.ToDecimal(ech29.Text)+System.Convert.ToDecimal(ech30.Text))/5;
				txMoy12.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech1.Text)+System.Convert.ToDecimal(ech2.Text)+System.Convert.ToDecimal(ech3.Text)+System.Convert.ToDecimal(ech4.Text)+System.Convert.ToDecimal(ech5.Text))/5;
				txMoy13.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech6.Text)+System.Convert.ToDecimal(ech7.Text)+System.Convert.ToDecimal(ech8.Text)+System.Convert.ToDecimal(ech9.Text)+System.Convert.ToDecimal(ech10.Text))/5;
				txMoy14.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech11.Text)+System.Convert.ToDecimal(ech12.Text)+System.Convert.ToDecimal(ech13.Text)+System.Convert.ToDecimal(ech14.Text)+System.Convert.ToDecimal(ech15.Text))/5;
				txMoy15.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech16.Text)+System.Convert.ToDecimal(ech17.Text)+System.Convert.ToDecimal(ech18.Text)+System.Convert.ToDecimal(ech19.Text)+System.Convert.ToDecimal(ech20.Text))/5;
				txMoy16.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech21.Text)+System.Convert.ToDecimal(ech22.Text)+System.Convert.ToDecimal(ech23.Text)+System.Convert.ToDecimal(ech24.Text)+System.Convert.ToDecimal(ech25.Text))/5;
				txMoy17.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech26.Text)+System.Convert.ToDecimal(ech27.Text)+System.Convert.ToDecimal(ech28.Text)+System.Convert.ToDecimal(ech29.Text)+System.Convert.ToDecimal(ech30.Text))/5;
				txMoy18.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech1.Text)+System.Convert.ToDecimal(ech2.Text)+System.Convert.ToDecimal(ech3.Text)+System.Convert.ToDecimal(ech4.Text)+System.Convert.ToDecimal(ech5.Text))/5;
				txMoy19.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech6.Text)+System.Convert.ToDecimal(ech7.Text)+System.Convert.ToDecimal(ech8.Text)+System.Convert.ToDecimal(ech9.Text)+System.Convert.ToDecimal(ech10.Text))/5;
				txMoy20.Text=moy.ToString("0.000");
				Decimal TotalMoyenne=(System.Convert.ToDecimal(txMoy1.Text)+System.Convert.ToDecimal(txMoy2.Text)+System.Convert.ToDecimal(txMoy3.Text)+System.Convert.ToDecimal(txMoy4.Text)+System.Convert.ToDecimal(txMoy5.Text)+System.Convert.ToDecimal(txMoy6.Text))/6;
				Decimal MaxMoyenne=0;
				if(System.Convert.ToDecimal(txMoy1.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy1.Text);
				if(System.Convert.ToDecimal(txMoy2.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy2.Text);
				if(System.Convert.ToDecimal(txMoy3.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy3.Text);
				if(System.Convert.ToDecimal(txMoy4.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy4.Text);
				if(System.Convert.ToDecimal(txMoy5.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy5.Text);
				if(System.Convert.ToDecimal(txMoy6.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy6.Text);
				if(System.Convert.ToDecimal(txMoy7.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy7.Text);
				if(System.Convert.ToDecimal(txMoy8.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy8.Text);
				if(System.Convert.ToDecimal(txMoy9.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy9.Text);
				if(System.Convert.ToDecimal(txMoy10.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy10.Text);
				if(System.Convert.ToDecimal(txMoy11.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy11.Text);
				if(System.Convert.ToDecimal(txMoy12.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy12.Text);
				if(System.Convert.ToDecimal(txMoy13.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy13.Text);
				if(System.Convert.ToDecimal(txMoy14.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy14.Text);
				if(System.Convert.ToDecimal(txMoy15.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy15.Text);
				if(System.Convert.ToDecimal(txMoy16.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy16.Text);
				if(System.Convert.ToDecimal(txMoy17.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy17.Text);
				if(System.Convert.ToDecimal(txMoy18.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy18.Text);
				if(System.Convert.ToDecimal(txMoy19.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy19.Text);
				if(System.Convert.ToDecimal(txMoy20.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy20.Text);
				Decimal MinMoyenne=MaxMoyenne;
				if(System.Convert.ToDecimal(txMoy1.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy1.Text);
				if(System.Convert.ToDecimal(txMoy2.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy2.Text);
				if(System.Convert.ToDecimal(txMoy3.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy3.Text);
				if(System.Convert.ToDecimal(txMoy4.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy4.Text);
				if(System.Convert.ToDecimal(txMoy5.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy5.Text);
				if(System.Convert.ToDecimal(txMoy6.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy6.Text);
				if(System.Convert.ToDecimal(txMoy7.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy7.Text);
				if(System.Convert.ToDecimal(txMoy8.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy8.Text);
				if(System.Convert.ToDecimal(txMoy9.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy9.Text);
				if(System.Convert.ToDecimal(txMoy10.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy10.Text);
				if(System.Convert.ToDecimal(txMoy11.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy11.Text);
				if(System.Convert.ToDecimal(txMoy12.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy12.Text);
				if(System.Convert.ToDecimal(txMoy13.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy13.Text);
				if(System.Convert.ToDecimal(txMoy14.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy14.Text);
				if(System.Convert.ToDecimal(txMoy15.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy15.Text);
				if(System.Convert.ToDecimal(txMoy16.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy16.Text);
				if(System.Convert.ToDecimal(txMoy17.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy17.Text);
				if(System.Convert.ToDecimal(txMoy18.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy18.Text);
				if(System.Convert.ToDecimal(txMoy19.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy19.Text);
				if(System.Convert.ToDecimal(txMoy20.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy20.Text);
				ChartLoader chartLoader= chartControl1.getChartLoader();
				// set chart parameters 
				chartLoader.clearParams();
				chartLoader.setParameter("TITLECHART","Moyennes"); 
				chartLoader.setParameter("XSCALE_MIN","0"); 
				chartLoader.setParameter("XSCALE_MAX","3"); 
				chartLoader.setParameter("YSCALE_MIN","0"); 
				//chartLoader.setParameter("YSCALE_MAX",Max.ToString().Replace(",","."));
				chartLoader.setParameter("BIG_TICK_INTERVALY","1"); 
				chartLoader.setParameter("TICK_INTERVALY","10"); 
				chartLoader.setParameter("CERO_XAXIS","LINE"); 
				chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
				chartLoader.setParameter("SERIE_1","Moyenne"); 
				chartLoader.setParameter("SERIE_2","Limite supérieure"); 
				chartLoader.setParameter("SERIE_3","Limite inférieure");
				chartLoader.setParameter("SERIE_4","Mesures"); 
				chartLoader.setParameter("LEGEND","TRUE");
				chartLoader.setParameter("LEFT_MARGIN","0.20");
				chartLoader.setParameter("YAXIS_LABEL_FORMAT","{0:F1}");
				chartLoader.setParameter("SERIE_TYPE_1","LINE");
				chartLoader.setParameter("SERIE_STYLE_1","1|RED|LINE");
				chartLoader.setParameter("SERIE_STYLE_2","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_3","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_4","1|BLACK|LINE");
				chartLoader.setParameter("TICK_INTERVALY","1");
				chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
				chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("XAXIS_LABELS","Type machine|Poste|Cam");
				chartLoader.setParameter("BARCHART_CUMULATIVE","TRUE");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("SERIE_DATA_1",TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+
														"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_2",MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+
					"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_3",MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+
					"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_4",System.Convert.ToDecimal(txMoy1.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy2.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy3.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy4.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy5.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy6.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy7.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy8.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy9.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy10.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy11.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy12.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy13.Text).ToString()+
					"|"+System.Convert.ToDecimal(txMoy14.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy15.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy16.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy17.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy18.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy19.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy20.Text).ToString());
				chartLoader.setParameter("CHART_FILL","ffcc00"); 
				chartLoader.setParameter("YLABEL_VERTICAL","FALSE"); 
				chartLoader.setParameter("YAXIS_TICKATBASE","true");
				// create chart 
				chartControl1.buildChart();
				this.Update();
				Decimal Max=0;
				if(System.Convert.ToDecimal(ech1.Text)>Max)
					Max=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)>Max)
					Max=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)>Max)
					Max=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)>Max)
					Max=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)>Max)
					Max=System.Convert.ToDecimal(ech5.Text);
				Decimal Min=Max;
				if(System.Convert.ToDecimal(ech1.Text)<Min)
					Min=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)<Min)
					Min=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)<Min)
					Min=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)<Min)
					Min=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)<Min)
					Min=System.Convert.ToDecimal(ech5.Text);
				Decimal Diff=Max-Min;
				et1.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech6.Text)>Max)
					Max=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)>Max)
					Max=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)>Max)
					Max=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)>Max)
					Max=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)>Max)
					Max=System.Convert.ToDecimal(ech10.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech6.Text)<Min)
					Min=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)<Min)
					Min=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)<Min)
					Min=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)<Min)
					Min=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)<Min)
					Min=System.Convert.ToDecimal(ech10.Text);
				Diff=Max-Min;
				et2.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech11.Text)>Max)
					Max=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)>Max)
					Max=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)>Max)
					Max=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)>Max)
					Max=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)>Max)
					Max=System.Convert.ToDecimal(ech15.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech11.Text)<Min)
					Min=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)<Min)
					Min=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)<Min)
					Min=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)<Min)
					Min=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)<Min)
					Min=System.Convert.ToDecimal(ech15.Text);
				Diff=Max-Min;
				et3.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech16.Text)>Max)
					Max=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)>Max)
					Max=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)>Max)
					Max=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)>Max)
					Max=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)>Max)
					Max=System.Convert.ToDecimal(ech20.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech16.Text)<Min)
					Min=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)<Min)
					Min=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)<Min)
					Min=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)<Min)
					Min=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)<Min)
					Min=System.Convert.ToDecimal(ech20.Text);
				Diff=Max-Min;
				et4.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech21.Text)>Max)
					Max=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)>Max)
					Max=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)>Max)
					Max=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)>Max)
					Max=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)>Max)
					Max=System.Convert.ToDecimal(ech25.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech21.Text)<Min)
					Min=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)<Min)
					Min=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)<Min)
					Min=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)<Min)
					Min=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)<Min)
					Min=System.Convert.ToDecimal(ech25.Text);
				Diff=Max-Min;
				et5.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech26.Text)>Max)
					Max=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)>Max)
					Max=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)>Max)
					Max=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)>Max)
					Max=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)>Max)
					Max=System.Convert.ToDecimal(ech30.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech26.Text)<Min)
					Min=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)<Min)
					Min=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)<Min)
					Min=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)<Min)
					Min=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)<Min)
					Min=System.Convert.ToDecimal(ech30.Text);
				Diff=Max-Min;
				et6.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech1.Text)>Max)
					Max=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)>Max)
					Max=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)>Max)
					Max=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)>Max)
					Max=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)>Max)
					Max=System.Convert.ToDecimal(ech5.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech1.Text)<Min)
					Min=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)<Min)
					Min=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)<Min)
					Min=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)<Min)
					Min=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)<Min)
					Min=System.Convert.ToDecimal(ech5.Text);
				Diff=Max-Min;
				et7.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech6.Text)>Max)
					Max=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)>Max)
					Max=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)>Max)
					Max=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)>Max)
					Max=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)>Max)
					Max=System.Convert.ToDecimal(ech10.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech6.Text)<Min)
					Min=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)<Min)
					Min=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)<Min)
					Min=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)<Min)
					Min=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)<Min)
					Min=System.Convert.ToDecimal(ech10.Text);
				Diff=Max-Min;
				et8.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech11.Text)>Max)
					Max=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)>Max)
					Max=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)>Max)
					Max=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)>Max)
					Max=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)>Max)
					Max=System.Convert.ToDecimal(ech15.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech11.Text)<Min)
					Min=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)<Min)
					Min=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)<Min)
					Min=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)<Min)
					Min=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)<Min)
					Min=System.Convert.ToDecimal(ech15.Text);
				Diff=Max-Min;
				et9.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech16.Text)>Max)
					Max=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)>Max)
					Max=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)>Max)
					Max=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)>Max)
					Max=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)>Max)
					Max=System.Convert.ToDecimal(ech20.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech16.Text)<Min)
					Min=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)<Min)
					Min=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)<Min)
					Min=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)<Min)
					Min=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)<Min)
					Min=System.Convert.ToDecimal(ech20.Text);
				Diff=Max-Min;
				et10.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech21.Text)>Max)
					Max=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)>Max)
					Max=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)>Max)
					Max=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)>Max)
					Max=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)>Max)
					Max=System.Convert.ToDecimal(ech25.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech21.Text)<Min)
					Min=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)<Min)
					Min=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)<Min)
					Min=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)<Min)
					Min=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)<Min)
					Min=System.Convert.ToDecimal(ech25.Text);
				Diff=Max-Min;
				et11.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech26.Text)>Max)
					Max=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)>Max)
					Max=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)>Max)
					Max=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)>Max)
					Max=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)>Max)
					Max=System.Convert.ToDecimal(ech30.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech26.Text)<Min)
					Min=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)<Min)
					Min=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)<Min)
					Min=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)<Min)
					Min=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)<Min)
					Min=System.Convert.ToDecimal(ech30.Text);
				Diff=Max-Min;
				et12.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech1.Text)>Max)
					Max=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)>Max)
					Max=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)>Max)
					Max=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)>Max)
					Max=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)>Max)
					Max=System.Convert.ToDecimal(ech5.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech1.Text)<Min)
					Min=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)<Min)
					Min=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)<Min)
					Min=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)<Min)
					Min=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)<Min)
					Min=System.Convert.ToDecimal(ech5.Text);
				Diff=Max-Min;
				et13.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech6.Text)>Max)
					Max=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)>Max)
					Max=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)>Max)
					Max=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)>Max)
					Max=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)>Max)
					Max=System.Convert.ToDecimal(ech10.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech6.Text)<Min)
					Min=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)<Min)
					Min=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)<Min)
					Min=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)<Min)
					Min=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)<Min)
					Min=System.Convert.ToDecimal(ech10.Text);
				Diff=Max-Min;
				et14.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech11.Text)>Max)
					Max=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)>Max)
					Max=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)>Max)
					Max=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)>Max)
					Max=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)>Max)
					Max=System.Convert.ToDecimal(ech15.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech11.Text)<Min)
					Min=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)<Min)
					Min=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)<Min)
					Min=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)<Min)
					Min=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)<Min)
					Min=System.Convert.ToDecimal(ech15.Text);
				Diff=Max-Min;
				et15.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech16.Text)>Max)
					Max=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)>Max)
					Max=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)>Max)
					Max=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)>Max)
					Max=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)>Max)
					Max=System.Convert.ToDecimal(ech20.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech16.Text)<Min)
					Min=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)<Min)
					Min=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)<Min)
					Min=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)<Min)
					Min=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)<Min)
					Min=System.Convert.ToDecimal(ech20.Text);
				Diff=Max-Min;
				et16.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech21.Text)>Max)
					Max=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)>Max)
					Max=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)>Max)
					Max=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)>Max)
					Max=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)>Max)
					Max=System.Convert.ToDecimal(ech25.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech21.Text)<Min)
					Min=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)<Min)
					Min=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)<Min)
					Min=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)<Min)
					Min=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)<Min)
					Min=System.Convert.ToDecimal(ech25.Text);
				Diff=Max-Min;
				et17.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech26.Text)>Max)
					Max=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)>Max)
					Max=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)>Max)
					Max=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)>Max)
					Max=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)>Max)
					Max=System.Convert.ToDecimal(ech30.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech26.Text)<Min)
					Min=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)<Min)
					Min=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)<Min)
					Min=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)<Min)
					Min=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)<Min)
					Min=System.Convert.ToDecimal(ech30.Text);
				Diff=Max-Min;
				et18.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech1.Text)>Max)
					Max=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)>Max)
					Max=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)>Max)
					Max=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)>Max)
					Max=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)>Max)
					Max=System.Convert.ToDecimal(ech5.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech1.Text)<Min)
					Min=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)<Min)
					Min=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)<Min)
					Min=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)<Min)
					Min=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)<Min)
					Min=System.Convert.ToDecimal(ech5.Text);
				Diff=Max-Min;
				et19.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech6.Text)>Max)
					Max=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)>Max)
					Max=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)>Max)
					Max=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)>Max)
					Max=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)>Max)
					Max=System.Convert.ToDecimal(ech10.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech6.Text)<Min)
					Min=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)<Min)
					Min=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)<Min)
					Min=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)<Min)
					Min=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)<Min)
					Min=System.Convert.ToDecimal(ech10.Text);
				Diff=Max-Min;
				et20.Text=Diff.ToString("0.000");
				MaxMoyenne=0;
				if(System.Convert.ToDecimal(et1.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et1.Text);
				if(System.Convert.ToDecimal(et2.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et2.Text);
				if(System.Convert.ToDecimal(et3.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et3.Text);
				if(System.Convert.ToDecimal(et4.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et4.Text);
				if(System.Convert.ToDecimal(et5.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et5.Text);
				if(System.Convert.ToDecimal(et6.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et6.Text);
				if(System.Convert.ToDecimal(et7.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et7.Text);
				if(System.Convert.ToDecimal(et8.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et8.Text);
				if(System.Convert.ToDecimal(et9.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et9.Text);
				if(System.Convert.ToDecimal(et10.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et10.Text);
				if(System.Convert.ToDecimal(et11.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et11.Text);
				if(System.Convert.ToDecimal(et12.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et12.Text);
				if(System.Convert.ToDecimal(et13.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et13.Text);
				if(System.Convert.ToDecimal(et14.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et14.Text);
				if(System.Convert.ToDecimal(et15.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et15.Text);
				if(System.Convert.ToDecimal(et16.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et16.Text);
				if(System.Convert.ToDecimal(et17.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et17.Text);
				if(System.Convert.ToDecimal(et18.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et18.Text);
				if(System.Convert.ToDecimal(et19.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et19.Text);
				if(System.Convert.ToDecimal(et20.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et20.Text);
				chartLoader= chartControl2.getChartLoader();
				// set chart parameters 
				chartLoader.clearParams();
				chartLoader.setParameter("TITLECHART","Etendues"); 
				chartLoader.setParameter("XSCALE_MIN","0"); 
				chartLoader.setParameter("XSCALE_MAX","3"); 
				chartLoader.setParameter("YSCALE_MIN","0"); 
				//chartLoader.setParameter("YSCALE_MAX",Max.ToString().Replace(",","."));
				chartLoader.setParameter("BIG_TICK_INTERVALY","1"); 
				chartLoader.setParameter("TICK_INTERVALY","10"); 
				chartLoader.setParameter("CERO_XAXIS","LINE"); 
				chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
				chartLoader.setParameter("SERIE_1","Limite supérieure"); 
				chartLoader.setParameter("SERIE_2","Limite inférieure");
				chartLoader.setParameter("SERIE_3","Mesures"); 
				chartLoader.setParameter("LEGEND","TRUE");
				chartLoader.setParameter("LEFT_MARGIN","0.20");
				chartLoader.setParameter("YAXIS_LABEL_FORMAT","{0:F1}");
				chartLoader.setParameter("SERIE_TYPE_1","LINE");
				chartLoader.setParameter("SERIE_STYLE_1","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_2","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_3","1|BLACK|LINE");
				chartLoader.setParameter("TICK_INTERVALY","1");
				chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
				chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("XAXIS_LABELS","Type machine|Poste|Cam");
				chartLoader.setParameter("BARCHART_CUMULATIVE","TRUE");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("SERIE_DATA_1",MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+
					"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_2",0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+
					"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0);
				chartLoader.setParameter("SERIE_DATA_3",System.Convert.ToDecimal(et1.Text).ToString()+"|"+System.Convert.ToDecimal(et2.Text).ToString()+"|"+System.Convert.ToDecimal(et3.Text).ToString()+"|"+System.Convert.ToDecimal(et4.Text).ToString()+"|"+System.Convert.ToDecimal(et5.Text).ToString()+"|"+System.Convert.ToDecimal(et6.Text).ToString()+"|"+System.Convert.ToDecimal(et7.Text).ToString()+"|"+System.Convert.ToDecimal(et8.Text).ToString()+"|"+System.Convert.ToDecimal(et9.Text).ToString()+"|"+System.Convert.ToDecimal(et10.Text).ToString()+"|"+System.Convert.ToDecimal(et11.Text).ToString()+"|"+System.Convert.ToDecimal(et12.Text).ToString()+"|"+System.Convert.ToDecimal(et13.Text).ToString()+
					"|"+System.Convert.ToDecimal(et14.Text).ToString()+"|"+System.Convert.ToDecimal(et15.Text).ToString()+"|"+System.Convert.ToDecimal(et16.Text).ToString()+"|"+System.Convert.ToDecimal(et17.Text).ToString()+"|"+System.Convert.ToDecimal(et18.Text).ToString()+"|"+System.Convert.ToDecimal(et19.Text).ToString()+"|"+System.Convert.ToDecimal(et20.Text).ToString());
				chartLoader.setParameter("CHART_FILL","ffcc00"); 
				chartLoader.setParameter("YLABEL_VERTICAL","FALSE"); 
				chartLoader.setParameter("YAXIS_TICKATBASE","true");
				// create chart 
				chartControl2.buildChart();
			}
			else if (NbMesures.Equals(50))
			{
				Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017,"
					+"T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044,"
					+"T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050,T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus], T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_affectation.Affectation, T_site.Site, T_parc_CAPTEURS.Chaine, T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM (T_site INNER JOIN (T_affectation INNER JOIN ((T_controles_cam INNER JOIN "
					+"T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site) INNER JOIN T_type_machine_Vis ON T_parc_machine.[Type machine] = T_type_machine_Vis.Code WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(MyData,"T_controles_cam");
				ech1.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_001"]).ToString("0.00");
				ech2.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_002"]).ToString("0.00");
				ech3.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_003"]).ToString("0.00");
				ech4.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_004"]).ToString("0.00");
				ech5.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_005"]).ToString("0.00");
				ech6.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_006"]).ToString("0.00");
				ech7.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_007"]).ToString("0.00");
				ech8.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_008"]).ToString("0.00");
				ech9.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_009"]).ToString("0.00");
				ech10.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_010"]).ToString("0.00");
				ech11.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_011"]).ToString("0.00");
				ech12.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_012"]).ToString("0.00");
				ech13.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_013"]).ToString("0.00");
				ech14.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_014"]).ToString("0.00");
				ech15.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_015"]).ToString("0.00");
				ech16.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_016"]).ToString("0.00");
				ech17.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_017"]).ToString("0.00");
				ech18.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_018"]).ToString("0.00");
				ech19.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_019"]).ToString("0.00");
				ech20.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_020"]).ToString("0.00");
				ech21.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_021"]).ToString("0.00");
				ech22.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_022"]).ToString("0.00");
				ech23.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_023"]).ToString("0.00");
				ech24.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_024"]).ToString("0.00");
				ech25.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_025"]).ToString("0.00");
				ech26.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_026"]).ToString("0.00");
				ech27.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_027"]).ToString("0.00");
				ech28.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_028"]).ToString("0.00");
				ech29.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_029"]).ToString("0.00");
				ech30.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_030"]).ToString("0.00");
				ech31.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_031"]).ToString("0.00");
				ech32.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_032"]).ToString("0.00");
				ech33.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_033"]).ToString("0.00");
				ech34.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_034"]).ToString("0.00");
				ech35.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_035"]).ToString("0.00");
				ech36.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_036"]).ToString("0.00");
				ech37.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_037"]).ToString("0.00");
				ech38.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_038"]).ToString("0.00");
				ech39.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_039"]).ToString("0.00");
				ech40.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_040"]).ToString("0.00");
				ech41.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_041"]).ToString("0.00");
				ech42.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_042"]).ToString("0.00");
				ech43.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_043"]).ToString("0.00");
				ech44.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_044"]).ToString("0.00");
				ech45.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_045"]).ToString("0.00");
				ech46.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_046"]).ToString("0.00");
				ech47.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_047"]).ToString("0.00");
				ech48.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_048"]).ToString("0.00");
				ech49.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_049"]).ToString("0.00");
				ech50.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_050"]).ToString("0.00");
				ech51.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_001"]).ToString("0.00");
				ech52.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_002"]).ToString("0.00");
				ech53.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_003"]).ToString("0.00");
				ech54.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_004"]).ToString("0.00");
				ech55.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_005"]).ToString("0.00");
				ech56.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_006"]).ToString("0.00");
				ech57.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_007"]).ToString("0.00");
				ech58.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_008"]).ToString("0.00");
				ech59.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_009"]).ToString("0.00");
				ech60.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_010"]).ToString("0.00");
				ech61.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_011"]).ToString("0.00");
				ech62.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_012"]).ToString("0.00");
				ech63.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_013"]).ToString("0.00");
				ech64.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_014"]).ToString("0.00");
				ech65.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_015"]).ToString("0.00");
				ech66.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_016"]).ToString("0.00");
				ech67.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_017"]).ToString("0.00");
				ech68.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_018"]).ToString("0.00");
				ech69.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_019"]).ToString("0.00");
				ech70.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_020"]).ToString("0.00");
				ech71.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_021"]).ToString("0.00");
				ech72.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_022"]).ToString("0.00");
				ech73.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_023"]).ToString("0.00");
				ech74.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_024"]).ToString("0.00");
				ech75.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_025"]).ToString("0.00");
				ech76.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_026"]).ToString("0.00");
				ech77.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_027"]).ToString("0.00");
				ech78.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_028"]).ToString("0.00");
				ech79.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_029"]).ToString("0.00");
				ech80.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_030"]).ToString("0.00");
				ech81.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_031"]).ToString("0.00");
				ech82.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_032"]).ToString("0.00");
				ech83.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_033"]).ToString("0.00");
				ech84.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_034"]).ToString("0.00");
				ech85.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_035"]).ToString("0.00");
				ech86.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_036"]).ToString("0.00");
				ech87.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_037"]).ToString("0.00");
				ech88.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_038"]).ToString("0.00");
				ech89.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_039"]).ToString("0.00");
				ech90.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_040"]).ToString("0.00");
				ech91.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_041"]).ToString("0.00");
				ech92.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_042"]).ToString("0.00");
				ech93.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_043"]).ToString("0.00");
				ech94.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_044"]).ToString("0.00");
				ech95.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_045"]).ToString("0.00");
				ech96.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_046"]).ToString("0.00");
				ech97.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_047"]).ToString("0.00");
				ech98.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_048"]).ToString("0.00");
				ech99.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_049"]).ToString("0.00");
				ech100.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_050"]).ToString("0.00");
				Decimal moy=(System.Convert.ToDecimal(ech1.Text)+System.Convert.ToDecimal(ech2.Text)+System.Convert.ToDecimal(ech3.Text)+System.Convert.ToDecimal(ech4.Text)+System.Convert.ToDecimal(ech5.Text))/5;
				txMoy1.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech6.Text)+System.Convert.ToDecimal(ech7.Text)+System.Convert.ToDecimal(ech8.Text)+System.Convert.ToDecimal(ech9.Text)+System.Convert.ToDecimal(ech10.Text))/5;
				txMoy2.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech11.Text)+System.Convert.ToDecimal(ech12.Text)+System.Convert.ToDecimal(ech13.Text)+System.Convert.ToDecimal(ech14.Text)+System.Convert.ToDecimal(ech15.Text))/5;
				txMoy3.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech16.Text)+System.Convert.ToDecimal(ech17.Text)+System.Convert.ToDecimal(ech18.Text)+System.Convert.ToDecimal(ech19.Text)+System.Convert.ToDecimal(ech20.Text))/5;
				txMoy4.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech21.Text)+System.Convert.ToDecimal(ech22.Text)+System.Convert.ToDecimal(ech23.Text)+System.Convert.ToDecimal(ech24.Text)+System.Convert.ToDecimal(ech25.Text))/5;
				txMoy5.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech26.Text)+System.Convert.ToDecimal(ech27.Text)+System.Convert.ToDecimal(ech28.Text)+System.Convert.ToDecimal(ech29.Text)+System.Convert.ToDecimal(ech30.Text))/5;
				txMoy6.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech31.Text)+System.Convert.ToDecimal(ech32.Text)+System.Convert.ToDecimal(ech33.Text)+System.Convert.ToDecimal(ech34.Text)+System.Convert.ToDecimal(ech35.Text))/5;
				txMoy7.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech36.Text)+System.Convert.ToDecimal(ech37.Text)+System.Convert.ToDecimal(ech38.Text)+System.Convert.ToDecimal(ech39.Text)+System.Convert.ToDecimal(ech40.Text))/5;
				txMoy8.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech41.Text)+System.Convert.ToDecimal(ech42.Text)+System.Convert.ToDecimal(ech43.Text)+System.Convert.ToDecimal(ech44.Text)+System.Convert.ToDecimal(ech45.Text))/5;
				txMoy9.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech46.Text)+System.Convert.ToDecimal(ech47.Text)+System.Convert.ToDecimal(ech48.Text)+System.Convert.ToDecimal(ech49.Text)+System.Convert.ToDecimal(ech50.Text))/5;
				txMoy10.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech1.Text)+System.Convert.ToDecimal(ech2.Text)+System.Convert.ToDecimal(ech3.Text)+System.Convert.ToDecimal(ech4.Text)+System.Convert.ToDecimal(ech5.Text))/5;
				txMoy11.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech6.Text)+System.Convert.ToDecimal(ech7.Text)+System.Convert.ToDecimal(ech8.Text)+System.Convert.ToDecimal(ech9.Text)+System.Convert.ToDecimal(ech10.Text))/5;
				txMoy12.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech11.Text)+System.Convert.ToDecimal(ech12.Text)+System.Convert.ToDecimal(ech13.Text)+System.Convert.ToDecimal(ech14.Text)+System.Convert.ToDecimal(ech15.Text))/5;
				txMoy13.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech16.Text)+System.Convert.ToDecimal(ech17.Text)+System.Convert.ToDecimal(ech18.Text)+System.Convert.ToDecimal(ech19.Text)+System.Convert.ToDecimal(ech20.Text))/5;
				txMoy14.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech21.Text)+System.Convert.ToDecimal(ech22.Text)+System.Convert.ToDecimal(ech23.Text)+System.Convert.ToDecimal(ech24.Text)+System.Convert.ToDecimal(ech25.Text))/5;
				txMoy15.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech26.Text)+System.Convert.ToDecimal(ech27.Text)+System.Convert.ToDecimal(ech28.Text)+System.Convert.ToDecimal(ech29.Text)+System.Convert.ToDecimal(ech30.Text))/5;
				txMoy16.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech31.Text)+System.Convert.ToDecimal(ech32.Text)+System.Convert.ToDecimal(ech33.Text)+System.Convert.ToDecimal(ech34.Text)+System.Convert.ToDecimal(ech35.Text))/5;
				txMoy17.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech36.Text)+System.Convert.ToDecimal(ech37.Text)+System.Convert.ToDecimal(ech38.Text)+System.Convert.ToDecimal(ech39.Text)+System.Convert.ToDecimal(ech40.Text))/5;
				txMoy18.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech41.Text)+System.Convert.ToDecimal(ech42.Text)+System.Convert.ToDecimal(ech43.Text)+System.Convert.ToDecimal(ech44.Text)+System.Convert.ToDecimal(ech45.Text))/5;
				txMoy19.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech46.Text)+System.Convert.ToDecimal(ech47.Text)+System.Convert.ToDecimal(ech48.Text)+System.Convert.ToDecimal(ech49.Text)+System.Convert.ToDecimal(ech50.Text))/5;
				txMoy20.Text=moy.ToString("0.000");
				Decimal TotalMoyenne=(System.Convert.ToDecimal(txMoy1.Text)+System.Convert.ToDecimal(txMoy2.Text)+System.Convert.ToDecimal(txMoy3.Text)+System.Convert.ToDecimal(txMoy4.Text)+System.Convert.ToDecimal(txMoy5.Text)+System.Convert.ToDecimal(txMoy6.Text))/6;
				Decimal MaxMoyenne=0;
				if(System.Convert.ToDecimal(txMoy1.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy1.Text);
				if(System.Convert.ToDecimal(txMoy2.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy2.Text);
				if(System.Convert.ToDecimal(txMoy3.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy3.Text);
				if(System.Convert.ToDecimal(txMoy4.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy4.Text);
				if(System.Convert.ToDecimal(txMoy5.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy5.Text);
				if(System.Convert.ToDecimal(txMoy6.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy6.Text);
				if(System.Convert.ToDecimal(txMoy7.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy7.Text);
				if(System.Convert.ToDecimal(txMoy8.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy8.Text);
				if(System.Convert.ToDecimal(txMoy9.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy9.Text);
				if(System.Convert.ToDecimal(txMoy10.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy10.Text);
				if(System.Convert.ToDecimal(txMoy11.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy11.Text);
				if(System.Convert.ToDecimal(txMoy12.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy12.Text);
				if(System.Convert.ToDecimal(txMoy13.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy13.Text);
				if(System.Convert.ToDecimal(txMoy14.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy14.Text);
				if(System.Convert.ToDecimal(txMoy15.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy15.Text);
				if(System.Convert.ToDecimal(txMoy16.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy16.Text);
				if(System.Convert.ToDecimal(txMoy17.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy17.Text);
				if(System.Convert.ToDecimal(txMoy18.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy18.Text);
				if(System.Convert.ToDecimal(txMoy19.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy19.Text);
				if(System.Convert.ToDecimal(txMoy20.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy20.Text);
				Decimal MinMoyenne=MaxMoyenne;
				if(System.Convert.ToDecimal(txMoy1.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy1.Text);
				if(System.Convert.ToDecimal(txMoy2.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy2.Text);
				if(System.Convert.ToDecimal(txMoy3.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy3.Text);
				if(System.Convert.ToDecimal(txMoy4.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy4.Text);
				if(System.Convert.ToDecimal(txMoy5.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy5.Text);
				if(System.Convert.ToDecimal(txMoy6.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy6.Text);
				if(System.Convert.ToDecimal(txMoy7.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy7.Text);
				if(System.Convert.ToDecimal(txMoy8.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy8.Text);
				if(System.Convert.ToDecimal(txMoy9.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy9.Text);
				if(System.Convert.ToDecimal(txMoy10.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy10.Text);
				if(System.Convert.ToDecimal(txMoy11.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy11.Text);
				if(System.Convert.ToDecimal(txMoy12.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy12.Text);
				if(System.Convert.ToDecimal(txMoy13.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy13.Text);
				if(System.Convert.ToDecimal(txMoy14.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy14.Text);
				if(System.Convert.ToDecimal(txMoy15.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy15.Text);
				if(System.Convert.ToDecimal(txMoy16.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy16.Text);
				if(System.Convert.ToDecimal(txMoy17.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy17.Text);
				if(System.Convert.ToDecimal(txMoy18.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy18.Text);
				if(System.Convert.ToDecimal(txMoy19.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy19.Text);
				if(System.Convert.ToDecimal(txMoy20.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy20.Text);
				ChartLoader chartLoader= chartControl1.getChartLoader();
				// set chart parameters 
				chartLoader.clearParams();
				chartLoader.setParameter("TITLECHART","Moyennes"); 
				chartLoader.setParameter("XSCALE_MIN","0"); 
				chartLoader.setParameter("XSCALE_MAX","3"); 
				chartLoader.setParameter("YSCALE_MIN","0"); 
				//chartLoader.setParameter("YSCALE_MAX",Max.ToString().Replace(",","."));
				chartLoader.setParameter("BIG_TICK_INTERVALY","1"); 
				chartLoader.setParameter("TICK_INTERVALY","10"); 
				chartLoader.setParameter("CERO_XAXIS","LINE"); 
				chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
				chartLoader.setParameter("SERIE_1","Moyenne"); 
				chartLoader.setParameter("SERIE_2","Limite supérieure"); 
				chartLoader.setParameter("SERIE_3","Limite inférieure");
				chartLoader.setParameter("SERIE_4","Mesures"); 
				chartLoader.setParameter("LEGEND","TRUE");
				chartLoader.setParameter("LEFT_MARGIN","0.20");
				chartLoader.setParameter("YAXIS_LABEL_FORMAT","{0:F1}");
				chartLoader.setParameter("SERIE_TYPE_1","LINE");
				chartLoader.setParameter("SERIE_STYLE_1","1|RED|LINE");
				chartLoader.setParameter("SERIE_STYLE_2","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_3","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_4","1|BLACK|LINE");
				chartLoader.setParameter("TICK_INTERVALY","1");
				chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
				chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("XAXIS_LABELS","Type machine|Poste|Cam");
				chartLoader.setParameter("BARCHART_CUMULATIVE","TRUE");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("SERIE_DATA_1",TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+
					"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_2",MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+
					"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_3",MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+
					"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_4",System.Convert.ToDecimal(txMoy1.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy2.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy3.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy4.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy5.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy6.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy7.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy8.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy9.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy10.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy11.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy12.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy13.Text).ToString()+
					"|"+System.Convert.ToDecimal(txMoy14.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy15.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy16.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy17.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy18.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy19.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy20.Text).ToString());
				chartLoader.setParameter("CHART_FILL","ffcc00"); 
				chartLoader.setParameter("YLABEL_VERTICAL","FALSE"); 
				chartLoader.setParameter("YAXIS_TICKATBASE","true");
				// create chart 
				chartControl1.buildChart();
				this.Update();
				Decimal Max=0;
				if(System.Convert.ToDecimal(ech1.Text)>Max)
					Max=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)>Max)
					Max=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)>Max)
					Max=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)>Max)
					Max=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)>Max)
					Max=System.Convert.ToDecimal(ech5.Text);
				Decimal Min=Max;
				if(System.Convert.ToDecimal(ech1.Text)<Min)
					Min=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)<Min)
					Min=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)<Min)
					Min=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)<Min)
					Min=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)<Min)
					Min=System.Convert.ToDecimal(ech5.Text);
				Decimal Diff=Max-Min;
				et1.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech6.Text)>Max)
					Max=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)>Max)
					Max=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)>Max)
					Max=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)>Max)
					Max=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)>Max)
					Max=System.Convert.ToDecimal(ech10.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech6.Text)<Min)
					Min=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)<Min)
					Min=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)<Min)
					Min=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)<Min)
					Min=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)<Min)
					Min=System.Convert.ToDecimal(ech10.Text);
				Diff=Max-Min;
				et2.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech11.Text)>Max)
					Max=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)>Max)
					Max=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)>Max)
					Max=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)>Max)
					Max=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)>Max)
					Max=System.Convert.ToDecimal(ech15.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech11.Text)<Min)
					Min=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)<Min)
					Min=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)<Min)
					Min=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)<Min)
					Min=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)<Min)
					Min=System.Convert.ToDecimal(ech15.Text);
				Diff=Max-Min;
				et3.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech16.Text)>Max)
					Max=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)>Max)
					Max=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)>Max)
					Max=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)>Max)
					Max=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)>Max)
					Max=System.Convert.ToDecimal(ech20.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech16.Text)<Min)
					Min=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)<Min)
					Min=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)<Min)
					Min=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)<Min)
					Min=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)<Min)
					Min=System.Convert.ToDecimal(ech20.Text);
				Diff=Max-Min;
				et4.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech21.Text)>Max)
					Max=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)>Max)
					Max=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)>Max)
					Max=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)>Max)
					Max=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)>Max)
					Max=System.Convert.ToDecimal(ech25.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech21.Text)<Min)
					Min=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)<Min)
					Min=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)<Min)
					Min=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)<Min)
					Min=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)<Min)
					Min=System.Convert.ToDecimal(ech25.Text);
				Diff=Max-Min;
				et5.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech26.Text)>Max)
					Max=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)>Max)
					Max=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)>Max)
					Max=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)>Max)
					Max=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)>Max)
					Max=System.Convert.ToDecimal(ech30.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech26.Text)<Min)
					Min=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)<Min)
					Min=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)<Min)
					Min=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)<Min)
					Min=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)<Min)
					Min=System.Convert.ToDecimal(ech30.Text);
				Diff=Max-Min;
				et6.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech31.Text)>Max)
					Max=System.Convert.ToDecimal(ech31.Text);
				if(System.Convert.ToDecimal(ech32.Text)>Max)
					Max=System.Convert.ToDecimal(ech32.Text);
				if(System.Convert.ToDecimal(ech33.Text)>Max)
					Max=System.Convert.ToDecimal(ech33.Text);
				if(System.Convert.ToDecimal(ech34.Text)>Max)
					Max=System.Convert.ToDecimal(ech34.Text);
				if(System.Convert.ToDecimal(ech35.Text)>Max)
					Max=System.Convert.ToDecimal(ech35.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech31.Text)<Min)
					Min=System.Convert.ToDecimal(ech31.Text);
				if(System.Convert.ToDecimal(ech32.Text)<Min)
					Min=System.Convert.ToDecimal(ech32.Text);
				if(System.Convert.ToDecimal(ech33.Text)<Min)
					Min=System.Convert.ToDecimal(ech33.Text);
				if(System.Convert.ToDecimal(ech34.Text)<Min)
					Min=System.Convert.ToDecimal(ech34.Text);
				if(System.Convert.ToDecimal(ech35.Text)<Min)
					Min=System.Convert.ToDecimal(ech35.Text);
				Diff=Max-Min;
				et7.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech36.Text)>Max)
					Max=System.Convert.ToDecimal(ech36.Text);
				if(System.Convert.ToDecimal(ech37.Text)>Max)
					Max=System.Convert.ToDecimal(ech37.Text);
				if(System.Convert.ToDecimal(ech38.Text)>Max)
					Max=System.Convert.ToDecimal(ech38.Text);
				if(System.Convert.ToDecimal(ech39.Text)>Max)
					Max=System.Convert.ToDecimal(ech39.Text);
				if(System.Convert.ToDecimal(ech40.Text)>Max)
					Max=System.Convert.ToDecimal(ech40.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech36.Text)<Min)
					Min=System.Convert.ToDecimal(ech36.Text);
				if(System.Convert.ToDecimal(ech37.Text)<Min)
					Min=System.Convert.ToDecimal(ech37.Text);
				if(System.Convert.ToDecimal(ech38.Text)<Min)
					Min=System.Convert.ToDecimal(ech38.Text);
				if(System.Convert.ToDecimal(ech39.Text)<Min)
					Min=System.Convert.ToDecimal(ech39.Text);
				if(System.Convert.ToDecimal(ech40.Text)<Min)
					Min=System.Convert.ToDecimal(ech40.Text);
				Diff=Max-Min;
				et8.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech41.Text)>Max)
					Max=System.Convert.ToDecimal(ech41.Text);
				if(System.Convert.ToDecimal(ech42.Text)>Max)
					Max=System.Convert.ToDecimal(ech42.Text);
				if(System.Convert.ToDecimal(ech43.Text)>Max)
					Max=System.Convert.ToDecimal(ech43.Text);
				if(System.Convert.ToDecimal(ech44.Text)>Max)
					Max=System.Convert.ToDecimal(ech44.Text);
				if(System.Convert.ToDecimal(ech45.Text)>Max)
					Max=System.Convert.ToDecimal(ech45.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech41.Text)<Min)
					Min=System.Convert.ToDecimal(ech41.Text);
				if(System.Convert.ToDecimal(ech42.Text)<Min)
					Min=System.Convert.ToDecimal(ech42.Text);
				if(System.Convert.ToDecimal(ech43.Text)<Min)
					Min=System.Convert.ToDecimal(ech43.Text);
				if(System.Convert.ToDecimal(ech44.Text)<Min)
					Min=System.Convert.ToDecimal(ech44.Text);
				if(System.Convert.ToDecimal(ech45.Text)<Min)
					Min=System.Convert.ToDecimal(ech45.Text);
				Diff=Max-Min;
				et9.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech46.Text)>Max)
					Max=System.Convert.ToDecimal(ech46.Text);
				if(System.Convert.ToDecimal(ech47.Text)>Max)
					Max=System.Convert.ToDecimal(ech47.Text);
				if(System.Convert.ToDecimal(ech48.Text)>Max)
					Max=System.Convert.ToDecimal(ech48.Text);
				if(System.Convert.ToDecimal(ech49.Text)>Max)
					Max=System.Convert.ToDecimal(ech49.Text);
				if(System.Convert.ToDecimal(ech50.Text)>Max)
					Max=System.Convert.ToDecimal(ech50.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech46.Text)<Min)
					Min=System.Convert.ToDecimal(ech46.Text);
				if(System.Convert.ToDecimal(ech47.Text)<Min)
					Min=System.Convert.ToDecimal(ech47.Text);
				if(System.Convert.ToDecimal(ech48.Text)<Min)
					Min=System.Convert.ToDecimal(ech48.Text);
				if(System.Convert.ToDecimal(ech49.Text)<Min)
					Min=System.Convert.ToDecimal(ech49.Text);
				if(System.Convert.ToDecimal(ech50.Text)<Min)
					Min=System.Convert.ToDecimal(ech50.Text);
				Diff=Max-Min;
				et10.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech1.Text)>Max)
					Max=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)>Max)
					Max=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)>Max)
					Max=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)>Max)
					Max=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)>Max)
					Max=System.Convert.ToDecimal(ech5.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech1.Text)<Min)
					Min=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)<Min)
					Min=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)<Min)
					Min=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)<Min)
					Min=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)<Min)
					Min=System.Convert.ToDecimal(ech5.Text);
				Diff=Max-Min;
				et11.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech6.Text)>Max)
					Max=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)>Max)
					Max=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)>Max)
					Max=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)>Max)
					Max=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)>Max)
					Max=System.Convert.ToDecimal(ech10.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech6.Text)<Min)
					Min=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)<Min)
					Min=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)<Min)
					Min=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)<Min)
					Min=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)<Min)
					Min=System.Convert.ToDecimal(ech10.Text);
				Diff=Max-Min;
				et12.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech11.Text)>Max)
					Max=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)>Max)
					Max=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)>Max)
					Max=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)>Max)
					Max=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)>Max)
					Max=System.Convert.ToDecimal(ech15.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech11.Text)<Min)
					Min=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)<Min)
					Min=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)<Min)
					Min=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)<Min)
					Min=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)<Min)
					Min=System.Convert.ToDecimal(ech15.Text);
				Diff=Max-Min;
				et13.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech16.Text)>Max)
					Max=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)>Max)
					Max=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)>Max)
					Max=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)>Max)
					Max=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)>Max)
					Max=System.Convert.ToDecimal(ech20.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech16.Text)<Min)
					Min=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)<Min)
					Min=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)<Min)
					Min=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)<Min)
					Min=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)<Min)
					Min=System.Convert.ToDecimal(ech20.Text);
				Diff=Max-Min;
				et14.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech21.Text)>Max)
					Max=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)>Max)
					Max=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)>Max)
					Max=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)>Max)
					Max=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)>Max)
					Max=System.Convert.ToDecimal(ech25.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech21.Text)<Min)
					Min=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)<Min)
					Min=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)<Min)
					Min=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)<Min)
					Min=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)<Min)
					Min=System.Convert.ToDecimal(ech25.Text);
				Diff=Max-Min;
				et15.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech26.Text)>Max)
					Max=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)>Max)
					Max=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)>Max)
					Max=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)>Max)
					Max=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)>Max)
					Max=System.Convert.ToDecimal(ech30.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech26.Text)<Min)
					Min=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)<Min)
					Min=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)<Min)
					Min=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)<Min)
					Min=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)<Min)
					Min=System.Convert.ToDecimal(ech30.Text);
				Diff=Max-Min;
				et16.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech31.Text)>Max)
					Max=System.Convert.ToDecimal(ech31.Text);
				if(System.Convert.ToDecimal(ech32.Text)>Max)
					Max=System.Convert.ToDecimal(ech32.Text);
				if(System.Convert.ToDecimal(ech33.Text)>Max)
					Max=System.Convert.ToDecimal(ech33.Text);
				if(System.Convert.ToDecimal(ech34.Text)>Max)
					Max=System.Convert.ToDecimal(ech34.Text);
				if(System.Convert.ToDecimal(ech35.Text)>Max)
					Max=System.Convert.ToDecimal(ech35.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech31.Text)<Min)
					Min=System.Convert.ToDecimal(ech31.Text);
				if(System.Convert.ToDecimal(ech32.Text)<Min)
					Min=System.Convert.ToDecimal(ech32.Text);
				if(System.Convert.ToDecimal(ech33.Text)<Min)
					Min=System.Convert.ToDecimal(ech33.Text);
				if(System.Convert.ToDecimal(ech34.Text)<Min)
					Min=System.Convert.ToDecimal(ech34.Text);
				if(System.Convert.ToDecimal(ech35.Text)<Min)
					Min=System.Convert.ToDecimal(ech35.Text);
				Diff=Max-Min;
				et17.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech36.Text)>Max)
					Max=System.Convert.ToDecimal(ech36.Text);
				if(System.Convert.ToDecimal(ech37.Text)>Max)
					Max=System.Convert.ToDecimal(ech37.Text);
				if(System.Convert.ToDecimal(ech38.Text)>Max)
					Max=System.Convert.ToDecimal(ech38.Text);
				if(System.Convert.ToDecimal(ech39.Text)>Max)
					Max=System.Convert.ToDecimal(ech39.Text);
				if(System.Convert.ToDecimal(ech40.Text)>Max)
					Max=System.Convert.ToDecimal(ech40.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech36.Text)<Min)
					Min=System.Convert.ToDecimal(ech36.Text);
				if(System.Convert.ToDecimal(ech37.Text)<Min)
					Min=System.Convert.ToDecimal(ech37.Text);
				if(System.Convert.ToDecimal(ech38.Text)<Min)
					Min=System.Convert.ToDecimal(ech38.Text);
				if(System.Convert.ToDecimal(ech39.Text)<Min)
					Min=System.Convert.ToDecimal(ech39.Text);
				if(System.Convert.ToDecimal(ech40.Text)<Min)
					Min=System.Convert.ToDecimal(ech40.Text);
				Diff=Max-Min;
				et18.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech41.Text)>Max)
					Max=System.Convert.ToDecimal(ech41.Text);
				if(System.Convert.ToDecimal(ech42.Text)>Max)
					Max=System.Convert.ToDecimal(ech42.Text);
				if(System.Convert.ToDecimal(ech43.Text)>Max)
					Max=System.Convert.ToDecimal(ech43.Text);
				if(System.Convert.ToDecimal(ech44.Text)>Max)
					Max=System.Convert.ToDecimal(ech44.Text);
				if(System.Convert.ToDecimal(ech45.Text)>Max)
					Max=System.Convert.ToDecimal(ech45.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech41.Text)<Min)
					Min=System.Convert.ToDecimal(ech41.Text);
				if(System.Convert.ToDecimal(ech42.Text)<Min)
					Min=System.Convert.ToDecimal(ech42.Text);
				if(System.Convert.ToDecimal(ech43.Text)<Min)
					Min=System.Convert.ToDecimal(ech43.Text);
				if(System.Convert.ToDecimal(ech44.Text)<Min)
					Min=System.Convert.ToDecimal(ech44.Text);
				if(System.Convert.ToDecimal(ech45.Text)<Min)
					Min=System.Convert.ToDecimal(ech45.Text);
				Diff=Max-Min;
				et19.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech46.Text)>Max)
					Max=System.Convert.ToDecimal(ech46.Text);
				if(System.Convert.ToDecimal(ech47.Text)>Max)
					Max=System.Convert.ToDecimal(ech47.Text);
				if(System.Convert.ToDecimal(ech48.Text)>Max)
					Max=System.Convert.ToDecimal(ech48.Text);
				if(System.Convert.ToDecimal(ech49.Text)>Max)
					Max=System.Convert.ToDecimal(ech49.Text);
				if(System.Convert.ToDecimal(ech50.Text)>Max)
					Max=System.Convert.ToDecimal(ech50.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech46.Text)<Min)
					Min=System.Convert.ToDecimal(ech46.Text);
				if(System.Convert.ToDecimal(ech47.Text)<Min)
					Min=System.Convert.ToDecimal(ech47.Text);
				if(System.Convert.ToDecimal(ech48.Text)<Min)
					Min=System.Convert.ToDecimal(ech48.Text);
				if(System.Convert.ToDecimal(ech49.Text)<Min)
					Min=System.Convert.ToDecimal(ech49.Text);
				if(System.Convert.ToDecimal(ech50.Text)<Min)
					Min=System.Convert.ToDecimal(ech50.Text);
				Diff=Max-Min;
				et20.Text=Diff.ToString("0.000");
				MaxMoyenne=0;
				if(System.Convert.ToDecimal(et1.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et1.Text);
				if(System.Convert.ToDecimal(et2.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et2.Text);
				if(System.Convert.ToDecimal(et3.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et3.Text);
				if(System.Convert.ToDecimal(et4.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et4.Text);
				if(System.Convert.ToDecimal(et5.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et5.Text);
				if(System.Convert.ToDecimal(et6.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et6.Text);
				if(System.Convert.ToDecimal(et7.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et7.Text);
				if(System.Convert.ToDecimal(et8.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et8.Text);
				if(System.Convert.ToDecimal(et9.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et9.Text);
				if(System.Convert.ToDecimal(et10.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et10.Text);
				if(System.Convert.ToDecimal(et11.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et11.Text);
				if(System.Convert.ToDecimal(et12.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et12.Text);
				if(System.Convert.ToDecimal(et13.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et13.Text);
				if(System.Convert.ToDecimal(et14.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et14.Text);
				if(System.Convert.ToDecimal(et15.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et15.Text);
				if(System.Convert.ToDecimal(et16.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et16.Text);
				if(System.Convert.ToDecimal(et17.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et17.Text);
				if(System.Convert.ToDecimal(et18.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et18.Text);
				if(System.Convert.ToDecimal(et19.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et19.Text);
				if(System.Convert.ToDecimal(et20.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et20.Text);
				chartLoader= chartControl2.getChartLoader();
				// set chart parameters 
				chartLoader.clearParams();
				chartLoader.setParameter("TITLECHART","Etendues"); 
				chartLoader.setParameter("XSCALE_MIN","0"); 
				chartLoader.setParameter("XSCALE_MAX","3"); 
				chartLoader.setParameter("YSCALE_MIN","0"); 
				//chartLoader.setParameter("YSCALE_MAX",Max.ToString().Replace(",","."));
				chartLoader.setParameter("BIG_TICK_INTERVALY","1"); 
				chartLoader.setParameter("TICK_INTERVALY","10"); 
				chartLoader.setParameter("CERO_XAXIS","LINE"); 
				chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
				chartLoader.setParameter("SERIE_1","Limite supérieure"); 
				chartLoader.setParameter("SERIE_2","Limite inférieure");
				chartLoader.setParameter("SERIE_3","Mesures"); 
				chartLoader.setParameter("LEGEND","TRUE");
				chartLoader.setParameter("LEFT_MARGIN","0.20");
				chartLoader.setParameter("YAXIS_LABEL_FORMAT","{0:F1}");
				chartLoader.setParameter("SERIE_TYPE_1","LINE");
				chartLoader.setParameter("SERIE_STYLE_1","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_2","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_3","1|BLACK|LINE");
				chartLoader.setParameter("TICK_INTERVALY","1");
				chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
				chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("XAXIS_LABELS","Type machine|Poste|Cam");
				chartLoader.setParameter("BARCHART_CUMULATIVE","TRUE");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("SERIE_DATA_1",MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+
					"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_2",0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+
					"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0);
				chartLoader.setParameter("SERIE_DATA_3",System.Convert.ToDecimal(et1.Text).ToString()+"|"+System.Convert.ToDecimal(et2.Text).ToString()+"|"+System.Convert.ToDecimal(et3.Text).ToString()+"|"+System.Convert.ToDecimal(et4.Text).ToString()+"|"+System.Convert.ToDecimal(et5.Text).ToString()+"|"+System.Convert.ToDecimal(et6.Text).ToString()+"|"+System.Convert.ToDecimal(et7.Text).ToString()+"|"+System.Convert.ToDecimal(et8.Text).ToString()+"|"+System.Convert.ToDecimal(et9.Text).ToString()+"|"+System.Convert.ToDecimal(et10.Text).ToString()+"|"+System.Convert.ToDecimal(et11.Text).ToString()+"|"+System.Convert.ToDecimal(et12.Text).ToString()+"|"+System.Convert.ToDecimal(et13.Text).ToString()+
					"|"+System.Convert.ToDecimal(et14.Text).ToString()+"|"+System.Convert.ToDecimal(et15.Text).ToString()+"|"+System.Convert.ToDecimal(et16.Text).ToString()+"|"+System.Convert.ToDecimal(et17.Text).ToString()+"|"+System.Convert.ToDecimal(et18.Text).ToString()+"|"+System.Convert.ToDecimal(et19.Text).ToString()+"|"+System.Convert.ToDecimal(et20.Text).ToString());
				chartLoader.setParameter("CHART_FILL","ffcc00"); 
				chartLoader.setParameter("YLABEL_VERTICAL","FALSE"); 
				chartLoader.setParameter("YAXIS_TICKATBASE","true");
				// create chart 
				chartControl2.buildChart();
			}
			else if(NbMesures.Equals(100))
			{
				Comm.CommandText="SELECT T_controles_cam.[N° Controle], T_controles_cam.[Mini-poste], T_controles_cam.[Maxi-poste], T_controles_cam.Vitesse_mesuree, T_controles_cam.Date_controle, T_controles_cam.type_controle, T_controles_cam.Operateur, T_controles_cam.ets, T_controles_cam.Val_001, T_controles_cam.Val_002, T_controles_cam.Val_003, T_controles_cam.Val_004, T_controles_cam.Val_005, T_controles_cam.Val_006, T_controles_cam.Val_007, T_controles_cam.Val_008, T_controles_cam.Val_009, T_controles_cam.Val_010, T_controles_cam.Val_011, T_controles_cam.Val_012, T_controles_cam.Val_013, T_controles_cam.Val_014, T_controles_cam.Val_015, T_controles_cam.Val_016, T_controles_cam.Val_017,"
					+"T_controles_cam.Val_018, T_controles_cam.Val_019, T_controles_cam.Val_020, T_controles_cam.Val_021, T_controles_cam.Val_022, T_controles_cam.Val_023, T_controles_cam.Val_024, T_controles_cam.Val_025, T_controles_cam.Val_026, T_controles_cam.Val_027, T_controles_cam.Val_028, T_controles_cam.Val_029, T_controles_cam.Val_030, T_controles_cam.Val_031, T_controles_cam.Val_032, T_controles_cam.Val_033, T_controles_cam.Val_034, T_controles_cam.Val_035, T_controles_cam.Val_036, T_controles_cam.Val_037, T_controles_cam.Val_038, T_controles_cam.Val_039, T_controles_cam.Val_040, T_controles_cam.Val_041, T_controles_cam.Val_042, T_controles_cam.Val_043, T_controles_cam.Val_044,"
					+"T_controles_cam.Val_045, T_controles_cam.Val_046, T_controles_cam.Val_047, T_controles_cam.Val_048, T_controles_cam.Val_049, T_controles_cam.Val_050,T_controles_cam.Val_051,T_controles_cam.Val_052,T_controles_cam.Val_053,T_controles_cam.Val_054,T_controles_cam.Val_055,T_controles_cam.Val_056,T_controles_cam.Val_057,T_controles_cam.Val_058,T_controles_cam.Val_059,T_controles_cam.Val_060,T_controles_cam.Val_061,T_controles_cam.Val_062,T_controles_cam.Val_063,T_controles_cam.Val_064,T_controles_cam.Val_065,T_controles_cam.Val_066,T_controles_cam.Val_067,T_controles_cam.Val_068,T_controles_cam.Val_069,T_controles_cam.Val_070,T_controles_cam.Val_071,T_controles_cam.Val_072,"
					+"T_controles_cam.Val_073,T_controles_cam.Val_074,T_controles_cam.Val_075,T_controles_cam.Val_076,T_controles_cam.Val_077,T_controles_cam.Val_078,T_controles_cam.Val_079,T_controles_cam.Val_080,T_controles_cam.Val_081,T_controles_cam.Val_082,T_controles_cam.Val_083,T_controles_cam.Val_084,T_controles_cam.Val_085,T_controles_cam.Val_086,T_controles_cam.Val_087,T_controles_cam.Val_088,T_controles_cam.Val_089,T_controles_cam.Val_090,T_controles_cam.Val_091,T_controles_cam.Val_092,T_controles_cam.Val_093,T_controles_cam.Val_094,T_controles_cam.Val_095,T_controles_cam.Val_096,T_controles_cam.Val_097,T_controles_cam.Val_098,T_controles_cam.Val_099,T_controles_cam.Val_100,"
					+"T_controles_cam.Commentaire, T_controles_cam.[Code machine opindus], T_parc_machine.[Code Mabec], T_parc_machine.[Type machine], T_affectation.Affectation, T_site.Site, T_parc_CAPTEURS.Chaine, T_type_machine_Vis.C_mini, T_type_machine_Vis.C_maxi, T_type_machine_Vis.Vitesse FROM (T_site INNER JOIN (T_affectation INNER JOIN ((T_controles_cam INNER JOIN "
					+"T_parc_machine ON T_controles_cam.[Code machine opindus] = T_parc_machine.[Code machine Opindus]) INNER JOIN T_parc_CAPTEURS ON T_controles_cam.capteur = T_parc_CAPTEURS.ID) ON T_affectation.ID = T_parc_machine.Affectation) ON T_site.ID = T_parc_machine.Site) INNER JOIN T_type_machine_Vis ON T_parc_machine.[Type machine] = T_type_machine_Vis.Code WHERE (((T_controles_cam.[N° Controle])="+NumControle+"))";
				DataAD.SelectCommand=Comm;
				DataAD.Fill(MyData,"T_controles_cam");
				ech1.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_001"]).ToString("0.00");
				ech2.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_002"]).ToString("0.00");
				ech3.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_003"]).ToString("0.00");
				ech4.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_004"]).ToString("0.00");
				ech5.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_005"]).ToString("0.00");
				ech6.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_006"]).ToString("0.00");
				ech7.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_007"]).ToString("0.00");
				ech8.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_008"]).ToString("0.00");
				ech9.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_009"]).ToString("0.00");
				ech10.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_010"]).ToString("0.00");
				ech11.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_011"]).ToString("0.00");
				ech12.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_012"]).ToString("0.00");
				ech13.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_013"]).ToString("0.00");
				ech14.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_014"]).ToString("0.00");
				ech15.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_015"]).ToString("0.00");
				ech16.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_016"]).ToString("0.00");
				ech17.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_017"]).ToString("0.00");
				ech18.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_018"]).ToString("0.00");
				ech19.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_019"]).ToString("0.00");
				ech20.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_020"]).ToString("0.00");
				ech21.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_021"]).ToString("0.00");
				ech22.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_022"]).ToString("0.00");
				ech23.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_023"]).ToString("0.00");
				ech24.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_024"]).ToString("0.00");
				ech25.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_025"]).ToString("0.00");
				ech26.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_026"]).ToString("0.00");
				ech27.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_027"]).ToString("0.00");
				ech28.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_028"]).ToString("0.00");
				ech29.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_029"]).ToString("0.00");
				ech30.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_030"]).ToString("0.00");
				ech31.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_031"]).ToString("0.00");
				ech32.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_032"]).ToString("0.00");
				ech33.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_033"]).ToString("0.00");
				ech34.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_034"]).ToString("0.00");
				ech35.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_035"]).ToString("0.00");
				ech36.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_036"]).ToString("0.00");
				ech37.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_037"]).ToString("0.00");
				ech38.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_038"]).ToString("0.00");
				ech39.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_039"]).ToString("0.00");
				ech40.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_040"]).ToString("0.00");
				ech41.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_041"]).ToString("0.00");
				ech42.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_042"]).ToString("0.00");
				ech43.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_043"]).ToString("0.00");
				ech44.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_044"]).ToString("0.00");
				ech45.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_045"]).ToString("0.00");
				ech46.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_046"]).ToString("0.00");
				ech47.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_047"]).ToString("0.00");
				ech48.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_048"]).ToString("0.00");
				ech49.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_049"]).ToString("0.00");
				ech50.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_050"]).ToString("0.00");
				ech51.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_051"]).ToString("0.00");
				ech52.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_052"]).ToString("0.00");
				ech53.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_053"]).ToString("0.00");
				ech54.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_054"]).ToString("0.00");
				ech55.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_055"]).ToString("0.00");
				ech56.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_056"]).ToString("0.00");
				ech57.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_057"]).ToString("0.00");
				ech58.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_058"]).ToString("0.00");
				ech59.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_059"]).ToString("0.00");
				ech60.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_060"]).ToString("0.00");
				ech61.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_061"]).ToString("0.00");
				ech62.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_062"]).ToString("0.00");
				ech63.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_063"]).ToString("0.00");
				ech64.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_064"]).ToString("0.00");
				ech65.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_065"]).ToString("0.00");
				ech66.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_066"]).ToString("0.00");
				ech67.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_067"]).ToString("0.00");
				ech68.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_068"]).ToString("0.00");
				ech69.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_069"]).ToString("0.00");
				ech70.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_070"]).ToString("0.00");
				ech71.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_071"]).ToString("0.00");
				ech72.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_072"]).ToString("0.00");
				ech73.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_073"]).ToString("0.00");
				ech74.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_074"]).ToString("0.00");
				ech75.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_075"]).ToString("0.00");
				ech76.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_076"]).ToString("0.00");
				ech77.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_077"]).ToString("0.00");
				ech78.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_078"]).ToString("0.00");
				ech79.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_079"]).ToString("0.00");
				ech80.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_080"]).ToString("0.00");
				ech81.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_081"]).ToString("0.00");
				ech82.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_082"]).ToString("0.00");
				ech83.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_083"]).ToString("0.00");
				ech84.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_084"]).ToString("0.00");
				ech85.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_085"]).ToString("0.00");
				ech86.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_086"]).ToString("0.00");
				ech87.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_087"]).ToString("0.00");
				ech88.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_088"]).ToString("0.00");
				ech89.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_089"]).ToString("0.00");
				ech90.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_090"]).ToString("0.00");
				ech91.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_091"]).ToString("0.00");
				ech92.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_092"]).ToString("0.00");
				ech93.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_093"]).ToString("0.00");
				ech94.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_094"]).ToString("0.00");
				ech95.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_095"]).ToString("0.00");
				ech96.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_096"]).ToString("0.00");
				ech97.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_097"]).ToString("0.00");
				ech98.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_098"]).ToString("0.00");
				ech99.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_099"]).ToString("0.00");
				ech100.Text=System.Convert.ToDecimal(MyData.Tables["T_controles_cam"].Rows[0]["Val_100"]).ToString("0.00");
				Decimal moy=(System.Convert.ToDecimal(ech1.Text)+System.Convert.ToDecimal(ech2.Text)+System.Convert.ToDecimal(ech3.Text)+System.Convert.ToDecimal(ech4.Text)+System.Convert.ToDecimal(ech5.Text))/5;
				txMoy1.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech6.Text)+System.Convert.ToDecimal(ech7.Text)+System.Convert.ToDecimal(ech8.Text)+System.Convert.ToDecimal(ech9.Text)+System.Convert.ToDecimal(ech10.Text))/5;
				txMoy2.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech11.Text)+System.Convert.ToDecimal(ech12.Text)+System.Convert.ToDecimal(ech13.Text)+System.Convert.ToDecimal(ech14.Text)+System.Convert.ToDecimal(ech15.Text))/5;
				txMoy3.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech16.Text)+System.Convert.ToDecimal(ech17.Text)+System.Convert.ToDecimal(ech18.Text)+System.Convert.ToDecimal(ech19.Text)+System.Convert.ToDecimal(ech20.Text))/5;
				txMoy4.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech21.Text)+System.Convert.ToDecimal(ech22.Text)+System.Convert.ToDecimal(ech23.Text)+System.Convert.ToDecimal(ech24.Text)+System.Convert.ToDecimal(ech25.Text))/5;
				txMoy5.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech26.Text)+System.Convert.ToDecimal(ech27.Text)+System.Convert.ToDecimal(ech28.Text)+System.Convert.ToDecimal(ech29.Text)+System.Convert.ToDecimal(ech30.Text))/5;
				txMoy6.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech31.Text)+System.Convert.ToDecimal(ech32.Text)+System.Convert.ToDecimal(ech33.Text)+System.Convert.ToDecimal(ech34.Text)+System.Convert.ToDecimal(ech35.Text))/5;
				txMoy7.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech36.Text)+System.Convert.ToDecimal(ech37.Text)+System.Convert.ToDecimal(ech38.Text)+System.Convert.ToDecimal(ech39.Text)+System.Convert.ToDecimal(ech40.Text))/5;
				txMoy8.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech41.Text)+System.Convert.ToDecimal(ech42.Text)+System.Convert.ToDecimal(ech43.Text)+System.Convert.ToDecimal(ech44.Text)+System.Convert.ToDecimal(ech45.Text))/5;
				txMoy9.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech46.Text)+System.Convert.ToDecimal(ech47.Text)+System.Convert.ToDecimal(ech48.Text)+System.Convert.ToDecimal(ech49.Text)+System.Convert.ToDecimal(ech50.Text))/5;
				txMoy10.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech51.Text)+System.Convert.ToDecimal(ech52.Text)+System.Convert.ToDecimal(ech53.Text)+System.Convert.ToDecimal(ech54.Text)+System.Convert.ToDecimal(ech55.Text))/5;
				txMoy11.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech56.Text)+System.Convert.ToDecimal(ech57.Text)+System.Convert.ToDecimal(ech58.Text)+System.Convert.ToDecimal(ech59.Text)+System.Convert.ToDecimal(ech60.Text))/5;
				txMoy12.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech61.Text)+System.Convert.ToDecimal(ech62.Text)+System.Convert.ToDecimal(ech63.Text)+System.Convert.ToDecimal(ech64.Text)+System.Convert.ToDecimal(ech65.Text))/5;
				txMoy13.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech66.Text)+System.Convert.ToDecimal(ech67.Text)+System.Convert.ToDecimal(ech68.Text)+System.Convert.ToDecimal(ech69.Text)+System.Convert.ToDecimal(ech70.Text))/5;
				txMoy14.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech71.Text)+System.Convert.ToDecimal(ech72.Text)+System.Convert.ToDecimal(ech73.Text)+System.Convert.ToDecimal(ech74.Text)+System.Convert.ToDecimal(ech75.Text))/5;
				txMoy15.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech76.Text)+System.Convert.ToDecimal(ech77.Text)+System.Convert.ToDecimal(ech78.Text)+System.Convert.ToDecimal(ech79.Text)+System.Convert.ToDecimal(ech80.Text))/5;
				txMoy16.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech81.Text)+System.Convert.ToDecimal(ech82.Text)+System.Convert.ToDecimal(ech83.Text)+System.Convert.ToDecimal(ech84.Text)+System.Convert.ToDecimal(ech85.Text))/5;
				txMoy17.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech86.Text)+System.Convert.ToDecimal(ech87.Text)+System.Convert.ToDecimal(ech88.Text)+System.Convert.ToDecimal(ech89.Text)+System.Convert.ToDecimal(ech90.Text))/5;
				txMoy18.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech91.Text)+System.Convert.ToDecimal(ech92.Text)+System.Convert.ToDecimal(ech93.Text)+System.Convert.ToDecimal(ech94.Text)+System.Convert.ToDecimal(ech95.Text))/5;
				txMoy19.Text=moy.ToString("0.000");
				moy=(System.Convert.ToDecimal(ech96.Text)+System.Convert.ToDecimal(ech97.Text)+System.Convert.ToDecimal(ech98.Text)+System.Convert.ToDecimal(ech99.Text)+System.Convert.ToDecimal(ech100.Text))/5;
				txMoy20.Text=moy.ToString("0.000");
				Decimal TotalMoyenne=(System.Convert.ToDecimal(txMoy1.Text)+System.Convert.ToDecimal(txMoy2.Text)+System.Convert.ToDecimal(txMoy3.Text)+System.Convert.ToDecimal(txMoy4.Text)+System.Convert.ToDecimal(txMoy5.Text)+System.Convert.ToDecimal(txMoy6.Text))/6;
				Decimal MaxMoyenne=0;
				if(System.Convert.ToDecimal(txMoy1.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy1.Text);
				if(System.Convert.ToDecimal(txMoy2.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy2.Text);
				if(System.Convert.ToDecimal(txMoy3.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy3.Text);
				if(System.Convert.ToDecimal(txMoy4.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy4.Text);
				if(System.Convert.ToDecimal(txMoy5.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy5.Text);
				if(System.Convert.ToDecimal(txMoy6.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy6.Text);
				if(System.Convert.ToDecimal(txMoy7.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy7.Text);
				if(System.Convert.ToDecimal(txMoy8.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy8.Text);
				if(System.Convert.ToDecimal(txMoy9.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy9.Text);
				if(System.Convert.ToDecimal(txMoy10.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy10.Text);
				if(System.Convert.ToDecimal(txMoy11.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy11.Text);
				if(System.Convert.ToDecimal(txMoy12.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy12.Text);
				if(System.Convert.ToDecimal(txMoy13.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy13.Text);
				if(System.Convert.ToDecimal(txMoy14.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy14.Text);
				if(System.Convert.ToDecimal(txMoy15.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy15.Text);
				if(System.Convert.ToDecimal(txMoy16.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy16.Text);
				if(System.Convert.ToDecimal(txMoy17.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy17.Text);
				if(System.Convert.ToDecimal(txMoy18.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy18.Text);
				if(System.Convert.ToDecimal(txMoy19.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy19.Text);
				if(System.Convert.ToDecimal(txMoy20.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(txMoy20.Text);
				Decimal MinMoyenne=MaxMoyenne;
				if(System.Convert.ToDecimal(txMoy1.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy1.Text);
				if(System.Convert.ToDecimal(txMoy2.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy2.Text);
				if(System.Convert.ToDecimal(txMoy3.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy3.Text);
				if(System.Convert.ToDecimal(txMoy4.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy4.Text);
				if(System.Convert.ToDecimal(txMoy5.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy5.Text);
				if(System.Convert.ToDecimal(txMoy6.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy6.Text);
				if(System.Convert.ToDecimal(txMoy7.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy7.Text);
				if(System.Convert.ToDecimal(txMoy8.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy8.Text);
				if(System.Convert.ToDecimal(txMoy9.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy9.Text);
				if(System.Convert.ToDecimal(txMoy10.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy10.Text);
				if(System.Convert.ToDecimal(txMoy11.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy11.Text);
				if(System.Convert.ToDecimal(txMoy12.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy12.Text);
				if(System.Convert.ToDecimal(txMoy13.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy13.Text);
				if(System.Convert.ToDecimal(txMoy14.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy14.Text);
				if(System.Convert.ToDecimal(txMoy15.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy15.Text);
				if(System.Convert.ToDecimal(txMoy16.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy16.Text);
				if(System.Convert.ToDecimal(txMoy17.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy17.Text);
				if(System.Convert.ToDecimal(txMoy18.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy18.Text);
				if(System.Convert.ToDecimal(txMoy19.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy19.Text);
				if(System.Convert.ToDecimal(txMoy20.Text)<MinMoyenne)
					MinMoyenne=System.Convert.ToDecimal(txMoy20.Text);
				ChartLoader chartLoader= chartControl1.getChartLoader();
				// set chart parameters 
				chartLoader.clearParams();
				chartLoader.setParameter("TITLECHART","Moyennes"); 
				chartLoader.setParameter("XSCALE_MIN","0"); 
				chartLoader.setParameter("XSCALE_MAX","3"); 
				chartLoader.setParameter("YSCALE_MIN","0"); 
				//chartLoader.setParameter("YSCALE_MAX",Max.ToString().Replace(",","."));
				chartLoader.setParameter("BIG_TICK_INTERVALY","1"); 
				chartLoader.setParameter("TICK_INTERVALY","10"); 
				chartLoader.setParameter("CERO_XAXIS","LINE"); 
				chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
				chartLoader.setParameter("SERIE_1","Moyenne"); 
				chartLoader.setParameter("SERIE_2","Limite supérieure"); 
				chartLoader.setParameter("SERIE_3","Limite inférieure");
				chartLoader.setParameter("SERIE_4","Mesures"); 
				chartLoader.setParameter("LEGEND","TRUE");
				chartLoader.setParameter("LEFT_MARGIN","0.20");
				chartLoader.setParameter("YAXIS_LABEL_FORMAT","{0:F1}");
				chartLoader.setParameter("SERIE_TYPE_1","LINE");
				chartLoader.setParameter("SERIE_STYLE_1","1|RED|LINE");
				chartLoader.setParameter("SERIE_STYLE_2","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_3","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_4","1|BLACK|LINE");
				chartLoader.setParameter("TICK_INTERVALY","1");
				chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
				chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("XAXIS_LABELS","Type machine|Poste|Cam");
				chartLoader.setParameter("BARCHART_CUMULATIVE","TRUE");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("SERIE_DATA_1",TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+
					"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString()+"|"+TotalMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_2",MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+
					"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_3",MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+
					"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString()+"|"+MinMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_4",System.Convert.ToDecimal(txMoy1.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy2.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy3.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy4.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy5.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy6.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy7.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy8.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy9.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy10.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy11.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy12.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy13.Text).ToString()+
					"|"+System.Convert.ToDecimal(txMoy14.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy15.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy16.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy17.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy18.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy19.Text).ToString()+"|"+System.Convert.ToDecimal(txMoy20.Text).ToString());
				chartLoader.setParameter("CHART_FILL","ffcc00"); 
				chartLoader.setParameter("YLABEL_VERTICAL","FALSE"); 
				chartLoader.setParameter("YAXIS_TICKATBASE","true");
				// create chart 
				chartControl1.buildChart();
				this.Update();
				Decimal Max=0;
				if(System.Convert.ToDecimal(ech1.Text)>Max)
					Max=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)>Max)
					Max=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)>Max)
					Max=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)>Max)
					Max=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)>Max)
					Max=System.Convert.ToDecimal(ech5.Text);
				Decimal Min=Max;
				if(System.Convert.ToDecimal(ech1.Text)<Min)
					Min=System.Convert.ToDecimal(ech1.Text);
				if(System.Convert.ToDecimal(ech2.Text)<Min)
					Min=System.Convert.ToDecimal(ech2.Text);
				if(System.Convert.ToDecimal(ech3.Text)<Min)
					Min=System.Convert.ToDecimal(ech3.Text);
				if(System.Convert.ToDecimal(ech4.Text)<Min)
					Min=System.Convert.ToDecimal(ech4.Text);
				if(System.Convert.ToDecimal(ech5.Text)<Min)
					Min=System.Convert.ToDecimal(ech5.Text);
				Decimal Diff=Max-Min;
				et1.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech6.Text)>Max)
					Max=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)>Max)
					Max=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)>Max)
					Max=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)>Max)
					Max=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)>Max)
					Max=System.Convert.ToDecimal(ech10.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech6.Text)<Min)
					Min=System.Convert.ToDecimal(ech6.Text);
				if(System.Convert.ToDecimal(ech7.Text)<Min)
					Min=System.Convert.ToDecimal(ech7.Text);
				if(System.Convert.ToDecimal(ech8.Text)<Min)
					Min=System.Convert.ToDecimal(ech8.Text);
				if(System.Convert.ToDecimal(ech9.Text)<Min)
					Min=System.Convert.ToDecimal(ech9.Text);
				if(System.Convert.ToDecimal(ech10.Text)<Min)
					Min=System.Convert.ToDecimal(ech10.Text);
				Diff=Max-Min;
				et2.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech11.Text)>Max)
					Max=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)>Max)
					Max=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)>Max)
					Max=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)>Max)
					Max=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)>Max)
					Max=System.Convert.ToDecimal(ech15.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech11.Text)<Min)
					Min=System.Convert.ToDecimal(ech11.Text);
				if(System.Convert.ToDecimal(ech12.Text)<Min)
					Min=System.Convert.ToDecimal(ech12.Text);
				if(System.Convert.ToDecimal(ech13.Text)<Min)
					Min=System.Convert.ToDecimal(ech13.Text);
				if(System.Convert.ToDecimal(ech14.Text)<Min)
					Min=System.Convert.ToDecimal(ech14.Text);
				if(System.Convert.ToDecimal(ech15.Text)<Min)
					Min=System.Convert.ToDecimal(ech15.Text);
				Diff=Max-Min;
				et3.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech16.Text)>Max)
					Max=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)>Max)
					Max=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)>Max)
					Max=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)>Max)
					Max=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)>Max)
					Max=System.Convert.ToDecimal(ech20.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech16.Text)<Min)
					Min=System.Convert.ToDecimal(ech16.Text);
				if(System.Convert.ToDecimal(ech17.Text)<Min)
					Min=System.Convert.ToDecimal(ech17.Text);
				if(System.Convert.ToDecimal(ech18.Text)<Min)
					Min=System.Convert.ToDecimal(ech18.Text);
				if(System.Convert.ToDecimal(ech19.Text)<Min)
					Min=System.Convert.ToDecimal(ech19.Text);
				if(System.Convert.ToDecimal(ech20.Text)<Min)
					Min=System.Convert.ToDecimal(ech20.Text);
				Diff=Max-Min;
				et4.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech21.Text)>Max)
					Max=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)>Max)
					Max=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)>Max)
					Max=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)>Max)
					Max=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)>Max)
					Max=System.Convert.ToDecimal(ech25.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech21.Text)<Min)
					Min=System.Convert.ToDecimal(ech21.Text);
				if(System.Convert.ToDecimal(ech22.Text)<Min)
					Min=System.Convert.ToDecimal(ech22.Text);
				if(System.Convert.ToDecimal(ech23.Text)<Min)
					Min=System.Convert.ToDecimal(ech23.Text);
				if(System.Convert.ToDecimal(ech24.Text)<Min)
					Min=System.Convert.ToDecimal(ech24.Text);
				if(System.Convert.ToDecimal(ech25.Text)<Min)
					Min=System.Convert.ToDecimal(ech25.Text);
				Diff=Max-Min;
				et5.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech26.Text)>Max)
					Max=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)>Max)
					Max=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)>Max)
					Max=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)>Max)
					Max=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)>Max)
					Max=System.Convert.ToDecimal(ech30.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech26.Text)<Min)
					Min=System.Convert.ToDecimal(ech26.Text);
				if(System.Convert.ToDecimal(ech27.Text)<Min)
					Min=System.Convert.ToDecimal(ech27.Text);
				if(System.Convert.ToDecimal(ech28.Text)<Min)
					Min=System.Convert.ToDecimal(ech28.Text);
				if(System.Convert.ToDecimal(ech29.Text)<Min)
					Min=System.Convert.ToDecimal(ech29.Text);
				if(System.Convert.ToDecimal(ech30.Text)<Min)
					Min=System.Convert.ToDecimal(ech30.Text);
				Diff=Max-Min;
				et6.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech31.Text)>Max)
					Max=System.Convert.ToDecimal(ech31.Text);
				if(System.Convert.ToDecimal(ech32.Text)>Max)
					Max=System.Convert.ToDecimal(ech32.Text);
				if(System.Convert.ToDecimal(ech33.Text)>Max)
					Max=System.Convert.ToDecimal(ech33.Text);
				if(System.Convert.ToDecimal(ech34.Text)>Max)
					Max=System.Convert.ToDecimal(ech34.Text);
				if(System.Convert.ToDecimal(ech35.Text)>Max)
					Max=System.Convert.ToDecimal(ech35.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech31.Text)<Min)
					Min=System.Convert.ToDecimal(ech31.Text);
				if(System.Convert.ToDecimal(ech32.Text)<Min)
					Min=System.Convert.ToDecimal(ech32.Text);
				if(System.Convert.ToDecimal(ech33.Text)<Min)
					Min=System.Convert.ToDecimal(ech33.Text);
				if(System.Convert.ToDecimal(ech34.Text)<Min)
					Min=System.Convert.ToDecimal(ech34.Text);
				if(System.Convert.ToDecimal(ech35.Text)<Min)
					Min=System.Convert.ToDecimal(ech35.Text);
				Diff=Max-Min;
				et7.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech36.Text)>Max)
					Max=System.Convert.ToDecimal(ech36.Text);
				if(System.Convert.ToDecimal(ech37.Text)>Max)
					Max=System.Convert.ToDecimal(ech37.Text);
				if(System.Convert.ToDecimal(ech38.Text)>Max)
					Max=System.Convert.ToDecimal(ech38.Text);
				if(System.Convert.ToDecimal(ech39.Text)>Max)
					Max=System.Convert.ToDecimal(ech39.Text);
				if(System.Convert.ToDecimal(ech40.Text)>Max)
					Max=System.Convert.ToDecimal(ech40.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech36.Text)<Min)
					Min=System.Convert.ToDecimal(ech36.Text);
				if(System.Convert.ToDecimal(ech37.Text)<Min)
					Min=System.Convert.ToDecimal(ech37.Text);
				if(System.Convert.ToDecimal(ech38.Text)<Min)
					Min=System.Convert.ToDecimal(ech38.Text);
				if(System.Convert.ToDecimal(ech39.Text)<Min)
					Min=System.Convert.ToDecimal(ech39.Text);
				if(System.Convert.ToDecimal(ech40.Text)<Min)
					Min=System.Convert.ToDecimal(ech40.Text);
				Diff=Max-Min;
				et8.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech41.Text)>Max)
					Max=System.Convert.ToDecimal(ech41.Text);
				if(System.Convert.ToDecimal(ech42.Text)>Max)
					Max=System.Convert.ToDecimal(ech42.Text);
				if(System.Convert.ToDecimal(ech43.Text)>Max)
					Max=System.Convert.ToDecimal(ech43.Text);
				if(System.Convert.ToDecimal(ech44.Text)>Max)
					Max=System.Convert.ToDecimal(ech44.Text);
				if(System.Convert.ToDecimal(ech45.Text)>Max)
					Max=System.Convert.ToDecimal(ech45.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech41.Text)<Min)
					Min=System.Convert.ToDecimal(ech41.Text);
				if(System.Convert.ToDecimal(ech42.Text)<Min)
					Min=System.Convert.ToDecimal(ech42.Text);
				if(System.Convert.ToDecimal(ech43.Text)<Min)
					Min=System.Convert.ToDecimal(ech43.Text);
				if(System.Convert.ToDecimal(ech44.Text)<Min)
					Min=System.Convert.ToDecimal(ech44.Text);
				if(System.Convert.ToDecimal(ech45.Text)<Min)
					Min=System.Convert.ToDecimal(ech45.Text);
				Diff=Max-Min;
				et9.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech46.Text)>Max)
					Max=System.Convert.ToDecimal(ech46.Text);
				if(System.Convert.ToDecimal(ech47.Text)>Max)
					Max=System.Convert.ToDecimal(ech47.Text);
				if(System.Convert.ToDecimal(ech48.Text)>Max)
					Max=System.Convert.ToDecimal(ech48.Text);
				if(System.Convert.ToDecimal(ech49.Text)>Max)
					Max=System.Convert.ToDecimal(ech49.Text);
				if(System.Convert.ToDecimal(ech50.Text)>Max)
					Max=System.Convert.ToDecimal(ech50.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech46.Text)<Min)
					Min=System.Convert.ToDecimal(ech46.Text);
				if(System.Convert.ToDecimal(ech47.Text)<Min)
					Min=System.Convert.ToDecimal(ech47.Text);
				if(System.Convert.ToDecimal(ech48.Text)<Min)
					Min=System.Convert.ToDecimal(ech48.Text);
				if(System.Convert.ToDecimal(ech49.Text)<Min)
					Min=System.Convert.ToDecimal(ech49.Text);
				if(System.Convert.ToDecimal(ech50.Text)<Min)
					Min=System.Convert.ToDecimal(ech50.Text);
				Diff=Max-Min;
				et10.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech51.Text)>Max)
					Max=System.Convert.ToDecimal(ech51.Text);
				if(System.Convert.ToDecimal(ech52.Text)>Max)
					Max=System.Convert.ToDecimal(ech52.Text);
				if(System.Convert.ToDecimal(ech53.Text)>Max)
					Max=System.Convert.ToDecimal(ech53.Text);
				if(System.Convert.ToDecimal(ech54.Text)>Max)
					Max=System.Convert.ToDecimal(ech54.Text);
				if(System.Convert.ToDecimal(ech55.Text)>Max)
					Max=System.Convert.ToDecimal(ech55.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech51.Text)<Min)
					Min=System.Convert.ToDecimal(ech51.Text);
				if(System.Convert.ToDecimal(ech52.Text)<Min)
					Min=System.Convert.ToDecimal(ech52.Text);
				if(System.Convert.ToDecimal(ech53.Text)<Min)
					Min=System.Convert.ToDecimal(ech53.Text);
				if(System.Convert.ToDecimal(ech54.Text)<Min)
					Min=System.Convert.ToDecimal(ech54.Text);
				if(System.Convert.ToDecimal(ech55.Text)<Min)
					Min=System.Convert.ToDecimal(ech55.Text);
				Diff=Max-Min;
				et11.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech56.Text)>Max)
					Max=System.Convert.ToDecimal(ech56.Text);
				if(System.Convert.ToDecimal(ech57.Text)>Max)
					Max=System.Convert.ToDecimal(ech57.Text);
				if(System.Convert.ToDecimal(ech58.Text)>Max)
					Max=System.Convert.ToDecimal(ech58.Text);
				if(System.Convert.ToDecimal(ech59.Text)>Max)
					Max=System.Convert.ToDecimal(ech59.Text);
				if(System.Convert.ToDecimal(ech60.Text)>Max)
					Max=System.Convert.ToDecimal(ech60.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech56.Text)<Min)
					Min=System.Convert.ToDecimal(ech56.Text);
				if(System.Convert.ToDecimal(ech57.Text)<Min)
					Min=System.Convert.ToDecimal(ech57.Text);
				if(System.Convert.ToDecimal(ech58.Text)<Min)
					Min=System.Convert.ToDecimal(ech58.Text);
				if(System.Convert.ToDecimal(ech59.Text)<Min)
					Min=System.Convert.ToDecimal(ech59.Text);
				if(System.Convert.ToDecimal(ech60.Text)<Min)
					Min=System.Convert.ToDecimal(ech60.Text);
				Diff=Max-Min;
				et12.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech61.Text)>Max)
					Max=System.Convert.ToDecimal(ech61.Text);
				if(System.Convert.ToDecimal(ech62.Text)>Max)
					Max=System.Convert.ToDecimal(ech62.Text);
				if(System.Convert.ToDecimal(ech63.Text)>Max)
					Max=System.Convert.ToDecimal(ech63.Text);
				if(System.Convert.ToDecimal(ech64.Text)>Max)
					Max=System.Convert.ToDecimal(ech64.Text);
				if(System.Convert.ToDecimal(ech65.Text)>Max)
					Max=System.Convert.ToDecimal(ech65.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech61.Text)<Min)
					Min=System.Convert.ToDecimal(ech61.Text);
				if(System.Convert.ToDecimal(ech62.Text)<Min)
					Min=System.Convert.ToDecimal(ech62.Text);
				if(System.Convert.ToDecimal(ech63.Text)<Min)
					Min=System.Convert.ToDecimal(ech63.Text);
				if(System.Convert.ToDecimal(ech64.Text)<Min)
					Min=System.Convert.ToDecimal(ech64.Text);
				if(System.Convert.ToDecimal(ech65.Text)<Min)
					Min=System.Convert.ToDecimal(ech65.Text);
				Diff=Max-Min;
				et13.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech66.Text)>Max)
					Max=System.Convert.ToDecimal(ech66.Text);
				if(System.Convert.ToDecimal(ech67.Text)>Max)
					Max=System.Convert.ToDecimal(ech67.Text);
				if(System.Convert.ToDecimal(ech68.Text)>Max)
					Max=System.Convert.ToDecimal(ech68.Text);
				if(System.Convert.ToDecimal(ech69.Text)>Max)
					Max=System.Convert.ToDecimal(ech69.Text);
				if(System.Convert.ToDecimal(ech70.Text)>Max)
					Max=System.Convert.ToDecimal(ech70.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech66.Text)<Min)
					Min=System.Convert.ToDecimal(ech66.Text);
				if(System.Convert.ToDecimal(ech67.Text)<Min)
					Min=System.Convert.ToDecimal(ech67.Text);
				if(System.Convert.ToDecimal(ech68.Text)<Min)
					Min=System.Convert.ToDecimal(ech68.Text);
				if(System.Convert.ToDecimal(ech69.Text)<Min)
					Min=System.Convert.ToDecimal(ech69.Text);
				if(System.Convert.ToDecimal(ech70.Text)<Min)
					Min=System.Convert.ToDecimal(ech70.Text);
				Diff=Max-Min;
				et14.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech71.Text)>Max)
					Max=System.Convert.ToDecimal(ech71.Text);
				if(System.Convert.ToDecimal(ech72.Text)>Max)
					Max=System.Convert.ToDecimal(ech72.Text);
				if(System.Convert.ToDecimal(ech73.Text)>Max)
					Max=System.Convert.ToDecimal(ech73.Text);
				if(System.Convert.ToDecimal(ech74.Text)>Max)
					Max=System.Convert.ToDecimal(ech74.Text);
				if(System.Convert.ToDecimal(ech75.Text)>Max)
					Max=System.Convert.ToDecimal(ech75.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech71.Text)<Min)
					Min=System.Convert.ToDecimal(ech71.Text);
				if(System.Convert.ToDecimal(ech72.Text)<Min)
					Min=System.Convert.ToDecimal(ech72.Text);
				if(System.Convert.ToDecimal(ech73.Text)<Min)
					Min=System.Convert.ToDecimal(ech73.Text);
				if(System.Convert.ToDecimal(ech74.Text)<Min)
					Min=System.Convert.ToDecimal(ech74.Text);
				if(System.Convert.ToDecimal(ech75.Text)<Min)
					Min=System.Convert.ToDecimal(ech75.Text);
				Diff=Max-Min;
				et15.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech76.Text)>Max)
					Max=System.Convert.ToDecimal(ech76.Text);
				if(System.Convert.ToDecimal(ech77.Text)>Max)
					Max=System.Convert.ToDecimal(ech77.Text);
				if(System.Convert.ToDecimal(ech78.Text)>Max)
					Max=System.Convert.ToDecimal(ech78.Text);
				if(System.Convert.ToDecimal(ech79.Text)>Max)
					Max=System.Convert.ToDecimal(ech79.Text);
				if(System.Convert.ToDecimal(ech80.Text)>Max)
					Max=System.Convert.ToDecimal(ech80.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech76.Text)<Min)
					Min=System.Convert.ToDecimal(ech76.Text);
				if(System.Convert.ToDecimal(ech77.Text)<Min)
					Min=System.Convert.ToDecimal(ech77.Text);
				if(System.Convert.ToDecimal(ech78.Text)<Min)
					Min=System.Convert.ToDecimal(ech78.Text);
				if(System.Convert.ToDecimal(ech79.Text)<Min)
					Min=System.Convert.ToDecimal(ech79.Text);
				if(System.Convert.ToDecimal(ech80.Text)<Min)
					Min=System.Convert.ToDecimal(ech80.Text);
				Diff=Max-Min;
				et16.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech81.Text)>Max)
					Max=System.Convert.ToDecimal(ech81.Text);
				if(System.Convert.ToDecimal(ech82.Text)>Max)
					Max=System.Convert.ToDecimal(ech82.Text);
				if(System.Convert.ToDecimal(ech83.Text)>Max)
					Max=System.Convert.ToDecimal(ech83.Text);
				if(System.Convert.ToDecimal(ech84.Text)>Max)
					Max=System.Convert.ToDecimal(ech84.Text);
				if(System.Convert.ToDecimal(ech85.Text)>Max)
					Max=System.Convert.ToDecimal(ech85.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech81.Text)<Min)
					Min=System.Convert.ToDecimal(ech81.Text);
				if(System.Convert.ToDecimal(ech82.Text)<Min)
					Min=System.Convert.ToDecimal(ech82.Text);
				if(System.Convert.ToDecimal(ech83.Text)<Min)
					Min=System.Convert.ToDecimal(ech83.Text);
				if(System.Convert.ToDecimal(ech84.Text)<Min)
					Min=System.Convert.ToDecimal(ech84.Text);
				if(System.Convert.ToDecimal(ech85.Text)<Min)
					Min=System.Convert.ToDecimal(ech85.Text);
				Diff=Max-Min;
				et17.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech86.Text)>Max)
					Max=System.Convert.ToDecimal(ech86.Text);
				if(System.Convert.ToDecimal(ech87.Text)>Max)
					Max=System.Convert.ToDecimal(ech87.Text);
				if(System.Convert.ToDecimal(ech88.Text)>Max)
					Max=System.Convert.ToDecimal(ech88.Text);
				if(System.Convert.ToDecimal(ech89.Text)>Max)
					Max=System.Convert.ToDecimal(ech89.Text);
				if(System.Convert.ToDecimal(ech90.Text)>Max)
					Max=System.Convert.ToDecimal(ech90.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech86.Text)<Min)
					Min=System.Convert.ToDecimal(ech86.Text);
				if(System.Convert.ToDecimal(ech87.Text)<Min)
					Min=System.Convert.ToDecimal(ech87.Text);
				if(System.Convert.ToDecimal(ech88.Text)<Min)
					Min=System.Convert.ToDecimal(ech88.Text);
				if(System.Convert.ToDecimal(ech89.Text)<Min)
					Min=System.Convert.ToDecimal(ech89.Text);
				if(System.Convert.ToDecimal(ech90.Text)<Min)
					Min=System.Convert.ToDecimal(ech90.Text);
				Diff=Max-Min;
				et18.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech91.Text)>Max)
					Max=System.Convert.ToDecimal(ech91.Text);
				if(System.Convert.ToDecimal(ech92.Text)>Max)
					Max=System.Convert.ToDecimal(ech92.Text);
				if(System.Convert.ToDecimal(ech93.Text)>Max)
					Max=System.Convert.ToDecimal(ech93.Text);
				if(System.Convert.ToDecimal(ech94.Text)>Max)
					Max=System.Convert.ToDecimal(ech94.Text);
				if(System.Convert.ToDecimal(ech95.Text)>Max)
					Max=System.Convert.ToDecimal(ech95.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech91.Text)<Min)
					Min=System.Convert.ToDecimal(ech91.Text);
				if(System.Convert.ToDecimal(ech92.Text)<Min)
					Min=System.Convert.ToDecimal(ech92.Text);
				if(System.Convert.ToDecimal(ech93.Text)<Min)
					Min=System.Convert.ToDecimal(ech93.Text);
				if(System.Convert.ToDecimal(ech94.Text)<Min)
					Min=System.Convert.ToDecimal(ech94.Text);
				if(System.Convert.ToDecimal(ech95.Text)<Min)
					Min=System.Convert.ToDecimal(ech95.Text);
				Diff=Max-Min;
				et19.Text=Diff.ToString("0.000");
				Max=0;
				if(System.Convert.ToDecimal(ech96.Text)>Max)
					Max=System.Convert.ToDecimal(ech96.Text);
				if(System.Convert.ToDecimal(ech97.Text)>Max)
					Max=System.Convert.ToDecimal(ech97.Text);
				if(System.Convert.ToDecimal(ech98.Text)>Max)
					Max=System.Convert.ToDecimal(ech98.Text);
				if(System.Convert.ToDecimal(ech99.Text)>Max)
					Max=System.Convert.ToDecimal(ech99.Text);
				if(System.Convert.ToDecimal(ech100.Text)>Max)
					Max=System.Convert.ToDecimal(ech100.Text);
				Min=Max;
				if(System.Convert.ToDecimal(ech96.Text)<Min)
					Min=System.Convert.ToDecimal(ech96.Text);
				if(System.Convert.ToDecimal(ech97.Text)<Min)
					Min=System.Convert.ToDecimal(ech97.Text);
				if(System.Convert.ToDecimal(ech98.Text)<Min)
					Min=System.Convert.ToDecimal(ech98.Text);
				if(System.Convert.ToDecimal(ech99.Text)<Min)
					Min=System.Convert.ToDecimal(ech99.Text);
				if(System.Convert.ToDecimal(ech100.Text)<Min)
					Min=System.Convert.ToDecimal(ech100.Text);
				Diff=Max-Min;
				et20.Text=Diff.ToString("0.000");
				MaxMoyenne=0;
				if(System.Convert.ToDecimal(et1.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et1.Text);
				if(System.Convert.ToDecimal(et2.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et2.Text);
				if(System.Convert.ToDecimal(et3.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et3.Text);
				if(System.Convert.ToDecimal(et4.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et4.Text);
				if(System.Convert.ToDecimal(et5.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et5.Text);
				if(System.Convert.ToDecimal(et6.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et6.Text);
				if(System.Convert.ToDecimal(et7.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et7.Text);
				if(System.Convert.ToDecimal(et8.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et8.Text);
				if(System.Convert.ToDecimal(et9.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et9.Text);
				if(System.Convert.ToDecimal(et10.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et10.Text);
				if(System.Convert.ToDecimal(et11.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et11.Text);
				if(System.Convert.ToDecimal(et12.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et12.Text);
				if(System.Convert.ToDecimal(et13.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et13.Text);
				if(System.Convert.ToDecimal(et14.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et14.Text);
				if(System.Convert.ToDecimal(et15.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et15.Text);
				if(System.Convert.ToDecimal(et16.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et16.Text);
				if(System.Convert.ToDecimal(et17.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et17.Text);
				if(System.Convert.ToDecimal(et18.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et18.Text);
				if(System.Convert.ToDecimal(et19.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et19.Text);
				if(System.Convert.ToDecimal(et20.Text)>MaxMoyenne)
					MaxMoyenne=System.Convert.ToDecimal(et20.Text);
				chartLoader= chartControl2.getChartLoader();
				// set chart parameters 
				chartLoader.clearParams();
				chartLoader.setParameter("TITLECHART","Etendues"); 
				chartLoader.setParameter("XSCALE_MIN","0"); 
				chartLoader.setParameter("XSCALE_MAX","3"); 
				chartLoader.setParameter("YSCALE_MIN","0"); 
				//chartLoader.setParameter("YSCALE_MAX",Max.ToString().Replace(",","."));
				chartLoader.setParameter("BIG_TICK_INTERVALY","1"); 
				chartLoader.setParameter("TICK_INTERVALY","10"); 
				chartLoader.setParameter("CERO_XAXIS","LINE"); 
				chartLoader.setParameter("YAXIS_INTEGER","TRUE"); 
				chartLoader.setParameter("SERIE_1","Limite supérieure"); 
				chartLoader.setParameter("SERIE_2","Limite inférieure");
				chartLoader.setParameter("SERIE_3","Mesures"); 
				chartLoader.setParameter("LEGEND","TRUE");
				chartLoader.setParameter("LEFT_MARGIN","0.20");
				chartLoader.setParameter("YAXIS_LABEL_FORMAT","{0:F1}");
				chartLoader.setParameter("SERIE_TYPE_1","LINE");
				chartLoader.setParameter("SERIE_STYLE_1","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_2","1|BLUE|LINE");
				chartLoader.setParameter("SERIE_STYLE_3","1|BLACK|LINE");
				chartLoader.setParameter("TICK_INTERVALY","1");
				chartLoader.setParameter("YAXIS_AUTO_TICKS","5");
				chartLoader.setParameter("YAXIS_PREF_TICK_INTERVAL","0.1|0.5|1|5|10|25|50|100|250|500|1000|5000|10000|50000|100000|500000|1000000");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("XAXIS_LABELS","Type machine|Poste|Cam");
				chartLoader.setParameter("BARCHART_CUMULATIVE","TRUE");
				chartLoader.setParameter("CHART_BORDER","1|0|NORMAL");
				chartLoader.setParameter("CHART_FILL","LIGHTGRAY");
				chartLoader.setParameter("SERIE_DATA_1",MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+
					"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString()+"|"+MaxMoyenne.ToString());
				chartLoader.setParameter("SERIE_DATA_2",0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+
					"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0+"|"+0);
				chartLoader.setParameter("SERIE_DATA_3",System.Convert.ToDecimal(et1.Text).ToString()+"|"+System.Convert.ToDecimal(et2.Text).ToString()+"|"+System.Convert.ToDecimal(et3.Text).ToString()+"|"+System.Convert.ToDecimal(et4.Text).ToString()+"|"+System.Convert.ToDecimal(et5.Text).ToString()+"|"+System.Convert.ToDecimal(et6.Text).ToString()+"|"+System.Convert.ToDecimal(et7.Text).ToString()+"|"+System.Convert.ToDecimal(et8.Text).ToString()+"|"+System.Convert.ToDecimal(et9.Text).ToString()+"|"+System.Convert.ToDecimal(et10.Text).ToString()+"|"+System.Convert.ToDecimal(et11.Text).ToString()+"|"+System.Convert.ToDecimal(et12.Text).ToString()+"|"+System.Convert.ToDecimal(et13.Text).ToString()+
					"|"+System.Convert.ToDecimal(et14.Text).ToString()+"|"+System.Convert.ToDecimal(et15.Text).ToString()+"|"+System.Convert.ToDecimal(et16.Text).ToString()+"|"+System.Convert.ToDecimal(et17.Text).ToString()+"|"+System.Convert.ToDecimal(et18.Text).ToString()+"|"+System.Convert.ToDecimal(et19.Text).ToString()+"|"+System.Convert.ToDecimal(et20.Text).ToString());
				chartLoader.setParameter("CHART_FILL","ffcc00"); 
				chartLoader.setParameter("YLABEL_VERTICAL","FALSE"); 
				chartLoader.setParameter("YAXIS_TICKATBASE","true");
				// create chart 
				chartControl2.buildChart();
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
			this.chartControl1 = new J4L.RChart.ChartControl();
			this.chartControl2 = new J4L.RChart.ChartControl();
			this.ech96 = new System.Windows.Forms.TextBox();
			this.ech91 = new System.Windows.Forms.TextBox();
			this.ech86 = new System.Windows.Forms.TextBox();
			this.ech81 = new System.Windows.Forms.TextBox();
			this.ech76 = new System.Windows.Forms.TextBox();
			this.ech71 = new System.Windows.Forms.TextBox();
			this.ech66 = new System.Windows.Forms.TextBox();
			this.ech61 = new System.Windows.Forms.TextBox();
			this.ech56 = new System.Windows.Forms.TextBox();
			this.ech51 = new System.Windows.Forms.TextBox();
			this.ech46 = new System.Windows.Forms.TextBox();
			this.ech41 = new System.Windows.Forms.TextBox();
			this.ech36 = new System.Windows.Forms.TextBox();
			this.ech31 = new System.Windows.Forms.TextBox();
			this.ech26 = new System.Windows.Forms.TextBox();
			this.ech21 = new System.Windows.Forms.TextBox();
			this.ech16 = new System.Windows.Forms.TextBox();
			this.ech11 = new System.Windows.Forms.TextBox();
			this.ech6 = new System.Windows.Forms.TextBox();
			this.ech1 = new System.Windows.Forms.TextBox();
			this.ech97 = new System.Windows.Forms.TextBox();
			this.ech92 = new System.Windows.Forms.TextBox();
			this.ech87 = new System.Windows.Forms.TextBox();
			this.ech82 = new System.Windows.Forms.TextBox();
			this.ech77 = new System.Windows.Forms.TextBox();
			this.ech72 = new System.Windows.Forms.TextBox();
			this.ech67 = new System.Windows.Forms.TextBox();
			this.ech62 = new System.Windows.Forms.TextBox();
			this.ech57 = new System.Windows.Forms.TextBox();
			this.ech52 = new System.Windows.Forms.TextBox();
			this.ech47 = new System.Windows.Forms.TextBox();
			this.ech42 = new System.Windows.Forms.TextBox();
			this.ech37 = new System.Windows.Forms.TextBox();
			this.ech32 = new System.Windows.Forms.TextBox();
			this.ech27 = new System.Windows.Forms.TextBox();
			this.ech22 = new System.Windows.Forms.TextBox();
			this.ech17 = new System.Windows.Forms.TextBox();
			this.ech12 = new System.Windows.Forms.TextBox();
			this.ech7 = new System.Windows.Forms.TextBox();
			this.ech2 = new System.Windows.Forms.TextBox();
			this.ech98 = new System.Windows.Forms.TextBox();
			this.ech93 = new System.Windows.Forms.TextBox();
			this.ech88 = new System.Windows.Forms.TextBox();
			this.ech83 = new System.Windows.Forms.TextBox();
			this.ech78 = new System.Windows.Forms.TextBox();
			this.ech73 = new System.Windows.Forms.TextBox();
			this.ech68 = new System.Windows.Forms.TextBox();
			this.ech63 = new System.Windows.Forms.TextBox();
			this.ech58 = new System.Windows.Forms.TextBox();
			this.ech53 = new System.Windows.Forms.TextBox();
			this.ech48 = new System.Windows.Forms.TextBox();
			this.ech43 = new System.Windows.Forms.TextBox();
			this.ech38 = new System.Windows.Forms.TextBox();
			this.ech33 = new System.Windows.Forms.TextBox();
			this.ech28 = new System.Windows.Forms.TextBox();
			this.ech23 = new System.Windows.Forms.TextBox();
			this.ech18 = new System.Windows.Forms.TextBox();
			this.ech13 = new System.Windows.Forms.TextBox();
			this.ech8 = new System.Windows.Forms.TextBox();
			this.ech3 = new System.Windows.Forms.TextBox();
			this.ech99 = new System.Windows.Forms.TextBox();
			this.ech94 = new System.Windows.Forms.TextBox();
			this.ech89 = new System.Windows.Forms.TextBox();
			this.ech84 = new System.Windows.Forms.TextBox();
			this.ech79 = new System.Windows.Forms.TextBox();
			this.ech74 = new System.Windows.Forms.TextBox();
			this.ech69 = new System.Windows.Forms.TextBox();
			this.ech64 = new System.Windows.Forms.TextBox();
			this.ech59 = new System.Windows.Forms.TextBox();
			this.ech54 = new System.Windows.Forms.TextBox();
			this.ech49 = new System.Windows.Forms.TextBox();
			this.ech44 = new System.Windows.Forms.TextBox();
			this.ech39 = new System.Windows.Forms.TextBox();
			this.ech34 = new System.Windows.Forms.TextBox();
			this.ech29 = new System.Windows.Forms.TextBox();
			this.ech24 = new System.Windows.Forms.TextBox();
			this.ech19 = new System.Windows.Forms.TextBox();
			this.ech14 = new System.Windows.Forms.TextBox();
			this.ech9 = new System.Windows.Forms.TextBox();
			this.ech4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.ech100 = new System.Windows.Forms.TextBox();
			this.ech95 = new System.Windows.Forms.TextBox();
			this.ech90 = new System.Windows.Forms.TextBox();
			this.ech85 = new System.Windows.Forms.TextBox();
			this.ech80 = new System.Windows.Forms.TextBox();
			this.ech75 = new System.Windows.Forms.TextBox();
			this.ech70 = new System.Windows.Forms.TextBox();
			this.ech65 = new System.Windows.Forms.TextBox();
			this.ech60 = new System.Windows.Forms.TextBox();
			this.ech55 = new System.Windows.Forms.TextBox();
			this.ech50 = new System.Windows.Forms.TextBox();
			this.ech45 = new System.Windows.Forms.TextBox();
			this.ech40 = new System.Windows.Forms.TextBox();
			this.ech35 = new System.Windows.Forms.TextBox();
			this.ech30 = new System.Windows.Forms.TextBox();
			this.ech25 = new System.Windows.Forms.TextBox();
			this.ech20 = new System.Windows.Forms.TextBox();
			this.ech15 = new System.Windows.Forms.TextBox();
			this.ech10 = new System.Windows.Forms.TextBox();
			this.ech5 = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.txMoy20 = new System.Windows.Forms.TextBox();
			this.txMoy19 = new System.Windows.Forms.TextBox();
			this.txMoy18 = new System.Windows.Forms.TextBox();
			this.txMoy17 = new System.Windows.Forms.TextBox();
			this.txMoy16 = new System.Windows.Forms.TextBox();
			this.txMoy15 = new System.Windows.Forms.TextBox();
			this.txMoy14 = new System.Windows.Forms.TextBox();
			this.txMoy13 = new System.Windows.Forms.TextBox();
			this.txMoy12 = new System.Windows.Forms.TextBox();
			this.txMoy11 = new System.Windows.Forms.TextBox();
			this.txMoy10 = new System.Windows.Forms.TextBox();
			this.txMoy9 = new System.Windows.Forms.TextBox();
			this.txMoy8 = new System.Windows.Forms.TextBox();
			this.txMoy7 = new System.Windows.Forms.TextBox();
			this.txMoy6 = new System.Windows.Forms.TextBox();
			this.txMoy5 = new System.Windows.Forms.TextBox();
			this.txMoy4 = new System.Windows.Forms.TextBox();
			this.txMoy3 = new System.Windows.Forms.TextBox();
			this.txMoy2 = new System.Windows.Forms.TextBox();
			this.txMoy1 = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.et20 = new System.Windows.Forms.TextBox();
			this.et19 = new System.Windows.Forms.TextBox();
			this.et18 = new System.Windows.Forms.TextBox();
			this.et17 = new System.Windows.Forms.TextBox();
			this.et16 = new System.Windows.Forms.TextBox();
			this.et15 = new System.Windows.Forms.TextBox();
			this.et14 = new System.Windows.Forms.TextBox();
			this.et13 = new System.Windows.Forms.TextBox();
			this.et12 = new System.Windows.Forms.TextBox();
			this.et11 = new System.Windows.Forms.TextBox();
			this.et10 = new System.Windows.Forms.TextBox();
			this.et9 = new System.Windows.Forms.TextBox();
			this.et8 = new System.Windows.Forms.TextBox();
			this.et7 = new System.Windows.Forms.TextBox();
			this.et6 = new System.Windows.Forms.TextBox();
			this.et5 = new System.Windows.Forms.TextBox();
			this.et4 = new System.Windows.Forms.TextBox();
			this.et3 = new System.Windows.Forms.TextBox();
			this.et2 = new System.Windows.Forms.TextBox();
			this.et1 = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.SuspendLayout();
			// 
			// chartControl1
			// 
			this.chartControl1.BackColor = System.Drawing.Color.White;
			this.chartControl1.Location = new System.Drawing.Point(112, 312);
			this.chartControl1.Name = "chartControl1";
			this.chartControl1.Size = new System.Drawing.Size(760, 208);
			this.chartControl1.TabIndex = 1;
			this.chartControl1.Text = "chartControl1";
			// 
			// chartControl2
			// 
			this.chartControl2.BackColor = System.Drawing.Color.White;
			this.chartControl2.Location = new System.Drawing.Point(112, 552);
			this.chartControl2.Name = "chartControl2";
			this.chartControl2.Size = new System.Drawing.Size(760, 208);
			this.chartControl2.TabIndex = 2;
			this.chartControl2.Text = "chartControl2";
			// 
			// ech96
			// 
			this.ech96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech96.Location = new System.Drawing.Point(856, 88);
			this.ech96.Name = "ech96";
			this.ech96.Size = new System.Drawing.Size(40, 20);
			this.ech96.TabIndex = 42;
			this.ech96.Text = "";
			this.ech96.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech91
			// 
			this.ech91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech91.Location = new System.Drawing.Point(816, 88);
			this.ech91.Name = "ech91";
			this.ech91.Size = new System.Drawing.Size(40, 20);
			this.ech91.TabIndex = 41;
			this.ech91.Text = "";
			this.ech91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech86
			// 
			this.ech86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech86.Location = new System.Drawing.Point(776, 88);
			this.ech86.Name = "ech86";
			this.ech86.Size = new System.Drawing.Size(40, 20);
			this.ech86.TabIndex = 40;
			this.ech86.Text = "";
			this.ech86.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech81
			// 
			this.ech81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech81.Location = new System.Drawing.Point(736, 88);
			this.ech81.Name = "ech81";
			this.ech81.Size = new System.Drawing.Size(40, 20);
			this.ech81.TabIndex = 39;
			this.ech81.Text = "";
			this.ech81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech76
			// 
			this.ech76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech76.Location = new System.Drawing.Point(696, 88);
			this.ech76.Name = "ech76";
			this.ech76.Size = new System.Drawing.Size(40, 20);
			this.ech76.TabIndex = 38;
			this.ech76.Text = "";
			this.ech76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech71
			// 
			this.ech71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech71.Location = new System.Drawing.Point(656, 88);
			this.ech71.Name = "ech71";
			this.ech71.Size = new System.Drawing.Size(40, 20);
			this.ech71.TabIndex = 37;
			this.ech71.Text = "";
			this.ech71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech66
			// 
			this.ech66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech66.Location = new System.Drawing.Point(616, 88);
			this.ech66.Name = "ech66";
			this.ech66.Size = new System.Drawing.Size(40, 20);
			this.ech66.TabIndex = 36;
			this.ech66.Text = "";
			this.ech66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech61
			// 
			this.ech61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech61.Location = new System.Drawing.Point(576, 88);
			this.ech61.Name = "ech61";
			this.ech61.Size = new System.Drawing.Size(40, 20);
			this.ech61.TabIndex = 35;
			this.ech61.Text = "";
			this.ech61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech56
			// 
			this.ech56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech56.Location = new System.Drawing.Point(536, 88);
			this.ech56.Name = "ech56";
			this.ech56.Size = new System.Drawing.Size(40, 20);
			this.ech56.TabIndex = 34;
			this.ech56.Text = "";
			this.ech56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech51
			// 
			this.ech51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech51.Location = new System.Drawing.Point(496, 88);
			this.ech51.Name = "ech51";
			this.ech51.Size = new System.Drawing.Size(40, 20);
			this.ech51.TabIndex = 33;
			this.ech51.Text = "";
			this.ech51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech46
			// 
			this.ech46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech46.Location = new System.Drawing.Point(456, 88);
			this.ech46.Name = "ech46";
			this.ech46.Size = new System.Drawing.Size(40, 20);
			this.ech46.TabIndex = 32;
			this.ech46.Text = "";
			this.ech46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech41
			// 
			this.ech41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech41.Location = new System.Drawing.Point(416, 88);
			this.ech41.Name = "ech41";
			this.ech41.Size = new System.Drawing.Size(40, 20);
			this.ech41.TabIndex = 31;
			this.ech41.Text = "";
			this.ech41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech36
			// 
			this.ech36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech36.Location = new System.Drawing.Point(376, 88);
			this.ech36.Name = "ech36";
			this.ech36.Size = new System.Drawing.Size(40, 20);
			this.ech36.TabIndex = 30;
			this.ech36.Text = "";
			this.ech36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech31
			// 
			this.ech31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech31.Location = new System.Drawing.Point(336, 88);
			this.ech31.Name = "ech31";
			this.ech31.Size = new System.Drawing.Size(40, 20);
			this.ech31.TabIndex = 29;
			this.ech31.Text = "";
			this.ech31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech26
			// 
			this.ech26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech26.Location = new System.Drawing.Point(296, 88);
			this.ech26.Name = "ech26";
			this.ech26.Size = new System.Drawing.Size(40, 20);
			this.ech26.TabIndex = 28;
			this.ech26.Text = "";
			this.ech26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech21
			// 
			this.ech21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech21.Location = new System.Drawing.Point(256, 88);
			this.ech21.Name = "ech21";
			this.ech21.Size = new System.Drawing.Size(40, 20);
			this.ech21.TabIndex = 27;
			this.ech21.Text = "";
			this.ech21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech16
			// 
			this.ech16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech16.Location = new System.Drawing.Point(216, 88);
			this.ech16.Name = "ech16";
			this.ech16.Size = new System.Drawing.Size(40, 20);
			this.ech16.TabIndex = 26;
			this.ech16.Text = "";
			this.ech16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech11
			// 
			this.ech11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech11.Location = new System.Drawing.Point(176, 88);
			this.ech11.Name = "ech11";
			this.ech11.Size = new System.Drawing.Size(40, 20);
			this.ech11.TabIndex = 25;
			this.ech11.Text = "";
			this.ech11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech6
			// 
			this.ech6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech6.Location = new System.Drawing.Point(136, 88);
			this.ech6.Name = "ech6";
			this.ech6.Size = new System.Drawing.Size(40, 20);
			this.ech6.TabIndex = 24;
			this.ech6.Text = "";
			this.ech6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech1
			// 
			this.ech1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech1.Location = new System.Drawing.Point(96, 88);
			this.ech1.Name = "ech1";
			this.ech1.Size = new System.Drawing.Size(40, 20);
			this.ech1.TabIndex = 23;
			this.ech1.Text = "";
			this.ech1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech97
			// 
			this.ech97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech97.Location = new System.Drawing.Point(856, 112);
			this.ech97.Name = "ech97";
			this.ech97.Size = new System.Drawing.Size(40, 20);
			this.ech97.TabIndex = 62;
			this.ech97.Text = "";
			this.ech97.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech92
			// 
			this.ech92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech92.Location = new System.Drawing.Point(816, 112);
			this.ech92.Name = "ech92";
			this.ech92.Size = new System.Drawing.Size(40, 20);
			this.ech92.TabIndex = 61;
			this.ech92.Text = "";
			this.ech92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech87
			// 
			this.ech87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech87.Location = new System.Drawing.Point(776, 112);
			this.ech87.Name = "ech87";
			this.ech87.Size = new System.Drawing.Size(40, 20);
			this.ech87.TabIndex = 60;
			this.ech87.Text = "";
			this.ech87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech82
			// 
			this.ech82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech82.Location = new System.Drawing.Point(736, 112);
			this.ech82.Name = "ech82";
			this.ech82.Size = new System.Drawing.Size(40, 20);
			this.ech82.TabIndex = 59;
			this.ech82.Text = "";
			this.ech82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech77
			// 
			this.ech77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech77.Location = new System.Drawing.Point(696, 112);
			this.ech77.Name = "ech77";
			this.ech77.Size = new System.Drawing.Size(40, 20);
			this.ech77.TabIndex = 58;
			this.ech77.Text = "";
			this.ech77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech72
			// 
			this.ech72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech72.Location = new System.Drawing.Point(656, 112);
			this.ech72.Name = "ech72";
			this.ech72.Size = new System.Drawing.Size(40, 20);
			this.ech72.TabIndex = 57;
			this.ech72.Text = "";
			this.ech72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech67
			// 
			this.ech67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech67.Location = new System.Drawing.Point(616, 112);
			this.ech67.Name = "ech67";
			this.ech67.Size = new System.Drawing.Size(40, 20);
			this.ech67.TabIndex = 56;
			this.ech67.Text = "";
			this.ech67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech62
			// 
			this.ech62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech62.Location = new System.Drawing.Point(576, 112);
			this.ech62.Name = "ech62";
			this.ech62.Size = new System.Drawing.Size(40, 20);
			this.ech62.TabIndex = 55;
			this.ech62.Text = "";
			this.ech62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech57
			// 
			this.ech57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech57.Location = new System.Drawing.Point(536, 112);
			this.ech57.Name = "ech57";
			this.ech57.Size = new System.Drawing.Size(40, 20);
			this.ech57.TabIndex = 54;
			this.ech57.Text = "";
			this.ech57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech52
			// 
			this.ech52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech52.Location = new System.Drawing.Point(496, 112);
			this.ech52.Name = "ech52";
			this.ech52.Size = new System.Drawing.Size(40, 20);
			this.ech52.TabIndex = 53;
			this.ech52.Text = "";
			this.ech52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech47
			// 
			this.ech47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech47.Location = new System.Drawing.Point(456, 112);
			this.ech47.Name = "ech47";
			this.ech47.Size = new System.Drawing.Size(40, 20);
			this.ech47.TabIndex = 52;
			this.ech47.Text = "";
			this.ech47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech42
			// 
			this.ech42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech42.Location = new System.Drawing.Point(416, 112);
			this.ech42.Name = "ech42";
			this.ech42.Size = new System.Drawing.Size(40, 20);
			this.ech42.TabIndex = 51;
			this.ech42.Text = "";
			this.ech42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech37
			// 
			this.ech37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech37.Location = new System.Drawing.Point(376, 112);
			this.ech37.Name = "ech37";
			this.ech37.Size = new System.Drawing.Size(40, 20);
			this.ech37.TabIndex = 50;
			this.ech37.Text = "";
			this.ech37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech32
			// 
			this.ech32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech32.Location = new System.Drawing.Point(336, 112);
			this.ech32.Name = "ech32";
			this.ech32.Size = new System.Drawing.Size(40, 20);
			this.ech32.TabIndex = 49;
			this.ech32.Text = "";
			this.ech32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech27
			// 
			this.ech27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech27.Location = new System.Drawing.Point(296, 112);
			this.ech27.Name = "ech27";
			this.ech27.Size = new System.Drawing.Size(40, 20);
			this.ech27.TabIndex = 48;
			this.ech27.Text = "";
			this.ech27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech22
			// 
			this.ech22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech22.Location = new System.Drawing.Point(256, 112);
			this.ech22.Name = "ech22";
			this.ech22.Size = new System.Drawing.Size(40, 20);
			this.ech22.TabIndex = 47;
			this.ech22.Text = "";
			this.ech22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech17
			// 
			this.ech17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech17.Location = new System.Drawing.Point(216, 112);
			this.ech17.Name = "ech17";
			this.ech17.Size = new System.Drawing.Size(40, 20);
			this.ech17.TabIndex = 46;
			this.ech17.Text = "";
			this.ech17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech12
			// 
			this.ech12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech12.Location = new System.Drawing.Point(176, 112);
			this.ech12.Name = "ech12";
			this.ech12.Size = new System.Drawing.Size(40, 20);
			this.ech12.TabIndex = 45;
			this.ech12.Text = "";
			this.ech12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech7
			// 
			this.ech7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech7.Location = new System.Drawing.Point(136, 112);
			this.ech7.Name = "ech7";
			this.ech7.Size = new System.Drawing.Size(40, 20);
			this.ech7.TabIndex = 44;
			this.ech7.Text = "";
			this.ech7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech2
			// 
			this.ech2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech2.Location = new System.Drawing.Point(96, 112);
			this.ech2.Name = "ech2";
			this.ech2.Size = new System.Drawing.Size(40, 20);
			this.ech2.TabIndex = 43;
			this.ech2.Text = "";
			this.ech2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech98
			// 
			this.ech98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech98.Location = new System.Drawing.Point(856, 136);
			this.ech98.Name = "ech98";
			this.ech98.Size = new System.Drawing.Size(40, 20);
			this.ech98.TabIndex = 82;
			this.ech98.Text = "";
			this.ech98.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech93
			// 
			this.ech93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech93.Location = new System.Drawing.Point(816, 136);
			this.ech93.Name = "ech93";
			this.ech93.Size = new System.Drawing.Size(40, 20);
			this.ech93.TabIndex = 81;
			this.ech93.Text = "";
			this.ech93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech88
			// 
			this.ech88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech88.Location = new System.Drawing.Point(776, 136);
			this.ech88.Name = "ech88";
			this.ech88.Size = new System.Drawing.Size(40, 20);
			this.ech88.TabIndex = 80;
			this.ech88.Text = "";
			this.ech88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech83
			// 
			this.ech83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech83.Location = new System.Drawing.Point(736, 136);
			this.ech83.Name = "ech83";
			this.ech83.Size = new System.Drawing.Size(40, 20);
			this.ech83.TabIndex = 79;
			this.ech83.Text = "";
			this.ech83.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech78
			// 
			this.ech78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech78.Location = new System.Drawing.Point(696, 136);
			this.ech78.Name = "ech78";
			this.ech78.Size = new System.Drawing.Size(40, 20);
			this.ech78.TabIndex = 78;
			this.ech78.Text = "";
			this.ech78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech73
			// 
			this.ech73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech73.Location = new System.Drawing.Point(656, 136);
			this.ech73.Name = "ech73";
			this.ech73.Size = new System.Drawing.Size(40, 20);
			this.ech73.TabIndex = 77;
			this.ech73.Text = "";
			this.ech73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech68
			// 
			this.ech68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech68.Location = new System.Drawing.Point(616, 136);
			this.ech68.Name = "ech68";
			this.ech68.Size = new System.Drawing.Size(40, 20);
			this.ech68.TabIndex = 76;
			this.ech68.Text = "";
			this.ech68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech63
			// 
			this.ech63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech63.Location = new System.Drawing.Point(576, 136);
			this.ech63.Name = "ech63";
			this.ech63.Size = new System.Drawing.Size(40, 20);
			this.ech63.TabIndex = 75;
			this.ech63.Text = "";
			this.ech63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech58
			// 
			this.ech58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech58.Location = new System.Drawing.Point(536, 136);
			this.ech58.Name = "ech58";
			this.ech58.Size = new System.Drawing.Size(40, 20);
			this.ech58.TabIndex = 74;
			this.ech58.Text = "";
			this.ech58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech53
			// 
			this.ech53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech53.Location = new System.Drawing.Point(496, 136);
			this.ech53.Name = "ech53";
			this.ech53.Size = new System.Drawing.Size(40, 20);
			this.ech53.TabIndex = 73;
			this.ech53.Text = "";
			this.ech53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech48
			// 
			this.ech48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech48.Location = new System.Drawing.Point(456, 136);
			this.ech48.Name = "ech48";
			this.ech48.Size = new System.Drawing.Size(40, 20);
			this.ech48.TabIndex = 72;
			this.ech48.Text = "";
			this.ech48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech43
			// 
			this.ech43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech43.Location = new System.Drawing.Point(416, 136);
			this.ech43.Name = "ech43";
			this.ech43.Size = new System.Drawing.Size(40, 20);
			this.ech43.TabIndex = 71;
			this.ech43.Text = "";
			this.ech43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech38
			// 
			this.ech38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech38.Location = new System.Drawing.Point(376, 136);
			this.ech38.Name = "ech38";
			this.ech38.Size = new System.Drawing.Size(40, 20);
			this.ech38.TabIndex = 70;
			this.ech38.Text = "";
			this.ech38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech33
			// 
			this.ech33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech33.Location = new System.Drawing.Point(336, 136);
			this.ech33.Name = "ech33";
			this.ech33.Size = new System.Drawing.Size(40, 20);
			this.ech33.TabIndex = 69;
			this.ech33.Text = "";
			this.ech33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech28
			// 
			this.ech28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech28.Location = new System.Drawing.Point(296, 136);
			this.ech28.Name = "ech28";
			this.ech28.Size = new System.Drawing.Size(40, 20);
			this.ech28.TabIndex = 68;
			this.ech28.Text = "";
			this.ech28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech23
			// 
			this.ech23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech23.Location = new System.Drawing.Point(256, 136);
			this.ech23.Name = "ech23";
			this.ech23.Size = new System.Drawing.Size(40, 20);
			this.ech23.TabIndex = 67;
			this.ech23.Text = "";
			this.ech23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech18
			// 
			this.ech18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech18.Location = new System.Drawing.Point(216, 136);
			this.ech18.Name = "ech18";
			this.ech18.Size = new System.Drawing.Size(40, 20);
			this.ech18.TabIndex = 66;
			this.ech18.Text = "";
			this.ech18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech13
			// 
			this.ech13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech13.Location = new System.Drawing.Point(176, 136);
			this.ech13.Name = "ech13";
			this.ech13.Size = new System.Drawing.Size(40, 20);
			this.ech13.TabIndex = 65;
			this.ech13.Text = "";
			this.ech13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech8
			// 
			this.ech8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech8.Location = new System.Drawing.Point(136, 136);
			this.ech8.Name = "ech8";
			this.ech8.Size = new System.Drawing.Size(40, 20);
			this.ech8.TabIndex = 64;
			this.ech8.Text = "";
			this.ech8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech3
			// 
			this.ech3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech3.Location = new System.Drawing.Point(96, 136);
			this.ech3.Name = "ech3";
			this.ech3.Size = new System.Drawing.Size(40, 20);
			this.ech3.TabIndex = 63;
			this.ech3.Text = "";
			this.ech3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech99
			// 
			this.ech99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech99.Location = new System.Drawing.Point(856, 160);
			this.ech99.Name = "ech99";
			this.ech99.Size = new System.Drawing.Size(40, 20);
			this.ech99.TabIndex = 102;
			this.ech99.Text = "";
			this.ech99.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech94
			// 
			this.ech94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech94.Location = new System.Drawing.Point(816, 160);
			this.ech94.Name = "ech94";
			this.ech94.Size = new System.Drawing.Size(40, 20);
			this.ech94.TabIndex = 101;
			this.ech94.Text = "";
			this.ech94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech89
			// 
			this.ech89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech89.Location = new System.Drawing.Point(776, 160);
			this.ech89.Name = "ech89";
			this.ech89.Size = new System.Drawing.Size(40, 20);
			this.ech89.TabIndex = 100;
			this.ech89.Text = "";
			this.ech89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech84
			// 
			this.ech84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech84.Location = new System.Drawing.Point(736, 160);
			this.ech84.Name = "ech84";
			this.ech84.Size = new System.Drawing.Size(40, 20);
			this.ech84.TabIndex = 99;
			this.ech84.Text = "";
			this.ech84.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech79
			// 
			this.ech79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech79.Location = new System.Drawing.Point(696, 160);
			this.ech79.Name = "ech79";
			this.ech79.Size = new System.Drawing.Size(40, 20);
			this.ech79.TabIndex = 98;
			this.ech79.Text = "";
			this.ech79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech74
			// 
			this.ech74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech74.Location = new System.Drawing.Point(656, 160);
			this.ech74.Name = "ech74";
			this.ech74.Size = new System.Drawing.Size(40, 20);
			this.ech74.TabIndex = 97;
			this.ech74.Text = "";
			this.ech74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech69
			// 
			this.ech69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech69.Location = new System.Drawing.Point(616, 160);
			this.ech69.Name = "ech69";
			this.ech69.Size = new System.Drawing.Size(40, 20);
			this.ech69.TabIndex = 96;
			this.ech69.Text = "";
			this.ech69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech64
			// 
			this.ech64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech64.Location = new System.Drawing.Point(576, 160);
			this.ech64.Name = "ech64";
			this.ech64.Size = new System.Drawing.Size(40, 20);
			this.ech64.TabIndex = 95;
			this.ech64.Text = "";
			this.ech64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech59
			// 
			this.ech59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech59.Location = new System.Drawing.Point(536, 160);
			this.ech59.Name = "ech59";
			this.ech59.Size = new System.Drawing.Size(40, 20);
			this.ech59.TabIndex = 94;
			this.ech59.Text = "";
			this.ech59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech54
			// 
			this.ech54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech54.Location = new System.Drawing.Point(496, 160);
			this.ech54.Name = "ech54";
			this.ech54.Size = new System.Drawing.Size(40, 20);
			this.ech54.TabIndex = 93;
			this.ech54.Text = "";
			this.ech54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech49
			// 
			this.ech49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech49.Location = new System.Drawing.Point(456, 160);
			this.ech49.Name = "ech49";
			this.ech49.Size = new System.Drawing.Size(40, 20);
			this.ech49.TabIndex = 92;
			this.ech49.Text = "";
			this.ech49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech44
			// 
			this.ech44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech44.Location = new System.Drawing.Point(416, 160);
			this.ech44.Name = "ech44";
			this.ech44.Size = new System.Drawing.Size(40, 20);
			this.ech44.TabIndex = 91;
			this.ech44.Text = "";
			this.ech44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech39
			// 
			this.ech39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech39.Location = new System.Drawing.Point(376, 160);
			this.ech39.Name = "ech39";
			this.ech39.Size = new System.Drawing.Size(40, 20);
			this.ech39.TabIndex = 90;
			this.ech39.Text = "";
			this.ech39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech34
			// 
			this.ech34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech34.Location = new System.Drawing.Point(336, 160);
			this.ech34.Name = "ech34";
			this.ech34.Size = new System.Drawing.Size(40, 20);
			this.ech34.TabIndex = 89;
			this.ech34.Text = "";
			this.ech34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech29
			// 
			this.ech29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech29.Location = new System.Drawing.Point(296, 160);
			this.ech29.Name = "ech29";
			this.ech29.Size = new System.Drawing.Size(40, 20);
			this.ech29.TabIndex = 88;
			this.ech29.Text = "";
			this.ech29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech24
			// 
			this.ech24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech24.Location = new System.Drawing.Point(256, 160);
			this.ech24.Name = "ech24";
			this.ech24.Size = new System.Drawing.Size(40, 20);
			this.ech24.TabIndex = 87;
			this.ech24.Text = "";
			this.ech24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech19
			// 
			this.ech19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech19.Location = new System.Drawing.Point(216, 160);
			this.ech19.Name = "ech19";
			this.ech19.Size = new System.Drawing.Size(40, 20);
			this.ech19.TabIndex = 86;
			this.ech19.Text = "";
			this.ech19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech14
			// 
			this.ech14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech14.Location = new System.Drawing.Point(176, 160);
			this.ech14.Name = "ech14";
			this.ech14.Size = new System.Drawing.Size(40, 20);
			this.ech14.TabIndex = 85;
			this.ech14.Text = "";
			this.ech14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech9
			// 
			this.ech9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech9.Location = new System.Drawing.Point(136, 160);
			this.ech9.Name = "ech9";
			this.ech9.Size = new System.Drawing.Size(40, 20);
			this.ech9.TabIndex = 84;
			this.ech9.Text = "";
			this.ech9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech4
			// 
			this.ech4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech4.Location = new System.Drawing.Point(96, 160);
			this.ech4.Name = "ech4";
			this.ech4.Size = new System.Drawing.Size(40, 20);
			this.ech4.TabIndex = 83;
			this.ech4.Text = "";
			this.ech4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(96, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 103;
			this.label1.Text = "1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(136, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 104;
			this.label2.Text = "2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(176, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 105;
			this.label3.Text = "3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(216, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 106;
			this.label4.Text = "4";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(256, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 107;
			this.label5.Text = "5";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(296, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 23);
			this.label6.TabIndex = 108;
			this.label6.Text = "6";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(336, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 109;
			this.label7.Text = "7";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(376, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 110;
			this.label8.Text = "8";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(416, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 23);
			this.label9.TabIndex = 111;
			this.label9.Text = "9";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(456, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 23);
			this.label10.TabIndex = 112;
			this.label10.Text = "10";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(496, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 23);
			this.label11.TabIndex = 113;
			this.label11.Text = "11";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(536, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 23);
			this.label12.TabIndex = 114;
			this.label12.Text = "12";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(576, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 23);
			this.label13.TabIndex = 115;
			this.label13.Text = "13";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(616, 56);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 23);
			this.label14.TabIndex = 116;
			this.label14.Text = "14";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(656, 56);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(40, 23);
			this.label15.TabIndex = 117;
			this.label15.Text = "15";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(696, 56);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(40, 23);
			this.label16.TabIndex = 118;
			this.label16.Text = "16";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(736, 56);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(40, 23);
			this.label17.TabIndex = 119;
			this.label17.Text = "17";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(776, 56);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(40, 23);
			this.label18.TabIndex = 120;
			this.label18.Text = "18";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(816, 56);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(40, 23);
			this.label19.TabIndex = 121;
			this.label19.Text = "19";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(856, 56);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(40, 23);
			this.label20.TabIndex = 122;
			this.label20.Text = "20";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(32, 64);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 16);
			this.label21.TabIndex = 123;
			this.label21.Text = "Echantillon";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(32, 88);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(64, 16);
			this.label22.TabIndex = 124;
			this.label22.Text = "Mesure 1";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(32, 112);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(64, 16);
			this.label23.TabIndex = 125;
			this.label23.Text = "Mesure 2";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(32, 136);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(64, 16);
			this.label24.TabIndex = 126;
			this.label24.Text = "Mesure 3";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(32, 160);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(64, 16);
			this.label25.TabIndex = 127;
			this.label25.Text = "Mesure 4";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(32, 184);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(64, 16);
			this.label26.TabIndex = 148;
			this.label26.Text = "Mesure 5";
			// 
			// ech100
			// 
			this.ech100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech100.Location = new System.Drawing.Point(856, 184);
			this.ech100.Name = "ech100";
			this.ech100.Size = new System.Drawing.Size(40, 20);
			this.ech100.TabIndex = 147;
			this.ech100.Text = "";
			this.ech100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech95
			// 
			this.ech95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech95.Location = new System.Drawing.Point(816, 184);
			this.ech95.Name = "ech95";
			this.ech95.Size = new System.Drawing.Size(40, 20);
			this.ech95.TabIndex = 146;
			this.ech95.Text = "";
			this.ech95.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech90
			// 
			this.ech90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech90.Location = new System.Drawing.Point(776, 184);
			this.ech90.Name = "ech90";
			this.ech90.Size = new System.Drawing.Size(40, 20);
			this.ech90.TabIndex = 145;
			this.ech90.Text = "";
			this.ech90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech85
			// 
			this.ech85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech85.Location = new System.Drawing.Point(736, 184);
			this.ech85.Name = "ech85";
			this.ech85.Size = new System.Drawing.Size(40, 20);
			this.ech85.TabIndex = 144;
			this.ech85.Text = "";
			this.ech85.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech80
			// 
			this.ech80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech80.Location = new System.Drawing.Point(696, 184);
			this.ech80.Name = "ech80";
			this.ech80.Size = new System.Drawing.Size(40, 20);
			this.ech80.TabIndex = 143;
			this.ech80.Text = "";
			this.ech80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech75
			// 
			this.ech75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech75.Location = new System.Drawing.Point(656, 184);
			this.ech75.Name = "ech75";
			this.ech75.Size = new System.Drawing.Size(40, 20);
			this.ech75.TabIndex = 142;
			this.ech75.Text = "";
			this.ech75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech70
			// 
			this.ech70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech70.Location = new System.Drawing.Point(616, 184);
			this.ech70.Name = "ech70";
			this.ech70.Size = new System.Drawing.Size(40, 20);
			this.ech70.TabIndex = 141;
			this.ech70.Text = "";
			this.ech70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech65
			// 
			this.ech65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech65.Location = new System.Drawing.Point(576, 184);
			this.ech65.Name = "ech65";
			this.ech65.Size = new System.Drawing.Size(40, 20);
			this.ech65.TabIndex = 140;
			this.ech65.Text = "";
			this.ech65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech60
			// 
			this.ech60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech60.Location = new System.Drawing.Point(536, 184);
			this.ech60.Name = "ech60";
			this.ech60.Size = new System.Drawing.Size(40, 20);
			this.ech60.TabIndex = 139;
			this.ech60.Text = "";
			this.ech60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech55
			// 
			this.ech55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech55.Location = new System.Drawing.Point(496, 184);
			this.ech55.Name = "ech55";
			this.ech55.Size = new System.Drawing.Size(40, 20);
			this.ech55.TabIndex = 138;
			this.ech55.Text = "";
			this.ech55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech50
			// 
			this.ech50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech50.Location = new System.Drawing.Point(456, 184);
			this.ech50.Name = "ech50";
			this.ech50.Size = new System.Drawing.Size(40, 20);
			this.ech50.TabIndex = 137;
			this.ech50.Text = "";
			this.ech50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech45
			// 
			this.ech45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech45.Location = new System.Drawing.Point(416, 184);
			this.ech45.Name = "ech45";
			this.ech45.Size = new System.Drawing.Size(40, 20);
			this.ech45.TabIndex = 136;
			this.ech45.Text = "";
			this.ech45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech40
			// 
			this.ech40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech40.Location = new System.Drawing.Point(376, 184);
			this.ech40.Name = "ech40";
			this.ech40.Size = new System.Drawing.Size(40, 20);
			this.ech40.TabIndex = 135;
			this.ech40.Text = "";
			this.ech40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech35
			// 
			this.ech35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech35.Location = new System.Drawing.Point(336, 184);
			this.ech35.Name = "ech35";
			this.ech35.Size = new System.Drawing.Size(40, 20);
			this.ech35.TabIndex = 134;
			this.ech35.Text = "";
			this.ech35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech30
			// 
			this.ech30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech30.Location = new System.Drawing.Point(296, 184);
			this.ech30.Name = "ech30";
			this.ech30.Size = new System.Drawing.Size(40, 20);
			this.ech30.TabIndex = 133;
			this.ech30.Text = "";
			this.ech30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech25
			// 
			this.ech25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech25.Location = new System.Drawing.Point(256, 184);
			this.ech25.Name = "ech25";
			this.ech25.Size = new System.Drawing.Size(40, 20);
			this.ech25.TabIndex = 132;
			this.ech25.Text = "";
			this.ech25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech20
			// 
			this.ech20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech20.Location = new System.Drawing.Point(216, 184);
			this.ech20.Name = "ech20";
			this.ech20.Size = new System.Drawing.Size(40, 20);
			this.ech20.TabIndex = 131;
			this.ech20.Text = "";
			this.ech20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech15
			// 
			this.ech15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech15.Location = new System.Drawing.Point(176, 184);
			this.ech15.Name = "ech15";
			this.ech15.Size = new System.Drawing.Size(40, 20);
			this.ech15.TabIndex = 130;
			this.ech15.Text = "";
			this.ech15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech10
			// 
			this.ech10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech10.Location = new System.Drawing.Point(136, 184);
			this.ech10.Name = "ech10";
			this.ech10.Size = new System.Drawing.Size(40, 20);
			this.ech10.TabIndex = 129;
			this.ech10.Text = "";
			this.ech10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ech5
			// 
			this.ech5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ech5.Location = new System.Drawing.Point(96, 184);
			this.ech5.Name = "ech5";
			this.ech5.Size = new System.Drawing.Size(40, 20);
			this.ech5.TabIndex = 128;
			this.ech5.Text = "";
			this.ech5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(32, 216);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(64, 16);
			this.label27.TabIndex = 169;
			this.label27.Text = "Moyenne";
			// 
			// txMoy20
			// 
			this.txMoy20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy20.Location = new System.Drawing.Point(856, 216);
			this.txMoy20.Name = "txMoy20";
			this.txMoy20.Size = new System.Drawing.Size(40, 20);
			this.txMoy20.TabIndex = 168;
			this.txMoy20.Text = "";
			this.txMoy20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy19
			// 
			this.txMoy19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy19.Location = new System.Drawing.Point(816, 216);
			this.txMoy19.Name = "txMoy19";
			this.txMoy19.Size = new System.Drawing.Size(40, 20);
			this.txMoy19.TabIndex = 167;
			this.txMoy19.Text = "";
			this.txMoy19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy18
			// 
			this.txMoy18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy18.Location = new System.Drawing.Point(776, 216);
			this.txMoy18.Name = "txMoy18";
			this.txMoy18.Size = new System.Drawing.Size(40, 20);
			this.txMoy18.TabIndex = 166;
			this.txMoy18.Text = "";
			this.txMoy18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy17
			// 
			this.txMoy17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy17.Location = new System.Drawing.Point(736, 216);
			this.txMoy17.Name = "txMoy17";
			this.txMoy17.Size = new System.Drawing.Size(40, 20);
			this.txMoy17.TabIndex = 165;
			this.txMoy17.Text = "";
			this.txMoy17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy16
			// 
			this.txMoy16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy16.Location = new System.Drawing.Point(696, 216);
			this.txMoy16.Name = "txMoy16";
			this.txMoy16.Size = new System.Drawing.Size(40, 20);
			this.txMoy16.TabIndex = 164;
			this.txMoy16.Text = "";
			this.txMoy16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy15
			// 
			this.txMoy15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy15.Location = new System.Drawing.Point(656, 216);
			this.txMoy15.Name = "txMoy15";
			this.txMoy15.Size = new System.Drawing.Size(40, 20);
			this.txMoy15.TabIndex = 163;
			this.txMoy15.Text = "";
			this.txMoy15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy14
			// 
			this.txMoy14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy14.Location = new System.Drawing.Point(616, 216);
			this.txMoy14.Name = "txMoy14";
			this.txMoy14.Size = new System.Drawing.Size(40, 20);
			this.txMoy14.TabIndex = 162;
			this.txMoy14.Text = "";
			this.txMoy14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy13
			// 
			this.txMoy13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy13.Location = new System.Drawing.Point(576, 216);
			this.txMoy13.Name = "txMoy13";
			this.txMoy13.Size = new System.Drawing.Size(40, 20);
			this.txMoy13.TabIndex = 161;
			this.txMoy13.Text = "";
			this.txMoy13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy12
			// 
			this.txMoy12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy12.Location = new System.Drawing.Point(536, 216);
			this.txMoy12.Name = "txMoy12";
			this.txMoy12.Size = new System.Drawing.Size(40, 20);
			this.txMoy12.TabIndex = 160;
			this.txMoy12.Text = "";
			this.txMoy12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy11
			// 
			this.txMoy11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy11.Location = new System.Drawing.Point(496, 216);
			this.txMoy11.Name = "txMoy11";
			this.txMoy11.Size = new System.Drawing.Size(40, 20);
			this.txMoy11.TabIndex = 159;
			this.txMoy11.Text = "";
			this.txMoy11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy10
			// 
			this.txMoy10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy10.Location = new System.Drawing.Point(456, 216);
			this.txMoy10.Name = "txMoy10";
			this.txMoy10.Size = new System.Drawing.Size(40, 20);
			this.txMoy10.TabIndex = 158;
			this.txMoy10.Text = "";
			this.txMoy10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy9
			// 
			this.txMoy9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy9.Location = new System.Drawing.Point(416, 216);
			this.txMoy9.Name = "txMoy9";
			this.txMoy9.Size = new System.Drawing.Size(40, 20);
			this.txMoy9.TabIndex = 157;
			this.txMoy9.Text = "";
			this.txMoy9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy8
			// 
			this.txMoy8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy8.Location = new System.Drawing.Point(376, 216);
			this.txMoy8.Name = "txMoy8";
			this.txMoy8.Size = new System.Drawing.Size(40, 20);
			this.txMoy8.TabIndex = 156;
			this.txMoy8.Text = "";
			this.txMoy8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy7
			// 
			this.txMoy7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy7.Location = new System.Drawing.Point(336, 216);
			this.txMoy7.Name = "txMoy7";
			this.txMoy7.Size = new System.Drawing.Size(40, 20);
			this.txMoy7.TabIndex = 155;
			this.txMoy7.Text = "";
			this.txMoy7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy6
			// 
			this.txMoy6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy6.Location = new System.Drawing.Point(296, 216);
			this.txMoy6.Name = "txMoy6";
			this.txMoy6.Size = new System.Drawing.Size(40, 20);
			this.txMoy6.TabIndex = 154;
			this.txMoy6.Text = "";
			this.txMoy6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy5
			// 
			this.txMoy5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy5.Location = new System.Drawing.Point(256, 216);
			this.txMoy5.Name = "txMoy5";
			this.txMoy5.Size = new System.Drawing.Size(40, 20);
			this.txMoy5.TabIndex = 153;
			this.txMoy5.Text = "";
			this.txMoy5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy4
			// 
			this.txMoy4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy4.Location = new System.Drawing.Point(216, 216);
			this.txMoy4.Name = "txMoy4";
			this.txMoy4.Size = new System.Drawing.Size(40, 20);
			this.txMoy4.TabIndex = 152;
			this.txMoy4.Text = "";
			this.txMoy4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy3
			// 
			this.txMoy3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy3.Location = new System.Drawing.Point(176, 216);
			this.txMoy3.Name = "txMoy3";
			this.txMoy3.Size = new System.Drawing.Size(40, 20);
			this.txMoy3.TabIndex = 151;
			this.txMoy3.Text = "";
			this.txMoy3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy2
			// 
			this.txMoy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy2.Location = new System.Drawing.Point(136, 216);
			this.txMoy2.Name = "txMoy2";
			this.txMoy2.Size = new System.Drawing.Size(40, 20);
			this.txMoy2.TabIndex = 150;
			this.txMoy2.Text = "";
			this.txMoy2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txMoy1
			// 
			this.txMoy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txMoy1.Location = new System.Drawing.Point(96, 216);
			this.txMoy1.Name = "txMoy1";
			this.txMoy1.Size = new System.Drawing.Size(40, 20);
			this.txMoy1.TabIndex = 149;
			this.txMoy1.Text = "";
			this.txMoy1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(32, 240);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 16);
			this.label28.TabIndex = 190;
			this.label28.Text = "Etendue";
			// 
			// et20
			// 
			this.et20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et20.Location = new System.Drawing.Point(856, 240);
			this.et20.Name = "et20";
			this.et20.Size = new System.Drawing.Size(40, 20);
			this.et20.TabIndex = 189;
			this.et20.Text = "";
			this.et20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et19
			// 
			this.et19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et19.Location = new System.Drawing.Point(816, 240);
			this.et19.Name = "et19";
			this.et19.Size = new System.Drawing.Size(40, 20);
			this.et19.TabIndex = 188;
			this.et19.Text = "";
			this.et19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et18
			// 
			this.et18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et18.Location = new System.Drawing.Point(776, 240);
			this.et18.Name = "et18";
			this.et18.Size = new System.Drawing.Size(40, 20);
			this.et18.TabIndex = 187;
			this.et18.Text = "";
			this.et18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et17
			// 
			this.et17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et17.Location = new System.Drawing.Point(736, 240);
			this.et17.Name = "et17";
			this.et17.Size = new System.Drawing.Size(40, 20);
			this.et17.TabIndex = 186;
			this.et17.Text = "";
			this.et17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et16
			// 
			this.et16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et16.Location = new System.Drawing.Point(696, 240);
			this.et16.Name = "et16";
			this.et16.Size = new System.Drawing.Size(40, 20);
			this.et16.TabIndex = 185;
			this.et16.Text = "";
			this.et16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et15
			// 
			this.et15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et15.Location = new System.Drawing.Point(656, 240);
			this.et15.Name = "et15";
			this.et15.Size = new System.Drawing.Size(40, 20);
			this.et15.TabIndex = 184;
			this.et15.Text = "";
			this.et15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et14
			// 
			this.et14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et14.Location = new System.Drawing.Point(616, 240);
			this.et14.Name = "et14";
			this.et14.Size = new System.Drawing.Size(40, 20);
			this.et14.TabIndex = 183;
			this.et14.Text = "";
			this.et14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et13
			// 
			this.et13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et13.Location = new System.Drawing.Point(576, 240);
			this.et13.Name = "et13";
			this.et13.Size = new System.Drawing.Size(40, 20);
			this.et13.TabIndex = 182;
			this.et13.Text = "";
			this.et13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et12
			// 
			this.et12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et12.Location = new System.Drawing.Point(536, 240);
			this.et12.Name = "et12";
			this.et12.Size = new System.Drawing.Size(40, 20);
			this.et12.TabIndex = 181;
			this.et12.Text = "";
			this.et12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et11
			// 
			this.et11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et11.Location = new System.Drawing.Point(496, 240);
			this.et11.Name = "et11";
			this.et11.Size = new System.Drawing.Size(40, 20);
			this.et11.TabIndex = 180;
			this.et11.Text = "";
			this.et11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et10
			// 
			this.et10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et10.Location = new System.Drawing.Point(456, 240);
			this.et10.Name = "et10";
			this.et10.Size = new System.Drawing.Size(40, 20);
			this.et10.TabIndex = 179;
			this.et10.Text = "";
			this.et10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et9
			// 
			this.et9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et9.Location = new System.Drawing.Point(416, 240);
			this.et9.Name = "et9";
			this.et9.Size = new System.Drawing.Size(40, 20);
			this.et9.TabIndex = 178;
			this.et9.Text = "";
			this.et9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et8
			// 
			this.et8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et8.Location = new System.Drawing.Point(376, 240);
			this.et8.Name = "et8";
			this.et8.Size = new System.Drawing.Size(40, 20);
			this.et8.TabIndex = 177;
			this.et8.Text = "";
			this.et8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et7
			// 
			this.et7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et7.Location = new System.Drawing.Point(336, 240);
			this.et7.Name = "et7";
			this.et7.Size = new System.Drawing.Size(40, 20);
			this.et7.TabIndex = 176;
			this.et7.Text = "";
			this.et7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et6
			// 
			this.et6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et6.Location = new System.Drawing.Point(296, 240);
			this.et6.Name = "et6";
			this.et6.Size = new System.Drawing.Size(40, 20);
			this.et6.TabIndex = 175;
			this.et6.Text = "";
			this.et6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et5
			// 
			this.et5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et5.Location = new System.Drawing.Point(256, 240);
			this.et5.Name = "et5";
			this.et5.Size = new System.Drawing.Size(40, 20);
			this.et5.TabIndex = 174;
			this.et5.Text = "";
			this.et5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et4
			// 
			this.et4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et4.Location = new System.Drawing.Point(216, 240);
			this.et4.Name = "et4";
			this.et4.Size = new System.Drawing.Size(40, 20);
			this.et4.TabIndex = 173;
			this.et4.Text = "";
			this.et4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et3
			// 
			this.et3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et3.Location = new System.Drawing.Point(176, 240);
			this.et3.Name = "et3";
			this.et3.Size = new System.Drawing.Size(40, 20);
			this.et3.TabIndex = 172;
			this.et3.Text = "";
			this.et3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et2
			// 
			this.et2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et2.Location = new System.Drawing.Point(136, 240);
			this.et2.Name = "et2";
			this.et2.Size = new System.Drawing.Size(40, 20);
			this.et2.TabIndex = 171;
			this.et2.Text = "";
			this.et2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// et1
			// 
			this.et1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.et1.Location = new System.Drawing.Point(96, 240);
			this.et1.Name = "et1";
			this.et1.Size = new System.Drawing.Size(40, 20);
			this.et1.TabIndex = 170;
			this.et1.Text = "";
			this.et1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label29.Location = new System.Drawing.Point(456, 288);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(64, 16);
			this.label29.TabIndex = 191;
			this.label29.Text = "Moyennes";
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.Location = new System.Drawing.Point(456, 528);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(64, 16);
			this.label30.TabIndex = 192;
			this.label30.Text = "Etendues";
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""M:\Lyon\bd.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// GraphiquesCAM2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(988, 872);
			this.ControlBox = false;
			this.Controls.Add(this.label30);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.et20);
			this.Controls.Add(this.et19);
			this.Controls.Add(this.et18);
			this.Controls.Add(this.et17);
			this.Controls.Add(this.et16);
			this.Controls.Add(this.et15);
			this.Controls.Add(this.et14);
			this.Controls.Add(this.et13);
			this.Controls.Add(this.et12);
			this.Controls.Add(this.et11);
			this.Controls.Add(this.et10);
			this.Controls.Add(this.et9);
			this.Controls.Add(this.et8);
			this.Controls.Add(this.et7);
			this.Controls.Add(this.et6);
			this.Controls.Add(this.et5);
			this.Controls.Add(this.et4);
			this.Controls.Add(this.et3);
			this.Controls.Add(this.et2);
			this.Controls.Add(this.et1);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.txMoy20);
			this.Controls.Add(this.txMoy19);
			this.Controls.Add(this.txMoy18);
			this.Controls.Add(this.txMoy17);
			this.Controls.Add(this.txMoy16);
			this.Controls.Add(this.txMoy15);
			this.Controls.Add(this.txMoy14);
			this.Controls.Add(this.txMoy13);
			this.Controls.Add(this.txMoy12);
			this.Controls.Add(this.txMoy11);
			this.Controls.Add(this.txMoy10);
			this.Controls.Add(this.txMoy9);
			this.Controls.Add(this.txMoy8);
			this.Controls.Add(this.txMoy7);
			this.Controls.Add(this.txMoy6);
			this.Controls.Add(this.txMoy5);
			this.Controls.Add(this.txMoy4);
			this.Controls.Add(this.txMoy3);
			this.Controls.Add(this.txMoy2);
			this.Controls.Add(this.txMoy1);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.ech100);
			this.Controls.Add(this.ech95);
			this.Controls.Add(this.ech90);
			this.Controls.Add(this.ech85);
			this.Controls.Add(this.ech80);
			this.Controls.Add(this.ech75);
			this.Controls.Add(this.ech70);
			this.Controls.Add(this.ech65);
			this.Controls.Add(this.ech60);
			this.Controls.Add(this.ech55);
			this.Controls.Add(this.ech50);
			this.Controls.Add(this.ech45);
			this.Controls.Add(this.ech40);
			this.Controls.Add(this.ech35);
			this.Controls.Add(this.ech30);
			this.Controls.Add(this.ech25);
			this.Controls.Add(this.ech20);
			this.Controls.Add(this.ech15);
			this.Controls.Add(this.ech10);
			this.Controls.Add(this.ech5);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ech99);
			this.Controls.Add(this.ech94);
			this.Controls.Add(this.ech89);
			this.Controls.Add(this.ech84);
			this.Controls.Add(this.ech79);
			this.Controls.Add(this.ech74);
			this.Controls.Add(this.ech69);
			this.Controls.Add(this.ech64);
			this.Controls.Add(this.ech59);
			this.Controls.Add(this.ech54);
			this.Controls.Add(this.ech49);
			this.Controls.Add(this.ech44);
			this.Controls.Add(this.ech39);
			this.Controls.Add(this.ech34);
			this.Controls.Add(this.ech29);
			this.Controls.Add(this.ech24);
			this.Controls.Add(this.ech19);
			this.Controls.Add(this.ech14);
			this.Controls.Add(this.ech9);
			this.Controls.Add(this.ech4);
			this.Controls.Add(this.ech98);
			this.Controls.Add(this.ech93);
			this.Controls.Add(this.ech88);
			this.Controls.Add(this.ech83);
			this.Controls.Add(this.ech78);
			this.Controls.Add(this.ech73);
			this.Controls.Add(this.ech68);
			this.Controls.Add(this.ech63);
			this.Controls.Add(this.ech58);
			this.Controls.Add(this.ech53);
			this.Controls.Add(this.ech48);
			this.Controls.Add(this.ech43);
			this.Controls.Add(this.ech38);
			this.Controls.Add(this.ech33);
			this.Controls.Add(this.ech28);
			this.Controls.Add(this.ech23);
			this.Controls.Add(this.ech18);
			this.Controls.Add(this.ech13);
			this.Controls.Add(this.ech8);
			this.Controls.Add(this.ech3);
			this.Controls.Add(this.ech97);
			this.Controls.Add(this.ech92);
			this.Controls.Add(this.ech87);
			this.Controls.Add(this.ech82);
			this.Controls.Add(this.ech77);
			this.Controls.Add(this.ech72);
			this.Controls.Add(this.ech67);
			this.Controls.Add(this.ech62);
			this.Controls.Add(this.ech57);
			this.Controls.Add(this.ech52);
			this.Controls.Add(this.ech47);
			this.Controls.Add(this.ech42);
			this.Controls.Add(this.ech37);
			this.Controls.Add(this.ech32);
			this.Controls.Add(this.ech27);
			this.Controls.Add(this.ech22);
			this.Controls.Add(this.ech17);
			this.Controls.Add(this.ech12);
			this.Controls.Add(this.ech7);
			this.Controls.Add(this.ech2);
			this.Controls.Add(this.ech96);
			this.Controls.Add(this.ech91);
			this.Controls.Add(this.ech86);
			this.Controls.Add(this.ech81);
			this.Controls.Add(this.ech76);
			this.Controls.Add(this.ech71);
			this.Controls.Add(this.ech66);
			this.Controls.Add(this.ech61);
			this.Controls.Add(this.ech56);
			this.Controls.Add(this.ech51);
			this.Controls.Add(this.ech46);
			this.Controls.Add(this.ech41);
			this.Controls.Add(this.ech36);
			this.Controls.Add(this.ech31);
			this.Controls.Add(this.ech26);
			this.Controls.Add(this.ech21);
			this.Controls.Add(this.ech16);
			this.Controls.Add(this.ech11);
			this.Controls.Add(this.ech6);
			this.Controls.Add(this.ech1);
			this.Controls.Add(this.chartControl2);
			this.Controls.Add(this.chartControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "GraphiquesCAM2";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
