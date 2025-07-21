using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TourId                                   ModelPrimitiveType int int int Int32
    // 018 CellModels                               ModelClassListType List`1<ProfileEventArchiveInfoTourPopupViewCellModel> List`1<ProfileEventArchiveInfoTourPopupViewCellModel> List<ProfileEventArchiveInfoTourPopupViewCellModel> Pointer
    public partial class ProfileEventArchiveInfoTourPopupViewModel : DataModel
    {
        public int                                      TourId                                  { get; set; }
        public List<ProfileEventArchiveInfoTourPopupViewCellModel>? CellModels                              { get; set; }

        public static ProfileEventArchiveInfoTourPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEventArchiveInfoTourPopupViewModel() { Pointer= p0 };

            value.TourId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 TourId                      ( ModelPrimitiveType int int int Int32 )
            value.CellModels                                = GetObjectList<ProfileEventArchiveInfoTourPopupViewCellModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfileEventArchiveInfoTourPopupViewCellModel.FromPointer); // 0x18 CellModels                  ( ModelClassListType List`1<ProfileEventArchiveInfoTourPopupViewCellModel> List`1<ProfileEventArchiveInfoTourPopupViewCellModel> List<ProfileEventArchiveInfoTourPopupViewCellModel> Pointer )

            return value;
        }
    }
}
