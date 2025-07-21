using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ByValObjectsInScope                      ModelEnumType ObjectReferenceStack ObjectReferenceStack ObjectReferenceStack Int32
    // 0A0 XmlSerializableWriter                    ModelClassType XmlSerializableWriter XmlSerializableWriter XmlSerializableWriter Pointer
    // 000 depthToCheckCyclicReference              int IL2CPP_TYPE_I4
    // 0A8 PreserveObjectReferences                 ModelPrimitiveType bool bool bool Bool
    // 0B0 SerializedObjects                        ModelClassType ObjectToIdCache ObjectToIdCache ObjectToIdCache Pointer
    // 0B8 IsGetOnlyCollection                      ModelPrimitiveType bool bool bool Bool
    // 0B9 UnsafeTypeForwardingEnabled              ModelPrimitiveType bool bool bool Bool
    // 0BA SerializeReadOnlyTypes                   ModelPrimitiveType bool bool bool Bool
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

            value.ByValObjectsInScope                       = (ObjectReferenceStack)GetInt32(new IntPtr(p + 0x080)); // 0x80 ByValObjectsInScope         ( ModelEnumType ObjectReferenceStack ObjectReferenceStack ObjectReferenceStack Int32 )
            value.XmlSerializableWriter                     = GetObject<XmlSerializableWriter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlSerializableWriter.FromPointer); // 0xA0 XmlSerializableWriter       ( ModelClassType XmlSerializableWriter XmlSerializableWriter XmlSerializableWriter Pointer )
            value.PreserveObjectReferences                  = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 PreserveObjectReferences    ( ModelPrimitiveType bool bool bool Bool )
            value.SerializedObjects                         = GetObject<ObjectToIdCache>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ObjectToIdCache.FromPointer); // 0xB0 SerializedObjects           ( ModelClassType ObjectToIdCache ObjectToIdCache ObjectToIdCache Pointer )
            value.IsGetOnlyCollection                       = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 IsGetOnlyCollection         ( ModelPrimitiveType bool bool bool Bool )
            value.UnsafeTypeForwardingEnabled               = GetBool(new IntPtr(p + 0x0B9)); // 0xB9 UnsafeTypeForwardingEnabled ( ModelPrimitiveType bool bool bool Bool )
            value.SerializeReadOnlyTypes                    = GetBool(new IntPtr(p + 0x0BA)); // 0xBA SerializeReadOnlyTypes      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
