using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Positions                                ModelEnumListType float3[] float3[] List<float3> Pointer
    // 018 Attributes                               ModelEnumListType VertexAttribute[] VertexAttribute[] List<VertexAttribute> Pointer
    // 020 MaxConnectionDistance                    ModelPrimitiveType float float float Single
    // 024 UserEdit                                 ModelPrimitiveType bool bool bool Bool
    public partial class SelectionData : DataModel
    {
        public List<float3>?                            Positions                               { get; set; }
        public List<VertexAttribute>?                   Attributes                              { get; set; }
        public float                                    MaxConnectionDistance                   { get; set; }
        public bool                                     UserEdit                                { get; set; }

        public static SelectionData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectionData() { Pointer= p0 };

            value.Positions                                 = GetEnumList<float3>(new IntPtr(p + 0x010)); // 0x10 Positions                   ( ModelEnumListType float3[] float3[] List<float3> Pointer )
            value.Attributes                                = GetEnumList<VertexAttribute>(new IntPtr(p + 0x018)); // 0x18 Attributes                  ( ModelEnumListType VertexAttribute[] VertexAttribute[] List<VertexAttribute> Pointer )
            value.MaxConnectionDistance                     = GetSingle(new IntPtr(p + 0x020)); // 0x20 MaxConnectionDistance       ( ModelPrimitiveType float float float Single )
            value.UserEdit                                  = GetBool(new IntPtr(p + 0x024)); // 0x24 UserEdit                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
