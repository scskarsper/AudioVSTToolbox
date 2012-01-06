﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using CommonUtils.FFT;

namespace ProcessVSTPlugin
{
	/// <summary>
	/// Description of FrequencyAnalyserUserControl.
	/// </summary>
	public partial class FrequencyAnalyserUserControl : UserControl
	{
		Bitmap bmp;
		
		double sampleRate = 44100;
		int fftWindowsSize = 2048;
		float MIN_FREQ = 0;
		float MAX_FREQ = 20000;
		
		// overlap must be an integer smaller than the window size
		// half the windows size is quite normal, sometimes 80% is best?!
		int fftOverlap = 1;

		public FrequencyAnalyserUserControl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
			              ControlStyles.OptimizedDoubleBuffer, true);
			InitializeComponent();
		}

		public float MinimumFrequency
		{
			get { return MIN_FREQ; }
			set { MIN_FREQ = value; }
		}

		public float MaximumFrequency
		{
			get { return MAX_FREQ; }
			set { MAX_FREQ = value; }
		}
		
		public double SampleRate
		{
			get { return sampleRate; }
			set { sampleRate = value; }
		}
		
		public int FFTWindowsSize
		{
			get { return fftWindowsSize; }
			set { fftWindowsSize = value; }
		}

		public int FFTOverlap
		{
			get { return fftOverlap; }
			set { fftOverlap = value; }
		}
		
		/// <summary>
		/// <see cref="Control.OnPaint"/>
		/// </summary>
		protected override void OnPaint(PaintEventArgs pe)
		{
			if (bmp != null) {
				pe.Graphics.DrawImage(bmp, 0, 0);
			}

			// Calling the base class OnPaint
			base.OnPaint(pe);
		}
		
		private float[] audioData;

		/// <summary>
		/// sets graph data
		/// </summary>
		public void SetAudioData(float[] audioData)
		{
			this.audioData = audioData;
			float[][] spectrogramData = AudioAnalyzer.CreateSpectrogramLomont(audioData, sampleRate, fftWindowsSize, fftOverlap, true);
			bmp = AudioAnalyzer.PrepareAndDrawSpectrumAnalysis(spectrogramData, sampleRate, fftWindowsSize, fftOverlap, new Size(this.Width, this.Height), MIN_FREQ, MAX_FREQ);
			
			// force redraw
			this.Invalidate();
		}
	}
}
