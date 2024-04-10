using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LeftChild                                000186604CA0 ModelClassType SyntaxTreeNode SyntaxTreeNode SyntaxTreeNode Pointer
    // 018 RightChild                               000186604CA0 ModelClassType SyntaxTreeNode SyntaxTreeNode SyntaxTreeNode Pointer
    public partial class InteriorNode : DataModel
    {
        public SyntaxTreeNode?                          LeftChild                               { get; set; }
        public SyntaxTreeNode?                          RightChild                              { get; set; }

        public static InteriorNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InteriorNode() { Pointer= p0 };

            value.LeftChild                                 = GetObject<SyntaxTreeNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.SyntaxTreeNode.FromPointer); // 02466755D650 0x10 LeftChild                   ( 000186604CA0 ModelClassType SyntaxTreeNode SyntaxTreeNode SyntaxTreeNode Pointer )
            value.RightChild                                = GetObject<SyntaxTreeNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.SyntaxTreeNode.FromPointer); // 02466755D670 0x18 RightChild                  ( 000186604CA0 ModelClassType SyntaxTreeNode SyntaxTreeNode SyntaxTreeNode Pointer )

            return value;
        }
    }
}
