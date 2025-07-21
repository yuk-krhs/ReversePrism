using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 View                                     ModelClassType LiveMVUnitConfirmationView LiveMVUnitConfirmationView LiveMVUnitConfirmationView Pointer
    // 080 UnitEditView                             ModelClassType LiveMVUnitConfirmationUnitEditView LiveMVUnitConfirmationUnitEditView LiveMVUnitConfirmationUnitEditView Pointer
    // 088 UnitListWindow                           ModelClassType LiveMVUnitListWindow LiveMVUnitListWindow LiveMVUnitListWindow Pointer
    // 090 RecommendPopupCaller                     ModelClassType LiveMVUnitRecommendPopupCaller LiveMVUnitRecommendPopupCaller LiveMVUnitRecommendPopupCaller Pointer
    // 098 LimitedVoiceSeparateDetailPopupCaller    ModelClassType LimitedVoiceSeparateDetailPopupCaller LimitedVoiceSeparateDetailPopupCaller LimitedVoiceSeparateDetailPopupCaller Pointer
    // 0A0 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 0A8 JumpParameter                            ModelClassType JumpParameter JumpParameter JumpParameter Pointer
    // 0B0 Model                                    ModelClassType LiveMVUnitConfirmationModel LiveMVUnitConfirmationModel LiveMVUnitConfirmationModel Pointer
    public partial class LiveMVUnitConfirmationPresenter : DataModel
    {
        public LiveMVUnitConfirmationView?              View                                    { get; set; }
        public LiveMVUnitConfirmationUnitEditView?      UnitEditView                            { get; set; }
        public LiveMVUnitListWindow?                    UnitListWindow                          { get; set; }
        public LiveMVUnitRecommendPopupCaller?          RecommendPopupCaller                    { get; set; }
        public LimitedVoiceSeparateDetailPopupCaller?   LimitedVoiceSeparateDetailPopupCaller   { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public JumpParameter?                           JumpParameter                           { get; set; }
        public LiveMVUnitConfirmationModel?             Model                                   { get; set; }

        public static LiveMVUnitConfirmationPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitConfirmationPresenter() { Pointer= p0 };

            value.View                                      = GetObject<LiveMVUnitConfirmationView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveMVUnitConfirmationView.FromPointer); // 0x78 View                        ( ModelClassType LiveMVUnitConfirmationView LiveMVUnitConfirmationView LiveMVUnitConfirmationView Pointer )
            value.UnitEditView                              = GetObject<LiveMVUnitConfirmationUnitEditView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveMVUnitConfirmationUnitEditView.FromPointer); // 0x80 UnitEditView                ( ModelClassType LiveMVUnitConfirmationUnitEditView LiveMVUnitConfirmationUnitEditView LiveMVUnitConfirmationUnitEditView Pointer )
            value.UnitListWindow                            = GetObject<LiveMVUnitListWindow>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveMVUnitListWindow.FromPointer); // 0x88 UnitListWindow              ( ModelClassType LiveMVUnitListWindow LiveMVUnitListWindow LiveMVUnitListWindow Pointer )
            value.RecommendPopupCaller                      = GetObject<LiveMVUnitRecommendPopupCaller>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveMVUnitRecommendPopupCaller.FromPointer); // 0x90 RecommendPopupCaller        ( ModelClassType LiveMVUnitRecommendPopupCaller LiveMVUnitRecommendPopupCaller LiveMVUnitRecommendPopupCaller Pointer )
            value.LimitedVoiceSeparateDetailPopupCaller     = GetObject<LimitedVoiceSeparateDetailPopupCaller>(new IntPtr(p + 0x098), ReversePrism.DataModels.LimitedVoiceSeparateDetailPopupCaller.FromPointer); // 0x98 LimitedVoiceSeparateDetailPopupCaller ( ModelClassType LimitedVoiceSeparateDetailPopupCaller LimitedVoiceSeparateDetailPopupCaller LimitedVoiceSeparateDetailPopupCaller Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.JumpParameter                             = GetObject<JumpParameter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.JumpParameter.FromPointer); // 0xA8 JumpParameter               ( ModelClassType JumpParameter JumpParameter JumpParameter Pointer )
            value.Model                                     = GetObject<LiveMVUnitConfirmationModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveMVUnitConfirmationModel.FromPointer); // 0xB0 Model                       ( ModelClassType LiveMVUnitConfirmationModel LiveMVUnitConfirmationModel LiveMVUnitConfirmationModel Pointer )

            return value;
        }
    }
}
