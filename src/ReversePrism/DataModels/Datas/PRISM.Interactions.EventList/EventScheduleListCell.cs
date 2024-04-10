using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 NewBadge                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 BannerImage                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 050 TagViewPrefab                            000186766B80 ModelClassType EventScheduleTagView EventScheduleTagView EventScheduleTagView Pointer
    // 058 TagViewContainer                         0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 060 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 OpeningPeriodLabel                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 DisplayUntilLabel                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 DateTimeText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 RemainingDateTimeText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 Data                                     000186766DC0 ModelClassType IEventScheduleStatus IEventScheduleStatus IEventScheduleStatus Pointer
    // 090 BannerLoadCts                            0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 098 HalfCellSize                             0001866656B0 ModelPrimitiveType float float float Single
    // 09C HalfContainerSize                        0001866656B0 ModelPrimitiveType float float float Single
    public partial class EventScheduleListCell : DataModel
    {
        public GameObject?                              NewBadge                                { get; set; }
        public RawImage?                                BannerImage                             { get; set; }
        public EventScheduleTagView?                    TagViewPrefab                           { get; set; }
        public Transform?                               TagViewContainer                        { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public GameObject?                              OpeningPeriodLabel                      { get; set; }
        public GameObject?                              DisplayUntilLabel                       { get; set; }
        public UITextMeshProUGUI?                       DateTimeText                            { get; set; }
        public UITextMeshProUGUI?                       RemainingDateTimeText                   { get; set; }
        public IEventScheduleStatus?                    Data                                    { get; set; }
        public CancellationTokenSource?                 BannerLoadCts                           { get; set; }
        public float                                    HalfCellSize                            { get; set; }
        public float                                    HalfContainerSize                       { get; set; }

        public static EventScheduleListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventScheduleListCell() { Pointer= p0 };

            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF5ECC8 0x40 NewBadge                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BannerImage                               = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 02466BF5ECE8 0x48 BannerImage                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TagViewPrefab                             = GetObject<EventScheduleTagView>(new IntPtr(p + 0x050), ReversePrism.DataModels.EventScheduleTagView.FromPointer); // 02466BF5ED08 0x50 TagViewPrefab               ( 000186766B80 ModelClassType EventScheduleTagView EventScheduleTagView EventScheduleTagView Pointer )
            value.TagViewContainer                          = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 02466BF5ED28 0x58 TagViewContainer            ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF5ED48 0x60 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OpeningPeriodLabel                        = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF5ED68 0x68 OpeningPeriodLabel          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayUntilLabel                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466BF5ED88 0x70 DisplayUntilLabel           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DateTimeText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF5EDA8 0x78 DateTimeText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RemainingDateTimeText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BF5EDC8 0x80 RemainingDateTimeText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Data                                      = GetObject<IEventScheduleStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IEventScheduleStatus.FromPointer); // 02466BF5EDE8 0x88 Data                        ( 000186766DC0 ModelClassType IEventScheduleStatus IEventScheduleStatus IEventScheduleStatus Pointer )
            value.BannerLoadCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x090), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466BF5EE08 0x90 BannerLoadCts               ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.HalfCellSize                              = GetSingle(new IntPtr(p + 0x098)); // 02466BF5EE28 0x98 HalfCellSize                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HalfContainerSize                         = GetSingle(new IntPtr(p + 0x09C)); // 02466BF5EE48 0x9C HalfContainerSize           ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
