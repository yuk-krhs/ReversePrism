using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Jobs                                   NativeArray`1<JobHandle> IL2CPP_TYPE_GENERICINST
    // 020 M_NextJobIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OpacityIdAccelerator
    {
        public int                                      M_NextJobIndex                          { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static OpacityIdAccelerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OpacityIdAccelerator();

            value.M_NextJobIndex                            = GetInt32(new IntPtr(p + 0x020)); // 0270068684E8 0x20 M_NextJobIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x024)); // 027006868508 0x24 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
