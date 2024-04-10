using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Popup                                    0001866741D0 ModelClassType ITitlePopupReference ITitlePopupReference ITitlePopupReference Pointer
    // 018 DeleteUserDataAction                     00018667A3C0 ModelClassType Action Action Action Pointer
    public partial class TitleMenuPresenter : DataModel
    {
        public ITitlePopupReference?                    Popup                                   { get; set; }
        public Action?                                  DeleteUserDataAction                    { get; set; }

        public static TitleMenuPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleMenuPresenter() { Pointer= p0 };

            value.Popup                                     = GetObject<ITitlePopupReference>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITitlePopupReference.FromPointer); // 0245A44A9860 0x10 Popup                       ( 0001866741D0 ModelClassType ITitlePopupReference ITitlePopupReference ITitlePopupReference Pointer )
            value.DeleteUserDataAction                      = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0245A44A9880 0x18 DeleteUserDataAction        ( 00018667A3C0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
