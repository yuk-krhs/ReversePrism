using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018659A020 ModelClassType FittingRoomView FittingRoomView FittingRoomView Pointer
    public partial class FittingRoomBuilder
    {
        public FittingRoomView?                         View                                    { get; set; }

        public static FittingRoomBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FittingRoomBuilder();

            value.View                                      = GetObject<FittingRoomView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FittingRoomView.FromPointer); // 0270DB615220 0x20 View                        ( 00018659A020 ModelClassType FittingRoomView FittingRoomView FittingRoomView Pointer )

            return value;
        }
    }
}
