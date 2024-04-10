using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bias                                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 StandardName                             0001865AF9C0 ModelEnumType <StandardName>e__FixedBuffer <StandardName>e__FixedBuffer <StandardName>e__FixedBuffer Int32
    // 054 StandardDate                             000186724AA0 ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32
    // 064 StandardBias                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 068 DaylightName                             0001865AF4C0 ModelEnumType <DaylightName>e__FixedBuffer <DaylightName>e__FixedBuffer <DaylightName>e__FixedBuffer Int32
    // 0A8 DaylightDate                             000186724AA0 ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32
    // 0B8 DaylightBias                             0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class TIME_ZONE_INFORMATION : DataModel
    {
        public int                                      Bias                                    { get; set; }
        public <StandardName>e__FixedBuffer             StandardName                            { get; set; }
        public SYSTEMTIME                               StandardDate                            { get; set; }
        public int                                      StandardBias                            { get; set; }
        public <DaylightName>e__FixedBuffer             DaylightName                            { get; set; }
        public SYSTEMTIME                               DaylightDate                            { get; set; }
        public int                                      DaylightBias                            { get; set; }

        public static TIME_ZONE_INFORMATION? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TIME_ZONE_INFORMATION() { Pointer= p0 };

            value.Bias                                      = GetInt32(new IntPtr(p + 0x010)); // 0246669A06D0 0x10 Bias                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.StandardName                              = (<StandardName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x014)); // 0246669A06F0 0x14 StandardName                ( 0001865AF9C0 ModelEnumType <StandardName>e__FixedBuffer <StandardName>e__FixedBuffer <StandardName>e__FixedBuffer Int32 )
            value.StandardDate                              = (SYSTEMTIME)GetInt32(new IntPtr(p + 0x054)); // 0246669A0710 0x54 StandardDate                ( 000186724AA0 ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32 )
            value.StandardBias                              = GetInt32(new IntPtr(p + 0x064)); // 0246669A0730 0x64 StandardBias                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DaylightName                              = (<DaylightName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x068)); // 0246669A0750 0x68 DaylightName                ( 0001865AF4C0 ModelEnumType <DaylightName>e__FixedBuffer <DaylightName>e__FixedBuffer <DaylightName>e__FixedBuffer Int32 )
            value.DaylightDate                              = (SYSTEMTIME)GetInt32(new IntPtr(p + 0x0A8)); // 0246669A0770 0xA8 DaylightDate                ( 000186724AA0 ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32 )
            value.DaylightBias                              = GetInt32(new IntPtr(p + 0x0B8)); // 0246669A0790 0xB8 DaylightBias                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
