using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BackgroundColor                          ModelEnumType Color Color Color Int32
    // 020 BackgroundImage                          ModelEnumType Background Background Background Int32
    // 040 BackgroundPositionX                      ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 04C BackgroundPositionY                      ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32
    // 058 BackgroundRepeat                         ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32
    // 060 BackgroundSize                           ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32
    // 074 BorderBottomColor                        ModelEnumType Color Color Color Int32
    // 084 BorderBottomLeftRadius                   ModelEnumType Length Length Length Int32
    // 08C BorderBottomRightRadius                  ModelEnumType Length Length Length Int32
    // 094 BorderLeftColor                          ModelEnumType Color Color Color Int32
    // 0A4 BorderRightColor                         ModelEnumType Color Color Color Int32
    // 0B4 BorderTopColor                           ModelEnumType Color Color Color Int32
    // 0C4 BorderTopLeftRadius                      ModelEnumType Length Length Length Int32
    // 0CC BorderTopRightRadius                     ModelEnumType Length Length Length Int32
    // 0D4 Opacity                                  ModelPrimitiveType float float float Single
    // 0D8 Overflow                                 ModelEnumType OverflowInternal OverflowInternal OverflowInternal Int32
    public partial class VisualData : DataModel
    {
        public Color                                    BackgroundColor                         { get; set; }
        public Background                               BackgroundImage                         { get; set; }
        public BackgroundPosition                       BackgroundPositionX                     { get; set; }
        public BackgroundPosition                       BackgroundPositionY                     { get; set; }
        public BackgroundRepeat                         BackgroundRepeat                        { get; set; }
        public BackgroundSize                           BackgroundSize                          { get; set; }
        public Color                                    BorderBottomColor                       { get; set; }
        public Length                                   BorderBottomLeftRadius                  { get; set; }
        public Length                                   BorderBottomRightRadius                 { get; set; }
        public Color                                    BorderLeftColor                         { get; set; }
        public Color                                    BorderRightColor                        { get; set; }
        public Color                                    BorderTopColor                          { get; set; }
        public Length                                   BorderTopLeftRadius                     { get; set; }
        public Length                                   BorderTopRightRadius                    { get; set; }
        public float                                    Opacity                                 { get; set; }
        public OverflowInternal                         Overflow                                { get; set; }

        public static VisualData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualData() { Pointer= p0 };

            value.BackgroundColor                           = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 BackgroundColor             ( ModelEnumType Color Color Color Int32 )
            value.BackgroundImage                           = (Background)GetInt32(new IntPtr(p + 0x020)); // 0x20 BackgroundImage             ( ModelEnumType Background Background Background Int32 )
            value.BackgroundPositionX                       = (BackgroundPosition)GetInt32(new IntPtr(p + 0x040)); // 0x40 BackgroundPositionX         ( ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.BackgroundPositionY                       = (BackgroundPosition)GetInt32(new IntPtr(p + 0x04C)); // 0x4C BackgroundPositionY         ( ModelEnumType BackgroundPosition BackgroundPosition BackgroundPosition Int32 )
            value.BackgroundRepeat                          = (BackgroundRepeat)GetInt32(new IntPtr(p + 0x058)); // 0x58 BackgroundRepeat            ( ModelEnumType BackgroundRepeat BackgroundRepeat BackgroundRepeat Int32 )
            value.BackgroundSize                            = (BackgroundSize)GetInt32(new IntPtr(p + 0x060)); // 0x60 BackgroundSize              ( ModelEnumType BackgroundSize BackgroundSize BackgroundSize Int32 )
            value.BorderBottomColor                         = (Color)GetInt32(new IntPtr(p + 0x074)); // 0x74 BorderBottomColor           ( ModelEnumType Color Color Color Int32 )
            value.BorderBottomLeftRadius                    = (Length)GetInt32(new IntPtr(p + 0x084)); // 0x84 BorderBottomLeftRadius      ( ModelEnumType Length Length Length Int32 )
            value.BorderBottomRightRadius                   = (Length)GetInt32(new IntPtr(p + 0x08C)); // 0x8C BorderBottomRightRadius     ( ModelEnumType Length Length Length Int32 )
            value.BorderLeftColor                           = (Color)GetInt32(new IntPtr(p + 0x094)); // 0x94 BorderLeftColor             ( ModelEnumType Color Color Color Int32 )
            value.BorderRightColor                          = (Color)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 BorderRightColor            ( ModelEnumType Color Color Color Int32 )
            value.BorderTopColor                            = (Color)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 BorderTopColor              ( ModelEnumType Color Color Color Int32 )
            value.BorderTopLeftRadius                       = (Length)GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 BorderTopLeftRadius         ( ModelEnumType Length Length Length Int32 )
            value.BorderTopRightRadius                      = (Length)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC BorderTopRightRadius        ( ModelEnumType Length Length Length Int32 )
            value.Opacity                                   = GetSingle(new IntPtr(p + 0x0D4)); // 0xD4 Opacity                     ( ModelPrimitiveType float float float Single )
            value.Overflow                                  = (OverflowInternal)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 Overflow                    ( ModelEnumType OverflowInternal OverflowInternal OverflowInternal Int32 )

            return value;
        }
    }
}
