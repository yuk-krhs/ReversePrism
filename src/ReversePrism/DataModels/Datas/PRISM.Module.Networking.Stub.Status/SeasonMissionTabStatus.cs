using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastDisplayDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SeasonMissionTabStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ReceivableCountFieldNumber               int IL2CPP_TYPE_I4
    // 028 ReceivableCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 02C IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 LastDisplayDateFieldNumber               int IL2CPP_TYPE_I4
    // 030 _LastDisplayDate                         000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class SeasonMissionTabStatus
    {
        public DateTime                                 LastDisplayDate                         { get; set; }
        public int                                      ReceivableCount                         { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public Timestamp?                               _LastDisplayDate                        { get; set; }

        public static SeasonMissionTabStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionTabStatus();

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x010)); // 0270D279C450 0x10 LastDisplayDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ReceivableCount                           = GetInt32(new IntPtr(p + 0x028)); // 0270D279C4D0 0x28 ReceivableCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x02C)); // 0270D279C510 0x2C IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._LastDisplayDate                          = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D279C550 0x30 _LastDisplayDate            ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LastDisplayDate               = ToDateTime(value._LastDisplayDate);

            return value;
        }
    }
}
