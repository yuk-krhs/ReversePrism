using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 028 OnReceiveOnAirStatus                     Action`3<Status, bool, PModeStatus> IL2CPP_TYPE_GENERICINST
    // 030 IsViewPaused                             ModelPrimitiveType bool bool bool Bool
    public partial class OperatorView : DataModel
    {
        public bool                                     IsViewPaused                            { get; set; }

        public static OperatorView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OperatorView() { Pointer= p0 };

            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x030)); // 0x30 IsViewPaused                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
