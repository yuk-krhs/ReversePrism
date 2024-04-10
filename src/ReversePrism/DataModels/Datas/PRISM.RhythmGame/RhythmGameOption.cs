using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Basic                                    0001866865C0 ModelClassType RhythmGameOptionBasic RhythmGameOptionBasic RhythmGameOptionBasic Pointer
    // 028 Detail                                   0001866873E0 ModelClassType RhythmGameOptionDetail RhythmGameOptionDetail RhythmGameOptionDetail Pointer
    // 030 Sound                                    000186689080 ModelClassType RhythmGameOptionSound RhythmGameOptionSound RhythmGameOptionSound Pointer
    public partial class RhythmGameOption : DataModel
    {
        public RhythmGameOptionBasic?                   Basic                                   { get; set; }
        public RhythmGameOptionDetail?                  Detail                                  { get; set; }
        public RhythmGameOptionSound?                   Sound                                   { get; set; }

        public static RhythmGameOption? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameOption() { Pointer= p0 };

            value.Basic                                     = GetObject<RhythmGameOptionBasic>(new IntPtr(p + 0x020), ReversePrism.DataModels.RhythmGameOptionBasic.FromPointer); // 0245A3A884B8 0x20 Basic                       ( 0001866865C0 ModelClassType RhythmGameOptionBasic RhythmGameOptionBasic RhythmGameOptionBasic Pointer )
            value.Detail                                    = GetObject<RhythmGameOptionDetail>(new IntPtr(p + 0x028), ReversePrism.DataModels.RhythmGameOptionDetail.FromPointer); // 0245A3A884D8 0x28 Detail                      ( 0001866873E0 ModelClassType RhythmGameOptionDetail RhythmGameOptionDetail RhythmGameOptionDetail Pointer )
            value.Sound                                     = GetObject<RhythmGameOptionSound>(new IntPtr(p + 0x030), ReversePrism.DataModels.RhythmGameOptionSound.FromPointer); // 0245A3A884F8 0x30 Sound                       ( 000186689080 ModelClassType RhythmGameOptionSound RhythmGameOptionSound RhythmGameOptionSound Pointer )

            return value;
        }
    }
}
