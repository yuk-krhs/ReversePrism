using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType float float float Single
    // 014 M_SpeedMode                              ModelEnumType SpeedMode SpeedMode SpeedMode Int32
    // 018 M_MaxSpeed                               ModelPrimitiveType float float float Single
    // 01C M_AccelTime                              ModelPrimitiveType float float float Single
    // 020 M_DecelTime                              ModelPrimitiveType float float float Single
    // 028 M_InputAxisName                          ModelPrimitiveType string string string String
    // 030 M_InputAxisValue                         ModelPrimitiveType float float float Single
    // 034 M_InvertInput                            ModelPrimitiveType bool bool bool Bool
    // 038 M_MinValue                               ModelPrimitiveType float float float Single
    // 03C M_MaxValue                               ModelPrimitiveType float float float Single
    // 040 M_Wrap                                   ModelPrimitiveType bool bool bool Bool
    // 044 M_Recentering                            ModelEnumType Recentering Recentering Recentering Int32
    // 064 M_CurrentSpeed                           ModelPrimitiveType float float float Single
    // 068 M_LastUpdateTime                         ModelPrimitiveType float float float Single
    // 06C M_LastUpdateFrame                        ModelPrimitiveType int int int Int32
    // 000 Epsilon                                  float IL2CPP_TYPE_R4
    // 070 M_InputAxisProvider                      ModelClassType IInputAxisProvider IInputAxisProvider IInputAxisProvider Pointer
    // 078 M_InputAxisIndex                         ModelPrimitiveType int int int Int32
    // 07C ValueRangeLocked                         ModelPrimitiveType bool bool bool Bool
    // 07D HasRecentering                           ModelPrimitiveType bool bool bool Bool
    public partial class AxisState : DataModel
    {
        public float                                    Value                                   { get; set; }
        public SpeedMode                                M_SpeedMode                             { get; set; }
        public float                                    M_MaxSpeed                              { get; set; }
        public float                                    M_AccelTime                             { get; set; }
        public float                                    M_DecelTime                             { get; set; }
        public string                                   M_InputAxisName                         { get; set; }
        public float                                    M_InputAxisValue                        { get; set; }
        public bool                                     M_InvertInput                           { get; set; }
        public float                                    M_MinValue                              { get; set; }
        public float                                    M_MaxValue                              { get; set; }
        public bool                                     M_Wrap                                  { get; set; }
        public Recentering                              M_Recentering                           { get; set; }
        public float                                    M_CurrentSpeed                          { get; set; }
        public float                                    M_LastUpdateTime                        { get; set; }
        public int                                      M_LastUpdateFrame                       { get; set; }
        public IInputAxisProvider?                      M_InputAxisProvider                     { get; set; }
        public int                                      M_InputAxisIndex                        { get; set; }
        public bool                                     ValueRangeLocked                        { get; set; }
        public bool                                     HasRecentering                          { get; set; }

        public static AxisState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AxisState() { Pointer= p0 };

            value.Value                                     = GetSingle(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType float float float Single )
            value.M_SpeedMode                               = (SpeedMode)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_SpeedMode                 ( ModelEnumType SpeedMode SpeedMode SpeedMode Int32 )
            value.M_MaxSpeed                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_MaxSpeed                  ( ModelPrimitiveType float float float Single )
            value.M_AccelTime                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_AccelTime                 ( ModelPrimitiveType float float float Single )
            value.M_DecelTime                               = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_DecelTime                 ( ModelPrimitiveType float float float Single )
            value.M_InputAxisName                           = GetString(new IntPtr(p + 0x028)); // 0x28 M_InputAxisName             ( ModelPrimitiveType string string string String )
            value.M_InputAxisValue                          = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_InputAxisValue            ( ModelPrimitiveType float float float Single )
            value.M_InvertInput                             = GetBool(new IntPtr(p + 0x034)); // 0x34 M_InvertInput               ( ModelPrimitiveType bool bool bool Bool )
            value.M_MinValue                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_MinValue                  ( ModelPrimitiveType float float float Single )
            value.M_MaxValue                                = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_MaxValue                  ( ModelPrimitiveType float float float Single )
            value.M_Wrap                                    = GetBool(new IntPtr(p + 0x040)); // 0x40 M_Wrap                      ( ModelPrimitiveType bool bool bool Bool )
            value.M_Recentering                             = (Recentering)GetInt32(new IntPtr(p + 0x044)); // 0x44 M_Recentering               ( ModelEnumType Recentering Recentering Recentering Int32 )
            value.M_CurrentSpeed                            = GetSingle(new IntPtr(p + 0x064)); // 0x64 M_CurrentSpeed              ( ModelPrimitiveType float float float Single )
            value.M_LastUpdateTime                          = GetSingle(new IntPtr(p + 0x068)); // 0x68 M_LastUpdateTime            ( ModelPrimitiveType float float float Single )
            value.M_LastUpdateFrame                         = GetInt32(new IntPtr(p + 0x06C)); // 0x6C M_LastUpdateFrame           ( ModelPrimitiveType int int int Int32 )
            value.M_InputAxisProvider                       = GetObject<IInputAxisProvider>(new IntPtr(p + 0x070), ReversePrism.DataModels.IInputAxisProvider.FromPointer); // 0x70 M_InputAxisProvider         ( ModelClassType IInputAxisProvider IInputAxisProvider IInputAxisProvider Pointer )
            value.M_InputAxisIndex                          = GetInt32(new IntPtr(p + 0x078)); // 0x78 M_InputAxisIndex            ( ModelPrimitiveType int int int Int32 )
            value.ValueRangeLocked                          = GetBool(new IntPtr(p + 0x07C)); // 0x7C ValueRangeLocked            ( ModelPrimitiveType bool bool bool Bool )
            value.HasRecentering                            = GetBool(new IntPtr(p + 0x07D)); // 0x7D HasRecentering              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
