namespace HttpContextItem
{
    using System.Text;
    using System.Web;
    using NLog;
    using NLog.Config;
    using NLog.LayoutRenderers;

    [LayoutRenderer("http-context-item")]
    public class HttpContextItemLayoutRenderer : LayoutRenderer
    {
        [RequiredParameter]
        public string ItemName { get; set; }

        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            var itemValue = HttpContext.Current.Items[ItemName];
            builder.Append(itemValue);
        }
    }
}