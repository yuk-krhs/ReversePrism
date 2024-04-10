using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_NumEyes                                int IL2CPP_TYPE_I4
    // 000 k_NumCoCHistoryTextures                  int IL2CPP_TYPE_I4
    // 020 m_CoCHistoryTextures                     RenderTexture[][] IL2CPP_TYPE_SZARRAY
    // 028 M_HistoryPingPong                        000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 000 k_FilmHeight                             float IL2CPP_TYPE_R4
    public partial class DepthOfFieldRenderer : DataModel
    {
        public List<int>?                               M_HistoryPingPong                       { get; set; }

        public static DepthOfFieldRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOfFieldRenderer() { Pointer= p0 };

            value.M_HistoryPingPong                         = GetInt32List(new IntPtr(p + 0x028)); // 0245A6550BA0 0x28 M_HistoryPingPong           ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
