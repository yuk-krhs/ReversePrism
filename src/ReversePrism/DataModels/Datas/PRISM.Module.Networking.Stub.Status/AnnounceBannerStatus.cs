using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<AnnounceBannerStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ArticleIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 ArticleId                                000186671910 ModelPrimitiveType string string string String
    // 000 BannerUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 020 BannerUrl                                000186671910 ModelPrimitiveType string string string String
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 028 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AnnounceBannerStatus
    {
        public string                                   ArticleId                               { get; set; }
        public string                                   BannerUrl                               { get; set; }
        public int                                      SortId                                  { get; set; }

        public static AnnounceBannerStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceBannerStatus();

            value.ArticleId                                 = GetString(new IntPtr(p + 0x018)); // 0270D0F4BA50 0x18 ArticleId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x020)); // 0270D0F4BA90 0x20 BannerUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D0F4BAD0 0x28 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
