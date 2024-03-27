using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    000186665030 ModelClassType ADVLogModel ADVLogModel ADVLogModel Pointer
    // 018 ViewModel                                000186666890 ModelClassType ADVLogOverlayViewModel ADVLogOverlayViewModel ADVLogOverlayViewModel Pointer
    public partial class ADVLogOverlayPresenter
    {
        public ADVLogModel?                             Model                                   { get; set; }
        public ADVLogOverlayViewModel?                  ViewModel                               { get; set; }

        public static ADVLogOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogOverlayPresenter();

            value.Model                                     = GetObject<ADVLogModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ADVLogModel.FromPointer); // 0270D6919748 0x10 Model                       ( 000186665030 ModelClassType ADVLogModel ADVLogModel ADVLogModel Pointer )
            value.ViewModel                                 = GetObject<ADVLogOverlayViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ADVLogOverlayViewModel.FromPointer); // 0270D6919768 0x18 ViewModel                   ( 000186666890 ModelClassType ADVLogOverlayViewModel ADVLogOverlayViewModel ADVLogOverlayViewModel Pointer )

            return value;
        }
    }
}
