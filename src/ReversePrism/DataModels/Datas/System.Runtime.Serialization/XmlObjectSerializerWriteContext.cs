using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ByValObjectsInScope                      0001866CCDC0 ModelEnumType ObjectReferenceStack ObjectReferenceStack ObjectReferenceStack Int32
    // 0A0 XmlSerializableWriter                    0001865C57A0 ModelClassType XmlSerializableWriter XmlSerializableWriter XmlSerializableWriter Pointer
    // 000 depthToCheckCyclicReference              int IL2CPP_TYPE_I4
    // 0A8 PreserveObjectReferences                 000186595480 ModelPrimitiveType bool bool bool Bool
    // 0B0 SerializedObjects                        0001866CD4D0 ModelClassType ObjectToIdCache ObjectToIdCache ObjectToIdCache Pointer
    // 0B8 IsGetOnlyCollection                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B9 UnsafeTypeForwardingEnabled              0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 0BA SerializeReadOnlyTypes                   000186595480 ModelPrimitiveType bool bool bool Bool
    public partial class XmlObjectSerializerWriteContext : DataModel
    {
        public ObjectReferenceStack                     ByValObjectsInScope                     { get; set; }
        public XmlSerializableWriter?                   XmlSerializableWriter                   { get; set; }
        public bool                                     PreserveObjectReferences                { get; set; }
        public ObjectToIdCache?                         SerializedObjects                       { get; set; }
        public bool                                     IsGetOnlyCollection                     { get; set; }
        public bool                                     UnsafeTypeForwardingEnabled             { get; set; }
        public bool                                     SerializeReadOnlyTypes                  { get; set; }

        public static XmlObjectSerializerWriteContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectSerializerWriteContext() { Pointer= p0 };

            value.ByValObjectsInScope                       = (ObjectReferenceStack)GetInt32(new IntPtr(p + 0x080)); // 0245A4DCEFE0 0x80 ByValObjectsInScope         ( 0001866CCDC0 ModelEnumType ObjectReferenceStack ObjectReferenceStack ObjectReferenceStack Int32 )
            value.XmlSerializableWriter                     = GetObject<XmlSerializableWriter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSerializableWriter.FromPointer); // 0245A4DCF000 0xA0 XmlSerializableWriter       ( 0001865C57A0 ModelClassType XmlSerializableWriter XmlSerializableWriter XmlSerializableWriter Pointer )
            value.PreserveObjectReferences                  = GetBool(new IntPtr(p + 0x0A8)); // 0245A4DCF040 0xA8 PreserveObjectReferences    ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.SerializedObjects                         = GetObject<ObjectToIdCache>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ObjectToIdCache.FromPointer); // 0245A4DCF060 0xB0 SerializedObjects           ( 0001866CD4D0 ModelClassType ObjectToIdCache ObjectToIdCache ObjectToIdCache Pointer )
            value.IsGetOnlyCollection                       = GetBool(new IntPtr(p + 0x0B8)); // 0245A4DCF080 0xB8 IsGetOnlyCollection         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UnsafeTypeForwardingEnabled               = GetBool(new IntPtr(p + 0x0B9)); // 0245A4DCF0A0 0xB9 UnsafeTypeForwardingEnabled ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.SerializeReadOnlyTypes                    = GetBool(new IntPtr(p + 0x0BA)); // 0245A4DCF0C0 0xBA SerializeReadOnlyTypes      ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
