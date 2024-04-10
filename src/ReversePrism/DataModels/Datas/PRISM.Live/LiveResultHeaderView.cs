using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ClearHeader                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 FailedHeader                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class LiveResultHeaderView : DataModel
    {
        public GameObject?                              ClearHeader                             { get; set; }
        public GameObject?                              FailedHeader                            { get; set; }

        public static LiveResultHeaderView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultHeaderView() { Pointer= p0 };

            value.ClearHeader                               = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0246652BC608 0x20 ClearHeader                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FailedHeader                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0246652BC628 0x28 FailedHeader                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
