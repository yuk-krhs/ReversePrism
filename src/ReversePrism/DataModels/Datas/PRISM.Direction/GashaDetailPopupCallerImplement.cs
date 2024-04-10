using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 factory                                  PopupViewFactory`1<IGashaDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 028 Sequencer                                0001865F8660 ModelClassType GashaDetailPopupSequencer GashaDetailPopupSequencer GashaDetailPopupSequencer Pointer
    public partial class GashaDetailPopupCallerImplement : DataModel
    {
        public GashaDetailPopupSequencer?               Sequencer                               { get; set; }

        public static GashaDetailPopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailPopupCallerImplement() { Pointer= p0 };

            value.Sequencer                                 = GetObject<GashaDetailPopupSequencer>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaDetailPopupSequencer.FromPointer); // 02466BA41888 0x28 Sequencer                   ( 0001865F8660 ModelClassType GashaDetailPopupSequencer GashaDetailPopupSequencer GashaDetailPopupSequencer Pointer )

            return value;
        }
    }
}
