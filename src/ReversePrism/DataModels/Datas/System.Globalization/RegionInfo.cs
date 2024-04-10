using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 currentRegion                            RegionInfo IL2CPP_TYPE_CLASS
    // 010 RegionId                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Iso2Name                                 000186671910 ModelPrimitiveType string string string String
    // 020 Iso3Name                                 000186671910 ModelPrimitiveType string string string String
    // 028 Win3Name                                 000186671910 ModelPrimitiveType string string string String
    // 030 EnglishName                              000186671910 ModelPrimitiveType string string string String
    // 038 NativeName                               000186671910 ModelPrimitiveType string string string String
    // 040 CurrencySymbol                           000186671910 ModelPrimitiveType string string string String
    // 048 IsoCurrencySymbol                        000186671910 ModelPrimitiveType string string string String
    // 050 CurrencyEnglishName                      000186671910 ModelPrimitiveType string string string String
    // 058 CurrencyNativeName                       000186671910 ModelPrimitiveType string string string String
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

            value.RegionId                                  = GetInt32(new IntPtr(p + 0x010)); // 024666D91970 0x10 RegionId                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Iso2Name                                  = GetString(new IntPtr(p + 0x018)); // 024666D91990 0x18 Iso2Name                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Iso3Name                                  = GetString(new IntPtr(p + 0x020)); // 024666D919B0 0x20 Iso3Name                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Win3Name                                  = GetString(new IntPtr(p + 0x028)); // 024666D919D0 0x28 Win3Name                    ( 000186671910 ModelPrimitiveType string string string String )
            value.EnglishName                               = GetString(new IntPtr(p + 0x030)); // 024666D919F0 0x30 EnglishName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.NativeName                                = GetString(new IntPtr(p + 0x038)); // 024666D91A10 0x38 NativeName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.CurrencySymbol                            = GetString(new IntPtr(p + 0x040)); // 024666D91A30 0x40 CurrencySymbol              ( 000186671910 ModelPrimitiveType string string string String )
            value.IsoCurrencySymbol                         = GetString(new IntPtr(p + 0x048)); // 024666D91A50 0x48 IsoCurrencySymbol           ( 000186671910 ModelPrimitiveType string string string String )
            value.CurrencyEnglishName                       = GetString(new IntPtr(p + 0x050)); // 024666D91A70 0x50 CurrencyEnglishName         ( 000186671910 ModelPrimitiveType string string string String )
            value.CurrencyNativeName                        = GetString(new IntPtr(p + 0x058)); // 024666D91A90 0x58 CurrencyNativeName          ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
