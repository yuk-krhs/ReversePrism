using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 puFactory                                IPopupViewFactory`1<IEditUnitNamePopupView> IL2CPP_TYPE_GENERICINST
    public partial class EditUnitNamePopupSequencer : DataModel
    {

        public static EditUnitNamePopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditUnitNamePopupSequencer() { Pointer= p0 };


            return value;
        }
    }
}
