using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Parent                                 ModelClassType PolyNode PolyNode PolyNode Pointer
    // 018 M_polygon                                ModelEnumListType List`1<IntPoint> List`1<IntPoint> List<IntPoint> Pointer
    // 020 M_Index                                  ModelPrimitiveType int int int Int32
    // 024 M_jointype                               ModelEnumType JoinType JoinType JoinType Int32
    // 028 M_endtype                                ModelEnumType EndType EndType EndType Int32
    // 030 M_Childs                                 ModelClassListType List`1<PolyNode> List`1<PolyNode> List<PolyNode> Pointer
    // 038 IsOpen                                   ModelPrimitiveType bool bool bool Bool
    public partial class PolyNode : DataModel
    {
        public PolyNode?                                M_Parent                                { get; set; }
        public List<IntPoint>?                          M_polygon                               { get; set; }
        public int                                      M_Index                                 { get; set; }
        public JoinType                                 M_jointype                              { get; set; }
        public EndType                                  M_endtype                               { get; set; }
        public List<PolyNode>?                          M_Childs                                { get; set; }
        public bool                                     IsOpen                                  { get; set; }

        public static PolyNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PolyNode() { Pointer= p0 };

            value.M_Parent                                  = GetObject<PolyNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.PolyNode.FromPointer); // 0x10 M_Parent                    ( ModelClassType PolyNode PolyNode PolyNode Pointer )
            value.M_polygon                                 = GetEnumList<IntPoint>(new IntPtr(p + 0x018)); // 0x18 M_polygon                   ( ModelEnumListType List`1<IntPoint> List`1<IntPoint> List<IntPoint> Pointer )
            value.M_Index                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Index                     ( ModelPrimitiveType int int int Int32 )
            value.M_jointype                                = (JoinType)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_jointype                  ( ModelEnumType JoinType JoinType JoinType Int32 )
            value.M_endtype                                 = (EndType)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_endtype                   ( ModelEnumType EndType EndType EndType Int32 )
            value.M_Childs                                  = GetObjectList<PolyNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.PolyNode.FromPointer); // 0x30 M_Childs                    ( ModelClassListType List`1<PolyNode> List`1<PolyNode> List<PolyNode> Pointer )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x038)); // 0x38 IsOpen                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
