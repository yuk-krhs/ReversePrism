using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 factory                                  PopupViewFactory`1<ICostumeDetailPopupView> IL2CPP_TYPE_GENERICINST
    public partial class CostumeDetailPopupCallerImplement : DataModel
    {

        public static CostumeDetailPopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeDetailPopupCallerImplement() { Pointer= p0 };


            return value;
        }
    }
}
