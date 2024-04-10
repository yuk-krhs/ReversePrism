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
    public partial class LogoManager : DataModel
    {
        public Sprite?                                  Logo                                    { get; set; }

        public static LogoManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogoManager() { Pointer= p0 };

            value.Logo                                      = GetObject<Sprite>(new IntPtr(p + 0x010), ReversePrism.DataModels.Sprite.FromPointer); // 02466B4E7218 0x10 Logo                        ( 00018666BB10 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}
