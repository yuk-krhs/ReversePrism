using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetStreamArchiveListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Cursor                                   ModelPrimitiveType string string string String
    // 000 IsFavoriteFieldNumber                    int IL2CPP_TYPE_I4
    // 020 IsFavorite                               ModelPrimitiveType bool bool bool Bool
    public partial class GetStreamArchiveListArgs : DataModel
    {
        public string                                   Cursor                                  { get; set; }
        public bool                                     IsFavorite                              { get; set; }

        public static GetStreamArchiveListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetStreamArchiveListArgs() { Pointer= p0 };

            value.Cursor                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Cursor                      ( ModelPrimitiveType string string string String )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x020)); // 0x20 IsFavorite                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
