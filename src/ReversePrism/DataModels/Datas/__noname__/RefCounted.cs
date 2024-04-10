using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_NextId                                 uint IL2CPP_TYPE_U4
    // 000 m_RefCount                               int IL2CPP_TYPE_I4
    // 000 m_Id                                     uint IL2CPP_TYPE_U4
    // 000 value                                    <var> IL2CPP_TYPE_VAR
    public partial class RefCounted : DataModel
    {

        public static RefCounted? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RefCounted() { Pointer= p0 };


            return value;
        }
    }
}
