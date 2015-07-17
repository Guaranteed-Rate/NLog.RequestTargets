namespace NLog.RequestTargerts.HttpContextItem
{
    using System.Text;
    using System.Web;
    using NLog;
    using Config;
    using LayoutRenderers;

    [LayoutRenderer("http-context-item")]
    public class HttpContextItemLayoutRenderer : LayoutRenderer
    {
        [RequiredParameter]
        public string ItemName { get; set; }

        public bool AddToProperties { get; set; }

        public string PropertyName { get; set; }

        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            if (HttpContext.Current == null || !HttpContext.Current.Items.Contains(ItemName))
                return;
            var itemValue = HttpContext.Current.Items[ItemName];
            builder.Append(itemValue);
            if (!AddToProperties)
                return;
            var propertyName = PropertyName ?? ItemName;
            logEvent.Properties[propertyName] = itemValue;
        }
    }
}