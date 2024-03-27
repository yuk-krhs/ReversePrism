using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoryTopContentType                      000186582AF0 ModelEnumType StoryTopContentType StoryTopContentType StoryTopContentType Int32
    // 014 IsNew                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 015 IsUnread                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class StoryTopTabViewModel
    {
        public StoryTopContentType                      StoryTopContentType                     { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public bool                                     IsUnread                                { get; set; }

        public static StoryTopTabViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryTopTabViewModel();

            value.StoryTopContentType                       = (StoryTopContentType)GetInt32(new IntPtr(p + 0x010)); // 0270D67FB238 0x10 StoryTopContentType         ( 000186582AF0 ModelEnumType StoryTopContentType StoryTopContentType StoryTopContentType Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x014)); // 0270D67FB258 0x14 IsNew                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsUnread                                  = GetBool(new IntPtr(p + 0x015)); // 0270D67FB278 0x15 IsUnread                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
