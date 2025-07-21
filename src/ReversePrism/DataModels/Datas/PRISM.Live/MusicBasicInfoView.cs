using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MusicTypeIcon                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 MusicName                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 MusicDifficulties                        ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 MusicLevel                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 MusicLevelColors                         ModelEnumListType Color[] Color[] List<Color> Pointer
    // 048 UnitColorObjects                         ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer
    // 050 Config                                   ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer
    // 058 ArtistName                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
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

            value.MusicTypeIcon                             = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 MusicTypeIcon               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MusicName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 MusicName                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicDifficulties                         = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 MusicDifficulties           ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.MusicLevel                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 MusicLevel                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MusicLevelColors                          = GetEnumList<Color>(new IntPtr(p + 0x040)); // 0x40 MusicLevelColors            ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.UnitColorObjects                          = GetObjectList<Graphic>(new IntPtr(p + 0x048), ReversePrism.DataModels.Graphic.FromPointer); // 0x48 UnitColorObjects            ( ModelClassListType Graphic[] Graphic[] List<Graphic> Pointer )
            value.Config                                    = GetObject<LiveUIResourceConfig>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveUIResourceConfig.FromPointer); // 0x50 Config                      ( ModelClassType LiveUIResourceConfig LiveUIResourceConfig LiveUIResourceConfig Pointer )
            value.ArtistName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 ArtistName                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
