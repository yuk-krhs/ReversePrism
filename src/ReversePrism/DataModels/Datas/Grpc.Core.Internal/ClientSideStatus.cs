using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Status                                   ModelEnumType Status Status Status Int32
    // 028 Trailers                                 ModelClassType Metadata Metadata Metadata Pointer
    public partial class ClientSideStatus : DataModel
    {
        public Status                                   Status                                  { get; set; }
        public Metadata?                                Trailers                                { get; set; }

        public static ClientSideStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientSideStatus() { Pointer= p0 };

            value.Status                                    = (Status)GetInt32(new IntPtr(p + 0x010)); // 0x10 Status                      ( ModelEnumType Status Status Status Int32 )
            value.Trailers                                  = GetObject<Metadata>(new IntPtr(p + 0x028), ReversePrism.DataModels.Metadata.FromPointer); // 0x28 Trailers                    ( ModelClassType Metadata Metadata Metadata Pointer )

            return value;
        }
    }
}
