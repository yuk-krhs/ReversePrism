using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseType                                 ModelPrimitiveType string string string String
    // 018 IsInterface                              ModelPrimitiveType bool bool bool Bool
    // 01C ArrayRank                                ModelPrimitiveType int int int Int32
    // 020 ArrayElementType                         ModelClassType CodeTypeReference CodeTypeReference CodeTypeReference Pointer
    // 028 TypeArguments                            ModelClassListType List`1<CodeTypeReference> List`1<CodeTypeReference> List<CodeTypeReference> Pointer
    // 030 ReferenceOptions                         ModelEnumType CodeTypeReferenceOptions CodeTypeReferenceOptions CodeTypeReferenceOptions Int32
    // 034 NeedsFixup                               ModelPrimitiveType bool bool bool Bool
    public partial class CodeTypeReference : DataModel
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
            var value   = new CodeTypeReference() { Pointer= p0 };

            value.BaseType                                  = GetString(new IntPtr(p + 0x010)); // 0x10 BaseType                    ( ModelPrimitiveType string string string String )
            value.IsInterface                               = GetBool(new IntPtr(p + 0x018)); // 0x18 IsInterface                 ( ModelPrimitiveType bool bool bool Bool )
            value.ArrayRank                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ArrayRank                   ( ModelPrimitiveType int int int Int32 )
            value.ArrayElementType                          = GetObject<CodeTypeReference>(new IntPtr(p + 0x020), ReversePrism.DataModels.CodeTypeReference.FromPointer); // 0x20 ArrayElementType            ( ModelClassType CodeTypeReference CodeTypeReference CodeTypeReference Pointer )
            value.TypeArguments                             = GetObjectList<CodeTypeReference>(new IntPtr(p + 0x028), ReversePrism.DataModels.CodeTypeReference.FromPointer); // 0x28 TypeArguments               ( ModelClassListType List`1<CodeTypeReference> List`1<CodeTypeReference> List<CodeTypeReference> Pointer )
            value.ReferenceOptions                          = (CodeTypeReferenceOptions)GetInt32(new IntPtr(p + 0x030)); // 0x30 ReferenceOptions            ( ModelEnumType CodeTypeReferenceOptions CodeTypeReferenceOptions CodeTypeReferenceOptions Int32 )
            value.NeedsFixup                                = GetBool(new IntPtr(p + 0x034)); // 0x34 NeedsFixup                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
