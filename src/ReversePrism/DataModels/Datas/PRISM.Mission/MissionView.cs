using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 ModelClassType MissionTabButtonGroup MissionTabButtonGroup MissionTabButtonGroup Pointer
    // 028 ButtonGetAll                             ModelClassType UIButton UIButton UIButton Pointer
    // 030 ReceiveButtonObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 038 LockButtonObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 040 FilterAndSortView                        ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 048 MissionListRootObject                    ModelClassType GameObject GameObject GameObject Pointer
    // 050 MissionList                              ModelClassType MissionList MissionList MissionList Pointer
    // 058 MissionEventListRootObject               ModelClassType GameObject GameObject GameObject Pointer
    // 060 MissionEventList                         ModelClassType MissionEventList MissionEventList MissionEventList Pointer
    // 068 LimitRootObject                          ModelClassType GameObject GameObject GameObject Pointer
    // 070 LimitText                                ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 078 MissionListGaugeView                     ModelClassType MissionListGaugeView MissionListGaugeView MissionListGaugeView Pointer
    // 080 HeaderTitleObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 088 HeaderTitleText                          ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    public partial class MissionView : DataModel
    {
        public MissionTabButtonGroup?                   TabGroup                                { get; set; }
        public UIButton?                                ButtonGetAll                            { get; set; }
        public GameObject?                              ReceiveButtonObject                     { get; set; }
        public GameObject?                              LockButtonObject                        { get; set; }
        public FilterAndSortView?                       FilterAndSortView                       { get; set; }
        public GameObject?                              MissionListRootObject                   { get; set; }
        public MissionList?                             MissionList                             { get; set; }
        public GameObject?                              MissionEventListRootObject              { get; set; }
        public MissionEventList?                        MissionEventList                        { get; set; }
        public GameObject?                              LimitRootObject                         { get; set; }
        public TextMeshProUGUI?                         LimitText                               { get; set; }
        public MissionListGaugeView?                    MissionListGaugeView                    { get; set; }
        public GameObject?                              HeaderTitleObject                       { get; set; }
        public TextMeshProUGUI?                         HeaderTitleText                         { get; set; }

        public static MissionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<MissionTabButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.MissionTabButtonGroup.FromPointer); // 0x20 TabGroup                    ( ModelClassType MissionTabButtonGroup MissionTabButtonGroup MissionTabButtonGroup Pointer )
            value.ButtonGetAll                              = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 ButtonGetAll                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ReceiveButtonObject                       = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 ReceiveButtonObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LockButtonObject                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 LockButtonObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FilterAndSortView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0x40 FilterAndSortView           ( ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.MissionListRootObject                     = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 MissionListRootObject       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionList                               = GetObject<MissionList>(new IntPtr(p + 0x050), ReversePrism.DataModels.MissionList.FromPointer); // 0x50 MissionList                 ( ModelClassType MissionList MissionList MissionList Pointer )
            value.MissionEventListRootObject                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 MissionEventListRootObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionEventList                          = GetObject<MissionEventList>(new IntPtr(p + 0x060), ReversePrism.DataModels.MissionEventList.FromPointer); // 0x60 MissionEventList            ( ModelClassType MissionEventList MissionEventList MissionEventList Pointer )
            value.LimitRootObject                           = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 LimitRootObject             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LimitText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x70 LimitText                   ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MissionListGaugeView                      = GetObject<MissionListGaugeView>(new IntPtr(p + 0x078), ReversePrism.DataModels.MissionListGaugeView.FromPointer); // 0x78 MissionListGaugeView        ( ModelClassType MissionListGaugeView MissionListGaugeView MissionListGaugeView Pointer )
            value.HeaderTitleObject                         = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 HeaderTitleObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HeaderTitleText                           = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x88 HeaderTitleText             ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )

            return value;
        }
    }
}
