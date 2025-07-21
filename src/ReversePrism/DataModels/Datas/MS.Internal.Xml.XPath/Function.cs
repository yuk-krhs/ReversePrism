using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FunctionType                             ModelEnumType FunctionType FunctionType FunctionType Int32
    // 018 ArgumentList                             ModelClassListType List`1<AstNode> List`1<AstNode> List<AstNode> Pointer
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 Prefix                                   ModelPrimitiveType string string string String
    // 000 ReturnTypes                              XPathResultType[] IL2CPP_TYPE_SZARRAY
    public partial class Function : DataModel
    {
        public FunctionType                             FunctionType                            { get; set; }
        public List<AstNode>?                           ArgumentList                            { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   Prefix                                  { get; set; }

        public static Function? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Function() { Pointer= p0 };

            value.FunctionType                              = (FunctionType)GetInt32(new IntPtr(p + 0x010)); // 0x10 FunctionType                ( ModelEnumType FunctionType FunctionType FunctionType Int32 )
            value.ArgumentList                              = GetObjectList<AstNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.AstNode.FromPointer); // 0x18 ArgumentList                ( ModelClassListType List`1<AstNode> List`1<AstNode> List<AstNode> Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Prefix                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
