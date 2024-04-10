using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IsCompletion                             000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 IsActiveTutorial                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C ActiveTutorialType                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 ActiveUnitId                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 IsShowInfoTutorialPU                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 IsClearNewTutorial                       0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ProduceTutorialSaveData : DataModel
    {
        public List<int>?                               IsCompletion                            { get; set; }
        public int                                      IsActiveTutorial                        { get; set; }
        public int                                      ActiveTutorialType                      { get; set; }
        public int                                      ActiveUnitId                            { get; set; }
        public int                                      IsShowInfoTutorialPU                    { get; set; }
        public int                                      IsClearNewTutorial                      { get; set; }

        public static ProduceTutorialSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialSaveData() { Pointer= p0 };

            value.IsCompletion                              = GetInt32List(new IntPtr(p + 0x020)); // 0245A3A80D50 0x20 IsCompletion                ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IsActiveTutorial                          = GetInt32(new IntPtr(p + 0x028)); // 0245A3A80D70 0x28 IsActiveTutorial            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ActiveTutorialType                        = GetInt32(new IntPtr(p + 0x02C)); // 0245A3A80D90 0x2C ActiveTutorialType          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ActiveUnitId                              = GetInt32(new IntPtr(p + 0x030)); // 0245A3A80DB0 0x30 ActiveUnitId                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsShowInfoTutorialPU                      = GetInt32(new IntPtr(p + 0x034)); // 0245A3A80DD0 0x34 IsShowInfoTutorialPU        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsClearNewTutorial                        = GetInt32(new IntPtr(p + 0x038)); // 0245A3A80DF0 0x38 IsClearNewTutorial          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
