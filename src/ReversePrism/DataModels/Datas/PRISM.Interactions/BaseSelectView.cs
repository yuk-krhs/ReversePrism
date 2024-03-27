using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PlateViews                               000185B74FE0 ModelClassListType CharacterPlateView[] CharacterPlateView[] List<CharacterPlateView> Pointer
    // 028 onTapPosition                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class BaseSelectView
    {
        public List<CharacterPlateView>?                PlateViews                              { get; set; }

        public static BaseSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseSelectView();

            value.PlateViews                                = GetObjectList<CharacterPlateView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterPlateView.FromPointer); // 0270DA2285C8 0x20 PlateViews                  ( 000185B74FE0 ModelClassListType CharacterPlateView[] CharacterPlateView[] List<CharacterPlateView> Pointer )

            return value;
        }
    }
}
