using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 scriptVersionString                      string IL2CPP_TYPE_STRING
    // 000 cri_mana_vp9_name                        string IL2CPP_TYPE_STRING
    public partial class CriManaVp9
    {

        public static CriManaVp9? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriManaVp9();


            return value;
        }
    }
}
