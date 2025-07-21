using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtPieceConversionItem                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 BtnToExchange                            ModelClassType UIButton UIButton UIButton Pointer
    // 030 TabGroupView                             ModelClassType LabelTabGroupView LabelTabGroupView LabelTabGroupView Pointer
    // 038 GridView                                 ModelClassType EnhancedPieceSelectGridView EnhancedPieceSelectGridView EnhancedPieceSelectGridView Pointer
    // 040 PieceArchiveBottomView                   ModelClassType PieceArchiveBottomView PieceArchiveBottomView PieceArchiveBottomView Pointer
    // 048 toExchange                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onConversion                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Vm                                       ModelClassType PieceArchiveViewModel PieceArchiveViewModel PieceArchiveViewModel Pointer
    public partial class PieceArchiveView : DataModel
    {
        public UITextMeshProUGUI?                       TxtPieceConversionItem                  { get; set; }
        public UIButton?                                BtnToExchange                           { get; set; }
        public LabelTabGroupView?                       TabGroupView                            { get; set; }
        public EnhancedPieceSelectGridView?             GridView                                { get; set; }
        public PieceArchiveBottomView?                  PieceArchiveBottomView                  { get; set; }
        public PieceArchiveViewModel?                   Vm                                      { get; set; }

        public static PieceArchiveView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceArchiveView() { Pointer= p0 };

            value.TxtPieceConversionItem                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtPieceConversionItem      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnToExchange                             = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnToExchange               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TabGroupView                              = GetObject<LabelTabGroupView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LabelTabGroupView.FromPointer); // 0x30 TabGroupView                ( ModelClassType LabelTabGroupView LabelTabGroupView LabelTabGroupView Pointer )
            value.GridView                                  = GetObject<EnhancedPieceSelectGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.EnhancedPieceSelectGridView.FromPointer); // 0x38 GridView                    ( ModelClassType EnhancedPieceSelectGridView EnhancedPieceSelectGridView EnhancedPieceSelectGridView Pointer )
            value.PieceArchiveBottomView                    = GetObject<PieceArchiveBottomView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PieceArchiveBottomView.FromPointer); // 0x40 PieceArchiveBottomView      ( ModelClassType PieceArchiveBottomView PieceArchiveBottomView PieceArchiveBottomView Pointer )
            value.Vm                                        = GetObject<PieceArchiveViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.PieceArchiveViewModel.FromPointer); // 0x58 Vm                          ( ModelClassType PieceArchiveViewModel PieceArchiveViewModel PieceArchiveViewModel Pointer )

            return value;
        }
    }
}
