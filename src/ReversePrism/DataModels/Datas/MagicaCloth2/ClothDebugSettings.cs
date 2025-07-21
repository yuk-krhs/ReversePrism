using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 011 Ztest                                    ModelPrimitiveType bool bool bool Bool
    // 012 Position                                 ModelPrimitiveType bool bool bool Bool
    // 014 Axis                                     ModelEnumType DebugAxis DebugAxis DebugAxis Int32
    // 018 Shape                                    ModelPrimitiveType bool bool bool Bool
    // 019 BaseLine                                 ModelPrimitiveType bool bool bool Bool
    // 01A Depth                                    ModelPrimitiveType bool bool bool Bool
    // 01B Collider                                 ModelPrimitiveType bool bool bool Bool
    // 01C AnimatedPosition                         ModelPrimitiveType bool bool bool Bool
    // 020 AnimatedAxis                             ModelEnumType DebugAxis DebugAxis DebugAxis Int32
    // 024 AnimatedShape                            ModelPrimitiveType bool bool bool Bool
    // 025 InertiaCenter                            ModelPrimitiveType bool bool bool Bool
    public partial class ClothDebugSettings : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public bool                                     Ztest                                   { get; set; }
        public bool                                     Position                                { get; set; }
        public DebugAxis                                Axis                                    { get; set; }
        public bool                                     Shape                                   { get; set; }
        public bool                                     BaseLine                                { get; set; }
        public bool                                     Depth                                   { get; set; }
        public bool                                     Collider                                { get; set; }
        public bool                                     AnimatedPosition                        { get; set; }
        public DebugAxis                                AnimatedAxis                            { get; set; }
        public bool                                     AnimatedShape                           { get; set; }
        public bool                                     InertiaCenter                           { get; set; }

        public static ClothDebugSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClothDebugSettings() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.Ztest                                     = GetBool(new IntPtr(p + 0x011)); // 0x11 Ztest                       ( ModelPrimitiveType bool bool bool Bool )
            value.Position                                  = GetBool(new IntPtr(p + 0x012)); // 0x12 Position                    ( ModelPrimitiveType bool bool bool Bool )
            value.Axis                                      = (DebugAxis)GetInt32(new IntPtr(p + 0x014)); // 0x14 Axis                        ( ModelEnumType DebugAxis DebugAxis DebugAxis Int32 )
            value.Shape                                     = GetBool(new IntPtr(p + 0x018)); // 0x18 Shape                       ( ModelPrimitiveType bool bool bool Bool )
            value.BaseLine                                  = GetBool(new IntPtr(p + 0x019)); // 0x19 BaseLine                    ( ModelPrimitiveType bool bool bool Bool )
            value.Depth                                     = GetBool(new IntPtr(p + 0x01A)); // 0x1A Depth                       ( ModelPrimitiveType bool bool bool Bool )
            value.Collider                                  = GetBool(new IntPtr(p + 0x01B)); // 0x1B Collider                    ( ModelPrimitiveType bool bool bool Bool )
            value.AnimatedPosition                          = GetBool(new IntPtr(p + 0x01C)); // 0x1C AnimatedPosition            ( ModelPrimitiveType bool bool bool Bool )
            value.AnimatedAxis                              = (DebugAxis)GetInt32(new IntPtr(p + 0x020)); // 0x20 AnimatedAxis                ( ModelEnumType DebugAxis DebugAxis DebugAxis Int32 )
            value.AnimatedShape                             = GetBool(new IntPtr(p + 0x024)); // 0x24 AnimatedShape               ( ModelPrimitiveType bool bool bool Bool )
            value.InertiaCenter                             = GetBool(new IntPtr(p + 0x025)); // 0x25 InertiaCenter               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
