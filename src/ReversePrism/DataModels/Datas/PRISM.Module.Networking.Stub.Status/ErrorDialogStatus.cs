using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaintenanceTime                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ErrorDialogStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 MessageFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Message                                  000186671910 ModelPrimitiveType string string string String
    // 000 ConnectionRetryCountFieldNumber          int IL2CPP_TYPE_I4
    // 038 ConnectionRetryCount                     0001865F7700 ModelPrimitiveType long long long Int64
    // 000 ButtonsFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_buttons_codec                  FieldCodec`1<ErrorButtonStatus> IL2CPP_TYPE_GENERICINST
    // 040 Buttons                                  000185CD5258 ModelClassListType RepeatedField`1<ErrorButtonStatus> RepeatedField`1<ErrorButtonStatus> List<ErrorButtonStatus> Pointer
    // 000 MaintenanceTimeFieldNumber               int IL2CPP_TYPE_I4
    // 048 _MaintenanceTime                         000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ErrorCodeFieldNumber                     int IL2CPP_TYPE_I4
    // 050 ErrorCode                                000186671910 ModelPrimitiveType string string string String
    public partial class ErrorDialogStatus : DataModel
    {
        public DateTime                                 MaintenanceTime                         { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Message                                 { get; set; }
        public long                                     ConnectionRetryCount                    { get; set; }
        public List<ErrorButtonStatus>?                 Buttons                                 { get; set; }
        public Timestamp?                               _MaintenanceTime                        { get; set; }
        public string                                   ErrorCode                               { get; set; }

        public static ErrorDialogStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorDialogStatus() { Pointer= p0 };

            value.MaintenanceTime                           = GetDateTime(new IntPtr(p + 0x010)); // 0246605D6288 0x10 MaintenanceTime             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Title                                     = GetString(new IntPtr(p + 0x028)); // 0246605D6308 0x28 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x030)); // 0246605D6348 0x30 Message                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ConnectionRetryCount                      = GetInt64(new IntPtr(p + 0x038)); // 0246605D6388 0x38 ConnectionRetryCount        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Buttons                                   = GetObjectList<ErrorButtonStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ErrorButtonStatus.FromPointer); // 0246605D63E8 0x40 Buttons                     ( 000185CD5258 ModelClassListType RepeatedField`1<ErrorButtonStatus> RepeatedField`1<ErrorButtonStatus> List<ErrorButtonStatus> Pointer )
            value._MaintenanceTime                          = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0246605D6428 0x48 _MaintenanceTime            ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ErrorCode                                 = GetString(new IntPtr(p + 0x050)); // 0246605D6468 0x50 ErrorCode                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MaintenanceTime               = ToDateTime(value._MaintenanceTime);

            return value;
        }
    }
}
