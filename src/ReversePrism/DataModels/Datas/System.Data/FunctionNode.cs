using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Name                                     0001866731A0 ModelPrimitiveType string string string String
    // 020 Info                                     0001865F44E0 ModelPrimitiveType int int int Int32
    // 024 ArgumentCount                            0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 Arguments                                000185B7DA40 ModelClassListType ExpressionNode[] ExpressionNode[] List<ExpressionNode> Pointer
    // 000 s_funcs                                  Function[] IL2CPP_TYPE_SZARRAY
    public partial class FunctionNode : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Info                                    { get; set; }
        public int                                      ArgumentCount                           { get; set; }
        public List<ExpressionNode>?                    Arguments                               { get; set; }

        public static FunctionNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FunctionNode() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 024668997200 0x18 Name                        ( 0001866731A0 ModelPrimitiveType string string string String )
            value.Info                                      = GetInt32(new IntPtr(p + 0x020)); // 024668997220 0x20 Info                        ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.ArgumentCount                             = GetInt32(new IntPtr(p + 0x024)); // 024668997240 0x24 ArgumentCount               ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Arguments                                 = GetObjectList<ExpressionNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExpressionNode.FromPointer); // 024668997260 0x28 Arguments                   ( 000185B7DA40 ModelClassListType ExpressionNode[] ExpressionNode[] List<ExpressionNode> Pointer )

            return value;
        }
    }
}
