using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetDS                                 ModelClassType DataSet DataSet DataSet Pointer
    public partial class DSRowDiffIdUsageSection : DataModel
    {
        public DataSet?                                 TargetDS                                { get; set; }

        public static DSRowDiffIdUsageSection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DSRowDiffIdUsageSection() { Pointer= p0 };

            value.TargetDS                                  = GetObject<DataSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataSet.FromPointer); // 0x10 TargetDS                    ( ModelClassType DataSet DataSet DataSet Pointer )

            return value;
        }
    }
}
