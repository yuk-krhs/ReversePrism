using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionID                                 ModelPrimitiveType string string string String
    // 018 Explain                                  ModelPrimitiveType string string string String
    // 020 Duration                                 ModelPrimitiveType int int int Int32
    // 028 FaceAnim                                 ModelClassListType FaceAnimData[] FaceAnimData[] List<FaceAnimData> Pointer
    // 030 NeckVertical                             ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 038 NeckHorizontal                           ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 040 NeckRoll                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 048 EyeClose                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 050 EyeCloseSmile                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 PositionList                             ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 060 PositionIndex                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class FaceAct : DataModel
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
            var value   = new FaceAct() { Pointer= p0 };

            value.ActionID                                  = GetString(new IntPtr(p + 0x010)); // 0x10 ActionID                    ( ModelPrimitiveType string string string String )
            value.Explain                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Explain                     ( ModelPrimitiveType string string string String )
            value.Duration                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 Duration                    ( ModelPrimitiveType int int int Int32 )
            value.FaceAnim                                  = GetObjectList<FaceAnimData>(new IntPtr(p + 0x028), ReversePrism.DataModels.FaceAnimData.FromPointer); // 0x28 FaceAnim                    ( ModelClassListType FaceAnimData[] FaceAnimData[] List<FaceAnimData> Pointer )
            value.NeckVertical                              = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x30 NeckVertical                ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.NeckHorizontal                            = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x38 NeckHorizontal              ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.NeckRoll                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x40 NeckRoll                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeClose                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x48 EyeClose                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.EyeCloseSmile                             = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x50 EyeCloseSmile               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.PositionList                              = GetEnumList<Vector3>(new IntPtr(p + 0x058)); // 0x58 PositionList                ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.PositionIndex                             = GetObject<AnimationCurve>(new IntPtr(p + 0x060), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x60 PositionIndex               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
