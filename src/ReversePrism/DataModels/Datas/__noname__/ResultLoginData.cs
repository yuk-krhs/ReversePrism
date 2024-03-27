using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ErrorMessage                             0001866722E0 ModelPrimitiveType string string string String
    // 018 AccessToken                              0001866722E0 ModelPrimitiveType string string string String
    // 020 OpenId                                   0001866722E0 ModelPrimitiveType string string string String
    public partial class ResultLoginData
    {
        public string                                   ErrorMessage                            { get; set; }
        public string                                   AccessToken                             { get; set; }
        public string                                   OpenId                                  { get; set; }

        public static ResultLoginData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResultLoginData();

            value.ErrorMessage                              = GetString(new IntPtr(p + 0x010)); // 0270DB4813C0 0x10 ErrorMessage                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AccessToken                               = GetString(new IntPtr(p + 0x018)); // 0270DB4813E0 0x18 AccessToken                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.OpenId                                    = GetString(new IntPtr(p + 0x020)); // 0270DB481400 0x20 OpenId                      ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
