using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  IPopupViewFactory`1<IGashaDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 018 GashaDetailTabSave                       0001865F9920 ModelClassType GashaDetailsTabSave GashaDetailsTabSave GashaDetailsTabSave Pointer
    public partial class GashaDetailPopupSequencer
    {
        public GashaDetailsTabSave?                     GashaDetailTabSave                      { get; set; }

        public static GashaDetailPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailPopupSequencer();

            value.GashaDetailTabSave                        = GetObject<GashaDetailsTabSave>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaDetailsTabSave.FromPointer); // 0270D634E8A0 0x18 GashaDetailTabSave          ( 0001865F9920 ModelClassType GashaDetailsTabSave GashaDetailsTabSave GashaDetailsTabSave Pointer )

            return value;
        }
    }
}
