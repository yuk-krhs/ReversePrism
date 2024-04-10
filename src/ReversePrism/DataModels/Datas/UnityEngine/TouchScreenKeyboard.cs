using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 000 <disableInPlaceEditing>k__BackingField   bool IL2CPP_TYPE_BOOLEAN
    public partial class TouchScreenKeyboard : DataModel
    {

        public static TouchScreenKeyboard? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchScreenKeyboard() { Pointer= p0 };


            return value;
        }
    }
}
