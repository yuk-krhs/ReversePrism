using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_serializedStates                       IList`1<<object>> IL2CPP_TYPE_GENERICINST
    // 018 M_savedSerializationInfo                 0001866636F0 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 020 m_realObject                             <object> IL2CPP_TYPE_OBJECT
    // 028 M_realType                               00018669F180 ModelClassType RuntimeType RuntimeType RuntimeType Pointer
    // 030 SerializeObjectState                     EventHandler`1<SafeSerializationEventArgs> IL2CPP_TYPE_GENERICINST
    // 000 RealTypeSerializationName                string IL2CPP_TYPE_STRING
    public partial class SafeSerializationManager
    {
        public SerializationInfo?                       M_savedSerializationInfo                { get; set; }
        public RuntimeType?                             M_realType                              { get; set; }

        public static SafeSerializationManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeSerializationManager();

            value.M_savedSerializationInfo                  = GetObject<SerializationInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.SerializationInfo.FromPointer); // 027004BDFDB0 0x18 M_savedSerializationInfo    ( 0001866636F0 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.M_realType                                = GetObject<RuntimeType>(new IntPtr(p + 0x028), ReversePrism.DataModels.RuntimeType.FromPointer); // 027004BDFDF0 0x28 M_realType                  ( 00018669F180 ModelClassType RuntimeType RuntimeType RuntimeType Pointer )

            return value;
        }
    }
}
