using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 DrawArea                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 ExpandToggle                             ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 090 ExpandToggleTransform                    ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 LayoutGroup                              ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer
    // 0A0 ExpandArrow                              ModelClassType Image Image Image Pointer
    // 0A8 Elements                                 ModelClassListType List`1<InspectorField> List`1<InspectorField> List<InspectorField> Pointer
    // 0B0 ExposedMethods                           ModelClassListType List`1<ExposedMethodField> List`1<ExposedMethodField> List<ExposedMethodField> Pointer
    // 0B8 M_isExpanded                             ModelPrimitiveType bool bool bool Bool
    // 0BC M_headerVisibility                       ModelEnumType HeaderVisibility HeaderVisibility HeaderVisibility Int32
    public partial class ExpandableInspectorField : DataModel
    {
        public RectTransform?                           DrawArea                                { get; set; }
        public PointerEventListener?                    ExpandToggle                            { get; set; }
        public RectTransform?                           ExpandToggleTransform                   { get; set; }
        public LayoutGroup?                             LayoutGroup                             { get; set; }
        public Image?                                   ExpandArrow                             { get; set; }
        public List<InspectorField>?                    Elements                                { get; set; }
        public List<ExposedMethodField>?                ExposedMethods                          { get; set; }
        public bool                                     M_isExpanded                            { get; set; }
        public HeaderVisibility                         M_headerVisibility                      { get; set; }

        public static ExpandableInspectorField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpandableInspectorField() { Pointer= p0 };

            value.DrawArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 0x80 DrawArea                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ExpandToggle                              = GetObject<PointerEventListener>(new IntPtr(p + 0x088), ReversePrism.DataModels.PointerEventListener.FromPointer); // 0x88 ExpandToggle                ( ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.ExpandToggleTransform                     = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 0x90 ExpandToggleTransform       ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LayoutGroup                               = GetObject<LayoutGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.LayoutGroup.FromPointer); // 0x98 LayoutGroup                 ( ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer )
            value.ExpandArrow                               = GetObject<Image>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Image.FromPointer); // 0xA0 ExpandArrow                 ( ModelClassType Image Image Image Pointer )
            value.Elements                                  = GetObjectList<InspectorField>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.InspectorField.FromPointer); // 0xA8 Elements                    ( ModelClassListType List`1<InspectorField> List`1<InspectorField> List<InspectorField> Pointer )
            value.ExposedMethods                            = GetObjectList<ExposedMethodField>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ExposedMethodField.FromPointer); // 0xB0 ExposedMethods              ( ModelClassListType List`1<ExposedMethodField> List`1<ExposedMethodField> List<ExposedMethodField> Pointer )
            value.M_isExpanded                              = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 M_isExpanded                ( ModelPrimitiveType bool bool bool Bool )
            value.M_headerVisibility                        = (HeaderVisibility)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC M_headerVisibility          ( ModelEnumType HeaderVisibility HeaderVisibility HeaderVisibility Int32 )

            return value;
        }
    }
}
