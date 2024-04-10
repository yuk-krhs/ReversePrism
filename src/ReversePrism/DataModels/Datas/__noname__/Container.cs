using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_IDToken                                string IL2CPP_TYPE_STRING
    // 048 <children>k__BackingField                ObservableList`1<Widget> IL2CPP_TYPE_GENERICINST
    public partial class Container : DataModel
    {

        public static Container? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Container() { Pointer= p0 };


            return value;
        }
    }
}
