using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 factory                                  PopupViewFactory`1<IGashaCostumePopupView> IL2CPP_TYPE_GENERICINST
    // 028 Sequencer                                0001865F5E90 ModelClassType GashaCostumePopupSequencer GashaCostumePopupSequencer GashaCostumePopupSequencer Pointer
    public partial class GashaCostumePopupCallerImplement
    {
        public GashaCostumePopupSequencer?              Sequencer                               { get; set; }

        public static GashaCostumePopupCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaCostumePopupCallerImplement();

            value.Sequencer                                 = GetObject<GashaCostumePopupSequencer>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaCostumePopupSequencer.FromPointer); // 0270DB9C4DB0 0x28 Sequencer                   ( 0001865F5E90 ModelClassType GashaCostumePopupSequencer GashaCostumePopupSequencer GashaCostumePopupSequencer Pointer )

            return value;
        }
    }
}
