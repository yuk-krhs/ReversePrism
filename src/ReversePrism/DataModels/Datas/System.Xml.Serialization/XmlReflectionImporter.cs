using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InitialDefaultNamespace                  ModelPrimitiveType string string string String
    // 018 AttributeOverrides                       ModelClassType XmlAttributeOverrides XmlAttributeOverrides XmlAttributeOverrides Pointer
    // 020 IncludedTypes                            ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 Helper                                   ModelClassType ReflectionHelper ReflectionHelper ReflectionHelper Pointer
    // 030 ArrayChoiceCount                         ModelPrimitiveType int int int Int32
    // 038 RelatedMaps                              ModelClassType ArrayList ArrayList ArrayList Pointer
    // 040 AllowPrivateTypes                        ModelPrimitiveType bool bool bool Bool
    // 000 errSimple                                string IL2CPP_TYPE_STRING
    // 008 errSimple2                               string IL2CPP_TYPE_STRING
    public partial class XmlReflectionImporter : DataModel
    {
        public string                                   InitialDefaultNamespace                 { get; set; }
        public XmlAttributeOverrides?                   AttributeOverrides                      { get; set; }
        public ArrayList?                               IncludedTypes                           { get; set; }
        public ReflectionHelper?                        Helper                                  { get; set; }
        public int                                      ArrayChoiceCount                        { get; set; }
        public ArrayList?                               RelatedMaps                             { get; set; }
        public bool                                     AllowPrivateTypes                       { get; set; }

        public static XmlReflectionImporter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlReflectionImporter() { Pointer= p0 };

            value.InitialDefaultNamespace                   = GetString(new IntPtr(p + 0x010)); // 0x10 InitialDefaultNamespace     ( ModelPrimitiveType string string string String )
            value.AttributeOverrides                        = GetObject<XmlAttributeOverrides>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlAttributeOverrides.FromPointer); // 0x18 AttributeOverrides          ( ModelClassType XmlAttributeOverrides XmlAttributeOverrides XmlAttributeOverrides Pointer )
            value.IncludedTypes                             = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0x20 IncludedTypes               ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Helper                                    = GetObject<ReflectionHelper>(new IntPtr(p + 0x028), ReversePrism.DataModels.ReflectionHelper.FromPointer); // 0x28 Helper                      ( ModelClassType ReflectionHelper ReflectionHelper ReflectionHelper Pointer )
            value.ArrayChoiceCount                          = GetInt32(new IntPtr(p + 0x030)); // 0x30 ArrayChoiceCount            ( ModelPrimitiveType int int int Int32 )
            value.RelatedMaps                               = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 0x38 RelatedMaps                 ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.AllowPrivateTypes                         = GetBool(new IntPtr(p + 0x040)); // 0x40 AllowPrivateTypes           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
