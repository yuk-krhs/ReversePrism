using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Vocal                                    Color IL2CPP_TYPE_VALUETYPE
    // 010 Dance                                    ModelEnumType Color Color Color Int32
    // 020 Visual                                   ModelEnumType Color Color Color Int32
    // 030 Mental                                   ModelEnumType Color Color Color Int32
    // 040 OutlineBlack                             ModelEnumType Color Color Color Int32
    // 050 DisableWhite                             ModelEnumType Color Color Color Int32
    // 060 ButtonGreen                              ModelEnumType Color Color Color Int32
    // 070 BackgroundGreen                          ModelEnumType Color Color Color Int32
    // 080 DisableLabel                             ModelEnumType Color Color Color Int32
    // 090 White                                    ModelEnumType Color Color Color Int32
    // 0A0 Black                                    ModelEnumType Color Color Color Int32
    // 0B0 UnitBlue                                 ModelEnumType Color Color Color Int32
    // 0C0 WarningRed                               ModelEnumType Color Color Color Int32
    // 0D0 Inactive                                 ModelEnumType Color Color Color Int32
    // 0E0 Inactive2                                ModelEnumType Color Color Color Int32
    // 0F0 Hint                                     ModelEnumType Color Color Color Int32
    // 100 OverFlow                                 ModelEnumType Color Color Color Int32
    // 110 LinkPinc                                 ModelEnumType Color Color Color Int32
    // 120 LightBlue                                ModelEnumType Color Color Color Int32
    // 130 LightRed                                 ModelEnumType Color Color Color Int32
    // 140 DefaultCharacterProfileFontColor         ModelEnumType Color Color Color Int32
    // 150 DefaultCharacterProfileBgColor           ModelEnumType Color Color Color Int32
    public partial class PRISMColorizeUtility : DataModel
    {
        public Color                                    Dance                                   { get; set; }
        public Color                                    Visual                                  { get; set; }
        public Color                                    Mental                                  { get; set; }
        public Color                                    OutlineBlack                            { get; set; }
        public Color                                    DisableWhite                            { get; set; }
        public Color                                    ButtonGreen                             { get; set; }
        public Color                                    BackgroundGreen                         { get; set; }
        public Color                                    DisableLabel                            { get; set; }
        public Color                                    White                                   { get; set; }
        public Color                                    Black                                   { get; set; }
        public Color                                    UnitBlue                                { get; set; }
        public Color                                    WarningRed                              { get; set; }
        public Color                                    Inactive                                { get; set; }
        public Color                                    Inactive2                               { get; set; }
        public Color                                    Hint                                    { get; set; }
        public Color                                    OverFlow                                { get; set; }
        public Color                                    LinkPinc                                { get; set; }
        public Color                                    LightBlue                               { get; set; }
        public Color                                    LightRed                                { get; set; }
        public Color                                    DefaultCharacterProfileFontColor        { get; set; }
        public Color                                    DefaultCharacterProfileBgColor          { get; set; }

        public static PRISMColorizeUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PRISMColorizeUtility() { Pointer= p0 };

            value.Dance                                     = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 Dance                       ( ModelEnumType Color Color Color Int32 )
            value.Visual                                    = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 Visual                      ( ModelEnumType Color Color Color Int32 )
            value.Mental                                    = (Color)GetInt32(new IntPtr(p + 0x030)); // 0x30 Mental                      ( ModelEnumType Color Color Color Int32 )
            value.OutlineBlack                              = (Color)GetInt32(new IntPtr(p + 0x040)); // 0x40 OutlineBlack                ( ModelEnumType Color Color Color Int32 )
            value.DisableWhite                              = (Color)GetInt32(new IntPtr(p + 0x050)); // 0x50 DisableWhite                ( ModelEnumType Color Color Color Int32 )
            value.ButtonGreen                               = (Color)GetInt32(new IntPtr(p + 0x060)); // 0x60 ButtonGreen                 ( ModelEnumType Color Color Color Int32 )
            value.BackgroundGreen                           = (Color)GetInt32(new IntPtr(p + 0x070)); // 0x70 BackgroundGreen             ( ModelEnumType Color Color Color Int32 )
            value.DisableLabel                              = (Color)GetInt32(new IntPtr(p + 0x080)); // 0x80 DisableLabel                ( ModelEnumType Color Color Color Int32 )
            value.White                                     = (Color)GetInt32(new IntPtr(p + 0x090)); // 0x90 White                       ( ModelEnumType Color Color Color Int32 )
            value.Black                                     = (Color)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Black                       ( ModelEnumType Color Color Color Int32 )
            value.UnitBlue                                  = (Color)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 UnitBlue                    ( ModelEnumType Color Color Color Int32 )
            value.WarningRed                                = (Color)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 WarningRed                  ( ModelEnumType Color Color Color Int32 )
            value.Inactive                                  = (Color)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 Inactive                    ( ModelEnumType Color Color Color Int32 )
            value.Inactive2                                 = (Color)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 Inactive2                   ( ModelEnumType Color Color Color Int32 )
            value.Hint                                      = (Color)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 Hint                        ( ModelEnumType Color Color Color Int32 )
            value.OverFlow                                  = (Color)GetInt32(new IntPtr(p + 0x100)); // 0x100 OverFlow                    ( ModelEnumType Color Color Color Int32 )
            value.LinkPinc                                  = (Color)GetInt32(new IntPtr(p + 0x110)); // 0x110 LinkPinc                    ( ModelEnumType Color Color Color Int32 )
            value.LightBlue                                 = (Color)GetInt32(new IntPtr(p + 0x120)); // 0x120 LightBlue                   ( ModelEnumType Color Color Color Int32 )
            value.LightRed                                  = (Color)GetInt32(new IntPtr(p + 0x130)); // 0x130 LightRed                    ( ModelEnumType Color Color Color Int32 )
            value.DefaultCharacterProfileFontColor          = (Color)GetInt32(new IntPtr(p + 0x140)); // 0x140 DefaultCharacterProfileFontColor ( ModelEnumType Color Color Color Int32 )
            value.DefaultCharacterProfileBgColor            = (Color)GetInt32(new IntPtr(p + 0x150)); // 0x150 DefaultCharacterProfileBgColor ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
