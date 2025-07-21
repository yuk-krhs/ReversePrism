using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bias                                     ModelPrimitiveType int int int Int32
    // 014 StandardName                             ModelEnumType <StandardName>e__FixedBuffer <StandardName>e__FixedBuffer <StandardName>e__FixedBuffer Int32
    // 054 StandardDate                             ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32
    // 064 StandardBias                             ModelPrimitiveType int int int Int32
    // 068 DaylightName                             ModelEnumType <DaylightName>e__FixedBuffer <DaylightName>e__FixedBuffer <DaylightName>e__FixedBuffer Int32
    // 0A8 DaylightDate                             ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32
    // 0B8 DaylightBias                             ModelPrimitiveType int int int Int32
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

            value.Bias                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Bias                        ( ModelPrimitiveType int int int Int32 )
            value.StandardName                              = (<StandardName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x014)); // 0x14 StandardName                ( ModelEnumType <StandardName>e__FixedBuffer <StandardName>e__FixedBuffer <StandardName>e__FixedBuffer Int32 )
            value.StandardDate                              = (SYSTEMTIME)GetInt32(new IntPtr(p + 0x054)); // 0x54 StandardDate                ( ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32 )
            value.StandardBias                              = GetInt32(new IntPtr(p + 0x064)); // 0x64 StandardBias                ( ModelPrimitiveType int int int Int32 )
            value.DaylightName                              = (<DaylightName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x068)); // 0x68 DaylightName                ( ModelEnumType <DaylightName>e__FixedBuffer <DaylightName>e__FixedBuffer <DaylightName>e__FixedBuffer Int32 )
            value.DaylightDate                              = (SYSTEMTIME)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 DaylightDate                ( ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32 )
            value.DaylightBias                              = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 DaylightBias                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
