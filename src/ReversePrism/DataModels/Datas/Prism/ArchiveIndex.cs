using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ArchiveIndex> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StreamingIdFieldNumber                   int IL2CPP_TYPE_I4
    // 018 StreamingId                              000186671910 ModelPrimitiveType string string string String
    // 000 ArchiveIndexUrlFieldNumber               int IL2CPP_TYPE_I4
    // 020 ArchiveIndexUrl                          000186671910 ModelPrimitiveType string string string String
    // 000 CreatedAtFieldNumber                     int IL2CPP_TYPE_I4
    // 028 _CreatedAt                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class ArchiveIndex : DataModel
    {
        public string                                   StreamingId                             { get; set; }
        public string                                   ArchiveIndexUrl                         { get; set; }
        public Timestamp?                               _CreatedAt                              { get; set; }

        public static ArchiveIndex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArchiveIndex() { Pointer= p0 };

            value.StreamingId                               = GetString(new IntPtr(p + 0x018)); // 024664BE8D20 0x18 StreamingId                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ArchiveIndexUrl                           = GetString(new IntPtr(p + 0x020)); // 024664BE8D60 0x20 ArchiveIndexUrl             ( 000186671910 ModelPrimitiveType string string string String )
            value._CreatedAt                                = GetObject<Timestamp>(new IntPtr(p + 0x028), ReversePrism.DataModels.Timestamp.FromPointer); // 024664BE8DA0 0x28 _CreatedAt                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )

            return value;
        }
    }
}
