using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType float3 float3 float3 Int32
    // 01C VertexIndex                              ModelPrimitiveType int int int Int32
    // 020 ProxyVertexIndex                         ModelPrimitiveType int int int Int32
    // 024 ProxyVertexDistance                      ModelPrimitiveType float float float Single
    public partial class MappingWorkData : DataModel
    {
        public float3                                   Position                                { get; set; }
        public int                                      VertexIndex                             { get; set; }
        public int                                      ProxyVertexIndex                        { get; set; }
        public float                                    ProxyVertexDistance                     { get; set; }

        public static MappingWorkData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MappingWorkData() { Pointer= p0 };

            value.Position                                  = (float3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType float3 float3 float3 Int32 )
            value.VertexIndex                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C VertexIndex                 ( ModelPrimitiveType int int int Int32 )
            value.ProxyVertexIndex                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 ProxyVertexIndex            ( ModelPrimitiveType int int int Int32 )
            value.ProxyVertexDistance                       = GetSingle(new IntPtr(p + 0x024)); // 0x24 ProxyVertexDistance         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
