using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cursor                                   ModelEnumType Cursor Cursor Cursor Int32
    // 028 TextOverflow                             ModelEnumType TextOverflow TextOverflow TextOverflow Int32
    // 02C UnityBackgroundImageTintColor            ModelEnumType Color Color Color Int32
    // 03C UnityOverflowClipBox                     ModelEnumType OverflowClipBox OverflowClipBox OverflowClipBox Int32
    // 040 UnitySliceBottom                         ModelPrimitiveType int int int Int32
    // 044 UnitySliceLeft                           ModelPrimitiveType int int int Int32
    // 048 UnitySliceRight                          ModelPrimitiveType int int int Int32
    // 04C UnitySliceScale                          ModelPrimitiveType float float float Single
    // 050 UnitySliceTop                            ModelPrimitiveType int int int Int32
    // 054 UnityTextOverflowPosition                ModelEnumType TextOverflowPosition TextOverflowPosition TextOverflowPosition Int32
    public partial class RareData : DataModel
    {
        public Cursor                                   Cursor                                  { get; set; }
        public TextOverflow                             TextOverflow                            { get; set; }
        public Color                                    UnityBackgroundImageTintColor           { get; set; }
        public OverflowClipBox                          UnityOverflowClipBox                    { get; set; }
        public int                                      UnitySliceBottom                        { get; set; }
        public int                                      UnitySliceLeft                          { get; set; }
        public int                                      UnitySliceRight                         { get; set; }
        public float                                    UnitySliceScale                         { get; set; }
        public int                                      UnitySliceTop                           { get; set; }
        public TextOverflowPosition                     UnityTextOverflowPosition               { get; set; }

        public static RareData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RareData() { Pointer= p0 };

            value.Cursor                                    = (Cursor)GetInt32(new IntPtr(p + 0x010)); // 0x10 Cursor                      ( ModelEnumType Cursor Cursor Cursor Int32 )
            value.TextOverflow                              = (TextOverflow)GetInt32(new IntPtr(p + 0x028)); // 0x28 TextOverflow                ( ModelEnumType TextOverflow TextOverflow TextOverflow Int32 )
            value.UnityBackgroundImageTintColor             = (Color)GetInt32(new IntPtr(p + 0x02C)); // 0x2C UnityBackgroundImageTintColor ( ModelEnumType Color Color Color Int32 )
            value.UnityOverflowClipBox                      = (OverflowClipBox)GetInt32(new IntPtr(p + 0x03C)); // 0x3C UnityOverflowClipBox        ( ModelEnumType OverflowClipBox OverflowClipBox OverflowClipBox Int32 )
            value.UnitySliceBottom                          = GetInt32(new IntPtr(p + 0x040)); // 0x40 UnitySliceBottom            ( ModelPrimitiveType int int int Int32 )
            value.UnitySliceLeft                            = GetInt32(new IntPtr(p + 0x044)); // 0x44 UnitySliceLeft              ( ModelPrimitiveType int int int Int32 )
            value.UnitySliceRight                           = GetInt32(new IntPtr(p + 0x048)); // 0x48 UnitySliceRight             ( ModelPrimitiveType int int int Int32 )
            value.UnitySliceScale                           = GetSingle(new IntPtr(p + 0x04C)); // 0x4C UnitySliceScale             ( ModelPrimitiveType float float float Single )
            value.UnitySliceTop                             = GetInt32(new IntPtr(p + 0x050)); // 0x50 UnitySliceTop               ( ModelPrimitiveType int int int Int32 )
            value.UnityTextOverflowPosition                 = (TextOverflowPosition)GetInt32(new IntPtr(p + 0x054)); // 0x54 UnityTextOverflowPosition   ( ModelEnumType TextOverflowPosition TextOverflowPosition TextOverflowPosition Int32 )

            return value;
        }
    }
}
