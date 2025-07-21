using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType MobileScreenConnectorView MobileScreenConnectorView MobileScreenConnectorView Pointer
    public partial class MobileScreenConnectorBuilder : DataModel
    {
        public MobileScreenConnectorView?               View                                    { get; set; }

        public static MobileScreenConnectorBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileScreenConnectorBuilder() { Pointer= p0 };

            value.View                                      = GetObject<MobileScreenConnectorView>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenConnectorView.FromPointer); // 0x20 View                        ( ModelClassType MobileScreenConnectorView MobileScreenConnectorView MobileScreenConnectorView Pointer )

            return value;
        }
    }
}
