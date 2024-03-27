using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 EventText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 EventTermTypeText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 EventTermText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 EventTypeImageObject                     000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 BadgeDotObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 BadgeNewObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 EventEndObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ThumbnailImage                           0001866CCDB0 ModelClassType Image Image Image Pointer
    // 080 ClickButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class MissionEventListViewCell
    {
        public UITextMeshProUGUI?                       EventText                               { get; set; }
        public UITextMeshProUGUI?                       EventTermTypeText                       { get; set; }
        public UITextMeshProUGUI?                       EventTermText                           { get; set; }
        public List<GameObject>?                        EventTypeImageObject                    { get; set; }
        public GameObject?                              BadgeDotObject                          { get; set; }
        public GameObject?                              BadgeNewObject                          { get; set; }
        public GameObject?                              EventEndObject                          { get; set; }
        public Image?                                   ThumbnailImage                          { get; set; }
        public UIButton?                                ClickButton                             { get; set; }

        public static MissionEventListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionEventListViewCell();

            value.EventText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5555CD0 0x40 EventText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventTermTypeText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5555CF0 0x48 EventTermTypeText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventTermText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5555D10 0x50 EventTermText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EventTypeImageObject                      = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5555D30 0x58 EventTypeImageObject        ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BadgeDotObject                            = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5555D50 0x60 BadgeDotObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeNewObject                            = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5555D70 0x68 BadgeNewObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EventEndObject                            = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5555D90 0x70 EventEndObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ThumbnailImage                            = GetObject<Image>(new IntPtr(p + 0x078), ReversePrism.DataModels.Image.FromPointer); // 0270D5555DB0 0x78 ThumbnailImage              ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ClickButton                               = GetObject<UIButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5555DD0 0x80 ClickButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
