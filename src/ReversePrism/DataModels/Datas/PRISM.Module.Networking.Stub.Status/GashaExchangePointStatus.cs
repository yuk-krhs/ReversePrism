using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GashaExchangePointStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaExchangeIdFieldNumber               int IL2CPP_TYPE_I4
    // 028 GashaExchangeId                          000186671910 ModelPrimitiveType string string string String
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Point                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 038 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 040 ResourceId                               000186671910 ModelPrimitiveType string string string String
    // 000 BannerUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 048 BannerUrl                                000186671910 ModelPrimitiveType string string string String
    public partial class GashaExchangePointStatus : DataModel
    {
        public DateTime                                 EndDate                                 { get; set; }
        public string                                   GashaExchangeId                         { get; set; }
        public int                                      Point                                   { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public string                                   ResourceId                              { get; set; }
        public string                                   BannerUrl                               { get; set; }

        public static GashaExchangePointStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangePointStatus() { Pointer= p0 };

            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x010)); // 024661528F08 0x10 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x028)); // 024661528F88 0x28 GashaExchangeId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Point                                     = GetInt32(new IntPtr(p + 0x030)); // 024661528FC8 0x30 Point                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 024661529008 0x38 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ResourceId                                = GetString(new IntPtr(p + 0x040)); // 024661529048 0x40 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x048)); // 024661529088 0x48 BannerUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
