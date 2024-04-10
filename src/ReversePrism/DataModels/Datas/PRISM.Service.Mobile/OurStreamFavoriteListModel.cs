using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Service                                  0001865B4FD0 ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer
    // 018 FavoriteList                             000185CCD0E8 ModelClassListType List`1<ArchiveStreamProgram> List`1<ArchiveStreamProgram> List<ArchiveStreamProgram> Pointer
    public partial class OurStreamFavoriteListModel : DataModel
    {
        public StreamProgramService?                    Service                                 { get; set; }
        public List<ArchiveStreamProgram>?              FavoriteList                            { get; set; }

        public static OurStreamFavoriteListModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamFavoriteListModel() { Pointer= p0 };

            value.Service                                   = GetObject<StreamProgramService>(new IntPtr(p + 0x010), ReversePrism.DataModels.StreamProgramService.FromPointer); // 0246669010B8 0x10 Service                     ( 0001865B4FD0 ModelClassType StreamProgramService StreamProgramService StreamProgramService Pointer )
            value.FavoriteList                              = GetObjectList<ArchiveStreamProgram>(new IntPtr(p + 0x018), ReversePrism.DataModels.ArchiveStreamProgram.FromPointer); // 0246669010D8 0x18 FavoriteList                ( 000185CCD0E8 ModelClassListType List`1<ArchiveStreamProgram> List`1<ArchiveStreamProgram> List<ArchiveStreamProgram> Pointer )

            return value;
        }
    }
}
