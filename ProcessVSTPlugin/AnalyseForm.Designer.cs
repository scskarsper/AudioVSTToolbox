﻿/*
 * Created by SharpDevelop.
 * User: perivar.nerseth
 * Date: 02.01.2012
 * Time: 00:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProcessVSTPlugin
{
	partial class AnalyseForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.frequencyAnalyserUserControl1 = new ProcessVSTPlugin.FrequencyAnalyserUserControl();
			this.OnOffCheckbox = new System.Windows.Forms.CheckBox();
			this.WindowsSizeComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// frequencyAnalyserUserControl1
			// 
			this.frequencyAnalyserUserControl1.FFTOverlap = 1;
			this.frequencyAnalyserUserControl1.FFTWindowsSize = 256;
			this.frequencyAnalyserUserControl1.Location = new System.Drawing.Point(0, 1);
			this.frequencyAnalyserUserControl1.Name = "frequencyAnalyserUserControl1";
			this.frequencyAnalyserUserControl1.SampleRate = 44100D;
			this.frequencyAnalyserUserControl1.Size = new System.Drawing.Size(665, 354);
			this.frequencyAnalyserUserControl1.TabIndex = 0;
			// 
			// OnOffCheckbox
			// 
			this.OnOffCheckbox.Checked = true;
			this.OnOffCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.OnOffCheckbox.Location = new System.Drawing.Point(671, 3);
			this.OnOffCheckbox.Name = "OnOffCheckbox";
			this.OnOffCheckbox.Size = new System.Drawing.Size(66, 24);
			this.OnOffCheckbox.TabIndex = 1;
			this.OnOffCheckbox.Text = "Turn On";
			this.OnOffCheckbox.UseVisualStyleBackColor = true;
			this.OnOffCheckbox.CheckedChanged += new System.EventHandler(this.OnOffCheckboxCheckedChanged);
			// 
			// WindowsSizeComboBox
			// 
			this.WindowsSizeComboBox.FormattingEnabled = true;
			this.WindowsSizeComboBox.Items.AddRange(new object[] {
			                                        	"512",
			                                        	"1024",
			                                        	"2048",
			                                        	"4096"});
			this.WindowsSizeComboBox.Location = new System.Drawing.Point(671, 61);
			this.WindowsSizeComboBox.Name = "WindowsSizeComboBox";
			this.WindowsSizeComboBox.Size = new System.Drawing.Size(66, 21);
			this.WindowsSizeComboBox.TabIndex = 2;
			this.WindowsSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(671, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Window Size";
			// 
			// AnalyseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 355);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.WindowsSizeComboBox);
			this.Controls.Add(this.OnOffCheckbox);
			this.Controls.Add(this.frequencyAnalyserUserControl1);
			this.Name = "AnalyseForm";
			this.Text = "AnalyseForm";
			this.ResumeLayout(false);
		}
		private ProcessVSTPlugin.FrequencyAnalyserUserControl frequencyAnalyserUserControl1;
		private System.Windows.Forms.CheckBox OnOffCheckbox;
		private System.Windows.Forms.ComboBox WindowsSizeComboBox;
		private System.Windows.Forms.Label label1;
	}
}