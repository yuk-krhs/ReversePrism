using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 EventText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 EventTermTypeText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 EventTermText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 EventTypeImageObject                     ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 BadgeDotObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 068 BadgeNewObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 070 EventEndObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 078 ThumbnailImage                           ModelClassType Image Image Image Pointer
    // 080 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class MissionEventListViewCell : DataModel
    {
        public UITextMeshProUGUI?                       EventText                               { get; set; }
        public UITextMeshProUGUI?                       EventTermTypeText                       { get; set; }
        public UITextMeshProUGUI?                       EventTermText                           { get; set; }
        public List<GameObject>?                        EventTypeImageObject                    { get; set; }
        public GameObject?                              BadgeDotObject                          { get; set; }
        public GameObject?                              BadgeNewObject                          { get; set; }
        public GameObject?                              EventEndObject                          { get; set; }
        public Image?                                   ThumbnailImage                          { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static MissionEventListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionEventListViewCell() { Pointer= p0 };

            value.EventText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 EventText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventTermTypeText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 EventTermTypeText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventTermText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 EventTermText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventTypeImageObject                      = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 EventTypeImageObject        ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BadgeDotObject                            = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 BadgeDotObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeNewObject                            = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 BadgeNewObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EventEndObject                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 EventEndObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ThumbnailImage                            = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 0x78 ThumbnailImage              ( ModelClassType Image Image Image Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x080)); // 0x80 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
