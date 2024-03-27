using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleDetailTabButtonContentList       000185D05FE8 ModelClassListType List`1<ScheduleDetailTabButtonContent> List`1<ScheduleDetailTabButtonContent> List<ScheduleDetailTabButtonContent> Pointer
    // 028 ScheduleDetailTabGroup                   0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 ScheduleNameText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ScheduleLvText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ScheduleLvObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ScheduleLvImage                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 SupportBonusObject                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 NoTabDisplayAreaObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 Lv1Object                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 Lv3Object                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 Lv5Object                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ScheduleDetailList                       000185CE8228 ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer
    // 080 IsInitilized                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 onClickTab                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ScheduleDetailTabGroupContent
    {
        public List<ScheduleDetailTabButtonContent>?    ScheduleDetailTabButtonContentList      { get; set; }
        public UITabGroup?                              ScheduleDetailTabGroup                  { get; set; }
        public UITextMeshProUGUI?                       ScheduleNameText                        { get; set; }
        public UITextMeshProUGUI?                       ScheduleLvText                          { get; set; }
        public GameObject?                              ScheduleLvObject                        { get; set; }
        public UIImage?                                 ScheduleLvImage                         { get; set; }
        public GameObject?                              SupportBonusObject                      { get; set; }
        public GameObject?                              NoTabDisplayAreaObject                  { get; set; }
        public GameObject?                              Lv1Object                               { get; set; }
        public GameObject?                              Lv3Object                               { get; set; }
        public GameObject?                              Lv5Object                               { get; set; }
        public List<IScheduleDetailStatus>?             ScheduleDetailList                      { get; set; }
        public bool                                     IsInitilized                            { get; set; }

        public static ScheduleDetailTabGroupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleDetailTabGroupContent();

            value.ScheduleDetailTabButtonContentList        = GetObjectList<ScheduleDetailTabButtonContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleDetailTabButtonContent.FromPointer); // 0270DA0C2EC8 0x20 ScheduleDetailTabButtonContentList ( 000185D05FE8 ModelClassListType List`1<ScheduleDetailTabButtonContent> List`1<ScheduleDetailTabButtonContent> List<ScheduleDetailTabButtonContent> Pointer )
            value.ScheduleDetailTabGroup                    = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 0270DA0C2EE8 0x28 ScheduleDetailTabGroup      ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.ScheduleNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0C2F08 0x30 ScheduleNameText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleLvText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0C2F28 0x38 ScheduleLvText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleLvObject                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2F48 0x40 ScheduleLvObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLvImage                           = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA0C2F68 0x48 ScheduleLvImage             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.SupportBonusObject                        = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2F88 0x50 SupportBonusObject          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NoTabDisplayAreaObject                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2FA8 0x58 NoTabDisplayAreaObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Lv1Object                                 = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2FC8 0x60 Lv1Object                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Lv3Object                                 = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C2FE8 0x68 Lv3Object                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Lv5Object                                 = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0C3008 0x70 Lv5Object                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDetailList                        = GetObjectList<IScheduleDetailStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IScheduleDetailStatus.FromPointer); // 0270DA0C3028 0x78 ScheduleDetailList          ( 000185CE8228 ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer )
            value.IsInitilized                              = GetBool(new IntPtr(p + 0x080)); // 0270DA0C3048 0x80 IsInitilized                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
