using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FullRecoverDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<StaminaStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StaminaTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 028 StaminaType                              00018656BC30 ModelEnumType StaminaType StaminaType StaminaType Int32
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Value                                    00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 FullRecoverDateFieldNumber               int IL2CPP_TYPE_I4
    // 038 _FullRecoverDate                         000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 AutoRecoverIntervalFieldNumber           int IL2CPP_TYPE_I4
    // 040 AutoRecoverInterval                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StaminaStatus : DataModel
    {
        public DateTime                                 FullRecoverDate                         { get; set; }
        public StaminaType                              StaminaType                             { get; set; }
        public LimitedValueStatus?                      Value                                   { get; set; }
        public Timestamp?                               _FullRecoverDate                        { get; set; }
        public int                                      AutoRecoverInterval                     { get; set; }

        public static StaminaStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaStatus() { Pointer= p0 };

            value.FullRecoverDate                           = GetDateTime(new IntPtr(p + 0x010)); // 0246621AFF00 0x10 FullRecoverDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.StaminaType                               = (StaminaType)GetInt32(new IntPtr(p + 0x028)); // 0246621AFF80 0x28 StaminaType                 ( 00018656BC30 ModelEnumType StaminaType StaminaType StaminaType Int32 )
            value.Value                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0246621AFFC0 0x30 Value                       ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value._FullRecoverDate                          = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0246621B0000 0x38 _FullRecoverDate            ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.AutoRecoverInterval                       = GetInt32(new IntPtr(p + 0x040)); // 0246621B0040 0x40 AutoRecoverInterval         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FullRecoverDate               = ToDateTime(value._FullRecoverDate);

            return value;
        }
    }
}
