using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Queue                                    00018663A3F0 ModelEnumType ModelRenderSettingQueue ModelRenderSettingQueue ModelRenderSettingQueue Int32
    // 018 UnityAction                              000186712270 ModelClassType UnityAction UnityAction UnityAction Pointer
    public partial class ModelRenderCameraSettingData : DataModel
    {
        public int                                      Id                                      { get; set; }
        public ModelRenderSettingQueue                  Queue                                   { get; set; }
        public UnityAction?                             UnityAction                             { get; set; }

        public static ModelRenderCameraSettingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModelRenderCameraSettingData() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A3FD8F28 0x10 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Queue                                     = (ModelRenderSettingQueue)GetInt32(new IntPtr(p + 0x014)); // 0245A3FD8F48 0x14 Queue                       ( 00018663A3F0 ModelEnumType ModelRenderSettingQueue ModelRenderSettingQueue ModelRenderSettingQueue Int32 )
            value.UnityAction                               = GetObject<UnityAction>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityAction.FromPointer); // 0245A3FD8F68 0x18 UnityAction                 ( 000186712270 ModelClassType UnityAction UnityAction UnityAction Pointer )

            return value;
        }
    }
}
