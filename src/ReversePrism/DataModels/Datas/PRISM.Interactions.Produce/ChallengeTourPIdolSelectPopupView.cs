using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PIdolSelectGridView                      0001865765D0 ModelClassType ChallengeTourPIdolSelectGridView ChallengeTourPIdolSelectGridView ChallengeTourPIdolSelectGridView Pointer
    // 028 pIdoleDetailPopupFactory                 PopupViewFactory`1<IPIdolDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 030 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onCancel                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 PIdolIcons                               000185B99EC0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourPIdolSelectPopupView
    {
        public ChallengeTourPIdolSelectGridView?        PIdolSelectGridView                     { get; set; }
        public List<PIdolIcon>?                         PIdolIcons                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourPIdolSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolSelectPopupView();

            value.PIdolSelectGridView                       = GetObject<ChallengeTourPIdolSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourPIdolSelectGridView.FromPointer); // 0270DA1B7A28 0x20 PIdolSelectGridView         ( 0001865765D0 ModelClassType ChallengeTourPIdolSelectGridView ChallengeTourPIdolSelectGridView ChallengeTourPIdolSelectGridView Pointer )
            value.PIdolIcons                                = GetObjectList<PIdolIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0270DA1B7AA8 0x40 PIdolIcons                  ( 000185B99EC0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA1B7AC8 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
