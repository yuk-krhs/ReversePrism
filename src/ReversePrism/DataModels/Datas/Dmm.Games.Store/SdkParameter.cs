using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SdkCommand                               0001866722E0 ModelPrimitiveType string string string String
    // 018 Setting                                  0001866E6B70 ModelClassType DmmGamesStoreSdkSettings DmmGamesStoreSdkSettings DmmGamesStoreSdkSettings Pointer
    public partial class SdkParameter
    {
        public string                                   SdkCommand                              { get; set; }
        public DmmGamesStoreSdkSettings?                Setting                                 { get; set; }

        public static SdkParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SdkParameter();

            value.SdkCommand                                = GetString(new IntPtr(p + 0x010)); // 0270DB4A0DA8 0x10 SdkCommand                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Setting                                   = GetObject<DmmGamesStoreSdkSettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.DmmGamesStoreSdkSettings.FromPointer); // 0270DB4A0DC8 0x18 Setting                     ( 0001866E6B70 ModelClassType DmmGamesStoreSdkSettings DmmGamesStoreSdkSettings DmmGamesStoreSdkSettings Pointer )

            return value;
        }
    }
}
