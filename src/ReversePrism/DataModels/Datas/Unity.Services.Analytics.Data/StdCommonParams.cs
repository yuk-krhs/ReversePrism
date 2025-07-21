using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GameStoreID                              ModelPrimitiveType string string string String
    // 018 GameBundleID                             ModelPrimitiveType string string string String
    // 020 Platform                                 ModelPrimitiveType string string string String
    // 028 UasUserID                                ModelPrimitiveType string string string String
    // 030 Idfv                                     ModelPrimitiveType string string string String
    // 038 <DeviceVolume>k__BackingField            Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 048 <BatteryLoad>k__BackingField             Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 058 BuildGuuid                               ModelPrimitiveType string string string String
    // 060 ClientVersion                            ModelPrimitiveType string string string String
    // 068 UserCountry                              ModelPrimitiveType string string string String
    // 070 ProjectID                                ModelPrimitiveType string string string String
    public partial class StdCommonParams : DataModel
    {
        public string                                   GameStoreID                             { get; set; }
        public string                                   GameBundleID                            { get; set; }
        public string                                   Platform                                { get; set; }
        public string                                   UasUserID                               { get; set; }
        public string                                   Idfv                                    { get; set; }
        public string                                   BuildGuuid                              { get; set; }
        public string                                   ClientVersion                           { get; set; }
        public string                                   UserCountry                             { get; set; }
        public string                                   ProjectID                               { get; set; }

        public static StdCommonParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StdCommonParams() { Pointer= p0 };

            value.GameStoreID                               = GetString(new IntPtr(p + 0x010)); // 0x10 GameStoreID                 ( ModelPrimitiveType string string string String )
            value.GameBundleID                              = GetString(new IntPtr(p + 0x018)); // 0x18 GameBundleID                ( ModelPrimitiveType string string string String )
            value.Platform                                  = GetString(new IntPtr(p + 0x020)); // 0x20 Platform                    ( ModelPrimitiveType string string string String )
            value.UasUserID                                 = GetString(new IntPtr(p + 0x028)); // 0x28 UasUserID                   ( ModelPrimitiveType string string string String )
            value.Idfv                                      = GetString(new IntPtr(p + 0x030)); // 0x30 Idfv                        ( ModelPrimitiveType string string string String )
            value.BuildGuuid                                = GetString(new IntPtr(p + 0x058)); // 0x58 BuildGuuid                  ( ModelPrimitiveType string string string String )
            value.ClientVersion                             = GetString(new IntPtr(p + 0x060)); // 0x60 ClientVersion               ( ModelPrimitiveType string string string String )
            value.UserCountry                               = GetString(new IntPtr(p + 0x068)); // 0x68 UserCountry                 ( ModelPrimitiveType string string string String )
            value.ProjectID                                 = GetString(new IntPtr(p + 0x070)); // 0x70 ProjectID                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
