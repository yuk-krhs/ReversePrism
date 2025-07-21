using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  OverlayViewFactory`1<IAdvTextLogOverlayView> IL2CPP_TYPE_GENERICINST
    public partial class AdvTextLogOverlayCallerImplement : DataModel
    {

        public static AdvTextLogOverlayCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvTextLogOverlayCallerImplement() { Pointer= p0 };


            return value;
        }
    }
}
