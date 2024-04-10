using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ScreenEdgeColorScreen                    string IL2CPP_TYPE_STRING
    // 000 ScreenEdgeColorAdd                       string IL2CPP_TYPE_STRING
    // 000 ScreenEdgeColorAlphaBlend                string IL2CPP_TYPE_STRING
    // 000 ScreenEdgeColorMultiply                  string IL2CPP_TYPE_STRING
    public partial class ScreenEdgeColorRenderer : DataModel
    {

        public static ScreenEdgeColorRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenEdgeColorRenderer() { Pointer= p0 };


            return value;
        }
    }
}
