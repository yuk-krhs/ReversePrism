using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <textElement>k__BackingField             TextElement IL2CPP_TYPE_CLASS
    // 000 scrollView                               ScrollView IL2CPP_TYPE_CLASS
    // 000 multilineContainer                       VisualElement IL2CPP_TYPE_CLASS
    // 000 innerComponentsModifierName              string IL2CPP_TYPE_STRING
    // 000 innerTextElementUssClassName             string IL2CPP_TYPE_STRING
    // 000 innerTextElementWithScrollViewUssClassName string IL2CPP_TYPE_STRING
    // 000 horizontalVariantInnerTextElementUssClassName string IL2CPP_TYPE_STRING
    // 000 verticalVariantInnerTextElementUssClassName string IL2CPP_TYPE_STRING
    // 000 verticalHorizontalVariantInnerTextElementUssClassName string IL2CPP_TYPE_STRING
    // 000 innerScrollviewUssClassName              string IL2CPP_TYPE_STRING
    // 000 innerViewportUssClassName                string IL2CPP_TYPE_STRING
    // 000 innerContentContainerUssClassName        string IL2CPP_TYPE_STRING
    // 000 <isDragging>k__BackingField              bool IL2CPP_TYPE_BOOLEAN
    // 000 scrollOffset                             Vector2 IL2CPP_TYPE_VALUETYPE
    // 000 m_ScrollViewWasClamped                   bool IL2CPP_TYPE_BOOLEAN
    // 000 lastCursorPos                            Vector2 IL2CPP_TYPE_VALUETYPE
    // 000 m_VerticalScrollerVisibility             ScrollerVisibility IL2CPP_TYPE_VALUETYPE
    public partial class TextInputBase : DataModel
    {

        public static TextInputBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextInputBase() { Pointer= p0 };


            return value;
        }
    }
}
