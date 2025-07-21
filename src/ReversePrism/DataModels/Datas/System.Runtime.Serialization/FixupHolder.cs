using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_id                                     ModelPrimitiveType long long long Int64
    // 018 m_fixupInfo                              <object> IL2CPP_TYPE_OBJECT
    // 020 M_fixupType                              ModelPrimitiveType int int int Int32
    public partial class FixupHolder : DataModel
    {
        public long                                     M_id                                    { get; set; }
        public int                                      M_fixupType                             { get; set; }

        public static FixupHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixupHolder() { Pointer= p0 };

            value.M_id                                      = GetInt64(new IntPtr(p + 0x010)); // 0x10 M_id                        ( ModelPrimitiveType long long long Int64 )
            value.M_fixupType                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_fixupType                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
