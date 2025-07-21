using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_onDeserializationHandler               ModelClassType DeserializationEventHandler DeserializationEventHandler DeserializationEventHandler Pointer
    // 018 M_onDeserializedHandler                  ModelClassType SerializationEventHandler SerializationEventHandler SerializationEventHandler Pointer
    // 020 M_objects                                ModelClassListType ObjectHolder[] ObjectHolder[] List<ObjectHolder> Pointer
    // 028 m_topObject                              <object> IL2CPP_TYPE_OBJECT
    // 030 M_specialFixupObjects                    ModelClassType ObjectHolderList ObjectHolderList ObjectHolderList Pointer
    // 038 M_fixupCount                             ModelPrimitiveType long long long Int64
    // 040 M_selector                               ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer
    // 048 M_context                                ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    public partial class ObjectManager : DataModel
    {
        public DeserializationEventHandler?             M_onDeserializationHandler              { get; set; }
        public SerializationEventHandler?               M_onDeserializedHandler                 { get; set; }
        public List<ObjectHolder>?                      M_objects                               { get; set; }
        public ObjectHolderList?                        M_specialFixupObjects                   { get; set; }
        public long                                     M_fixupCount                            { get; set; }
        public ISurrogateSelector?                      M_selector                              { get; set; }
        public StreamingContext                         M_context                               { get; set; }

        public static ObjectManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectManager() { Pointer= p0 };

            value.M_onDeserializationHandler                = GetObject<DeserializationEventHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.DeserializationEventHandler.FromPointer); // 0x10 M_onDeserializationHandler  ( ModelClassType DeserializationEventHandler DeserializationEventHandler DeserializationEventHandler Pointer )
            value.M_onDeserializedHandler                   = GetObject<SerializationEventHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.SerializationEventHandler.FromPointer); // 0x18 M_onDeserializedHandler     ( ModelClassType SerializationEventHandler SerializationEventHandler SerializationEventHandler Pointer )
            value.M_objects                                 = GetObjectList<ObjectHolder>(new IntPtr(p + 0x020), ReversePrism.DataModels.ObjectHolder.FromPointer); // 0x20 M_objects                   ( ModelClassListType ObjectHolder[] ObjectHolder[] List<ObjectHolder> Pointer )
            value.M_specialFixupObjects                     = GetObject<ObjectHolderList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ObjectHolderList.FromPointer); // 0x30 M_specialFixupObjects       ( ModelClassType ObjectHolderList ObjectHolderList ObjectHolderList Pointer )
            value.M_fixupCount                              = GetInt64(new IntPtr(p + 0x038)); // 0x38 M_fixupCount                ( ModelPrimitiveType long long long Int64 )
            value.M_selector                                = GetObject<ISurrogateSelector>(new IntPtr(p + 0x040), ReversePrism.DataModels.ISurrogateSelector.FromPointer); // 0x40 M_selector                  ( ModelClassType ISurrogateSelector ISurrogateSelector ISurrogateSelector Pointer )
            value.M_context                                 = (StreamingContext)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_context                   ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )

            return value;
        }
    }
}
