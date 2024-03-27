using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_NativePtr                              <int> IL2CPP_TYPE_I
    // 000 HR_SUCCESS                               long IL2CPP_TYPE_I8
    public partial class VideoCapture
    {

        public static VideoCapture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VideoCapture();


            return value;
        }
    }
}
