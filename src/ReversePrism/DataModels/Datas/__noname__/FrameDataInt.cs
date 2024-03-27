using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FrameCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 EyeIrisUvL                               000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 EyeIrisUvR                               000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 EyeFlip                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 FaceParams                               000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 BodyBones                                000185CC0DC8 ModelClassListType BoneAxisInt[] BoneAxisInt[] List<BoneAxisInt> Pointer
    // 040 HipsTrans                                000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class FrameDataInt
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
            var value   = new FrameDataInt();

            value.FrameCount                                = GetInt32(new IntPtr(p + 0x010)); // 0270D4D994D8 0x10 FrameCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.EyeIrisUvL                                = GetInt32List(new IntPtr(p + 0x018)); // 0270D4D994F8 0x18 EyeIrisUvL                  ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EyeIrisUvR                                = GetInt32List(new IntPtr(p + 0x020)); // 0270D4D99518 0x20 EyeIrisUvR                  ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EyeFlip                                   = GetInt32(new IntPtr(p + 0x028)); // 0270D4D99538 0x28 EyeFlip                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FaceParams                                = GetInt32List(new IntPtr(p + 0x030)); // 0270D4D99558 0x30 FaceParams                  ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.BodyBones                                 = GetObjectList<BoneAxisInt>(new IntPtr(p + 0x038), ReversePrism.DataModels.BoneAxisInt.FromPointer); // 0270D4D99578 0x38 BodyBones                   ( 000185CC0DC8 ModelClassListType BoneAxisInt[] BoneAxisInt[] List<BoneAxisInt> Pointer )
            value.HipsTrans                                 = GetInt32List(new IntPtr(p + 0x040)); // 0270D4D99598 0x40 HipsTrans                   ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
