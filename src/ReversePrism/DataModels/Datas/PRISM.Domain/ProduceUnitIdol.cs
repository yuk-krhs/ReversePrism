using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceIdol                              ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer
    // 018 MstIdolSkillId                           ModelPrimitiveType int int int Int32
    public partial class ProduceUnitIdol : DataModel
    {
        public ProduceIdol?                             ProduceIdol                             { get; set; }
        public int                                      MstIdolSkillId                          { get; set; }

        public static ProduceUnitIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitIdol() { Pointer= p0 };

            value.ProduceIdol                               = GetObject<ProduceIdol>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceIdol.FromPointer); // 0x10 ProduceIdol                 ( ModelClassType ProduceIdol ProduceIdol ProduceIdol Pointer )
            value.MstIdolSkillId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolSkillId              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
