using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VocalAreaObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 DanceAreaObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 VisualAreaObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 MentalAreaObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 VocalRankText                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 VocalValueText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 DanceRankText                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 058 DanceValueText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 VisualRankText                           0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 068 VisualValueText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 MentalRankText                           0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 078 MentalValueText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 VocalPointUpValueText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 DancePointUpValueText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 VisualPointUpValueText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 MentalPointUpValueText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 RawImageList                             000185D18558 ModelClassListType List`1<UIRawImage> List`1<UIRawImage> List<UIRawImage> Pointer
    // 0A8 RawImageAfterList                        000185D18558 ModelClassListType List`1<UIRawImage> List`1<UIRawImage> List<UIRawImage> Pointer
    // 0B0 ParameterModels                          000185CBFC28 ModelClassListType ParameterModel[] ParameterModel[] List<ParameterModel> Pointer
    // 0B8 IdolArea                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 IdolSDIcon                               0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 0C8 UnitArea                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0D0 UnitIdolCountText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D8 Disposables                              000185CE2498 ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer
    public partial class ParameterContent : DataModel
    {
        public GameObject?                              VocalAreaObject                         { get; set; }
        public GameObject?                              DanceAreaObject                         { get; set; }
        public GameObject?                              VisualAreaObject                        { get; set; }
        public GameObject?                              MentalAreaObject                        { get; set; }
        public UIRawImage?                              VocalRankText                           { get; set; }
        public UITextMeshProUGUI?                       VocalValueText                          { get; set; }
        public UIRawImage?                              DanceRankText                           { get; set; }
        public UITextMeshProUGUI?                       DanceValueText                          { get; set; }
        public UIRawImage?                              VisualRankText                          { get; set; }
        public UITextMeshProUGUI?                       VisualValueText                         { get; set; }
        public UIRawImage?                              MentalRankText                          { get; set; }
        public UITextMeshProUGUI?                       MentalValueText                         { get; set; }
        public UITextMeshProUGUI?                       VocalPointUpValueText                   { get; set; }
        public UITextMeshProUGUI?                       DancePointUpValueText                   { get; set; }
        public UITextMeshProUGUI?                       VisualPointUpValueText                  { get; set; }
        public UITextMeshProUGUI?                       MentalPointUpValueText                  { get; set; }
        public List<UIRawImage>?                        RawImageList                            { get; set; }
        public List<UIRawImage>?                        RawImageAfterList                       { get; set; }
        public List<ParameterModel>?                    ParameterModels                         { get; set; }
        public GameObject?                              IdolArea                                { get; set; }
        public UIImage?                                 IdolSDIcon                              { get; set; }
        public GameObject?                              UnitArea                                { get; set; }
        public UITextMeshProUGUI?                       UnitIdolCountText                       { get; set; }
        public List<IDisposable>?                       Disposables                             { get; set; }

        public static ParameterContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterContent() { Pointer= p0 };

            value.VocalAreaObject                           = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024665C59C20 0x20 VocalAreaObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DanceAreaObject                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665C59C40 0x28 DanceAreaObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.VisualAreaObject                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 024665C59C60 0x30 VisualAreaObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MentalAreaObject                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 024665C59C80 0x38 MentalAreaObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.VocalRankText                             = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665C59CA0 0x40 VocalRankText               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VocalValueText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59CC0 0x48 VocalValueText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DanceRankText                             = GetObject<UIRawImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665C59CE0 0x50 DanceRankText               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.DanceValueText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59D00 0x58 DanceValueText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VisualRankText                            = GetObject<UIRawImage>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665C59D20 0x60 VisualRankText              ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.VisualValueText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59D40 0x68 VisualValueText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MentalRankText                            = GetObject<UIRawImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665C59D60 0x70 MentalRankText              ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.MentalValueText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59D80 0x78 MentalValueText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VocalPointUpValueText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59DA0 0x80 VocalPointUpValueText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DancePointUpValueText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59DC0 0x88 DancePointUpValueText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VisualPointUpValueText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59DE0 0x90 VisualPointUpValueText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MentalPointUpValueText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59E00 0x98 MentalPointUpValueText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RawImageList                              = GetObjectList<UIRawImage>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665C59E20 0xA0 RawImageList                ( 000185D18558 ModelClassListType List`1<UIRawImage> List`1<UIRawImage> List<UIRawImage> Pointer )
            value.RawImageAfterList                         = GetObjectList<UIRawImage>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UIRawImage.FromPointer); // 024665C59E40 0xA8 RawImageAfterList           ( 000185D18558 ModelClassListType List`1<UIRawImage> List`1<UIRawImage> List<UIRawImage> Pointer )
            value.ParameterModels                           = GetObjectList<ParameterModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ParameterModel.FromPointer); // 024665C59E60 0xB0 ParameterModels             ( 000185CBFC28 ModelClassListType ParameterModel[] ParameterModel[] List<ParameterModel> Pointer )
            value.IdolArea                                  = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 024665C59E80 0xB8 IdolArea                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolSDIcon                                = GetObject<UIImage>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UIImage.FromPointer); // 024665C59EA0 0xC0 IdolSDIcon                  ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.UnitArea                                  = GetObject<GameObject>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.GameObject.FromPointer); // 024665C59EC0 0xC8 UnitArea                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.UnitIdolCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C59EE0 0xD0 UnitIdolCountText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Disposables                               = GetObjectList<IDisposable>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IDisposable.FromPointer); // 024665C59F00 0xD8 Disposables                 ( 000185CE2498 ModelClassListType List`1<IDisposable> List`1<IDisposable> List<IDisposable> Pointer )

            return value;
        }
    }
}
