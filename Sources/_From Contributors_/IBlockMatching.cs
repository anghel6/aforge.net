// AForge Image Processing Library
// AForge.NET framework
//
// Copyright � Andrew Kirillov, 2005-2008
// andrew.kirillov@gmail.com
//
// Copyright � Joan Charmant, 2008
// joan.charmant@gmail.com
//
namespace AForge.Imaging
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;

    /// <summary>
    /// Block matching interface.
    /// </summary>
    /// 
    /// <remarks><para>The interface specifies set of methods, which should be implemented by different
    /// block matching algorithms.</para>
    /// 
    /// <para>Block matching algorithms work with two images - source and search image - and
    /// a set of reference points. For each provided reference point, the algorithm takes
    /// a block from source image (reference point is a coordinate of block's center) and finds
    /// the best match for it in search image providing its coordinate (search is done within
    /// search window of specified size). In other words, block matching algorithm tries to
    /// find new coordinates in search image of specified reference points in source image.
    /// </para>
    /// </remarks>
    /// 
    public interface IBlockMatching
    {
        /// <summary>
        /// Process images matching blocks between them.
        /// </summary>
        /// 
        /// <param name="sourceImage">Source image with reference points.</param>
        /// <param name="coordinates">Array of reference points to be matched.</param>
        /// <param name="searchImage">Image in which the reference points will be looked for.</param>
        /// <param name="relative"><b>True</b> if results should be given as relative displacement, <b>false</b> for absolute coordinates.</param>
        /// 
        /// <returns>Returns array of relative displacements or absolute coordinates. In the case if
        /// reference point was skipped and no matching was found for it, the returned array
        /// may have a corresponding point with both coordinate set to <see cref="int.MaxValue"/>.</returns>
        /// 
        Point[] ProcessImage( Bitmap sourceImage, Point[] coordinates, Bitmap searchImage, bool relative );

        /// <summary>
        /// Process images matching blocks between them.
        /// </summary>
        /// 
        /// <param name="sourceImageData">Source image with reference points.</param>
        /// <param name="coordinates">Array of reference points to be matched.</param>
        /// <param name="searchImageData">Image in which the reference points will be looked for.</param>
        /// <param name="relative"><b>True</b> if results should be given as relative displacement, <b>false</b> for absolute coordinates.</param>
        /// 
        /// <returns>Returns array of relative displacements or absolute coordinates. In the case if
        /// reference point was skipped and no matching was found for it, the returned array
        /// may have a corresponding point with both coordinate set to <see cref="int.MaxValue"/>.</returns>
        /// 
        Point[] ProcessImage( BitmapData sourceImageData, Point[] coordinates, BitmapData searchImageData, bool relative );
    }
}
