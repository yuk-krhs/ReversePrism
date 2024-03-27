using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MarkFavoriteFesIdolArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FesIdolId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 020 MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class MarkFavoriteFesIdolArgs
    {
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }

        public static MarkFavoriteFesIdolArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkFavoriteFesIdolArgs();

            value.FesIdolId                                 = GetString(new IntPtr(p + 0x018)); // 0270D12A56E8 0x18 FesIdolId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x020)); // 0270D12A5728 0x20 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
