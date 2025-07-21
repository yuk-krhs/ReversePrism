using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 dic                                      Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 000 MAX_FLAG                                 int IL2CPP_TYPE_I4
    // 000 MAX_IN_BOX                               int IL2CPP_TYPE_I4
    // 000 MAX_BOX                                  int IL2CPP_TYPE_I4
    // 000 MAX_VALUE                                int IL2CPP_TYPE_I4
    // 000 MAX_PROGRESS                             int IL2CPP_TYPE_I4
    // 008 flag                                     BitArray IL2CPP_TYPE_CLASS
    // 010 FlagOnTrigger                            ModelClassType BitArray BitArray BitArray Pointer
    // 018 LocalFlag                                ModelClassType BitArray BitArray BitArray Pointer
    // 020 Value                                    ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 checkQueue                               Queue`1<int> IL2CPP_TYPE_GENERICINST
    // 030 IsEnable                                 ModelPrimitiveType bool bool bool Bool
    // 038 EndCallback                              ModelClassType onTextEnd onTextEnd onTextEnd Pointer
    // 040 EmergeParentTransform                    ModelClassType Transform Transform Transform Pointer
    public partial class Status : DataModel
    {
        public BitArray?                                FlagOnTrigger                           { get; set; }
        public BitArray?                                LocalFlag                               { get; set; }
        public List<int>?                               Value                                   { get; set; }
        public bool                                     IsEnable                                { get; set; }
        public onTextEnd?                               EndCallback                             { get; set; }
        public Transform?                               EmergeParentTransform                   { get; set; }

        public static Status? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Status() { Pointer= p0 };

            value.FlagOnTrigger                             = GetObject<BitArray>(new IntPtr(p + 0x010), ReversePrism.DataModels.BitArray.FromPointer); // 0x10 FlagOnTrigger               ( ModelClassType BitArray BitArray BitArray Pointer )
            value.LocalFlag                                 = GetObject<BitArray>(new IntPtr(p + 0x018), ReversePrism.DataModels.BitArray.FromPointer); // 0x18 LocalFlag                   ( ModelClassType BitArray BitArray BitArray Pointer )
            value.Value                                     = GetInt32List(new IntPtr(p + 0x020)); // 0x20 Value                       ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.IsEnable                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 IsEnable                    ( ModelPrimitiveType bool bool bool Bool )
            value.EndCallback                               = GetObject<onTextEnd>(new IntPtr(p + 0x038), ReversePrism.DataModels.onTextEnd.FromPointer); // 0x38 EndCallback                 ( ModelClassType onTextEnd onTextEnd onTextEnd Pointer )
            value.EmergeParentTransform                     = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 EmergeParentTransform       ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
