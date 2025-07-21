using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrologueStoryNo                          int IL2CPP_TYPE_I4
    // 000 EpilogueStoryNo                          int IL2CPP_TYPE_I4
    public partial class ADVLocalizeTextUtility : DataModel
    {

        public static ADVLocalizeTextUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLocalizeTextUtility() { Pointer= p0 };


            return value;
        }
    }
}
