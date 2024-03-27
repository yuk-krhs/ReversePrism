using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FocusRing                                000186516E70 ModelClassType IFocusRing IFocusRing IFocusRing Pointer
    // 018 M_SelectedTextElement                    000186638B30 ModelClassType TextElement TextElement TextElement Pointer
    // 020 M_FocusedElements                        000185D240B8 ModelEnumListType List`1<FocusedElement> List`1<FocusedElement> List<FocusedElement> Pointer
    // 028 M_LastFocusedElement                     0001865D3CE0 ModelClassType Focusable Focusable Focusable Pointer
    // 030 M_LastPendingFocusedElement              0001865D3F20 ModelClassType Focusable Focusable Focusable Pointer
    // 038 M_PendingFocusCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C ImguiKeyboardControl                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FocusController
    {
        public IFocusRing?                              FocusRing                               { get; set; }
        public TextElement?                             M_SelectedTextElement                   { get; set; }
        public List<FocusedElement>?                    M_FocusedElements                       { get; set; }
        public Focusable?                               M_LastFocusedElement                    { get; set; }
        public Focusable?                               M_LastPendingFocusedElement             { get; set; }
        public int                                      M_PendingFocusCount                     { get; set; }
        public int                                      ImguiKeyboardControl                    { get; set; }

        public static FocusController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FocusController();

            value.FocusRing                                 = GetObject<IFocusRing>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFocusRing.FromPointer); // 0270067DAEA8 0x10 FocusRing                   ( 000186516E70 ModelClassType IFocusRing IFocusRing IFocusRing Pointer )
            value.M_SelectedTextElement                     = GetObject<TextElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextElement.FromPointer); // 0270067DAEC8 0x18 M_SelectedTextElement       ( 000186638B30 ModelClassType TextElement TextElement TextElement Pointer )
            value.M_FocusedElements                         = GetEnumList<FocusedElement>(new IntPtr(p + 0x020)); // 0270067DAEE8 0x20 M_FocusedElements           ( 000185D240B8 ModelEnumListType List`1<FocusedElement> List`1<FocusedElement> List<FocusedElement> Pointer )
            value.M_LastFocusedElement                      = GetObject<Focusable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Focusable.FromPointer); // 0270067DAF08 0x28 M_LastFocusedElement        ( 0001865D3CE0 ModelClassType Focusable Focusable Focusable Pointer )
            value.M_LastPendingFocusedElement               = GetObject<Focusable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Focusable.FromPointer); // 0270067DAF28 0x30 M_LastPendingFocusedElement ( 0001865D3F20 ModelClassType Focusable Focusable Focusable Pointer )
            value.M_PendingFocusCount                       = GetInt32(new IntPtr(p + 0x038)); // 0270067DAF48 0x38 M_PendingFocusCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ImguiKeyboardControl                      = GetInt32(new IntPtr(p + 0x03C)); // 0270067DAF68 0x3C ImguiKeyboardControl        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
