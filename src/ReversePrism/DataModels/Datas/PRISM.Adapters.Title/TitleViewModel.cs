using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AppVersion                               0001866736C0 ModelPrimitiveType string string string String
    // 018 UserData                                 0001865BC9A0 ModelClassType LoginUserData LoginUserData LoginUserData Pointer
    public partial class TitleViewModel
    {
        public string                                   AppVersion                              { get; set; }
        public LoginUserData?                           UserData                                { get; set; }

        public static TitleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleViewModel();

            value.AppVersion                                = GetString(new IntPtr(p + 0x010)); // 027004426948 0x10 AppVersion                  ( 0001866736C0 ModelPrimitiveType string string string String )
            value.UserData                                  = GetObject<LoginUserData>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoginUserData.FromPointer); // 027004426968 0x18 UserData                    ( 0001865BC9A0 ModelClassType LoginUserData LoginUserData LoginUserData Pointer )

            return value;
        }
    }
}
