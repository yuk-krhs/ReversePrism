using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                ModelClassType Text Text Text Pointer
    // 068 ValueToggle                              ModelClassType UIFoldout UIFoldout UIFoldout Pointer
    // 070 M_Field                                  ModelClassType Foldout Foldout Foldout Pointer
    // 078 M_Container                              ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer
    // 000 k_FoldoutXOffset                         float IL2CPP_TYPE_R4
    // 000 k_XOffset                                float IL2CPP_TYPE_R4
    public partial class DebugUIHandlerFoldout : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public UIFoldout?                               ValueToggle                             { get; set; }
        public Foldout?                                 M_Field                                 { get; set; }
        public DebugUIHandlerContainer?                 M_Container                             { get; set; }

        public static DebugUIHandlerFoldout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerFoldout() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.ValueToggle                               = GetObject<UIFoldout>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIFoldout.FromPointer); // 0x68 ValueToggle                 ( ModelClassType UIFoldout UIFoldout UIFoldout Pointer )
            value.M_Field                                   = GetObject<Foldout>(new IntPtr(p + 0x070), ReversePrism.DataModels.Foldout.FromPointer); // 0x70 M_Field                     ( ModelClassType Foldout Foldout Foldout Pointer )
            value.M_Container                               = GetObject<DebugUIHandlerContainer>(new IntPtr(p + 0x078), ReversePrism.DataModels.DebugUIHandlerContainer.FromPointer); // 0x78 M_Container                 ( ModelClassType DebugUIHandlerContainer DebugUIHandlerContainer DebugUIHandlerContainer Pointer )

            return value;
        }
    }
}
