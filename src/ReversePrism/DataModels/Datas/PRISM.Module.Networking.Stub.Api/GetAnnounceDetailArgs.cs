using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetAnnounceDetailArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ArticleIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 ArticleId                                ModelPrimitiveType string string string String
    public partial class GetAnnounceDetailArgs : DataModel
    {
        public string                                   ArticleId                               { get; set; }

        public static GetAnnounceDetailArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetAnnounceDetailArgs() { Pointer= p0 };

            value.ArticleId                                 = GetString(new IntPtr(p + 0x018)); // 0x18 ArticleId                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
