using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Primary2DMotion                          InternedString IL2CPP_TYPE_VALUETYPE
    // 010 Secondary2DMotion                        0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 020 PrimaryAction                            0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 030 SecondaryAction                          0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 040 PrimaryTrigger                           0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 050 SecondaryTrigger                         0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 060 Modifier                                 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 070 Position                                 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 080 Orientation                              0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 090 Hatswitch                                0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 0A0 Back                                     0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 0B0 Forward                                  0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 0C0 Menu                                     0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 0D0 Submit                                   0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 0E0 Cancel                                   0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 0F0 Horizontal                               0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 100 Vertical                                 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 110 Twist                                    0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 120 Pressure                                 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 130 ScrollHorizontal                         0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 140 ScrollVertical                           0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 150 Point                                    0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 160 LowFreqMotor                             0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 170 HighFreqMotor                            0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 180 LeftHand                                 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 190 RightHand                                0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
    // 1A0 BatteryStrength                          0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32
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

            value.Secondary2DMotion                         = (InternedString)GetInt32(new IntPtr(p + 0x010)); // 02466771DA80 0x10 Secondary2DMotion           ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.PrimaryAction                             = (InternedString)GetInt32(new IntPtr(p + 0x020)); // 02466771DAA0 0x20 PrimaryAction               ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.SecondaryAction                           = (InternedString)GetInt32(new IntPtr(p + 0x030)); // 02466771DAC0 0x30 SecondaryAction             ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.PrimaryTrigger                            = (InternedString)GetInt32(new IntPtr(p + 0x040)); // 02466771DAE0 0x40 PrimaryTrigger              ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.SecondaryTrigger                          = (InternedString)GetInt32(new IntPtr(p + 0x050)); // 02466771DB00 0x50 SecondaryTrigger            ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Modifier                                  = (InternedString)GetInt32(new IntPtr(p + 0x060)); // 02466771DB20 0x60 Modifier                    ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Position                                  = (InternedString)GetInt32(new IntPtr(p + 0x070)); // 02466771DB40 0x70 Position                    ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Orientation                               = (InternedString)GetInt32(new IntPtr(p + 0x080)); // 02466771DB60 0x80 Orientation                 ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Hatswitch                                 = (InternedString)GetInt32(new IntPtr(p + 0x090)); // 02466771DB80 0x90 Hatswitch                   ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Back                                      = (InternedString)GetInt32(new IntPtr(p + 0x0A0)); // 02466771DBA0 0xA0 Back                        ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Forward                                   = (InternedString)GetInt32(new IntPtr(p + 0x0B0)); // 02466771DBC0 0xB0 Forward                     ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Menu                                      = (InternedString)GetInt32(new IntPtr(p + 0x0C0)); // 02466771DBE0 0xC0 Menu                        ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Submit                                    = (InternedString)GetInt32(new IntPtr(p + 0x0D0)); // 02466771DC00 0xD0 Submit                      ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Cancel                                    = (InternedString)GetInt32(new IntPtr(p + 0x0E0)); // 02466771DC20 0xE0 Cancel                      ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Horizontal                                = (InternedString)GetInt32(new IntPtr(p + 0x0F0)); // 02466771DC40 0xF0 Horizontal                  ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Vertical                                  = (InternedString)GetInt32(new IntPtr(p + 0x100)); // 02466771DC60 0x100 Vertical                    ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Twist                                     = (InternedString)GetInt32(new IntPtr(p + 0x110)); // 02466771DC80 0x110 Twist                       ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Pressure                                  = (InternedString)GetInt32(new IntPtr(p + 0x120)); // 02466771DCA0 0x120 Pressure                    ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.ScrollHorizontal                          = (InternedString)GetInt32(new IntPtr(p + 0x130)); // 02466771DCC0 0x130 ScrollHorizontal            ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.ScrollVertical                            = (InternedString)GetInt32(new IntPtr(p + 0x140)); // 02466771DCE0 0x140 ScrollVertical              ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.Point                                     = (InternedString)GetInt32(new IntPtr(p + 0x150)); // 02466771DD00 0x150 Point                       ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.LowFreqMotor                              = (InternedString)GetInt32(new IntPtr(p + 0x160)); // 02466771DD20 0x160 LowFreqMotor                ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.HighFreqMotor                             = (InternedString)GetInt32(new IntPtr(p + 0x170)); // 02466771DD40 0x170 HighFreqMotor               ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.LeftHand                                  = (InternedString)GetInt32(new IntPtr(p + 0x180)); // 02466771DD60 0x180 LeftHand                    ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.RightHand                                 = (InternedString)GetInt32(new IntPtr(p + 0x190)); // 02466771DD80 0x190 RightHand                   ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.BatteryStrength                           = (InternedString)GetInt32(new IntPtr(p + 0x1A0)); // 02466771DDA0 0x1A0 BatteryStrength             ( 0001865FECD0 ModelEnumType InternedString InternedString InternedString Int32 )

            return value;
        }
    }
}
