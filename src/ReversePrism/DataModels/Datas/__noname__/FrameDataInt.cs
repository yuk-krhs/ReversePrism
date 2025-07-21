using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FrameCount                               ModelPrimitiveType int int int Int32
    // 018 EyeIrisUvL                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 EyeIrisUvR                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 EyeFlip                                  ModelPrimitiveType int int int Int32
    // 030 FaceParams                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 BodyBones                                ModelClassListType BoneAxisInt[] BoneAxisInt[] List<BoneAxisInt> Pointer
    // 040 HipsTrans                                ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class FrameDataInt : DataModel
    {
        public int                                      FrameCount                              { get; set; }
        public List<int>?                               EyeIrisUvL                              { get; set; }
        public List<int>?                               EyeIrisUvR                              { get; set; }
        public int                                      EyeFlip                                 { get; set; }
        public List<int>?                               FaceParams                              { get; set; }
        public List<BoneAxisInt>?                       BodyBones                               { get; set; }
        public List<int>?                               HipsTrans                               { get; set; }

        public static FrameDataInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FrameDataInt() { Pointer= p0 };

            value.FrameCount                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 FrameCount                  ( ModelPrimitiveType int int int Int32 )
            value.EyeIrisUvL                                = GetInt32List(new IntPtr(p + 0x018)); // 0x18 EyeIrisUvL                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EyeIrisUvR                                = GetInt32List(new IntPtr(p + 0x020)); // 0x20 EyeIrisUvR                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EyeFlip                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 EyeFlip                     ( ModelPrimitiveType int int int Int32 )
            value.FaceParams                                = GetInt32List(new IntPtr(p + 0x030)); // 0x30 FaceParams                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.BodyBones                                 = GetObjectList<BoneAxisInt>(new IntPtr(p + 0x038), ReversePrism.DataModels.BoneAxisInt.FromPointer); // 0x38 BodyBones                   ( ModelClassListType BoneAxisInt[] BoneAxisInt[] List<BoneAxisInt> Pointer )
            value.HipsTrans                                 = GetInt32List(new IntPtr(p + 0x040)); // 0x40 HipsTrans                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
