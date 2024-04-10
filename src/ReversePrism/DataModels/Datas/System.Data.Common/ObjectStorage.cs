using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           <object> IL2CPP_TYPE_OBJECT
    // 050 _values                                  <object>[] IL2CPP_TYPE_SZARRAY
    // 058 ImplementsIXmlSerializable               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 008 s_tempAssemblyCacheLock                  <object> IL2CPP_TYPE_OBJECT
    // 010 s_tempAssemblyCache                      Dictionary`2<KeyValuePair`2<Type, XmlRootAttribute>, XmlSerializer> IL2CPP_TYPE_GENERICINST
    // 018 S_serializerFactory                      0001865C8540 ModelClassType XmlSerializerFactory XmlSerializerFactory XmlSerializerFactory Pointer
    public partial class ObjectStorage : DataModel
    {
        public bool                                     ImplementsIXmlSerializable              { get; set; }
        public XmlSerializerFactory?                    S_serializerFactory                     { get; set; }

        public static ObjectStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectStorage() { Pointer= p0 };

            value.ImplementsIXmlSerializable                = GetBool(new IntPtr(p + 0x058)); // 024668A3D530 0x58 ImplementsIXmlSerializable  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.S_serializerFactory                       = GetObject<XmlSerializerFactory>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSerializerFactory.FromPointer); // 024668A3D590 0x18 S_serializerFactory         ( 0001865C8540 ModelClassType XmlSerializerFactory XmlSerializerFactory XmlSerializerFactory Pointer )

            return value;
        }
    }
}
