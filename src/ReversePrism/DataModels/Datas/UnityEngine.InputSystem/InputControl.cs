using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StateBlock                             0001865F0800 ModelEnumType InputStateBlock InputStateBlock InputStateBlock Int32
    // 020 M_Name                                   0001865FE3A0 ModelEnumType InternedString InternedString InternedString Int32
    // 030 M_Path                                   000186671BA0 ModelPrimitiveType string string string String
    // 038 M_DisplayName                            000186671BA0 ModelPrimitiveType string string string String
    // 040 M_DisplayNameFromLayout                  000186671BA0 ModelPrimitiveType string string string String
    // 048 M_ShortDisplayName                       000186671BA0 ModelPrimitiveType string string string String
    // 050 M_ShortDisplayNameFromLayout             000186671BA0 ModelPrimitiveType string string string String
    // 058 M_Layout                                 0001865FE3A0 ModelEnumType InternedString InternedString InternedString Int32
    // 068 M_Variants                               0001865FE3A0 ModelEnumType InternedString InternedString InternedString Int32
    // 078 M_Device                                 0001866FB0A0 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 080 M_Parent                                 0001865EB450 ModelClassType InputControl InputControl InputControl Pointer
    // 088 M_UsageCount                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 08C M_UsageStartIndex                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 090 M_AliasCount                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 094 M_AliasStartIndex                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 098 M_ChildCount                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 09C M_ChildStartIndex                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 0A0 M_ControlFlags                           000186626160 ModelEnumType ControlFlags ControlFlags ControlFlags Int32
    // 0A4 M_CachedValueIsStale                     000186595210 ModelPrimitiveType bool bool bool Bool
    // 0A5 M_UnprocessedCachedValueIsStale          000186595210 ModelPrimitiveType bool bool bool Bool
    // 0A8 M_DefaultState                           000186514700 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0B8 M_MinValue                               000186514700 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0C8 M_MaxValue                               000186514700 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0D8 M_OptimizedControlDataType               0001865BB440 ModelEnumType FourCC FourCC FourCC Int32
    public partial class InputControl : DataModel
    {
        public InputStateBlock                          M_StateBlock                            { get; set; }
        public InternedString                           M_Name                                  { get; set; }
        public string                                   M_Path                                  { get; set; }
        public string                                   M_DisplayName                           { get; set; }
        public string                                   M_DisplayNameFromLayout                 { get; set; }
        public string                                   M_ShortDisplayName                      { get; set; }
        public string                                   M_ShortDisplayNameFromLayout            { get; set; }
        public InternedString                           M_Layout                                { get; set; }
        public InternedString                           M_Variants                              { get; set; }
        public InputDevice?                             M_Device                                { get; set; }
        public InputControl?                            M_Parent                                { get; set; }
        public int                                      M_UsageCount                            { get; set; }
        public int                                      M_UsageStartIndex                       { get; set; }
        public int                                      M_AliasCount                            { get; set; }
        public int                                      M_AliasStartIndex                       { get; set; }
        public int                                      M_ChildCount                            { get; set; }
        public int                                      M_ChildStartIndex                       { get; set; }
        public ControlFlags                             M_ControlFlags                          { get; set; }
        public bool                                     M_CachedValueIsStale                    { get; set; }
        public bool                                     M_UnprocessedCachedValueIsStale         { get; set; }
        public PrimitiveValue                           M_DefaultState                          { get; set; }
        public PrimitiveValue                           M_MinValue                              { get; set; }
        public PrimitiveValue                           M_MaxValue                              { get; set; }
        public FourCC                                   M_OptimizedControlDataType              { get; set; }

        public static InputControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputControl() { Pointer= p0 };

            value.M_StateBlock                              = (InputStateBlock)GetInt32(new IntPtr(p + 0x010)); // 0245A2E356B8 0x10 M_StateBlock                ( 0001865F0800 ModelEnumType InputStateBlock InputStateBlock InputStateBlock Int32 )
            value.M_Name                                    = (InternedString)GetInt32(new IntPtr(p + 0x020)); // 0245A2E356D8 0x20 M_Name                      ( 0001865FE3A0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_Path                                    = GetString(new IntPtr(p + 0x030)); // 0245A2E356F8 0x30 M_Path                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_DisplayName                             = GetString(new IntPtr(p + 0x038)); // 0245A2E35718 0x38 M_DisplayName               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_DisplayNameFromLayout                   = GetString(new IntPtr(p + 0x040)); // 0245A2E35738 0x40 M_DisplayNameFromLayout     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_ShortDisplayName                        = GetString(new IntPtr(p + 0x048)); // 0245A2E35758 0x48 M_ShortDisplayName          ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_ShortDisplayNameFromLayout              = GetString(new IntPtr(p + 0x050)); // 0245A2E35778 0x50 M_ShortDisplayNameFromLayout ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Layout                                  = (InternedString)GetInt32(new IntPtr(p + 0x058)); // 0245A2E35798 0x58 M_Layout                    ( 0001865FE3A0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_Variants                                = (InternedString)GetInt32(new IntPtr(p + 0x068)); // 0245A2E357B8 0x68 M_Variants                  ( 0001865FE3A0 ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_Device                                  = GetObject<InputDevice>(new IntPtr(p + 0x078), ReversePrism.DataModels.InputDevice.FromPointer); // 0245A2E357D8 0x78 M_Device                    ( 0001866FB0A0 ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.M_Parent                                  = GetObject<InputControl>(new IntPtr(p + 0x080), ReversePrism.DataModels.InputControl.FromPointer); // 0245A2E357F8 0x80 M_Parent                    ( 0001865EB450 ModelClassType InputControl InputControl InputControl Pointer )
            value.M_UsageCount                              = GetInt32(new IntPtr(p + 0x088)); // 0245A2E35818 0x88 M_UsageCount                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_UsageStartIndex                         = GetInt32(new IntPtr(p + 0x08C)); // 0245A2E35838 0x8C M_UsageStartIndex           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AliasCount                              = GetInt32(new IntPtr(p + 0x090)); // 0245A2E35858 0x90 M_AliasCount                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_AliasStartIndex                         = GetInt32(new IntPtr(p + 0x094)); // 0245A2E35878 0x94 M_AliasStartIndex           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_ChildCount                              = GetInt32(new IntPtr(p + 0x098)); // 0245A2E35898 0x98 M_ChildCount                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_ChildStartIndex                         = GetInt32(new IntPtr(p + 0x09C)); // 0245A2E358B8 0x9C M_ChildStartIndex           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_ControlFlags                            = (ControlFlags)GetInt32(new IntPtr(p + 0x0A0)); // 0245A2E358D8 0xA0 M_ControlFlags              ( 000186626160 ModelEnumType ControlFlags ControlFlags ControlFlags Int32 )
            value.M_CachedValueIsStale                      = GetBool(new IntPtr(p + 0x0A4)); // 0245A2E358F8 0xA4 M_CachedValueIsStale        ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_UnprocessedCachedValueIsStale           = GetBool(new IntPtr(p + 0x0A5)); // 0245A2E35918 0xA5 M_UnprocessedCachedValueIsStale ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_DefaultState                            = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0A8)); // 0245A2E35938 0xA8 M_DefaultState              ( 000186514700 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.M_MinValue                                = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0B8)); // 0245A2E35958 0xB8 M_MinValue                  ( 000186514700 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.M_MaxValue                                = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0C8)); // 0245A2E35978 0xC8 M_MaxValue                  ( 000186514700 ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.M_OptimizedControlDataType                = (FourCC)GetInt32(new IntPtr(p + 0x0D8)); // 0245A2E35998 0xD8 M_OptimizedControlDataType  ( 0001865BB440 ModelEnumType FourCC FourCC FourCC Int32 )

            return value;
        }
    }
}
