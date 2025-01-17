using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Opindus
{
	/// <summary>
	/// Description résumée de DemandePrix.
	/// </summary>
	public class DemandePrix : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox40;
		private System.Windows.Forms.TextBox textBox41;
		private System.Windows.Forms.TextBox textBox42;
		private System.Windows.Forms.TextBox textBox43;
		private System.Windows.Forms.TextBox textBox44;
		private System.Windows.Forms.TextBox textBox35;
		private System.Windows.Forms.TextBox textBox36;
		private System.Windows.Forms.TextBox textBox37;
		private System.Windows.Forms.TextBox textBox38;
		private System.Windows.Forms.TextBox textBox39;
		private System.Windows.Forms.TextBox textBox30;
		private System.Windows.Forms.TextBox textBox31;
		private System.Windows.Forms.TextBox textBox32;
		private System.Windows.Forms.TextBox textBox33;
		private System.Windows.Forms.TextBox textBox34;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.TextBox textBox26;
		private System.Windows.Forms.TextBox textBox27;
		private System.Windows.Forms.TextBox textBox28;
		private System.Windows.Forms.TextBox textBox29;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private MTGCComboBox mtgcComboBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.TextBox textBox45;
		private System.Windows.Forms.TextBox textBox46;
		private System.Windows.Forms.TextBox textBox47;
		private System.Windows.Forms.TextBox textBox48;
		private System.Windows.Forms.TextBox textBox49;
		private System.Windows.Forms.TextBox textBox50;
		private System.Windows.Forms.TextBox textBox51;
		private System.Windows.Forms.TextBox textBox52;
		private System.Windows.Forms.TextBox textBox53;
		private System.Windows.Forms.TextBox textBox54;
		private System.Windows.Forms.TextBox textBox55;
		private System.Windows.Forms.TextBox textBox56;
		private System.Windows.Forms.TextBox textBox57;
		private System.Windows.Forms.TextBox textBox58;
		private System.Windows.Forms.TextBox textBox59;
		private System.Windows.Forms.TextBox textBox60;
		private System.Windows.Forms.TextBox textBox61;
		private System.Windows.Forms.TextBox textBox62;
		private System.Windows.Forms.TextBox textBox63;
		private System.Windows.Forms.TextBox textBox64;
		private System.Windows.Forms.TextBox textBox65;
		private System.Windows.Forms.TextBox textBox66;
		private System.Windows.Forms.TextBox textBox67;
		private System.Windows.Forms.TextBox textBox68;
		private System.Windows.Forms.TextBox textBox69;
		private System.Windows.Forms.TextBox textBox70;
		private System.Windows.Forms.TextBox textBox71;
		private System.Windows.Forms.TextBox textBox72;
		private System.Windows.Forms.TextBox textBox73;
		private System.Windows.Forms.TextBox textBox74;
		private System.Windows.Forms.TextBox textBox75;
		private System.Windows.Forms.TextBox textBox76;
		private System.Windows.Forms.TextBox textBox77;
		private System.Windows.Forms.TextBox textBox78;
		private System.Windows.Forms.TextBox textBox79;
		private System.Windows.Forms.TextBox textBox80;
		private System.Windows.Forms.TextBox textBox81;
		private System.Windows.Forms.TextBox textBox82;
		private System.Windows.Forms.TextBox textBox83;
		private System.Windows.Forms.TextBox textBox84;
		private System.ComponentModel.IContainer components;

		public DemandePrix()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
			dateTimePicker1.Value=DateTime.Now;
			mtgcComboBox1.Items.Add(new MTGCComboBoxItem("M","","",""));
			mtgcComboBox1.Items.Add(new MTGCComboBoxItem("Mme","","",""));
			mtgcComboBox1.SelectedIndex=0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DemandePrix));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox45 = new System.Windows.Forms.TextBox();
			this.textBox46 = new System.Windows.Forms.TextBox();
			this.textBox47 = new System.Windows.Forms.TextBox();
			this.textBox48 = new System.Windows.Forms.TextBox();
			this.textBox49 = new System.Windows.Forms.TextBox();
			this.textBox50 = new System.Windows.Forms.TextBox();
			this.textBox51 = new System.Windows.Forms.TextBox();
			this.textBox52 = new System.Windows.Forms.TextBox();
			this.textBox53 = new System.Windows.Forms.TextBox();
			this.textBox54 = new System.Windows.Forms.TextBox();
			this.textBox55 = new System.Windows.Forms.TextBox();
			this.textBox56 = new System.Windows.Forms.TextBox();
			this.textBox57 = new System.Windows.Forms.TextBox();
			this.textBox58 = new System.Windows.Forms.TextBox();
			this.textBox59 = new System.Windows.Forms.TextBox();
			this.textBox60 = new System.Windows.Forms.TextBox();
			this.textBox61 = new System.Windows.Forms.TextBox();
			this.textBox62 = new System.Windows.Forms.TextBox();
			this.textBox63 = new System.Windows.Forms.TextBox();
			this.textBox64 = new System.Windows.Forms.TextBox();
			this.textBox65 = new System.Windows.Forms.TextBox();
			this.textBox66 = new System.Windows.Forms.TextBox();
			this.textBox67 = new System.Windows.Forms.TextBox();
			this.textBox68 = new System.Windows.Forms.TextBox();
			this.textBox69 = new System.Windows.Forms.TextBox();
			this.textBox70 = new System.Windows.Forms.TextBox();
			this.textBox71 = new System.Windows.Forms.TextBox();
			this.textBox72 = new System.Windows.Forms.TextBox();
			this.textBox73 = new System.Windows.Forms.TextBox();
			this.textBox74 = new System.Windows.Forms.TextBox();
			this.textBox75 = new System.Windows.Forms.TextBox();
			this.textBox76 = new System.Windows.Forms.TextBox();
			this.textBox77 = new System.Windows.Forms.TextBox();
			this.textBox78 = new System.Windows.Forms.TextBox();
			this.textBox79 = new System.Windows.Forms.TextBox();
			this.textBox80 = new System.Windows.Forms.TextBox();
			this.textBox81 = new System.Windows.Forms.TextBox();
			this.textBox82 = new System.Windows.Forms.TextBox();
			this.textBox83 = new System.Windows.Forms.TextBox();
			this.textBox84 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.textBox40 = new System.Windows.Forms.TextBox();
			this.textBox41 = new System.Windows.Forms.TextBox();
			this.textBox42 = new System.Windows.Forms.TextBox();
			this.textBox43 = new System.Windows.Forms.TextBox();
			this.textBox44 = new System.Windows.Forms.TextBox();
			this.textBox35 = new System.Windows.Forms.TextBox();
			this.textBox36 = new System.Windows.Forms.TextBox();
			this.textBox37 = new System.Windows.Forms.TextBox();
			this.textBox38 = new System.Windows.Forms.TextBox();
			this.textBox39 = new System.Windows.Forms.TextBox();
			this.textBox30 = new System.Windows.Forms.TextBox();
			this.textBox31 = new System.Windows.Forms.TextBox();
			this.textBox32 = new System.Windows.Forms.TextBox();
			this.textBox33 = new System.Windows.Forms.TextBox();
			this.textBox34 = new System.Windows.Forms.TextBox();
			this.textBox25 = new System.Windows.Forms.TextBox();
			this.textBox26 = new System.Windows.Forms.TextBox();
			this.textBox27 = new System.Windows.Forms.TextBox();
			this.textBox28 = new System.Windows.Forms.TextBox();
			this.textBox29 = new System.Windows.Forms.TextBox();
			this.textBox20 = new System.Windows.Forms.TextBox();
			this.textBox21 = new System.Windows.Forms.TextBox();
			this.textBox22 = new System.Windows.Forms.TextBox();
			this.textBox23 = new System.Windows.Forms.TextBox();
			this.textBox24 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.textBox18 = new System.Windows.Forms.TextBox();
			this.textBox19 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.mtgcComboBox1 = new MTGCComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.panel1.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(560, 712);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(184, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Impression";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(8, 712);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "Quitter";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.textBox45);
			this.panel1.Controls.Add(this.textBox46);
			this.panel1.Controls.Add(this.textBox47);
			this.panel1.Controls.Add(this.textBox48);
			this.panel1.Controls.Add(this.textBox49);
			this.panel1.Controls.Add(this.textBox50);
			this.panel1.Controls.Add(this.textBox51);
			this.panel1.Controls.Add(this.textBox52);
			this.panel1.Controls.Add(this.textBox53);
			this.panel1.Controls.Add(this.textBox54);
			this.panel1.Controls.Add(this.textBox55);
			this.panel1.Controls.Add(this.textBox56);
			this.panel1.Controls.Add(this.textBox57);
			this.panel1.Controls.Add(this.textBox58);
			this.panel1.Controls.Add(this.textBox59);
			this.panel1.Controls.Add(this.textBox60);
			this.panel1.Controls.Add(this.textBox61);
			this.panel1.Controls.Add(this.textBox62);
			this.panel1.Controls.Add(this.textBox63);
			this.panel1.Controls.Add(this.textBox64);
			this.panel1.Controls.Add(this.textBox65);
			this.panel1.Controls.Add(this.textBox66);
			this.panel1.Controls.Add(this.textBox67);
			this.panel1.Controls.Add(this.textBox68);
			this.panel1.Controls.Add(this.textBox69);
			this.panel1.Controls.Add(this.textBox70);
			this.panel1.Controls.Add(this.textBox71);
			this.panel1.Controls.Add(this.textBox72);
			this.panel1.Controls.Add(this.textBox73);
			this.panel1.Controls.Add(this.textBox74);
			this.panel1.Controls.Add(this.textBox75);
			this.panel1.Controls.Add(this.textBox76);
			this.panel1.Controls.Add(this.textBox77);
			this.panel1.Controls.Add(this.textBox78);
			this.panel1.Controls.Add(this.textBox79);
			this.panel1.Controls.Add(this.textBox80);
			this.panel1.Controls.Add(this.textBox81);
			this.panel1.Controls.Add(this.textBox82);
			this.panel1.Controls.Add(this.textBox83);
			this.panel1.Controls.Add(this.textBox84);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.panel10);
			this.panel1.Controls.Add(this.textBox40);
			this.panel1.Controls.Add(this.textBox41);
			this.panel1.Controls.Add(this.textBox42);
			this.panel1.Controls.Add(this.textBox43);
			this.panel1.Controls.Add(this.textBox44);
			this.panel1.Controls.Add(this.textBox35);
			this.panel1.Controls.Add(this.textBox36);
			this.panel1.Controls.Add(this.textBox37);
			this.panel1.Controls.Add(this.textBox38);
			this.panel1.Controls.Add(this.textBox39);
			this.panel1.Controls.Add(this.textBox30);
			this.panel1.Controls.Add(this.textBox31);
			this.panel1.Controls.Add(this.textBox32);
			this.panel1.Controls.Add(this.textBox33);
			this.panel1.Controls.Add(this.textBox34);
			this.panel1.Controls.Add(this.textBox25);
			this.panel1.Controls.Add(this.textBox26);
			this.panel1.Controls.Add(this.textBox27);
			this.panel1.Controls.Add(this.textBox28);
			this.panel1.Controls.Add(this.textBox29);
			this.panel1.Controls.Add(this.textBox20);
			this.panel1.Controls.Add(this.textBox21);
			this.panel1.Controls.Add(this.textBox22);
			this.panel1.Controls.Add(this.textBox23);
			this.panel1.Controls.Add(this.textBox24);
			this.panel1.Controls.Add(this.textBox15);
			this.panel1.Controls.Add(this.textBox16);
			this.panel1.Controls.Add(this.textBox17);
			this.panel1.Controls.Add(this.textBox18);
			this.panel1.Controls.Add(this.textBox19);
			this.panel1.Controls.Add(this.textBox10);
			this.panel1.Controls.Add(this.textBox11);
			this.panel1.Controls.Add(this.textBox12);
			this.panel1.Controls.Add(this.textBox13);
			this.panel1.Controls.Add(this.textBox14);
			this.panel1.Controls.Add(this.textBox9);
			this.panel1.Controls.Add(this.textBox8);
			this.panel1.Controls.Add(this.textBox7);
			this.panel1.Controls.Add(this.textBox6);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.mtgcComboBox1);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.panel8);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(760, 696);
			this.panel1.TabIndex = 3;
			// 
			// textBox45
			// 
			this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox45.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox45.Location = new System.Drawing.Point(672, 736);
			this.textBox45.Name = "textBox45";
			this.textBox45.Size = new System.Drawing.Size(52, 20);
			this.textBox45.TabIndex = 203;
			this.textBox45.Text = "";
			// 
			// textBox46
			// 
			this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox46.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox46.Location = new System.Drawing.Point(608, 736);
			this.textBox46.Name = "textBox46";
			this.textBox46.Size = new System.Drawing.Size(56, 20);
			this.textBox46.TabIndex = 202;
			this.textBox46.Text = "";
			// 
			// textBox47
			// 
			this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox47.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox47.Location = new System.Drawing.Point(528, 736);
			this.textBox47.Name = "textBox47";
			this.textBox47.Size = new System.Drawing.Size(72, 20);
			this.textBox47.TabIndex = 201;
			this.textBox47.Text = "";
			// 
			// textBox48
			// 
			this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox48.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox48.Location = new System.Drawing.Point(160, 736);
			this.textBox48.Name = "textBox48";
			this.textBox48.Size = new System.Drawing.Size(360, 20);
			this.textBox48.TabIndex = 200;
			this.textBox48.Text = "";
			// 
			// textBox49
			// 
			this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox49.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox49.Location = new System.Drawing.Point(8, 736);
			this.textBox49.Name = "textBox49";
			this.textBox49.Size = new System.Drawing.Size(144, 20);
			this.textBox49.TabIndex = 199;
			this.textBox49.Text = "";
			// 
			// textBox50
			// 
			this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox50.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox50.Location = new System.Drawing.Point(672, 712);
			this.textBox50.Name = "textBox50";
			this.textBox50.Size = new System.Drawing.Size(52, 20);
			this.textBox50.TabIndex = 198;
			this.textBox50.Text = "";
			// 
			// textBox51
			// 
			this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox51.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox51.Location = new System.Drawing.Point(608, 712);
			this.textBox51.Name = "textBox51";
			this.textBox51.Size = new System.Drawing.Size(56, 20);
			this.textBox51.TabIndex = 197;
			this.textBox51.Text = "";
			// 
			// textBox52
			// 
			this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox52.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox52.Location = new System.Drawing.Point(528, 712);
			this.textBox52.Name = "textBox52";
			this.textBox52.Size = new System.Drawing.Size(72, 20);
			this.textBox52.TabIndex = 196;
			this.textBox52.Text = "";
			// 
			// textBox53
			// 
			this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox53.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox53.Location = new System.Drawing.Point(160, 712);
			this.textBox53.Name = "textBox53";
			this.textBox53.Size = new System.Drawing.Size(360, 20);
			this.textBox53.TabIndex = 195;
			this.textBox53.Text = "";
			// 
			// textBox54
			// 
			this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox54.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox54.Location = new System.Drawing.Point(8, 712);
			this.textBox54.Name = "textBox54";
			this.textBox54.Size = new System.Drawing.Size(144, 20);
			this.textBox54.TabIndex = 194;
			this.textBox54.Text = "";
			// 
			// textBox55
			// 
			this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox55.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox55.Location = new System.Drawing.Point(672, 688);
			this.textBox55.Name = "textBox55";
			this.textBox55.Size = new System.Drawing.Size(52, 20);
			this.textBox55.TabIndex = 193;
			this.textBox55.Text = "";
			// 
			// textBox56
			// 
			this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox56.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox56.Location = new System.Drawing.Point(608, 688);
			this.textBox56.Name = "textBox56";
			this.textBox56.Size = new System.Drawing.Size(56, 20);
			this.textBox56.TabIndex = 192;
			this.textBox56.Text = "";
			// 
			// textBox57
			// 
			this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox57.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox57.Location = new System.Drawing.Point(528, 688);
			this.textBox57.Name = "textBox57";
			this.textBox57.Size = new System.Drawing.Size(72, 20);
			this.textBox57.TabIndex = 191;
			this.textBox57.Text = "";
			// 
			// textBox58
			// 
			this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox58.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox58.Location = new System.Drawing.Point(160, 688);
			this.textBox58.Name = "textBox58";
			this.textBox58.Size = new System.Drawing.Size(360, 20);
			this.textBox58.TabIndex = 190;
			this.textBox58.Text = "";
			// 
			// textBox59
			// 
			this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox59.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox59.Location = new System.Drawing.Point(8, 688);
			this.textBox59.Name = "textBox59";
			this.textBox59.Size = new System.Drawing.Size(144, 20);
			this.textBox59.TabIndex = 189;
			this.textBox59.Text = "";
			// 
			// textBox60
			// 
			this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox60.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox60.Location = new System.Drawing.Point(672, 664);
			this.textBox60.Name = "textBox60";
			this.textBox60.Size = new System.Drawing.Size(52, 20);
			this.textBox60.TabIndex = 188;
			this.textBox60.Text = "";
			// 
			// textBox61
			// 
			this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox61.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox61.Location = new System.Drawing.Point(608, 664);
			this.textBox61.Name = "textBox61";
			this.textBox61.Size = new System.Drawing.Size(56, 20);
			this.textBox61.TabIndex = 187;
			this.textBox61.Text = "";
			// 
			// textBox62
			// 
			this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox62.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox62.Location = new System.Drawing.Point(528, 664);
			this.textBox62.Name = "textBox62";
			this.textBox62.Size = new System.Drawing.Size(72, 20);
			this.textBox62.TabIndex = 186;
			this.textBox62.Text = "";
			// 
			// textBox63
			// 
			this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox63.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox63.Location = new System.Drawing.Point(160, 664);
			this.textBox63.Name = "textBox63";
			this.textBox63.Size = new System.Drawing.Size(360, 20);
			this.textBox63.TabIndex = 185;
			this.textBox63.Text = "";
			// 
			// textBox64
			// 
			this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox64.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox64.Location = new System.Drawing.Point(8, 664);
			this.textBox64.Name = "textBox64";
			this.textBox64.Size = new System.Drawing.Size(144, 20);
			this.textBox64.TabIndex = 184;
			this.textBox64.Text = "";
			// 
			// textBox65
			// 
			this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox65.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox65.Location = new System.Drawing.Point(672, 640);
			this.textBox65.Name = "textBox65";
			this.textBox65.Size = new System.Drawing.Size(52, 20);
			this.textBox65.TabIndex = 183;
			this.textBox65.Text = "";
			// 
			// textBox66
			// 
			this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox66.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox66.Location = new System.Drawing.Point(608, 640);
			this.textBox66.Name = "textBox66";
			this.textBox66.Size = new System.Drawing.Size(56, 20);
			this.textBox66.TabIndex = 182;
			this.textBox66.Text = "";
			// 
			// textBox67
			// 
			this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox67.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox67.Location = new System.Drawing.Point(528, 640);
			this.textBox67.Name = "textBox67";
			this.textBox67.Size = new System.Drawing.Size(72, 20);
			this.textBox67.TabIndex = 181;
			this.textBox67.Text = "";
			// 
			// textBox68
			// 
			this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox68.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox68.Location = new System.Drawing.Point(160, 640);
			this.textBox68.Name = "textBox68";
			this.textBox68.Size = new System.Drawing.Size(360, 20);
			this.textBox68.TabIndex = 180;
			this.textBox68.Text = "";
			// 
			// textBox69
			// 
			this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox69.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox69.Location = new System.Drawing.Point(8, 640);
			this.textBox69.Name = "textBox69";
			this.textBox69.Size = new System.Drawing.Size(144, 20);
			this.textBox69.TabIndex = 179;
			this.textBox69.Text = "";
			// 
			// textBox70
			// 
			this.textBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox70.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox70.Location = new System.Drawing.Point(672, 616);
			this.textBox70.Name = "textBox70";
			this.textBox70.Size = new System.Drawing.Size(52, 20);
			this.textBox70.TabIndex = 178;
			this.textBox70.Text = "";
			// 
			// textBox71
			// 
			this.textBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox71.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox71.Location = new System.Drawing.Point(608, 616);
			this.textBox71.Name = "textBox71";
			this.textBox71.Size = new System.Drawing.Size(56, 20);
			this.textBox71.TabIndex = 177;
			this.textBox71.Text = "";
			// 
			// textBox72
			// 
			this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox72.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox72.Location = new System.Drawing.Point(528, 616);
			this.textBox72.Name = "textBox72";
			this.textBox72.Size = new System.Drawing.Size(72, 20);
			this.textBox72.TabIndex = 176;
			this.textBox72.Text = "";
			// 
			// textBox73
			// 
			this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox73.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox73.Location = new System.Drawing.Point(160, 616);
			this.textBox73.Name = "textBox73";
			this.textBox73.Size = new System.Drawing.Size(360, 20);
			this.textBox73.TabIndex = 175;
			this.textBox73.Text = "";
			// 
			// textBox74
			// 
			this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox74.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox74.Location = new System.Drawing.Point(8, 616);
			this.textBox74.Name = "textBox74";
			this.textBox74.Size = new System.Drawing.Size(144, 20);
			this.textBox74.TabIndex = 174;
			this.textBox74.Text = "";
			// 
			// textBox75
			// 
			this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox75.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox75.Location = new System.Drawing.Point(672, 592);
			this.textBox75.Name = "textBox75";
			this.textBox75.Size = new System.Drawing.Size(52, 20);
			this.textBox75.TabIndex = 173;
			this.textBox75.Text = "";
			// 
			// textBox76
			// 
			this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox76.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox76.Location = new System.Drawing.Point(608, 592);
			this.textBox76.Name = "textBox76";
			this.textBox76.Size = new System.Drawing.Size(56, 20);
			this.textBox76.TabIndex = 172;
			this.textBox76.Text = "";
			// 
			// textBox77
			// 
			this.textBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox77.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox77.Location = new System.Drawing.Point(528, 592);
			this.textBox77.Name = "textBox77";
			this.textBox77.Size = new System.Drawing.Size(72, 20);
			this.textBox77.TabIndex = 171;
			this.textBox77.Text = "";
			// 
			// textBox78
			// 
			this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox78.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox78.Location = new System.Drawing.Point(160, 592);
			this.textBox78.Name = "textBox78";
			this.textBox78.Size = new System.Drawing.Size(360, 20);
			this.textBox78.TabIndex = 170;
			this.textBox78.Text = "";
			// 
			// textBox79
			// 
			this.textBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox79.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox79.Location = new System.Drawing.Point(8, 592);
			this.textBox79.Name = "textBox79";
			this.textBox79.Size = new System.Drawing.Size(144, 20);
			this.textBox79.TabIndex = 169;
			this.textBox79.Text = "";
			// 
			// textBox80
			// 
			this.textBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox80.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox80.Location = new System.Drawing.Point(672, 568);
			this.textBox80.Name = "textBox80";
			this.textBox80.Size = new System.Drawing.Size(52, 20);
			this.textBox80.TabIndex = 168;
			this.textBox80.Text = "";
			// 
			// textBox81
			// 
			this.textBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox81.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox81.Location = new System.Drawing.Point(608, 568);
			this.textBox81.Name = "textBox81";
			this.textBox81.Size = new System.Drawing.Size(56, 20);
			this.textBox81.TabIndex = 167;
			this.textBox81.Text = "";
			// 
			// textBox82
			// 
			this.textBox82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox82.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox82.Location = new System.Drawing.Point(528, 568);
			this.textBox82.Name = "textBox82";
			this.textBox82.Size = new System.Drawing.Size(72, 20);
			this.textBox82.TabIndex = 166;
			this.textBox82.Text = "";
			// 
			// textBox83
			// 
			this.textBox83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox83.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox83.Location = new System.Drawing.Point(160, 568);
			this.textBox83.Name = "textBox83";
			this.textBox83.Size = new System.Drawing.Size(360, 20);
			this.textBox83.TabIndex = 165;
			this.textBox83.Text = "";
			// 
			// textBox84
			// 
			this.textBox84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox84.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox84.Location = new System.Drawing.Point(8, 568);
			this.textBox84.Name = "textBox84";
			this.textBox84.Size = new System.Drawing.Size(144, 20);
			this.textBox84.TabIndex = 164;
			this.textBox84.Text = "";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(200, 1208);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(320, 23);
			this.label16.TabIndex = 163;
			this.label16.Text = "La maitrise de l\'outillage pneumatique.";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(8, 1184);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(720, 23);
			this.label15.TabIndex = 162;
			this.label15.Text = "Réparation tous types, toutes marque pneumatiques, électrique, hydraulique.";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Black;
			this.panel10.Controls.Add(this.panel11);
			this.panel10.Location = new System.Drawing.Point(-9, 1176);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(745, 3);
			this.panel10.TabIndex = 161;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.Black;
			this.panel11.Location = new System.Drawing.Point(0, 48);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(736, 3);
			this.panel11.TabIndex = 7;
			// 
			// textBox40
			// 
			this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox40.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox40.Location = new System.Drawing.Point(672, 544);
			this.textBox40.Name = "textBox40";
			this.textBox40.Size = new System.Drawing.Size(52, 20);
			this.textBox40.TabIndex = 159;
			this.textBox40.Text = "";
			// 
			// textBox41
			// 
			this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox41.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox41.Location = new System.Drawing.Point(608, 544);
			this.textBox41.Name = "textBox41";
			this.textBox41.Size = new System.Drawing.Size(56, 20);
			this.textBox41.TabIndex = 158;
			this.textBox41.Text = "";
			// 
			// textBox42
			// 
			this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox42.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox42.Location = new System.Drawing.Point(528, 544);
			this.textBox42.Name = "textBox42";
			this.textBox42.Size = new System.Drawing.Size(72, 20);
			this.textBox42.TabIndex = 157;
			this.textBox42.Text = "";
			// 
			// textBox43
			// 
			this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox43.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox43.Location = new System.Drawing.Point(160, 544);
			this.textBox43.Name = "textBox43";
			this.textBox43.Size = new System.Drawing.Size(360, 20);
			this.textBox43.TabIndex = 156;
			this.textBox43.Text = "";
			// 
			// textBox44
			// 
			this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox44.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox44.Location = new System.Drawing.Point(8, 544);
			this.textBox44.Name = "textBox44";
			this.textBox44.Size = new System.Drawing.Size(144, 20);
			this.textBox44.TabIndex = 155;
			this.textBox44.Text = "";
			// 
			// textBox35
			// 
			this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox35.Location = new System.Drawing.Point(672, 520);
			this.textBox35.Name = "textBox35";
			this.textBox35.Size = new System.Drawing.Size(52, 20);
			this.textBox35.TabIndex = 154;
			this.textBox35.Text = "";
			// 
			// textBox36
			// 
			this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox36.Location = new System.Drawing.Point(608, 520);
			this.textBox36.Name = "textBox36";
			this.textBox36.Size = new System.Drawing.Size(56, 20);
			this.textBox36.TabIndex = 153;
			this.textBox36.Text = "";
			// 
			// textBox37
			// 
			this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox37.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox37.Location = new System.Drawing.Point(528, 520);
			this.textBox37.Name = "textBox37";
			this.textBox37.Size = new System.Drawing.Size(72, 20);
			this.textBox37.TabIndex = 152;
			this.textBox37.Text = "";
			// 
			// textBox38
			// 
			this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox38.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox38.Location = new System.Drawing.Point(160, 520);
			this.textBox38.Name = "textBox38";
			this.textBox38.Size = new System.Drawing.Size(360, 20);
			this.textBox38.TabIndex = 151;
			this.textBox38.Text = "";
			// 
			// textBox39
			// 
			this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox39.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox39.Location = new System.Drawing.Point(8, 520);
			this.textBox39.Name = "textBox39";
			this.textBox39.Size = new System.Drawing.Size(144, 20);
			this.textBox39.TabIndex = 150;
			this.textBox39.Text = "";
			// 
			// textBox30
			// 
			this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox30.Location = new System.Drawing.Point(672, 496);
			this.textBox30.Name = "textBox30";
			this.textBox30.Size = new System.Drawing.Size(52, 20);
			this.textBox30.TabIndex = 149;
			this.textBox30.Text = "";
			// 
			// textBox31
			// 
			this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox31.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox31.Location = new System.Drawing.Point(608, 496);
			this.textBox31.Name = "textBox31";
			this.textBox31.Size = new System.Drawing.Size(56, 20);
			this.textBox31.TabIndex = 148;
			this.textBox31.Text = "";
			// 
			// textBox32
			// 
			this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox32.Location = new System.Drawing.Point(528, 496);
			this.textBox32.Name = "textBox32";
			this.textBox32.Size = new System.Drawing.Size(72, 20);
			this.textBox32.TabIndex = 147;
			this.textBox32.Text = "";
			// 
			// textBox33
			// 
			this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox33.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox33.Location = new System.Drawing.Point(160, 496);
			this.textBox33.Name = "textBox33";
			this.textBox33.Size = new System.Drawing.Size(360, 20);
			this.textBox33.TabIndex = 146;
			this.textBox33.Text = "";
			// 
			// textBox34
			// 
			this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox34.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox34.Location = new System.Drawing.Point(8, 496);
			this.textBox34.Name = "textBox34";
			this.textBox34.Size = new System.Drawing.Size(144, 20);
			this.textBox34.TabIndex = 145;
			this.textBox34.Text = "";
			// 
			// textBox25
			// 
			this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox25.Location = new System.Drawing.Point(672, 472);
			this.textBox25.Name = "textBox25";
			this.textBox25.Size = new System.Drawing.Size(52, 20);
			this.textBox25.TabIndex = 144;
			this.textBox25.Text = "";
			// 
			// textBox26
			// 
			this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox26.Location = new System.Drawing.Point(608, 472);
			this.textBox26.Name = "textBox26";
			this.textBox26.Size = new System.Drawing.Size(56, 20);
			this.textBox26.TabIndex = 143;
			this.textBox26.Text = "";
			// 
			// textBox27
			// 
			this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox27.Location = new System.Drawing.Point(528, 472);
			this.textBox27.Name = "textBox27";
			this.textBox27.Size = new System.Drawing.Size(72, 20);
			this.textBox27.TabIndex = 142;
			this.textBox27.Text = "";
			// 
			// textBox28
			// 
			this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox28.Location = new System.Drawing.Point(160, 472);
			this.textBox28.Name = "textBox28";
			this.textBox28.Size = new System.Drawing.Size(360, 20);
			this.textBox28.TabIndex = 141;
			this.textBox28.Text = "";
			// 
			// textBox29
			// 
			this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox29.Location = new System.Drawing.Point(8, 472);
			this.textBox29.Name = "textBox29";
			this.textBox29.Size = new System.Drawing.Size(144, 20);
			this.textBox29.TabIndex = 140;
			this.textBox29.Text = "";
			// 
			// textBox20
			// 
			this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox20.Location = new System.Drawing.Point(672, 448);
			this.textBox20.Name = "textBox20";
			this.textBox20.Size = new System.Drawing.Size(52, 20);
			this.textBox20.TabIndex = 139;
			this.textBox20.Text = "";
			// 
			// textBox21
			// 
			this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox21.Location = new System.Drawing.Point(608, 448);
			this.textBox21.Name = "textBox21";
			this.textBox21.Size = new System.Drawing.Size(56, 20);
			this.textBox21.TabIndex = 138;
			this.textBox21.Text = "";
			// 
			// textBox22
			// 
			this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox22.Location = new System.Drawing.Point(528, 448);
			this.textBox22.Name = "textBox22";
			this.textBox22.Size = new System.Drawing.Size(72, 20);
			this.textBox22.TabIndex = 137;
			this.textBox22.Text = "";
			// 
			// textBox23
			// 
			this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox23.Location = new System.Drawing.Point(160, 448);
			this.textBox23.Name = "textBox23";
			this.textBox23.Size = new System.Drawing.Size(360, 20);
			this.textBox23.TabIndex = 136;
			this.textBox23.Text = "";
			// 
			// textBox24
			// 
			this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox24.Location = new System.Drawing.Point(8, 448);
			this.textBox24.Name = "textBox24";
			this.textBox24.Size = new System.Drawing.Size(144, 20);
			this.textBox24.TabIndex = 135;
			this.textBox24.Text = "";
			// 
			// textBox15
			// 
			this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox15.Location = new System.Drawing.Point(672, 424);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(52, 20);
			this.textBox15.TabIndex = 134;
			this.textBox15.Text = "";
			// 
			// textBox16
			// 
			this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox16.Location = new System.Drawing.Point(608, 424);
			this.textBox16.Name = "textBox16";
			this.textBox16.Size = new System.Drawing.Size(56, 20);
			this.textBox16.TabIndex = 133;
			this.textBox16.Text = "";
			// 
			// textBox17
			// 
			this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox17.Location = new System.Drawing.Point(528, 424);
			this.textBox17.Name = "textBox17";
			this.textBox17.Size = new System.Drawing.Size(72, 20);
			this.textBox17.TabIndex = 132;
			this.textBox17.Text = "";
			// 
			// textBox18
			// 
			this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox18.Location = new System.Drawing.Point(160, 424);
			this.textBox18.Name = "textBox18";
			this.textBox18.Size = new System.Drawing.Size(360, 20);
			this.textBox18.TabIndex = 131;
			this.textBox18.Text = "";
			// 
			// textBox19
			// 
			this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox19.Location = new System.Drawing.Point(8, 424);
			this.textBox19.Name = "textBox19";
			this.textBox19.Size = new System.Drawing.Size(144, 20);
			this.textBox19.TabIndex = 130;
			this.textBox19.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox10.Location = new System.Drawing.Point(672, 400);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(52, 20);
			this.textBox10.TabIndex = 129;
			this.textBox10.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox11.Location = new System.Drawing.Point(608, 400);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(56, 20);
			this.textBox11.TabIndex = 128;
			this.textBox11.Text = "";
			// 
			// textBox12
			// 
			this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox12.Location = new System.Drawing.Point(528, 400);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(72, 20);
			this.textBox12.TabIndex = 127;
			this.textBox12.Text = "";
			// 
			// textBox13
			// 
			this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox13.Location = new System.Drawing.Point(160, 400);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(360, 20);
			this.textBox13.TabIndex = 126;
			this.textBox13.Text = "";
			// 
			// textBox14
			// 
			this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox14.Location = new System.Drawing.Point(8, 400);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(144, 20);
			this.textBox14.TabIndex = 125;
			this.textBox14.Text = "";
			// 
			// textBox9
			// 
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox9.Location = new System.Drawing.Point(672, 376);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(52, 20);
			this.textBox9.TabIndex = 124;
			this.textBox9.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox8.Location = new System.Drawing.Point(608, 376);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(56, 20);
			this.textBox8.TabIndex = 123;
			this.textBox8.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(528, 376);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(72, 20);
			this.textBox7.TabIndex = 122;
			this.textBox7.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(160, 376);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(360, 20);
			this.textBox6.TabIndex = 121;
			this.textBox6.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(8, 376);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(144, 20);
			this.textBox5.TabIndex = 120;
			this.textBox5.Text = "";
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
			this.mtgcComboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray;
			this.mtgcComboBox1.GridLineHorizontal = false;
			this.mtgcComboBox1.GridLineVertical = false;
			this.mtgcComboBox1.HighlightBorderColor = System.Drawing.Color.Blue;
			this.mtgcComboBox1.HighlightBorderOnMouseEvents = true;
			this.mtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
			this.mtgcComboBox1.Location = new System.Drawing.Point(16, 224);
			this.mtgcComboBox1.ManagingFastMouseMoving = true;
			this.mtgcComboBox1.ManagingFastMouseMovingInterval = 30;
			this.mtgcComboBox1.Name = "mtgcComboBox1";
			this.mtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black;
			this.mtgcComboBox1.Size = new System.Drawing.Size(72, 26);
			this.mtgcComboBox1.TabIndex = 119;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(560, 160);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(112, 25);
			this.dateTimePicker1.TabIndex = 118;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Black;
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Location = new System.Drawing.Point(0, 360);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(736, 3);
			this.panel8.TabIndex = 117;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Black;
			this.panel9.Location = new System.Drawing.Point(0, 48);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(736, 3);
			this.panel9.TabIndex = 7;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(672, 344);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(48, 16);
			this.label14.TabIndex = 116;
			this.label14.Text = "Délai";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(608, 344);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 16);
			this.label13.TabIndex = 115;
			this.label13.Text = "Prix";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(528, 344);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 16);
			this.label12.TabIndex = 114;
			this.label12.Text = "Quantité";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(160, 344);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 16);
			this.label11.TabIndex = 113;
			this.label11.Text = "Désignation";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 344);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 16);
			this.label10.TabIndex = 112;
			this.label10.Text = "Référence";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Location = new System.Drawing.Point(0, 336);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(736, 3);
			this.panel6.TabIndex = 111;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Black;
			this.panel7.Location = new System.Drawing.Point(0, 48);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(736, 3);
			this.panel7.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(160, 288);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(424, 29);
			this.textBox4.TabIndex = 102;
			this.textBox4.Text = "Demande de prix et délais";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(80, 288);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 110;
			this.label9.Text = "Objet : ";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(0, 272);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(736, 3);
			this.panel4.TabIndex = 109;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.Location = new System.Drawing.Point(0, 48);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(736, 3);
			this.panel5.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(496, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 108;
			this.label8.Text = "Date :";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(112, 224);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(320, 25);
			this.textBox3.TabIndex = 99;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(112, 192);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(320, 25);
			this.textBox2.TabIndex = 97;
			this.textBox2.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 107;
			this.label7.Text = "Société :";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(112, 160);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(320, 25);
			this.textBox1.TabIndex = 95;
			this.textBox1.Text = "Madame PERRET LEBATEUX";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 160);
			this.label6.Name = "label6";
			this.label6.TabIndex = 106;
			this.label6.Text = "Emetteur :";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(232, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(304, 23);
			this.label5.TabIndex = 105;
			this.label5.Text = "Tel : 04 78 21 73 14 - Fax : 04 78 21 73 01";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(0, 136);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(736, 3);
			this.panel2.TabIndex = 104;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Black;
			this.panel3.Location = new System.Drawing.Point(0, 48);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(736, 3);
			this.panel3.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(368, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 23);
			this.label4.TabIndex = 103;
			this.label4.Text = "St Priest";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(288, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 101;
			this.label3.Text = "69800";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(280, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 23);
			this.label2.TabIndex = 100;
			this.label2.Text = "1 rue Maurice Audibert";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(216, 50);
			this.pictureBox2.TabIndex = 98;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(624, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 112);
			this.pictureBox1.TabIndex = 96;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(272, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 23);
			this.label1.TabIndex = 94;
			this.label1.Text = "Opindus";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(110, 145);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// DemandePrix
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(770, 744);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DemandePrix";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DemandePrix";
			this.panel1.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			Dispose();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{

		}
	}
}
