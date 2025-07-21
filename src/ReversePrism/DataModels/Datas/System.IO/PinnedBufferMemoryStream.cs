using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Array                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 070 PinningHandle                            ModelEnumType GCHandle GCHandle GCHandle Int32
    public partial class PinnedBufferMemoryStream : DataModel
    {
        public List<sbyte>?                             Array                                   { get; set; }
        public GCHandle                                 PinningHandle                           { get; set; }

        public static PinnedBufferMemoryStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PinnedBufferMemoryStream() { Pointer= p0 };

            value.Array                                     = GetSByteList(new IntPtr(p + 0x068)); // 0x68 Array                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.PinningHandle                             = (GCHandle)GetInt32(new IntPtr(p + 0x070)); // 0x70 PinningHandle               ( ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
