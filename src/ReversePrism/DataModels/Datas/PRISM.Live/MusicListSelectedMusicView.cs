using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ArtistName                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 CommonView                               ModelClassType MusicListCellCommonView MusicListCellCommonView MusicListCellCommonView Pointer
    public partial class MusicListSelectedMusicView : DataModel
    {
        public UITextMeshProUGUI?                       ArtistName                              { get; set; }
        public MusicListCellCommonView?                 CommonView                              { get; set; }

        public static MusicListSelectedMusicView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicListSelectedMusicView() { Pointer= p0 };

            value.ArtistName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 ArtistName                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommonView                                = GetObject<MusicListCellCommonView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicListCellCommonView.FromPointer); // 0x28 CommonView                  ( ModelClassType MusicListCellCommonView MusicListCellCommonView MusicListCellCommonView Pointer )

            return value;
        }
    }
}
