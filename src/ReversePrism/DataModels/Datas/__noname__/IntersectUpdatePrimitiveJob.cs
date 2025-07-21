using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Kind                                     ModelPrimitiveType uint uint uint UInt32
    // 018 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 028 nextPosArray                             NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 038 primitiveArray                           NativeArray`1<Primitive> IL2CPP_TYPE_GENERICINST
    // 048 processingArray                          NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    public partial class IntersectUpdatePrimitiveJob : DataModel
    {
        public uint                                     Kind                                    { get; set; }

        public static IntersectUpdatePrimitiveJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntersectUpdatePrimitiveJob() { Pointer= p0 };

            value.Kind                                      = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Kind                        ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
