using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_Hammersley2dSeq16                      float[] IL2CPP_TYPE_SZARRAY
    // 008 k_Hammersley2dSeq32                      float[] IL2CPP_TYPE_SZARRAY
    // 010 K_Hammersley2dSeq64                      ModelPrimitiveListType float[] float[] List<float> Pointer
    // 018 K_Hammersley2dSeq256                     ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 S_hammersley2DSeq16Id                    ModelPrimitiveType int int int Int32
    // 024 S_hammersley2DSeq32Id                    ModelPrimitiveType int int int Int32
    // 028 S_hammersley2DSeq64Id                    ModelPrimitiveType int int int Int32
    // 02C S_hammersley2DSeq256Id                   ModelPrimitiveType int int int Int32
    public partial class Hammersley : DataModel
    {
        public List<float>?                             K_Hammersley2dSeq64                     { get; set; }
        public List<float>?                             K_Hammersley2dSeq256                    { get; set; }
        public int                                      S_hammersley2DSeq16Id                   { get; set; }
        public int                                      S_hammersley2DSeq32Id                   { get; set; }
        public int                                      S_hammersley2DSeq64Id                   { get; set; }
        public int                                      S_hammersley2DSeq256Id                  { get; set; }

        public static Hammersley? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hammersley() { Pointer= p0 };

            value.K_Hammersley2dSeq64                       = GetSingleList(new IntPtr(p + 0x010)); // 0x10 K_Hammersley2dSeq64         ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.K_Hammersley2dSeq256                      = GetSingleList(new IntPtr(p + 0x018)); // 0x18 K_Hammersley2dSeq256        ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.S_hammersley2DSeq16Id                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 S_hammersley2DSeq16Id       ( ModelPrimitiveType int int int Int32 )
            value.S_hammersley2DSeq32Id                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 S_hammersley2DSeq32Id       ( ModelPrimitiveType int int int Int32 )
            value.S_hammersley2DSeq64Id                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 S_hammersley2DSeq64Id       ( ModelPrimitiveType int int int Int32 )
            value.S_hammersley2DSeq256Id                    = GetInt32(new IntPtr(p + 0x02C)); // 0x2C S_hammersley2DSeq256Id      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
