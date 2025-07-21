using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewMatrix                               ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 ProjectionMatrix                         ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 090 ShadowTransform                          ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0D0 OffsetX                                  ModelPrimitiveType int int int Int32
    // 0D4 OffsetY                                  ModelPrimitiveType int int int Int32
    // 0D8 Resolution                               ModelPrimitiveType int int int Int32
    // 0DC SplitData                                ModelEnumType ShadowSplitData ShadowSplitData ShadowSplitData Int32
    public partial class ShadowSliceData : DataModel
    {
        public Matrix4x4                                ViewMatrix                              { get; set; }
        public Matrix4x4                                ProjectionMatrix                        { get; set; }
        public Matrix4x4                                ShadowTransform                         { get; set; }
        public int                                      OffsetX                                 { get; set; }
        public int                                      OffsetY                                 { get; set; }
        public int                                      Resolution                              { get; set; }
        public ShadowSplitData                          SplitData                               { get; set; }

        public static ShadowSliceData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowSliceData() { Pointer= p0 };

            value.ViewMatrix                                = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 ViewMatrix                  ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ProjectionMatrix                          = (Matrix4x4)GetInt32(new IntPtr(p + 0x050)); // 0x50 ProjectionMatrix            ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ShadowTransform                           = (Matrix4x4)GetInt32(new IntPtr(p + 0x090)); // 0x90 ShadowTransform             ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.OffsetX                                   = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 OffsetX                     ( ModelPrimitiveType int int int Int32 )
            value.OffsetY                                   = GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 OffsetY                     ( ModelPrimitiveType int int int Int32 )
            value.Resolution                                = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 Resolution                  ( ModelPrimitiveType int int int Int32 )
            value.SplitData                                 = (ShadowSplitData)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC SplitData                   ( ModelEnumType ShadowSplitData ShadowSplitData ShadowSplitData Int32 )

            return value;
        }
    }
}
