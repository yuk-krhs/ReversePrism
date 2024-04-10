using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InvalidId                                int IL2CPP_TYPE_I4
    // 010 UniqueId                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 HasChanged                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 ModelRenderCameraSettingDataList         000185CF40A8 ModelClassListType List`1<ModelRenderCameraSettingData> List`1<ModelRenderCameraSettingData> List<ModelRenderCameraSettingData> Pointer
    public partial class UpdateCameraSettingList : DataModel
    {
        public int                                      UniqueId                                { get; set; }
        public bool                                     HasChanged                              { get; set; }
        public List<ModelRenderCameraSettingData>?      ModelRenderCameraSettingDataList        { get; set; }

        public static UpdateCameraSettingList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateCameraSettingList() { Pointer= p0 };

            value.UniqueId                                  = GetInt32(new IntPtr(p + 0x010)); // 0245A3FD3810 0x10 UniqueId                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HasChanged                                = GetBool(new IntPtr(p + 0x014)); // 0245A3FD3830 0x14 HasChanged                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ModelRenderCameraSettingDataList          = GetObjectList<ModelRenderCameraSettingData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ModelRenderCameraSettingData.FromPointer); // 0245A3FD3850 0x18 ModelRenderCameraSettingDataList ( 000185CF40A8 ModelClassListType List`1<ModelRenderCameraSettingData> List`1<ModelRenderCameraSettingData> List<ModelRenderCameraSettingData> Pointer )

            return value;
        }
    }
}
