using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 AccessKey                                000186671BA0 ModelPrimitiveType string string string String
    // 020 User                                     00018674B3F0 ModelClassType User User User Pointer
    // 000 OnUpdateSettings                         Action`1<HubSettings> IL2CPP_TYPE_GENERICINST
    // 000 API                                      string IL2CPP_TYPE_STRING
    // 000 Version                                  string IL2CPP_TYPE_STRING
    // 000 EditorBundle                             string IL2CPP_TYPE_STRING
    // 008 settings                                 HubSettings IL2CPP_TYPE_CLASS
    public partial class HubSettings
    {
        public string                                   AccessKey                               { get; set; }
        public User?                                    User                                    { get; set; }

        public static HubSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HubSettings();

            value.AccessKey                                 = GetString(new IntPtr(p + 0x018)); // 027003342158 0x18 AccessKey                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.User                                      = GetObject<User>(new IntPtr(p + 0x020), ReversePrism.DataModels.User.FromPointer); // 027003342178 0x20 User                        ( 00018674B3F0 ModelClassType User User User Pointer )

            return value;
        }
    }
}
