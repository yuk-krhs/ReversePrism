using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Playback                                 000186648460 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 014 IsStopping                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BgmPlayInfo : DataModel
    {
        public CriAtomExPlayback                        Playback                                { get; set; }
        public bool                                     IsStopping                              { get; set; }

        public static BgmPlayInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BgmPlayInfo() { Pointer= p0 };

            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x010)); // 024661956DB8 0x10 Playback                    ( 000186648460 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.IsStopping                                = GetBool(new IntPtr(p + 0x014)); // 024661956DD8 0x14 IsStopping                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
