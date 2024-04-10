using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 View                                     00018655FFC0 ModelClassType LiveMVUnitConfirmationView LiveMVUnitConfirmationView LiveMVUnitConfirmationView Pointer
    // 088 UnitEditView                             00018655FAC0 ModelClassType LiveMVUnitConfirmationUnitEditView LiveMVUnitConfirmationUnitEditView LiveMVUnitConfirmationUnitEditView Pointer
    // 090 UnitListWindow                           000186561690 ModelClassType LiveMVUnitListWindow LiveMVUnitListWindow LiveMVUnitListWindow Pointer
    // 098 RecommendPopupCaller                     000186562540 ModelClassType LiveMVUnitRecommendPopupCaller LiveMVUnitRecommendPopupCaller LiveMVUnitRecommendPopupCaller Pointer
    // 0A0 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 0A8 JumpParameter                            0001866ADA60 ModelClassType JumpParameter JumpParameter JumpParameter Pointer
    // 0B0 Model                                    00018655DF30 ModelClassType LiveMVUnitConfirmationModel LiveMVUnitConfirmationModel LiveMVUnitConfirmationModel Pointer
    public partial class LiveMVUnitConfirmationPresenter : DataModel
    {
        public LiveMVUnitConfirmationView?              View                                    { get; set; }
        public LiveMVUnitConfirmationUnitEditView?      UnitEditView                            { get; set; }
        public LiveMVUnitListWindow?                    UnitListWindow                          { get; set; }
        public LiveMVUnitRecommendPopupCaller?          RecommendPopupCaller                    { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public JumpParameter?                           JumpParameter                           { get; set; }
        public LiveMVUnitConfirmationModel?             Model                                   { get; set; }

        public static LiveMVUnitConfirmationPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitConfirmationPresenter() { Pointer= p0 };

            value.View                                      = GetObject<LiveMVUnitConfirmationView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveMVUnitConfirmationView.FromPointer); // 0246651FFA58 0x80 View                        ( 00018655FFC0 ModelClassType LiveMVUnitConfirmationView LiveMVUnitConfirmationView LiveMVUnitConfirmationView Pointer )
            value.UnitEditView                              = GetObject<LiveMVUnitConfirmationUnitEditView>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveMVUnitConfirmationUnitEditView.FromPointer); // 0246651FFA78 0x88 UnitEditView                ( 00018655FAC0 ModelClassType LiveMVUnitConfirmationUnitEditView LiveMVUnitConfirmationUnitEditView LiveMVUnitConfirmationUnitEditView Pointer )
            value.UnitListWindow                            = GetObject<LiveMVUnitListWindow>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveMVUnitListWindow.FromPointer); // 0246651FFA98 0x90 UnitListWindow              ( 000186561690 ModelClassType LiveMVUnitListWindow LiveMVUnitListWindow LiveMVUnitListWindow Pointer )
            value.RecommendPopupCaller                      = GetObject<LiveMVUnitRecommendPopupCaller>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveMVUnitRecommendPopupCaller.FromPointer); // 0246651FFAB8 0x98 RecommendPopupCaller        ( 000186562540 ModelClassType LiveMVUnitRecommendPopupCaller LiveMVUnitRecommendPopupCaller LiveMVUnitRecommendPopupCaller Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0A0)); // 0246651FFAD8 0xA0 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.JumpParameter                             = GetObject<JumpParameter>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.JumpParameter.FromPointer); // 0246651FFAF8 0xA8 JumpParameter               ( 0001866ADA60 ModelClassType JumpParameter JumpParameter JumpParameter Pointer )
            value.Model                                     = GetObject<LiveMVUnitConfirmationModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveMVUnitConfirmationModel.FromPointer); // 0246651FFB18 0xB0 Model                       ( 00018655DF30 ModelClassType LiveMVUnitConfirmationModel LiveMVUnitConfirmationModel LiveMVUnitConfirmationModel Pointer )

            return value;
        }
    }
}
