using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BindableElement                          0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 <animator>k__BackingField                ValueAnimation`1<StyleValues> IL2CPP_TYPE_GENERICINST
    // 020 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Id                                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 IsDragGhost                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 onGeometryChanged                        Action`1<ReusableCollectionItem> IL2CPP_TYPE_GENERICINST
    // 038 m_GeometryChangedEventCallback           EventCallback`1<GeometryChangedEvent> IL2CPP_TYPE_GENERICINST
    public partial class ReusableCollectionItem : DataModel
    {
        public VisualElement?                           BindableElement                         { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      Id                                      { get; set; }
        public bool                                     IsDragGhost                             { get; set; }

        public static ReusableCollectionItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReusableCollectionItem() { Pointer= p0 };

            value.BindableElement                           = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66AFAD8 0x10 BindableElement             ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 0245A66AFB18 0x20 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x024)); // 0245A66AFB38 0x24 Id                          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsDragGhost                               = GetBool(new IntPtr(p + 0x028)); // 0245A66AFB58 0x28 IsDragGhost                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
