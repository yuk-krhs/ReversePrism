using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 m_MenuBuilder                            Action`1<ContextualMenuPopulateEvent> IL2CPP_TYPE_GENERICINST
    public partial class ContextualMenuManipulator
    {

        public static ContextualMenuManipulator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextualMenuManipulator();


            return value;
        }
    }
}
