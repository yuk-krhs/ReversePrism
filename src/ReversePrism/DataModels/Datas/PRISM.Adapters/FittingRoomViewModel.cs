using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Idol                                     000186701120 ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer
    // 018 CueName                                  000186671910 ModelPrimitiveType string string string String
    public partial class FittingRoomViewModel
    {
        public DressUpRoomIdol?                         Idol                                    { get; set; }
        public string                                   CueName                                 { get; set; }

        public static FittingRoomViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FittingRoomViewModel();

            value.Idol                                      = GetObject<DressUpRoomIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.DressUpRoomIdol.FromPointer); // 0270D6275388 0x10 Idol                        ( 000186701120 ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer )
            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 0270D62753A8 0x18 CueName                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
