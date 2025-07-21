using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StateBlock                             ModelEnumType InputStateBlock InputStateBlock InputStateBlock Int32
    // 020 M_Name                                   ModelEnumType InternedString InternedString InternedString Int32
    // 030 M_Path                                   ModelPrimitiveType string string string String
    // 038 M_DisplayName                            ModelPrimitiveType string string string String
    // 040 M_DisplayNameFromLayout                  ModelPrimitiveType string string string String
    // 048 M_ShortDisplayName                       ModelPrimitiveType string string string String
    // 050 M_ShortDisplayNameFromLayout             ModelPrimitiveType string string string String
    // 058 M_Layout                                 ModelEnumType InternedString InternedString InternedString Int32
    // 068 M_Variants                               ModelEnumType InternedString InternedString InternedString Int32
    // 078 M_Device                                 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 080 M_Parent                                 ModelClassType InputControl InputControl InputControl Pointer
    // 088 M_UsageCount                             ModelPrimitiveType int int int Int32
    // 08C M_UsageStartIndex                        ModelPrimitiveType int int int Int32
    // 090 M_AliasCount                             ModelPrimitiveType int int int Int32
    // 094 M_AliasStartIndex                        ModelPrimitiveType int int int Int32
    // 098 M_ChildCount                             ModelPrimitiveType int int int Int32
    // 09C M_ChildStartIndex                        ModelPrimitiveType int int int Int32
    // 0A0 M_ControlFlags                           ModelEnumType ControlFlags ControlFlags ControlFlags Int32
    // 0A4 M_CachedValueIsStale                     ModelPrimitiveType bool bool bool Bool
    // 0A5 M_UnprocessedCachedValueIsStale          ModelPrimitiveType bool bool bool Bool
    // 0A8 M_DefaultState                           ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0B8 M_MinValue                               ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0C8 M_MaxValue                               ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32
    // 0D8 M_OptimizedControlDataType               ModelEnumType FourCC FourCC FourCC Int32
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

            value.M_StateBlock                              = (InputStateBlock)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_StateBlock                ( ModelEnumType InputStateBlock InputStateBlock InputStateBlock Int32 )
            value.M_Name                                    = (InternedString)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Name                      ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_Path                                    = GetString(new IntPtr(p + 0x030)); // 0x30 M_Path                      ( ModelPrimitiveType string string string String )
            value.M_DisplayName                             = GetString(new IntPtr(p + 0x038)); // 0x38 M_DisplayName               ( ModelPrimitiveType string string string String )
            value.M_DisplayNameFromLayout                   = GetString(new IntPtr(p + 0x040)); // 0x40 M_DisplayNameFromLayout     ( ModelPrimitiveType string string string String )
            value.M_ShortDisplayName                        = GetString(new IntPtr(p + 0x048)); // 0x48 M_ShortDisplayName          ( ModelPrimitiveType string string string String )
            value.M_ShortDisplayNameFromLayout              = GetString(new IntPtr(p + 0x050)); // 0x50 M_ShortDisplayNameFromLayout ( ModelPrimitiveType string string string String )
            value.M_Layout                                  = (InternedString)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_Layout                    ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_Variants                                = (InternedString)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_Variants                  ( ModelEnumType InternedString InternedString InternedString Int32 )
            value.M_Device                                  = GetObject<InputDevice>(new IntPtr(p + 0x078), ReversePrism.DataModels.InputDevice.FromPointer); // 0x78 M_Device                    ( ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.M_Parent                                  = GetObject<InputControl>(new IntPtr(p + 0x080), ReversePrism.DataModels.InputControl.FromPointer); // 0x80 M_Parent                    ( ModelClassType InputControl InputControl InputControl Pointer )
            value.M_UsageCount                              = GetInt32(new IntPtr(p + 0x088)); // 0x88 M_UsageCount                ( ModelPrimitiveType int int int Int32 )
            value.M_UsageStartIndex                         = GetInt32(new IntPtr(p + 0x08C)); // 0x8C M_UsageStartIndex           ( ModelPrimitiveType int int int Int32 )
            value.M_AliasCount                              = GetInt32(new IntPtr(p + 0x090)); // 0x90 M_AliasCount                ( ModelPrimitiveType int int int Int32 )
            value.M_AliasStartIndex                         = GetInt32(new IntPtr(p + 0x094)); // 0x94 M_AliasStartIndex           ( ModelPrimitiveType int int int Int32 )
            value.M_ChildCount                              = GetInt32(new IntPtr(p + 0x098)); // 0x98 M_ChildCount                ( ModelPrimitiveType int int int Int32 )
            value.M_ChildStartIndex                         = GetInt32(new IntPtr(p + 0x09C)); // 0x9C M_ChildStartIndex           ( ModelPrimitiveType int int int Int32 )
            value.M_ControlFlags                            = (ControlFlags)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_ControlFlags              ( ModelEnumType ControlFlags ControlFlags ControlFlags Int32 )
            value.M_CachedValueIsStale                      = GetBool(new IntPtr(p + 0x0A4)); // 0xA4 M_CachedValueIsStale        ( ModelPrimitiveType bool bool bool Bool )
            value.M_UnprocessedCachedValueIsStale           = GetBool(new IntPtr(p + 0x0A5)); // 0xA5 M_UnprocessedCachedValueIsStale ( ModelPrimitiveType bool bool bool Bool )
            value.M_DefaultState                            = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_DefaultState              ( ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.M_MinValue                                = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_MinValue                  ( ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.M_MaxValue                                = (PrimitiveValue)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 M_MaxValue                  ( ModelEnumType PrimitiveValue PrimitiveValue PrimitiveValue Int32 )
            value.M_OptimizedControlDataType                = (FourCC)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 M_OptimizedControlDataType  ( ModelEnumType FourCC FourCC FourCC Int32 )

            return value;
        }
    }
}
