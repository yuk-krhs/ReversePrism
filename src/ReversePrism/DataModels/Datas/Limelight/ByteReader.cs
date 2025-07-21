using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset                                   ModelPrimitiveType int int int Int32
    // 018 Src                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class ByteReader : DataModel
    {
        public int                                      Offset                                  { get; set; }
        public List<sbyte>?                             Src                                     { get; set; }

        public static ByteReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByteReader() { Pointer= p0 };

            value.Offset                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Src                                       = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Src                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
