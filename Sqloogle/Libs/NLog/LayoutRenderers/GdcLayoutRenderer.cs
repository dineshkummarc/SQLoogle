#region License
// /*
// See license included in this library folder.
// */
#endregion

using System.Text;
using Sqloogle.Libs.NLog.Config;

namespace Sqloogle.Libs.NLog.LayoutRenderers
{
    /// <summary>
    ///     Global Diagnostics Context item. Provided for compatibility with log4net.
    /// </summary>
    [LayoutRenderer("gdc")]
    public class GdcLayoutRenderer : LayoutRenderer
    {
        /// <summary>
        ///     Gets or sets the name of the item.
        /// </summary>
        /// <docgen category='Rendering Options' order='10' />
        [RequiredParameter]
        [DefaultParameter]
        public string Item { get; set; }

        /// <summary>
        ///     Renders the specified Global Diagnostics Context item and appends it to the specified <see cref="StringBuilder" />.
        /// </summary>
        /// <param name="builder">
        ///     The <see cref="StringBuilder" /> to append the rendered data to.
        /// </param>
        /// <param name="logEvent">Logging event.</param>
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            var msg = GlobalDiagnosticsContext.Get(Item);
            builder.Append(msg);
        }
    }
}