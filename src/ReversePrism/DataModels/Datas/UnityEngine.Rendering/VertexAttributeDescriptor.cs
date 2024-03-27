using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attribute                                000186512590 ModelEnumType VertexAttribute VertexAttribute VertexAttribute Int32
    // 014 Format                                   0001865130D0 ModelEnumType VertexAttributeFormat VertexAttributeFormat VertexAttributeFormat Int32
    // 018 Dimension                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Stream                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class VertexAttributeDescriptor
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
            var value   = new VertexAttributeDescriptor();

            value.Attribute                                 = (VertexAttribute)GetInt32(new IntPtr(p + 0x010)); // 02700247DDD0 0x10 Attribute                   ( 000186512590 ModelEnumType VertexAttribute VertexAttribute VertexAttribute Int32 )
            value.Format                                    = (VertexAttributeFormat)GetInt32(new IntPtr(p + 0x014)); // 02700247DDF0 0x14 Format                      ( 0001865130D0 ModelEnumType VertexAttributeFormat VertexAttributeFormat VertexAttributeFormat Int32 )
            value.Dimension                                 = GetInt32(new IntPtr(p + 0x018)); // 02700247DE10 0x18 Dimension                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Stream                                    = GetInt32(new IntPtr(p + 0x01C)); // 02700247DE30 0x1C Stream                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
