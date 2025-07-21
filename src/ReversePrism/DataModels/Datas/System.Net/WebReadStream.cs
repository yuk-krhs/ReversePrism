using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Operation                                ModelClassType WebOperation WebOperation WebOperation Pointer
    // 030 InnerStream                              ModelClassType Stream Stream Stream Pointer
    // 038 Disposed                                 ModelPrimitiveType bool bool bool Bool
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

            value.Operation                                 = GetObject<WebOperation>(new IntPtr(p + 0x028), ReversePrism.DataModels.WebOperation.FromPointer); // 0x28 Operation                   ( ModelClassType WebOperation WebOperation WebOperation Pointer )
            value.InnerStream                               = GetObject<Stream>(new IntPtr(p + 0x030), ReversePrism.DataModels.Stream.FromPointer); // 0x30 InnerStream                 ( ModelClassType Stream Stream Stream Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x038)); // 0x38 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
