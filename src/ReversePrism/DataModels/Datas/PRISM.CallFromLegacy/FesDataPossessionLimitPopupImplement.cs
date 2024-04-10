using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  PopupViewFactory`1<IFesDataPossessionLimitPopupView> IL2CPP_TYPE_GENERICINST
    public partial class FesDataPossessionLimitPopupImplement : DataModel
    {

        public static FesDataPossessionLimitPopupImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesDataPossessionLimitPopupImplement() { Pointer= p0 };


            return value;
        }
    }
}
