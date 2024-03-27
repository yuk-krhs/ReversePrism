using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Map                                      0001866CA010 ModelClassType ObjectMap ObjectMap ObjectMap Pointer
    // 018 RelatedMaps                              00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 020 Format                                   00018672E200 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32
    // 028 Source                                   00018672FC30 ModelClassType SerializationSource SerializationSource SerializationSource Pointer
    // 030 ElementName                              000186671BA0 ModelPrimitiveType string string string String
    // 038 Namespace                                000186671BA0 ModelPrimitiveType string string string String
    // 040 Key                                      000186671910 ModelPrimitiveType string string string String
    public partial class XmlMapping
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
            var value   = new XmlMapping();

            value.Map                                       = GetObject<ObjectMap>(new IntPtr(p + 0x010), ReversePrism.DataModels.ObjectMap.FromPointer); // 0270D74B2808 0x10 Map                         ( 0001866CA010 ModelClassType ObjectMap ObjectMap ObjectMap Pointer )
            value.RelatedMaps                               = GetObject<ArrayList>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74B2828 0x18 RelatedMaps                 ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Format                                    = (SerializationFormat)GetInt32(new IntPtr(p + 0x020)); // 0270D74B2848 0x20 Format                      ( 00018672E200 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32 )
            value.Source                                    = GetObject<SerializationSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.SerializationSource.FromPointer); // 0270D74B2868 0x28 Source                      ( 00018672FC30 ModelClassType SerializationSource SerializationSource SerializationSource Pointer )
            value.ElementName                               = GetString(new IntPtr(p + 0x030)); // 0270D74B2888 0x30 ElementName                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Namespace                                 = GetString(new IntPtr(p + 0x038)); // 0270D74B28A8 0x38 Namespace                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Key                                       = GetString(new IntPtr(p + 0x040)); // 0270D74B28C8 0x40 Key                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
