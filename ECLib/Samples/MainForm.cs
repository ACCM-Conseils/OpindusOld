using System;
using System.Drawing;
using System.Windows.Forms;
using ECLib.Math.Statistics;
using System.Collections;
using ZedGraph;

namespace Samples
{
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox choiceComboBox;
		private System.Windows.Forms.TextBox standardDeviationTextBox;
		private ZedGraph.ZedGraphControl graphControl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox meanTextBox;
		private static int NB_TRY=10000;
		IStatisticalLaw law;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			this.meanTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.graphControl = new ZedGraph.ZedGraphControl();
			this.standardDeviationTextBox = new System.Windows.Forms.TextBox();
			this.choiceComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// meanTextBox
			// 
			this.meanTextBox.Location = new System.Drawing.Point(240, 8);
			this.meanTextBox.Name = "meanTextBox";
			this.meanTextBox.TabIndex = 2;
			this.meanTextBox.Text = "0.5";
			this.meanTextBox.TextChanged += new System.EventHandler(this.MeanTextBoxTextChanged);
			// 
			// label1
			// 
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(136, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "Mean";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// graphControl
			// 
			this.graphControl.IsShowPointValues = false;
			this.graphControl.Location = new System.Drawing.Point(8, 32);
			this.graphControl.Name = "graphControl";
			this.graphControl.PointValueFormat = "G";
			this.graphControl.Size = new System.Drawing.Size(648, 456);
			this.graphControl.TabIndex = 0;
			// 
			// standardDeviationTextBox
			// 
			this.standardDeviationTextBox.Location = new System.Drawing.Point(472, 8);
			this.standardDeviationTextBox.Name = "standardDeviationTextBox";
			this.standardDeviationTextBox.TabIndex = 3;
			this.standardDeviationTextBox.Text = "0.5";
			this.standardDeviationTextBox.TextChanged += new System.EventHandler(this.StandardDeviationTextBoxTextChanged);
			// 
			// choiceComboBox
			// 
			this.choiceComboBox.Items.AddRange(new object[] {
						"Uniform",
						"Exponential",
						"Normal"});
			this.choiceComboBox.Location = new System.Drawing.Point(8, 8);
			this.choiceComboBox.Name = "choiceComboBox";
			this.choiceComboBox.Size = new System.Drawing.Size(121, 21);
			this.choiceComboBox.TabIndex = 1;
			this.choiceComboBox.Text = "Uniform";
			this.choiceComboBox.SelectedIndexChanged += new System.EventHandler(this.ChoiceComboBoxSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(368, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "StandardDeviation";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 494);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.standardDeviationTextBox);
			this.Controls.Add(this.meanTextBox);
			this.Controls.Add(this.choiceComboBox);
			this.Controls.Add(this.graphControl);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		#endregion
		void MainFormLoad(object sender, System.EventArgs e)
		{
			ChoiceComboBoxSelectedIndexChanged(sender,e);
			MeanTextBoxTextChanged(sender,e);
			StandardDeviationTextBoxTextChanged(sender,e);
		}
		
		void DisplayGraph(IStatisticalLaw law)
		{
			int i;
			Hashtable table = new Hashtable();	
			
			for(i=0 ; i<NB_TRY; i++)
			{
				double lawValue = law.NextDouble();
				double contentValue = ((int)(lawValue * 100))/100.0;
				if (table.ContainsKey(contentValue))
				{
					int current = (int)table[contentValue];
					table.Remove(contentValue);
					table.Add(contentValue,current+1);
				}
				else
				{
					table.Add(contentValue,1);
				}
			}
			
			double[] x = new double[table.Count];
			double[] y = new double[table.Count];
			IDictionaryEnumerator enumerator = table.GetEnumerator();

			double xMin = Double.MaxValue;
			double xMax = Double.MinValue;
			double yMin = Double.MaxValue;
			double yMax = Double.MinValue;
			
			i=0;
			while(enumerator.MoveNext())
			{
				x[i] = (double)enumerator.Key;
				y[i] = (double)((int)enumerator.Value);
			
				if (x[i] > xMax) xMax = x[i];
				if (x[i] < xMin) xMin = x[i];
				if (y[i] > yMax) yMax = y[i];
				if (y[i] < yMin) yMin = y[i];
				
				i++;
			}
			
			GraphPane pane = graphControl.GraphPane;
			
			pane.Title = "Sample";
			pane.XAxis.Min = xMin;
			pane.YAxis.Min = yMin;
			pane.XAxis.Max = xMax;
			pane.YAxis.Max = yMax;
			pane.XAxis.Step = (xMax - xMin) / 5;
			pane.XAxis.IsMinorTic = false;
			pane.XAxis.IsOppositeTic = false;
			pane.XAxis.NumDec = 2;
			pane.YAxis.Step = (yMax - yMin) / 5;
			pane.YAxis.IsMinorTic = false;
			pane.YAxis.IsOppositeTic = false;
			pane.YAxis.NumDec = 2;
			
			pane.CurveList.Clear();
			LineItem curve = pane.AddCurve("Repartition",x,y,System.Drawing.Color.Blue,SymbolType.Circle);
			                               
			curve.Line.IsVisible = false;
			graphControl.Invalidate();
		}
		
		void ChoiceComboBoxSelectedIndexChanged(object sender, System.EventArgs e)
		{
			law=null;
			
			switch(choiceComboBox.Text)
			{
				case "Uniform":
					law = new UniformLaw();
					break;
				case "Exponential":
					law = new ExponentialLaw(new UniformLaw(),1.0);
					break;
				case "Normal":
					law = new NormalLaw();
					break;
			}
			DisplayGraph(law);
		}
				
		void StandardDeviationTextBoxTextChanged(object sender, System.EventArgs e)
		{
			meanTextBox.Text = law.Mean.ToString();
			try
			{
				law.StandardDeviation = Double.Parse(standardDeviationTextBox.Text);
			}
			catch(Exception)
			{
				standardDeviationTextBox.Text = "1";
				law.StandardDeviation = 1;
			}
			DisplayGraph(law);
		}
		
		void MeanTextBoxTextChanged(object sender, System.EventArgs e)
		{
			standardDeviationTextBox.Text =  law.StandardDeviation.ToString();
			try
			{
				law.Mean = Double.Parse(meanTextBox.Text);
			}
			catch(Exception)
			{
				meanTextBox.Text = "1";
				law.Mean = 1;
			}
			DisplayGraph(law);
		}
		
	}
}
