using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MonitoredResource> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Type                                     000186671910 ModelPrimitiveType string string string String
    // 000 LabelsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _map_labels_codec                        Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 020 labels_                                  MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class MonitoredResource : DataModel
    {
        public string                                   Type                                    { get; set; }

        public static MonitoredResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonitoredResource() { Pointer= p0 };

            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 02466A866BE8 0x18 Type                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
