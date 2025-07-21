using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BindableElement                          ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 <animator>k__BackingField                ValueAnimation`1<StyleValues> IL2CPP_TYPE_GENERICINST
    // 020 Index                                    ModelPrimitiveType int int int Int32
    // 024 Id                                       ModelPrimitiveType int int int Int32
    // 028 IsDragGhost                              ModelPrimitiveType bool bool bool Bool
    // 030 onGeometryChanged                        Action`1<ReusableCollectionItem> IL2CPP_TYPE_GENERICINST
    // 038 m_GeometryChangedEventCallback           EventCallback`1<GeometryChangedEvent> IL2CPP_TYPE_GENERICINST
    // 040 onDestroy                                Action`1<ReusableCollectionItem> IL2CPP_TYPE_GENERICINST
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

            value.BindableElement                           = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 BindableElement             ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x024)); // 0x24 Id                          ( ModelPrimitiveType int int int Int32 )
            value.IsDragGhost                               = GetBool(new IntPtr(p + 0x028)); // 0x28 IsDragGhost                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
