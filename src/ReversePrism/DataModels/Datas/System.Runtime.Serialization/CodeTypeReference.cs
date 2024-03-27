using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseType                                 000186671910 ModelPrimitiveType string string string String
    // 018 IsInterface                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C ArrayRank                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ArrayElementType                         0001865BFF70 ModelClassType CodeTypeReference CodeTypeReference CodeTypeReference Pointer
    // 028 TypeArguments                            000185CD2DD8 ModelClassListType List`1<CodeTypeReference> List`1<CodeTypeReference> List<CodeTypeReference> Pointer
    // 030 ReferenceOptions                         0001865C0460 ModelEnumType CodeTypeReferenceOptions CodeTypeReferenceOptions CodeTypeReferenceOptions Int32
    // 034 NeedsFixup                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CodeTypeReference
    {
        public string                                   BaseType                                { get; set; }
        public bool                                     IsInterface                             { get; set; }
        public int                                      ArrayRank                               { get; set; }
        public CodeTypeReference?                       ArrayElementType                        { get; set; }
        public List<CodeTypeReference>?                 TypeArguments                           { get; set; }
        public CodeTypeReferenceOptions                 ReferenceOptions                        { get; set; }
        public bool                                     NeedsFixup                              { get; set; }

        public static CodeTypeReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CodeTypeReference();

            value.BaseType                                  = GetString(new IntPtr(p + 0x010)); // 0270D7CEA788 0x10 BaseType                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IsInterface                               = GetBool(new IntPtr(p + 0x018)); // 0270D7CEA7A8 0x18 IsInterface                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ArrayRank                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D7CEA7C8 0x1C ArrayRank                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ArrayElementType                          = GetObject<CodeTypeReference>(new IntPtr(p + 0x020), ReversePrism.DataModels.CodeTypeReference.FromPointer); // 0270D7CEA7E8 0x20 ArrayElementType            ( 0001865BFF70 ModelClassType CodeTypeReference CodeTypeReference CodeTypeReference Pointer )
            value.TypeArguments                             = GetObjectList<CodeTypeReference>(new IntPtr(p + 0x028), ReversePrism.DataModels.CodeTypeReference.FromPointer); // 0270D7CEA808 0x28 TypeArguments               ( 000185CD2DD8 ModelClassListType List`1<CodeTypeReference> List`1<CodeTypeReference> List<CodeTypeReference> Pointer )
            value.ReferenceOptions                          = (CodeTypeReferenceOptions)GetInt32(new IntPtr(p + 0x030)); // 0270D7CEA828 0x30 ReferenceOptions            ( 0001865C0460 ModelEnumType CodeTypeReferenceOptions CodeTypeReferenceOptions CodeTypeReferenceOptions Int32 )
            value.NeedsFixup                                = GetBool(new IntPtr(p + 0x034)); // 0270D7CEA848 0x34 NeedsFixup                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
