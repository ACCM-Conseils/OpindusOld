using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Opindus
{
	/// <summary>
	/// Description résumée de DetailControles.
	/// </summary>
	public class DetailControles : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.ListView listView5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private TMGDevelopment.PrintForm.PrintForm printForm1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.IContainer components;

		public DetailControles()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DetailControles));
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.listView2 = new System.Windows.Forms.ListView();
			this.listView1 = new System.Windows.Forms.ListView();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.listView4 = new System.Windows.Forms.ListView();
			this.listView3 = new System.Windows.Forms.ListView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.listView5 = new System.Windows.Forms.ListView();
			this.label7 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label28 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.printForm1 = new TMGDevelopment.PrintForm.PrintForm(this.components);
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox5);
			this.panel1.Controls.Add(this.groupBox6);
			this.panel1.Location = new System.Drawing.Point(8, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(739, 697);
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(696, 81);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(104, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(104, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(104, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(12, 75);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(696, 47);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(187, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(313, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "Norme E41.32.110.N(1990) et E.41.32.110.R(1990)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(248, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "CAPABILITE - CAM";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.label30);
			this.groupBox3.Controls.Add(this.label29);
			this.groupBox3.Controls.Add(this.label27);
			this.groupBox3.Controls.Add(this.label26);
			this.groupBox3.Controls.Add(this.label25);
			this.groupBox3.Controls.Add(this.label24);
			this.groupBox3.Controls.Add(this.label23);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.label21);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.listView2);
			this.groupBox3.Controls.Add(this.listView1);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Location = new System.Drawing.Point(8, 112);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(696, 312);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(328, 280);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(328, 16);
			this.label30.TabIndex = 25;
			this.label30.Text = "label30";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(48, 280);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(280, 16);
			this.label29.TabIndex = 24;
			this.label29.Text = "Mesures effectuées avec le matériel de contrôle relié :";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(576, 64);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(112, 16);
			this.label27.TabIndex = 22;
			this.label27.Text = "label27";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(576, 48);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(112, 16);
			this.label26.TabIndex = 21;
			this.label26.Text = "label26";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(576, 32);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(112, 16);
			this.label25.TabIndex = 20;
			this.label25.Text = "label25";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(576, 16);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(112, 16);
			this.label24.TabIndex = 19;
			this.label24.Text = "label24";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(120, 96);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(192, 16);
			this.label23.TabIndex = 18;
			this.label23.Text = "label23";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(120, 80);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(192, 16);
			this.label22.TabIndex = 17;
			this.label22.Text = "label22";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(120, 64);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(192, 16);
			this.label21.TabIndex = 16;
			this.label21.Text = "label21";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(120, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(192, 16);
			this.label20.TabIndex = 15;
			this.label20.Text = "label20";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(120, 32);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(192, 16);
			this.label19.TabIndex = 14;
			this.label19.Text = "label19";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(472, 80);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(72, 16);
			this.label17.TabIndex = 12;
			this.label17.Text = "Conformité";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(472, 64);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 16);
			this.label16.TabIndex = 11;
			this.label16.Text = "Dernier CAM";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(472, 48);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 16);
			this.label15.TabIndex = 10;
			this.label15.Text = "Opérateur";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(472, 32);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 16);
			this.label14.TabIndex = 9;
			this.label14.Text = "Date édition";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(472, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 16);
			this.label13.TabIndex = 8;
			this.label13.Text = "Date contrôle";
			// 
			// listView2
			// 
			this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader4,
																						this.columnHeader5,
																						this.columnHeader6,
																						this.columnHeader7,
																						this.columnHeader8,
																						this.columnHeader9});
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Location = new System.Drawing.Point(296, 136);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(368, 123);
			this.listView2.TabIndex = 7;
			this.printForm1.SetUseLegacyPrinting(this.listView2, true);
			this.listView2.View = System.Windows.Forms.View.Details;
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
			this.listView1.Location = new System.Drawing.Point(8, 136);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(232, 122);
			this.listView1.TabIndex = 6;
			this.printForm1.SetUseLegacyPrinting(this.listView1, true);
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 96);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 16);
			this.label12.TabIndex = 5;
			this.label12.Text = "Site";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 80);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(88, 16);
			this.label11.TabIndex = 4;
			this.label11.Text = "Affectation";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 16);
			this.label10.TabIndex = 3;
			this.label10.Text = "Code machine";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 15);
			this.label9.TabIndex = 2;
			this.label9.Text = "Type";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 16);
			this.label8.TabIndex = 1;
			this.label8.Text = "Marque";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label28);
			this.groupBox4.Controls.Add(this.listView4);
			this.groupBox4.Controls.Add(this.listView3);
			this.groupBox4.Location = new System.Drawing.Point(8, 416);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(696, 208);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			// 
			// listView4
			// 
			this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView4.FullRowSelect = true;
			this.listView4.GridLines = true;
			this.listView4.Location = new System.Drawing.Point(16, 56);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(280, 136);
			this.listView4.TabIndex = 1;
			this.printForm1.SetUseLegacyPrinting(this.listView4, true);
			this.listView4.View = System.Windows.Forms.View.Details;
			// 
			// listView3
			// 
			this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView3.FullRowSelect = true;
			this.listView3.GridLines = true;
			this.listView3.Location = new System.Drawing.Point(304, 40);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(368, 152);
			this.listView3.TabIndex = 0;
			this.printForm1.SetUseLegacyPrinting(this.listView3, true);
			this.listView3.View = System.Windows.Forms.View.Details;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label35);
			this.groupBox5.Controls.Add(this.label34);
			this.groupBox5.Controls.Add(this.label33);
			this.groupBox5.Controls.Add(this.label32);
			this.groupBox5.Controls.Add(this.label31);
			this.groupBox5.Location = new System.Drawing.Point(8, 616);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(696, 88);
			this.groupBox5.TabIndex = 10;
			this.groupBox5.TabStop = false;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label36);
			this.groupBox6.Controls.Add(this.listView5);
			this.groupBox6.Location = new System.Drawing.Point(8, 696);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(697, 170);
			this.groupBox6.TabIndex = 11;
			this.groupBox6.TabStop = false;
			// 
			// listView5
			// 
			this.listView5.GridLines = true;
			this.listView5.Location = new System.Drawing.Point(232, 56);
			this.listView5.Name = "listView5";
			this.listView5.Size = new System.Drawing.Size(360, 97);
			this.listView5.TabIndex = 0;
			this.printForm1.SetUseLegacyPrinting(this.listView5, true);
			this.listView5.View = System.Windows.Forms.View.Details;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "Contrôle N°";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(120, 16);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(192, 16);
			this.label18.TabIndex = 27;
			this.label18.Text = "label18";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(576, 80);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(16, 24);
			this.checkBox1.TabIndex = 28;
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(296, 8);
			this.label28.Name = "label28";
			this.label28.TabIndex = 2;
			this.label28.Text = "Calculs";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(8, 117);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(232, 20);
			this.textBox1.TabIndex = 29;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.printForm1.SetUseLegacyPrinting(this.textBox1, true);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(296, 117);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(368, 20);
			this.textBox2.TabIndex = 30;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.printForm1.SetUseLegacyPrinting(this.textBox2, true);
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label31.Location = new System.Drawing.Point(168, 8);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(328, 23);
			this.label31.TabIndex = 0;
			this.label31.Text = "Tests (Non significatif pour 30 mesures)";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(8, 40);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(100, 16);
			this.label32.TabIndex = 1;
			this.label32.Text = "Test de dérive :";
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(8, 64);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(192, 16);
			this.label33.TabIndex = 2;
			this.label33.Text = "Test de normalité (Kolmogorov) :";
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(216, 40);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(456, 16);
			this.label34.TabIndex = 3;
			this.label34.Text = "label34";
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(216, 64);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(456, 16);
			this.label35.TabIndex = 4;
			this.label35.Text = "label35";
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label36.Location = new System.Drawing.Point(96, 16);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(536, 16);
			this.label36.TabIndex = 1;
			this.label36.Text = "Comparaison avec la norme E 39.11.020.N (1989) à partir des valeurs ci-dessus.";
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(123, 17);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(521, 713);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(193, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// DetailControles
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(851, 744);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DetailControles";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DetailControles";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			printPreviewDialog1.Document=printForm1;
			printPreviewDialog1.ShowDialog();
		}

	}
}
