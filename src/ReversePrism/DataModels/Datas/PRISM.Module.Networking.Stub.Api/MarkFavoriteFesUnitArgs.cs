using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MarkFavoriteFesUnitArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FesUnitId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 020 MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class MarkFavoriteFesUnitArgs
    {
        public string                                   FesUnitId                               { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }

        public static MarkFavoriteFesUnitArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarkFavoriteFesUnitArgs();

            value.FesUnitId                                 = GetString(new IntPtr(p + 0x018)); // 0270D13232A0 0x18 FesUnitId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x020)); // 0270D13232E0 0x20 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
