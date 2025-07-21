using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScheduleDetailTabButtonContentList       ModelClassListType List`1<ScheduleDetailTabButtonContent> List`1<ScheduleDetailTabButtonContent> List<ScheduleDetailTabButtonContent> Pointer
    // 028 ScheduleDetailTabGroup                   ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 030 ScheduleNameText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ScheduleLvText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ScheduleLvObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 048 ScheduleLvImage                          ModelClassType UIImage UIImage UIImage Pointer
    // 050 SupportBonusObject                       ModelClassType GameObject GameObject GameObject Pointer
    // 058 NoTabDisplayAreaObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 060 Lv1Object                                ModelClassType GameObject GameObject GameObject Pointer
    // 068 Lv3Object                                ModelClassType GameObject GameObject GameObject Pointer
    // 070 Lv5Object                                ModelClassType GameObject GameObject GameObject Pointer
    // 078 ScheduleDetailList                       ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer
    // 080 IsInitilized                             ModelPrimitiveType bool bool bool Bool
    // 088 onClickTab                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ScheduleDetailTabGroupContent : DataModel
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
            var value   = new ScheduleDetailTabGroupContent() { Pointer= p0 };

            value.ScheduleDetailTabButtonContentList        = GetObjectList<ScheduleDetailTabButtonContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleDetailTabButtonContent.FromPointer); // 0x20 ScheduleDetailTabButtonContentList ( ModelClassListType List`1<ScheduleDetailTabButtonContent> List`1<ScheduleDetailTabButtonContent> List<ScheduleDetailTabButtonContent> Pointer )
            value.ScheduleDetailTabGroup                    = GetObject<UITabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x28 ScheduleDetailTabGroup      ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.ScheduleNameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ScheduleNameText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleLvText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ScheduleLvText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleLvObject                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 ScheduleLvObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleLvImage                           = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0x48 ScheduleLvImage             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.SupportBonusObject                        = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 SupportBonusObject          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.NoTabDisplayAreaObject                    = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 NoTabDisplayAreaObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Lv1Object                                 = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 Lv1Object                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Lv3Object                                 = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 Lv3Object                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Lv5Object                                 = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 Lv5Object                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ScheduleDetailList                        = GetObjectList<IScheduleDetailStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IScheduleDetailStatus.FromPointer); // 0x78 ScheduleDetailList          ( ModelClassListType List`1<IScheduleDetailStatus> List`1<IScheduleDetailStatus> List<IScheduleDetailStatus> Pointer )
            value.IsInitilized                              = GetBool(new IntPtr(p + 0x080)); // 0x80 IsInitilized                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
