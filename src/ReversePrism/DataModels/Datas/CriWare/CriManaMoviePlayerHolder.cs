using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Player                                   ModelClassType Player Player Player Pointer
    public partial class CriManaMoviePlayerHolder : DataModel
    {
        public Player?                                  Player                                  { get; set; }

        public static CriManaMoviePlayerHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaMoviePlayerHolder() { Pointer= p0 };

            value.Player                                    = GetObject<Player>(new IntPtr(p + 0x030), ReversePrism.DataModels.Player.FromPointer); // 0x30 Player                      ( ModelClassType Player Player Player Pointer )

            return value;
        }
    }
}
