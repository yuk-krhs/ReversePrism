using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Length                                   ModelPrimitiveType int int int Int32
    // 018 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 028 outAABB                                  NativeReference`1<AABB> IL2CPP_TYPE_GENERICINST
    public partial class CalcAABBJob : DataModel
    {
        public int                                      Length                                  { get; set; }

        public static CalcAABBJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcAABBJob() { Pointer= p0 };

            value.Length                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
