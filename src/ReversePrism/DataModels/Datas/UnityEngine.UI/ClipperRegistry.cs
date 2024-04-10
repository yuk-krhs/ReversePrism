using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               ClipperRegistry IL2CPP_TYPE_CLASS
    // 010 m_Clippers                               IndexedSet`1<IClipper> IL2CPP_TYPE_GENERICINST
    public partial class ClipperRegistry : DataModel
    {

        public static ClipperRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClipperRegistry() { Pointer= p0 };


            return value;
        }
    }
}
