using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mission                                  ModelClassType ISpecialMissionMissionStatus ISpecialMissionMissionStatus ISpecialMissionMissionStatus Pointer
    public partial class SpecialMissionListViewModel : DataModel
    {
        public ISpecialMissionMissionStatus?            Mission                                 { get; set; }

        public static SpecialMissionListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionListViewModel() { Pointer= p0 };

            value.Mission                                   = GetObject<ISpecialMissionMissionStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISpecialMissionMissionStatus.FromPointer); // 0x10 Mission                     ( ModelClassType ISpecialMissionMissionStatus ISpecialMissionMissionStatus ISpecialMissionMissionStatus Pointer )

            return value;
        }
    }
}
