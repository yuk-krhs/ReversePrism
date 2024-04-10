using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  Func`1<IMessage> IL2CPP_TYPE_GENERICINST
    // 018 DiscardUnknownFields                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 Extensions                               000186532D90 ModelClassType ExtensionRegistry ExtensionRegistry ExtensionRegistry Pointer
    public partial class MessageParser : DataModel
    {
        public bool                                     DiscardUnknownFields                    { get; set; }
        public ExtensionRegistry?                       Extensions                              { get; set; }

        public static MessageParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageParser() { Pointer= p0 };

            value.DiscardUnknownFields                      = GetBool(new IntPtr(p + 0x018)); // 024660B256F0 0x18 DiscardUnknownFields        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Extensions                                = GetObject<ExtensionRegistry>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExtensionRegistry.FromPointer); // 024660B25710 0x20 Extensions                  ( 000186532D90 ModelClassType ExtensionRegistry ExtensionRegistry ExtensionRegistry Pointer )

            return value;
        }
    }
}
