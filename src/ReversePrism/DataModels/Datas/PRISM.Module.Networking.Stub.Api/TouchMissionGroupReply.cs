using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LastDisplayDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<TouchMissionGroupReply> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LastDisplayDateFieldNumber               int IL2CPP_TYPE_I4
    // 028 _LastDisplayDate                         000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class TouchMissionGroupReply
    {
        public DateTime                                 LastDisplayDate                         { get; set; }
        public Timestamp?                               _LastDisplayDate                        { get; set; }

        public static TouchMissionGroupReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchMissionGroupReply();

            value.LastDisplayDate                           = GetDateTime(new IntPtr(p + 0x010)); // 0270D22EB0B8 0x10 LastDisplayDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value._LastDisplayDate                          = GetObject<Timestamp>(new IntPtr(p + 0x028), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D22EB138 0x28 _LastDisplayDate            ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.LastDisplayDate               = ToDateTime(value._LastDisplayDate);

            return value;
        }
    }
}
