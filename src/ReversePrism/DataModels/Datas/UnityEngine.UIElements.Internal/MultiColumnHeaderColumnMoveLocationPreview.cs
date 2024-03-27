using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 visualUssClassName                       string IL2CPP_TYPE_STRING
    public partial class MultiColumnHeaderColumnMoveLocationPreview
    {

        public static MultiColumnHeaderColumnMoveLocationPreview? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnHeaderColumnMoveLocationPreview();


            return value;
        }
    }
}
