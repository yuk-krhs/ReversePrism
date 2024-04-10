using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TopResourceTagName                       string IL2CPP_TYPE_STRING
    // 000 DetailResourceTagName                    string IL2CPP_TYPE_STRING
    // 000 UnitEditResourceTagName                  string IL2CPP_TYPE_STRING
    // 000 FilterTitle                              string IL2CPP_TYPE_STRING
    // 000 ResultAnimGet                            string IL2CPP_TYPE_STRING
    // 000 ResultAnimStar                           string IL2CPP_TYPE_STRING
    // 000 ShilhouettePosition                      Vector2[][] IL2CPP_TYPE_SZARRAY
    public partial class ChallengeTourConst : DataModel
    {

        public static ChallengeTourConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourConst() { Pointer= p0 };


            return value;
        }
    }
}
