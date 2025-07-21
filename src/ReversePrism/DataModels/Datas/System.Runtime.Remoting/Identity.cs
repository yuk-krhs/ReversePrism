using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectUri                                ModelPrimitiveType string string string String
    // 018 ChannelSink                              ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 020 EnvoySink                                ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 028 ClientDynamicProperties                  ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer
    // 030 ServerDynamicProperties                  ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer
    // 038 ObjRef                                   ModelClassType ObjRef ObjRef ObjRef Pointer
    // 040 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class Identity : DataModel
    {
        public string                                   ObjectUri                               { get; set; }
        public IMessageSink?                            ChannelSink                             { get; set; }
        public IMessageSink?                            EnvoySink                               { get; set; }
        public DynamicPropertyCollection?               ClientDynamicProperties                 { get; set; }
        public DynamicPropertyCollection?               ServerDynamicProperties                 { get; set; }
        public ObjRef?                                  ObjRef                                  { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static Identity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Identity() { Pointer= p0 };

            value.ObjectUri                                 = GetString(new IntPtr(p + 0x010)); // 0x10 ObjectUri                   ( ModelPrimitiveType string string string String )
            value.ChannelSink                               = GetObject<IMessageSink>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMessageSink.FromPointer); // 0x18 ChannelSink                 ( ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.EnvoySink                                 = GetObject<IMessageSink>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMessageSink.FromPointer); // 0x20 EnvoySink                   ( ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.ClientDynamicProperties                   = GetObject<DynamicPropertyCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.DynamicPropertyCollection.FromPointer); // 0x28 ClientDynamicProperties     ( ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer )
            value.ServerDynamicProperties                   = GetObject<DynamicPropertyCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.DynamicPropertyCollection.FromPointer); // 0x30 ServerDynamicProperties     ( ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer )
            value.ObjRef                                    = GetObject<ObjRef>(new IntPtr(p + 0x038), ReversePrism.DataModels.ObjRef.FromPointer); // 0x38 ObjRef                      ( ModelClassType ObjRef ObjRef ObjRef Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x040)); // 0x40 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
