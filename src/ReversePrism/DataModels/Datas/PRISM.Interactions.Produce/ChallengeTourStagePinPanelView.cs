using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Thumbnail                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 NormalPinObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 BossPinObject                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 LockObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 StageNumberText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 StarObjects                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class ChallengeTourStagePinPanelView : DataModel
    {
        public Image?                                   Thumbnail                               { get; set; }
        public GameObject?                              NormalPinObject                         { get; set; }
        public GameObject?                              BossPinObject                           { get; set; }
        public GameObject?                              LockObject                              { get; set; }
        public UITextMeshProUGUI?                       StageNumberText                         { get; set; }
        public List<GameObject>?                        StarObjects                             { get; set; }

        public static ChallengeTourStagePinPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStagePinPanelView() { Pointer= p0 };

            value.Thumbnail                                 = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 02466A218ED8 0x20 Thumbnail                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.NormalPinObject                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466A218EF8 0x28 NormalPinObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BossPinObject                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A218F18 0x30 BossPinObject               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A218F38 0x38 LockObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.StageNumberText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A218F58 0x40 StageNumberText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StarObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466A218F78 0x48 StarObjects                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
