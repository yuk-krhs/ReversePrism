using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainKind                                 ModelPrimitiveType uint uint uint UInt32
    // 014 ExecNumber                               ModelPrimitiveType int int int Int32
    // 018 Div                                      ModelPrimitiveType int int int Int32
    // 020 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 030 primitiveArray                           NativeArray`1<Primitive> IL2CPP_TYPE_GENERICINST
    // 040 sortAndSweepArray                        NativeArray`1<SortData> IL2CPP_TYPE_GENERICINST
    // 050 processingEdgeEdgeArray                  NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 060 intersectFlagArray                       NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    public partial class IntersectEdgeTriangleJob : DataModel
    {
        public uint                                     MainKind                                { get; set; }
        public int                                      ExecNumber                              { get; set; }
        public int                                      Div                                     { get; set; }

        public static IntersectEdgeTriangleJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntersectEdgeTriangleJob() { Pointer= p0 };

            value.MainKind                                  = GetUInt32(new IntPtr(p + 0x010)); // 0x10 MainKind                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.ExecNumber                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 ExecNumber                  ( ModelPrimitiveType int int int Int32 )
            value.Div                                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 Div                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
