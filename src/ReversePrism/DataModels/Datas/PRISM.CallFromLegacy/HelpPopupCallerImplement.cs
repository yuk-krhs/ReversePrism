using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 factory                                  PopupViewFactory`1<IGameHelpListPopupView> IL2CPP_TYPE_GENERICINST
    public partial class HelpPopupCallerImplement
    {

        public static HelpPopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HelpPopupCallerImplement();


            return value;
        }
    }
}
