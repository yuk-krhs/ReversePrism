using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SearchUserId                             ModelPrimitiveType string string string String
    // 028 LoginUserName                            ModelPrimitiveType string string string String
    // 030 FirstTimeDate                            ModelPrimitiveType long long long Int64
    // 038 ReleasableDate                           ModelPrimitiveType long long long Int64
    // 040 ConnectedStatus                          ModelPrimitiveType bool bool bool Bool
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

            value.SearchUserId                              = GetString(new IntPtr(p + 0x020)); // 0x20 SearchUserId                ( ModelPrimitiveType string string string String )
            value.LoginUserName                             = GetString(new IntPtr(p + 0x028)); // 0x28 LoginUserName               ( ModelPrimitiveType string string string String )
            value.FirstTimeDate                             = GetInt64(new IntPtr(p + 0x030)); // 0x30 FirstTimeDate               ( ModelPrimitiveType long long long Int64 )
            value.ReleasableDate                            = GetInt64(new IntPtr(p + 0x038)); // 0x38 ReleasableDate              ( ModelPrimitiveType long long long Int64 )
            value.ConnectedStatus                           = GetBool(new IntPtr(p + 0x040)); // 0x40 ConnectedStatus             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
