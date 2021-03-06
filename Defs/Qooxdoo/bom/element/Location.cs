// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.element
{
    /// <summary>
	/// <para>Query the location of an arbitrary DOM element in relation to its top
	/// level body element. Works in all major browsers:</para>
	/// <list type="bullet">
	/// <item>Mozilla 1.5 + 2.0</item>
	/// <item>Internet Explorer 6.0 + 7.0 (both standard &amp; quirks mode)</item>
	/// <item>Opera 9.2</item>
	/// <item>Safari 3.0 beta</item>
	/// </list>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.element.Location", OmitOptionalParameters = true, Export = false)]
    public partial class Location 
    {
		#region Methods

		public Location() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the location of the given element in context of
		/// the document dimensions.</para>
		/// <para>Supported modes:</para>
		/// <list type="bullet">
		/// <item>margin: Calculate from the margin box of the element (bigger than the visual appearance: including margins of given element)</item>
		/// <item>box: Calculates the offset box of the element (default, uses the same size as visible)</item>
		/// <item>border: Calculate the border box (useful to align to border edges of two elements).</item>
		/// <item>scroll: Calculate the scroll box (relevant for absolute positioned content).</item>
		/// <item>padding: Calculate the padding box (relevant for static/relative positioned content).</item>
		/// </list>
		/// </summary>
		/// <param name="elem">DOM element to query</param>
		/// <param name="mode">A supported option. See comment above.</param>
		/// <returns>Returns a map with left, top, right and bottom which contains the distance of the element relative to the document.</returns>
		[JsMethod(Name = "get")]
		public static object Get(qx.html.Element elem, string mode = "box") { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the location of the given element in context of
		/// the document dimensions. For supported modes please
		/// have a look at the <see cref="qx.bom.element.Location.Get"/> method.</para>
		/// </summary>
		/// <param name="elem">DOM element to query</param>
		/// <param name="mode">A supported option. See comment above.</param>
		/// <returns>The bottom distance of the element relative to the document.</returns>
		[JsMethod(Name = "getBottom")]
		public static double GetBottom(qx.html.Element elem, string mode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the location of the given element in context of
		/// the document dimensions. For supported modes please
		/// have a look at the <see cref="qx.bom.element.Location.Get"/> method.</para>
		/// </summary>
		/// <param name="elem">DOM element to query</param>
		/// <param name="mode">A supported option. See comment above.</param>
		/// <returns>The left distance of the element relative to the document.</returns>
		[JsMethod(Name = "getLeft")]
		public static double GetLeft(qx.html.Element elem, string mode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Detects the offset parent of the given element</para>
		/// </summary>
		/// <param name="element">Element to query for offset parent</param>
		/// <returns>Detected offset parent</returns>
		[JsMethod(Name = "getOffsetParent")]
		public static qx.html.Element GetOffsetParent(qx.html.Element element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the distance between the given element to its offset parent.</para>
		/// </summary>
		/// <param name="elem">DOM element to query</param>
		/// <returns>Returns a map with left and top which contains the distance of the elements from each other.</returns>
		[JsMethod(Name = "getPosition")]
		public static object GetPosition(qx.html.Element elem) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the distance between two DOM elements. For supported modes please
		/// have a look at the <see cref="qx.bom.element.Location.Get"/> method.</para>
		/// </summary>
		/// <param name="elem1">First element</param>
		/// <param name="elem2">Second element</param>
		/// <param name="mode1">Mode for first element</param>
		/// <param name="mode2">Mode for second element</param>
		/// <returns>Returns a map with left and top which contains the distance of the elements from each other.</returns>
		[JsMethod(Name = "getRelative")]
		public static object GetRelative(qx.html.Element elem1, qx.html.Element elem2, string mode1 = null, string mode2 = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the location of the given element in context of
		/// the document dimensions. For supported modes please
		/// have a look at the <see cref="qx.bom.element.Location.Get"/> method.</para>
		/// </summary>
		/// <param name="elem">DOM element to query</param>
		/// <param name="mode">A supported option. See comment above.</param>
		/// <returns>The right distance of the element relative to the document.</returns>
		[JsMethod(Name = "getRight")]
		public static double GetRight(qx.html.Element elem, string mode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the location of the given element in context of
		/// the document dimensions. For supported modes please
		/// have a look at the <see cref="qx.bom.element.Location.Get"/> method.</para>
		/// </summary>
		/// <param name="elem">DOM element to query</param>
		/// <param name="mode">A supported option. See comment above.</param>
		/// <returns>The top distance of the element relative to the document.</returns>
		[JsMethod(Name = "getTop")]
		public static double GetTop(qx.html.Element elem, string mode) { throw new NotImplementedException(); }

		#endregion Methods
    }
}