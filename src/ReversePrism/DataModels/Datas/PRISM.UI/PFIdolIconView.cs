using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 178 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 180 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PFIdolIconView
    {
        public CompositeDisposable?                     Disposables                             { get; set; }
        public int                                      Index                                   { get; set; }

        public static PFIdolIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolIconView();

            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x178), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 027005AFCF28 0x178 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x180)); // 027005AFCF48 0x180 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
