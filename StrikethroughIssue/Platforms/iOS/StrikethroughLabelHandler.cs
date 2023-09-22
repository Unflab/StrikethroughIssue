using Foundation;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrikethroughIssue.Handlers
{
    public partial class StrikethroughLabelHandler : LabelHandler
    {
        public StrikethroughLabelHandler() : base(Mapper()) { }

        private static new IPropertyMapper<ILabel, ILabelHandler> Mapper()
        {
            var mapper = new PropertyMapper<ILabel, ILabelHandler>(LabelHandler.Mapper);
            mapper.ModifyMapping(nameof(ILabel.Text), (h, v, a) => MapText(h, v));
            return mapper;
        }

        public static new void MapText(ILabelHandler handler, ILabel label)
        {
            if (handler.PlatformView != null && label.Text != null)
                handler.PlatformView.AttributedText = new NSMutableAttributedString(label.Text);
            MapFormatting(handler, label);
        }
    }
}
