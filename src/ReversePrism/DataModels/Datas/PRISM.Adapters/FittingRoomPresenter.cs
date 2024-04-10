using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865169B0 ModelClassType IFittingRoomView IFittingRoomView IFittingRoomView Pointer
    // 018 Argument                                 000186599120 ModelClassType FittingRoomArgument FittingRoomArgument FittingRoomArgument Pointer
    // 020 Model                                    00018659A770 ModelClassType FittingRoomViewModel FittingRoomViewModel FittingRoomViewModel Pointer
    public partial class FittingRoomPresenter : DataModel
    {
        public IFittingRoomView?                        View                                    { get; set; }
        public FittingRoomArgument?                     Argument                                { get; set; }
        public FittingRoomViewModel?                    Model                                   { get; set; }

        public static FittingRoomPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FittingRoomPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IFittingRoomView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFittingRoomView.FromPointer); // 0246662D49F8 0x10 View                        ( 0001865169B0 ModelClassType IFittingRoomView IFittingRoomView IFittingRoomView Pointer )
            value.Argument                                  = GetObject<FittingRoomArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.FittingRoomArgument.FromPointer); // 0246662D4A18 0x18 Argument                    ( 000186599120 ModelClassType FittingRoomArgument FittingRoomArgument FittingRoomArgument Pointer )
            value.Model                                     = GetObject<FittingRoomViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.FittingRoomViewModel.FromPointer); // 0246662D4A38 0x20 Model                       ( 00018659A770 ModelClassType FittingRoomViewModel FittingRoomViewModel FittingRoomViewModel Pointer )

            return value;
        }
    }
}
