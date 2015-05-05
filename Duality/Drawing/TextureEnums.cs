﻿using System;
using System.Collections.Generic;
using System.Linq;

using Duality.Editor;
using Duality.Resources;

namespace Duality.Drawing
{
	/// <summary>
	/// Defines how a Texture should handle pixel data without power-of-two dimensions.
	/// </summary>
	public enum TextureSizeMode
	{
		/// <summary>
		/// Enlarges the images dimensions without scaling the image, leaving
		/// the new space empty. Texture coordinates are automatically adjusted in
		/// order to display the image correctly. This preserves the images full
		/// quality but prevents tiling, if not power-of-two anyway.
		/// </summary>
		Enlarge,
		/// <summary>
		/// Stretches the image to fit power-of-two dimensions and downscales it
		/// again when displaying. This might blur the image slightly but allows
		/// tiling it.
		/// </summary>
		Stretch,
		/// <summary>
		/// The images dimensions are not affected, as OpenGL uses an actual 
		/// non-power-of-two texture. However, this might be unsupported on older hardware.
		/// </summary>
		NonPowerOfTwo,

		/// <summary>
		/// The default behaviour. Equals <see cref="Enlarge"/>.
		/// </summary>
		Default = Enlarge
	}

	/// <summary>
	/// Defines which filtering algorithm will be used when displaying the Texture larger than it is.
	/// </summary>
	public enum TextureMagFilter
	{
		/// <summary>
		/// Point filtering with sharp edges.
		/// </summary>
		Nearest,
		/// <summary>
		/// Linear interpolation.
		/// </summary>
		Linear
	}

	/// <summary>
	/// Defines which filtering algorithm will be used when displaying the Texture smaller than it is.
	/// </summary>
	public enum TextureMinFilter
	{
		/// <summary>
		/// Point filtering with sharp edges.
		/// </summary>
		Nearest,
		/// <summary>
		/// Linear interpolation.
		/// </summary>
		Linear,
		/// <summary>
		/// Point filtering with sharp edges. Mipmaps will be used, but switch from one to the next instantly.
		/// </summary>
		NearestMipmapNearest,
		/// <summary>
		/// Linear interpolation. Mipmaps will be used, but switch from one to the next instantly.
		/// </summary>
		LinearMipmapNearest,
		/// <summary>
		/// Point filtering with sharp edges. Mipmaps will be used and smoothly blend over from one to the next.
		/// </summary>
		NearestMipmapLinear,
		/// <summary>
		/// Linear interpolation. Mipmaps will be used and smoothly blend over from one to the next.
		/// </summary>
		LinearMipmapLinear,
	}

	/// <summary>
	/// Defines how Texture coordinates outside the regular [0 - 1] range will be handled.
	/// </summary>
	public enum TextureWrapMode
	{
		Clamp,
		Repeat,
		MirroredRepeat,
	}

	/// <summary>
	/// Defines the format that is used to store the Textures pixel data.
	/// </summary>
	public enum TexturePixelFormat
	{
		Single,
		Dual,
		Rgb,
		Rgba,

		FloatSingle,
		FloatDual,
		FloatRgb,
		FloatRgba,

		CompressedSingle,
		CompressedDual,
		CompressedRgb,
		CompressedRgba
	}
}
