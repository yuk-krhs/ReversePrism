using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Primary2DMotion                          InternedString IL2CPP_TYPE_VALUETYPE
    // 010 Secondary2DMotion                        ModelEnumType InternedString InternedString InternedString Int32
    // 020 PrimaryAction                            ModelEnumType InternedString InternedString InternedString Int32
    // 030 SecondaryAction                          ModelEnumType InternedString InternedString InternedString Int32
    // 040 PrimaryTrigger                           ModelEnumType InternedString InternedString InternedString Int32
    // 050 SecondaryTrigger                         ModelEnumType InternedString InternedString InternedString Int32
    // 060 Modifier                                 ModelEnumType InternedString InternedString InternedString Int32
    // 070 Position                                 ModelEnumType InternedString InternedString InternedString Int32
    // 080 Orientation                              ModelEnumType InternedString InternedString InternedString Int32
    // 090 Hatswitch                                ModelEnumType InternedString InternedString InternedString Int32
    // 0A0 Back                                     ModelEnumType InternedString InternedString InternedString Int32
    // 0B0 Forward                                  ModelEnumType InternedString InternedString InternedString Int32
    // 0C0 Menu                                     ModelEnumType InternedString InternedString InternedString Int32
    // 0D0 Submit                                   ModelEnumType InternedString InternedString InternedString Int32
    // 0E0 Cancel                                   ModelEnumType InternedString InternedString InternedString Int32
    // 0F0 Horizontal                               ModelEnumType InternedString InternedString InternedString Int32
    // 100 Vertical                                 ModelEnumType InternedString InternedString InternedString Int32
    // 110 Twist                                    ModelEnumType InternedString InternedString InternedString Int32
    // 120 Pressure                                 ModelEnumType InternedString InternedString InternedString Int32
    // 130 ScrollHorizontal                         ModelEnumType InternedString InternedString InternedString Int32
    // 140 ScrollVertical                           ModelEnumType InternedString InternedString InternedString Int32
    // 150 Point                                    ModelEnumType InternedString InternedString InternedString Int32
    // 160 LowFreqMotor                             ModelEnumType InternedString InternedString InternedString Int32
    // 170 HighFreqMotor                            ModelEnumType InternedString InternedString InternedString Int32
    // 180 LeftHand                                 ModelEnumType InternedString InternedString InternedString Int32
    // 190 RightHand                                ModelEnumType InternedString InternedString InternedString Int32
    // 1A0 BatteryStrength                          ModelEnumType InternedString InternedString InternedString Int32
    public partial class CommonUsages : DataModel
    {
        public InternedString                           Secondary2DMotion                       { get; set; }
        public InternedString                           PrimaryAction                           { get; set; }
        public InternedString                           SecondaryAction                         { get; set; }
        public InternedString                           PrimaryTrigger                          { get; set; }
        public InternedString                           SecondaryTrigger                        { get; set; }
        public InternedString                           Modifier                                { get; set; }
        public InternedString                           Position                                { get; set; }
        public InternedString                           Orientation                             { get; set; }
        public InternedString                           Hatswitch                               { get; set; }
        public InternedString                           Back                                    { get; set; }
        public InternedString                           Forward                                 { get; set; }
        public InternedString                           Menu                                    { get; set; }
        public InternedString                           Submit                                  { get; set; }
        public InternedString                           Cancel                                  { get; set; }
        public InternedString                           Horizontal                              { get; set; }
        public InternedString                           Vertical                                { get; set; }
        public InternedString                           Twist                                   { get; set; }
        public InternedString                           Pressure                                { get; set; }
        public InternedString                           ScrollHorizontal                        { get; set; }
        public InternedString                           ScrollVertical                          { get; set; }
        public InternedString                           Point                                   { get; set; }
        public InternedString                           LowFreqMotor                            { get; set; }
        public InternedString                           HighFreqMotor                           { get; set; }
        public InternedString                           LeftHand                                { get; set; }
        public InternedString                           RightHand                               { get; set; }
        public InternedString                           BatteryStrength                         { get; set; }

        public static CommonUsages? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonUsages() { Pointer= p0 };

            value.Secondary2DMotion                         = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 0x10 Secondary2DMotion           ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.PrimaryAction                             = (InternedString)GetInt32(new IntPtr(p + 0x020)); // 0x20 PrimaryAction               ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.SecondaryAction                           = (InternedString)GetInt32(new IntPtr(p + 0x030)); // 0x30 SecondaryAction             ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.PrimaryTrigger                            = (InternedString)GetInt32(new IntPtr(p + 0x040)); // 0x40 PrimaryTrigger              ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.SecondaryTrigger                          = (InternedString)GetInt32(new IntPtr(p + 0x050)); // 0x50 SecondaryTrigger            ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Modifier                                  = (InternedString)GetInt32(new IntPtr(p + 0x060)); // 0x60 Modifier                    ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Position                                  = (InternedString)GetInt32(new IntPtr(p + 0x070)); // 0x70 Position                    ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Orientation                               = (InternedString)GetInt32(new IntPtr(p + 0x080)); // 0x80 Orientation                 ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Hatswitch                                 = (InternedString)GetInt32(new IntPtr(p + 0x090)); // 0x90 Hatswitch                   ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Back                                      = (InternedString)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Back                        ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Forward                                   = (InternedString)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 Forward                     ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Menu                                      = (InternedString)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 Menu                        ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Submit                                    = (InternedString)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 Submit                      ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Cancel                                    = (InternedString)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 Cancel                      ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Horizontal                                = (InternedString)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 Horizontal                  ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Vertical                                  = (InternedString)GetInt32(new IntPtr(p + 0x100)); // 0x100 Vertical                    ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Twist                                     = (InternedString)GetInt32(new IntPtr(p + 0x110)); // 0x110 Twist                       ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Pressure                                  = (InternedString)GetInt32(new IntPtr(p + 0x120)); // 0x120 Pressure                    ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.ScrollHorizontal                          = (InternedString)GetInt32(new IntPtr(p + 0x130)); // 0x130 ScrollHorizontal            ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.ScrollVertical                            = (InternedString)GetInt32(new IntPtr(p + 0x140)); // 0x140 ScrollVertical              ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.Point                                     = (InternedString)GetInt32(new IntPtr(p + 0x150)); // 0x150 Point                       ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.LowFreqMotor                              = (InternedString)GetInt32(new IntPtr(p + 0x160)); // 0x160 LowFreqMotor                ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.HighFreqMotor                             = (InternedString)GetInt32(new IntPtr(p + 0x170)); // 0x170 HighFreqMotor               ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.LeftHand                                  = (InternedString)GetInt32(new IntPtr(p + 0x180)); // 0x180 LeftHand                    ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.RightHand                                 = (InternedString)GetInt32(new IntPtr(p + 0x190)); // 0x190 RightHand                   ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.BatteryStrength                           = (InternedString)GetInt32(new IntPtr(p + 0x1A0)); // 0x1A0 BatteryStrength             ( ModelEnumType InternedString InternedString InternedString Int32 )

            return value;
        }
    }
}
