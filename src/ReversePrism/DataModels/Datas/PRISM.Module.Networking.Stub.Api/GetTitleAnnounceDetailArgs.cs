using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTitleAnnounceDetailArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PlatformFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Platform                                 ModelPrimitiveType string string string String
    // 000 ArticleIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 ArticleId                                ModelPrimitiveType string string string String
    public partial class GetTitleAnnounceDetailArgs : DataModel
    {
        public string                                   Platform                                { get; set; }
        public string                                   ArticleId                               { get; set; }

        public static GetTitleAnnounceDetailArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTitleAnnounceDetailArgs() { Pointer= p0 };

            value.Platform                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Platform                    ( ModelPrimitiveType string string string String )
            value.ArticleId                                 = GetString(new IntPtr(p + 0x020)); // 0x20 ArticleId                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
