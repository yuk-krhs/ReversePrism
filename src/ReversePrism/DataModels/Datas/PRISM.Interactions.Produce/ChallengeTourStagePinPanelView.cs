using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Thumbnail                                ModelClassType Image Image Image Pointer
    // 028 NormalPinObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 030 BossPinObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 038 LockObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 040 StageNumberText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 StarObjects                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
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

            value.Thumbnail                                 = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 Thumbnail                   ( ModelClassType Image Image Image Pointer )
            value.NormalPinObject                           = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 NormalPinObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BossPinObject                             = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 BossPinObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockObject                                = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 LockObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.StageNumberText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 StageNumberText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StarObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 StarObjects                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
