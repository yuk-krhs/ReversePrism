using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 SizeLayoutElement                        00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer
    // 0C8 SizeText                                 000186631C00 ModelClassType Text Text Text Pointer
    // 0D0 SizeInput                                00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer
    // 0D8 IsArray                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E0 ElementType                              000186692850 ModelClassType Type Type Type Pointer
    // 0E8 ElementsExpandedStates                   000185CCF508 ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer
    public partial class ArrayField
    {
        public LayoutElement?                           SizeLayoutElement                       { get; set; }
        public Text?                                    SizeText                                { get; set; }
        public BoundInputField?                         SizeInput                               { get; set; }
        public bool                                     IsArray                                 { get; set; }
        public Type?                                    ElementType                             { get; set; }
        public List<bool>?                              ElementsExpandedStates                  { get; set; }

        public static ArrayField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArrayField();

            value.SizeLayoutElement                         = GetObject<LayoutElement>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.LayoutElement.FromPointer); // 0270DB1D64F0 0xC0 SizeLayoutElement           ( 00018650C2A0 ModelClassType LayoutElement LayoutElement LayoutElement Pointer )
            value.SizeText                                  = GetObject<Text>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Text.FromPointer); // 0270DB1D6510 0xC8 SizeText                    ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.SizeInput                                 = GetObject<BoundInputField>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.BoundInputField.FromPointer); // 0270DB1D6530 0xD0 SizeInput                   ( 00018676E700 ModelClassType BoundInputField BoundInputField BoundInputField Pointer )
            value.IsArray                                   = GetBool(new IntPtr(p + 0x0D8)); // 0270DB1D6550 0xD8 IsArray                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ElementType                               = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0270DB1D6570 0xE0 ElementType                 ( 000186692850 ModelClassType Type Type Type Pointer )
            value.ElementsExpandedStates                    = GetBoolList(new IntPtr(p + 0x0E8)); // 0270DB1D6590 0xE8 ElementsExpandedStates      ( 000185CCF508 ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer )

            return value;
        }
    }
}
