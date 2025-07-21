using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_Toggle                                 ModelClassType Toggle Toggle Toggle Pointer
    // 050 M_Container                              ModelClassType VisualElement VisualElement VisualElement Pointer
    // 058 M_IndentElement                          ModelClassType VisualElement VisualElement VisualElement Pointer
    // 060 M_BindableContainer                      ModelClassType VisualElement VisualElement VisualElement Pointer
    // 068 M_Checkmark                              ModelClassType VisualElement VisualElement VisualElement Pointer
    // 070 onPointerUp                              Action`1<PointerUpEvent> IL2CPP_TYPE_GENERICINST
    // 078 onToggleValueChanged                     Action`1<ChangeEvent`1<bool>> IL2CPP_TYPE_GENERICINST
    // 080 M_Depth                                  ModelPrimitiveType int int int Int32
    // 084 M_IndentWidth                            ModelPrimitiveType float float float Single
    // 088 m_PointerUpCallback                      EventCallback`1<PointerUpEvent> IL2CPP_TYPE_GENERICINST
    // 090 m_ToggleValueChangedCallback             EventCallback`1<ChangeEvent`1<bool>> IL2CPP_TYPE_GENERICINST
    // 098 m_ToggleGeometryChangedCallback          EventCallback`1<GeometryChangedEvent> IL2CPP_TYPE_GENERICINST
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

            value.M_Toggle                                  = GetObject<Toggle>(new IntPtr(p + 0x048), ReversePrism.DataModels.Toggle.FromPointer); // 0x48 M_Toggle                    ( ModelClassType Toggle Toggle Toggle Pointer )
            value.M_Container                               = GetObject<VisualElement>(new IntPtr(p + 0x050), ReversePrism.DataModels.VisualElement.FromPointer); // 0x50 M_Container                 ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_IndentElement                           = GetObject<VisualElement>(new IntPtr(p + 0x058), ReversePrism.DataModels.VisualElement.FromPointer); // 0x58 M_IndentElement             ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_BindableContainer                       = GetObject<VisualElement>(new IntPtr(p + 0x060), ReversePrism.DataModels.VisualElement.FromPointer); // 0x60 M_BindableContainer         ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Checkmark                               = GetObject<VisualElement>(new IntPtr(p + 0x068), ReversePrism.DataModels.VisualElement.FromPointer); // 0x68 M_Checkmark                 ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Depth                                   = GetInt32(new IntPtr(p + 0x080)); // 0x80 M_Depth                     ( ModelPrimitiveType int int int Int32 )
            value.M_IndentWidth                             = GetSingle(new IntPtr(p + 0x084)); // 0x84 M_IndentWidth               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
