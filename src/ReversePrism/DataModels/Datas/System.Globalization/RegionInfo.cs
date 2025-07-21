using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 currentRegion                            RegionInfo IL2CPP_TYPE_CLASS
    // 010 RegionId                                 ModelPrimitiveType int int int Int32
    // 018 Iso2Name                                 ModelPrimitiveType string string string String
    // 020 Iso3Name                                 ModelPrimitiveType string string string String
    // 028 Win3Name                                 ModelPrimitiveType string string string String
    // 030 EnglishName                              ModelPrimitiveType string string string String
    // 038 NativeName                               ModelPrimitiveType string string string String
    // 040 CurrencySymbol                           ModelPrimitiveType string string string String
    // 048 IsoCurrencySymbol                        ModelPrimitiveType string string string String
    // 050 CurrencyEnglishName                      ModelPrimitiveType string string string String
    // 058 CurrencyNativeName                       ModelPrimitiveType string string string String
    public partial class RegionInfo : DataModel
    {
        public int                                      RegionId                                { get; set; }
        public string                                   Iso2Name                                { get; set; }
        public string                                   Iso3Name                                { get; set; }
        public string                                   Win3Name                                { get; set; }
        public string                                   EnglishName                             { get; set; }
        public string                                   NativeName                              { get; set; }
        public string                                   CurrencySymbol                          { get; set; }
        public string                                   IsoCurrencySymbol                       { get; set; }
        public string                                   CurrencyEnglishName                     { get; set; }
        public string                                   CurrencyNativeName                      { get; set; }

        public static RegionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegionInfo() { Pointer= p0 };

            value.RegionId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 RegionId                    ( ModelPrimitiveType int int int Int32 )
            value.Iso2Name                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Iso2Name                    ( ModelPrimitiveType string string string String )
            value.Iso3Name                                  = GetString(new IntPtr(p + 0x020)); // 0x20 Iso3Name                    ( ModelPrimitiveType string string string String )
            value.Win3Name                                  = GetString(new IntPtr(p + 0x028)); // 0x28 Win3Name                    ( ModelPrimitiveType string string string String )
            value.EnglishName                               = GetString(new IntPtr(p + 0x030)); // 0x30 EnglishName                 ( ModelPrimitiveType string string string String )
            value.NativeName                                = GetString(new IntPtr(p + 0x038)); // 0x38 NativeName                  ( ModelPrimitiveType string string string String )
            value.CurrencySymbol                            = GetString(new IntPtr(p + 0x040)); // 0x40 CurrencySymbol              ( ModelPrimitiveType string string string String )
            value.IsoCurrencySymbol                         = GetString(new IntPtr(p + 0x048)); // 0x48 IsoCurrencySymbol           ( ModelPrimitiveType string string string String )
            value.CurrencyEnglishName                       = GetString(new IntPtr(p + 0x050)); // 0x50 CurrencyEnglishName         ( ModelPrimitiveType string string string String )
            value.CurrencyNativeName                        = GetString(new IntPtr(p + 0x058)); // 0x58 CurrencyNativeName          ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
