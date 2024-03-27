using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 activeQualityLevelChanged                Action`2<int, int> IL2CPP_TYPE_GENERICINST
    public partial class QualitySettings
    {

        public static QualitySettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QualitySettings();


            return value;
        }
    }
}
