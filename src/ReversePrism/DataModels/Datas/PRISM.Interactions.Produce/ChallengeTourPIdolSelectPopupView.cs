using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PIdolSelectGridView                      ModelClassType ChallengeTourPIdolSelectGridView ChallengeTourPIdolSelectGridView ChallengeTourPIdolSelectGridView Pointer
    // 028 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 030 PIdolIcons                               ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ChallengeTourPIdolSelectPopupView : DataModel
    {
        public ChallengeTourPIdolSelectGridView?        PIdolSelectGridView                     { get; set; }
        public List<PIdolIcon>?                         PIdolIcons                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ChallengeTourPIdolSelectPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolSelectPopupView() { Pointer= p0 };

            value.PIdolSelectGridView                       = GetObject<ChallengeTourPIdolSelectGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourPIdolSelectGridView.FromPointer); // 0x20 PIdolSelectGridView         ( ModelClassType ChallengeTourPIdolSelectGridView ChallengeTourPIdolSelectGridView ChallengeTourPIdolSelectGridView Pointer )
            value.PIdolIcons                                = GetObjectList<PIdolIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0x30 PIdolIcons                  ( ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
