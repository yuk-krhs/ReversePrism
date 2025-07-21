using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EncodingUTF8                             Encoding IL2CPP_TYPE_CLASS
    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 ValueBytes                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 LazyValue                                ModelPrimitiveType string string string String
    public partial class AuthProperty : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<sbyte>?                             ValueBytes                              { get; set; }
        public string                                   LazyValue                               { get; set; }

        public static AuthProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthProperty() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.ValueBytes                                = GetSByteList(new IntPtr(p + 0x018)); // 0x18 ValueBytes                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LazyValue                                 = GetString(new IntPtr(p + 0x020)); // 0x20 LazyValue                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
