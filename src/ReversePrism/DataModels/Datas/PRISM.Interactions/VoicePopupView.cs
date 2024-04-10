using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabGroup                                 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 IdolGridView                             00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 030 PIdolGridView                            00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 038 SCharaGridView                           00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer
    // 040 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 <OnClickCell>k__BackingField             IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 050 <OnDetailCellIcon>k__BackingField        IObservable`1<int> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class VoicePopupView : DataModel
    {
        public UITabGroup?                              TabGroup                                { get; set; }
        public CategoryElementGridView?                 IdolGridView                            { get; set; }
        public CategoryElementGridView?                 PIdolGridView                           { get; set; }
        public CategoryElementGridView?                 SCharaGridView                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static VoicePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoicePopupView() { Pointer= p0 };

            value.TabGroup                                  = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466A3A7300 0x20 TabGroup                    ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.IdolGridView                              = GetObject<CategoryElementGridView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 02466A3A7320 0x28 IdolGridView                ( 00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.PIdolGridView                             = GetObject<CategoryElementGridView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 02466A3A7340 0x30 PIdolGridView               ( 00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.SCharaGridView                            = GetObject<CategoryElementGridView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CategoryElementGridView.FromPointer); // 02466A3A7360 0x38 SCharaGridView              ( 00018654FF30 ModelClassType CategoryElementGridView CategoryElementGridView CategoryElementGridView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A3A73E0 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
