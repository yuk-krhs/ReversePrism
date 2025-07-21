using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Adid                                     ModelPrimitiveType string string string String
    // 018 Message                                  ModelPrimitiveType string string string String
    // 020 Timestamp                                ModelPrimitiveType string string string String
    // 028 EventToken                               ModelPrimitiveType string string string String
    // 030 CallbackId                               ModelPrimitiveType string string string String
    // 038 <JsonResponse>k__BackingField            Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    public partial class AdjustEventSuccess : DataModel
    {
        public string                                   Adid                                    { get; set; }
        public string                                   Message                                 { get; set; }
        public string                                   Timestamp                               { get; set; }
        public string                                   EventToken                              { get; set; }
        public string                                   CallbackId                              { get; set; }

        public static AdjustEventSuccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustEventSuccess() { Pointer= p0 };

            value.Adid                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Adid                        ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Message                     ( ModelPrimitiveType string string string String )
            value.Timestamp                                 = GetString(new IntPtr(p + 0x020)); // 0x20 Timestamp                   ( ModelPrimitiveType string string string String )
            value.EventToken                                = GetString(new IntPtr(p + 0x028)); // 0x28 EventToken                  ( ModelPrimitiveType string string string String )
            value.CallbackId                                = GetString(new IntPtr(p + 0x030)); // 0x30 CallbackId                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
