using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LastBytes                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 LastBytesCount                           ModelPrimitiveType int int int Int32
    public partial class Ucs4Decoder : DataModel
    {
        public List<sbyte>?                             LastBytes                               { get; set; }
        public int                                      LastBytesCount                          { get; set; }

        public static Ucs4Decoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Ucs4Decoder() { Pointer= p0 };

            value.LastBytes                                 = GetSByteList(new IntPtr(p + 0x020)); // 0x20 LastBytes                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.LastBytesCount                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 LastBytesCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
