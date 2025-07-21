using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Move                                     ModelPrimitiveType bool bool bool Bool
    // 011 Fix                                      ModelPrimitiveType bool bool bool Bool
    // 012 Ignore                                   ModelPrimitiveType bool bool bool Bool
    // 013 Invalid                                  ModelPrimitiveType bool bool bool Bool
    // 018 gridMap                                  NativeParallelMultiHashMap`2<int3, int> IL2CPP_TYPE_GENERICINST
    // 028 GridSize                                 ModelPrimitiveType float float float Single
    // 030 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 attribute                                NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    public partial class CreateGridMapJob : DataModel
    {
        public bool                                     Move                                    { get; set; }
        public bool                                     Fix                                     { get; set; }
        public bool                                     Ignore                                  { get; set; }
        public bool                                     Invalid                                 { get; set; }
        public float                                    GridSize                                { get; set; }

        public static CreateGridMapJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateGridMapJob() { Pointer= p0 };

            value.Move                                      = GetBool(new IntPtr(p + 0x010)); // 0x10 Move                        ( ModelPrimitiveType bool bool bool Bool )
            value.Fix                                       = GetBool(new IntPtr(p + 0x011)); // 0x11 Fix                         ( ModelPrimitiveType bool bool bool Bool )
            value.Ignore                                    = GetBool(new IntPtr(p + 0x012)); // 0x12 Ignore                      ( ModelPrimitiveType bool bool bool Bool )
            value.Invalid                                   = GetBool(new IntPtr(p + 0x013)); // 0x13 Invalid                     ( ModelPrimitiveType bool bool bool Bool )
            value.GridSize                                  = GetSingle(new IntPtr(p + 0x028)); // 0x28 GridSize                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
