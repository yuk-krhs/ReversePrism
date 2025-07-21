using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Idol                                     ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer
    // 018 CueName                                  ModelPrimitiveType string string string String
    public partial class FittingRoomViewModel : DataModel
    {
        public DressUpRoomIdol?                         Idol                                    { get; set; }
        public string                                   CueName                                 { get; set; }

        public static FittingRoomViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FittingRoomViewModel() { Pointer= p0 };

            value.Idol                                      = GetObject<DressUpRoomIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.DressUpRoomIdol.FromPointer); // 0x10 Idol                        ( ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer )
            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 0x18 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
