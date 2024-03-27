using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DmmGamesLogo                             string IL2CPP_TYPE_STRING
    // 008 FanzaGamesLogo                           string IL2CPP_TYPE_STRING
    // 010 Logo                                     00018666BB10 ModelClassType Sprite Sprite Sprite Pointer
    public partial class LogoManager
    {
        public Sprite?                                  Logo                                    { get; set; }

        public static LogoManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogoManager();

            value.Logo                                      = GetObject<Sprite>(new IntPtr(p + 0x010), ReversePrism.DataModels.Sprite.FromPointer); // 0270DB45A228 0x10 Logo                        ( 00018666BB10 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
