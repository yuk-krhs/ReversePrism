using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<QuotaLimit> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 020 Description                              ModelPrimitiveType string string string String
    // 000 DefaultLimitFieldNumber                  int IL2CPP_TYPE_I4
    // 028 DefaultLimit                             ModelPrimitiveType long long long Int64
    // 000 MaxLimitFieldNumber                      int IL2CPP_TYPE_I4
    // 030 MaxLimit                                 ModelPrimitiveType long long long Int64
    // 000 FreeTierFieldNumber                      int IL2CPP_TYPE_I4
    // 038 FreeTier                                 ModelPrimitiveType long long long Int64
    // 000 DurationFieldNumber                      int IL2CPP_TYPE_I4
    // 040 Duration                                 ModelPrimitiveType string string string String
    // 000 MetricFieldNumber                        int IL2CPP_TYPE_I4
    // 048 Metric                                   ModelPrimitiveType string string string String
    // 000 UnitFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Unit                                     ModelPrimitiveType string string string String
    // 000 ValuesFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _map_values_codec                        Codec<string, long> IL2CPP_TYPE_GENERICINST
    // 058 values_                                  MapField`2<string, long> IL2CPP_TYPE_GENERICINST
    // 000 DisplayNameFieldNumber                   int IL2CPP_TYPE_I4
    // 060 DisplayName                              ModelPrimitiveType string string string String
    public partial class QuotaLimit : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Description                             { get; set; }
        public long                                     DefaultLimit                            { get; set; }
        public long                                     MaxLimit                                { get; set; }
        public long                                     FreeTier                                { get; set; }
        public string                                   Duration                                { get; set; }
        public string                                   Metric                                  { get; set; }
        public string                                   Unit                                    { get; set; }
        public string                                   DisplayName                             { get; set; }

        public static QuotaLimit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuotaLimit() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 0x20 Description                 ( ModelPrimitiveType string string string String )
            value.DefaultLimit                              = GetInt64(new IntPtr(p + 0x028)); // 0x28 DefaultLimit                ( ModelPrimitiveType long long long Int64 )
            value.MaxLimit                                  = GetInt64(new IntPtr(p + 0x030)); // 0x30 MaxLimit                    ( ModelPrimitiveType long long long Int64 )
            value.FreeTier                                  = GetInt64(new IntPtr(p + 0x038)); // 0x38 FreeTier                    ( ModelPrimitiveType long long long Int64 )
            value.Duration                                  = GetString(new IntPtr(p + 0x040)); // 0x40 Duration                    ( ModelPrimitiveType string string string String )
            value.Metric                                    = GetString(new IntPtr(p + 0x048)); // 0x48 Metric                      ( ModelPrimitiveType string string string String )
            value.Unit                                      = GetString(new IntPtr(p + 0x050)); // 0x50 Unit                        ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x060)); // 0x60 DisplayName                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
