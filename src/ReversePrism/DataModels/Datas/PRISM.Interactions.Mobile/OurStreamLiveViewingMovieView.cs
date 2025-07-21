using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PlayStartDisposable                      ModelClassType IDisposable IDisposable IDisposable Pointer
    // 028 PlayEndDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 030 IsPlayStart                              ModelPrimitiveType bool bool bool Bool
    // 038 playEndSubject                           Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class OurStreamLiveViewingMovieView : DataModel
    {
        public IDisposable?                             PlayStartDisposable                     { get; set; }
        public IDisposable?                             PlayEndDisposable                       { get; set; }
        public bool                                     IsPlayStart                             { get; set; }

        public static OurStreamLiveViewingMovieView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingMovieView() { Pointer= p0 };

            value.PlayStartDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDisposable.FromPointer); // 0x20 PlayStartDisposable         ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.PlayEndDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0x28 PlayEndDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.IsPlayStart                               = GetBool(new IntPtr(p + 0x030)); // 0x30 IsPlayStart                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
