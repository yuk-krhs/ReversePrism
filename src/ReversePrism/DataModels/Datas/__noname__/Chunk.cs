using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bytes                                    000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Offset                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Chunk
    {
        public List<sbyte>?                             Bytes                                   { get; set; }
        public int                                      Offset                                  { get; set; }

        public static Chunk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Chunk();

            value.Bytes                                     = GetSByteList(new IntPtr(p + 0x010)); // 0270D7A8FE28 0x10 Bytes                       ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D7A8FE48 0x18 Offset                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
