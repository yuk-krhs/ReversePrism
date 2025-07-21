using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attribute                                ModelEnumType VertexAttribute VertexAttribute VertexAttribute Int32
    // 014 Format                                   ModelEnumType VertexAttributeFormat VertexAttributeFormat VertexAttributeFormat Int32
    // 018 Dimension                                ModelPrimitiveType int int int Int32
    // 01C Stream                                   ModelPrimitiveType int int int Int32
    public partial class VertexAttributeDescriptor : DataModel
    {
        public VertexAttribute                          Attribute                               { get; set; }
        public VertexAttributeFormat                    Format                                  { get; set; }
        public int                                      Dimension                               { get; set; }
        public int                                      Stream                                  { get; set; }

        public static VertexAttributeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VertexAttributeDescriptor() { Pointer= p0 };

            value.Attribute                                 = (VertexAttribute)GetInt32(new IntPtr(p + 0x010)); // 0x10 Attribute                   ( ModelEnumType VertexAttribute VertexAttribute VertexAttribute Int32 )
            value.Format                                    = (VertexAttributeFormat)GetInt32(new IntPtr(p + 0x014)); // 0x14 Format                      ( ModelEnumType VertexAttributeFormat VertexAttributeFormat VertexAttributeFormat Int32 )
            value.Dimension                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 Dimension                   ( ModelPrimitiveType int int int Int32 )
            value.Stream                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Stream                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
