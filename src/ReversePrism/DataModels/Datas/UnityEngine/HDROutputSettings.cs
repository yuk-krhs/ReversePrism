using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DisplayIndex                           ModelPrimitiveType int int int Int32
    // 000 displays                                 HDROutputSettings[] IL2CPP_TYPE_SZARRAY
    // 008 _mainDisplay                             HDROutputSettings IL2CPP_TYPE_CLASS
    public partial class HDROutputSettings : DataModel
    {
        public int                                      M_DisplayIndex                          { get; set; }

        public static HDROutputSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HDROutputSettings() { Pointer= p0 };

            value.M_DisplayIndex                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_DisplayIndex              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
