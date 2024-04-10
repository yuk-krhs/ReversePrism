using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Callback                                 0001865C5C70 ModelClassType XmlSerializationCollectionFixupCallback XmlSerializationCollectionFixupCallback XmlSerializationCollectionFixupCallback Pointer
    // 018 collection                               <object> IL2CPP_TYPE_OBJECT
    // 020 collectionItems                          <object> IL2CPP_TYPE_OBJECT
    // 028 Id                                       000186671910 ModelPrimitiveType string string string String
    public partial class CollectionFixup : DataModel
    {
        public XmlSerializationCollectionFixupCallback? Callback                                { get; set; }
        public string                                   Id                                      { get; set; }

        public static CollectionFixup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionFixup() { Pointer= p0 };

            value.Callback                                  = GetObject<XmlSerializationCollectionFixupCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSerializationCollectionFixupCallback.FromPointer); // 024667530B70 0x10 Callback                    ( 0001865C5C70 ModelClassType XmlSerializationCollectionFixupCallback XmlSerializationCollectionFixupCallback XmlSerializationCollectionFixupCallback Pointer )
            value.Id                                        = GetString(new IntPtr(p + 0x028)); // 024667530BD0 0x28 Id                          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
