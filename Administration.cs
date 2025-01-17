using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Opindus
{
	/// <summary>
	/// Description résumée de Administration.
	/// </summary>
	public class Administration : System.Windows.Forms.Form
	{
		private Microsoft.CLRAdmin.DataGridComboBox dataGridComboBox1;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Administration()
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
			this.dataGridComboBox1 = new Microsoft.CLRAdmin.DataGridComboBox();
			this.SuspendLayout();
			// 
			// dataGridComboBox1
			// 
			this.dataGridComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dataGridComboBox1.Location = new System.Drawing.Point(16, 16);
			this.dataGridComboBox1.Name = "dataGridComboBox1";
			this.dataGridComboBox1.Size = new System.Drawing.Size(288, 21);
			this.dataGridComboBox1.TabIndex = 0;
			// 
			// Administration
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 266);
			this.Controls.Add(this.dataGridComboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Administration";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administration";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
