using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Map                                      ModelClassType ObjectMap ObjectMap ObjectMap Pointer
    // 018 RelatedMaps                              ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 Format                                   ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32
    // 028 Source                                   ModelClassType SerializationSource SerializationSource SerializationSource Pointer
    // 030 ElementName                              ModelPrimitiveType string string string String
    // 038 Namespace                                ModelPrimitiveType string string string String
    // 040 Key                                      ModelPrimitiveType string string string String
    public partial class XmlMapping : DataModel
    {
        public ObjectMap?                               Map                                     { get; set; }
        public ArrayList?                               RelatedMaps                             { get; set; }
        public SerializationFormat                      Format                                  { get; set; }
        public SerializationSource?                     Source                                  { get; set; }
        public string                                   ElementName                             { get; set; }
        public string                                   Namespace                               { get; set; }
        public string                                   Key                                     { get; set; }

        public static XmlMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlMapping() { Pointer= p0 };

            value.Map                                       = GetObject<ObjectMap>(new IntPtr(p + 0x010), ReversePrism.DataModels.ObjectMap.FromPointer); // 0x10 Map                         ( ModelClassType ObjectMap ObjectMap ObjectMap Pointer )
            value.RelatedMaps                               = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0x18 RelatedMaps                 ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Format                                    = (SerializationFormat)GetInt32(new IntPtr(p + 0x020)); // 0x20 Format                      ( ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32 )
            value.Source                                    = GetObject<SerializationSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.SerializationSource.FromPointer); // 0x28 Source                      ( ModelClassType SerializationSource SerializationSource SerializationSource Pointer )
            value.ElementName                               = GetString(new IntPtr(p + 0x030)); // 0x30 ElementName                 ( ModelPrimitiveType string string string String )
            value.Namespace                                 = GetString(new IntPtr(p + 0x038)); // 0x38 Namespace                   ( ModelPrimitiveType string string string String )
            value.Key                                       = GetString(new IntPtr(p + 0x040)); // 0x40 Key                         ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
