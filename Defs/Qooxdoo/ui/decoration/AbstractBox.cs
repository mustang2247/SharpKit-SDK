// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.decoration
{
    /// <summary>
	/// <para>Abstract base class for the HBox and VBox decorators.
	/// This decorator uses three images, which are positioned in a
	/// vertical/horizontal line. The first and last image always keep their
	/// original size. The center image is stretched.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.decoration.AbstractBox", OmitOptionalParameters = true, Export = false)]
    public partial class AbstractBox : qx.ui.decoration.Abstract, qx.ui.decoration.IDecorator
    {
		#region Properties

		/// <summary>
		/// <para>Base image URL. All the different images needed are named by the default
		/// naming scheme:</para>
		/// <para>${baseImageWithoutExtension}-${imageName}.${baseImageExtension}</para>
		/// <para>These image names are used:</para>
		/// <list type="bullet">
		/// <item>t: top side (vertical orientation)</item>
		/// <item>b: bottom side (vertical orientation)</item>
		/// </list>
		/// <list type="bullet">
		/// <item>l: left side (horizontal orientation)</item>
		/// <item>r: right side (horizontal orientation)</item>
		/// </list>
		/// <list type="bullet">
		/// <item>c: center image</item>
		/// </list>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "baseImage", NativeField = true)]
		public string BaseImage { get; set; }

		/// <summary>
		/// <para>Only used for the CSS3 implementation, see <see cref="qx.ui.decoration.css3.BorderImage.Fill"/> *</para>
		/// </summary>
		[JsProperty(Name = "fill", NativeField = true)]
		public object Fill { get; set; }

		/// <summary>
		/// <para>Width of the bottom slice</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sliceBottom", NativeField = true)]
		public double SliceBottom { get; set; }

		/// <summary>
		/// <para>Width of the left slice</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sliceLeft", NativeField = true)]
		public double SliceLeft { get; set; }

		/// <summary>
		/// <para>Width of the right slice</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sliceRight", NativeField = true)]
		public double SliceRight { get; set; }

		/// <summary>
		/// <para>Property group for slices</para>
		/// </summary>
		[JsProperty(Name = "slices", NativeField = true)]
		public object Slices { get; set; }

		/// <summary>
		/// <para>Width of the top slice</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sliceTop", NativeField = true)]
		public double SliceTop { get; set; }

		#endregion Properties

		#region Methods

		public AbstractBox() { throw new NotImplementedException(); }

		/// <param name="baseImage">Base image to use</param>
		/// <param name="insets">Insets for the grid</param>
		/// <param name="orientation">Vertical or horizontal orientation</param>
		public AbstractBox(string baseImage, object insets, string orientation) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property baseImage.</para>
		/// </summary>
		[JsMethod(Name = "getBaseImage")]
		public string GetBaseImage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property fill.</para>
		/// </summary>
		[JsMethod(Name = "getFill")]
		public object GetFill() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the amount of space, the decoration needs for its border on each
		/// side.</para>
		/// </summary>
		/// <returns>the desired insed a map with the keys top, right, bottom, left.</returns>
		[JsMethod(Name = "getInsets")]
		public object GetInsets() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the basic markup structure used for this decoration.
		/// This later updated on DOM to resize or tint the element.</para>
		/// </summary>
		/// <returns>Basic markup</returns>
		[JsMethod(Name = "getMarkup")]
		public string GetMarkup() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sliceBottom.</para>
		/// </summary>
		[JsMethod(Name = "getSliceBottom")]
		public double GetSliceBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sliceLeft.</para>
		/// </summary>
		[JsMethod(Name = "getSliceLeft")]
		public double GetSliceLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sliceRight.</para>
		/// </summary>
		[JsMethod(Name = "getSliceRight")]
		public double GetSliceRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sliceTop.</para>
		/// </summary>
		[JsMethod(Name = "getSliceTop")]
		public double GetSliceTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property baseImage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property baseImage.</param>
		[JsMethod(Name = "initBaseImage")]
		public void InitBaseImage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property fill
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property fill.</param>
		[JsMethod(Name = "initFill")]
		public void InitFill(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sliceBottom
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sliceBottom.</param>
		[JsMethod(Name = "initSliceBottom")]
		public void InitSliceBottom(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sliceLeft
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sliceLeft.</param>
		[JsMethod(Name = "initSliceLeft")]
		public void InitSliceLeft(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sliceRight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sliceRight.</param>
		[JsMethod(Name = "initSliceRight")]
		public void InitSliceRight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sliceTop
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sliceTop.</param>
		[JsMethod(Name = "initSliceTop")]
		public void InitSliceTop(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property baseImage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBaseImage")]
		public void ResetBaseImage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property fill.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFill")]
		public void ResetFill() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sliceBottom.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSliceBottom")]
		public void ResetSliceBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sliceLeft.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSliceLeft")]
		public void ResetSliceLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sliceRight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSliceRight")]
		public void ResetSliceRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property slices.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSlices")]
		public void ResetSlices() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sliceTop.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSliceTop")]
		public void ResetSliceTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resizes the element respecting the configured borders
		/// to the given width and height. Should automatically
		/// respect the box model of the client to correctly
		/// compute the dimensions.</para>
		/// </summary>
		/// <param name="element">The element to update</param>
		/// <param name="width">Width of the element</param>
		/// <param name="height">Height of the element</param>
		[JsMethod(Name = "resize")]
		public void Resize(qx.html.Element element, double width, double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property baseImage.</para>
		/// </summary>
		/// <param name="value">New value for property baseImage.</param>
		[JsMethod(Name = "setBaseImage")]
		public void SetBaseImage(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property fill.</para>
		/// </summary>
		/// <param name="value">New value for property fill.</param>
		[JsMethod(Name = "setFill")]
		public void SetFill(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sliceBottom.</para>
		/// </summary>
		/// <param name="value">New value for property sliceBottom.</param>
		[JsMethod(Name = "setSliceBottom")]
		public void SetSliceBottom(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sliceLeft.</para>
		/// </summary>
		/// <param name="value">New value for property sliceLeft.</param>
		[JsMethod(Name = "setSliceLeft")]
		public void SetSliceLeft(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sliceRight.</para>
		/// </summary>
		/// <param name="value">New value for property sliceRight.</param>
		[JsMethod(Name = "setSliceRight")]
		public void SetSliceRight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group slices.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="sliceTop">Sets the value of the property #sliceTop.</param>
		/// <param name="sliceRight">Sets the value of the property #sliceRight.</param>
		/// <param name="sliceBottom">Sets the value of the property #sliceBottom.</param>
		/// <param name="sliceLeft">Sets the value of the property #sliceLeft.</param>
		[JsMethod(Name = "setSlices")]
		public void SetSlices(object sliceTop, object sliceRight, object sliceBottom, object sliceLeft) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sliceTop.</para>
		/// </summary>
		/// <param name="value">New value for property sliceTop.</param>
		[JsMethod(Name = "setSliceTop")]
		public void SetSliceTop(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies the given background color to the element
		/// or fallback to the background color defined
		/// by the decoration itself.</para>
		/// </summary>
		/// <param name="element">The element to update</param>
		/// <param name="bgcolor">The color to apply or null</param>
		[JsMethod(Name = "tint")]
		public void Tint(qx.html.Element element, string bgcolor) { throw new NotImplementedException(); }

		#endregion Methods
    }
}