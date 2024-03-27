using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<MedalGashaStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 038 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstMedalGashaIdFieldNumber               int IL2CPP_TYPE_I4
    // 03C MstMedalGashaId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 048 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PriceListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_priceList_codec                FieldCodec`1<GashaPriceStatus> IL2CPP_TYPE_GENERICINST
    // 050 PriceList                                000185CDBF68 ModelClassListType RepeatedField`1<GashaPriceStatus> RepeatedField`1<GashaPriceStatus> List<GashaPriceStatus> Pointer
    // 000 BoxCountFieldNumber                      int IL2CPP_TYPE_I4
    // 058 BoxCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsLockEnabledFieldNumber                 int IL2CPP_TYPE_I4
    // 05C IsLockEnabled                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class MedalGashaStatus
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstEventId                              { get; set; }
        public int                                      MstMedalGashaId                         { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public List<GashaPriceStatus>?                  PriceList                               { get; set; }
        public int                                      BoxCount                                { get; set; }
        public bool                                     IsLockEnabled                           { get; set; }

        public static MedalGashaStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaStatus();

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0270D229D860 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D229D880 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x038)); // 0270D229D900 0x38 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstMedalGashaId                           = GetInt32(new IntPtr(p + 0x03C)); // 0270D229D940 0x3C MstMedalGashaId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D229D980 0x40 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D229D9C0 0x48 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PriceList                                 = GetObjectList<GashaPriceStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.GashaPriceStatus.FromPointer); // 0270D229DA20 0x50 PriceList                   ( 000185CDBF68 ModelClassListType RepeatedField`1<GashaPriceStatus> RepeatedField`1<GashaPriceStatus> List<GashaPriceStatus> Pointer )
            value.BoxCount                                  = GetInt32(new IntPtr(p + 0x058)); // 0270D229DA60 0x58 BoxCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsLockEnabled                             = GetBool(new IntPtr(p + 0x05C)); // 0270D229DAA0 0x5C IsLockEnabled               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
