using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Separator                                char IL2CPP_TYPE_CHAR
    // 000 kSeparatorString                         string IL2CPP_TYPE_STRING
    // 010 M_Name                                   000186671910 ModelPrimitiveType string string string String
    // 018 M_Id                                     000186671BA0 ModelPrimitiveType string string string String
    // 020 M_Path                                   000186671910 ModelPrimitiveType string string string String
    // 028 M_Interactions                           000186671910 ModelPrimitiveType string string string String
    // 030 M_Processors                             000186671910 ModelPrimitiveType string string string String
    // 038 M_Groups                                 000186671BA0 ModelPrimitiveType string string string String
    // 040 M_Action                                 000186671910 ModelPrimitiveType string string string String
    // 048 M_Flags                                  0001866242D0 ModelEnumType Flags Flags Flags Int32
    // 050 M_OverridePath                           0001866742E0 ModelPrimitiveType string string string String
    // 058 M_OverrideInteractions                   0001866742E0 ModelPrimitiveType string string string String
    // 060 M_OverrideProcessors                     0001866742E0 ModelPrimitiveType string string string String
    public partial class InputBinding
    {
        public string                                   M_Name                                  { get; set; }
        public string                                   M_Id                                    { get; set; }
        public string                                   M_Path                                  { get; set; }
        public string                                   M_Interactions                          { get; set; }
        public string                                   M_Processors                            { get; set; }
        public string                                   M_Groups                                { get; set; }
        public string                                   M_Action                                { get; set; }
        public Flags                                    M_Flags                                 { get; set; }
        public string                                   M_OverridePath                          { get; set; }
        public string                                   M_OverrideInteractions                  { get; set; }
        public string                                   M_OverrideProcessors                    { get; set; }

        public static InputBinding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputBinding();

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0270D76319C0 0x10 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Id                                      = GetString(new IntPtr(p + 0x018)); // 0270D76319E0 0x18 M_Id                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Path                                    = GetString(new IntPtr(p + 0x020)); // 0270D7631A00 0x20 M_Path                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Interactions                            = GetString(new IntPtr(p + 0x028)); // 0270D7631A20 0x28 M_Interactions              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Processors                              = GetString(new IntPtr(p + 0x030)); // 0270D7631A40 0x30 M_Processors                ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Groups                                  = GetString(new IntPtr(p + 0x038)); // 0270D7631A60 0x38 M_Groups                    ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Action                                  = GetString(new IntPtr(p + 0x040)); // 0270D7631A80 0x40 M_Action                    ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Flags                                   = (Flags)GetInt32(new IntPtr(p + 0x048)); // 0270D7631AA0 0x48 M_Flags                     ( 0001866242D0 ModelEnumType Flags Flags Flags Int32 )
            value.M_OverridePath                            = GetString(new IntPtr(p + 0x050)); // 0270D7631AC0 0x50 M_OverridePath              ( 0001866742E0 ModelPrimitiveType string string string String )
            value.M_OverrideInteractions                    = GetString(new IntPtr(p + 0x058)); // 0270D7631AE0 0x58 M_OverrideInteractions      ( 0001866742E0 ModelPrimitiveType string string string String )
            value.M_OverrideProcessors                      = GetString(new IntPtr(p + 0x060)); // 0270D7631B00 0x60 M_OverrideProcessors        ( 0001866742E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
