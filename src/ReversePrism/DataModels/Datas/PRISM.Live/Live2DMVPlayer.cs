using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MoviePlayer                              000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer
    // 000 SyncTimeInterval                         float IL2CPP_TYPE_R4
    // 028 SyncTimeDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class Live2DMVPlayer
    {
        public MoviePlayer?                             MoviePlayer                             { get; set; }
        public IDisposable?                             SyncTimeDisposable                      { get; set; }

        public static Live2DMVPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Live2DMVPlayer();

            value.MoviePlayer                               = GetObject<MoviePlayer>(new IntPtr(p + 0x020), ReversePrism.DataModels.MoviePlayer.FromPointer); // 0270D4E2D9C8 0x20 MoviePlayer                 ( 000186658A40 ModelClassType MoviePlayer MoviePlayer MoviePlayer Pointer )
            value.SyncTimeDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D4E2DA08 0x28 SyncTimeDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
