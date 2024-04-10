using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TextElement                            000186638B30 ModelClassType TextElement TextElement TextElement Pointer
    // 018 EditingEventHandler                      000186637F70 ModelClassType TextEditorEventHandler TextEditorEventHandler TextEditorEventHandler Pointer
    // 020 EditingUtilities                         000186637560 ModelClassType TextEditingUtilities TextEditingUtilities TextEditingUtilities Pointer
    // 028 M_TouchScreenTextFieldInitialized        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 M_HardwareKeyboardPoller                 000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    public partial class TextEditingManipulator : DataModel
    {
        public TextElement?                             M_TextElement                           { get; set; }
        public TextEditorEventHandler?                  EditingEventHandler                     { get; set; }
        public TextEditingUtilities?                    EditingUtilities                        { get; set; }
        public bool                                     M_TouchScreenTextFieldInitialized       { get; set; }
        public IVisualElementScheduledItem?             M_HardwareKeyboardPoller                { get; set; }

        public static TextEditingManipulator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextEditingManipulator() { Pointer= p0 };

            value.M_TextElement                             = GetObject<TextElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextElement.FromPointer); // 0245A6807420 0x10 M_TextElement               ( 000186638B30 ModelClassType TextElement TextElement TextElement Pointer )
            value.EditingEventHandler                       = GetObject<TextEditorEventHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextEditorEventHandler.FromPointer); // 0245A6807440 0x18 EditingEventHandler         ( 000186637F70 ModelClassType TextEditorEventHandler TextEditorEventHandler TextEditorEventHandler Pointer )
            value.EditingUtilities                          = GetObject<TextEditingUtilities>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextEditingUtilities.FromPointer); // 0245A6807460 0x20 EditingUtilities            ( 000186637560 ModelClassType TextEditingUtilities TextEditingUtilities TextEditingUtilities Pointer )
            value.M_TouchScreenTextFieldInitialized         = GetBool(new IntPtr(p + 0x028)); // 0245A6807480 0x28 M_TouchScreenTextFieldInitialized ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_HardwareKeyboardPoller                  = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 0245A68074A0 0x30 M_HardwareKeyboardPoller    ( 000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )

            return value;
        }
    }
}
