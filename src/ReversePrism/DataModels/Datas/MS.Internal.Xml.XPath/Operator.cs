using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_invertOp                               Op[] IL2CPP_TYPE_SZARRAY
    // 010 OpType                                   ModelEnumType Op Op Op Int32
    // 018 Opnd1                                    ModelClassType AstNode AstNode AstNode Pointer
    // 020 Opnd2                                    ModelClassType AstNode AstNode AstNode Pointer
    public partial class Operator : DataModel
    {
        public Op                                       OpType                                  { get; set; }
        public AstNode?                                 Opnd1                                   { get; set; }
        public AstNode?                                 Opnd2                                   { get; set; }

        public static Operator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Operator() { Pointer= p0 };

            value.OpType                                    = (Op)GetInt32(new IntPtr(p + 0x010)); // 0x10 OpType                      ( ModelEnumType Op Op Op Int32 )
            value.Opnd1                                     = GetObject<AstNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.AstNode.FromPointer); // 0x18 Opnd1                       ( ModelClassType AstNode AstNode AstNode Pointer )
            value.Opnd2                                     = GetObject<AstNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.AstNode.FromPointer); // 0x20 Opnd2                       ( ModelClassType AstNode AstNode AstNode Pointer )

            return value;
        }
    }
}
