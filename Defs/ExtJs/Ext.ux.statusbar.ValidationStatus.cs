//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux.statusbar
{
    #region ValidationStatus
    /// <inheritdocs />
    /// <summary>
    /// <p>A <see cref="Ext.ux.statusbar.StatusBar">Ext.ux.statusbar.StatusBar</see> plugin that provides automatic error
    /// notification when the associated form contains validation errors.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ValidationStatus : Ext.Component
    {
        /// <summary>
        /// The iconCls value to be applied
        /// to the status message when there is a validation error.
        /// Defaults to: <c>&quot;x-status-error&quot;</c>
        /// </summary>
        public JsString errorIconCls;
        /// <summary>
        /// The css class to be used for the error list when there are validation errors.
        /// Defaults to: <c>&quot;x-status-error-list&quot;</c>
        /// </summary>
        public JsString errorListCls;
        /// <summary>
        /// The text value to display when
        /// the error list is displayed.
        /// Defaults to: <c>&quot;Click again to hide the error list&quot;</c>
        /// </summary>
        public JsString hideText;
        /// <summary>
        /// The text value to be applied when
        /// there is a form validation error.
        /// Defaults to: <c>&quot;The form has errors (click for details...)&quot;</c>
        /// </summary>
        public JsString showText;
        /// <summary>
        /// The text value to be applied when
        /// the form is being submitted.
        /// Defaults to: <c>&quot;Saving...&quot;</c>
        /// </summary>
        public JsString submitText;
        /// <summary>
        /// The iconCls value to be applied
        /// to the status message when the form validates.
        /// Defaults to: <c>&quot;x-status-valid&quot;</c>
        /// </summary>
        public JsString validIconCls;
        public ValidationStatus(ValidationStatusConfig config){}
        public ValidationStatus(){}
        public ValidationStatus(params object[] args){}
    }
    #endregion
    #region ValidationStatusConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ValidationStatusConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// The iconCls value to be applied
        /// to the status message when there is a validation error.
        /// Defaults to: <c>&quot;x-status-error&quot;</c>
        /// </summary>
        public JsString errorIconCls;
        /// <summary>
        /// The css class to be used for the error list when there are validation errors.
        /// Defaults to: <c>&quot;x-status-error-list&quot;</c>
        /// </summary>
        public JsString errorListCls;
        /// <summary>
        /// The text value to display when
        /// the error list is displayed.
        /// Defaults to: <c>&quot;Click again to hide the error list&quot;</c>
        /// </summary>
        public JsString hideText;
        /// <summary>
        /// The text value to be applied when
        /// there is a form validation error.
        /// Defaults to: <c>&quot;The form has errors (click for details...)&quot;</c>
        /// </summary>
        public JsString showText;
        /// <summary>
        /// The text value to be applied when
        /// the form is being submitted.
        /// Defaults to: <c>&quot;Saving...&quot;</c>
        /// </summary>
        public JsString submitText;
        /// <summary>
        /// The iconCls value to be applied
        /// to the status message when the form validates.
        /// Defaults to: <c>&quot;x-status-valid&quot;</c>
        /// </summary>
        public JsString validIconCls;
        public ValidationStatusConfig(params object[] args){}
    }
    #endregion
    #region ValidationStatusEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ValidationStatusEvents : Ext.ComponentEvents
    {
        public ValidationStatusEvents(params object[] args){}
    }
    #endregion
}
