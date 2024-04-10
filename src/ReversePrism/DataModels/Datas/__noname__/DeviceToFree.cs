using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Page                                     0001867144C0 ModelClassType Page Page Page Pointer
    public partial class DeviceToFree : DataModel
    {
        public uint                                     Handle                                  { get; set; }
        public Page?                                    Page                                    { get; set; }

        public static DeviceToFree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceToFree() { Pointer= p0 };

            value.Handle                                    = GetUInt32(new IntPtr(p + 0x010)); // 0245A6822B50 0x10 Handle                      ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Page                                      = GetObject<Page>(new IntPtr(p + 0x018), ReversePrism.DataModels.Page.FromPointer); // 0245A6822B70 0x18 Page                        ( 0001867144C0 ModelClassType Page Page Page Pointer )

            return value;
        }
    }
}
