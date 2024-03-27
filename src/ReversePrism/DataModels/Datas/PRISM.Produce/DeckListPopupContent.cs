using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 000 MaxDisplayCount                          int IL2CPP_TYPE_I4
    // 060 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 068 ProduceCardAmount                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ProduceCardParentObject                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 CopyBaseproduceCardObject                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 ProduceCardObjectList                    000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 088 GetProduceCardContentList                000185CFB9B8 ModelClassListType List`1<ProduceCardContent> List`1<ProduceCardContent> List<ProduceCardContent> Pointer
    // 090 CacheProduceCardList                     000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 CardButtonObjectList                     000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 0A0 DeckListPopupContentPathString           000186671910 ModelPrimitiveType string string string String
    // 0A8 LoadedAssetBundlePathStringList          000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class DeckListPopupContent
    {
        public ScrollRect?                              ScrollRect                              { get; set; }
        public UITextMeshProUGUI?                       ProduceCardAmount                       { get; set; }
        public GameObject?                              ProduceCardParentObject                 { get; set; }
        public GameObject?                              CopyBaseproduceCardObject               { get; set; }
        public List<GameObject>?                        ProduceCardObjectList                   { get; set; }
        public List<ProduceCardContent>?                GetProduceCardContentList               { get; set; }
        public List<IProduceCardStatus>?                CacheProduceCardList                    { get; set; }
        public List<GameObject>?                        CardButtonObjectList                    { get; set; }
        public string                                   DeckListPopupContentPathString          { get; set; }
        public List<string>?                            LoadedAssetBundlePathStringList         { get; set; }

        public static DeckListPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeckListPopupContent();

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x060), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D5CB6298 0x60 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ProduceCardAmount                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5CB62B8 0x68 ProduceCardAmount           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProduceCardParentObject                   = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CB62D8 0x70 ProduceCardParentObject     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CopyBaseproduceCardObject                 = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CB62F8 0x78 CopyBaseproduceCardObject   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ProduceCardObjectList                     = GetObjectList<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CB6318 0x80 ProduceCardObjectList       ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.GetProduceCardContentList                 = GetObjectList<ProduceCardContent>(new IntPtr(p + 0x088), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0270D5CB6338 0x88 GetProduceCardContentList   ( 000185CFB9B8 ModelClassListType List`1<ProduceCardContent> List`1<ProduceCardContent> List<ProduceCardContent> Pointer )
            value.CacheProduceCardList                      = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CB6358 0x90 CacheProduceCardList        ( 000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.CardButtonObjectList                      = GetObjectList<GameObject>(new IntPtr(p + 0x098), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5CB6378 0x98 CardButtonObjectList        ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.DeckListPopupContentPathString            = GetString(new IntPtr(p + 0x0A0)); // 0270D5CB6398 0xA0 DeckListPopupContentPathString ( 000186671910 ModelPrimitiveType string string string String )
            value.LoadedAssetBundlePathStringList           = GetStringList(new IntPtr(p + 0x0A8)); // 0270D5CB63B8 0xA8 LoadedAssetBundlePathStringList ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
