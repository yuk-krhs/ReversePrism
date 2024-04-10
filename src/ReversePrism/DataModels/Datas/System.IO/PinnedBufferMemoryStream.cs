using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Array                                    000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 070 PinningHandle                            0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
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

            value.Array                                     = GetSByteList(new IntPtr(p + 0x068)); // 024666E8D6E0 0x68 Array                       ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.PinningHandle                             = (GCHandle)GetInt32(new IntPtr(p + 0x070)); // 024666E8D700 0x70 PinningHandle               ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
