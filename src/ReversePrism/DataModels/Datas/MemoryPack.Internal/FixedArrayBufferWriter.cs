using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Written                                  ModelPrimitiveType int int int Int32
    public partial class FixedArrayBufferWriter : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Written                                 { get; set; }

        public static FixedArrayBufferWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedArrayBufferWriter() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Written                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Written                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
