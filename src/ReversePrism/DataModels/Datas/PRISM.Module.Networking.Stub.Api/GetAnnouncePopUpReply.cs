using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetAnnouncePopUpReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ArticleIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 ArticleId                                000186671910 ModelPrimitiveType string string string String
    public partial class GetAnnouncePopUpReply : DataModel
    {
        public string                                   ArticleId                               { get; set; }

        public static GetAnnouncePopUpReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetAnnouncePopUpReply() { Pointer= p0 };

            value.ArticleId                                 = GetString(new IntPtr(p + 0x018)); // 024660B29D30 0x18 ArticleId                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
