using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MonitoredResourceMetadata> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SystemLabelsFieldNumber                  int IL2CPP_TYPE_I4
    // 018 SystemLabels                             ModelClassType Struct Struct Struct Pointer
    // 000 UserLabelsFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _map_userLabels_codec                    Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 020 userLabels_                              MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class MonitoredResourceMetadata : DataModel
    {
        public Struct?                                  SystemLabels                            { get; set; }

        public static MonitoredResourceMetadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonitoredResourceMetadata() { Pointer= p0 };

            value.SystemLabels                              = GetObject<Struct>(new IntPtr(p + 0x018), ReversePrism.DataModels.Struct.FromPointer); // 0x18 SystemLabels                ( ModelClassType Struct Struct Struct Pointer )

            return value;
        }
    }
}
