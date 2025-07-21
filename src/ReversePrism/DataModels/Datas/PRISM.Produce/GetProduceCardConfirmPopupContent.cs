using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ProduceCardPrefab                        ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 068 ProduceCardArea                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 GetMesseageText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CacheGetAmount                           ModelPrimitiveType int int int Int32
    // 080 CacheProduceCardStatusList               ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    public partial class GetProduceCardConfirmPopupContent : DataModel
    {
        public ProduceCardContent?                      ProduceCardPrefab                       { get; set; }
        public RectTransform?                           ProduceCardArea                         { get; set; }
        public UITextMeshProUGUI?                       GetMesseageText                         { get; set; }
        public int                                      CacheGetAmount                          { get; set; }
        public List<IProduceCardStatus>?                CacheProduceCardStatusList              { get; set; }

        public static GetProduceCardConfirmPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetProduceCardConfirmPopupContent() { Pointer= p0 };

            value.ProduceCardPrefab                         = GetObject<ProduceCardContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0x60 ProduceCardPrefab           ( ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.ProduceCardArea                           = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0x68 ProduceCardArea             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GetMesseageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 GetMesseageText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CacheGetAmount                            = GetInt32(new IntPtr(p + 0x078)); // 0x78 CacheGetAmount              ( ModelPrimitiveType int int int Int32 )
            value.CacheProduceCardStatusList                = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x80 CacheProduceCardStatusList  ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )

            return value;
        }
    }
}
