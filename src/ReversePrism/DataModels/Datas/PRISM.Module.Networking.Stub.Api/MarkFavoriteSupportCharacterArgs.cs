using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MarkFavoriteSupportCharacterArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 01C MstFavoriteMarkId                        ModelPrimitiveType int int int Int32
    public partial class MarkFavoriteSupportCharacterArgs : DataModel
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }

        public static MarkFavoriteSupportCharacterArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkFavoriteSupportCharacterArgs() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstFavoriteMarkId           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
