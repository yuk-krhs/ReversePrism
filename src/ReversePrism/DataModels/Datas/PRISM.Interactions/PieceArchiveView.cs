using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtPieceConversionItem                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 BtnToExchange                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 TabGroupView                             000186777080 ModelClassType LabelTabGroupView LabelTabGroupView LabelTabGroupView Pointer
    // 038 GridView                                 000186734B50 ModelClassType EnhancedPieceSelectGridView EnhancedPieceSelectGridView EnhancedPieceSelectGridView Pointer
    // 040 PieceArchiveBottomView                   00018673D400 ModelClassType PieceArchiveBottomView PieceArchiveBottomView PieceArchiveBottomView Pointer
    // 048 toExchange                               Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onConversion                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 Vm                                       00018673F090 ModelClassType PieceArchiveViewModel PieceArchiveViewModel PieceArchiveViewModel Pointer
    // 060 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class PieceArchiveView
    {
        public UITextMeshProUGUI?                       TxtPieceConversionItem                  { get; set; }
        public UIButton?                                BtnToExchange                           { get; set; }
        public LabelTabGroupView?                       TabGroupView                            { get; set; }
        public EnhancedPieceSelectGridView?             GridView                                { get; set; }
        public PieceArchiveBottomView?                  PieceArchiveBottomView                  { get; set; }
        public PieceArchiveViewModel?                   Vm                                      { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static PieceArchiveView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceArchiveView();

            value.TxtPieceConversionItem                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA290C58 0x20 TxtPieceConversionItem      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnToExchange                             = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA290C78 0x28 BtnToExchange               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TabGroupView                              = GetObject<LabelTabGroupView>(new IntPtr(p + 0x030), ReversePrism.DataModels.LabelTabGroupView.FromPointer); // 0270DA290C98 0x30 TabGroupView                ( 000186777080 ModelClassType LabelTabGroupView LabelTabGroupView LabelTabGroupView Pointer )
            value.GridView                                  = GetObject<EnhancedPieceSelectGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.EnhancedPieceSelectGridView.FromPointer); // 0270DA290CB8 0x38 GridView                    ( 000186734B50 ModelClassType EnhancedPieceSelectGridView EnhancedPieceSelectGridView EnhancedPieceSelectGridView Pointer )
            value.PieceArchiveBottomView                    = GetObject<PieceArchiveBottomView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PieceArchiveBottomView.FromPointer); // 0270DA290CD8 0x40 PieceArchiveBottomView      ( 00018673D400 ModelClassType PieceArchiveBottomView PieceArchiveBottomView PieceArchiveBottomView Pointer )
            value.Vm                                        = GetObject<PieceArchiveViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.PieceArchiveViewModel.FromPointer); // 0270DA290D38 0x58 Vm                          ( 00018673F090 ModelClassType PieceArchiveViewModel PieceArchiveViewModel PieceArchiveViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA290D58 0x60 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
