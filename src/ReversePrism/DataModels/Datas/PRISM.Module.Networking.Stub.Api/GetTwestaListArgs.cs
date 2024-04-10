using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTwestaListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 000 IsFavoriteFieldNumber                    int IL2CPP_TYPE_I4
    // 020 IsFavorite                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 MstTwestaUserIdFieldNumber               int IL2CPP_TYPE_I4
    // 024 MstTwestaUserId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetTwestaListArgs : DataModel
    {
        public string                                   Cursor                                  { get; set; }
        public bool                                     IsFavorite                              { get; set; }
        public int                                      MstTwestaUserId                         { get; set; }

        public static GetTwestaListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTwestaListArgs() { Pointer= p0 };

            value.Cursor                                    = GetString(new IntPtr(p + 0x018)); // 02466226E2C8 0x18 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x020)); // 02466226E308 0x20 IsFavorite                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MstTwestaUserId                           = GetInt32(new IntPtr(p + 0x024)); // 02466226E348 0x24 MstTwestaUserId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
