using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ArtistName                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 CommonView                               000186667770 ModelClassType MusicListCellCommonView MusicListCellCommonView MusicListCellCommonView Pointer
    public partial class MusicListSelectedMusicView
    {
        public UITextMeshProUGUI?                       ArtistName                              { get; set; }
        public MusicListCellCommonView?                 CommonView                              { get; set; }

        public static MusicListSelectedMusicView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicListSelectedMusicView();

            value.ArtistName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D517EDB0 0x20 ArtistName                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CommonView                                = GetObject<MusicListCellCommonView>(new IntPtr(p + 0x028), ReversePrism.DataModels.MusicListCellCommonView.FromPointer); // 0270D517EDD0 0x28 CommonView                  ( 000186667770 ModelClassType MusicListCellCommonView MusicListCellCommonView MusicListCellCommonView Pointer )

            return value;
        }
    }
}
