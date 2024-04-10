using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CompareInfo                              0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 000 Default                                  Comparer IL2CPP_TYPE_CLASS
    // 008 DefaultInvariant                         Comparer IL2CPP_TYPE_CLASS
    public partial class Comparer : DataModel
    {
        public CompareInfo?                             CompareInfo                             { get; set; }

        public static Comparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Comparer() { Pointer= p0 };

            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompareInfo.FromPointer); // 024666D939C0 0x10 CompareInfo                 ( 0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer )

            return value;
        }
    }
}
