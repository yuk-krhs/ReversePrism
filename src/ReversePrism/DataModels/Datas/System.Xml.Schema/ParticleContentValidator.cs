using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Symbols                                  0001866005F0 ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer
    // 020 Positions                                000186768E20 ModelClassType Positions Positions Positions Pointer
    // 028 Stack                                    00018655EBF0 ModelClassType Stack Stack Stack Pointer
    // 030 ContentNode                              000186604CA0 ModelClassType SyntaxTreeNode SyntaxTreeNode SyntaxTreeNode Pointer
    // 038 IsPartial                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C MinMaxNodesCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 EnableUpaCheck                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ParticleContentValidator : DataModel
    {
        public SymbolsDictionary?                       Symbols                                 { get; set; }
        public Positions?                               Positions                               { get; set; }
        public Stack?                                   Stack                                   { get; set; }
        public SyntaxTreeNode?                          ContentNode                             { get; set; }
        public bool                                     IsPartial                               { get; set; }
        public int                                      MinMaxNodesCount                        { get; set; }
        public bool                                     EnableUpaCheck                          { get; set; }

        public static ParticleContentValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParticleContentValidator() { Pointer= p0 };

            value.Symbols                                   = GetObject<SymbolsDictionary>(new IntPtr(p + 0x018), ReversePrism.DataModels.SymbolsDictionary.FromPointer); // 0246674DCE20 0x18 Symbols                     ( 0001866005F0 ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer )
            value.Positions                                 = GetObject<Positions>(new IntPtr(p + 0x020), ReversePrism.DataModels.Positions.FromPointer); // 0246674DCE40 0x20 Positions                   ( 000186768E20 ModelClassType Positions Positions Positions Pointer )
            value.Stack                                     = GetObject<Stack>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stack.FromPointer); // 0246674DCE60 0x28 Stack                       ( 00018655EBF0 ModelClassType Stack Stack Stack Pointer )
            value.ContentNode                               = GetObject<SyntaxTreeNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.SyntaxTreeNode.FromPointer); // 0246674DCE80 0x30 ContentNode                 ( 000186604CA0 ModelClassType SyntaxTreeNode SyntaxTreeNode SyntaxTreeNode Pointer )
            value.IsPartial                                 = GetBool(new IntPtr(p + 0x038)); // 0246674DCEA0 0x38 IsPartial                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MinMaxNodesCount                          = GetInt32(new IntPtr(p + 0x03C)); // 0246674DCEC0 0x3C MinMaxNodesCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EnableUpaCheck                            = GetBool(new IntPtr(p + 0x040)); // 0246674DCEE0 0x40 EnableUpaCheck              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
