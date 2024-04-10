using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 DeckProduceCards                         IEnumerable`1<IProduceCardStatus> IL2CPP_TYPE_GENERICINST
    public partial class DeckListPopupParam : DataModel
    {

        public static DeckListPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeckListPopupParam() { Pointer= p0 };


            return value;
        }
    }
}
