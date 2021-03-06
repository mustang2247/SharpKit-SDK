// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx
{
    /// <summary>
	/// <para>This class is used to define interfaces (similar to Java interfaces).</para>
	/// <para>See the description of the <see cref="Define"/> method how an interface is
	/// defined.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.Interface", OmitOptionalParameters = true, Export = false)]
    public partial class Interface 
    {
		#region Methods

		public Interface() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks if an interface is implemented by a class</para>
		/// </summary>
		/// <param name="clazz">class to check interface for</param>
		/// <param name="iface">the interface to verify</param>
		/// <param name="wrap">wrap functions required by interface to check parameters etc.</param>
		[JsMethod(Name = "assert")]
		public static void Assert(Class clazz, Interface iface, bool wrap = false) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Asserts that the given object implements all the methods defined in the
		/// interface. This method throws an exception if the object does not
		/// implement the interface.</para>
		/// </summary>
		/// <param name="objectx">Object to check interface for</param>
		/// <param name="iface">The interface to verify</param>
		[JsMethod(Name = "assertObject")]
		public static void AssertObject(qx.core.Object objectx, Interface iface) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Define a new interface. Interface definitions look much like class definitions.</para>
		/// <para>The main difference is that the bodies of functions defined in members
		/// and statics are called before the original function with the
		/// same arguments. This can be used to check the passed arguments. If the
		/// checks fail, an exception should be thrown. It is convenient to use the
		/// method defined in <see cref="qx.core.MAssert"/> to check the arguments.</para>
		/// <para>In the build version the checks are omitted.</para>
		/// <para>For properties only the names are required so the value of the properties
		/// can be empty maps.</para>
		/// <para>Example:</para>
		/// <code>
		/// qx.Interface.define("name",
		/// {
		/// extend: [SuperInterfaces],
		/// statics:
		/// {
		/// PI : 3.14
		/// },
		/// properties: {"color": {}, "name": {} },
		/// members:
		/// {
		/// meth1: function() {},
		/// meth2: function(a, b) { this.assertArgumentsCount(arguments, 2, 2); },
		/// meth3: function(c) { this.assertInterface(c.constructor, qx.some.Interface); }
		/// },
		/// events :
		/// {
		/// keydown : "qx.event.type.KeySequence"
		/// }
		/// });
		/// </code>
		/// </summary>
		/// <param name="name">name of the interface</param>
		/// <param name="config">Interface definition structure. The configuration map has the following keys:  NameTypeDescription extendInterface | Interface[]Single interface or array of interfaces this interface inherits from. membersMapMap of members of the interface. staticsMap Map of statics of the interface. The statics will not get copied into the target class. This is the same behaviour as statics in mixins (qx.Mixin#define).  propertiesMapMap of properties and their definitions. eventsMapMap of event names and the corresponding event class name. </param>
		/// <returns>The configured interface</returns>
		[JsMethod(Name = "define")]
		public static qx.Interface Define(string name, object config = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Generates a list of all interfaces including their super interfaces
		/// (resolved recursively)</para>
		/// </summary>
		/// <param name="ifaces">List of interfaces to be resolved</param>
		/// <returns>List of all interfaces</returns>
		[JsMethod(Name = "flatten")]
		public static JsArray Flatten(Interface ifaces = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an interface by name</para>
		/// </summary>
		/// <param name="name">class name to resolve</param>
		/// <returns>the class</returns>
		[JsMethod(Name = "getByName")]
		public static Class GetByName(string name) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Determine the number of interfaces which are defined</para>
		/// </summary>
		/// <returns>the number of interfaces</returns>
		[JsMethod(Name = "getTotalNumber")]
		public static double GetTotalNumber() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Determine if interface exists</para>
		/// </summary>
		/// <param name="name">Interface name to check</param>
		/// <returns>true if interface exists</returns>
		[JsMethod(Name = "isDefined")]
		public static bool IsDefined(string name) { throw new NotImplementedException(); }

		#endregion Methods
    }
}