using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AvoidRate                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 AvoidCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 IsAvoided                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 onChangeAvoidRate                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 028 countAvoidWhenSecDic                     Dictionary`2<int, float> IL2CPP_TYPE_GENERICINST
    // 030 onUpdateAvoidRateBySec                   Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 Player                                   0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 040 AvoidResult                              0001866D4D80 ModelClassType InGameExecActionResult InGameExecActionResult InGameExecActionResult Pointer
    // 048 onAvoidSuccess                           Subject`1<InGameExecActionResult> IL2CPP_TYPE_GENERICINST
    // 050 RandomModel                              0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
    public partial class IngameAvoidModel : DataModel
    {
        public int                                      AvoidRate                               { get; set; }
        public int                                      AvoidCount                              { get; set; }
        public bool                                     IsAvoided                               { get; set; }
        public IngamePlayerModel?                       Player                                  { get; set; }
        public InGameExecActionResult?                  AvoidResult                             { get; set; }
        public IngameRandomModel?                       RandomModel                             { get; set; }

        public static IngameAvoidModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngameAvoidModel() { Pointer= p0 };

            value.AvoidRate                                 = GetInt32(new IntPtr(p + 0x010)); // 024665BA9900 0x10 AvoidRate                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AvoidCount                                = GetInt32(new IntPtr(p + 0x014)); // 024665BA9920 0x14 AvoidCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsAvoided                                 = GetBool(new IntPtr(p + 0x018)); // 024665BA9940 0x18 IsAvoided                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Player                                    = GetObject<IngamePlayerModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 024665BA99C0 0x38 Player                      ( 0001866E5D10 ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.AvoidResult                               = GetObject<InGameExecActionResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.InGameExecActionResult.FromPointer); // 024665BA99E0 0x40 AvoidResult                 ( 0001866D4D80 ModelClassType InGameExecActionResult InGameExecActionResult InGameExecActionResult Pointer )
            value.RandomModel                               = GetObject<IngameRandomModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 024665BA9A20 0x50 RandomModel                 ( 0001866E6920 ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )

            return value;
        }
    }
}
