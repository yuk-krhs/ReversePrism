using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _objectSeenTable                         Dictionary`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 018 Context                                  ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 028 OnSerializedHandler                      ModelClassType SerializationEventHandler SerializationEventHandler SerializationEventHandler Pointer
    public partial class SerializationObjectManager : DataModel
    {
        public StreamingContext                         Context                                 { get; set; }
        public SerializationEventHandler?               OnSerializedHandler                     { get; set; }

        public static SerializationObjectManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationObjectManager() { Pointer= p0 };

            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x018)); // 0x18 Context                     ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.OnSerializedHandler                       = GetObject<SerializationEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.SerializationEventHandler.FromPointer); // 0x28 OnSerializedHandler         ( ModelClassType SerializationEventHandler SerializationEventHandler SerializationEventHandler Pointer )

            return value;
        }
    }
}
