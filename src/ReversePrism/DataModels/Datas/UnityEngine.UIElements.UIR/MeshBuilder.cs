using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_VectorGraphics9Slice                   ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 s_VectorGraphicsSplitTriangle            ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 S_VectorGraphicsScaleTriangle            ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 S_VectorGraphicsStretch                  ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 S_MaxTextMeshVertices                    ModelPrimitiveType int int int Int32
    public partial class MeshBuilder : DataModel
    {
        public ProfilerMarker                           S_VectorGraphicsScaleTriangle           { get; set; }
        public ProfilerMarker                           S_VectorGraphicsStretch                 { get; set; }
        public int                                      S_MaxTextMeshVertices                   { get; set; }

        public static MeshBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshBuilder() { Pointer= p0 };

            value.S_VectorGraphicsScaleTriangle             = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_VectorGraphicsScaleTriangle ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_VectorGraphicsStretch                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0x18 S_VectorGraphicsStretch     ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_MaxTextMeshVertices                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 S_MaxTextMeshVertices       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
