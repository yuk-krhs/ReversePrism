using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Symbols                                  ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer
    // 020 Positions                                ModelClassType Positions Positions Positions Pointer
    // 028 Stack                                    ModelClassType Stack Stack Stack Pointer
    // 030 ContentNode                              ModelClassType SyntaxTreeNode SyntaxTreeNode SyntaxTreeNode Pointer
    // 038 IsPartial                                ModelPrimitiveType bool bool bool Bool
    // 03C MinMaxNodesCount                         ModelPrimitiveType int int int Int32
    // 040 EnableUpaCheck                           ModelPrimitiveType bool bool bool Bool
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

            value.Symbols                                   = GetObject<SymbolsDictionary>(new IntPtr(p + 0x018), ReversePrism.DataModels.SymbolsDictionary.FromPointer); // 0x18 Symbols                     ( ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer )
            value.Positions                                 = GetObject<Positions>(new IntPtr(p + 0x020), ReversePrism.DataModels.Positions.FromPointer); // 0x20 Positions                   ( ModelClassType Positions Positions Positions Pointer )
            value.Stack                                     = GetObject<Stack>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stack.FromPointer); // 0x28 Stack                       ( ModelClassType Stack Stack Stack Pointer )
            value.ContentNode                               = GetObject<SyntaxTreeNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.SyntaxTreeNode.FromPointer); // 0x30 ContentNode                 ( ModelClassType SyntaxTreeNode SyntaxTreeNode SyntaxTreeNode Pointer )
            value.IsPartial                                 = GetBool(new IntPtr(p + 0x038)); // 0x38 IsPartial                   ( ModelPrimitiveType bool bool bool Bool )
            value.MinMaxNodesCount                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C MinMaxNodesCount            ( ModelPrimitiveType int int int Int32 )
            value.EnableUpaCheck                            = GetBool(new IntPtr(p + 0x040)); // 0x40 EnableUpaCheck              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
