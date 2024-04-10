using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 M_ObsoleteNames                          000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 Type                                     000186671910 ModelPrimitiveType string string string String
    // 028 TypeNamespace                            000186671910 ModelPrimitiveType string string string String
    // 030 Use                                      0001866CCB90 ModelEnumType Use Use Use Int32
    // 038 Restriction                              000186760FC0 ModelClassType UxmlTypeRestriction UxmlTypeRestriction UxmlTypeRestriction Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0245A66C7100 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.M_ObsoleteNames                           = GetStringList(new IntPtr(p + 0x018)); // 0245A66C7120 0x18 M_ObsoleteNames             ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Type                                      = GetString(new IntPtr(p + 0x020)); // 0245A66C7140 0x20 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.TypeNamespace                             = GetString(new IntPtr(p + 0x028)); // 0245A66C7160 0x28 TypeNamespace               ( 000186671910 ModelPrimitiveType string string string String )
            value.Use                                       = (Use)GetInt32(new IntPtr(p + 0x030)); // 0245A66C7180 0x30 Use                         ( 0001866CCB90 ModelEnumType Use Use Use Int32 )
            value.Restriction                               = GetObject<UxmlTypeRestriction>(new IntPtr(p + 0x038), ReversePrism.DataModels.UxmlTypeRestriction.FromPointer); // 0245A66C71A0 0x38 Restriction                 ( 000186760FC0 ModelClassType UxmlTypeRestriction UxmlTypeRestriction UxmlTypeRestriction Pointer )

            return value;
        }
    }
}
