using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 NewBadge                                 ModelClassType GameObject GameObject GameObject Pointer
    // 048 BannerImage                              ModelClassType RawImage RawImage RawImage Pointer
    // 050 TagViewPrefab                            ModelClassType EventScheduleTagView EventScheduleTagView EventScheduleTagView Pointer
    // 058 TagViewContainer                         ModelClassType Transform Transform Transform Pointer
    // 060 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 OpeningPeriodLabel                       ModelClassType GameObject GameObject GameObject Pointer
    // 070 DisplayUntilLabel                        ModelClassType GameObject GameObject GameObject Pointer
    // 078 DateTimeText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 RemainingDateTimeText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 Data                                     ModelClassType IEventScheduleStatus IEventScheduleStatus IEventScheduleStatus Pointer
    // 090 BannerLoadCts                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 098 HalfCellSize                             ModelPrimitiveType float float float Single
    // 09C HalfContainerSize                        ModelPrimitiveType float float float Single
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

            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 NewBadge                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BannerImage                               = GetObject<RawImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.RawImage.FromPointer); // 0x48 BannerImage                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TagViewPrefab                             = GetObject<EventScheduleTagView>(new IntPtr(p + 0x050), ReversePrism.DataModels.EventScheduleTagView.FromPointer); // 0x50 TagViewPrefab               ( ModelClassType EventScheduleTagView EventScheduleTagView EventScheduleTagView Pointer )
            value.TagViewContainer                          = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0x58 TagViewContainer            ( ModelClassType Transform Transform Transform Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OpeningPeriodLabel                        = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 OpeningPeriodLabel          ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayUntilLabel                         = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 DisplayUntilLabel           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DateTimeText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 DateTimeText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RemainingDateTimeText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 RemainingDateTimeText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Data                                      = GetObject<IEventScheduleStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IEventScheduleStatus.FromPointer); // 0x88 Data                        ( ModelClassType IEventScheduleStatus IEventScheduleStatus IEventScheduleStatus Pointer )
            value.BannerLoadCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x090), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x90 BannerLoadCts               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.HalfCellSize                              = GetSingle(new IntPtr(p + 0x098)); // 0x98 HalfCellSize                ( ModelPrimitiveType float float float Single )
            value.HalfContainerSize                         = GetSingle(new IntPtr(p + 0x09C)); // 0x9C HalfContainerSize           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
