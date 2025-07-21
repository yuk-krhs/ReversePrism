using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 teamDataArray                            NativeArray`1<TeamData> IL2CPP_TYPE_GENERICINST
    // 020 centerDataArray                          NativeArray`1<CenterData> IL2CPP_TYPE_GENERICINST
    public partial class PostTeamUpdateJob : DataModel
    {

        public static PostTeamUpdateJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostTeamUpdateJob() { Pointer= p0 };


            return value;
        }
    }
}
