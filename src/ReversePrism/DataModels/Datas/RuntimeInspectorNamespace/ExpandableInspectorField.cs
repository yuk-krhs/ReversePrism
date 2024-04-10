using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 DrawArea                                 000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 ExpandToggle                             00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 090 ExpandToggleTransform                    000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 098 LayoutGroup                              00018650CD20 ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer
    // 0A0 ExpandArrow                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 0A8 Elements                                 000185CECB18 ModelClassListType List`1<InspectorField> List`1<InspectorField> List<InspectorField> Pointer
    // 0B0 ExposedMethods                           000185CDBBB8 ModelClassListType List`1<ExposedMethodField> List`1<ExposedMethodField> List<ExposedMethodField> Pointer
    // 0B8 M_isExpanded                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0BC M_headerVisibility                       0001866ED1E0 ModelEnumType HeaderVisibility HeaderVisibility HeaderVisibility Int32
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

            value.DrawArea                                  = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B236218 0x80 DrawArea                    ( 000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ExpandToggle                              = GetObject<PointerEventListener>(new IntPtr(p + 0x088), ReversePrism.DataModels.PointerEventListener.FromPointer); // 02466B236238 0x88 ExpandToggle                ( 00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.ExpandToggleTransform                     = GetObject<RectTransform>(new IntPtr(p + 0x090), ReversePrism.DataModels.RectTransform.FromPointer); // 02466B236258 0x90 ExpandToggleTransform       ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LayoutGroup                               = GetObject<LayoutGroup>(new IntPtr(p + 0x098), ReversePrism.DataModels.LayoutGroup.FromPointer); // 02466B236278 0x98 LayoutGroup                 ( 00018650CD20 ModelClassType LayoutGroup LayoutGroup LayoutGroup Pointer )
            value.ExpandArrow                               = GetObject<Image>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Image.FromPointer); // 02466B236298 0xA0 ExpandArrow                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Elements                                  = GetObjectList<InspectorField>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.InspectorField.FromPointer); // 02466B2362B8 0xA8 Elements                    ( 000185CECB18 ModelClassListType List`1<InspectorField> List`1<InspectorField> List<InspectorField> Pointer )
            value.ExposedMethods                            = GetObjectList<ExposedMethodField>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ExposedMethodField.FromPointer); // 02466B2362D8 0xB0 ExposedMethods              ( 000185CDBBB8 ModelClassListType List`1<ExposedMethodField> List`1<ExposedMethodField> List<ExposedMethodField> Pointer )
            value.M_isExpanded                              = GetBool(new IntPtr(p + 0x0B8)); // 02466B2362F8 0xB8 M_isExpanded                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_headerVisibility                        = (HeaderVisibility)GetInt32(new IntPtr(p + 0x0BC)); // 02466B236318 0xBC M_headerVisibility          ( 0001866ED1E0 ModelEnumType HeaderVisibility HeaderVisibility HeaderVisibility Int32 )

            return value;
        }
    }
}
