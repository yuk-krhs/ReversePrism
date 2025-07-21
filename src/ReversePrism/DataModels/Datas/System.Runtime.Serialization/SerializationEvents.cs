using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSerializingMethods                     ModelClassListType List`1<MethodInfo> List`1<MethodInfo> List<MethodInfo> Pointer
    // 018 OnSerializedMethods                      ModelClassListType List`1<MethodInfo> List`1<MethodInfo> List<MethodInfo> Pointer
    // 020 OnDeserializingMethods                   ModelClassListType List`1<MethodInfo> List`1<MethodInfo> List<MethodInfo> Pointer
    // 028 OnDeserializedMethods                    ModelClassListType List`1<MethodInfo> List`1<MethodInfo> List<MethodInfo> Pointer
    public partial class SerializationEvents : DataModel
    {
        public List<MethodInfo>?                        OnSerializingMethods                    { get; set; }
        public List<MethodInfo>?                        OnSerializedMethods                     { get; set; }
        public List<MethodInfo>?                        OnDeserializingMethods                  { get; set; }
        public List<MethodInfo>?                        OnDeserializedMethods                   { get; set; }

        public static SerializationEvents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationEvents() { Pointer= p0 };

            value.OnSerializingMethods                      = GetObjectList<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x10 OnSerializingMethods        ( ModelClassListType List`1<MethodInfo> List`1<MethodInfo> List<MethodInfo> Pointer )
            value.OnSerializedMethods                       = GetObjectList<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x18 OnSerializedMethods         ( ModelClassListType List`1<MethodInfo> List`1<MethodInfo> List<MethodInfo> Pointer )
            value.OnDeserializingMethods                    = GetObjectList<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x20 OnDeserializingMethods      ( ModelClassListType List`1<MethodInfo> List`1<MethodInfo> List<MethodInfo> Pointer )
            value.OnDeserializedMethods                     = GetObjectList<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x28 OnDeserializedMethods       ( ModelClassListType List`1<MethodInfo> List`1<MethodInfo> List<MethodInfo> Pointer )

            return value;
        }
    }
}
