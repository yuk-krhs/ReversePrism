using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 00018662A830 ModelClassType MissionTabButtonGroup MissionTabButtonGroup MissionTabButtonGroup Pointer
    // 028 ButtonGetAll                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 ReceiveButtonObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 LockButtonObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 FilterAndSortView                        000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer
    // 048 MissionListRootObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 MissionList                              000186624790 ModelClassType MissionList MissionList MissionList Pointer
    // 058 MissionEventListRootObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 MissionEventList                         00018661FF70 ModelClassType MissionEventList MissionEventList MissionEventList Pointer
    // 068 LimitRootObject                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 LimitText                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 078 MissionListGaugeView                     000186624C30 ModelClassType MissionListGaugeView MissionListGaugeView MissionListGaugeView Pointer
    public partial class MissionView
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

        public static MissionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionView();

            value.TabGroup                                  = GetObject<MissionTabButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.MissionTabButtonGroup.FromPointer); // 0270D5587DC0 0x20 TabGroup                    ( 00018662A830 ModelClassType MissionTabButtonGroup MissionTabButtonGroup MissionTabButtonGroup Pointer )
            value.ButtonGetAll                              = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5587DE0 0x28 ButtonGetAll                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ReceiveButtonObject                       = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5587E00 0x30 ReceiveButtonObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LockButtonObject                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5587E20 0x38 LockButtonObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FilterAndSortView                         = GetObject<FilterAndSortView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FilterAndSortView.FromPointer); // 0270D5587E40 0x40 FilterAndSortView           ( 000186580020 ModelClassType FilterAndSortView FilterAndSortView FilterAndSortView Pointer )
            value.MissionListRootObject                     = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5587E60 0x48 MissionListRootObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionList                               = GetObject<MissionList>(new IntPtr(p + 0x050), ReversePrism.DataModels.MissionList.FromPointer); // 0270D5587E80 0x50 MissionList                 ( 000186624790 ModelClassType MissionList MissionList MissionList Pointer )
            value.MissionEventListRootObject                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5587EA0 0x58 MissionEventListRootObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionEventList                          = GetObject<MissionEventList>(new IntPtr(p + 0x060), ReversePrism.DataModels.MissionEventList.FromPointer); // 0270D5587EC0 0x60 MissionEventList            ( 00018661FF70 ModelClassType MissionEventList MissionEventList MissionEventList Pointer )
            value.LimitRootObject                           = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5587EE0 0x68 LimitRootObject             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LimitText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270D5587F00 0x70 LimitText                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.MissionListGaugeView                      = GetObject<MissionListGaugeView>(new IntPtr(p + 0x078), ReversePrism.DataModels.MissionListGaugeView.FromPointer); // 0270D5587F20 0x78 MissionListGaugeView        ( 000186624C30 ModelClassType MissionListGaugeView MissionListGaugeView MissionListGaugeView Pointer )

            return value;
        }
    }
}
