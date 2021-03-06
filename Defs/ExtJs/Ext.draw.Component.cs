//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.draw
{
    #region Component
    /// <inheritdocs />
    /// <summary>
    /// <p>The Draw Component is a surface in which sprites can be rendered. The Draw Component
    /// manages and holds an <see cref="Ext.draw.Surface">Ext.draw.Surface</see> instance where
    /// <see cref="Ext.draw.Sprite">Sprites</see> can be appended.</p>
    /// <p>One way to create a draw component is:</p>
    /// <pre><code>var drawComponent = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.draw.Component">Ext.draw.Component</see>', {
    /// viewBox: false,
    /// items: [{
    /// type: 'circle',
    /// fill: '#79BB3F',
    /// radius: 100,
    /// x: 100,
    /// y: 100
    /// }]
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.window.Window">Ext.Window</see>', {
    /// width: 215,
    /// height: 235,
    /// layout: 'fit',
    /// items: [drawComponent]
    /// }).show();
    /// </code></pre>
    /// <p>In this case we created a draw component and added a <see cref="Ext.draw.Sprite">sprite</see> to it.
    /// The <see cref="Ext.draw.SpriteConfig.type">type</see> of the sprite is <c>circle</c> so if you run this code you'll see a yellow-ish
    /// circle in a Window. When setting <c>viewBox</c> to <c>false</c> we are responsible for setting the object's position and
    /// dimensions accordingly.</p>
    /// <p>You can also add sprites by using the surface's add method:</p>
    /// <pre><code>drawComponent.surface.add({
    /// type: 'circle',
    /// fill: '#79BB3F',
    /// radius: 100,
    /// x: 100,
    /// y: 100
    /// });
    /// </code></pre>
    /// <h2>Larger example</h2>
    /// <pre><code>var drawComponent = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.draw.Component">Ext.draw.Component</see>', {
    /// width: 800,
    /// height: 600,
    /// renderTo: document.body
    /// }), surface = drawComponent.surface;
    /// surface.add([{
    /// type: 'circle',
    /// radius: 10,
    /// fill: '#f00',
    /// x: 10,
    /// y: 10,
    /// group: 'circles'
    /// }, {
    /// type: 'circle',
    /// radius: 10,
    /// fill: '#0f0',
    /// x: 50,
    /// y: 50,
    /// group: 'circles'
    /// }, {
    /// type: 'circle',
    /// radius: 10,
    /// fill: '#00f',
    /// x: 100,
    /// y: 100,
    /// group: 'circles'
    /// }, {
    /// type: 'rect',
    /// width: 20,
    /// height: 20,
    /// fill: '#f00',
    /// x: 10,
    /// y: 10,
    /// group: 'rectangles'
    /// }, {
    /// type: 'rect',
    /// width: 20,
    /// height: 20,
    /// fill: '#0f0',
    /// x: 50,
    /// y: 50,
    /// group: 'rectangles'
    /// }, {
    /// type: 'rect',
    /// width: 20,
    /// height: 20,
    /// fill: '#00f',
    /// x: 100,
    /// y: 100,
    /// group: 'rectangles'
    /// }]);
    /// // Get references to my groups
    /// circles = surface.getGroup('circles');
    /// rectangles = surface.getGroup('rectangles');
    /// // Animate the circles down
    /// circles.animate({
    /// duration: 1000,
    /// to: {
    /// translate: {
    /// y: 200
    /// }
    /// }
    /// });
    /// // Animate the rectangles across
    /// rectangles.animate({
    /// duration: 1000,
    /// to: {
    /// translate: {
    /// x: 200
    /// }
    /// }
    /// });
    /// </code></pre>
    /// <p>For more information on Sprites, the core elements added to a draw component's surface,
    /// refer to the <see cref="Ext.draw.Sprite">Ext.draw.Sprite</see> documentation.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Component : Ext.Component
    {
        /// <summary>
        /// Turn on autoSize support which will set the bounding div's size to the natural size of the contents.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool autoSize;
        /// <summary>
        /// Defines the priority order for which Surface implementation to use. The first
        /// one supported by the current environment will be used.
        /// Defaults to: <c>[&quot;Svg&quot;, &quot;Vml&quot;]</c>
        /// </summary>
        public JsString enginePriority;
        /// <summary>
        /// (optional) Define a set of gradients that can be used as fill property in sprites.
        /// The gradients array is an array of objects with the following properties:
        /// <li><c>id</c> - string - The unique name of the gradient.</li>
        /// <li><c>angle</c> - number, optional - The angle of the gradient in degrees.</li>
        /// <li><c>stops</c> - object - An object with numbers as keys (from 0 to 100) and style objects as values</li>
        /// Example
        /// <code>gradients: [{
        /// id: 'gradientId',
        /// angle: 45,
        /// stops: {
        /// 0: {
        /// color: '#555'
        /// },
        /// 100: {
        /// color: '#ddd'
        /// }
        /// }
        /// }, {
        /// id: 'gradientId2',
        /// angle: 0,
        /// stops: {
        /// 0: {
        /// color: '#590'
        /// },
        /// 20: {
        /// color: '#599'
        /// },
        /// 100: {
        /// color: '#ddd'
        /// }
        /// }
        /// }]
        /// </code>
        /// Then the sprites can use <c>gradientId</c> and <c>gradientId2</c> by setting the fill attributes to those ids, for example:
        /// <code>sprite.setAttributes({
        /// fill: 'url(#gradientId)'
        /// }, true);
        /// </code>
        /// </summary>
        public JsObject gradients;
        /// <summary>
        /// Array of sprites or sprite config objects to add initially to the surface.
        /// </summary>
        public Ext.draw.Sprite items;
        /// <summary>
        /// Turn on view box support which will scale and position items in the draw component to fit to the component while
        /// maintaining aspect ratio. Note that this scaling can override other sizing settings on your items.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool viewBox;
        /// <summary>
        /// The Surface instance managed by this component.
        /// </summary>
        public Surface surface{get;set;}
        /// <summary>
        /// Create the Surface instance. Resolves the correct Surface implementation to
        /// instantiate based on the 'enginePriority' config. Once the Surface instance is
        /// created you can use the handle to that instance to add sprites. For example:
        /// <code>drawComponent.surface.add(sprite);
        /// </code>
        /// </summary>
        private void createSurface(){}
        /// <summary>
        /// Create the Surface on initial render
        /// Overrides: <see cref="Ext.util.Renderable.onRender">Ext.util.Renderable.onRender</see>
        /// </summary>
        private void onRender(){}
        public Component(Ext.draw.ComponentConfig config){}
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
        /// Turn on autoSize support which will set the bounding div's size to the natural size of the contents.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool autoSize;
        /// <summary>
        /// Defines the priority order for which Surface implementation to use. The first
        /// one supported by the current environment will be used.
        /// Defaults to: <c>[&quot;Svg&quot;, &quot;Vml&quot;]</c>
        /// </summary>
        public JsString enginePriority;
        /// <summary>
        /// (optional) Define a set of gradients that can be used as fill property in sprites.
        /// The gradients array is an array of objects with the following properties:
        /// <li><c>id</c> - string - The unique name of the gradient.</li>
        /// <li><c>angle</c> - number, optional - The angle of the gradient in degrees.</li>
        /// <li><c>stops</c> - object - An object with numbers as keys (from 0 to 100) and style objects as values</li>
        /// Example
        /// <code>gradients: [{
        /// id: 'gradientId',
        /// angle: 45,
        /// stops: {
        /// 0: {
        /// color: '#555'
        /// },
        /// 100: {
        /// color: '#ddd'
        /// }
        /// }
        /// }, {
        /// id: 'gradientId2',
        /// angle: 0,
        /// stops: {
        /// 0: {
        /// color: '#590'
        /// },
        /// 20: {
        /// color: '#599'
        /// },
        /// 100: {
        /// color: '#ddd'
        /// }
        /// }
        /// }]
        /// </code>
        /// Then the sprites can use <c>gradientId</c> and <c>gradientId2</c> by setting the fill attributes to those ids, for example:
        /// <code>sprite.setAttributes({
        /// fill: 'url(#gradientId)'
        /// }, true);
        /// </code>
        /// </summary>
        public JsObject gradients;
        /// <summary>
        /// Array of sprites or sprite config objects to add initially to the surface.
        /// </summary>
        public Ext.draw.Sprite items;
        /// <summary>
        /// Turn on view box support which will scale and position items in the draw component to fit to the component while
        /// maintaining aspect ratio. Note that this scaling can override other sizing settings on your items.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool viewBox;
        public ComponentConfig(params object[] args){}
    }
    #endregion
    #region ComponentEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ComponentEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Event forwarded from surface.
        /// Fires when a click is detected within the surface.
        /// </summary>
        /// <param name="e"><p>An object encapsulating the DOM event.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void click(EventObject e, object eOpts){}
        /// <summary>
        /// Event forwarded from surface.
        /// Fires when a dblclick is detected within the surface.
        /// </summary>
        /// <param name="e"><p>An object encapsulating the DOM event.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void dblclick(EventObject e, object eOpts){}
        /// <summary>
        /// Event forwarded from surface.
        /// Fires when a mousedown is detected within the surface.
        /// </summary>
        /// <param name="e"><p>An object encapsulating the DOM event.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void mousedown(EventObject e, object eOpts){}
        /// <summary>
        /// Event forwarded from surface.
        /// Fires when a mouseenter is detected within the surface.
        /// </summary>
        /// <param name="e"><p>An object encapsulating the DOM event.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void mouseenter(EventObject e, object eOpts){}
        /// <summary>
        /// Event forwarded from surface.
        /// Fires when a mouseleave is detected within the surface.
        /// </summary>
        /// <param name="e"><p>An object encapsulating the DOM event.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void mouseleave(EventObject e, object eOpts){}
        /// <summary>
        /// Event forwarded from surface.
        /// Fires when a mousemove is detected within the surface.
        /// </summary>
        /// <param name="e"><p>An object encapsulating the DOM event.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void mousemove(EventObject e, object eOpts){}
        /// <summary>
        /// Event forwarded from surface.
        /// Fires when a mouseup is detected within the surface.
        /// </summary>
        /// <param name="e"><p>An object encapsulating the DOM event.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void mouseup(EventObject e, object eOpts){}
        public ComponentEvents(params object[] args){}
    }
    #endregion
}
