using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Anim                                     0001866B1B90 ModelClassType Animation Animation Animation Pointer
    // 018 Resumef                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 GRID_01                                  int IL2CPP_TYPE_I4
    // 000 GRID_02                                  int IL2CPP_TYPE_I4
    // 000 GRID_04                                  int IL2CPP_TYPE_I4
    // 000 GRID_08                                  int IL2CPP_TYPE_I4
    // 000 GRID_16                                  int IL2CPP_TYPE_I4
    // 000 GRID_05                                  int IL2CPP_TYPE_I4
    // 000 GRID_06                                  int IL2CPP_TYPE_I4
    // 000 GRID_11                                  int IL2CPP_TYPE_I4
    // 000 GRID_03                                  int IL2CPP_TYPE_I4
    // 000 GRID_12                                  int IL2CPP_TYPE_I4
    // 000 motion                                   MotionCell[] IL2CPP_TYPE_SZARRAY
    // 008 motion_adjust                            float[] IL2CPP_TYPE_SZARRAY
    // 010 ActionLength                             000185B7D8C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ChemicalLightMotion : DataModel
    {
        public Animation?                               Anim                                    { get; set; }
        public bool                                     Resumef                                 { get; set; }
        public List<int>?                               ActionLength                            { get; set; }

        public static ChemicalLightMotion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChemicalLightMotion() { Pointer= p0 };

            value.Anim                                      = GetObject<Animation>(new IntPtr(p + 0x010), ReversePrism.DataModels.Animation.FromPointer); // 024664EC0F10 0x10 Anim                        ( 0001866B1B90 ModelClassType Animation Animation Animation Pointer )
            value.Resumef                                   = GetBool(new IntPtr(p + 0x018)); // 024664EC0F30 0x18 Resumef                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ActionLength                              = GetInt32List(new IntPtr(p + 0x010)); // 024664EC10D0 0x10 ActionLength                ( 000185B7D8C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
