using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 N                                        int IL2CPP_TYPE_I4
    // 010 Angs                                     ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 FmAngs                                   ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 FmAngAdds                                ModelPrimitiveListType float[] float[] List<float> Pointer
    // 028 Outv                                     ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 Outv5                                    ModelPrimitiveListType float[] float[] List<float> Pointer
    // 040 SpeedMagRnd                              ModelPrimitiveType float float float Single
    // 044 SpeedMag                                 ModelPrimitiveType float float float Single
    // 048 AmpMag0                                  ModelPrimitiveType float float float Single
    // 04C AmpMag                                   ModelPrimitiveType float float float Single
    // 050 AmpMagy                                  ModelPrimitiveType float float float Single
    // 054 FmMag                                    ModelPrimitiveType float float float Single
    // 058 SlowMag                                  ModelPrimitiveType float float float Single
    public partial class Quiverer : DataModel
    {
        public List<float>?                             Angs                                    { get; set; }
        public List<float>?                             FmAngs                                  { get; set; }
        public List<float>?                             FmAngAdds                               { get; set; }
        public Vector3                                  Outv                                    { get; set; }
        public List<float>?                             Outv5                                   { get; set; }
        public float                                    SpeedMagRnd                             { get; set; }
        public float                                    SpeedMag                                { get; set; }
        public float                                    AmpMag0                                 { get; set; }
        public float                                    AmpMag                                  { get; set; }
        public float                                    AmpMagy                                 { get; set; }
        public float                                    FmMag                                   { get; set; }
        public float                                    SlowMag                                 { get; set; }

        public static Quiverer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Quiverer() { Pointer= p0 };

            value.Angs                                      = GetSingleList(new IntPtr(p + 0x010)); // 0x10 Angs                        ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.FmAngs                                    = GetSingleList(new IntPtr(p + 0x018)); // 0x18 FmAngs                      ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.FmAngAdds                                 = GetSingleList(new IntPtr(p + 0x020)); // 0x20 FmAngAdds                   ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Outv                                      = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 Outv                        ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Outv5                                     = GetSingleList(new IntPtr(p + 0x038)); // 0x38 Outv5                       ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.SpeedMagRnd                               = GetSingle(new IntPtr(p + 0x040)); // 0x40 SpeedMagRnd                 ( ModelPrimitiveType float float float Single )
            value.SpeedMag                                  = GetSingle(new IntPtr(p + 0x044)); // 0x44 SpeedMag                    ( ModelPrimitiveType float float float Single )
            value.AmpMag0                                   = GetSingle(new IntPtr(p + 0x048)); // 0x48 AmpMag0                     ( ModelPrimitiveType float float float Single )
            value.AmpMag                                    = GetSingle(new IntPtr(p + 0x04C)); // 0x4C AmpMag                      ( ModelPrimitiveType float float float Single )
            value.AmpMagy                                   = GetSingle(new IntPtr(p + 0x050)); // 0x50 AmpMagy                     ( ModelPrimitiveType float float float Single )
            value.FmMag                                     = GetSingle(new IntPtr(p + 0x054)); // 0x54 FmMag                       ( ModelPrimitiveType float float float Single )
            value.SlowMag                                   = GetSingle(new IntPtr(p + 0x058)); // 0x58 SlowMag                     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
