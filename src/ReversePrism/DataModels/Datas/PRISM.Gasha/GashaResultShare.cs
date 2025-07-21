using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoSelect                                 ModelClassType GameObject GameObject GameObject Pointer
    // 028 BtnClose                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 030 BtnIdol                                  ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 BtnIdolAndResult                         ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 TxtIdol                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtIdolAndResult                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 BtnResult                                ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 GoBtnRoot                                ModelClassType GameObject GameObject GameObject Pointer
    // 060 BtnCancel                                ModelClassType UIButton UIButton UIButton Pointer
    // 068 BtnShare                                 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 070 GoEnableShare                            ModelClassType GameObject GameObject GameObject Pointer
    // 078 GoItems                                  ModelClassType GameObject GameObject GameObject Pointer
    // 080 CanvasGroupItems                         ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 088 TxtMsg                                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 TxtCopyright                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 098 GoLogo                                   ModelClassType GameObject GameObject GameObject Pointer
    // 0A0 SelectedResultItem                       ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer
    // 0A8 ShareType                                ModelEnumType ShareType ShareType ShareType Int32
    // 0AC IsProduceIdol                            ModelPrimitiveType bool bool bool Bool
    // 0AD IsSupportCharacter                       ModelPrimitiveType bool bool bool Bool
    // 0B0 ShareLimit                               ModelPrimitiveType int int int Int32
    // 0B8 GashaResultItems                         ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer
    // 0C0 onItemClick                              Subject`1<ValueTuple`2<bool, GashaResultItem>> IL2CPP_TYPE_GENERICINST
    // 0C8 BtnDisposable                            ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0D0 CancelBtnDisposable                      ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 0D8 OnClose                                  ModelClassType Action Action Action Pointer
    // 0E0 BackDisposable                           ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.GoSelect                                  = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 GoSelect                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnClose                                  = GetObject<ButtonBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x28 BtnClose                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnIdol                                   = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 BtnIdol                     ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BtnIdolAndResult                          = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 BtnIdolAndResult            ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.TxtIdol                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtIdol                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtIdolAndResult                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtIdolAndResult            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnResult                                 = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x50 BtnResult                   ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoBtnRoot                                 = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 GoBtnRoot                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnCancel                                 = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 BtnCancel                   ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnShare                                  = GetObject<ButtonBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x68 BtnShare                    ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.GoEnableShare                             = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 GoEnableShare               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoItems                                   = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 GoItems                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CanvasGroupItems                          = GetObject<CanvasGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x80 CanvasGroupItems            ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtMsg                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 TxtMsg                      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCopyright                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x90 TxtCopyright                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoLogo                                    = GetObject<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0x98 GoLogo                      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedResultItem                        = GetObjectList<GashaResultItem>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GashaResultItem.FromPointer); // 0xA0 SelectedResultItem          ( ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer )
            value.ShareType                                 = (ShareType)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 ShareType                   ( ModelEnumType ShareType ShareType ShareType Int32 )
            value.IsProduceIdol                             = GetBool(new IntPtr(p + 0x0AC)); // 0xAC IsProduceIdol               ( ModelPrimitiveType bool bool bool Bool )
            value.IsSupportCharacter                        = GetBool(new IntPtr(p + 0x0AD)); // 0xAD IsSupportCharacter          ( ModelPrimitiveType bool bool bool Bool )
            value.ShareLimit                                = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 ShareLimit                  ( ModelPrimitiveType int int int Int32 )
            value.GashaResultItems                          = GetObjectList<GashaResultItem>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GashaResultItem.FromPointer); // 0xB8 GashaResultItems            ( ModelClassListType List`1<GashaResultItem> List`1<GashaResultItem> List<GashaResultItem> Pointer )
            value.BtnDisposable                             = GetObject<CompositeDisposable>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xC8 BtnDisposable               ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CancelBtnDisposable                       = GetObject<CompositeDisposable>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0xD0 CancelBtnDisposable         ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.OnClose                                   = GetObject<Action>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Action.FromPointer); // 0xD8 OnClose                     ( ModelClassType Action Action Action Pointer )
            value.BackDisposable                            = GetObject<IDisposable>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IDisposable.FromPointer); // 0xE0 BackDisposable              ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
