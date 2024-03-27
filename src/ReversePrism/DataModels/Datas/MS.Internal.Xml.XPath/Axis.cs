using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AxisType                                 0001866E9CE0 ModelEnumType AxisType AxisType AxisType Int32
    // 018 Input                                    0001866E9E90 ModelClassType AstNode AstNode AstNode Pointer
    // 020 Prefix                                   000186671910 ModelPrimitiveType string string string String
    // 028 Name                                     000186671910 ModelPrimitiveType string string string String
    // 030 NodeType                                 0001866B8EB0 ModelEnumType XPathNodeType XPathNodeType XPathNodeType Int32
    // 034 AbbrAxis                                 000186595480 ModelPrimitiveType bool bool bool Bool
    // 038 Urn                                      000186671910 ModelPrimitiveType string string string String
    public partial class Axis
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
            var value   = new Axis();

            value.AxisType                                  = (AxisType)GetInt32(new IntPtr(p + 0x010)); // 0270D74D46D8 0x10 AxisType                    ( 0001866E9CE0 ModelEnumType AxisType AxisType AxisType Int32 )
            value.Input                                     = GetObject<AstNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.AstNode.FromPointer); // 0270D74D46F8 0x18 Input                       ( 0001866E9E90 ModelClassType AstNode AstNode AstNode Pointer )
            value.Prefix                                    = GetString(new IntPtr(p + 0x020)); // 0270D74D4718 0x20 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Name                                      = GetString(new IntPtr(p + 0x028)); // 0270D74D4738 0x28 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.NodeType                                  = (XPathNodeType)GetInt32(new IntPtr(p + 0x030)); // 0270D74D4758 0x30 NodeType                    ( 0001866B8EB0 ModelEnumType XPathNodeType XPathNodeType XPathNodeType Int32 )
            value.AbbrAxis                                  = GetBool(new IntPtr(p + 0x034)); // 0270D74D4778 0x34 AbbrAxis                    ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Urn                                       = GetString(new IntPtr(p + 0x038)); // 0270D74D4798 0x38 Urn                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
