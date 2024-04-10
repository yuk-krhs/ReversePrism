using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SearchUserId                             000186671910 ModelPrimitiveType string string string String
    // 028 LoginUserName                            000186671910 ModelPrimitiveType string string string String
    // 030 FirstTimeDate                            0001865F7700 ModelPrimitiveType long long long Int64
    // 038 ReleasableDate                           0001865F7700 ModelPrimitiveType long long long Int64
    // 040 ConnectedStatus                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NonLoginUserData : DataModel
    {
        public string                                   SearchUserId                            { get; set; }
        public string                                   LoginUserName                           { get; set; }
        public long                                     FirstTimeDate                           { get; set; }
        public long                                     ReleasableDate                          { get; set; }
        public bool                                     ConnectedStatus                         { get; set; }

        public static NonLoginUserData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NonLoginUserData() { Pointer= p0 };

            value.SearchUserId                              = GetString(new IntPtr(p + 0x020)); // 0245A3A7F6D0 0x20 SearchUserId                ( 000186671910 ModelPrimitiveType string string string String )
            value.LoginUserName                             = GetString(new IntPtr(p + 0x028)); // 0245A3A7F6F0 0x28 LoginUserName               ( 000186671910 ModelPrimitiveType string string string String )
            value.FirstTimeDate                             = GetInt64(new IntPtr(p + 0x030)); // 0245A3A7F710 0x30 FirstTimeDate               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ReleasableDate                            = GetInt64(new IntPtr(p + 0x038)); // 0245A3A7F730 0x38 ReleasableDate              ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.ConnectedStatus                           = GetBool(new IntPtr(p + 0x040)); // 0245A3A7F750 0x40 ConnectedStatus             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
