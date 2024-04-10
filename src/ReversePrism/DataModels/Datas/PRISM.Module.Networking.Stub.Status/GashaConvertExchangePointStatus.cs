using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaConvertExchangePointStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaExchangeIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 GashaExchangeId                          000186671910 ModelPrimitiveType string string string String
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Point                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 028 Product                                  0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 030 ResourceId                               000186671910 ModelPrimitiveType string string string String
    // 000 BannerUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 038 BannerUrl                                000186671910 ModelPrimitiveType string string string String
    public partial class GashaConvertExchangePointStatus : DataModel
    {
        public string                                   GashaExchangeId                         { get; set; }
        public int                                      Point                                   { get; set; }
        public ProductWithAmountStatus?                 Product                                 { get; set; }
        public string                                   ResourceId                              { get; set; }
        public string                                   BannerUrl                               { get; set; }

        public static GashaConvertExchangePointStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaConvertExchangePointStatus() { Pointer= p0 };

            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x018)); // 024661524860 0x18 GashaExchangeId             ( 000186671910 ModelPrimitiveType string string string String )
            value.Point                                     = GetInt32(new IntPtr(p + 0x020)); // 0246615248A0 0x20 Point                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0246615248E0 0x28 Product                     ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.ResourceId                                = GetString(new IntPtr(p + 0x030)); // 024661524920 0x30 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x038)); // 024661524960 0x38 BannerUrl                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
