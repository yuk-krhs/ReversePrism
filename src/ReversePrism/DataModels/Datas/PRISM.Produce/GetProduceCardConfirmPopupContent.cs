using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 ProduceCardPrefab                        0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 068 ProduceCardArea                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 GetMesseageText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CacheGetAmount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 CacheProduceCardStatusList               000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
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

            value.ProduceCardPrefab                         = GetObject<ProduceCardContent>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 024665D2A5C0 0x60 ProduceCardPrefab           ( 0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.ProduceCardArea                           = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 024665D2A5E0 0x68 ProduceCardArea             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GetMesseageText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D2A600 0x70 GetMesseageText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CacheGetAmount                            = GetInt32(new IntPtr(p + 0x078)); // 024665D2A620 0x78 CacheGetAmount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CacheProduceCardStatusList                = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 024665D2A640 0x80 CacheProduceCardStatusList  ( 000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )

            return value;
        }
    }
}
