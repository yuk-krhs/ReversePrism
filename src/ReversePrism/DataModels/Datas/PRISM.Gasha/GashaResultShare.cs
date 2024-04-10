using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoSelect                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 BtnClose                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 BtnIdol                                  000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 BtnIdolAndResult                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 TxtIdol                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtIdolAndResult                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 BtnResult                                000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 GoBtnRoot                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 BtnCancel                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 BtnShare                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 GoEnableShare                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 GoItems                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 CanvasGroupItems                         000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 088 TxtMsg                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 TxtCopyright                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 GoLogo                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 SelectedResultItem                       000185CDE3B8 ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer
    // 0A8 ShareType                                000186719B90 ModelEnumType ShareType ShareType ShareType Int32
    // 0AC IsProduceIdol                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AD IsSupportCharacter                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 ShareLimit                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B8 GashaResultItems                         000185CDE358 ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer
    // 0C0 onItemClick                              Subject`1<ValueTuple`2<bool, GashaResultItem>> IL2CPP_TYPE_GENERICINST
    // 0C8 BtnDisposable                            0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0D0 CancelBtnDisposable                      0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0D8 OnClose                                  0001866792B0 ModelClassType Action Action Action Pointer
    // 0E0 BackDisposable                           0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class GashaResultShare : DataModel
    {
        public GameObject?                              GoSelect                                { get; set; }
        public ButtonBase?                              BtnClose                                { get; set; }
        public ButtonBase?                              BtnIdol                                 { get; set; }
        public ButtonBase?                              BtnIdolAndResult                        { get; set; }
        public UITextMeshProUGUI?                       TxtIdol                                 { get; set; }
        public UITextMeshProUGUI?                       TxtIdolAndResult                        { get; set; }
        public ButtonBase?                              BtnResult                               { get; set; }
        public GameObject?                              GoBtnRoot                               { get; set; }
        public UIButton?                                BtnCancel                               { get; set; }
        public ButtonBase?                              BtnShare                                { get; set; }
        public GameObject?                              GoEnableShare                           { get; set; }
        public GameObject?                              GoItems                                 { get; set; }
        public CanvasGroup?                             CanvasGroupItems                        { get; set; }
        public UITextMeshProUGUI?                       TxtMsg                                  { get; set; }
        public UITextMeshProUGUI?                       TxtCopyright                            { get; set; }
        public GameObject?                              GoLogo                                  { get; set; }
        public List<GashaResultItem>?                   SelectedResultItem                      { get; set; }
        public ShareType                                ShareType                               { get; set; }
        public bool                                     IsProduceIdol                           { get; set; }
        public bool                                     IsSupportCharacter                      { get; set; }
        public int                                      ShareLimit                              { get; set; }
        public List<GashaResultItem>?                   GashaResultItems                        { get; set; }
        public CompositeDisposable?                     BtnDisposable                           { get; set; }
        public CompositeDisposable?                     CancelBtnDisposable                     { get; set; }
        public Action?                                  OnClose                                 { get; set; }
        public IDisposable?                             BackDisposable                          { get; set; }

        public static GashaResultShare? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaResultShare() { Pointer= p0 };

            value.GoSelect                                  = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024665423158 0x20 GoSelect                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnClose                                  = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665423178 0x28 BtnClose                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnIdol                                   = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665423198 0x30 BtnIdol                     ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnIdolAndResult                          = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0246654231B8 0x38 BtnIdolAndResult            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtIdol                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246654231D8 0x40 TxtIdol                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtIdolAndResult                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246654231F8 0x48 TxtIdolAndResult            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnResult                                 = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665423218 0x50 BtnResult                   ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoBtnRoot                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 024665423238 0x58 GoBtnRoot                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnCancel                                 = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 024665423258 0x60 BtnCancel                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnShare                                  = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 024665423278 0x68 BtnShare                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoEnableShare                             = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024665423298 0x70 GoEnableShare               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoItems                                   = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0246654232B8 0x78 GoItems                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CanvasGroupItems                          = GetObject<CanvasGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0246654232D8 0x80 CanvasGroupItems            ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtMsg                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246654232F8 0x88 TxtMsg                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCopyright                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665423318 0x90 TxtCopyright                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoLogo                                    = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 024665423338 0x98 GoLogo                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedResultItem                        = GetObjectList<GashaResultItem>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GashaResultItem.FromPointer); // 024665423358 0xA0 SelectedResultItem          ( 000185CDE3B8 ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer )
            value.ShareType                                 = (ShareType)GetInt32(new IntPtr(p + 0x0A8)); // 024665423378 0xA8 ShareType                   ( 000186719B90 ModelEnumType ShareType ShareType ShareType Int32 )
            value.IsProduceIdol                             = GetBool(new IntPtr(p + 0x0AC)); // 024665423398 0xAC IsProduceIdol               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSupportCharacter                        = GetBool(new IntPtr(p + 0x0AD)); // 0246654233B8 0xAD IsSupportCharacter          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ShareLimit                                = GetInt32(new IntPtr(p + 0x0B0)); // 0246654233D8 0xB0 ShareLimit                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GashaResultItems                          = GetObjectList<GashaResultItem>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GashaResultItem.FromPointer); // 0246654233F8 0xB8 GashaResultItems            ( 000185CDE358 ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer )
            value.BtnDisposable                             = GetObject<CompositeDisposable>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665423438 0xC8 BtnDisposable               ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CancelBtnDisposable                       = GetObject<CompositeDisposable>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024665423458 0xD0 CancelBtnDisposable         ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.OnClose                                   = GetObject<Action>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Action.FromPointer); // 024665423478 0xD8 OnClose                     ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.BackDisposable                            = GetObject<IDisposable>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IDisposable.FromPointer); // 024665423498 0xE0 BackDisposable              ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
