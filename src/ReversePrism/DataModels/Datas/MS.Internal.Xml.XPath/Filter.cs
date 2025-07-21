using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Input                                    ModelClassType AstNode AstNode AstNode Pointer
    // 018 Condition                                ModelClassType AstNode AstNode AstNode Pointer
    public partial class Filter : DataModel
    {
        public AstNode?                                 Input                                   { get; set; }
        public AstNode?                                 Condition                               { get; set; }

        public static Filter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Filter() { Pointer= p0 };

            value.Input                                     = GetObject<AstNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.AstNode.FromPointer); // 0x10 Input                       ( ModelClassType AstNode AstNode AstNode Pointer )
            value.Condition                                 = GetObject<AstNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.AstNode.FromPointer); // 0x18 Condition                   ( ModelClassType AstNode AstNode AstNode Pointer )

            return value;
        }
    }
}
