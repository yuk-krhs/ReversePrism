using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PfIdolIconView                           000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 JumpDressUpButton                        0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 TxtDressSetName                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 IconViews                                000185B77940 ModelClassListType CostumeIconView[] CostumeIconView[] List<CostumeIconView> Pointer
    // 040 BlankIconViews                           000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 onClickPIdolSubject                      Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 onClickDressUpRoomSubject                Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 058 <OnCostumeIconDetail>k__BackingField     IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    public partial class GashaDetailCostumeCell
    {
        public PFIdolIconView?                          PfIdolIconView                          { get; set; }
        public UIButton?                                JumpDressUpButton                       { get; set; }
        public UITextMeshProUGUI?                       TxtDressSetName                         { get; set; }
        public List<CostumeIconView>?                   IconViews                               { get; set; }
        public List<GameObject>?                        BlankIconViews                          { get; set; }

        public static GashaDetailCostumeCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaDetailCostumeCell();

            value.PfIdolIconView                            = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0270DB9DFD80 0x20 PfIdolIconView              ( 000186704160 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.JumpDressUpButton                         = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB9DFDA0 0x28 JumpDressUpButton           ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtDressSetName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB9DFDC0 0x30 TxtDressSetName             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IconViews                                 = GetObjectList<CostumeIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostumeIconView.FromPointer); // 0270DB9DFDE0 0x38 IconViews                   ( 000185B77940 ModelClassListType CostumeIconView[] CostumeIconView[] List<CostumeIconView> Pointer )
            value.BlankIconViews                            = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9DFE00 0x40 BlankIconViews              ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
