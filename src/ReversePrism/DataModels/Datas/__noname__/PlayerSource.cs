using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Player                                   ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 018 Source3d                                 ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer
    public partial class PlayerSource : DataModel
    {
        public CriAtomExPlayer?                         Player                                  { get; set; }
        public CriAtomEx3dSource?                       Source3d                                { get; set; }

        public static PlayerSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerSource() { Pointer= p0 };

            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x010), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x10 Player                      ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.Source3d                                  = GetObject<CriAtomEx3dSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CriAtomEx3dSource.FromPointer); // 0x18 Source3d                    ( ModelClassType CriAtomEx3dSource CriAtomEx3dSource CriAtomEx3dSource Pointer )

            return value;
        }
    }
}
