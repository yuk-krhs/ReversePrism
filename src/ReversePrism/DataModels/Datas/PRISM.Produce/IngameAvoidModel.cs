using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AvoidRate                                ModelPrimitiveType int int int Int32
    // 014 AvoidCount                               ModelPrimitiveType int int int Int32
    // 018 IsAvoided                                ModelPrimitiveType bool bool bool Bool
    // 020 onChangeAvoidRate                        Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 028 countAvoidWhenSecDic                     Dictionary`2<int, float> IL2CPP_TYPE_GENERICINST
    // 030 onUpdateAvoidRateBySec                   Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 Player                                   ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer
    // 040 AvoidResult                              ModelClassType InGameExecActionResult InGameExecActionResult InGameExecActionResult Pointer
    // 048 onAvoidSuccess                           Subject`1<InGameExecActionResult> IL2CPP_TYPE_GENERICINST
    // 050 RandomModel                              ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer
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

            value.AvoidRate                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 AvoidRate                   ( ModelPrimitiveType int int int Int32 )
            value.AvoidCount                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 AvoidCount                  ( ModelPrimitiveType int int int Int32 )
            value.IsAvoided                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 IsAvoided                   ( ModelPrimitiveType bool bool bool Bool )
            value.Player                                    = GetObject<IngamePlayerModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IngamePlayerModel.FromPointer); // 0x38 Player                      ( ModelClassType IngamePlayerModel IngamePlayerModel IngamePlayerModel Pointer )
            value.AvoidResult                               = GetObject<InGameExecActionResult>(new IntPtr(p + 0x040), ReversePrism.DataModels.InGameExecActionResult.FromPointer); // 0x40 AvoidResult                 ( ModelClassType InGameExecActionResult InGameExecActionResult InGameExecActionResult Pointer )
            value.RandomModel                               = GetObject<IngameRandomModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.IngameRandomModel.FromPointer); // 0x50 RandomModel                 ( ModelClassType IngameRandomModel IngameRandomModel IngameRandomModel Pointer )

            return value;
        }
    }
}
