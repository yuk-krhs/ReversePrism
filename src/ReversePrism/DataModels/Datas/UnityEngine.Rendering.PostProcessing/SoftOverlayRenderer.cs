using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Pyramid                                000185CC3188 ModelEnumListType Level[] Level[] List<Level> Pointer
    // 000 k_MaxPyramidSize                         int IL2CPP_TYPE_I4
    public partial class SoftOverlayRenderer : DataModel
    {
        public List<Level>?                             M_Pyramid                               { get; set; }

        public static SoftOverlayRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoftOverlayRenderer() { Pointer= p0 };

            value.M_Pyramid                                 = GetEnumList<Level>(new IntPtr(p + 0x020)); // 0245A65531B8 0x20 M_Pyramid                   ( 000185CC3188 ModelEnumListType Level[] Level[] List<Level> Pointer )

            return value;
        }
    }
}
