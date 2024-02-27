using System.Windows.Forms;

namespace SatelliteDataProcessingApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NumericUpDownSigma = new System.Windows.Forms.NumericUpDown();
			this.NumericUpDownMu = new System.Windows.Forms.NumericUpDown();
			this.ButtonLoad = new System.Windows.Forms.Button();
			this.ListViewOutput = new System.Windows.Forms.ListView();
			this.columnHeaderA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ListBoxA = new System.Windows.Forms.ListBox();
			this.ButtonSelectionSortA = new System.Windows.Forms.Button();
			this.ButtonInsertionSortA = new System.Windows.Forms.Button();
			this.TextBoxSelectionTimeA = new System.Windows.Forms.TextBox();
			this.TextBoxInsertionTimeA = new System.Windows.Forms.TextBox();
			this.TextBoxSearchA = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TextBoxRecursiveTimeA = new System.Windows.Forms.TextBox();
			this.ButtonRecursiveSearchA = new System.Windows.Forms.Button();
			this.TextBoxIterativeTimeA = new System.Windows.Forms.TextBox();
			this.ButtonIterativeSearchA = new System.Windows.Forms.Button();
			this.TextBoxRecursiveTimeB = new System.Windows.Forms.TextBox();
			this.ButtonRecursiveSearchB = new System.Windows.Forms.Button();
			this.TextBoxIterativeTimeB = new System.Windows.Forms.TextBox();
			this.ButtonIterativeSearchB = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.TextBoxSearchB = new System.Windows.Forms.TextBox();
			this.TextBoxInsertionTimeB = new System.Windows.Forms.TextBox();
			this.ButtonInsertionSortB = new System.Windows.Forms.Button();
			this.TextBoxSelectionTimeB = new System.Windows.Forms.TextBox();
			this.ButtonSelectionSortB = new System.Windows.Forms.Button();
			this.ListBoxB = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSigma)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMu)).BeginInit();
			this.SuspendLayout();
			// 
			// NumericUpDownSigma
			// 
			this.NumericUpDownSigma.Location = new System.Drawing.Point(20, 40);
			this.NumericUpDownSigma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.NumericUpDownSigma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NumericUpDownSigma.Name = "NumericUpDownSigma";
			this.NumericUpDownSigma.Size = new System.Drawing.Size(56, 22);
			this.NumericUpDownSigma.TabIndex = 0;
			this.NumericUpDownSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// NumericUpDownMu
			// 
			this.NumericUpDownMu.Location = new System.Drawing.Point(100, 40);
			this.NumericUpDownMu.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
			this.NumericUpDownMu.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
			this.NumericUpDownMu.Name = "NumericUpDownMu";
			this.NumericUpDownMu.Size = new System.Drawing.Size(52, 22);
			this.NumericUpDownMu.TabIndex = 1;
			this.NumericUpDownMu.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// ButtonLoad
			// 
			this.ButtonLoad.Location = new System.Drawing.Point(20, 80);
			this.ButtonLoad.Name = "ButtonLoad";
			this.ButtonLoad.Size = new System.Drawing.Size(190, 23);
			this.ButtonLoad.TabIndex = 2;
			this.ButtonLoad.Text = "Load Sensor Data";
			this.ButtonLoad.UseVisualStyleBackColor = true;
			this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
			// 
			// ListViewOutput
			// 
			this.ListViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderA,
            this.columnHeaderB});
			this.ListViewOutput.HideSelection = false;
			this.ListViewOutput.Location = new System.Drawing.Point(20, 110);
			this.ListViewOutput.Name = "ListViewOutput";
			this.ListViewOutput.Size = new System.Drawing.Size(190, 290);
			this.ListViewOutput.TabIndex = 3;
			this.ListViewOutput.UseCompatibleStateImageBehavior = false;
			this.ListViewOutput.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderA
			// 
			this.columnHeaderA.Text = "Sensor A";
			// 
			// columnHeaderB
			// 
			this.columnHeaderB.Text = "Sensor B";
			this.columnHeaderB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Sigma";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(100, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Mu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(398, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Sensor A";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(688, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Sensor B";
			// 
			// ListBoxA
			// 
			this.ListBoxA.FormattingEnabled = true;
			this.ListBoxA.ItemHeight = 16;
			this.ListBoxA.Location = new System.Drawing.Point(398, 60);
			this.ListBoxA.Name = "ListBoxA";
			this.ListBoxA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.ListBoxA.Size = new System.Drawing.Size(110, 340);
			this.ListBoxA.TabIndex = 8;
			// 
			// ButtonSelectionSortA
			// 
			this.ButtonSelectionSortA.Location = new System.Drawing.Point(256, 60);
			this.ButtonSelectionSortA.Name = "ButtonSelectionSortA";
			this.ButtonSelectionSortA.Size = new System.Drawing.Size(112, 23);
			this.ButtonSelectionSortA.TabIndex = 9;
			this.ButtonSelectionSortA.Text = "Selection Sort";
			this.ButtonSelectionSortA.UseVisualStyleBackColor = true;
			this.ButtonSelectionSortA.Click += new System.EventHandler(this.ButtonSelectionSortA_Click);
			// 
			// ButtonInsertionSortA
			// 
			this.ButtonInsertionSortA.Location = new System.Drawing.Point(258, 130);
			this.ButtonInsertionSortA.Name = "ButtonInsertionSortA";
			this.ButtonInsertionSortA.Size = new System.Drawing.Size(110, 23);
			this.ButtonInsertionSortA.TabIndex = 11;
			this.ButtonInsertionSortA.Text = "Insertion Sort";
			this.ButtonInsertionSortA.UseVisualStyleBackColor = true;
			this.ButtonInsertionSortA.Click += new System.EventHandler(this.ButtonInsertionSortA_Click);
			// 
			// TextBoxSelectionTimeA
			// 
			this.TextBoxSelectionTimeA.Location = new System.Drawing.Point(258, 90);
			this.TextBoxSelectionTimeA.Name = "TextBoxSelectionTimeA";
			this.TextBoxSelectionTimeA.ReadOnly = true;
			this.TextBoxSelectionTimeA.Size = new System.Drawing.Size(110, 22);
			this.TextBoxSelectionTimeA.TabIndex = 10;
			// 
			// TextBoxInsertionTimeA
			// 
			this.TextBoxInsertionTimeA.Location = new System.Drawing.Point(258, 160);
			this.TextBoxInsertionTimeA.Name = "TextBoxInsertionTimeA";
			this.TextBoxInsertionTimeA.ReadOnly = true;
			this.TextBoxInsertionTimeA.Size = new System.Drawing.Size(110, 22);
			this.TextBoxInsertionTimeA.TabIndex = 12;
			// 
			// TextBoxSearchA
			// 
			this.TextBoxSearchA.Location = new System.Drawing.Point(258, 230);
			this.TextBoxSearchA.Name = "TextBoxSearchA";
			this.TextBoxSearchA.Size = new System.Drawing.Size(110, 22);
			this.TextBoxSearchA.TabIndex = 13;
			this.TextBoxSearchA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchA_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(268, 210);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Binary Search";
			// 
			// TextBoxRecursiveTimeA
			// 
			this.TextBoxRecursiveTimeA.Location = new System.Drawing.Point(258, 370);
			this.TextBoxRecursiveTimeA.Name = "TextBoxRecursiveTimeA";
			this.TextBoxRecursiveTimeA.ReadOnly = true;
			this.TextBoxRecursiveTimeA.Size = new System.Drawing.Size(110, 22);
			this.TextBoxRecursiveTimeA.TabIndex = 18;
			// 
			// ButtonRecursiveSearchA
			// 
			this.ButtonRecursiveSearchA.Location = new System.Drawing.Point(258, 340);
			this.ButtonRecursiveSearchA.Name = "ButtonRecursiveSearchA";
			this.ButtonRecursiveSearchA.Size = new System.Drawing.Size(110, 23);
			this.ButtonRecursiveSearchA.TabIndex = 17;
			this.ButtonRecursiveSearchA.Text = "Recursive";
			this.ButtonRecursiveSearchA.UseVisualStyleBackColor = true;
			this.ButtonRecursiveSearchA.Click += new System.EventHandler(this.ButtonRecursiveSearchA_Click);
			// 
			// TextBoxIterativeTimeA
			// 
			this.TextBoxIterativeTimeA.Location = new System.Drawing.Point(258, 300);
			this.TextBoxIterativeTimeA.Name = "TextBoxIterativeTimeA";
			this.TextBoxIterativeTimeA.ReadOnly = true;
			this.TextBoxIterativeTimeA.Size = new System.Drawing.Size(110, 22);
			this.TextBoxIterativeTimeA.TabIndex = 16;
			// 
			// ButtonIterativeSearchA
			// 
			this.ButtonIterativeSearchA.Location = new System.Drawing.Point(258, 270);
			this.ButtonIterativeSearchA.Name = "ButtonIterativeSearchA";
			this.ButtonIterativeSearchA.Size = new System.Drawing.Size(110, 23);
			this.ButtonIterativeSearchA.TabIndex = 15;
			this.ButtonIterativeSearchA.Text = "Iterative";
			this.ButtonIterativeSearchA.UseVisualStyleBackColor = true;
			this.ButtonIterativeSearchA.Click += new System.EventHandler(this.ButtonIterativeSearchA_Click);
			// 
			// TextBoxRecursiveTimeB
			// 
			this.TextBoxRecursiveTimeB.Location = new System.Drawing.Point(548, 370);
			this.TextBoxRecursiveTimeB.Name = "TextBoxRecursiveTimeB";
			this.TextBoxRecursiveTimeB.ReadOnly = true;
			this.TextBoxRecursiveTimeB.Size = new System.Drawing.Size(110, 22);
			this.TextBoxRecursiveTimeB.TabIndex = 29;
			// 
			// ButtonRecursiveSearchB
			// 
			this.ButtonRecursiveSearchB.Location = new System.Drawing.Point(548, 340);
			this.ButtonRecursiveSearchB.Name = "ButtonRecursiveSearchB";
			this.ButtonRecursiveSearchB.Size = new System.Drawing.Size(110, 23);
			this.ButtonRecursiveSearchB.TabIndex = 28;
			this.ButtonRecursiveSearchB.Text = "Recursive";
			this.ButtonRecursiveSearchB.UseVisualStyleBackColor = true;
			this.ButtonRecursiveSearchB.Click += new System.EventHandler(this.ButtonRecursiveSearchB_Click);
			// 
			// TextBoxIterativeTimeB
			// 
			this.TextBoxIterativeTimeB.Location = new System.Drawing.Point(548, 300);
			this.TextBoxIterativeTimeB.Name = "TextBoxIterativeTimeB";
			this.TextBoxIterativeTimeB.ReadOnly = true;
			this.TextBoxIterativeTimeB.Size = new System.Drawing.Size(110, 22);
			this.TextBoxIterativeTimeB.TabIndex = 27;
			// 
			// ButtonIterativeSearchB
			// 
			this.ButtonIterativeSearchB.Location = new System.Drawing.Point(548, 270);
			this.ButtonIterativeSearchB.Name = "ButtonIterativeSearchB";
			this.ButtonIterativeSearchB.Size = new System.Drawing.Size(110, 23);
			this.ButtonIterativeSearchB.TabIndex = 26;
			this.ButtonIterativeSearchB.Text = "Iterative";
			this.ButtonIterativeSearchB.UseVisualStyleBackColor = true;
			this.ButtonIterativeSearchB.Click += new System.EventHandler(this.ButtonIterativeSearchB_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(558, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 16);
			this.label6.TabIndex = 25;
			this.label6.Text = "Binary Search";
			// 
			// TextBoxSearchB
			// 
			this.TextBoxSearchB.Location = new System.Drawing.Point(548, 230);
			this.TextBoxSearchB.Name = "TextBoxSearchB";
			this.TextBoxSearchB.Size = new System.Drawing.Size(110, 22);
			this.TextBoxSearchB.TabIndex = 24;
			// 
			// TextBoxInsertionTimeB
			// 
			this.TextBoxInsertionTimeB.Location = new System.Drawing.Point(550, 160);
			this.TextBoxInsertionTimeB.Name = "TextBoxInsertionTimeB";
			this.TextBoxInsertionTimeB.ReadOnly = true;
			this.TextBoxInsertionTimeB.Size = new System.Drawing.Size(110, 22);
			this.TextBoxInsertionTimeB.TabIndex = 23;
			// 
			// ButtonInsertionSortB
			// 
			this.ButtonInsertionSortB.Location = new System.Drawing.Point(550, 130);
			this.ButtonInsertionSortB.Name = "ButtonInsertionSortB";
			this.ButtonInsertionSortB.Size = new System.Drawing.Size(110, 23);
			this.ButtonInsertionSortB.TabIndex = 22;
			this.ButtonInsertionSortB.Text = "Insertion Sort";
			this.ButtonInsertionSortB.UseVisualStyleBackColor = true;
			this.ButtonInsertionSortB.Click += new System.EventHandler(this.ButtonInsertionSortB_Click);
			// 
			// TextBoxSelectionTimeB
			// 
			this.TextBoxSelectionTimeB.Location = new System.Drawing.Point(550, 90);
			this.TextBoxSelectionTimeB.Name = "TextBoxSelectionTimeB";
			this.TextBoxSelectionTimeB.ReadOnly = true;
			this.TextBoxSelectionTimeB.Size = new System.Drawing.Size(110, 22);
			this.TextBoxSelectionTimeB.TabIndex = 21;
			// 
			// ButtonSelectionSortB
			// 
			this.ButtonSelectionSortB.Location = new System.Drawing.Point(548, 60);
			this.ButtonSelectionSortB.Name = "ButtonSelectionSortB";
			this.ButtonSelectionSortB.Size = new System.Drawing.Size(112, 23);
			this.ButtonSelectionSortB.TabIndex = 20;
			this.ButtonSelectionSortB.Text = "Selection Sort";
			this.ButtonSelectionSortB.UseVisualStyleBackColor = true;
			this.ButtonSelectionSortB.Click += new System.EventHandler(this.ButtonSelectionSortB_Click);
			// 
			// ListBoxB
			// 
			this.ListBoxB.FormattingEnabled = true;
			this.ListBoxB.ItemHeight = 16;
			this.ListBoxB.Location = new System.Drawing.Point(690, 60);
			this.ListBoxB.Name = "ListBoxB";
			this.ListBoxB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.ListBoxB.Size = new System.Drawing.Size(108, 340);
			this.ListBoxB.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 421);
			this.Controls.Add(this.TextBoxRecursiveTimeB);
			this.Controls.Add(this.ButtonRecursiveSearchB);
			this.Controls.Add(this.TextBoxIterativeTimeB);
			this.Controls.Add(this.ButtonIterativeSearchB);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TextBoxSearchB);
			this.Controls.Add(this.TextBoxInsertionTimeB);
			this.Controls.Add(this.ButtonInsertionSortB);
			this.Controls.Add(this.TextBoxSelectionTimeB);
			this.Controls.Add(this.ButtonSelectionSortB);
			this.Controls.Add(this.ListBoxB);
			this.Controls.Add(this.TextBoxRecursiveTimeA);
			this.Controls.Add(this.ButtonRecursiveSearchA);
			this.Controls.Add(this.TextBoxIterativeTimeA);
			this.Controls.Add(this.ButtonIterativeSearchA);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TextBoxSearchA);
			this.Controls.Add(this.TextBoxInsertionTimeA);
			this.Controls.Add(this.ButtonInsertionSortA);
			this.Controls.Add(this.TextBoxSelectionTimeA);
			this.Controls.Add(this.ButtonSelectionSortA);
			this.Controls.Add(this.ListBoxA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ListViewOutput);
			this.Controls.Add(this.ButtonLoad);
			this.Controls.Add(this.NumericUpDownMu);
			this.Controls.Add(this.NumericUpDownSigma);
			this.Name = "Form1";
			this.Text = "Satellite Data Processing";
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSigma)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown NumericUpDownSigma;
		private System.Windows.Forms.NumericUpDown NumericUpDownMu;
		private System.Windows.Forms.Button ButtonLoad;
		private System.Windows.Forms.ListView ListViewOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox ListBoxA;
		private System.Windows.Forms.Button ButtonSelectionSortA;
		private System.Windows.Forms.Button ButtonInsertionSortA;
		private System.Windows.Forms.TextBox TextBoxSelectionTimeA;
		private System.Windows.Forms.TextBox TextBoxInsertionTimeA;
		private System.Windows.Forms.TextBox TextBoxSearchA;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TextBoxRecursiveTimeA;
		private System.Windows.Forms.Button ButtonRecursiveSearchA;
		private System.Windows.Forms.TextBox TextBoxIterativeTimeA;
		private System.Windows.Forms.Button ButtonIterativeSearchA;
		private System.Windows.Forms.TextBox TextBoxRecursiveTimeB;
		private System.Windows.Forms.Button ButtonRecursiveSearchB;
		private System.Windows.Forms.TextBox TextBoxIterativeTimeB;
		private System.Windows.Forms.Button ButtonIterativeSearchB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TextBoxSearchB;
		private System.Windows.Forms.TextBox TextBoxInsertionTimeB;
		private System.Windows.Forms.Button ButtonInsertionSortB;
		private System.Windows.Forms.TextBox TextBoxSelectionTimeB;
		private System.Windows.Forms.Button ButtonSelectionSortB;
		private System.Windows.Forms.ListBox ListBoxB;
		private System.Windows.Forms.ColumnHeader columnHeaderA;
		private System.Windows.Forms.ColumnHeader columnHeaderB;
	}
}

