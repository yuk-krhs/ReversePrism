using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Padding                                000186651850 ModelClassType RectOffset RectOffset RectOffset Pointer
    // 028 M_ChildAlignment                         000186633930 ModelEnumType TextAnchor TextAnchor TextAnchor Int32
    // 030 M_Rect                                   000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 M_Tracker                                000186705E30 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    // 03C M_TotalMinSize                           0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 044 M_TotalPreferredSize                     0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 04C M_TotalFlexibleSize                      0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 058 M_RectChildren                           000185D00B78 ModelClassListType List`1<RectTransform> List`1<RectTransform> List<RectTransform> Pointer
    public partial class LayoutGroup : DataModel
    {
        public RectOffset?                              M_Padding                               { get; set; }
        public TextAnchor                               M_ChildAlignment                        { get; set; }
        public RectTransform?                           M_Rect                                  { get; set; }
        public DrivenRectTransformTracker               M_Tracker                               { get; set; }
        public Vector2                                  M_TotalMinSize                          { get; set; }
        public Vector2                                  M_TotalPreferredSize                    { get; set; }
        public Vector2                                  M_TotalFlexibleSize                     { get; set; }
        public List<RectTransform>?                     M_RectChildren                          { get; set; }

        public static LayoutGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutGroup() { Pointer= p0 };

            value.M_Padding                                 = GetObject<RectOffset>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectOffset.FromPointer); // 0245A3F9AA68 0x20 M_Padding                   ( 000186651850 ModelClassType RectOffset RectOffset RectOffset Pointer )
            value.M_ChildAlignment                          = (TextAnchor)GetInt32(new IntPtr(p + 0x028)); // 0245A3F9AA88 0x28 M_ChildAlignment            ( 000186633930 ModelEnumType TextAnchor TextAnchor TextAnchor Int32 )
            value.M_Rect                                    = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0245A3F9AAA8 0x30 M_Rect                      ( 000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Tracker                                 = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x038)); // 0245A3F9AAC8 0x38 M_Tracker                   ( 000186705E30 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )
            value.M_TotalMinSize                            = (Vector2)GetInt32(new IntPtr(p + 0x03C)); // 0245A3F9AAE8 0x3C M_TotalMinSize              ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_TotalPreferredSize                      = (Vector2)GetInt32(new IntPtr(p + 0x044)); // 0245A3F9AB08 0x44 M_TotalPreferredSize        ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_TotalFlexibleSize                       = (Vector2)GetInt32(new IntPtr(p + 0x04C)); // 0245A3F9AB28 0x4C M_TotalFlexibleSize         ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_RectChildren                            = GetObjectList<RectTransform>(new IntPtr(p + 0x058), ReversePrism.DataModels.RectTransform.FromPointer); // 0245A3F9AB48 0x58 M_RectChildren              ( 000185D00B78 ModelClassListType List`1<RectTransform> List`1<RectTransform> List<RectTransform> Pointer )

            return value;
        }
    }
}
