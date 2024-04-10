using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class ProduceSupportCharacterEditConfirmPopupViewFactory : DataModel
    {

        public static ProduceSupportCharacterEditConfirmPopupViewFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSupportCharacterEditConfirmPopupViewFactory() { Pointer= p0 };


            return value;
        }
    }
}
