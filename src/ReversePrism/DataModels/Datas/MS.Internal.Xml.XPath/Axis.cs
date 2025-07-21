using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AxisType                                 ModelEnumType AxisType AxisType AxisType Int32
    // 018 Input                                    ModelClassType AstNode AstNode AstNode Pointer
    // 020 Prefix                                   ModelPrimitiveType string string string String
    // 028 Name                                     ModelPrimitiveType string string string String
    // 030 NodeType                                 ModelEnumType XPathNodeType XPathNodeType XPathNodeType Int32
    // 034 AbbrAxis                                 ModelPrimitiveType bool bool bool Bool
    // 038 Urn                                      ModelPrimitiveType string string string String
    public partial class Axis : DataModel
    {
        public AxisType                                 AxisType                                { get; set; }
        public AstNode?                                 Input                                   { get; set; }
        public string                                   Prefix                                  { get; set; }
        public string                                   Name                                    { get; set; }
        public XPathNodeType                            NodeType                                { get; set; }
        public bool                                     AbbrAxis                                { get; set; }
        public string                                   Urn                                     { get; set; }

        public static Axis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Axis() { Pointer= p0 };

            value.AxisType                                  = (AxisType)GetInt32(new IntPtr(p + 0x010)); // 0x10 AxisType                    ( ModelEnumType AxisType AxisType AxisType Int32 )
            value.Input                                     = GetObject<AstNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.AstNode.FromPointer); // 0x18 Input                       ( ModelClassType AstNode AstNode AstNode Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Prefix                      ( ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Name                        ( ModelPrimitiveType string string string String )
            value.NodeType                                  = (XPathNodeType)GetInt32(new IntPtr(p + 0x030)); // 0x30 NodeType                    ( ModelEnumType XPathNodeType XPathNodeType XPathNodeType Int32 )
            value.AbbrAxis                                  = GetBool(new IntPtr(p + 0x034)); // 0x34 AbbrAxis                    ( ModelPrimitiveType bool bool bool Bool )
            value.Urn                                       = GetString(new IntPtr(p + 0x038)); // 0x38 Urn                         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
