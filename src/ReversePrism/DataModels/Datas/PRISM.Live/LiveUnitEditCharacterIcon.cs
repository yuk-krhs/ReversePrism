using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EmptyView                                0001867037B0 ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer
    // 028 IconView                                 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 030 IconButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 DragMark                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 FocusMark                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 LongPressDisposer                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 050 BonusRate                                0001866656B0 ModelPrimitiveType float float float Single
    // 054 IsEmpty                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 055 IsInDrag                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveUnitEditCharacterIcon
    {
        public PFIdolIconRectEmptyView?                 EmptyView                               { get; set; }
        public PFIdolIconRectView?                      IconView                                { get; set; }
        public ButtonBase?                              IconButton                              { get; set; }
        public GameObject?                              DragMark                                { get; set; }
        public GameObject?                              FocusMark                               { get; set; }
        public IDisposable?                             LongPressDisposer                       { get; set; }
        public float                                    BonusRate                               { get; set; }
        public bool                                     IsEmpty                                 { get; set; }
        public bool                                     IsInDrag                                { get; set; }

        public static LiveUnitEditCharacterIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditCharacterIcon();

            value.EmptyView                                 = GetObject<PFIdolIconRectEmptyView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconRectEmptyView.FromPointer); // 0270D50D23B8 0x20 EmptyView                   ( 0001867037B0 ModelClassType PFIdolIconRectEmptyView PFIdolIconRectEmptyView PFIdolIconRectEmptyView Pointer )
            value.IconView                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0270D50D23D8 0x28 IconView                    ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.IconButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D50D23F8 0x30 IconButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.DragMark                                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D50D2418 0x38 DragMark                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FocusMark                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D50D2438 0x40 FocusMark                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LongPressDisposer                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D50D2458 0x48 LongPressDisposer           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.BonusRate                                 = GetSingle(new IntPtr(p + 0x050)); // 0270D50D2478 0x50 BonusRate                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsEmpty                                   = GetBool(new IntPtr(p + 0x054)); // 0270D50D2498 0x54 IsEmpty                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsInDrag                                  = GetBool(new IntPtr(p + 0x055)); // 0270D50D24B8 0x55 IsInDrag                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
