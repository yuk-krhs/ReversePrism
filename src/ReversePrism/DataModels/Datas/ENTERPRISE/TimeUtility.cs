using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 lastServerTime                           DateTime IL2CPP_TYPE_VALUETYPE
    // 008 startupTimeBySetServeTime_               DateTime IL2CPP_TYPE_VALUETYPE
    // 000 elapsedMiliSecThr_                       long IL2CPP_TYPE_I8
    // 010 BaseTime                                 0001865B9A10 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 FormatCheck                              00018663B620 ModelClassType Regex Regex Regex Pointer
    // 020 W3cDTFCheck                              00018663B620 ModelClassType Regex Regex Regex Pointer
    // 028 ExpiredTimeString                        Dictionary`2<NameType, string> IL2CPP_TYPE_GENERICINST
    // 030 ExpiredTimeStringKey                     Dictionary`2<NameType, string> IL2CPP_TYPE_GENERICINST
    // 038 LastLoginTimeStringKey                   Dictionary`2<LastLoginTimeType, string> IL2CPP_TYPE_GENERICINST
    public partial class TimeUtility
    {
        public DateTime                                 BaseTime                                { get; set; }
        public Regex?                                   FormatCheck                             { get; set; }
        public Regex?                                   W3cDTFCheck                             { get; set; }

        public static TimeUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeUtility();

            value.BaseTime                                  = GetDateTime(new IntPtr(p + 0x010)); // 027004B2C268 0x10 BaseTime                    ( 0001865B9A10 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.FormatCheck                               = GetObject<Regex>(new IntPtr(p + 0x018), ReversePrism.DataModels.Regex.FromPointer); // 027004B2C288 0x18 FormatCheck                 ( 00018663B620 ModelClassType Regex Regex Regex Pointer )
            value.W3cDTFCheck                               = GetObject<Regex>(new IntPtr(p + 0x020), ReversePrism.DataModels.Regex.FromPointer); // 027004B2C2A8 0x20 W3cDTFCheck                 ( 00018663B620 ModelClassType Regex Regex Regex Pointer )

            return value;
        }
    }
}
