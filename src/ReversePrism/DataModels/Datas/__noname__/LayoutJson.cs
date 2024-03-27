using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Extend                                   0001866722E0 ModelPrimitiveType string string string String
    // 020 ExtendMultiple                           000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Format                                   0001866722E0 ModelPrimitiveType string string string String
    // 030 BeforeRender                             0001866722E0 ModelPrimitiveType string string string String
    // 038 RunInBackground                          0001866722E0 ModelPrimitiveType string string string String
    // 040 CommonUsages                             000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 DisplayName                              0001866722E0 ModelPrimitiveType string string string String
    // 050 Description                              0001866722E0 ModelPrimitiveType string string string String
    // 058 Type                                     0001866722E0 ModelPrimitiveType string string string String
    // 060 Variant                                  0001866722E0 ModelPrimitiveType string string string String
    // 068 IsGenericTypeOfDevice                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 069 HideInUI                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 070 Controls                                 000185CBD2A8 ModelClassListType ControlItemJson[] ControlItemJson[] List<ControlItemJson> Pointer
    public partial class LayoutJson
    {
        public string                                   Name                                    { get; set; }
        public string                                   Extend                                  { get; set; }
        public List<string>?                            ExtendMultiple                          { get; set; }
        public string                                   Format                                  { get; set; }
        public string                                   BeforeRender                            { get; set; }
        public string                                   RunInBackground                         { get; set; }
        public List<string>?                            CommonUsages                            { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   Description                             { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Variant                                 { get; set; }
        public bool                                     IsGenericTypeOfDevice                   { get; set; }
        public bool                                     HideInUI                                { get; set; }
        public List<ControlItemJson>?                   Controls                                { get; set; }

        public static LayoutJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutJson();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D78608C0 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Extend                                    = GetString(new IntPtr(p + 0x018)); // 0270D78608E0 0x18 Extend                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ExtendMultiple                            = GetStringList(new IntPtr(p + 0x020)); // 0270D7860900 0x20 ExtendMultiple              ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Format                                    = GetString(new IntPtr(p + 0x028)); // 0270D7860920 0x28 Format                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.BeforeRender                              = GetString(new IntPtr(p + 0x030)); // 0270D7860940 0x30 BeforeRender                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.RunInBackground                           = GetString(new IntPtr(p + 0x038)); // 0270D7860960 0x38 RunInBackground             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CommonUsages                              = GetStringList(new IntPtr(p + 0x040)); // 0270D7860980 0x40 CommonUsages                ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DisplayName                               = GetString(new IntPtr(p + 0x048)); // 0270D78609A0 0x48 DisplayName                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x050)); // 0270D78609C0 0x50 Description                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x058)); // 0270D78609E0 0x58 Type                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Variant                                   = GetString(new IntPtr(p + 0x060)); // 0270D7860A00 0x60 Variant                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsGenericTypeOfDevice                     = GetBool(new IntPtr(p + 0x068)); // 0270D7860A20 0x68 IsGenericTypeOfDevice       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HideInUI                                  = GetBool(new IntPtr(p + 0x069)); // 0270D7860A40 0x69 HideInUI                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Controls                                  = GetObjectList<ControlItemJson>(new IntPtr(p + 0x070), ReversePrism.DataModels.ControlItemJson.FromPointer); // 0270D7860A60 0x70 Controls                    ( 000185CBD2A8 ModelClassListType ControlItemJson[] ControlItemJson[] List<ControlItemJson> Pointer )

            return value;
        }
    }
}
