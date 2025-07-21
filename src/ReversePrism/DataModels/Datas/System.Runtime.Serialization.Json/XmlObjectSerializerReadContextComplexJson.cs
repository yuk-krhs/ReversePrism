using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0F8 ExtensionDataValueType                   ModelPrimitiveType string string string String
    // 100 DateTimeFormat                           ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer
    // 108 UseSimpleDictionaryFormat                ModelPrimitiveType bool bool bool Bool
    public partial class XmlObjectSerializerReadContextComplexJson : DataModel
    {
        public string                                   ExtensionDataValueType                  { get; set; }
        public DateTimeFormat?                          DateTimeFormat                          { get; set; }
        public bool                                     UseSimpleDictionaryFormat               { get; set; }

        public static XmlObjectSerializerReadContextComplexJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectSerializerReadContextComplexJson() { Pointer= p0 };

            value.ExtensionDataValueType                    = GetString(new IntPtr(p + 0x0F8)); // 0xF8 ExtensionDataValueType      ( ModelPrimitiveType string string string String )
            value.DateTimeFormat                            = GetObject<DateTimeFormat>(new IntPtr(p + 0x100), ReversePrism.DataModels.DateTimeFormat.FromPointer); // 0x100 DateTimeFormat              ( ModelClassType DateTimeFormat DateTimeFormat DateTimeFormat Pointer )
            value.UseSimpleDictionaryFormat                 = GetBool(new IntPtr(p + 0x108)); // 0x108 UseSimpleDictionaryFormat   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
