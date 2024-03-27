using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Text                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 Value                                    0001865A8950 ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer
    // 030 SubButtons                               000185B72030 ModelClassListType ButtonBase[] ButtonBase[] List<ButtonBase> Pointer
    // 038 AddButtons                               000185B72030 ModelClassListType ButtonBase[] ButtonBase[] List<ButtonBase> Pointer
    // 040 Steps                                    000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 048 Format                                   000186671910 ModelPrimitiveType string string string String
    // 050 IsRound                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 RoundDigitNumber                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 Min                                      0001866656B0 ModelPrimitiveType float float float Single
    // 05C Max                                      0001866656B0 ModelPrimitiveType float float float Single
    public partial class NumericInput
    {
        public UITextMeshProUGUI?                       Text                                    { get; set; }
        public FloatReactiveProperty?                   Value                                   { get; set; }
        public List<ButtonBase>?                        SubButtons                              { get; set; }
        public List<ButtonBase>?                        AddButtons                              { get; set; }
        public List<float>?                             Steps                                   { get; set; }
        public string                                   Format                                  { get; set; }
        public bool                                     IsRound                                 { get; set; }
        public int                                      RoundDigitNumber                        { get; set; }
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }

        public static NumericInput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumericInput();

            value.Text                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4EEC2E0 0x20 Text                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Value                                     = GetObject<FloatReactiveProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.FloatReactiveProperty.FromPointer); // 0270D4EEC300 0x28 Value                       ( 0001865A8950 ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer )
            value.SubButtons                                = GetObjectList<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D4EEC320 0x30 SubButtons                  ( 000185B72030 ModelClassListType ButtonBase[] ButtonBase[] List<ButtonBase> Pointer )
            value.AddButtons                                = GetObjectList<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D4EEC340 0x38 AddButtons                  ( 000185B72030 ModelClassListType ButtonBase[] ButtonBase[] List<ButtonBase> Pointer )
            value.Steps                                     = GetSingleList(new IntPtr(p + 0x040)); // 0270D4EEC360 0x40 Steps                       ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Format                                    = GetString(new IntPtr(p + 0x048)); // 0270D4EEC380 0x48 Format                      ( 000186671910 ModelPrimitiveType string string string String )
            value.IsRound                                   = GetBool(new IntPtr(p + 0x050)); // 0270D4EEC3A0 0x50 IsRound                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RoundDigitNumber                          = GetInt32(new IntPtr(p + 0x054)); // 0270D4EEC3C0 0x54 RoundDigitNumber            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Min                                       = GetSingle(new IntPtr(p + 0x058)); // 0270D4EEC3E0 0x58 Min                         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x05C)); // 0270D4EEC400 0x5C Max                         ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
