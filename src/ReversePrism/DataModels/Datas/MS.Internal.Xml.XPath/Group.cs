using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GroupNode                                ModelClassType AstNode AstNode AstNode Pointer
    public partial class Group : DataModel
    {
        public AstNode?                                 GroupNode                               { get; set; }

        public static Group? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Group() { Pointer= p0 };

            value.GroupNode                                 = GetObject<AstNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.AstNode.FromPointer); // 0x10 GroupNode                   ( ModelClassType AstNode AstNode AstNode Pointer )

            return value;
        }
    }
}
