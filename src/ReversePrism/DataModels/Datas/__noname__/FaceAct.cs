using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionID                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 Explain                                  0001866722E0 ModelPrimitiveType string string string String
    // 020 Duration                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 FaceAnim                                 000185B85EB0 ModelClassListType FaceAnimData[] FaceAnimData[] List<FaceAnimData> Pointer
    // 030 NeckVertical                             000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 038 NeckHorizontal                           000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 040 NeckRoll                                 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 048 EyeClose                                 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 050 EyeCloseSmile                            000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 PositionList                             000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 060 PositionIndex                            000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class FaceAct
    {
        public string                                   ActionID                                { get; set; }
        public string                                   Explain                                 { get; set; }
        public int                                      Duration                                { get; set; }
        public List<FaceAnimData>?                      FaceAnim                                { get; set; }
        public AnimationCurve?                          NeckVertical                            { get; set; }
        public AnimationCurve?                          NeckHorizontal                          { get; set; }
        public AnimationCurve?                          NeckRoll                                { get; set; }
        public AnimationCurve?                          EyeClose                                { get; set; }
        public AnimationCurve?                          EyeCloseSmile                           { get; set; }
        public List<Vector3>?                           PositionList                            { get; set; }
        public AnimationCurve?                          PositionIndex                           { get; set; }

        public static FaceAct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceAct();

            value.ActionID                                  = GetString(new IntPtr(p + 0x010)); // 0270060F02A0 0x10 ActionID                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Explain                                   = GetString(new IntPtr(p + 0x018)); // 0270060F02C0 0x18 Explain                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Duration                                  = GetInt32(new IntPtr(p + 0x020)); // 0270060F02E0 0x20 Duration                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FaceAnim                                  = GetObjectList<FaceAnimData>(new IntPtr(p + 0x028), ReversePrism.DataModels.FaceAnimData.FromPointer); // 0270060F0300 0x28 FaceAnim                    ( 000185B85EB0 ModelClassListType FaceAnimData[] FaceAnimData[] List<FaceAnimData> Pointer )
            value.NeckVertical                              = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270060F0320 0x30 NeckVertical                ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.NeckHorizontal                            = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270060F0340 0x38 NeckHorizontal              ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.NeckRoll                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270060F0360 0x40 NeckRoll                    ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeClose                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270060F0380 0x48 EyeClose                    ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeCloseSmile                             = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270060F03A0 0x50 EyeCloseSmile               ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.PositionList                              = GetEnumList<Vector3>(new IntPtr(p + 0x058)); // 0270060F03C0 0x58 PositionList                ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.PositionIndex                             = GetObject<AnimationCurve>(new IntPtr(p + 0x060), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270060F03E0 0x60 PositionIndex               ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
