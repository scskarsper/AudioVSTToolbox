﻿// Sound Fingerprinting framework
// https://code.google.com/p/soundfingerprinting/
// Code license: GNU General Public License v2
// ciumac.sergiu@gmail.com
using System;

namespace Wave2ZebraSynth.Fingerprinting
{
    /// <summary>
    ///   Random stride object. [min - max Samples stride]
    /// </summary>
    [Serializable]
    
    public class RandomStride : IStride
    {
        private static readonly Random Random = new Random(unchecked((int) DateTime.Now.Ticks));
        private readonly int _firstStride;

        /// <summary>
        ///   Max stride
        /// </summary>
        private readonly int _maxStride;

        /// <summary>
        ///   Min stride
        /// </summary>
        private readonly int _minStride;

        /// <summary>
        ///   Constructor for a random stride object
        /// </summary>
        /// <param name = "minStrideSize">Minimum stride size, generated by this object</param>
        /// <param name = "maxStrideSize">Maximum stride size, generated by this object</param>
        public RandomStride(int minStrideSize, int maxStrideSize)
        {
            if (minStrideSize < 0 || maxStrideSize < 0 || minStrideSize > maxStrideSize)
                throw new ArgumentException("Bad arguments. Please review the documentation");
            _minStride = minStrideSize;
            _maxStride = maxStrideSize;
            _firstStride = 0;
        }

        /// <summary>
        ///   Min stride size
        /// </summary>
        public int Min
        {
            get { return _minStride; }
        }

        /// <summary>
        ///   Max stride size
        /// </summary>
        public int Max
        {
            get { return _maxStride; }
        }

        #region IStride Members

        /// <summary>
        ///   Get's stride size in terms of number of samples, which are needed to be skipped
        /// </summary>
        /// <returns>Bit samples to skip, between 2 consecutive overlapping fingerprints</returns>
        public int GetStride()
        {
            return Random.Next(_minStride, _maxStride);
        }

        public int GetFirstStride()
        {
            return _firstStride;
        }

        #endregion
    }
}