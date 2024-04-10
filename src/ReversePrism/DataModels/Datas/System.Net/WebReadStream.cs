using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Operation                                00018654C930 ModelClassType WebOperation WebOperation WebOperation Pointer
    // 030 InnerStream                              000186670BE0 ModelClassType Stream Stream Stream Pointer
    // 038 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class WebReadStream : DataModel
    {
        public WebOperation?                            Operation                               { get; set; }
        public Stream?                                  InnerStream                             { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static WebReadStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebReadStream() { Pointer= p0 };

            value.Operation                                 = GetObject<WebOperation>(new IntPtr(p + 0x028), ReversePrism.DataModels.WebOperation.FromPointer); // 024667AB40C8 0x28 Operation                   ( 00018654C930 ModelClassType WebOperation WebOperation WebOperation Pointer )
            value.InnerStream                               = GetObject<Stream>(new IntPtr(p + 0x030), ReversePrism.DataModels.Stream.FromPointer); // 024667AB40E8 0x30 InnerStream                 ( 000186670BE0 ModelClassType Stream Stream Stream Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x038)); // 024667AB4108 0x38 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
