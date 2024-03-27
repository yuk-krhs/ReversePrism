using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Date                                     000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ExpireDateStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DateFieldNumber                          int IL2CPP_TYPE_I4
    // 028 _Date                                    000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Amount                                   0001865F7700 ModelPrimitiveType long long long Int64
    public partial class ExpireDateStatus
    {
        public DateTime                                 Date                                    { get; set; }
        public Timestamp?                               _Date                                   { get; set; }
        public long                                     Amount                                  { get; set; }

        public static ExpireDateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpireDateStatus();

            value.Date                                      = GetDateTime(new IntPtr(p + 0x010)); // 0270D0F5DFE8 0x10 Date                        ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value._Date                                     = GetObject<Timestamp>(new IntPtr(p + 0x028), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0F5E068 0x28 _Date                       ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Amount                                    = GetInt64(new IntPtr(p + 0x030)); // 0270D0F5E0A8 0x30 Amount                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Date                          = ToDateTime(value._Date);

            return value;
        }
    }
}
