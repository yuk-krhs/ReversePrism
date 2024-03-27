using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectUri                                000186671E00 ModelPrimitiveType string string string String
    // 018 ChannelSink                              0001865B0D10 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 020 EnvoySink                                0001865B0D10 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 028 ClientDynamicProperties                  000186710E70 ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer
    // 030 ServerDynamicProperties                  000186710E70 ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer
    // 038 ObjRef                                   0001866C5960 ModelClassType ObjRef ObjRef ObjRef Pointer
    // 040 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Identity
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
            var value   = new Identity();

            value.ObjectUri                                 = GetString(new IntPtr(p + 0x010)); // 0270D6A67458 0x10 ObjectUri                   ( 000186671E00 ModelPrimitiveType string string string String )
            value.ChannelSink                               = GetObject<IMessageSink>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMessageSink.FromPointer); // 0270D6A67478 0x18 ChannelSink                 ( 0001865B0D10 ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.EnvoySink                                 = GetObject<IMessageSink>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMessageSink.FromPointer); // 0270D6A67498 0x20 EnvoySink                   ( 0001865B0D10 ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.ClientDynamicProperties                   = GetObject<DynamicPropertyCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.DynamicPropertyCollection.FromPointer); // 0270D6A674B8 0x28 ClientDynamicProperties     ( 000186710E70 ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer )
            value.ServerDynamicProperties                   = GetObject<DynamicPropertyCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.DynamicPropertyCollection.FromPointer); // 0270D6A674D8 0x30 ServerDynamicProperties     ( 000186710E70 ModelClassType DynamicPropertyCollection DynamicPropertyCollection DynamicPropertyCollection Pointer )
            value.ObjRef                                    = GetObject<ObjRef>(new IntPtr(p + 0x038), ReversePrism.DataModels.ObjRef.FromPointer); // 0270D6A674F8 0x38 ObjRef                      ( 0001866C5960 ModelClassType ObjRef ObjRef ObjRef Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x040)); // 0270D6A67518 0x40 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
