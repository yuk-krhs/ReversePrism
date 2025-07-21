using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Extend                                   ModelPrimitiveType string string string String
    // 020 ExtendMultiple                           ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Format                                   ModelPrimitiveType string string string String
    // 030 BeforeRender                             ModelPrimitiveType string string string String
    // 038 RunInBackground                          ModelPrimitiveType string string string String
    // 040 CommonUsages                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 DisplayName                              ModelPrimitiveType string string string String
    // 050 Description                              ModelPrimitiveType string string string String
    // 058 Type                                     ModelPrimitiveType string string string String
    // 060 Variant                                  ModelPrimitiveType string string string String
    // 068 IsGenericTypeOfDevice                    ModelPrimitiveType bool bool bool Bool
    // 069 HideInUI                                 ModelPrimitiveType bool bool bool Bool
    // 070 Controls                                 ModelClassListType ControlItemJson[] ControlItemJson[] List<ControlItemJson> Pointer
    public partial class LayoutJson : DataModel
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
            var value   = new LayoutJson() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Extend                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Extend                      ( ModelPrimitiveType string string string String )
            value.ExtendMultiple                            = GetStringList(new IntPtr(p + 0x020)); // 0x20 ExtendMultiple              ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Format                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Format                      ( ModelPrimitiveType string string string String )
            value.BeforeRender                              = GetString(new IntPtr(p + 0x030)); // 0x30 BeforeRender                ( ModelPrimitiveType string string string String )
            value.RunInBackground                           = GetString(new IntPtr(p + 0x038)); // 0x38 RunInBackground             ( ModelPrimitiveType string string string String )
            value.CommonUsages                              = GetStringList(new IntPtr(p + 0x040)); // 0x40 CommonUsages                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.DisplayName                               = GetString(new IntPtr(p + 0x048)); // 0x48 DisplayName                 ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x050)); // 0x50 Description                 ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x058)); // 0x58 Type                        ( ModelPrimitiveType string string string String )
            value.Variant                                   = GetString(new IntPtr(p + 0x060)); // 0x60 Variant                     ( ModelPrimitiveType string string string String )
            value.IsGenericTypeOfDevice                     = GetBool(new IntPtr(p + 0x068)); // 0x68 IsGenericTypeOfDevice       ( ModelPrimitiveType bool bool bool Bool )
            value.HideInUI                                  = GetBool(new IntPtr(p + 0x069)); // 0x69 HideInUI                    ( ModelPrimitiveType bool bool bool Bool )
            value.Controls                                  = GetObjectList<ControlItemJson>(new IntPtr(p + 0x070), ReversePrism.DataModels.ControlItemJson.FromPointer); // 0x70 Controls                    ( ModelClassListType ControlItemJson[] ControlItemJson[] List<ControlItemJson> Pointer )

            return value;
        }
    }
}
