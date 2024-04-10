using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  IPopupViewFactory`1<IRegisterBirthDayPopupView> IL2CPP_TYPE_GENERICINST
    public partial class RegisterBirthDayPopupSequencer : DataModel
    {

        public static RegisterBirthDayPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterBirthDayPopupSequencer() { Pointer= p0 };


            return value;
        }
    }
}
