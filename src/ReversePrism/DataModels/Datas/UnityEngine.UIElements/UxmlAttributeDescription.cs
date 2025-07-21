using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 M_ObsoleteNames                          ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 Type                                     ModelPrimitiveType string string string String
    // 028 TypeNamespace                            ModelPrimitiveType string string string String
    // 030 Use                                      ModelEnumType Use Use Use Int32
    // 038 Restriction                              ModelClassType UxmlTypeRestriction UxmlTypeRestriction UxmlTypeRestriction Pointer
    public partial class UxmlAttributeDescription : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<string>?                            M_ObsoleteNames                         { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   TypeNamespace                           { get; set; }
        public Use                                      Use                                     { get; set; }
        public UxmlTypeRestriction?                     Restriction                             { get; set; }

        public static UxmlAttributeDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlAttributeDescription() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.M_ObsoleteNames                           = GetStringList(new IntPtr(p + 0x018)); // 0x18 M_ObsoleteNames             ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Type                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Type                        ( ModelPrimitiveType string string string String )
            value.TypeNamespace                             = GetString(new IntPtr(p + 0x028)); // 0x28 TypeNamespace               ( ModelPrimitiveType string string string String )
            value.Use                                       = (Use)GetInt32(new IntPtr(p + 0x030)); // 0x30 Use                         ( ModelEnumType Use Use Use Int32 )
            value.Restriction                               = GetObject<UxmlTypeRestriction>(new IntPtr(p + 0x038), ReversePrism.DataModels.UxmlTypeRestriction.FromPointer); // 0x38 Restriction                 ( ModelClassType UxmlTypeRestriction UxmlTypeRestriction UxmlTypeRestriction Pointer )

            return value;
        }
    }
}
