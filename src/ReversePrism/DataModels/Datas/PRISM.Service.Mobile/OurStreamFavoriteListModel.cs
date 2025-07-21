using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer
    // 018 FavoriteList                             ModelClassListType List`1<IArchiveStreamProgramStatus> List`1<IArchiveStreamProgramStatus> List<IArchiveStreamProgramStatus> Pointer
    public partial class OurStreamFavoriteListModel : DataModel
    {
        public StreamProgramService?                    Service                                 { get; set; }
        public List<IArchiveStreamProgramStatus>?       FavoriteList                            { get; set; }

        public static OurStreamFavoriteListModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamFavoriteListModel() { Pointer= p0 };

            value.Service                                   = GetObject<StreamProgramService>(new IntPtr(p + 0x010), ReversePrism.DataModels.StreamProgramService.FromPointer); // 0x10 Service                     ( ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer )
            value.FavoriteList                              = GetObjectList<IArchiveStreamProgramStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IArchiveStreamProgramStatus.FromPointer); // 0x18 FavoriteList                ( ModelClassListType List`1<IArchiveStreamProgramStatus> List`1<IArchiveStreamProgramStatus> List<IArchiveStreamProgramStatus> Pointer )

            return value;
        }
    }
}
