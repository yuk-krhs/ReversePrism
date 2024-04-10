using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_Toggle                                 000186682E60 ModelClassType Toggle Toggle Toggle Pointer
    // 048 M_Container                              0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 050 M_IndentElement                          0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 058 M_BindableContainer                      0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 060 M_Checkmark                              0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 068 onPointerUp                              Action`1<PointerUpEvent> IL2CPP_TYPE_GENERICINST
    // 070 onToggleValueChanged                     Action`1<ChangeEvent`1<bool>> IL2CPP_TYPE_GENERICINST
    // 078 M_Depth                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C M_IndentWidth                            0001866656B0 ModelPrimitiveType float float float Single
    // 080 m_PointerUpCallback                      EventCallback`1<PointerUpEvent> IL2CPP_TYPE_GENERICINST
    // 088 m_ToggleValueChangedCallback             EventCallback`1<ChangeEvent`1<bool>> IL2CPP_TYPE_GENERICINST
    // 090 m_ToggleGeometryChangedCallback          EventCallback`1<GeometryChangedEvent> IL2CPP_TYPE_GENERICINST
    public partial class ReusableTreeViewItem : DataModel
    {
        public Toggle?                                  M_Toggle                                { get; set; }
        public VisualElement?                           M_Container                             { get; set; }
        public VisualElement?                           M_IndentElement                         { get; set; }
        public VisualElement?                           M_BindableContainer                     { get; set; }
        public VisualElement?                           M_Checkmark                             { get; set; }
        public int                                      M_Depth                                 { get; set; }
        public float                                    M_IndentWidth                           { get; set; }

        public static ReusableTreeViewItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReusableTreeViewItem() { Pointer= p0 };

            value.M_Toggle                                  = GetObject<Toggle>(new IntPtr(p + 0x040), ReversePrism.DataModels.Toggle.FromPointer); // 0245A66B0930 0x40 M_Toggle                    ( 000186682E60 ModelClassType Toggle Toggle Toggle Pointer )
            value.M_Container                               = GetObject<VisualElement>(new IntPtr(p + 0x048), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66B0950 0x48 M_Container                 ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_IndentElement                           = GetObject<VisualElement>(new IntPtr(p + 0x050), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66B0970 0x50 M_IndentElement             ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_BindableContainer                       = GetObject<VisualElement>(new IntPtr(p + 0x058), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66B0990 0x58 M_BindableContainer         ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Checkmark                               = GetObject<VisualElement>(new IntPtr(p + 0x060), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66B09B0 0x60 M_Checkmark                 ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Depth                                   = GetInt32(new IntPtr(p + 0x078)); // 0245A66B0A10 0x78 M_Depth                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_IndentWidth                             = GetSingle(new IntPtr(p + 0x07C)); // 0245A66B0A30 0x7C M_IndentWidth               ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
