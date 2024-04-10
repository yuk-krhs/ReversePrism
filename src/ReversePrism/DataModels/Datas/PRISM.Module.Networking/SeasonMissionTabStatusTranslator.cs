using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class SeasonMissionTabStatusTranslator : DataModel
    {

        public static SeasonMissionTabStatusTranslator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionTabStatusTranslator() { Pointer= p0 };


            return value;
        }
    }
}
