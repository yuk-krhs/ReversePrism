using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Head                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 110 Tail                                     0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class PaddedHeadAndTail : DataModel
    {
        public int                                      Head                                    { get; set; }
        public int                                      Tail                                    { get; set; }

        public static PaddedHeadAndTail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PaddedHeadAndTail() { Pointer= p0 };

            value.Head                                      = GetInt32(new IntPtr(p + 0x090)); // 0245A3EFCAA0 0x90 Head                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Tail                                      = GetInt32(new IntPtr(p + 0x110)); // 0245A3EFCAC0 0x110 Tail                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
