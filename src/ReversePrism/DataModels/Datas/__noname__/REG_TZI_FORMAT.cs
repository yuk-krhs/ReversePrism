using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bias                                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 StandardBias                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 DaylightBias                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C StandardDate                             000186724AA0 ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32
    // 02C DaylightDate                             000186724AA0 ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32
    public partial class REG_TZI_FORMAT : DataModel
    {
        public int                                      Bias                                    { get; set; }
        public int                                      StandardBias                            { get; set; }
        public int                                      DaylightBias                            { get; set; }
        public SYSTEMTIME                               StandardDate                            { get; set; }
        public SYSTEMTIME                               DaylightDate                            { get; set; }

        public static REG_TZI_FORMAT? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new REG_TZI_FORMAT() { Pointer= p0 };

            value.Bias                                      = GetInt32(new IntPtr(p + 0x010)); // 0246669A0338 0x10 Bias                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.StandardBias                              = GetInt32(new IntPtr(p + 0x014)); // 0246669A0358 0x14 StandardBias                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.DaylightBias                              = GetInt32(new IntPtr(p + 0x018)); // 0246669A0378 0x18 DaylightBias                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.StandardDate                              = (SYSTEMTIME)GetInt32(new IntPtr(p + 0x01C)); // 0246669A0398 0x1C StandardDate                ( 000186724AA0 ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32 )
            value.DaylightDate                              = (SYSTEMTIME)GetInt32(new IntPtr(p + 0x02C)); // 0246669A03B8 0x2C DaylightDate                ( 000186724AA0 ModelEnumType SYSTEMTIME SYSTEMTIME SYSTEMTIME Int32 )

            return value;
        }
    }
}
