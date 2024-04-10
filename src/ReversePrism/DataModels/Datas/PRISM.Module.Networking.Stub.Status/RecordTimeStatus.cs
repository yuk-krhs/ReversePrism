using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Time                                     000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<RecordTimeStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 KindFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Kind                                     000186671910 ModelPrimitiveType string string string String
    // 000 TimeFieldNumber                          int IL2CPP_TYPE_I4
    // 030 _Time                                    000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class RecordTimeStatus : DataModel
    {
        public DateTime                                 Time                                    { get; set; }
        public string                                   Kind                                    { get; set; }
        public Timestamp?                               _Time                                   { get; set; }

        public static RecordTimeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RecordTimeStatus() { Pointer= p0 };

            value.Time                                      = GetDateTime(new IntPtr(p + 0x010)); // 024660D5EF20 0x10 Time                        ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Kind                                      = GetString(new IntPtr(p + 0x028)); // 024660D5EFA0 0x28 Kind                        ( 000186671910 ModelPrimitiveType string string string String )
            value._Time                                     = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 024660D5EFE0 0x30 _Time                       ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Time                          = ToDateTime(value._Time);

            return value;
        }
    }
}
