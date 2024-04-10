using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MusicTypeIcon                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 MusicName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 MusicDifficulties                        000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 MusicLevel                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 MusicLevelColors                         000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 048 UnitColorObjects                         000185B833A0 ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer
    // 050 Config                                   000186587F10 ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer
    // 058 ArtistName                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class MusicBasicInfoView : DataModel
    {
        public UIRawImage?                              MusicTypeIcon                           { get; set; }
        public UITextMeshProUGUI?                       MusicName                               { get; set; }
        public List<GameObject>?                        MusicDifficulties                       { get; set; }
        public UITextMeshProUGUI?                       MusicLevel                              { get; set; }
        public List<Color>?                             MusicLevelColors                        { get; set; }
        public List<Graphic>?                           UnitColorObjects                        { get; set; }
        public LiveUIResourceConfig?                    Config                                  { get; set; }
        public UITextMeshProUGUI?                       ArtistName                              { get; set; }

        public static MusicBasicInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicBasicInfoView() { Pointer= p0 };

            value.MusicTypeIcon                             = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466517E7D0 0x20 MusicTypeIcon               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466517E7F0 0x28 MusicName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicDifficulties                         = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466517E810 0x30 MusicDifficulties           ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MusicLevel                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466517E830 0x38 MusicLevel                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicLevelColors                          = GetEnumList<Color>(new IntPtr(p + 0x040)); // 02466517E850 0x40 MusicLevelColors            ( 000185B75890 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.UnitColorObjects                          = GetObjectList<Graphic>(new IntPtr(p + 0x048), ReversePrism.DataModels.Graphic.FromPointer); // 02466517E870 0x48 UnitColorObjects            ( 000185B833A0 ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer )
            value.Config                                    = GetObject<LiveUIResourceConfig>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveUIResourceConfig.FromPointer); // 02466517E890 0x50 Config                      ( 000186587F10 ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer )
            value.ArtistName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466517E8B0 0x58 ArtistName                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
