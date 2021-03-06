//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.flash
{
    #region Component
    /// <inheritdocs />
    /// <summary>
    /// <p>A simple Component for displaying an Adobe Flash SWF movie. The movie will be sized and can participate
    /// in layout like any other Component.</p>
    /// <p>This component requires the third-party SWFObject library version 2.2 or above. It is not included within
    /// the ExtJS distribution, so you will have to include it into your page manually in order to use this component.
    /// The SWFObject library can be downloaded from the <i>SWFObject project page</i>
    /// and then simply import it into the head of your HTML document:</p>
    /// <pre><code>&lt;script type="text/javascript" src="path/to/local/swfobject.js"&gt;&lt;/script&gt;
    /// </code></pre>
    /// <h2>Configuration</h2>
    /// <p>This component allows several options for configuring how the target Flash movie is embedded. The most
    /// important is the required <see cref="Ext.flash.ComponentConfig.url">url</see> which points to the location of the Flash movie to load. Other
    /// configurations include:</p>
    /// <ul>
    /// <li><see cref="Ext.flash.ComponentConfig.backgroundColor">backgroundColor</see></li>
    /// <li><see cref="Ext.flash.ComponentConfig.wmode">wmode</see></li>
    /// <li><see cref="Ext.flash.ComponentConfig.flashVars">flashVars</see></li>
    /// <li><see cref="Ext.flash.ComponentConfig.flashParams">flashParams</see></li>
    /// <li><see cref="Ext.flash.ComponentConfig.flashAttributes">flashAttributes</see></li>
    /// </ul>
    /// <h2>Example usage:</h2>
    /// <pre><code>var win = <see cref="Ext.ExtContext.widget">Ext.widget</see>('window', {
    /// title: "It's a tiger!",
    /// layout: 'fit',
    /// width: 300,
    /// height: 300,
    /// x: 20,
    /// y: 20,
    /// resizable: true,
    /// items: {
    /// xtype: 'flash',
    /// url: 'tiger.swf'
    /// }
    /// });
    /// win.show();
    /// </code></pre>
    /// <h2>Express Install</h2>
    /// <p>Adobe provides a tool called <i>Express Install</i>
    /// that offers users an easy way to upgrade their Flash player. If you wish to make use of this, you should set
    /// the static EXPRESS_INSTALL_URL property to the location of your Express Install SWF file:</p>
    /// <pre><code><see cref="Ext.flash.Component">Ext.flash.Component</see>.EXPRESS_INSTALL_URL = 'path/to/local/expressInstall.swf';
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Component : Ext.Component
    {
        /// <summary>
        /// The background color of the SWF movie.
        /// Defaults to: <c>&quot;#ffffff&quot;</c>
        /// </summary>
        public JsString backgroundColor;
        /// <summary>
        /// True to prompt the user to install flash if not installed. Note that this uses
        /// Ext.FlashComponent.EXPRESS_INSTALL_URL, which should be set to the local resource.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool expressInstall;
        /// <summary>
        /// A set of key value pairs to be passed to the flash object as attributes.
        /// </summary>
        public JsObject flashAttributes;
        /// <summary>
        /// A set of key value pairs to be passed to the flash object as parameters. Possible parameters can be found here:
        /// http://kb2.adobe.com/cps/127/tn_12701.html
        /// </summary>
        public JsObject flashParams;
        /// <summary>
        /// A set of key value pairs to be passed to the flash object as flash variables.
        /// </summary>
        public JsObject flashVars;
        /// <summary>
        /// Indicates the version the flash content was published for.
        /// Defaults to: <c>&quot;9.0.115&quot;</c>
        /// </summary>
        public JsString flashVersion;
        /// <summary>
        /// The height of the embedded SWF movie inside the component.
        /// Defaults to "100%" so that the movie matches the height of the component.
        /// Defaults to: <c>&quot;100%&quot;</c>
        /// </summary>
        public object swfHeight;
        /// <summary>
        /// The width of the embedded SWF movie inside the component.
        /// Defaults to "100%" so that the movie matches the width of the component.
        /// Defaults to: <c>&quot;100%&quot;</c>
        /// </summary>
        public object swfWidth;
        /// <summary>
        /// The URL of the SWF file to include.
        /// </summary>
        public JsString url;
        /// <summary>
        /// The wmode of the flash object. This can be used to control layering.
        /// Set to 'transparent' to ignore the backgroundColor and make the background of the Flash
        /// movie transparent.
        /// Defaults to: <c>&quot;opaque&quot;</c>
        /// </summary>
        public JsString wmode;
        /// <summary>
        /// A reference to the object or embed element into which the SWF file is loaded. Only
        /// populated after the component is rendered and the SWF has been successfully embedded.
        /// </summary>
        public Ext.dom.Element swf{get;set;}
        /// <summary>
        /// Retrieves the id of the SWF object/embed element.
        /// </summary>
        public void getSwfId(){}
        /// <summary>
        /// The callback method for handling an embedding success or failure by SWFObject
        /// </summary>
        /// <param name="e"><p>The event object passed by SWFObject - see http://code.google.com/p/swfobject/wiki/api</p>
        /// </param>
        private void swfCallback(object e){}
        /// <summary>
        /// The url for installing flash if it doesn't exist. This should be set to a local resource.
        /// See http://www.adobe.com/devnet/flashplayer/articles/express_install.html for details.
        /// </summary>
        public static JsString EXPRESS_INSTALL_URL{get;set;}
        public Component(Ext.flash.ComponentConfig config){}
        public Component(){}
        public Component(params object[] args){}
    }
    #endregion
    #region ComponentConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ComponentConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// The background color of the SWF movie.
        /// Defaults to: <c>&quot;#ffffff&quot;</c>
        /// </summary>
        public JsString backgroundColor;
        /// <summary>
        /// True to prompt the user to install flash if not installed. Note that this uses
        /// Ext.FlashComponent.EXPRESS_INSTALL_URL, which should be set to the local resource.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool expressInstall;
        /// <summary>
        /// A set of key value pairs to be passed to the flash object as attributes.
        /// </summary>
        public JsObject flashAttributes;
        /// <summary>
        /// A set of key value pairs to be passed to the flash object as parameters. Possible parameters can be found here:
        /// http://kb2.adobe.com/cps/127/tn_12701.html
        /// </summary>
        public JsObject flashParams;
        /// <summary>
        /// A set of key value pairs to be passed to the flash object as flash variables.
        /// </summary>
        public JsObject flashVars;
        /// <summary>
        /// Indicates the version the flash content was published for.
        /// Defaults to: <c>&quot;9.0.115&quot;</c>
        /// </summary>
        public JsString flashVersion;
        /// <summary>
        /// The height of the embedded SWF movie inside the component.
        /// Defaults to "100%" so that the movie matches the height of the component.
        /// Defaults to: <c>&quot;100%&quot;</c>
        /// </summary>
        public object swfHeight;
        /// <summary>
        /// The width of the embedded SWF movie inside the component.
        /// Defaults to "100%" so that the movie matches the width of the component.
        /// Defaults to: <c>&quot;100%&quot;</c>
        /// </summary>
        public object swfWidth;
        /// <summary>
        /// The URL of the SWF file to include.
        /// </summary>
        public JsString url;
        /// <summary>
        /// The wmode of the flash object. This can be used to control layering.
        /// Set to 'transparent' to ignore the backgroundColor and make the background of the Flash
        /// movie transparent.
        /// Defaults to: <c>&quot;opaque&quot;</c>
        /// </summary>
        public JsString wmode;
        public ComponentConfig(params object[] args){}
    }
    #endregion
    #region ComponentEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ComponentEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fired when the Flash movie embedding fails
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void failure(Ext.flash.Component @this, object eOpts){}
        /// <summary>
        /// Fired when the Flash movie has been successfully embedded
        /// </summary>
        /// <param name="this">
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void success(Ext.flash.Component @this, object eOpts){}
        public ComponentEvents(params object[] args){}
    }
    #endregion
}
