using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 generationThreshold                      int IL2CPP_TYPE_I4
    // 004 backgroundGeneration                     bool IL2CPP_TYPE_BOOLEAN
    // 005 deleteTempFiles                          bool IL2CPP_TYPE_BOOLEAN
    // 006 generatorFallback                        bool IL2CPP_TYPE_BOOLEAN
    // 010 CustomSerializer                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 TypeMapping                              00018659F0F0 ModelClassType XmlMapping XmlMapping XmlMapping Pointer
    // 020 SerializerData                           00018673F200 ModelClassType SerializerData SerializerData SerializerData Pointer
    // 008 serializerTypes                          Hashtable IL2CPP_TYPE_CLASS
    // 028 OnUnreferencedObject                     000186736860 ModelClassType UnreferencedObjectEventHandler UnreferencedObjectEventHandler UnreferencedObjectEventHandler Pointer
    // 030 OnUnknownAttribute                       00018658A890 ModelClassType XmlAttributeEventHandler XmlAttributeEventHandler XmlAttributeEventHandler Pointer
    // 038 OnUnknownElement                         000186598B00 ModelClassType XmlElementEventHandler XmlElementEventHandler XmlElementEventHandler Pointer
    // 040 OnUnknownNode                            0001865A2D70 ModelClassType XmlNodeEventHandler XmlNodeEventHandler XmlNodeEventHandler Pointer
    public partial class XmlSerializer
    {
        public bool                                     CustomSerializer                        { get; set; }
        public XmlMapping?                              TypeMapping                             { get; set; }
        public SerializerData?                          SerializerData                          { get; set; }
        public UnreferencedObjectEventHandler?          OnUnreferencedObject                    { get; set; }
        public XmlAttributeEventHandler?                OnUnknownAttribute                      { get; set; }
        public XmlElementEventHandler?                  OnUnknownElement                        { get; set; }
        public XmlNodeEventHandler?                     OnUnknownNode                           { get; set; }

        public static XmlSerializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializer();

            value.CustomSerializer                          = GetBool(new IntPtr(p + 0x010)); // 0270D74C9F28 0x10 CustomSerializer            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TypeMapping                               = GetObject<XmlMapping>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlMapping.FromPointer); // 0270D74C9F48 0x18 TypeMapping                 ( 00018659F0F0 ModelClassType XmlMapping XmlMapping XmlMapping Pointer )
            value.SerializerData                            = GetObject<SerializerData>(new IntPtr(p + 0x020), ReversePrism.DataModels.SerializerData.FromPointer); // 0270D74C9F68 0x20 SerializerData              ( 00018673F200 ModelClassType SerializerData SerializerData SerializerData Pointer )
            value.OnUnreferencedObject                      = GetObject<UnreferencedObjectEventHandler>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnreferencedObjectEventHandler.FromPointer); // 0270D74C9FA8 0x28 OnUnreferencedObject        ( 000186736860 ModelClassType UnreferencedObjectEventHandler UnreferencedObjectEventHandler UnreferencedObjectEventHandler Pointer )
            value.OnUnknownAttribute                        = GetObject<XmlAttributeEventHandler>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlAttributeEventHandler.FromPointer); // 0270D74C9FC8 0x30 OnUnknownAttribute          ( 00018658A890 ModelClassType XmlAttributeEventHandler XmlAttributeEventHandler XmlAttributeEventHandler Pointer )
            value.OnUnknownElement                          = GetObject<XmlElementEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlElementEventHandler.FromPointer); // 0270D74C9FE8 0x38 OnUnknownElement            ( 000186598B00 ModelClassType XmlElementEventHandler XmlElementEventHandler XmlElementEventHandler Pointer )
            value.OnUnknownNode                             = GetObject<XmlNodeEventHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlNodeEventHandler.FromPointer); // 0270D74CA008 0x40 OnUnknownNode               ( 0001865A2D70 ModelClassType XmlNodeEventHandler XmlNodeEventHandler XmlNodeEventHandler Pointer )

            return value;
        }
    }
}
