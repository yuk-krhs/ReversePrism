using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Date                                     000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<LastUpdateDateStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LastUpdateDateTypeFieldNumber            int IL2CPP_TYPE_I4
    // 028 LastUpdateDateType                       00018677A280 ModelEnumType LastUpdateDateType LastUpdateDateType LastUpdateDateType Int32
    // 000 SubTypeFieldNumber                       int IL2CPP_TYPE_I4
    // 02C SubType                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DateFieldNumber                          int IL2CPP_TYPE_I4
    // 030 _Date                                    000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class LastUpdateDateStatus
    {
        public DateTime                                 Date                                    { get; set; }
        public LastUpdateDateType                       LastUpdateDateType                      { get; set; }
        public int                                      SubType                                 { get; set; }
        public Timestamp?                               _Date                                   { get; set; }

        public static LastUpdateDateStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LastUpdateDateStatus();

            value.Date                                      = GetDateTime(new IntPtr(p + 0x010)); // 0270D0B53678 0x10 Date                        ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.LastUpdateDateType                        = (LastUpdateDateType)GetInt32(new IntPtr(p + 0x028)); // 0270D0B536F8 0x28 LastUpdateDateType          ( 00018677A280 ModelEnumType LastUpdateDateType LastUpdateDateType LastUpdateDateType Int32 )
            value.SubType                                   = GetInt32(new IntPtr(p + 0x02C)); // 0270D0B53738 0x2C SubType                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._Date                                     = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0B53778 0x30 _Date                       ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Date                          = ToDateTime(value._Date);

            return value;
        }
    }
}
