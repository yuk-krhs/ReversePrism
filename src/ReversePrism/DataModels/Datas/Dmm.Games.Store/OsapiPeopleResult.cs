using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Response                                 ModelClassType PeopleResult PeopleResult PeopleResult Pointer
    public partial class OsapiPeopleResult : DataModel
    {
        public PeopleResult?                            Response                                { get; set; }

        public static OsapiPeopleResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OsapiPeopleResult() { Pointer= p0 };

            value.Response                                  = GetObject<PeopleResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.PeopleResult.FromPointer); // 0x40 Response                    ( ModelClassType PeopleResult PeopleResult PeopleResult Pointer )

            return value;
        }
    }
}
