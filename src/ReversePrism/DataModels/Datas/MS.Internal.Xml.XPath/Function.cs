using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FunctionType                             0001866DC9E0 ModelEnumType FunctionType FunctionType FunctionType Int32
    // 018 ArgumentList                             000185CCD5C8 ModelClassListType List`1<AstNode> List`1<AstNode> List<AstNode> Pointer
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 028 Prefix                                   000186671910 ModelPrimitiveType string string string String
    // 000 ReturnTypes                              XPathResultType[] IL2CPP_TYPE_SZARRAY
    public partial class Function
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
            var value   = new Function();

            value.FunctionType                              = (FunctionType)GetInt32(new IntPtr(p + 0x010)); // 0270D75F5D88 0x10 FunctionType                ( 0001866DC9E0 ModelEnumType FunctionType FunctionType FunctionType Int32 )
            value.ArgumentList                              = GetObjectList<AstNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.AstNode.FromPointer); // 0270D75F5DA8 0x18 ArgumentList                ( 000185CCD5C8 ModelClassListType List`1<AstNode> List`1<AstNode> List<AstNode> Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D75F5DC8 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x028)); // 0270D75F5DE8 0x28 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
